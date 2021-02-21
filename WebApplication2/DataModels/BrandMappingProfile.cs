using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Entities;
using WebApplication2.ViewModels;

namespace WebApplication2.DataBase
{
    public class BrandMappingProfile : Profile
    {
        public BrandMappingProfile()
        {
            CreateMap<Brand, BrandViewModel>()
                .ForMember(o => o.BrandId, ex=>ex.MapFrom(o => o.ID))
                .ForMember(o => o.BrandName, ex =>ex.MapFrom(o => o.Name))
                .ForMember(o => o.State, ex => ex.MapFrom(o => o.IsActive))
                .ReverseMap();
        }
    }
}
