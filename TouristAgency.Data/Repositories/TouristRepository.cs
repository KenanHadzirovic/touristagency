using System.Collections.Generic;
using System.Linq;

namespace TouristAgency.Data.Repositories
{
    /// <inheritdoc/>
    public class TouristRepository : ITouristRepository
    {
        private DataModel _context;

        TouristRepository(DataModel context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public bool DeleteTourist(int TouristId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public ICollection<Tourist> GetAllTourists()
        {
            return _context.Tourist.ToList();
        }

        /// <inheritdoc/>
        public Tourist GetTourist(int touristId)
        {
            return _context.Tourist.FirstOrDefault(x => x.TouristId == touristId);
        }

        /// <inheritdoc/>
        public Tourist CreateTourist(Tourist tourist)
        {
            _context.Tourist.Add(tourist);
            return tourist;
        }

        /// <inheritdoc/>
        public Tourist UpdateTourist(Tourist tourist)
        {
            return Update(_context.Tourist.FirstOrDefault(x => x.TouristId == tourist.TouristId), tourist);
        }

        private Tourist Update(Tourist tourist, Tourist newTourist)
        {
            tourist.TouristId = newTourist.TouristId;
            tourist.SSN = newTourist.SSN;
            tourist.FirstName = newTourist.FirstName;
            tourist.LastName = newTourist.LastName;
            tourist.DateOfBirth = newTourist.DateOfBirth;
            tourist.Address = newTourist.Address;

            return tourist;
        }
    }
}
