using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu.Elements;
using BoneLib.BoneMenu;
using UnityEngine;

namespace GoodOlDays
{
    internal partial class Main : MelonMod
    {
        public override void OnEarlyInitializeMelon()
        {
            base.OnEarlyInitializeMelon();
        }

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Hooking.OnLevelInitialized += WeAreSoBack;
            MenuCategory rootCategory = MenuManager.RootCategory;
            rootCategory.CreateFunctionElement("Toggle BW Text", Color.white, delegate ()
            {
                this.ClutterToggled = !this.ClutterToggled;
                GameObject gameObject = GameObject.Find("ClutterLolCanvas");
                bool flag = gameObject && this.ClutterToggled;
                if (flag)
                {
                    gameObject.SetActive(true);
                }
                else
                {
                    gameObject.SetActive(false);
                }
            });
        }
        public void WeAreSoBack(LevelInfo levelInfo)
        {
            WarningText.ClutterYourScreen();
        }
        public override void OnLateInitializeMelon()
        {
            base.OnLateInitializeMelon();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
        }

        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();
        }

        public override void OnLateUpdate()
        {
            base.OnLateUpdate();
        }
        private bool ClutterToggled = true;
    }
}
