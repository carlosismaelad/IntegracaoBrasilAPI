using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenericDto<>), typeof(ResponseGenericDto<>));
            CreateMap<EnderecoResponseDto, Endereco>();
            CreateMap<Endereco, EnderecoResponseDto>();
        }
    }
}