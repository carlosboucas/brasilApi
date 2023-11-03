using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrasilApi.Models;

namespace BrasilApi.Dtos
{
    public class CidadeResponse
    {
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? AtualizadoEm { get; set; }
        public List<CidadeModel>? Clima { get; set; }
        //public string? cityCode { get; set; }
        public string? Data { get; set; }
        public string? Condicao { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int IndiceUv { get; set; }
        public string? DescricaoCondicao { get; set; }
        // public class Root
        // {
        //     // public string? Cidade { get; set; }
        //     // public string? Estado { get; set; }
        //     // public string? AtualizadoEm { get; set; }
        //     // public List<CidadeModel>? Clima { get; set; }
        // }
    }
}