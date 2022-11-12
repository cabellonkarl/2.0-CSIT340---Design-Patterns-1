using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Texts;
using UserInterface.Buttons;

namespace UserInterface.Factories
{
    public class LightFactory : IUserInterfaceFactory
    {
        public LightFactory()
        {
        }
        public Text NewText() => new LightText();

        public Button NewButton() => new LightButton();

    }
}
/// <summary>
/// [LightFactory(product)]
/// <insert a class which inherits the IUserInterfaceFactory methods but makes the method only for Light Family which is LightText and LightButton.
/// This means that LightFactory Class is only for the Light fam>
/// </summary