using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BrasilApi.Dtos;
using BrasilApi.Interfaces;
using BrasilApi.Models;

namespace BrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
         public async Task<ResponseGenerico<CidadeModel>> BuscarCidade(string cidade)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cidade}");

            var response = new ResponseGenerico<CidadeModel>();
            using(var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CidadeModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<List<AeroportoModel>>> BuscarTodosAeroportos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/");

            var response = new ResponseGenerico<List<AeroportoModel>>();
            using(var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<AeroportoModel>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<AeroportoModel>> BuscarAeroporto(string codigoIcao)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cptec/v1/clima/aeroporto/{codigoIcao}");

            var response = new ResponseGenerico<AeroportoModel>();
            using(var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<AeroportoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }   
    }
}