using BookMyHome.Shared.Domain.Models;
using BookMyHomeWebApp.Client.Services.Interfaces;
using System.Net.Http.Json;

namespace BookMyHomeWebApp.Client.Services
{
	public class BookingService : IBookingService
	{
		private readonly HttpClient _httpClient;

		public BookingService(HttpClient httpClient) 
		{ 
			_httpClient = httpClient;
		}

		public Task<Booking[]?> GetAllBookings()
		{
			var bookings = _httpClient.GetFromJsonAsync<Booking[]>("api/booking");
			return bookings;
		}

		public async Task<Booking?> GetBooking(int id)
		{
			var booking = await _httpClient.GetFromJsonAsync<Booking>("api/booking/" + id);
			return booking;
		}

		public async Task<int> AddBooking(Booking booking)
		{
			var answer = await _httpClient.PostAsJsonAsync("api/booking/", booking);
			var answerStatus = answer.StatusCode;
			return (int)answerStatus;
		}

		public async Task<int> UpdateBooking(Booking booking)
		{
			var answer = await _httpClient.PutAsJsonAsync("api/booking/", booking);
			var answerStatus = answer.StatusCode;
			return (int)answerStatus;
		}

		public async Task<int> DeleteBooking(int id)
		{
			var answer = await _httpClient.DeleteAsync("api/booking/" + id);
			var answerStatus = answer.StatusCode;
			return (int)answerStatus;
		}

	}
}
