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
            start_button = new Button();
            seconds_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            minutes_label = new Label();
            hours_label = new Label();
            groupBox1 = new GroupBox();
            stop_button = new Button();
            reset_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // start_button
            // 
            start_button.Location = new Point(176, 248);
            start_button.Name = "start_button";
            start_button.Size = new Size(145, 47);
            start_button.TabIndex = 0;
            start_button.Text = "Start";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // seconds_label
            // 
            seconds_label.AutoSize = true;
            seconds_label.Location = new Point(127, 44);
            seconds_label.Name = "seconds_label";
            seconds_label.Size = new Size(40, 32);
            seconds_label.TabIndex = 1;
            seconds_label.Text = "00";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // minutes_label
            // 
            minutes_label.AutoSize = true;
            minutes_label.Location = new Point(69, 44);
            minutes_label.Name = "minutes_label";
            minutes_label.Size = new Size(45, 32);
            minutes_label.TabIndex = 2;
            minutes_label.Text = "00:";
            // 
            // hours_label
            // 
            hours_label.AutoSize = true;
            hours_label.Location = new Point(16, 44);
            hours_label.Name = "hours_label";
            hours_label.Size = new Size(45, 32);
            hours_label.TabIndex = 3;
            hours_label.Text = "00:";
            hours_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.AliceBlue;
            groupBox1.Controls.Add(hours_label);
            groupBox1.Controls.Add(seconds_label);
            groupBox1.Controls.Add(minutes_label);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(160, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // stop_button
            // 
            stop_button.Location = new Point(176, 301);
            stop_button.Name = "stop_button";
            stop_button.Size = new Size(145, 47);
            stop_button.TabIndex = 5;
            stop_button.Text = "Stop";
            stop_button.UseVisualStyleBackColor = true;
            stop_button.Click += stop_button_Click;
            // 
            // reset_button
            // 
            reset_button.Location = new Point(176, 354);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(145, 46);
            reset_button.TabIndex = 6;
            reset_button.Text = "Reset";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 459);
            Controls.Add(reset_button);
            Controls.Add(stop_button);
            Controls.Add(groupBox1);
            Controls.Add(start_button);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button start_button;
        private Label seconds_label;
        private System.Windows.Forms.Timer timer1;
        private Label minutes_label;
        private Label hours_label;
        private GroupBox groupBox1;
        private Button stop_button;
        private Button reset_button;
    }
}