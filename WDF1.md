# BTWDF
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Xin chào Admin");
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string TextBox2 = this.textBox2.Text;
            string comboBox1 = this.comboBox1.Text;
            MessageBox.Show($"Chào mừng {TextBox2} đến với {comboBox1}");
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da Thoat");
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Chào mừng " + this.textBox1.Text + " đến với " + this.comboBox1.SelectedItem.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
