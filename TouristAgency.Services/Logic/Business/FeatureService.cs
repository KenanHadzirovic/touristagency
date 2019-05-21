using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;


namespace TouristAgency.Services
{
    public class FeatureService : IFeatureService
    {
        private IFeatureRepository _featureRepository;
        private IMapper _mapper;

        public FeatureService(IFeatureRepository featureRepository, IMapper mapper)
        {
            _mapper = mapper;
            _featureRepository = featureRepository;
        }

        public Contracts.Feature CreateFeature(Contracts.Feature feature)
        {
            Model.Feature efFeature = _mapper.Map<Contracts.Feature, Model.Feature>(feature);
            efFeature = _featureRepository.CreateFeature(efFeature);
            return _mapper.Map<Model.Feature, Contracts.Feature>(efFeature);
        }

        public Contracts.Feature UpdateFeature(Contracts.Feature feature)
        {
            Model.Feature efFeature = _mapper.Map<Contracts.Feature, Model.Feature>(feature);
            _featureRepository.UpdateFeature(efFeature);
            return feature;
        }

        public ICollection<Contracts.Feature> GetFeatures()
        {
            return _mapper.Map<ICollection<Model.Feature>, ICollection<Contracts.Feature>>(_featureRepository.GetAllFeatures());
        }

        public Contracts.Feature GetFeature(int featureId)
        {
            return _mapper.Map<Model.Feature, Contracts.Feature>(_featureRepository.GetFeature(featureId));
        }

        public bool DeleteFeature(int featureId)
        {
            return _featureRepository.DeleteFeature(featureId);
        }
    }
}
