using Microsoft.AspNetCore.Mvc;
namespace ExercicioAPI.Web.Controllers
{
    [ApiController]
    [Route("ControllerCalculadora")]
    public class CalculadoraApi : ControllerBase
    {
        [HttpGet("Somar")]
        public IActionResult SomaAPI(int num1, int num2){
            if (num1 == 1 || num1 > 999 || num2 == 1 || num2 > 999)
            {
                return BadRequest("BadRequest(400): Os Parâmetros devem ser maior que 0 e menor que 999");
            }
            var resultado =  num1 + num2;
            return Ok($"Resultado: {resultado}");
        }

        [HttpGet("Subtrair")]
        public IActionResult SubtracaoAPI(int num1, int num2){
            var resultado =  num1 - num2;
            return Ok($"Resultado: {resultado}");
        }

        [HttpGet("Multi")]
        public IActionResult MultiAPI(int num1, int num2){
            var resultado =  num1 * num2;
            return Ok($"Resultado: {resultado}");
        }

        [HttpGet("Divisao")]
        public IActionResult DivisaoAPI(int num1, int num2){
            var resultado =  num1 / num2;
            return Ok($"Resultado: {resultado}");
        }
    }
}