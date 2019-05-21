using AutoMapper;
using System.Collections.Generic;
using TouristAgency.Data.Repositories;
using Model = TouristAgency.Data;

namespace TouristAgency.Services
{
    public class HotelService : IHotelService
    {
        private IHotelRepository _hotelRepository;
        private IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, IMapper mapper)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }

        public Contracts.Hotel CreateHotel(Contracts.Hotel hotel)
        {
            Model.Hotel efHotel = _mapper.Map<Contracts.Hotel, Model.Hotel>(hotel);
            efHotel = _hotelRepository.CreateHotel(efHotel);
            return _mapper.Map<Model.Hotel, Contracts.Hotel>(efHotel);
        }

        public Contracts.Hotel UpdateHotel(Contracts.Hotel hotel)
        {
            Model.Hotel efHotel = _mapper.Map<Contracts.Hotel, Model.Hotel>(hotel);
            _hotelRepository.UpdateHotel(efHotel);
            return hotel;
        }

        public ICollection<Contracts.Hotel> GetHotels()
        {
            return _mapper.Map<ICollection<Model.Hotel>, ICollection<Contracts.Hotel>>(_hotelRepository.GetAllHotels());
        }

        public Contracts.Hotel GetHotel(int hotelId)
        {
            return _mapper.Map<Model.Hotel, Contracts.Hotel>(_hotelRepository.GetHotel(hotelId));
        }

        public bool DeleteHotel(int hotelId)
        {
            return _hotelRepository.DeleteHotel(hotelId);
        }
    }
}
