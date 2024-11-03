﻿namespace MentorProjectWebApp.Services.ArticleDetailServices
{
    using MentorProjectWebApp.Dtos.ArticleDetailDtos;
    using MentorProjectWebApp.Repositories;

    public interface IArticleDetailService : IGenericRepository<CreateArticleDetailDto, UpdateArticleDetailDto, ResultArticleDetailDto, ResultArticleDetailByIdDto, int>
    {
    }

}
