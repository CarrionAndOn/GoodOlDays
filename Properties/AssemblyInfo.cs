using System.Reflection;
using GoodOlDays;
using MelonLoader;

[assembly: AssemblyTitle(GoodOlDays.Main.Description)]
[assembly: AssemblyDescription(GoodOlDays.Main.Description)]
[assembly: AssemblyCompany(GoodOlDays.Main.Company)]
[assembly: AssemblyProduct(GoodOlDays.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + GoodOlDays.Main.Author)]
[assembly: AssemblyTrademark(GoodOlDays.Main.Company)]
[assembly: AssemblyVersion(GoodOlDays.Main.Version)]
[assembly: AssemblyFileVersion(GoodOlDays.Main.Version)]
[assembly: MelonInfo(typeof(GoodOlDays.Main), GoodOlDays.Main.Name, GoodOlDays.Main.Version, GoodOlDays.Main.Author, GoodOlDays.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]