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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CloseAllDataGridView();
        }

        private void CloseAllDataGridView()
        {
            foreach (var tmp in this.Controls)
            {
                if(typeof(DataGridView).IsAssignableFrom(tmp.GetType()))
                    (tmp as DataGridView).Visible = false;
                if (typeof(Button).IsAssignableFrom(tmp.GetType()))
                {
                    if((tmp as Button).Name.Substring(0,4) == "Room")
                    (tmp as Button).Visible = false;
                }
            }
        }

        private void Room3_Click(object sender, EventArgs e)
        {
            if (Room3_Info.Visible == true)
            {
                bool exist = false;
                string card = "";
                UserRead newForm = new UserRead(card);
                newForm.ShowDialog();
                card = newForm.temp;
                if (card.Length != 0)
                {
                    for (int i = 0; i < Program.Rooms.Count; i++)
                    {
                        if (Program.Rooms[i].Contains(card))
                        {
                            exist = true;
                            if (Program.Rooms[2].Contains(card))
                            {
                                new NewService(card).ShowDialog();
                                goto m;
                            }
                            new LoginError().ShowDialog();
                        }
                    }
                    if(!exist)Program.Rooms[2].Clients.Add(new Session((UInt16)1, card));
                }
            m: ;
            }
            CloseAllDataGridView();
            Room3_Info.Visible = true;
            Room3_Client.Visible = true;
            Room3_Room.Visible = true;
        }
        private void Room4_Click(object sender, EventArgs e)
        {
            if (Room4_Info.Visible == true)
            {
                bool exist = false;
                string card = "";
                UserRead newForm = new UserRead(card);
                newForm.ShowDialog();
                card = newForm.temp;
                if (card.Length != 0)
                {
                    for (int i = 0; i < Program.Rooms.Count; i++)
                    {
                        if (Program.Rooms[i].Contains(card))
                        {
                            exist = true;
                            if (Program.Rooms[3].Contains(card))
                            {
                                new NewService(card).ShowDialog();
                                goto m;
                            }
                            new LoginError().ShowDialog();
                        }
                    }
                    if (!exist) Program.Rooms[3].Clients.Add(new Session((UInt16)1, card));
                }
            m: ;
            }
            CloseAllDataGridView();
            Room4_Info.Visible = true;
            Room4_Client.Visible = true;
            Room4_Room.Visible = true;
        }
        private void Room2_Click(object sender, EventArgs e)
        {
            if (Room2_Info.Visible == true)
            {
                bool exist = false;
                string card = "";
                UserRead newForm = new UserRead(card);
                newForm.ShowDialog();
                card = newForm.temp;
                if (card.Length != 0)
                {
                    for (int i = 0; i < Program.Rooms.Count; i++)
                    {
                        if (Program.Rooms[i].Contains(card))
                        {
                            exist = true;
                            if (Program.Rooms[1].Contains(card))
                            {
                                new NewService(card).ShowDialog();
                                goto m;
                            }
                            new LoginError().ShowDialog();
                        }
                    }
                    if (!exist)Program.Rooms[1].Clients.Add(new Session((UInt16)1, card));
                }
            m: ;
            }
            CloseAllDataGridView();
            Room2_Info.Visible = true;
            Room2_Client.Visible = true;
            Room2_Room.Visible = true;
        }

        private void RunUserInputForm()
        {
            string card = "";
            UserRead newForm = new UserRead(card);
            newForm.ShowDialog();
            card = newForm.temp;
            newForm.Close();
        }

        private void Room1_Click(object sender, EventArgs e)
        {
            if (Room1_Info.Visible == true)
            {
                bool exist = false;
                string card = "";
                UserRead newForm = new UserRead(card);
                newForm.ShowDialog();
                card = newForm.temp;
                if (card.Length != 0)
                {
                    for (int i = 0; i < Program.Rooms.Count; i++)
                    {
                        if (Program.Rooms[i].Contains(card))
                        {
                            exist = true;
                            if(Program.Rooms[0].Contains(card))
                            {
                                new NewService(card).ShowDialog();
                                goto m;
                            }
                            new LoginError().ShowDialog();
                        }
                    }
                    if (!exist)Program.Rooms[0].Clients.Add(new Session((UInt16)1, card));
                }
            m:;
            }
            CloseAllDataGridView();
            Room1_Info.Visible = true;
            Room1_Client.Visible = true;
            Room1_Room.Visible = true;
        }
        private void RoomBig_Click(object sender, EventArgs e)
        {
            if (RoomBig_Info.Visible == true)
            {
                bool exist = false;
                string card = "";
                UserRead newForm = new UserRead(card);
                newForm.ShowDialog();
                card = newForm.temp;
                if (card.Length != 0)
                {
                    for (int i = 0; i < Program.Rooms.Count; i++)
                    {
                        if (Program.Rooms[i].Contains(card))
                        {
                            exist = true;
                            if (Program.Rooms[4].Contains(card))
                            {
                                new NewService(card).ShowDialog();
                                goto m;
                            }
                            new LoginError().ShowDialog();
                        }
                    }
                    if (!exist)Program.Rooms[4].Clients.Add(new Session((UInt16)1, card));
                }
            m: ;
            }
            CloseAllDataGridView();
            RoomBig_Info.Visible = true;
            RoomBig_Client.Visible = true;
            RoomBig_Room.Visible = true;
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            new NewClient().ShowDialog();
            RefreshRooms();
        }

        private void RefreshRooms()
        {
            foreach (Room temp in Program.Rooms)
            {
                foreach (Session client in temp.Clients)
                {
                    client.Calc();
                }
            }
            foreach (var tmp in this.Controls)
            {
                if (typeof(DataGridView).IsAssignableFrom(tmp.GetType()))
                    (tmp as DataGridView).Rows.Clear();
            }
            #region Room1
            Program.Rooms[0].RefreshTime();
            Room1_Info.Rows.Add("Кількість", Program.Rooms[0].Clients.Count.ToString());
            Room1_Info.Rows.Add("Час", Program.Rooms[0].StartSessionsString);
            Room1_Info.Rows.Add("Cума", Program.Rooms[0].Calc.ToString());
            foreach (Assortiment temp in Program.Menu)
            {
                UInt16 count = 0;
                foreach (Session ses in Program.Rooms[0].Clients)
                {
                    foreach (Assortiment assort in ses.Bougth)
                    {
                        if (assort.Name == temp.Name)
                            count++;
                    }
                }
                Room1_Info.Rows.Add(temp.Name, count.ToString());
            }
            #endregion
            #region Room2
            Program.Rooms[1].RefreshTime();
            Room2_Info.Rows.Add("Кількість", Program.Rooms[1].Clients.Count.ToString());
            Room2_Info.Rows.Add("Час", Program.Rooms[1].StartSessionsString);
            Room2_Info.Rows.Add("Сума", Program.Rooms[1].Calc.ToString());
            foreach (Assortiment temp in Program.Menu)
            {
                UInt16 count = 0;
                foreach (Session ses in Program.Rooms[1].Clients)
                {
                    foreach (Assortiment assort in ses.Bougth)
                    {
                        if (assort.Name == temp.Name)
                            count++;
                    }
                }
                Room2_Info.Rows.Add(temp.Name, count.ToString());
            }
            #endregion
            #region Room3
            Program.Rooms[2].RefreshTime();
            Room3_Info.Rows.Add("Кількість", Program.Rooms[2].Clients.Count.ToString());
            Room3_Info.Rows.Add("Час", Program.Rooms[2].StartSessionsString);
            Room3_Info.Rows.Add("Сума", Program.Rooms[2].Calc.ToString());
            foreach (Assortiment temp in Program.Menu)
            {
                UInt16 count = 0;
                foreach (Session ses in Program.Rooms[2].Clients)
                {
                    foreach (Assortiment assort in ses.Bougth)
                    {
                        if (assort.Name == temp.Name)
                            count++;
                    }
                }
                Room3_Info.Rows.Add(temp.Name, count.ToString());
            }
            #endregion
            #region Room4
            Program.Rooms[3].RefreshTime();
            Room4_Info.Rows.Add("Кількість", Program.Rooms[3].Clients.Count.ToString());
            Room4_Info.Rows.Add("Час", Program.Rooms[3].StartSessionsString);
            Room4_Info.Rows.Add("Сума", Program.Rooms[3].Calc.ToString());
            foreach (Assortiment temp in Program.Menu)
            {
                UInt16 count = 0;
                foreach (Session ses in Program.Rooms[3].Clients)
                {
                    foreach (Assortiment assort in ses.Bougth)
                    {
                        if (assort.Name == temp.Name)
                            count++;
                    }
                }
                Room4_Info.Rows.Add(temp.Name, count.ToString());
            }
            #endregion
            #region RoomBig
            Program.Rooms[4].RefreshTime();
            RoomBig_Info.Rows.Add("Кількість", Program.Rooms[4].Clients.Count.ToString());
            RoomBig_Info.Rows.Add("Час", Program.Rooms[4].StartSessionsString);
            RoomBig_Info.Rows.Add("Сума", Program.Rooms[4].Calc.ToString());
            foreach (Assortiment temp in Program.Menu)
            {
                UInt16 count = 0;
                foreach (Session ses in Program.Rooms[4].Clients)
                {
                    foreach (Assortiment assort in ses.Bougth)
                    {
                        if (assort.Name == temp.Name)
                            count++;
                    }
                }
                RoomBig_Info.Rows.Add(temp.Name, count.ToString());
            }
            #endregion 
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshRooms();
        }
    }
}
