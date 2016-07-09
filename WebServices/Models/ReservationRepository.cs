using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();
        public static ReservationRepository Current
        {
            get
            {
                return repo;
            }
        }
        private List<Reservation> data = new List<Reservation>
        {
            new Reservation {ReservationId=1,ClientName="Adam",Location="AoardDoom" },
            new Reservation {ReservationId=2,ClientName="Bdam",Location="BoardCoom" },
            new Reservation {ReservationId=3,ClientName="Cdam",Location="CoardBoom" },
            new Reservation {ReservationId=4,ClientName="Dam",Location="DoardAoom" }
        };
        public IEnumerable<Reservation> GetAll()
        {
            return data;
        }
        public Reservation Get(int id)
        {
            return data.Where(r => r.ReservationId == id).FirstOrDefault();
        }
        public Reservation Add(Reservation iteam)
        {
            iteam.ReservationId = data.Count + 1;
            data.Add(iteam);
            return iteam;
        }
        public void Remove(int id)
        {
            Reservation item = Get(id);
            if (item != null)
                data.Remove(item);
        }
        public bool Update(Reservation item)
        {
            Reservation storedItem = Get(item.ReservationId);
            if (storedItem != null)
            {
                storedItem.ClientName = item.ClientName;
                storedItem.Location = item.Location;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
