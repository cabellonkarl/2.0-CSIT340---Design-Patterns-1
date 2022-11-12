using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Texts;
using UserInterface.Buttons;

namespace UserInterface.Factories
{
    public class DarkFactory : IUserInterfaceFactory
    {
        public DarkFactory()
        {
        }

        public Text NewText() => new DarkText();

        public Button NewButton() => new DarkButton();

    }
}
/// <summary>
/// [DarKFactory(product)]
/// <insert a class which inherits the IUserInterfaceFactory methods but makes the method only for Dark Family which is DarkText and DarkButton>
/// </summary