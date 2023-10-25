
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Armando Um Porro", "857.032.950-41", "armandoumporro@gmail.com", "Pão");
        Cliente cliente2 = new Cliente(02, "Armando Dois Porro", "857.032.950-42", "armandodoisporro@gmail.com", "Broa");
        Cliente cliente3 = new Cliente(03, "Armando Tres Porro", "857.032.950-43", "armandotresporro@gmail.com", "Baguete");
        Cliente cliente4 = new Cliente(04, "Armando Quatro Porro", "857.032.950-44", "armandoquatroporro@gmail.com", "Biscoito");
        Cliente cliente5 = new Cliente(05, "Armando Cinco Porro", "857.032.950-45", "armandocincoporro@gmail.com", "Francês");

        // lista de clientes e atribui clientes

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancia do tipo fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01, "Pet S.A.", "14.182.102/0001-80", "petsa@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pet S.A.1", "14.182.102/0001-81", "petsa1@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Pet S.A.2", "14.182.102/0001-82", "petsa2@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Pet S.A.3", "14.182.102/0001-83", "petsa3@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Pet S.A.4", "14.182.102/0001-84", "petsa4@gmail.com");

        // lista de fornecedores e atribui fornecedores

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
