using AutoMapper;
using Chaves.Data.Models;

namespace Chaves.Service.ImportPasswords.Perfil
{
    public class ImportMapperPerfil : Profile
    {

        public ImportMapperPerfil()
        {
            CreateMap<GooglePassword, Password>()
                 .ForMember(pass => pass.Service, opt => opt.MapFrom(google => google.Name))
                 .ForMember(pass => pass.User, opt => opt.MapFrom(google => google.Username))
                 .ForMember(pass => pass.Pass, opt => opt.MapFrom(google => google.Password));

            CreateMap<NortonPassword, Password>()
                .ForMember(pass => pass.Service, opt => opt.MapFrom(norton => norton.Title))
                .ForMember(pass => pass.User, opt => opt.MapFrom(norton => norton.Username))
                .ForMember(pass => pass.Pass, opt => opt.MapFrom(norton => norton.Password));
        }
    }
}
