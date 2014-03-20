using System.Xml.Linq;
namespace ZoneReplacerPlus
{
    public interface IXMLService
    {
        string[] GetChildValues(string[] elementChain, string childProperty);

        XElement GetElement(string[] elementChain);

        //XElement[] GetElements(string[] elementChain);
    }
}