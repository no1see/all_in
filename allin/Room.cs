using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allin
{
    class Room
    {
        public bool Check = false;
        public DateTime StartSessions;
        public string Name;
        public List<Session> Clients;
        public UInt16 RoomNumber;

    
        public Room(string name, UInt16 roomNumber)
        {
            Name = name;
            RoomNumber = roomNumber;
            Clients = new List<Session>();
        }

        public UInt64 Calculate()
        {
            UInt64 result = 0;
            foreach (Session client in Clients)
            {
                result += client.Price;
                /*foreach (Assortiment ass in client.Bougth)
                {
                    result += ass.Price;
                }*/
            }
            return result;
        }

        public UInt64 Calc
        {
            get {return Calculate();}
        }

        public string StartSessionsString
        {
            get
            {
                if (Check == false) return "0";
                else
                {
                    double Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).TotalSeconds
                                                - new TimeSpan(StartSessions.Hour, StartSessions.Minute, StartSessions.Second).TotalSeconds
                                                   ; 
                    return TimeSpan.FromSeconds(Time).ToString();
                }
            }
        }

        public void RefreshTime()
        {
            if (Clients.Count == 0)
                Check = false;
            else
            {
                Check = true;
                DateTime tmp = Clients[0].StartTime;
                foreach (Session temp in Clients)
                {
                    if (DateTime.Compare(tmp, temp.StartTime) > 0)
                    {
                        tmp = temp.StartTime;
                    }
                }
                StartSessions = tmp;
            }
        }
        
        public bool Contains(string name)
        {
            if (Clients.Count == 0)
                Check = false;
            else
            {
                Check = true;
                DateTime tmp = Clients[0].StartTime;
                foreach (Session temp in Clients)
                {
                    if (DateTime.Compare(tmp, temp.StartTime) > 0)
                    {
                        tmp = temp.StartTime;
                    }
                }
                StartSessions = tmp;
            }
            foreach (Session temp in Clients)
            {
                if (temp.Card == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
