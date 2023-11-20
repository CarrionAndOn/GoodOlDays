namespace GoodOlDays.Melon;

internal static class Preferences
{
    private static readonly MelonPreferences_Category GlobalCategory = MelonPreferences.CreateCategory("Global");
    public static readonly MelonPreferences_Category OwnCategory = MelonPreferences.CreateCategory("GoodOlDays");
        
    public static MelonPreferences_Entry<int> LoggingMode { get; private set; }
    public static MelonPreferences_Entry<bool> AutoEnable { get; private set; }

    public static void Setup()
    {
        LoggingMode = GlobalCategory.GetEntry<int>("LoggingMode") ?? GlobalCategory.CreateEntry("LoggingMode", 0, "Logging Mode", "The level of logging to use. 0 = Important Only, 1 = All");
        AutoEnable = OwnCategory.GetEntry<bool>("AutoEnable") ?? OwnCategory.CreateEntry("AutoEnable", true, "Auto Enable", "Automatically enable the mod on startup");
        GlobalCategory.SetFilePath(MelonUtils.UserDataDirectory+"/WeatherElectric.cfg");
        GlobalCategory.SaveToFile(false);
        OwnCategory.SetFilePath(MelonUtils.UserDataDirectory+"/WeatherElectric.cfg");
        OwnCategory.SaveToFile(false);
        ModConsole.Msg("Finished preferences setup for GoodOlDays", 1);
    }
}