using System.Collections.Generic;

namespace PassportLib
{
    public class PassportGroup
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<PassportCard> Cards = new List<PassportCard>();

        public PassportGroup(string groupName)
        {
            Name = groupName;
        }
    }
}
