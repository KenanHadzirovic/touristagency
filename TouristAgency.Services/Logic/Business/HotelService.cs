using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class HotelService : IHotelService
    {
        private IHotelRepository _hotelRepository;

        HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public Contracts.Hotel CreateHotel(Contracts.Hotel hotel)
        {
            Model.Hotel efHotel = Mapper.Map<Contracts.Hotel, Model.Hotel>(hotel);
            efHotel = _hotelRepository.CreateHotel(efHotel);
            return Mapper.Map<Model.Hotel, Contracts.Hotel>(efHotel);
        }

        public Contracts.Hotel UpdateHotel(Contracts.Hotel hotel)
        {
            Model.Hotel efHotel = Mapper.Map<Contracts.Hotel, Model.Hotel>(hotel);
            _hotelRepository.UpdateHotel(efHotel);
            return hotel;
        }

        public ICollection<Contracts.Hotel> GetHotels()
        {
            return Mapper.Map<ICollection<Model.Hotel>, ICollection<Contracts.Hotel>>(_hotelRepository.GetAllHotels());
        }

        public Contracts.Hotel GetHotel(int hotelId)
        {
            return Mapper.Map<Model.Hotel, Contracts.Hotel>(_hotelRepository.GetHotel(hotelId));
        }

        public bool DeleteHotel(int hotelId)
        {
            return _hotelRepository.DeleteHotel(hotelId);
        }
    }
}
