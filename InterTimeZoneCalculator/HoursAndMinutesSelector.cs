using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterTimeZoneCalculator
{

    public partial class HoursAndMinutesSelector : UserControl
    {

        public event EventHandler ValueChanged;

        public HoursAndMinutesSelector()
        {

            InitializeComponent();

            string[] HoursArray = new string[23];

            string[] MinutesSecondsArray = new string[60];

            for (int i = 0; i < 9; ++i)
            {

                HoursArray[i] = Convert.ToString("0" + (i + 1));

            }

            for (int i = 0; i < 10; ++i)
            {

                MinutesSecondsArray[i] = Convert.ToString("0" + i);

            }

            for (int i = 9; i < 23; ++i)
            {

                HoursArray[i] = Convert.ToString(i + 1); 

            }

            for (int i = 10; i < 60; ++i)
            {

                MinutesSecondsArray[i] = Convert.ToString(i); 

            }

            HoursComboBox.Items.AddRange(HoursArray);

            HoursComboBox.SelectedIndex = 0;

            HoursComboBox.SelectedIndexChanged += HoursComboBox_SelectedIndexChanged;

            MinutesComboBox.Items.AddRange(MinutesSecondsArray);

            MinutesComboBox.SelectedIndex = 0;

            MinutesComboBox.SelectedIndexChanged += MinutesComboBox_SelectedIndexChanged;

            SecondsComboBox.Items.AddRange(MinutesSecondsArray);
            
            SecondsComboBox.SelectedIndex = 0;

            SecondsComboBox.SelectedIndexChanged += MillisecondsComboBox_SelectedIndexChanged;

        }

        void MillisecondsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            OnValueChanged();

        }

        void MinutesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            OnValueChanged();

        }

        void HoursComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            OnValueChanged();

        }

        protected void OnValueChanged()
        {

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);

        }

        public int HourValue
        {

            get
            {

                return Convert.ToInt32(HoursComboBox.SelectedItem);

            }

        }

        public int MinuteValue
        {

            get
            {

                return Convert.ToInt32(MinutesComboBox.SelectedItem);

            }

        }

        public int MillisecondValue
        {

            get
            {

                return Convert.ToInt32(SecondsComboBox.SelectedItem);

            }

        }

    }

}
