using BookMyHome.Shared.Domain.Models;

namespace BookMyHomeWebApp.Client.Services.Interfaces
{
	public interface IBookingService
	{
		Task<Booking[]?> GetAllBookings();
		Task<Booking?> GetBooking(int id);
		Task<int> AddBooking(Booking booking);
		Task<int> UpdateBooking(Booking booking);
		Task<int> DeleteBooking(int id);
	}
}
