namespace Timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            time_button = new Button();
            seconds_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            minutes_label = new Label();
            hours_label = new Label();
            SuspendLayout();
            // 
            // time_button
            // 
            time_button.Location = new Point(176, 248);
            time_button.Name = "time_button";
            time_button.Size = new Size(145, 47);
            time_button.TabIndex = 0;
            time_button.Text = "Show Time";
            time_button.UseVisualStyleBackColor = true;
            time_button.Click += time_button_Click;
            // 
            // seconds_label
            // 
            seconds_label.AutoSize = true;
            seconds_label.Location = new Point(285, 205);
            seconds_label.Name = "seconds_label";
            seconds_label.Size = new Size(36, 25);
            seconds_label.TabIndex = 1;
            seconds_label.Text = ":00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // minutes_label
            // 
            minutes_label.AutoSize = true;
            minutes_label.Location = new Point(243, 205);
            minutes_label.Name = "minutes_label";
            minutes_label.Size = new Size(36, 25);
            minutes_label.TabIndex = 2;
            minutes_label.Text = ":00";
            // 
            // hours_label
            // 
            hours_label.AutoSize = true;
            hours_label.Location = new Point(200, 205);
            hours_label.Name = "hours_label";
            hours_label.Size = new Size(32, 25);
            hours_label.TabIndex = 3;
            hours_label.Text = "00";
            hours_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 459);
            Controls.Add(hours_label);
            Controls.Add(minutes_label);
            Controls.Add(seconds_label);
            Controls.Add(time_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button time_button;
        private Label seconds_label;
        private System.Windows.Forms.Timer timer1;
        private Label minutes_label;
        private Label hours_label;
    }
}