
using System.Collections.Generic;
using WebServices.Models;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRepository repo = ReservationRepository.Current;
        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }
        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }
        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }
        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repo.Update(item);
        }
        // GET: Web
        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }
    }
}