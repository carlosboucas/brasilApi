using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrasilApi.Models
{
    public class CidadeModel
    {
        [JsonPropertyName("cidade")]
        public string? Cidade { get; set; }

        [JsonPropertyName("estado")]
        public string? Estado { get; set; }

        [JsonPropertyName("atualizado_em")]
        public string? AtualizadoEm { get; set; }

        [JsonPropertyName("clima")]
        public List<CidadeModel>? Clima { get; set; }
        // [JsonPropertyName("cityCode")]
        // public string? cityCode { get; set; }
        [JsonPropertyName("data")]
        public string? Data { get; set; }

        [JsonPropertyName("condicao")]
        public string? Condicao { get; set; }

        [JsonPropertyName("min")]
        public int Min { get; set; }

        [JsonPropertyName("max")]
        public int Max { get; set; }

        [JsonPropertyName("indice_uv")]
        public int IndiceUv { get; set; }

        [JsonPropertyName("condicao_desc")]
        public string? DescricaoCondicao { get; set; }

        // public class Root
        // {
        //     [JsonPropertyName("cidade")]
        //     public string? Cidade { get; set; }

        //     [JsonPropertyName("estado")]
        //     public string? Estado { get; set; }

        //     [JsonPropertyName("atualizado_em")]
        //     public string? AtualizadoEm { get; set; }

        //     [JsonPropertyName("clima")]
        //     public List<CidadeModel>? Clima { get; set; }
        // }
    }
}