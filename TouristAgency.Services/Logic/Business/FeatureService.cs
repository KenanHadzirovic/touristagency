using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;


namespace TouristAgency.Services
{
    public class FeatureService : IFeatureService
    {
        private IFeatureRepository _featureRepository;

        FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public Contracts.Feature CreateFeature(Contracts.Feature feature)
        {
            Model.Feature efFeature = Mapper.Map<Contracts.Feature, Model.Feature>(feature);
            efFeature = _featureRepository.CreateFeature(efFeature);
            return Mapper.Map<Model.Feature, Contracts.Feature>(efFeature);
        }

        public Contracts.Feature UpdateFeature(Contracts.Feature feature)
        {
            Model.Feature efFeature = Mapper.Map<Contracts.Feature, Model.Feature>(feature);
            _featureRepository.UpdateFeature(efFeature);
            return feature;
        }

        public ICollection<Contracts.Feature> GetFeatures()
        {
            return Mapper.Map<ICollection<Model.Feature>, ICollection<Contracts.Feature>>(_featureRepository.GetAllFeatures());
        }

        public Contracts.Feature GetFeature(int featureId)
        {
            return Mapper.Map<Model.Feature, Contracts.Feature>(_featureRepository.GetFeature(featureId));
        }

        public bool DeleteFeature(int featureId)
        {
            return _featureRepository.DeleteFeature(featureId);
        }
    }
}
