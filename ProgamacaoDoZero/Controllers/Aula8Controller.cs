using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgamacaoDoZero.Controllers
{
    [Route("api/aula8")]
    [ApiController]
    public class Aula8Controller : Controller
    {
        [Route("olaMundo")]
        [HttpGet]
        public string OlaMundo()
        {
            var mensagem = "Olá mundo via API";

            return mensagem;
        }

        [Route("olaMundoPersonalizado")]
        [HttpGet]
        public string OlaMundoPersonalizado(string nome)
        {
            var mensagem = "Olá mundo via API " + nome;

            return mensagem;
        }

        [Route("somar")]
        [HttpGet]
        public string Somar(int numero1, int numero2)
        {
            var soma = numero1 + numero2;

            var mensagem = "A soma é " + soma;

            return mensagem;
        }

        [Route("media")]
        [HttpGet]
        public string Media(int numero1, int numero2)
        {
            var soma = numero1 + numero2;

            var media = soma / 2;

            var mensagem = "A média é " + media;

            return mensagem;
        }

        [Route("terreno")]
        [HttpGet]
        public IActionResult Terreno(decimal largura, decimal comprimento, decimal valorM2)
        {
            var areaTerreno = largura * comprimento;

            var valorTerreno = areaTerreno * valorM2;

            var mensagem = "A área do terreno é de " + areaTerreno + "m2. O valor do terreno é de R$ " + valorTerreno;

            return Ok(mensagem);
                       
                        
        }

        [Route("troco")]
        [HttpGet]
        public IActionResult Troco(decimal preco, decimal quantidade, decimal valorDadoCliente)
        {
            var precoUnitario = preco * quantidade;

            var troco = precoUnitario - valorDadoCliente;

            var mensagem = "O troco do cliente é de R$ " + troco;

            return Ok(mensagem);
        }

        [Route("pagamento")]
        [HttpGet]
        public IActionResult Pagamento(decimal salario, decimal horasTrabalhadas, string nome)
        {
            var nomeNumero = nome;

            var horasNumero = salario * horasTrabalhadas;
                      
            var mensagem = "O pagamento para " + nome + " é de R$ " + horasNumero;

            return Ok(mensagem);
        }

        [Route("consumo")]
        [HttpGet]
        public IActionResult Consumo(decimal distancia, decimal litros)
        {
            var consumo = distancia / litros;

            var mensagem = "O consumo médio do veículo é de " + consumo + "km por litro";

            return Ok(mensagem);
        }
    }
}
