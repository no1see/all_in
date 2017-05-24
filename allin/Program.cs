using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace allin
{
    static class Program
    {   
        public static List<Room> Rooms;
        public static List<Assortiment> Menu;
        public static BD Data;
        public static UInt16 HourPrice = 25;
        public static List<Vip> Vips;
        public static bool Load = false;
        public static List<Personal> Personals;
        public static MainForm Main_Form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Rooms = new List<Room>();
            Rooms.Add(new Room("1", 1));
            Rooms.Add(new Room("2", 2));
            Rooms.Add(new Room("3", 3));
            Rooms.Add(new Room("4", 4));
            Rooms.Add(new Room("Big", 5));
            Data = new BD();
            Data.LoadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            if (Load == true)
            {
                Main_Form = new MainForm();
                Application.Run(Main_Form);
            }
        }
    }
}
