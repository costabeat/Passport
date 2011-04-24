namespace PassportLib
{
    public class PassportItem
    {
        private string _param = "";
        public string Param
        {
            get { return _param; }
            set { _param = value; }
        }

        private string _value = "";
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public PassportItem(string param, string value)
        {
            Param = param;
            Value = value;
        }
    }
}
