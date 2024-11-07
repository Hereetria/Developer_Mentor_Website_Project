
using DtoLayer.Dtos.MentorDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.MentorServices
{

    public interface IMentorService : IGenericRepository<CreateMentorDto, UpdateMentorDto, ResultMentorDto, ResultMentorByIdDto, int>

    {

    }
}