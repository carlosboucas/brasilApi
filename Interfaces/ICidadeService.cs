using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilApi.Dtos;

namespace BrasilApi.Interfaces
{
    public interface ICidadeService
    {
        Task<ResponseGenerico<CidadeResponse>> BuscarCidade(string cidade);
    }
}