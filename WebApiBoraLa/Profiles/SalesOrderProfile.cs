using ApplicationServicesSO.Data.Dtos;
using ApplicationServicesSO.Models;
using AutoMapper;

namespace ApplicationServicesSO.Profiles
{
    public class SalesOrderProfile : Profile
    {
        public SalesOrderProfile()
        {
            CreateMap<AddEntitiesDto, SalesOrderModel>();
            CreateMap<SalesOrderModel, RecoverEntitiesDto>();
            CreateMap<UpdateEntitiesDto, SalesOrderModel>();

        }
    }
}
