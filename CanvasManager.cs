namespace GoodOlDays;

internal static class CanvasManager
{
    public static void SpawnCanvas()
    {
        var canvasGo = new GameObject("BWModding");
        ModConsole.Msg("Created canvas gameobject", 1);
        var canvas = canvasGo.AddComponent<Canvas>();
        ModConsole.Msg("Added canvas component", 1);
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        ModConsole.Msg("Set canvas render mode", 1);

        var scaler = canvasGo.AddComponent<CanvasScaler>();
        ModConsole.Msg("Added canvas scaler component", 1);
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        ModConsole.Msg("Set canvas scaler ui scale mode", 1);
        scaler.referenceResolution = new Vector2(1920, 1080);
        ModConsole.Msg("Set canvas scaler reference resolution", 1);
        scaler.matchWidthOrHeight = 1;
        ModConsole.Msg("Set canvas scaler match width or height", 1);
        
        var textGo = new GameObject("PlayermodelText");
        ModConsole.Msg("Created playermodel text gameobject", 1);
        BoneMenu.PlayerModelText = textGo;
        ModConsole.Msg("Set playermodel text gameobject", 1);
        textGo.transform.parent = canvasGo.transform;
        ModConsole.Msg("Set playermodel text parent", 1);
        textGo.transform.localPosition = new Vector2(-850, 515);
        ModConsole.Msg("Set playermodel text local position", 1);
        textGo.transform.localRotation = Quaternion.Euler(0, 0, 0);
        ModConsole.Msg("Set playermodel text local rotation", 1);

        var tmpro = textGo.AddComponent<TextMeshProUGUI>();
        ModConsole.Msg("Added textmeshpro component", 1);
        tmpro.text = "ANY PLAYER MODELS USED ARE NOT OFFICIAL";
        ModConsole.Msg("Set textmeshpro text", 1);
        tmpro.color = Color.yellow;
        ModConsole.Msg("Set textmeshpro color", 1);
        tmpro.fontSize = 45;
        ModConsole.Msg("Set textmeshpro font size", 1);
        tmpro.overflowMode = TextOverflowModes.Overflow;
        ModConsole.Msg("Set textmeshpro overflow mode", 1);
        tmpro.enableWordWrapping = false;
        ModConsole.Msg("Set textmeshpro enable word wrapping", 1);

        var textGo2 = new GameObject("CustomItemsText");
        ModConsole.Msg("Created custom items text gameobject", 1);
        BoneMenu.CustomItemsText = textGo2;
        ModConsole.Msg("Set custom items text gameobject", 1);
        textGo2.transform.parent = canvasGo.transform;
        ModConsole.Msg("Set custom items text parent", 1);
        textGo2.transform.localPosition = new Vector2(160, -515);
        ModConsole.Msg("Set custom items text local position", 1);
        textGo2.transform.localRotation = Quaternion.Euler(0, 0, 0);
        ModConsole.Msg("Set custom items text local rotation", 1);

        var tmpro2 = textGo2.AddComponent<TextMeshProUGUI>();
        ModConsole.Msg("Added textmeshpro component", 1);
        tmpro2.text = "NOT ALL WEAPONS/ITEMS ARE OFFICIAL";
        ModConsole.Msg("Set textmeshpro text", 1);
        tmpro2.color = Color.red;
        ModConsole.Msg("Set textmeshpro color", 1);
        tmpro2.fontSize = 45;
        ModConsole.Msg("Set textmeshpro font size", 1);
        tmpro2.overflowMode = TextOverflowModes.Overflow;
        ModConsole.Msg("Set textmeshpro overflow mode", 1);
        tmpro2.enableWordWrapping = false;
        ModConsole.Msg("Set textmeshpro enable word wrapping", 1);
    }
}