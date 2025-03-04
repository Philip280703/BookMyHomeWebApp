using BookMyHome.Shared.Domain.Models;
namespace BookMyHomeWebApp.Persistence.Repositories
{
	public interface IBookingRepository
	{
		List<Booking> GetAllBookings();
		Booking GetBooking(int id);
		void AddBooking(Booking booking);
		bool DeleteBooking(int id);
	}
}
