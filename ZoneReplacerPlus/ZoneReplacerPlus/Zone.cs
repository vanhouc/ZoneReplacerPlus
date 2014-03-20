using System.Xml.Linq;
using System.Linq;
using System;
namespace ZoneReplacerPlus
{
    public class Zone : ObservableObject
    {
        private string _borderStyle;
        private string _columnCount;
        private string _height;
        private string _left;
        private string[] _receivers;

        private string _top;

        private string _width;

        public Zone(string[] receivers, string top, string left, string height, string width, string columnCount)
        {
            Receivers = receivers;
            Top = top;
            Left = left;
            Height = height;
            Width = width;
            ColumnCount = columnCount;
            BorderStyle = "0";
        }

        public Zone(string[] receivers, string top, string left, string height, string width, string columnCount, string borderStyle)
            : this(receivers, top, left, height, width, columnCount)
        {
            BorderStyle = borderStyle;
        }
        private XElement zoneXML;

        public XElement ZoneXML
        {
            get { return zoneXML; }
            set 
            { 
                zoneXML = value;
                RaisePropertyChanged("ZoneXML");
            }
        }
        

        public string BorderStyle
        {
            get { return _borderStyle; }
            set 
            { 
                _borderStyle = value;
                ZoneXML.Element("BorderStyle").Value = value;
                RaisePropertyChanged("BorderStyle");
            }
        }

        public string ColumnCount
        {
            get { return _columnCount; }
            set 
            {
                _columnCount = value;
                ZoneXML.Element("ColumnCount").Value = value;
                RaisePropertyChanged("ColumnCount");
            }
        }

        public string Height
        {
            get { return _height; }
            set 
            {
                _height = value;
                ZoneXML.Element("Height").Value = value;
                RaisePropertyChanged("Height");
            }
        }

        public string Left
        {
            get { return _left; }
            set 
            {
                _left = value;
                ZoneXML.Element("Left").Value = value;
                RaisePropertyChanged("Left");
            }
        }

        public string[] Receivers
        {
            get { return _receivers; }
            set 
            {
                _receivers = value;
                string receiverString = String.Empty;
                foreach (string receiver in value)
                {
                    receiverString += receiver + ",";
                }
                ZoneXML.Element("Receivers").Value = receiverString;
                RaisePropertyChanged("Receivers");
            }
        }

        public string Top
        {
            get { return _top; }
            set 
            {
                _top = value;
                ZoneXML.Element("Top").Value = value;
                RaisePropertyChanged("Top");
            }
        }

        public string Width
        {
            get { return _width; }
            set 
            { 
                _width = value;
                ZoneXML.Element("Width").Value = value;
                RaisePropertyChanged("Top");
            }
        }
    }
}