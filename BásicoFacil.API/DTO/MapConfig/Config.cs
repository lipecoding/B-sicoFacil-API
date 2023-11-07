using AutoMapper;
using BásicoFacil.API.DTO.Request;
using BásicoFacil.API.DTO.Response;
using BásicoFacil.API.Entity;

namespace BásicoFacil.API.DTO.MapConfig
{
    public class Config : Profile
    {
        public Config() 
        { 
            CreateMap<UserData, AddDataRequest>().ReverseMap();
            CreateMap<UserData, AddDataResponse>().ReverseMap();
        }
    }
}
