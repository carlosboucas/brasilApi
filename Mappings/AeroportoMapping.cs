using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilApi.Dtos;
using BrasilApi.Models;

namespace BrasilApi.Mappings
{
    public class AeroportoMapping : Profile
    {
         public AeroportoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<AeroportoResponse, AeroportoModel>();
            CreateMap<AeroportoModel, AeroportoResponse>();
        }
    }
}