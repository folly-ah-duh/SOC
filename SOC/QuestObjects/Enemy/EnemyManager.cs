using SOC.Classes.Fox2;
using SOC.QuestObjects.Common;
using System;
using System.Collections.Generic;
using SOC.Forms.Pages;
using SOC.Classes.Lua;
using SOC.Classes.Assets;
using SOC.Classes.Common;

namespace SOC.QuestObjects.Enemy
{
    class EnemyManager : NonLocationalManager
    {
        static EnemyControl control = new EnemyControl();

        static EnemyVisualizer visualizer = new EnemyVisualizer(control);

        public EnemyManager(EnemyDetail detail) : base(detail, visualizer) { }

        public override void AddToDefinitionLua(DefinitionLua definitionLua)
        {
            EnemyLua.GetDefinition((EnemyDetail)detail, definitionLua);
        }

        public override void AddToMainLua(MainLua mainLua)
        {
            EnemyLua.GetMain((EnemyDetail)detail, mainLua);
        }

        public override void AddToAssets(FileAssets fileAssets)
        {
            EnemyAssets.GetEnemyAssets((EnemyDetail)detail, fileAssets);
        }
    }
}
