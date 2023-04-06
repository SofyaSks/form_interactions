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
    public partial class Childe : Form
    {
       
        // 2
       /* public string MyText
        {
            set { label_childe.Text = value; }
        }*/

        public Childe()
        {
            InitializeComponent();
        }

        // 1
        public Childe(string s)
        {
            InitializeComponent();
            label_childe.Text = s;
        }



        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 3
       /* public DialogResult ShowDialog(string str)
        {
            label_childe.Text = str;
            return ShowDialog();
        }*/
    }
}
