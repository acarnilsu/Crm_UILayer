using AutoMapper;
using DTOLayer.DTOs.AnnouncementDtos;
using DTOLayer.DTOs.AppUserDtos;
using DTOLayer.DTOs.ProductDtos;
using EntityLayer.Concrete;

namespace Crm_UILayer.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Announcement, AnnouncementAddDto>();
            CreateMap<AnnouncementAddDto, Announcement>();


            CreateMap<Announcement, AnnouncementUpdateDto>();
            CreateMap<AnnouncementUpdateDto, Announcement>();


            CreateMap<Announcement, AnnouncementListDto>();
            CreateMap<AnnouncementListDto, Announcement>();


            CreateMap<AppUser, AppUserRegisterDto>();
            CreateMap<AppUserRegisterDto, AppUser>();


            CreateMap<Product,ProductAddDto>();
            CreateMap<ProductAddDto, Product>();
        }
    }
}
