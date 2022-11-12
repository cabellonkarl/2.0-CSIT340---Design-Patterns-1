using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public interface IUserInterfaceFactory
    {
        public Text NewText();
        public Button NewButton();
    }
}
// <summary>
/// [Iuserinterfacefactory(product)]
/// <insert interface class for creating new objects the one below these like DarkFactory and LightFactory are the ones which implements the interface the methods as you can see
/// are only NewText and NewButton since its up to the client what he wants if its dark or light and it these interface it does not show any specific like dark or light 
/// It does not have the specifics .>
/// </summary>