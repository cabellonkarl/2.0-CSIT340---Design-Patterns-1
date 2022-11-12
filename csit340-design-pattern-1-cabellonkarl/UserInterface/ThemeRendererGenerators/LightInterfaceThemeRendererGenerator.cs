using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Factories;

namespace UserInterface.ThemeRendererGenerators
{
    public class LightInterfaceThemeRendererGenerator : InterfaceThemeRendererGenerator
    {
        public LightInterfaceThemeRendererGenerator() : base(new LightFactory())
        {
        }
    }
}
/// <summary>
/// [CLIENT]
/// <insert this is the sub class of the InterfaceThemeGenerator which is the LightInterfaceThemeGenerator which only passes the dark fam 
/// as you can see since it inherits from  InterfaceThemeRendererGenerator so we can get everything from it but these sub class specifies only the LIght Fam. 
/// so iya e generate is only the LightFactory which is why base(new LightFactory())>
/// </summary>