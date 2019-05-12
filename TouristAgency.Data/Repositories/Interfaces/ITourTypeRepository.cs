using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on TourType table / class
    /// </summary>
    public interface ITourTypeRepository
    {
        /// <summary>
        /// Retrieve one TourType by Id
        /// </summary>
        /// <param name="tourTypeId"></param>
        /// <returns></returns>
        TourType GetTourType(int tourTypeId);
        /// <summary>
        /// Get all of the TourTypes in the database
        /// </summary>
        /// <returns></returns>
        ICollection<TourType> GetAllTourTypes();
        /// <summary>
        /// Remove the tourType with passed id from database
        /// </summary>
        /// <param name="tourTypeId"></param>
        /// <returns></returns>
        bool DeleteTourType(int tourTypeId);
        /// <summary>
        /// Update TourType with passed data
        /// </summary>
        /// <param name="tourType"></param>
        /// <returns></returns>
        TourType UpdateTourType(TourType tourType);
        /// <summary>
        /// Add a new TourType to the database
        /// </summary>
        /// <param name="tourType">TourType to be added</param>
        /// <returns>Newly added TourType</returns>
        TourType CreateTourType(TourType tourType);
    }
}
