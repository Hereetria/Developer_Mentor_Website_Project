

using AutoMapper;
using EntityLayer.Entities;
using DataAccessLayer.Contexts;
using DtoLayer.Dtos.ArticleCommentDtos;
using DataAccessLayer.Repositories;
using DataAccessLayer.Services.ArticleCommentServices;

namespace DataAccessLayer.Services.ArticleCommentServices
{
    
    public class ArticleCommentService : GenericRepository<ArticleComment, CreateArticleCommentDto, UpdateArticleCommentDto, ResultArticleCommentDto, ResultArticleCommentByIdDto, int>, IArticleCommentService

    {

        public ArticleCommentService(Context context, IMapper mapper)
            : base(context, mapper)
        {
        }

    }
}