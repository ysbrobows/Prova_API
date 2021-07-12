
using Confitec.Domain.Entities;
using Confitec.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Confitec.WebApi.Controllers
{
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IRepository _userRepo;

        public UsuariosController(IRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("api/usuario/GetUsuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            try
            {
                var result = await _userRepo.GetUsers();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("api/usuario/GetUsuarioById")]
        public async Task<IActionResult> GetUsuarioById(int UsuarioId)
        {
            try
            {
                var result = await _userRepo.GetUser(UsuarioId);
                return Ok("result");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("api/usuario/post")]
        public async Task<IActionResult> Add(Usuario model)
        {
            try
            {
                _userRepo.Add(model);

                if (await _userRepo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }


        [HttpPost]
        [Route("api/usuario/delete")]
        public async Task<IActionResult> Delete(Usuario model)
        {
            try
            {
                _userRepo.Delete(model);

                if (await _userRepo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPost]
        [Route("api/usuario/update")]
        public async Task<IActionResult> Update(Usuario model)
        {
            try
            {
                _userRepo.Update(model);

                if (await _userRepo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

    }
}


