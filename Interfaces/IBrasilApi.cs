using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilApi.Dtos;
using BrasilApi.Models;

namespace BrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<CidadeModel>> BuscarCidade(string cidade);
        Task<ResponseGenerico<List<AeroportoModel>>> BuscarTodosAeroportos(); 
        Task<ResponseGenerico<AeroportoModel>> BuscarAeroporto(string codigoIcao);
    }
}