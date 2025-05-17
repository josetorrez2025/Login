 using Microsoft.AspNetCore.Mvc;
 using practicas.Models;

namespace practicas.Controllers
{
	public class UsuarioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ActionResult ForMethod(string Username,string Password, string Name, string FechaNacimiento, string Email )
		{
			UsuarioModels Usuario;
			List<UsuarioModels> ListUsuario = new List<UsuarioModels>();

			for (int  i = 0; i <= 5; i++)
			{

				Usuario = new UsuarioModels();

				Usuario.Email = "josetorrez2581@gmail.com";
				Usuario.Username = "josetorrez2581";
				Usuario.Password = "123";
				Usuario.FechaNacimiento = DateTime.Now;
				Usuario.Name = "jose torrez";
				Usuario.Id = i;

				ListUsuario.Add(Usuario);
			}
			ViewBag.ListaUsuarios = ListUsuario;
			return View("Index");
		}

	}
}
