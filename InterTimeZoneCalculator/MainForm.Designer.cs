namespace InterTimeZoneCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ForiegnTimeZoneComboBox = new System.Windows.Forms.ComboBox();
            this.LocalTimeZoneComboBox = new System.Windows.Forms.ComboBox();
            this.ForiegnTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LocalTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainHoursAndMinutesSelector = new InterTimeZoneCalculator.HoursAndMinutesSelector();
            this.SuspendLayout();
            // 
            // ForiegnTimeZoneComboBox
            // 
            this.ForiegnTimeZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForiegnTimeZoneComboBox.FormattingEnabled = true;
            this.ForiegnTimeZoneComboBox.Location = new System.Drawing.Point(83, 12);
            this.ForiegnTimeZoneComboBox.Name = "ForiegnTimeZoneComboBox";
            this.ForiegnTimeZoneComboBox.Size = new System.Drawing.Size(317, 21);
            this.ForiegnTimeZoneComboBox.TabIndex = 0;
            // 
            // LocalTimeZoneComboBox
            // 
            this.LocalTimeZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalTimeZoneComboBox.FormattingEnabled = true;
            this.LocalTimeZoneComboBox.Location = new System.Drawing.Point(83, 42);
            this.LocalTimeZoneComboBox.Name = "LocalTimeZoneComboBox";
            this.LocalTimeZoneComboBox.Size = new System.Drawing.Size(317, 21);
            this.LocalTimeZoneComboBox.TabIndex = 1;
            // 
            // ForiegnTimePicker
            // 
            this.ForiegnTimePicker.Location = new System.Drawing.Point(406, 13);
            this.ForiegnTimePicker.Name = "ForiegnTimePicker";
            this.ForiegnTimePicker.Size = new System.Drawing.Size(209, 20);
            this.ForiegnTimePicker.TabIndex = 2;
            // 
            // LocalTimeTextBox
            // 
            this.LocalTimeTextBox.Location = new System.Drawing.Point(406, 42);
            this.LocalTimeTextBox.Name = "LocalTimeTextBox";
            this.LocalTimeTextBox.ReadOnly = true;
            this.LocalTimeTextBox.Size = new System.Drawing.Size(209, 20);
            this.LocalTimeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Foriegn Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Local Time:";
            // 
            // MainHoursAndMinutesSelector
            // 
            this.MainHoursAndMinutesSelector.Location = new System.Drawing.Point(621, 12);
            this.MainHoursAndMinutesSelector.Name = "MainHoursAndMinutesSelector";
            this.MainHoursAndMinutesSelector.Size = new System.Drawing.Size(323, 31);
            this.MainHoursAndMinutesSelector.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 75);
            this.Controls.Add(this.MainHoursAndMinutesSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocalTimeTextBox);
            this.Controls.Add(this.ForiegnTimePicker);
            this.Controls.Add(this.LocalTimeZoneComboBox);
            this.Controls.Add(this.ForiegnTimeZoneComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "InterTimeZoneCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ForiegnTimeZoneComboBox;
        private System.Windows.Forms.ComboBox LocalTimeZoneComboBox;
        private System.Windows.Forms.DateTimePicker ForiegnTimePicker;
        private System.Windows.Forms.TextBox LocalTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HoursAndMinutesSelector MainHoursAndMinutesSelector;
    }
}

