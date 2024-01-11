using Microsoft.AspNetCore.Mvc;
using ProgamacaoDoZero.Models;

namespace ProgamacaoDoZero.Controllers
{
    [Route("api/aula11")]
    [ApiController]
    public class Aula11Controller : ControllerBase
    {
        [Route("obterVeiculo")]
        [HttpGet]
        public Veiculo obterVeiculo()
        {
            var meuVeiculo = new Veiculo();

            meuVeiculo.Cor = "Vermelho";
            meuVeiculo.Marca = "Ford";
            meuVeiculo.Modelo = "Fusion";
            meuVeiculo.Placa = "BGX-7495";

            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
            meuVeiculo.Acelerar();
          
            return meuVeiculo;
        }

        [Route("obterCarro")]
        [HttpGet]
        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.Marca = "Honda";
            meuCarro.Modelo = "Fit";
            meuCarro.Placa = "BMK-4525";
            meuCarro.Cor = "Azul";

            meuCarro.Acelerar();

            return meuCarro;
        }

        [Route("obterMoto")]
        [HttpGet]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.Marca = "Yamaha";
            minhaMoto.Modelo = "Fazer 250";
            minhaMoto.Cor = "Preta";
            minhaMoto.Placa = "JBJ-1184";

            minhaMoto.Acelerar();

            return minhaMoto;
        }
    }
}
