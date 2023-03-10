using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BondGarfoApp.Controllers;

public class HelloWorldController : Controller
{
    //server/controlador/acao/id
    //toda classe publica no controlador vira uma acao
    public IActionResult Index()
    {
        return View();
    }

    public string Welcome(string nome, int ID=1)
    {
        return HtmlEncoder.Default.Encode(
            //https://localhost:7037/HelloWorld/Welcome?nome=Gabriel&idade=24
            $"Ola, {nome}. Seu ID e {ID}."
        );
    }
}