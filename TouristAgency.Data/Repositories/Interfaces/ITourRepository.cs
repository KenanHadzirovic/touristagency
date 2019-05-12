using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Tour table / class
    /// </summary>
    public interface ITourRepository
    {
        /// <summary>
        /// Retrieve one Tour by Id
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        Tour GetTour(int tourId);
        /// <summary>
        /// Get all of the Tours in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Tour> GetAllTours();
        /// <summary>
        /// Remove the Tour with passed id from database
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        bool DeleteTour(int tourId);
        /// <summary>
        /// Update Tour with passed data
        /// </summary>
        /// <param name="tour"></param>
        /// <returns></returns>
        Tour UpdateTour(Tour tour);
        /// <summary>
        /// Add a new Tour to the database
        /// </summary>
        /// <param name="tour">Tour to be added</param>
        /// <returns>Newly added Tour</returns>
        Tour CreateTour(Tour tour);
    }
}
