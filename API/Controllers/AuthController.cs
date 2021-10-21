using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Succes)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Succes)
            {
                var returnUser = new UserForSuccessfullyDto()
                {
                    Id = userToLogin.Data.Id,
                    Email = userToLogin.Data.Email,
                    Name = userToLogin.Data.Name,
                    Lastname = userToLogin.Data.Lastname,
                    IsApproved = userToLogin.Data.IsApproved,
                    RoleId = userToLogin.Data.RoleId,
                    Token = result.Data.Token
                };
                return Ok(returnUser);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Succes)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Succes)
            {
                return Ok(registerResult.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
