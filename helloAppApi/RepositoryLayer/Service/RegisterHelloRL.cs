using System;
using System.Linq;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using RepositoryLayer.Helper;
using StackExchange.Redis;
using System.Text.Json;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        private readonly ILogger<RegisterHelloRL> _logger;
        private readonly HelloAppContext _DbContext;
        private readonly JwtHelper _jwtHelper;
        private readonly IConnectionMultiplexer _redis;

        public RegisterHelloRL(ILogger<RegisterHelloRL> logger, HelloAppContext DbContext, JwtHelper jwtHelper, IConnectionMultiplexer redis)
        {
            _logger = logger;
            _DbContext = DbContext;
            _jwtHelper = jwtHelper;
            _redis = redis;
        }

        public async Task<string> Login(LoginDTO login)
        {
            try
            {
                _logger.LogInformation("Attempting login for email: {Email}", login.Email);
                var cacheKey = $"user_login_{login.Email}";
                var cache = _redis.GetDatabase();

                var cachedToken = await cache.StringGetAsync(cacheKey);
                if (!cachedToken.IsNullOrEmpty)
                {
                    _logger.LogInformation("Cache hit: Returning cached token for {Email}", login.Email);
                    return cachedToken.ToString();
                }

                var user = await _DbContext.AllUsers.FirstOrDefaultAsync(u => u.Email == login.Email && u.Password == login.Password);

                if (user == null)
                {
                    _logger.LogWarning("Login failed for email: {Email} - Invalid credentials", login.Email);
                    return string.Empty;
                }

                var token = _jwtHelper.Tokenize(user);
                await cache.StringSetAsync(cacheKey, token, TimeSpan.FromMinutes(30));

                _logger.LogInformation("Login successful for email: {Email}", login.Email);
                return token;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during login for email: {Email}", login.Email);
                throw;
            }
        }

        public async Task<UserEntity> Registration(RegisterDTO registerDTO)
        {
            try
            {
                _logger.LogInformation("Registering new user: {Email}", registerDTO.Email);
                var existingUser = await _DbContext.AllUsers.FirstOrDefaultAsync(u => u.Email == registerDTO.Email);

                if (existingUser != null)
                {
                    _logger.LogWarning("Registration failed - Email already exists: {Email}", registerDTO.Email);
                    return existingUser;
                }

                var newUser = new UserEntity
                {
                    FirstName = registerDTO.FirstName,
                    LastName = registerDTO.LastName,
                    Email = registerDTO.Email,
                    Password = registerDTO.Password
                };

                await _DbContext.AllUsers.AddAsync(newUser);
                await _DbContext.SaveChangesAsync();

                _logger.LogInformation("User registered successfully: {Email}", registerDTO.Email);
                return newUser;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during registration for email: {Email}", registerDTO.Email);
                throw;
            }
        }
    }
}
