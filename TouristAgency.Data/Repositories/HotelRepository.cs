using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class HotelRepository : IHotelRepository
    {
        private DataModel _context;

        public HotelRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteHotel(int HotelId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Hotel> GetAllHotels()
        {
            return _context.Hotel.ToList();
        }

        /// <inheritdoc/>
        public Hotel GetHotel(int hotelId)
        {
            return _context.Hotel.FirstOrDefault(x => x.HotelId == hotelId);
        }

        ///<inheritdoc/>
        public Hotel CreateHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);
            return hotel;
        }

        /// <inheritdoc/>
        public Hotel UpdateHotel(Hotel hotel)
        {
            return Update(_context.Hotel.FirstOrDefault(x => x.HotelId == hotel.HotelId), hotel);
        }

        private Hotel Update(Hotel hotel, Hotel newHotel)
        {
            hotel.HotelId = newHotel.HotelId;
            hotel.Name = newHotel.Name;
            hotel.Phone = newHotel.Phone;
            hotel.Stars = newHotel.Stars;
            hotel.Website = newHotel.Website;
            hotel.Address = newHotel.Address;
            hotel.City = newHotel.City;
            hotel.Country = newHotel.Country;
            return hotel;
        }
    }
}
