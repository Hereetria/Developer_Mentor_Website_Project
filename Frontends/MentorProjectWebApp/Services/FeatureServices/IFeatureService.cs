﻿namespace MentorProjectWebApp.Services.FeatureServices
{
    using MentorProjectWebApp.Dtos.FeatureDtos;
    using MentorProjectWebApp.Repositories;

    public interface IFeatureService : IGenericRepository<CreateFeatureDto, UpdateFeatureDto, ResultFeatureDto, ResultFeatureByIdDto, int>
    {
        Task<List<ResultFeatureWithRelationsDto>> GetFeatureWithRelationsAsync();
        Task<ResultFeatureWithRelationsByIdDto> GetFeatureWithRelationsByIdAsync(int id);
    }

}
