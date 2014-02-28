using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterTimeZoneCalculator
{

    public partial class MainForm : Form
    {

        public MainForm()
        {

            InitializeComponent();

            Icon = InterTimeZoneCalculator.Properties.Resources.TimeClock;

            IEnumerable<TimeZoneInfo> TimeZoneInfos = TimeZoneInfo.GetSystemTimeZones();

            AddTimeZoneInfos(ForiegnTimeZoneComboBox, TimeZoneInfos);

            AddTimeZoneInfos(LocalTimeZoneComboBox, TimeZoneInfos);

            ForiegnTimeZoneComboBox.SelectedIndexChanged += TimeZone1ComboBox_SelectedIndexChanged;

            LocalTimeZoneComboBox.SelectedIndexChanged += TimeZone2ComboBox_SelectedIndexChanged;

            FormClosing += MainForm_FormClosing;

            for(int i = 0; i < LocalTimeZoneComboBox.Items.Count; ++i)
            {

                if (TimeZoneInfo.Local.Id == ((TimeZoneInfo)LocalTimeZoneComboBox.Items[i]).Id)
                    LocalTimeZoneComboBox.SelectedIndex = i;

            }

            ForiegnTimePicker.ValueChanged += ForiegnTimePicker_ValueChanged;

            MainHoursAndMinutesSelector.ValueChanged += new EventHandler(MainHoursAndMinutesSelector_ValueChanged);  

        }

        void MainHoursAndMinutesSelector_ValueChanged(object sender, EventArgs e)
        {

            SetTime();

        }

        void ForiegnTimePicker_ValueChanged(object sender, EventArgs e)
        {

            SetTime();

        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            ForiegnTimeZoneComboBox.SelectedIndexChanged -= TimeZone1ComboBox_SelectedIndexChanged;

            LocalTimeZoneComboBox.SelectedIndexChanged -= TimeZone2ComboBox_SelectedIndexChanged;

            ForiegnTimePicker.ValueChanged -= ForiegnTimePicker_ValueChanged;

            FormClosing -= MainForm_FormClosing;
            
        }

        void TimeZone1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetTime();

        }

        void TimeZone2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SetTime();

        }

        void SetTime()
        {

            LocalTimeTextBox.Text = TimeZoneInfo.ConvertTime(new DateTime(ForiegnTimePicker.Value.Year, ForiegnTimePicker.Value.Month, ForiegnTimePicker.Value.Day, MainHoursAndMinutesSelector.HourValue, MainHoursAndMinutesSelector.MinuteValue, MainHoursAndMinutesSelector.MillisecondValue, DateTimeKind.Unspecified), (TimeZoneInfo)ForiegnTimeZoneComboBox.SelectedItem, (TimeZoneInfo)LocalTimeZoneComboBox.SelectedItem).ToString();

        }

        void AddTimeZoneInfos(ComboBox TheComboBox, IEnumerable<TimeZoneInfo> TimeZoneInfos)
        {

            TheComboBox.BeginUpdate();

            foreach (TimeZoneInfo Item in TimeZoneInfos)
            {

                TheComboBox.Items.Add(Item);

            }

            TheComboBox.SelectedIndex = 0;

            TheComboBox.EndUpdate();

        }

    }

}
