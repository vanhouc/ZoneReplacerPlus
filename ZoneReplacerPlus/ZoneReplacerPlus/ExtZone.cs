namespace ZoneReplacerPlus
{
    public class ExtZone : Zone
    {
        private string _click;
        private string _doubleClick;
        private string _extField;

        private string _rightClick;

        private string _type;

        public ExtZone(string[] receivers, string top, string left, string height, string width, string columnCount, string extField, string type)
            : base(receivers, top, left, height, width, columnCount)
        {
            ExtField = extField;
            Type = type;
        }

        public string Click
        {
            get { return _click; }
            set { _click = value; }
        }

        public string DoubleClick
        {
            get { return _doubleClick; }
            set { _doubleClick = value; }
        }

        public string ExtField
        {
            get { return _extField; }
            set { _extField = value; }
        }

        public string RightClick
        {
            get { return _rightClick; }
            set { _rightClick = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}