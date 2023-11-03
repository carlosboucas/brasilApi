using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilApi.Dtos;

namespace BrasilApi.Interfaces
{
    public interface IAeroportoService
    {
        Task<ResponseGenerico<List<AeroportoResponse>>> BuscarTodosAeroportos(); 
        Task<ResponseGenerico<AeroportoResponse>> BuscarAeroporto(string codigoIcao);
    }
}