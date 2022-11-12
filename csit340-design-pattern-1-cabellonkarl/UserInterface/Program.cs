using UserInterface;
using UserInterface.ThemeRendererGenerators;

Console.Write("Input theme (dark/light): ");
var theme = Console.ReadLine();

switch (theme)
{
    case "light":
        InterfaceThemeRendererGenerator ui = new LightInterfaceThemeRendererGenerator();
        ui.RenderUI();
        break;
    case "dark":
        InterfaceThemeRendererGenerator ux = new DarkInterfaceThemeRendererGenerator();
        ux.RenderUI();
        break;
    default:
        Console.WriteLine("Invalid theme");
        break;
}

// <summary>
/// [Program.Cs]
/// <insert makes you pick which is dark and light and if none of the two it would give you and error that it is invalid>
/// </summary>