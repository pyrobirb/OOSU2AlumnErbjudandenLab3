using AutoMapper;
using BusinessEntites.Models;
using WPFLayer.Models;

namespace WPFLayer.ViewModel
{
    internal class AlumnContextProfile : Profile
    {
        public void AlumnContextProfileConfig()
        {
            CreateMap<AlumnDTO, Alumn>().ReverseMap();
            CreateMap<Personal, PersonalDTO>().ReverseMap();
        }

    }
}