using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{

    public interface IHotelRepository
    {
        /// <summary>
        /// Retrieve one Hotel by Id
        /// </summary>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        Hotel GetHotel(int hotelId);
        /// <summary>
        /// Get all of the Hotels in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Hotel> GetAllHotels();
        /// <summary>
        /// Remove the Hotel with passed id from database
        /// </summary>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        bool DeleteHotel(int hotelId);
        /// <summary>
        /// Update Hotel with passed data
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        Hotel UpdateHotel(Hotel hotel);
        /// <summary>
        /// Add a new Hotel to the database
        /// </summary>
        /// <param name="hotel">Hotel to be added</param>
        /// <returns>Newly added Hotel</returns>
        Hotel CreateHotel(Hotel hotel);
    }
}
