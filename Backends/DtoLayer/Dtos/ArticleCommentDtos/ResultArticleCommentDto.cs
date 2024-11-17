

namespace DtoLayer.Dtos.ArticleCommentDtos
{
    public class ResultArticleCommentDto
    {
        public int ArticleCommentId { get; set; }
        public string Name { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; }
        public int? ParentCommentId { get; set; }
        public int ArticleDetailId { get; set; }
    }
}