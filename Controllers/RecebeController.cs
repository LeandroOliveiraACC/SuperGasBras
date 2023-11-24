using Microsoft.AspNetCore.Mvc;
using TesteSuper.Models;

[ApiController]
[Route("api/process")]
public class RecebeController : ControllerBase
{
    [HttpPost("string")]
    public ActionResult<string> ConcatenateString([FromBody] Recebe inputModel)
    {
        try
        {
            var validator = new Validador();
            var validadorResult = validator.Validate(inputModel);

            if (validadorResult.IsValid)
            {
                string recebido = ConcatenaRecebido(inputModel.InputString);
                return recebido;
            }
            else
            {
                var errors = validadorResult.Errors.Select(e => e.ErrorMessage);
                return BadRequest(new { Errors = errors });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no método RecebeController: {ex.Message}");
            return StatusCode(500, "Erro interno do servidor");
        }
    }

    private string ConcatenaRecebido(string inputString)
    {
        var concatenado = new System.Text.StringBuilder();
        concatenado.Append(inputString + " - Processed at UTC: " + DateTime.UtcNow);
        return concatenado.ToString();
    }
}
