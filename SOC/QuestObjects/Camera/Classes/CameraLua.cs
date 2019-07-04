
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOC.Classes.Lua;

namespace SOC.QuestObjects.Camera
{
    class CameraLua
    {
        internal static void GetMain(CameraDetail detail, MainLua mainLua)
        {
            mainLua.AddToQuestTable(BuildCameraList(detail.cameras));
            if (detail.cameras.Count > 0)
            {

                mainLua.AddToQStep_Start_OnEnter("this.SetCameraAttributes()");
                mainLua.AddCodeToScript($@"
function this.SetCameraAttributes()
  GameObject.SendCommand({{type=""TppSecurityCamera2""}}, {{id=""SetDevelopLevel"", developLevel=6}})
  for i,cameraInfo in ipairs(this.QUEST_TABLE.cameraList)do
    local gameObjectId= GetGameObjectId(cameraInfo.name)
    if gameObjectId~=GameObject.NULL_ID then
	  if cameraInfo.commands then
        for j,cameraCommand in ipairs(cameraInfo.commands)do
	      GameObject.SendCommand(gameObjectId, cameraCommand)
	    end
	  end
    end
  end
end");

                foreach (Camera cam in detail.cameras)
                {
                    if (cam.isTarget)
                        mainLua.AddToTargetList(cam.GetObjectName());
                }
            }
        }

        private static string BuildCameraList(List<Camera> cameras)
        {
            StringBuilder cameraListBuilder = new StringBuilder("cameraList = {");

            if (cameras.Count == 0)
                cameraListBuilder.Append(@"
        nil ");
            else
            {
                foreach (Camera camera in cameras)
                {
                    string setCPCommand = @"{id = ""SetCommandPost"", cp=CPNAME}";
                    string typeCommand = $@"{{id=""{(camera.weapon ? "SetGunCamera" : "NormalCamera")}""}} ";
                    string enabledCommand = @"{id=""SetEnabled"", enabled=true}";

                    cameraListBuilder.Append($@"
        {{
            name = ""{camera.GetObjectName()}"",
            commands = {{{setCPCommand}, {typeCommand}, {enabledCommand}}},");
                    cameraListBuilder.Append(@"
        },");
                }
            }
                
            cameraListBuilder.Append(@"
    }");
            return cameraListBuilder.ToString();
        }
    }
}
