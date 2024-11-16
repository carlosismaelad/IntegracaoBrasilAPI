using IntegraBrasilApi.Dtos;

namespace IntegraBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenericDto<EnderecoResponseDto>> BuscarEndereco(string cep);        
    }
}