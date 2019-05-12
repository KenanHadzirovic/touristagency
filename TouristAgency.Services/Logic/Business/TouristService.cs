using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class TouristService : ITouristService
    {
        private ITouristRepository _touristRepository;

        TouristService(ITouristRepository touristRepository)
        {
            _touristRepository = touristRepository;
        }

        public Contracts.Tourist CreateTourist(Contracts.Tourist tourist)
        {
            Model.Tourist efTourist = Mapper.Map<Contracts.Tourist, Model.Tourist>(tourist);
            efTourist = _touristRepository.CreateTourist(efTourist);
            return Mapper.Map<Model.Tourist, Contracts.Tourist>(efTourist);
        }

        public Contracts.Tourist UpdateTourist(Contracts.Tourist tourist)
        {
            Model.Tourist efTourist = Mapper.Map<Contracts.Tourist, Model.Tourist>(tourist);
            _touristRepository.UpdateTourist(efTourist);
            return tourist;
        }

        public ICollection<Contracts.Tourist> GetTourists()
        {
            return Mapper.Map<ICollection<Model.Tourist>, ICollection<Contracts.Tourist>>(_touristRepository.GetAllTourists());
        }

        public Contracts.Tourist GetTourist(int touristId)
        {
            return Mapper.Map<Model.Tourist, Contracts.Tourist>(_touristRepository.GetTourist(touristId));
        }

        public bool DeleteTourist(int touristId)
        {
            return _touristRepository.DeleteTourist(touristId);
        }
    }
}
