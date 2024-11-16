using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenericDto<Endereco>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenericDto<Endereco>();
            using(var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResponse = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Endereco>(contentResponse);

                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResponse);
                }
            }
            return response;
        }

        public Task<ResponseGenericDto<Banco>> BuscarBanco(string codigoDoBanco)
        {
            throw new NotImplementedException();
        }        

        public Task<ResponseGenericDto<List<Banco>>> BuscarTodosOsBancos()
        {
            throw new NotImplementedException();
        }
    }
}