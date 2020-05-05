using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUp(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        void AddUp(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber + secondNumber;
            MessageBox.Show(answer.ToString());

            return;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int returnValue = 0;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            returnValue = Subtract(num1, num2);
            MessageBox.Show(returnValue.ToString());

        }

        private int Subtract(int Pnum1, int Pnum2)
        {
            int answer;
            answer = Pnum1 - Pnum2;
            return answer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                rtb.Clear();
                rtb.LoadFile("C:\\_Transito\\test.txt");

            }
            catch (System.Exception excep)
            {

                MessageBox.Show(excep.Message);

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                MessageBox.Show("left mink");
            }
            else if(e.Button==MouseButtons.Right)
            {
                MessageBox.Show("right mink");
            }
        }
        


    }
}
