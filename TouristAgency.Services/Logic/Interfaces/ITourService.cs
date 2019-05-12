using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface ITourService
    {
        ICollection<Tour> GetTours();
        Tour GetTour(int tourId);
        Tour UpdateTour(Tour tour);
        Tour CreateTour(Tour tour);
        bool DeleteTour(int tourId);
    }
}
