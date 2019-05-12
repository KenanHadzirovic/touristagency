using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Tourist table / class
    /// </summary>
    public interface ITouristRepository
    {
        /// <summary>
        /// Retrieve one Tourist by Id
        /// </summary>
        /// <param name="touristId"></param>
        /// <returns></returns>
        Tourist GetTourist(int touristId);
        /// <summary>
        /// Get all of the Tourists in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Tourist> GetAllTourists();
        /// <summary>
        /// Remove the Tourist with passed id from database
        /// </summary>
        /// <param name="touristId"></param>
        /// <returns></returns>
        bool DeleteTourist(int touristId);
        /// <summary>
        /// Update Tourist with passed data
        /// </summary>
        /// <param name="tourist"></param>
        /// <returns></returns>
        Tourist UpdateTourist(Tourist tourist);
        /// <summary>
        /// Add a new Tourist to the database
        /// </summary>
        /// <param name="tourist">Tourist to be added</param>
        /// <returns>Newly added Tourist</returns>
        Tourist CreateTourist(Tourist tourist);
    }
}
