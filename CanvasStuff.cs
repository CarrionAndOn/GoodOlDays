using TMPro;
using UnityEngine;
using UnityEngine.UI;
using BoneMenuStuff;

namespace GoodOlDays
{
    internal static class BWMod
    {
        public static void SpawnCanvas()
        {
            // Create the canvas
            GameObject canvasGO = new GameObject("BWModding");
            // Cache the gameobject of the canvas to be able to toggle it later
            BoneMenu.spawnedCanvas = canvasGO;
            Canvas canvas = canvasGO.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            CanvasScaler scaler = canvasGO.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 1;

            // Create playermodel text
            GameObject textGO = new GameObject("PlayermodelText");
            // Cache playermodel text gameobject for toggling
            BoneMenu.playerModelText = textGO;
            textGO.transform.parent = canvasGO.transform;
            textGO.transform.localPosition = new Vector2(-850, 515);
            textGO.transform.localRotation = Quaternion.Euler(0, 0, 0);

            TextMeshProUGUI tmpro = textGO.AddComponent<TextMeshProUGUI>();
            tmpro.text = "ANY PLAYER MODELS USED ARE NOT OFFICIAL";
            tmpro.color = Color.yellow;
            tmpro.fontSize = 45;
            tmpro.overflowMode = TextOverflowModes.Overflow;
            tmpro.enableWordWrapping = false;

            // Create custom items text
            GameObject textGO2 = new GameObject("CustomItemsText");
            // Cache custom item text for toggling
            BoneMenu.customItemsText = textGO2;
            textGO2.transform.parent = canvasGO.transform;
            textGO2.transform.localPosition = new Vector2(160, -515);
            textGO2.transform.localRotation = Quaternion.Euler(0, 0, 0);

            TextMeshProUGUI tmpro2 = textGO2.AddComponent<TextMeshProUGUI>();
            tmpro2.text = "NOT ALL WEAPONS/ITEMS ARE OFFICIAL";
            tmpro2.color = Color.red;
            tmpro2.fontSize = 45;
            tmpro2.overflowMode = TextOverflowModes.Overflow;
            tmpro2.enableWordWrapping = false;
        }
    }
}