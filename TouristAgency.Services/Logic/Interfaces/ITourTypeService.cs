using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface ITourTypeService
    {
        ICollection<TourType> GetTourTypes();
        TourType GetTourType(int tourTypeId);
        TourType UpdateTourType(TourType tourType);
        TourType CreateTourType(TourType tourType);
        bool DeleteTourType(int tourTypeId);
    }
}
