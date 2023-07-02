using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GoodOlDays
{
    internal static class WarningText
    {
        public static void ClutterYourScreen()
        {
            Canvas canvas = CreateCanvas();

            CreateText(canvas, "NOT ALL WEAPONS/ITEMS ARE OFFICIAL", Color.red, 45, new Vector2(160, -515), 0);
            CreateText(canvas, "ANY PLAYER MODELS USED ARE NOT OFFICIAL", Color.yellow, 45, new Vector2(-850, 515), 0);
        }

        private static Canvas CreateCanvas()
        {
            GameObject canvasGO = new GameObject("ClutterLolCanvas");
            Canvas canvas = canvasGO.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;

            CanvasScaler scaler = canvasGO.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 1;

            return canvas;
        }

        private static void CreateText(Canvas canvas, string text, Color color, float fontSize, Vector2 position, float zRotation)
        {
            GameObject textGO = new GameObject("ClutterLolText");
            textGO.transform.parent = canvas.transform;
            textGO.transform.localPosition = position;
            textGO.transform.localRotation = Quaternion.Euler(0, 0, zRotation);

            TextMeshProUGUI tmpro = textGO.AddComponent<TextMeshProUGUI>();
            tmpro.text = text;
            tmpro.color = color;
            tmpro.fontSize = fontSize;
            tmpro.overflowMode = TextOverflowModes.Overflow;
            tmpro.enableWordWrapping = false;
        }
    }
}