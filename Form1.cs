using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Timer
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;


        }

        private void stop_button_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            seconds = 0;
            seconds_label.Text = $"0{seconds.ToString()}";
            minutes = 0;
            seconds_label.Text = $"0{seconds.ToString()}";
            hours = 0;
            seconds_label.Text = $"0{seconds.ToString()}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            ChangeTime();

            if (seconds < 10)
                seconds_label.Text = $"0{seconds.ToString()}";
            else
                seconds_label.Text = $"{seconds.ToString()}";

            if (minutes < 10)
                minutes_label.Text = $"0{minutes.ToString()}:";
            else
                minutes_label.Text = $"{minutes.ToString()}:";

            if (hours < 10)
                hours_label.Text = $"0{hours.ToString()}: ";
            else
                hours_label.Text = $"{hours.ToString()}: ";


        }

        private void ChangeTime()
        {
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
        }


    }
}