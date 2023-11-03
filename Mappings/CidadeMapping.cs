using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilApi.Dtos;
using BrasilApi.Models;

namespace BrasilApi.Mappings
{
    public class CidadeMapping : Profile
    {
        public CidadeMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<CidadeResponse, CidadeModel>();
            CreateMap<CidadeModel, CidadeResponse>();
        }
    }
}