using System.Collections.Generic;
using TouristAgency.Contracts;

namespace TouristAgency.Services
{
    public interface ITouristService
    {
        ICollection<Tourist> GetTourists();
        Tourist GetTourist(int touristId);
        Tourist UpdateTourist(Tourist tourist);
        Tourist CreateTourist(Tourist tourist);
        bool DeleteTourist(int touristId);
    }
}
