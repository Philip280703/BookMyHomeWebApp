using BookMyHome.Shared.Domain.Models;
using BookMyHomeWebApp.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookMyHomeWebApp.Command
{
	[ApiController]
	[Route("api/booking")]
	public class BookingCommand : ControllerBase
	{
		private readonly IBookingRepository _bookingRepository = new BookingRepositorySql();

		public BookingCommand(IBookingRepository bookingRepository)
		{
			if (_bookingRepository == null && bookingRepository != null)
			{
				_bookingRepository = bookingRepository;
				Console.WriteLine("Repository initialiseret");
			}
		}

		[HttpGet]
		public IEnumerable<Booking> GetAllBookings() 
		{ 
			return _bookingRepository.GetAllBookings();
		}

		[HttpGet("{id:int}")]
		public Booking GetBooking(int id) 
		{ 
			var booking = _bookingRepository.GetBooking(id);
			return booking;
		}

		[HttpPost]
		public void AddBooking(Booking booking) 
		{ 
			_bookingRepository.AddBooking(booking);
		}

		[HttpPut]
		public void UpdateBooking(Booking booking) 
		{
			// update 
		}

		[HttpDelete]
		public StatusCodeResult DeleteBooking(int id)
		{
			Console.WriteLine("Server: Slet booking kaldet: id = " + id);

			bool deleted = _bookingRepository.DeleteBooking(id);
			if (deleted)
			{
				Console.WriteLine("Server: booking slettet success");
				int code = (int)HttpStatusCode.OK;
				return new StatusCodeResult(code);
			}
			else
			{
				Console.WriteLine("Server: booking ikke slettet - ikke fundet");
				int code = (int)HttpStatusCode.NotFound;
				return new StatusCodeResult(code);
			}
		}

	}
}
