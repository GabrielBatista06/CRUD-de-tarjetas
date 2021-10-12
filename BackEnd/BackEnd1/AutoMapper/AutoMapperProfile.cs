using AutoMapper;
using BackEnd1.DTOs;
using BackEnd1.Models;

namespace BackEnd1.AutoMapper
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<TarjetaCredito, TarjetaCreditoDTO>().ReverseMap();
        }
    }
}
