using System.Collections.Generic;

namespace TouristAgency.Data.Repositories
{
    /// <summary>
    /// Repository for data manipulation on Feature table / class
    /// </summary>
    public interface IFeatureRepository
    {
        /// <summary>
        /// Retrieve one Feature by Id
        /// </summary>
        /// <param name="featureId"></param>
        /// <returns></returns>
        Feature GetFeature(int featureId);
        /// <summary>
        /// Get all of the Features in the database
        /// </summary>
        /// <returns></returns>
        ICollection<Feature> GetAllFeatures();
        /// <summary>
        /// Remove the Feature with passed id from database
        /// </summary>
        /// <param name="featureId"></param>
        /// <returns></returns>
        bool DeleteFeature(int featureId);
        /// <summary>
        /// Update Feature with passed data
        /// </summary>
        /// <param name="feature"></param>
        /// <returns></returns>
        Feature UpdateFeature(Feature feature);
    }
}
