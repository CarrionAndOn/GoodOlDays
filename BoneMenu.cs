namespace GoodOlDays;

internal static class BoneMenu
{
    public static GameObject CustomItemsText;
    public static GameObject PlayerModelText;
    public static void Setup()
    {
        MenuCategory mainCat = MenuManager.CreateCategory("Weather Electric", "#6FBDFF");
        MenuCategory menuCategory = mainCat.CreateCategory("GoodOlDays", "#e2b203");
        menuCategory.CreateFunctionElement("Toggle All", Color.white, ToggleCanvas);
        menuCategory.CreateFunctionElement("Toggle Custom Items Text", Color.red, ToggleCustomItemsText);
        menuCategory.CreateFunctionElement("Toggle Player Model Text", Color.yellow, TogglePlayerModelText);
        SubPanelElement subPanelElement = menuCategory.CreateSubPanel("Settings", "#B0B0B0");
        subPanelElement.CreateBoolPreference("Auto Enable", Color.white, Preferences.AutoEnable, Preferences.OwnCategory);
    }

    private static void ToggleCanvas()
    {
        ToggleCustomItemsText();
        TogglePlayerModelText();
    }

    private static void ToggleCustomItemsText()
    {
        CustomItemsText.SetActive(!CustomItemsText.activeSelf);
    }

    private static void TogglePlayerModelText()
    {
        PlayerModelText.SetActive(!PlayerModelText.activeSelf);
    }
}