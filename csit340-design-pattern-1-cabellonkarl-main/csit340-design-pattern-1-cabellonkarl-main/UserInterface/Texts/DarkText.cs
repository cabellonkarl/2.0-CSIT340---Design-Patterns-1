using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Texts
{
    public class DarkText : Text
    {
        public override string CreateText() => _text.ToUpper();
    }
}/// <summary>
 /// [DarkText(product)]
 /// <insert simply override the CreateText to show an ALL CAPS word THIS IS THE TEXT. this is a class for the DarkText which means to have the text all big letters>
 /// </summary