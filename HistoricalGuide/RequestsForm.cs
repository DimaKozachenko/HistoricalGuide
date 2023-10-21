using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoricalGuide
{
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        private void request1_Click(object sender, EventArgs e)
        {
            Request1 requests1 = new Request1();
            requests1.Show();
        }

        private void RequestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void buttonRequest2_Click(object sender, EventArgs e)
        {
            Request2 requests2 = new Request2();
            requests2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request3 requests3 = new Request3();
            requests3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Request4 requests4 = new Request4();
            requests4.Show();
        }

        private void buttonRequest5_Click(object sender, EventArgs e)
        {
            Request5 requests5 = new Request5();
            requests5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Request6 requests6 = new Request6();
            requests6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Request7 requests7 = new Request7();
            requests7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Request8 requests8 = new Request8();
            requests8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Request9 requests9 = new Request9();
            requests9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Request10 requests10 = new Request10();
            requests10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Request11 requests11 = new Request11();
            requests11.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Request12 requests12 = new Request12();
            requests12.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Request13 requests13 = new Request13();
            requests13.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Request14 requests14 = new Request14();
            requests14.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Request15 requests15 = new Request15();
            requests15.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Request16 requests16 = new Request16();
            requests16.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Request19 requests19 = new Request19();
            requests19.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Request20 requests20 = new Request20();
            requests20.Show();
        }
    }
}
