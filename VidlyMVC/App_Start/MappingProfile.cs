using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using VidlyMVC.Dtos;
using VidlyMVC.Models;

namespace VidlyMVC.App_Start
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}