using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_interactions
{
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        // 1
        private void button_show_Click(object sender, EventArgs e)
        {
            Childe Childe = new Childe(textBox1.Text);
            Childe.ShowDialog();
        }

        // 2
        /*private void button_show_Click(object sender, EventArgs e)
        {
            Childe Childe = new Childe();
            Childe.MyText = textBox1.Text;
            Childe.ShowDialog();
        }*/


        // 3
        /* private void button_show_Click(object sender, EventArgs e)
         {
             Childe Childe = new Childe();
             Childe.ShowDialog(textBox1.Text);
         }*/


    }
}
