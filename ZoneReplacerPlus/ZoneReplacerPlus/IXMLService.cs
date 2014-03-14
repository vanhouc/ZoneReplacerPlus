namespace ZoneReplacerPlus
{
    public interface IXMLService
    {
        string[] GetChildValues(string[] elementChain, string childProperty);

        string GetElementValue(string[] elementChain);
    }
}