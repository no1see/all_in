using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Personal temp in Program.Personals)
                {
                    if(temp.Check(textBox1.Text, textBox2.Text))
                    {
                        Program.Load = true;
                        Close();
                        goto m;
                    }
                }
                new LoginError().ShowDialog();
                textBox2.Text = "";
                m:;
            }
        }
    }
}
