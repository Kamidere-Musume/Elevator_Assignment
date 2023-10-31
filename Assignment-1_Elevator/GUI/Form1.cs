using System.Windows.Forms;

namespace Assignment_1_Elevator
{
    public partial class Form1 : Form
    {
        private int movement = 5;
        private int leftmovement = 0;
        private int rightmovement = 0;
        private int rightPosition;
        private int leftPosition;

        public Form1()
        {
            InitializeComponent();
            rightPosition = pictureBox3.Left;
            leftPosition = pictureBox2.Left;


        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            if (!timer_left.Enabled && !timer_right.Enabled)
            {
                timer_left.Start();
                timer_right.Start();
            }


        }

        private void timer_left_Tick(object sender, EventArgs e)
        {
            if (leftmovement < 80)
            {
                pictureBox2.Left -= movement;
                leftmovement += movement;
            }
            else
            {
                timer_left.Stop();
            }
        }

        private void timer_right_Tick(object sender, EventArgs e)
        {
            if (rightmovement < 80)
            {
                pictureBox3.Left += movement;
                rightmovement += movement;
            }

            else
            {
                timer_right.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!timer_left.Enabled && !timer_right.Enabled)
            {
                back_timer.Start();
            }
        }


        private void back_timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Left < leftPosition)
            {
                pictureBox2.Left += movement;
            }
            if (pictureBox3.Left > rightPosition)
            {
                pictureBox3.Left -= movement;
            }

            if (pictureBox2.Left >= leftPosition && pictureBox3.Left <= rightPosition)
            {
                back_timer.Stop();
                // Reset the movement counters
                leftmovement = 0;
                rightmovement = 0;
            }
        }
    }
}