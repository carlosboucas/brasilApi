using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilApi.Dtos;
using BrasilApi.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BrasilApi.Services
{
    public class AeroportoService : IAeroportoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public AeroportoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<AeroportoResponse>>> BuscarTodosAeroportos()
        {
            var aeroportos = await _brasilApi.BuscarTodosAeroportos();
            return _mapper.Map<ResponseGenerico<List<AeroportoResponse>>>(aeroportos);
        }
        public async Task<ResponseGenerico<AeroportoResponse>> BuscarAeroporto(string codigoIcao)
        {
            var aeroporto = await _brasilApi.BuscarAeroporto(codigoIcao);
            return _mapper.Map<ResponseGenerico<AeroportoResponse>>(codigoIcao);
        }
    }
}