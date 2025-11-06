using Ejercicio1_Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio3_WebApiApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SistemasController : ControllerBase
{
    static Sistema MiEmpresa=new Sistema();

    [HttpGet("CamionesCargados")]
    public ActionResult<string[]> GetCamonesCargados()
    {
        string[] camiones = MiEmpresa.CamionesCargados();

        if (camiones==null || camiones.Length==0)
            return NotFound("No hay camiones cargados.");

        return Ok(camiones);
    }

}
