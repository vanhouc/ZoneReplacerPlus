namespace ZoneReplacerPlus
{
    public class Zone
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

        public string BorderStyle
        {
            get { return _borderStyle; }
            set { _borderStyle = value; }
        }

        public string ColumnCount
        {
            get { return _columnCount; }
            set { _columnCount = value; }
        }

        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public string Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public string[] Receivers
        {
            get { return _receivers; }
            set { _receivers = value; }
        }

        public string Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}