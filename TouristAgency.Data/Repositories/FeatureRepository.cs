using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class FeatureRepository : IFeatureRepository
    {
        private DataModel _context;

        public FeatureRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteFeature(int FeatureId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Feature> GetAllFeatures()
        {
            return _context.Feature.ToList();
        }

        /// <inheritdoc/>
        public Feature GetFeature(int featureId)
        {
            return _context.Feature.FirstOrDefault(x => x.FeatureId == featureId);
        }

        ///<inheritdoc/>
        public Feature CreateFeature(Feature feature)
        {
            _context.Feature.Add(feature);
            return feature;
        }

        /// <inheritdoc/>
        public Feature UpdateFeature(Feature feature)
        {
            return Update(_context.Feature.FirstOrDefault(x => x.FeatureId == feature.FeatureId), feature);
        }

        private Feature Update(Feature feature, Feature newFeature)
        {
            feature.FeatureTypeId = newFeature.FeatureTypeId;
            feature.HotelId = newFeature.HotelId;
            feature.Price = newFeature.Price;
            return feature;
        }
    }
}
