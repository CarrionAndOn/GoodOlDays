using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu.Elements;
using BoneLib.BoneMenu;
using UnityEngine;

namespace GoodOlDays
{
    internal partial class Main : MelonMod
    {

        public static GameObject spawnedCanvas;

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            Hooking.OnLevelInitialized += WeAreSoBack;
            MenuCategory rootCategory = MenuManager.RootCategory;
            rootCategory.CreateFunctionElement("Toggle BW Text", Color.yellow, delegate ()
            {
                ClutterToggled = !ClutterToggled;
                if (spawnedCanvas)
                {
                    spawnedCanvas.SetActive(ClutterToggled);
                }
            });
        }
        public void WeAreSoBack(LevelInfo levelInfo)
        {
            WarningText.ClutterYourScreen();
        }

        public override void OnLateUpdate()
        {
            base.OnLateUpdate();
        }
        private bool ClutterToggled = true;
    }
}
