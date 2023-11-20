namespace GoodOlDays;

internal partial class Main : MelonMod
{
    public override void OnInitializeMelon()
    {
        ModConsole.Setup(LoggerInstance);
        Preferences.Setup();
        BoneMenu.Setup();
        Hooking.OnLevelInitialized += OnLevelLoad;
    }

    private static void OnLevelLoad(LevelInfo levelInfo)
    {
        if (!Preferences.AutoEnable.Value) return;
        ModConsole.Msg("Spawning canvas", 1);
        CanvasManager.SpawnCanvas();
    }
}