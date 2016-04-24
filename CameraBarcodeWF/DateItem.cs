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
    public partial class DateItem : UserControl
    {
        Day _day;

        public delegate void DaySelectedHandler(object sender, DaySelectedEventArgs e);
        public event EventHandler<DaySelectedEventArgs> OnDaySelected;

        #region Constructors

        public DateItem()
        {
            InitializeComponent();
            SetColor(MenuItemColor.Primary);
        }

        public DateItem(Day day)
            : this()
        {
            _day = day;
        }

        public DateItem(Day day, MenuItemColor color)
            : this(day)
        {
            SetColor(color);
        }

        #endregion

        #region Private Methods

        private void SetColor(MenuItemColor color)
        {
            if (color == MenuItemColor.Primary)
            {
                this.BackColor = System.Drawing.Color.Silver;
                lblTopText.ForeColor = System.Drawing.Color.Black;
                lblBottomText.ForeColor = System.Drawing.Color.DimGray;
            }
            else
            {
                this.BackColor = System.Drawing.Color.DimGray;
                lblTopText.ForeColor = System.Drawing.Color.Gainsboro;
                lblBottomText.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void SetDate(DateTime date)
        {
            lblTopText.Text = date.DayOfWeek.ToString();
            lblBottomText.Text = date.ToShortDateString();
        }

        private void DaySelected(Day day)
        {
            if (OnDaySelected != null)
            {
                DaySelectedEventArgs args = new DaySelectedEventArgs(day);
                OnDaySelected(this, args);
            }
        }

        #endregion

        #region Public Properties

        public MenuItemColor Color
        {
            set { SetColor(value); }
        }

        #endregion

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (OnDaySelected != null)
            {
                DaySelectedEventArgs args = new DaySelectedEventArgs(_day);
                OnDaySelected(this, args);
            }
        }

        private void DateItem_Load(object sender, EventArgs e)
        {
            SetDate(_day.Date);
        }
    }
}
