using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TwelveDaysOfChristmasWF
{
    public partial class Home : Form
    {     
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GiftCounter gC = new GiftCounter();
            //set text field value to string
            richTextBox1.Text = gC.CountGifts(12);
        }
    }
}
