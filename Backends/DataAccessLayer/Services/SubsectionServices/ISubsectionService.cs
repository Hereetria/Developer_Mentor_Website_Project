
using DtoLayer.Dtos.SubsectionDtos;
using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.Services.SubsectionServices
{

    public interface ISubsectionService : IGenericRepository<CreateSubsectionDto, UpdateSubsectionDto, ResultSubsectionDto, ResultSubsectionByIdDto, int>

    {

    }
}