using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu;
using UnityEngine;

namespace GoodOlDays
{
    internal partial class Main : MelonMod
    {

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            // Create a hook to detect when the level has fully loaded.
            Hooking.OnLevelInitialized += OnLevelLoad;
            // Generate BoneMenu stuff
            BoneMenuStuff.BoneMenu.CreateBoneMenu(MenuManager.CreateCategory("BW Mod Text", Color.yellow));
        }
        public void OnLevelLoad(LevelInfo levelInfo)
        {
            // Start all the canvas spawning shit.
            BWMod.SpawnCanvas();
        }
    }
}
