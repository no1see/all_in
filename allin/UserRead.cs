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
    public partial class UserRead : Form
    {
        public string temp;

        public UserRead(string _temp)
        {
            InitializeComponent();
            temp = _temp;
        }

        private void UserRead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temp = textBox1.Text;
                Close();
            }
        }
    }
}
