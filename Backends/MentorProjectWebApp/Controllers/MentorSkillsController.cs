

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MentorProjectWebApp.Dtos.MentorSkillDtos;
using .Services.MentorSkillServices;

namespace MentorProjectWebApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MentorSkillsController : ControllerBase

    {

        private readonly IMapper _mapper;
        private readonly IMentorSkillService _mentorSkillService;

        public MentorSkillsController(IMentorSkillService mentorSkillService, IMapper mapper)
        {
            _mentorSkillService = mentorSkillService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMentorSkillInfo()
        {
            try
            {
                var values = await _mentorSkillService.GetAllAsync();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while listing mentorSkill information: " + ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMentorSkillById(int id)
        {
            try
            {
                var value = await _mentorSkillService.GetByIdAsync(id);
                if (value == null)
                {
                    return NotFound($"MentorSkill information not found: {id}");
                }
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving mentorSkill information: " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorSkill(CreateMentorSkillDto createMentorSkillDto)
            {
            try
            {
                await _mentorSkillService.CreateAsync(createMentorSkillDto);
                return Ok("MentorSkill information successfully created.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while creating mentorSkill information: " + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentorSkill(int id)
        {
            try
            {
                await _mentorSkillService.DeleteAsync(id);
                return Ok("MentorSkill information successfully deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while deleting mentorSkill information: " + ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMentorSkill(UpdateMentorSkillDto updateMentorSkillDto)
        {
            try
            {
                await _mentorSkillService.UpdateAsync(updateMentorSkillDto);
                return Ok("MentorSkill information successfully updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while updating mentorSkill information: " + ex.Message);
            }
        }

    }
}