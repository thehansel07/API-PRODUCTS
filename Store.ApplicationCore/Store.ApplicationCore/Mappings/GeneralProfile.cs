using AutoMapper;
using Store.ApplicationCore.DTOs;
using Store.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.ApplicationCore.Mappings
{
    //This is useful to map automatically from the Request to the Entity and from the Entity to the Response.
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            //Request and Response
            CreateMap<CreateProductRequest, Product>();
            CreateMap<ProductResponse,Product>();

        }
    }
}
