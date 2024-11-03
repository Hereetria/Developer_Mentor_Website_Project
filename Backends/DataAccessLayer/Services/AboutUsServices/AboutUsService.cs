

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.AboutUsDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.AboutUsServices;

namespace DataAccessLayer.Services.AboutUsServices
{
    
    public class AboutUsService : GenericRepository<AboutUs, CreateAboutUsDto, UpdateAboutUsDto, ResultAboutUsDto, ResultAboutUsByIdDto, int>, IAboutUsService

    {

        public AboutUsService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}