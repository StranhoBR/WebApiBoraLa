using ApplicationServicesSO.Data.Dtos;
using ApplicationServicesSO.Models;
using AutoMapper;

namespace ApplicationServicesSO.Profiles
{
    public class SalesOrderProfile : Profile
    {
        public SalesOrderProfile()
        {
            CreateMap<AddEntitiesDto, WebApiBoraLa>();
            CreateMap<WebApiBoraLa, RecoverEntitiesDto>();
            CreateMap<UpdateEntitiesDto, WebApiBoraLa>();

        }
    }
}
