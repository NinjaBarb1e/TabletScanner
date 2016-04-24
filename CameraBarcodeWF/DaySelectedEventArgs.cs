using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBarcodeWF
{
    public class DaySelectedEventArgs : EventArgs
    {
        public Day SelectedDay { get; private set; }

        public DaySelectedEventArgs(Day selectedDay)
        {
            SelectedDay = selectedDay;
        }
    }
}
