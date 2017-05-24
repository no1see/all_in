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
    public partial class NewService : Form
    {
        private string card;

        public NewService(string _card)
        {
            InitializeComponent();
            card = _card;
            foreach (Assortiment temp in Program.Menu)
            {
                Stock.Rows.Add(temp.Name,"0");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            foreach(Room room in Program.Rooms)
            {
                foreach (Session client in room.Clients)
                {
                    if (client.Card == card)
                    {
                        for(int i = 0; i < (Stock.Rows.Count - 1); i++)
                        {
                            UInt16 price = 0;
                            foreach(Assortiment product in Program.Menu)
                            {
                                if(product.Name == Stock.Rows[i].Cells[0].Value.ToString()) price = product.Price;
                            }
                            for(int j =0;j<Convert.ToInt32(Stock.Rows[i].Cells[1].Value.ToString());j++)
                            {
                                client.Bougth.Add(new Assortiment(Stock.Rows[i].Cells[0].Value.ToString(), price));
                            }
                        }
                    }
                }
            }
            Close();
        }
    }
}
