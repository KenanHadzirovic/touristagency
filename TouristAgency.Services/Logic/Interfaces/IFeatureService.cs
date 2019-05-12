using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface IFeatureService
    {
        ICollection<Feature> GetFeatures();
        Feature GetFeature(int featureId);
        Feature UpdateFeature(Feature feature);
        Feature CreateFeature(Feature feature);
        bool DeleteFeature(int featureId);
    }
}
