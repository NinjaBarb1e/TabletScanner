using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CameraBarcodeWF
{
    public partial class Main : Form
    {
        List<Day> _days;

        public Main()
        {
            InitializeComponent();

            _days = OpenFile();

            //Scanner panel = new Scanner();
            DateList panel = new DateList();
            panel.OnDaySelected += Panel_OnDaySelected;
            panel.DataSource = _days;

            panelContainer.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
        }

        private void Panel_OnDaySelected(object sender, DaySelectedEventArgs e)
        {
            MessageBox.Show($"From Main {e.SelectedDay.Date.ToShortDateString()}");
        }

        private void GetDays()
        {
            List<Day> days = new List<Day>();

            Day d1 = new Day();
            d1.Date = new DateTime(2016, 10, 11);
            d1.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 11), Name = "Dinner" });
            d1.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 11), Name = "Activity 1" });
            days.Add(d1);

            Day d2 = new Day();
            d2.Date = new DateTime(2016, 10, 12);
            d2.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 12), Name = "Lunch" });
            d2.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 12), Name = "Dinner" });
            d2.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 12), Name = "Activity 1" });
            d2.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 12), Name = "Activity 2" });
            days.Add(d2);

            Day d3 = new Day();
            d3.Date = new DateTime(2016, 10, 13);
            d3.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 13), Name = "Breakfast" });
            d3.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 13), Name = "Lunch" });
            d3.Meals.Add(new Meal() { Date = new DateTime(2016, 10, 13), Name = "Dinner" });
            d3.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 13), Name = "Activity 3" });
            d3.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 13), Name = "Activity 4" });
            d3.Activities.Add(new Activity() { Date = new DateTime(2016, 10, 13), Name = "Activity 5" });
            days.Add(d3);

            SaveFile(days);

        }

        private void SaveFile(List<Day> days)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Bootcamp test to XML";
            saveDialog.DefaultExt = "xml";
            saveDialog.Filter = "XML files (*.xml)|*.xml";

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveDialog.FileName != null)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Day>));
                using (FileStream fs = File.Open(saveDialog.FileName, FileMode.Create))
                {
                    xs.Serialize(fs, days);
                }
            }
        }

        private List<Day> OpenFile()
        {
            List<Day> days = new List<Day>();

            using (Stream reader = new FileStream(@"C:\Users\amy\Desktop\xTest.xml", FileMode.Open))
            //using (Stream reader = new FileStream(@"C:\SccApp\Data\xTest.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Day>));
                days = (List<Day>)serializer.Deserialize(reader);
            }


            return days;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home");
        }

        private void btnSynch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sync");
        }
    }
}
