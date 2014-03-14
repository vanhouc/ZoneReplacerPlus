using System.Xml.Linq;

namespace ZoneReplacerPlus
{
    public interface IXDocProvider
    {
        XDocument Doc
        {
            get;
        }
    }
}