using Microsoft.AspNetCore.Mvc;

namespace EstudandoRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Exercicio1 : ControllerBase
    {

        [HttpGet]
        [Route("nome")]
        public string Nome()
        {
            return "Thomas Pippi";
        }
        [HttpGet]
        [Route("idade")]
        public int Idade()
        {
            return 22;
        }
        [HttpPost]
        [Route("nome")]
        public string RetornaNome(string nome)
        {
            return "Bem vindo, " + nome;
        }
        [HttpPost]
        [Route("nomeidade")]
        public string VerificaIdade(string nome,int idade)
        {
            if(idade >= 18)
            return nome + " é maior de idade.";
            else
                return nome + " é menor de idade.";
        }




    }
    
}
