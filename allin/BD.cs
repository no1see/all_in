using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace allin
{
    class BD
    {
        private SqlConnection bd;

        public BD()
        {
            bd = new SqlConnection("");
        }

        public void NewProduct(string newName, UInt16 price)
        {

        }

        public void LoadData()
        {
            LoadAdmins();
            Program.Menu = Menu();
            LoadVips();
        }

        private void LoadVips()
        {
            Program.Vips = new List<Vip>();
        }

        private void LoadAdmins()
        {
            Program.Personals = new List<Personal>();
            Program.Personals.Add(new Personal("Admin", "1"));
            Program.Personals.Add(new Personal("Not Admin", "1488"));
        }

        public List<Assortiment> Menu()
        {
            List<Assortiment> result = new List<Assortiment>();
            result.Add(new Assortiment("Cola", 10));
            result.Add(new Assortiment("Bounty", 20));
            result.Add(new Assortiment("Snickers", 25));
            return result;
        }
    }
}
