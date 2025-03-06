using System;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Entity;
using StackExchange.Redis;
using System.Text.Json;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        private readonly ILogger<RegisterHelloBL> _logger;
        private readonly IConnectionMultiplexer _redis;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL, ILogger<RegisterHelloBL> logger, IConnectionMultiplexer redis)
        {
            _registerHelloRL = registerHelloRL;
            _logger = logger;
            _redis = redis;
        }

        public async Task<string> LoginUser(LoginDTO loginDTO)
        {
            try
            {
                string cacheKey = $"user_login_{loginDTO.Email}";
                var cache = _redis.GetDatabase();

                var cachedToken = await cache.StringGetAsync(cacheKey);
                if (!cachedToken.IsNullOrEmpty)
                {
                    _logger.LogInformation("Cache hit: Returning cached token for {Email}", loginDTO.Email);
                    return cachedToken.ToString();
                }

                string result = await _registerHelloRL.Login(loginDTO);

                if (!string.IsNullOrEmpty(result))
                {
                    _logger.LogInformation("Login successful for user: {Email}", loginDTO.Email);
                    await cache.StringSetAsync(cacheKey, result, TimeSpan.FromMinutes(30));
                }
                else
                {
                    _logger.LogWarning("Login failed for user: {Email}", loginDTO.Email);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for user: {Email}", loginDTO.Email);
                throw;
            }
        }

        public async Task<RegistrationResponse> RegisterBL(RegisterDTO registerDTO)
        {
            try
            {
                var result = await _registerHelloRL.Registration(registerDTO);
                var response = new RegistrationResponse
                {
                    UserId = result.UserId,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    Email = result.Email
                };

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in user registration");
                throw;
            }
        }
    }
}
