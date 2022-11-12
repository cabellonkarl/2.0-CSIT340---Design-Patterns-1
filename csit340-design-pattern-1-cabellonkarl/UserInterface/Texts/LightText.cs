using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Texts
{
    public class LightText : Text
    {
        public override string CreateText() => _text.ToLower();
    }
}
/// <summary>
/// [LightText(product)]
/// <insert simply override the CreateText to show an lower caps. this is a class for the LightText which means to have the text all lower caps>
/// </summary