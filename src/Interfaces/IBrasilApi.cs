using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenericDto<Endereco>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenericDto<List<Banco>>> BuscarTodosOsBancos();
        Task<ResponseGenericDto<Banco>> BuscarBanco(string codigoDoBanco);
    }
}