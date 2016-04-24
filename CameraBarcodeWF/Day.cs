using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CameraBarcodeWF
{
    [XmlRoot()]
    public class Day
    {
        DateTime _date;
        List<Meal> _meals;
        List<Activity> _activities;

        public Day()
        {
            _meals = new List<Meal>();
            _activities = new List<Activity>();
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<Meal> Meals
        {
            get { return _meals; }
            set { _meals = value; }
        }

        public List<Activity> Activities
        {
            get { return _activities; }
            set { _activities = value; }
        }

        public string FriendlyDate
        {
            get { return _date.ToString("0:MM/dd/yy"); }
        }
    }
}
