using BoneLib.BoneMenu.Elements;
using UnityEngine;

namespace BWModding
{
    internal class BoneMenu
    {
        // Create all our variables
        private static bool AllToggled = true;
        private static bool PMToggled = true;
        private static bool CIToggled = true;
        public static GameObject spawnedCanvas;
        public static GameObject playerModelText;
        public static GameObject customItemsText;
        public static void CreateBoneMenu(MenuCategory rootCategory)
        {
            // Create toggle all bonemenu button
            rootCategory.CreateFunctionElement(
                "Toggle All",
                Color.white,
                () =>
                {
                    AllToggled = !AllToggled;
                    if (spawnedCanvas)
                    {
                        spawnedCanvas.SetActive(AllToggled);
                    }
                }
            );
            // Create toggle PMs bonemenu button
            rootCategory.CreateFunctionElement(
                "Toggle Player Models",
                Color.yellow,
                () =>
                {
                    PMToggled = !PMToggled;
                    if (playerModelText)
                    {
                        playerModelText.SetActive(PMToggled);
                    }
                }
            );
            // Create toggle CIs bonemenu button
            rootCategory.CreateFunctionElement(
                "Toggle Custom Items",
                Color.red,
                () =>
                {
                    CIToggled = !CIToggled;
                    if (customItemsText)
                    {
                        customItemsText.SetActive(CIToggled);
                    }
                }
            );
        }
    }
}