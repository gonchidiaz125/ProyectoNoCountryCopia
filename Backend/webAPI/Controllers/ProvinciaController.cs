﻿using Microsoft.AspNetCore.Mvc;
using webAPI.Database;
using webAPI.Models;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("api/Provincias")]
    public class ProvinciaController(AppDbContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Provincia>> GetProvincias()
        {
            try
            {
                var provincias = context.Provincias.ToList();

                return Ok(provincias);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrió un error al procesar la solicitud: {ex.Message}");
            }
        }

        [HttpGet("{idProvincia}")]
        public ActionResult<Provincia> GetProvincia(int idProvincia)
        {
            try
            {
                var provincia = context.Provincias.FirstOrDefault(p => p.Id == idProvincia);

                if (provincia is null)
                {
                    throw new Exception("¡Registro no encontrado!");
                }

                return Ok(provincia);
            }
            catch (Exception ex)
            {
                return BadRequest($"Ocurrió un error al procesar la solicitud: {ex.Message}");
            }
        }
    }
}
