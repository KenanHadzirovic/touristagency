using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IHotelService
    {
        ICollection<Hotel> GetHotels();
        Hotel GetHotel(int hotelId);
        Hotel UpdateHotel(Hotel hotel);
        Hotel CreateHotel(Hotel hotel);
        bool DeleteHotel(int hotelId);
    }
}
