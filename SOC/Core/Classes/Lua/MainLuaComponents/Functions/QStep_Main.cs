using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Lua
{
    public class QStep_Main : LuaMainComponent
    {
        List<QStep_Message> messageList = new List<QStep_Message>();

        public void Add(QStep_Message msg)
        {
            messageList.Add(msg);
        }

        public bool Contains(QStep_Message msg)
        {
            return (messageList.Exists(message => message.Equals(msg)));
        }

        public override string GetComponent()
        {
            return $@"
quest_step.QStep_Main = {{
  Messages = function( self )
    return
      StrCode32Table {{
{GetMessagesFormatted()}
      }}
  end,
  OnEnter = function()

    Fox.Log(""QStep_Main OnEnter"")
  end,
  OnLeave = function()
    Fox.Log(""QStep_Main OnLeave"")
  end,
}}";
        }

        public string GetMessagesFormatted()
        {
            List<string> categories = new List<string>();
            foreach(QStep_Message msg in messageList)
            {
                if (!categories.Contains(msg.GetCategory()))
                    categories.Add(msg.GetCategory());
            }
            StringBuilder formattedMessageBuilder = new StringBuilder();
            foreach(string category in categories)
            {
                formattedMessageBuilder.Append($@"
        {category} = {{");
                foreach(QStep_Message msg in messageList)
                {
                    if (msg.GetCategory() != category)
                        continue;
                    formattedMessageBuilder.Append($@"
          {{{msg.GetMessageFormatted()}
          }},");
                }
                formattedMessageBuilder.Append(@"
        },");
            }
            return formattedMessageBuilder.ToString();
        }
    }

    public class QStep_Message
    {
        string msgCategory;
        string msgName;
        string msgSender;
        string msgFunc;

        public QStep_Message(string category, string name, string function)
        {
            msgCategory = category; msgName = name; msgFunc = function; msgSender = "";
        }

        public QStep_Message(string category, string name, string sender, string function)
        {
            msgCategory = category; msgName = name; msgFunc = function; msgSender = sender;
        }

        public string GetCategory()
        {
            return msgCategory;
        }

        public string GetMessageFormatted()
        {
            StringBuilder msgBuilder = new StringBuilder($@"
            msg = {msgName}, {(msgSender == "" ? "" : $@"
            sender = {msgSender}, ")}
            func = {msgFunc}");

            return msgBuilder.ToString();
        }

        public bool Equals(QStep_Message msg)
        {
            if (msgCategory == msg.msgCategory)
                if (msgName == msg.msgName)
                    if (msgSender == msg.msgSender)
                        return msgFunc == msg.msgFunc;
            return false;
        }
    }
}
