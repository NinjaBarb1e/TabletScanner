using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CameraBarcodeWF
{
    public class Meal
    {
        DateTime _date;
        string _name;

        [XmlElement]
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        [XmlElement]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
