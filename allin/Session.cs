using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allin
{
    class Session
    {
        public UInt32 ID;
        public string Card;
        public DateTime StartTime;
        public DateTime EndTime;
        public List<Assortiment> Bougth;
        public UInt32 DeltaBonuses;
        public UInt32 Bonuses;
        public Vip VipClient;
        public List<UInt16> Room;
        public UInt16 Price;
        public UInt16 HookahMinutes = 0;
        
        public UInt16 CurrentRoom
        {
            get{return Room[Room.Count - 1];}
        }

        public void Calc()
        {
            double minutes = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second).TotalMinutes - new TimeSpan(StartTime.Hour, StartTime.Minute, StartTime.Second).TotalMinutes;
            minutes -= HookahMinutes;
            if (minutes < 0) minutes = 0;
            double price = minutes / 60 * Program.HourPrice;
            foreach (Assortiment temp in Bougth)
            {
                price += temp.Price;
            }
            Price = (UInt16)(price + 0.999);
        }

        public Session(UInt16 room, string card)
        {
            StartTime = DateTime.Now;
            Room = new List<ushort>();
            Room.Add(room);
            Card = card;
            Bougth = new List<Assortiment>();
            foreach (Vip tmp in Program.Vips)
            {
                if (tmp.Card == card)
                {
                    this.VipClient = tmp;
                }
            }
        }

        public void ChangeRoom(UInt16 room)
        {
            Room.Add(room);
        }
    }
}
