using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public abstract class InterfaceThemeRendererGenerator 
    {
    
        protected IUserInterfaceFactory _uiFactory;

        public InterfaceThemeRendererGenerator(IUserInterfaceFactory factory)
        {
            _uiFactory = factory;
        }

        public void RenderUI()
        {
            Text text = _uiFactory.NewText();
            Button button = _uiFactory.NewButton();

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(text.CreateText());
            Console.WriteLine(button.CreateButton());
        }
    }
}
/// <summary>
/// [CLIENT]
/// <insert basically the client of the Project it gets NewText and NewButton from the factories which the Button and Text abstract classes are connected. 
/// The client here does not care about the specifics which makes these and abstract factory method since it does not specify the concrete subclasses.
/// Used abstract class based on sirs discussion so when I pass it to the program I do not need to pass another Render just get the base(new RenderUI()) >
/// </summary>