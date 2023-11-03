using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrasilApi.Dtos;
using BrasilApi.Interfaces;

namespace BrasilApi.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CidadeService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<CidadeResponse>> BuscarCidade(string cidade)
        {
            var city = await _brasilApi.BuscarCidade(cidade);
            return _mapper.Map<ResponseGenerico<CidadeResponse>>(city);
        }
    }
}