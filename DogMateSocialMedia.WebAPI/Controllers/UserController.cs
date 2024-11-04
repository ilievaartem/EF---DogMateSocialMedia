using DogMateSocialMedia.BusinessLogicLayer.DTO.Request;
using DogMateSocialMedia.BusinessLogicLayer.Interfaces.Services;
using DogMateSocialMedia.DataAccessLayer.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace EF___DogMateSocialMedia.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService userService;

    public UserController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<UserDTO>> GetByIdAsync([FromRoute] int id)
    {
        try
        {
            var user = await userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { Message = "User not found" });
            }

            return Ok(user);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
        }
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsersAsync([FromQuery] UserParameters userParameters)
    {
        try
        {
            var users = await userService.GetAllUsersAsync(userParameters);
            return Ok(users);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> CreateUserAsync([FromBody] UserDTO userCreateRequest)
    {
        try
        {
            await userService.CreateUserAsync(userCreateRequest);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = userCreateRequest.Id }, userCreateRequest);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> DeleteUserAsync([FromRoute] int id)
    {
        try
        {
            await userService.DeleteUserAsync(id);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new { e.Message });
        }
    }
}