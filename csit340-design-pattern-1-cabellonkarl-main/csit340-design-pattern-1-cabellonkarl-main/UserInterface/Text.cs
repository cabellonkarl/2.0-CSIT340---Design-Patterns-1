using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserInterface
{
    public abstract class Text
    {
        protected readonly string? _text = "this is a text";

        public abstract string CreateText();

    }
}

/// <summary>
/// [Text(product)]
/// <insert abstract class for classes which is the class that generates the Dark and Light Text for the Client. 
/// why I used abstract classes with Text is because the Client does not want
/// the specifics but it only wants the interface and abstract classes which has access to the concrete ones below it.>
/// </summary