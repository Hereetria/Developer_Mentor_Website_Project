

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DtoLayer.Dtos.ArticleDetailDtos;
using DataAccessLayer.Services.ArticleDetailServices;
using BussinessLayer.Services.ArticleDetailServices;

namespace MentorProjectWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleDetailsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IArticleDetailManager _articleDetailService;

        public ArticleDetailsController(IArticleDetailManager articleDetailService, IMapper mapper)
        {
            _articleDetailService = articleDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticleDetailInfo()
        {
            try
            {
                var values = await _articleDetailService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing articleDetail information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleDetailById(int id)
        {
            try
            {
                var value = await _articleDetailService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"ArticleDetail information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving articleDetail information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleDetail(CreateArticleDetailDto createArticleDetailDto)
            {
            try
            {
                await _articleDetailService.CreateAsync(createArticleDetailDto);
                return Ok("ArticleDetail information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating articleDetail information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleDetail(int id)
        {
            try
            {
                await _articleDetailService.DeleteAsync(id);
                return Ok("ArticleDetail information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting articleDetail information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArticleDetail(UpdateArticleDetailDto updateArticleDetailDto)
        {
            try
            {
                await _articleDetailService.UpdateAsync(updateArticleDetailDto);
                return Ok("ArticleDetail information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating articleDetail information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleDetailWithRelations")]
        public async Task<IActionResult> GetArticleDetailWithRelations()
        {
            try
            {
                var values = await _articleDetailService.GetArticleDetailWithRelationsAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing articleDetail information: " + ex.Message);
            }
        }

        [HttpGet("GetArticleDetailWithRelations/{id}")]
        public async Task<IActionResult> GetArticleDetailWithRelations(int id)
        {
            try
            {
                var values = await _articleDetailService.GetArticleDetailWithRelationsByIdAsync(id);
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing articleDetail information: " + ex.Message);
            }
        }
    }
}