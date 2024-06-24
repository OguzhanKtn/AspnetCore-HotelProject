using AutoMapper;
using EntityLayer.Concrete;
using WebUI.Dtos.LoginDto;
using WebUI.Dtos.RegisterDto;
using WebUI.Dtos.ServiceDto;

namespace WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Services>().ReverseMap();
            CreateMap<UpdateServiceDto, Services>().ReverseMap();
            CreateMap<CreateServiceDto, Services>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
