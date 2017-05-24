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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Card.Text.Length != 0)
            {
                for (int i = 0; i < Program.Rooms.Count; i++)
                {
                    if (Program.Rooms[i].Contains(Card.Text))
                    {
                        new LoginError().ShowDialog();
                        goto m;
                    }
                }
                Program.Rooms[Convert.ToInt32(Room.Text)-1].Clients.Add(new Session((UInt16)Convert.ToInt32(Room.Text),Card.Text));
                Close();
            }
        m: ;
        }
    }
}
