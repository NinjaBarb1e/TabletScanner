using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraBarcodeWF
{
    public partial class DateList : UserControl
    {
        private List<Day> _dataSource;

        public delegate void DaySelectedHandler(object sender, DaySelectedEventArgs e);
        public event EventHandler<DaySelectedEventArgs> OnDaySelected;

        public DateList()
        {
            InitializeComponent();
        }

        private void LoadMenu(List<Day> days)
        {
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

        }

        public List<Day> DataSource
        {
            get { return _dataSource; }
            set
            {
                _dataSource = value;
                LoadItems(value);
            }
        }

        private void LoadItems(List<Day> days)
        {
            int i = 0;

            // Create menu item from data.
            foreach (Day day in days)
            {
                i++;

                // Create new dateitem.
                MenuItemColor color = (i % 2 == 0) ? MenuItemColor.Primary : MenuItemColor.Alternate;
                DateItem item = new DateItem(day, color);

                // Subscribe to selection event.
                item.OnDaySelected += Item_OnDaySelected;

                // Add new control to panel.
                AddMenuItemToList(item);
            }
        }

        private void Item_OnDaySelected(object sender, DaySelectedEventArgs e)
        {
            if(OnDaySelected != null)
            {
                OnDaySelected(this, e);
            }
        }

        private void AddMenuItemToList(DateItem item)
        {
            flowLayoutPanel1.Controls.Add(item);
        }
    }
}
