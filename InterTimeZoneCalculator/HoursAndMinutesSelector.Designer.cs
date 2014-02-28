namespace InterTimeZoneCalculator
{
    partial class HoursAndMinutesSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HoursComboBox = new System.Windows.Forms.ComboBox();
            this.MinutesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours:";
            // 
            // HoursComboBox
            // 
            this.HoursComboBox.FormattingEnabled = true;
            this.HoursComboBox.Location = new System.Drawing.Point(41, 3);
            this.HoursComboBox.Name = "HoursComboBox";
            this.HoursComboBox.Size = new System.Drawing.Size(47, 21);
            this.HoursComboBox.TabIndex = 1;
            // 
            // MinutesComboBox
            // 
            this.MinutesComboBox.FormattingEnabled = true;
            this.MinutesComboBox.Location = new System.Drawing.Point(147, 3);
            this.MinutesComboBox.Name = "MinutesComboBox";
            this.MinutesComboBox.Size = new System.Drawing.Size(47, 21);
            this.MinutesComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes:";
            // 
            // SecondsComboBox
            // 
            this.SecondsComboBox.FormattingEnabled = true;
            this.SecondsComboBox.Location = new System.Drawing.Point(258, 3);
            this.SecondsComboBox.Name = "SecondsComboBox";
            this.SecondsComboBox.Size = new System.Drawing.Size(47, 21);
            this.SecondsComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds:";
            // 
            // HoursAndMinutesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SecondsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinutesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoursComboBox);
            this.Controls.Add(this.label1);
            this.Name = "HoursAndMinutesSelector";
            this.Size = new System.Drawing.Size(314, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HoursComboBox;
        private System.Windows.Forms.ComboBox MinutesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SecondsComboBox;
        private System.Windows.Forms.Label label3;
    }
}
