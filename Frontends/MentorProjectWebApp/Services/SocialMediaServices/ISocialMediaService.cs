﻿using MentorProjectWebApp.Dtos.SocialMediaDtos;
using MentorProjectWebApp.Repositories;

namespace MentorProjectWebApp.Services.SocialMediaServices
{
    public interface ISocialMediaService : IGenericRepository<CreateSocialMediaDto, UpdateSocialMediaDto, ResultSocialMediaDto, ResultSocialMediaByIdDto, int>
    {
    }
}
