using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        private readonly IRegisterHelloBL _registerHelloBL;
        private readonly ILogger<HelloAppController> _logger;

        public HelloAppController(ILogger<HelloAppController> logger, IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginDTO loginDTO)
        {
            try
            {
                _logger.LogInformation("Login attempt for user: {Username}", loginDTO.Email);

                var token = await _registerHelloBL.LoginUser(loginDTO); // Await the task

                if (string.IsNullOrEmpty(token))
                {
                    return Unauthorized(new ResponseModel<string>
                    {
                        Success = false,
                        Message = "Invalid email or password",
                        Data = string.Empty
                    });
                }

                return Ok(new ResponseModel<string>
                {
                    Success = true,
                    Message = "Login successful",
                    Data = token
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception during login for user: {Username}", loginDTO.Email);

                return StatusCode(500, new ResponseModel<string>
                {
                    Success = false,
                    Message = "An error occurred while processing login",
                    Data = ex.Message
                });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegistrationUser([FromBody] RegisterDTO registerDTO)
        {
            try
            {
                var result = await _registerHelloBL.RegisterBL(registerDTO); // Await the task

                var response = new ResponseModel<RegistrationResponse>
                {
                    Success = true,
                    Message = "Registration successful",
                    Data = result
                };

                return Created("User created", response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during user registration");

                return StatusCode(500, new ResponseModel<string>
                {
                    Success = false,
                    Message = "An error occurred during registration.",
                    Data = ex.Message
                });
            }
        }
    }
}
