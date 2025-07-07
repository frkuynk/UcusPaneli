using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçuşPaneliX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTA:" + comboBox1.Text + "-" + comboBox2.Text + " / " + "TARİH:" + dateTimePicker1.Text + " / " + "SAAT:" + maskedTextBox1.Text + " / " + "ADI SOYADI:" + textBox1.Text + " / " + "T.C.:" + maskedTextBox2.Text + " / " + "TELEFON NO:" + maskedTextBox3.Text);
            MessageBox.Show("YOLCU KAYDI YAPILDI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;    // burda harika bir algoritma var ilk önce label9 a com2 yazdım 
            comboBox2.Text = comboBox1.Text; // sonra com2 ye com1 yadım com1 e de label9 yazdım
            comboBox1 .Text = label9.Text;
            label9.Visible = false; // özellikler kısmındanda labelin ismini saklarsın kot kısmındanda com2 den gelen değerin görünmemesini 
         }
    }
}
