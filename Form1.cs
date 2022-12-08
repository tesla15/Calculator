using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string final;

        void update()
        {
            if (richTextBox1.Text.Equals("naah bro you didnt :skull:"))
            {
                final = "";
                richTextBox1.Text = "";
            } else
            {
                richTextBox1.Text = final;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            final = final + "1";
            update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            final = final + "8";
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            final = final + "2";
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            final = final + "3";
            update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            final = final + "4";
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            final = final + "5";
            update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            final = final + "6";
            update();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            final = final + "7";
            update();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            final = final + "9";
            update();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            final = "";
            update();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            final = final + "0";
            update();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (final.Contains("/0"))
            {
                final = "naah bro you didnt :skull:";
                update();
            } else
            {
                string math = final;
                string value = new DataTable().Compute(math, null).ToString();
                final = value;
                update();

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            final = final + "/";
            update();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            final = final + "*";
            update();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            final = final + "-";
            update();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            final = final + "+";
            update();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not yet");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not yet");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ur already in bro");
        }
    }
}