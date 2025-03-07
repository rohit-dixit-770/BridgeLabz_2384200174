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

                var token = await _registerHelloBL.LoginUser(loginDTO); 

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
                var result = await _registerHelloBL.RegisterBL(registerDTO); 

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

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO forgotPasswordDTO)
        {
            try
            {
                var result = await _registerHelloBL.ForgotPassword(forgotPasswordDTO);
                return Ok(new ResponseModel<string>
                {
                    Success = true,
                    Message = result,
                    Data = null
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during forgot password request");
                return StatusCode(500, new ResponseModel<string>
                {
                    Success = false,
                    Message = "An error occurred while processing forgot password request.",
                    Data = ex.Message
                });
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDTO resetPasswordDTO)
        {
            try
            {
                var result = await _registerHelloBL.ResetPassword(resetPasswordDTO);
                return Ok(new ResponseModel<string>
                {
                    Success = result,
                    Message = result ? "Password reset successfully" : "Invalid token or expired",
                    Data = null
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during reset password request");
                return StatusCode(500, new ResponseModel<string>
                {
                    Success = false,
                    Message = "An error occurred while processing reset password request.",
                    Data = ex.Message
                });
            }
        }

    }
}
