using BookMyHome.Shared.Domain.Models;
using BookMyHomeWebApp.Persistence.ContextDB;

namespace BookMyHomeWebApp.Persistence.Repositories
{
	public class BookingRepositorySql : IBookingRepository
	{
        MyDbContext db = new MyDbContext();
        public BookingRepositorySql()
        {
            
        }

        public void AddBooking(Booking booking)
		{
			db.BookingEF.Add(booking);
			db.SaveChanges();
            Console.WriteLine("Booking added to database");
        }

        public bool DeleteBooking(int id)
        {
            var booking = db.BookingEF.Find(id);
            if(booking == null)
            {
                return false;    
            }
            db.BookingEF.Remove(booking);
            db.SaveChanges();
            return true;
        }

        public List<Booking> GetAllBookings()
		{
			return db.BookingEF.ToList();
		}

        public Booking GetBooking(int id)
        {
            return db.BookingEF.Find(id);
        }
    }
}
