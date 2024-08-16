using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }   
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Chào mừng " + this.txtTenHV.Text + "\r\n";
            if (checkBox1.Checked == true) str += "Giới tính: Nam\r\n";
            else
                str += "Giới tính: Nữ\r\n";
            str += "Danh sách khóa học:\n\r";
            if (checkBox3.Checked == true) str += "Toeic\r\n";
            if (checkBox4.Checked == true) str += "Photoshop\r\n";
            if (checkBox5.Checked == true) str += "Wordpress\r\n";
            str += textBox1.Text;
            MessageBox.Show(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da Thoat");
            Application.Exit();
        }

      
    }
}
