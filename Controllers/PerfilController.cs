namespace Instadev_SENAI.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
        
    {
        Perfil perfilModel = new Perfil();

        public IActionResult Index()
        {
            Viewbag.Perfil = perfilModel.ReadAll();
            return view;
        }
        [Route("EditarPerfil")]
        public IActionResult EditarPerfil(IFormCollection form)
        {
            Perfil novoPerfil = new Perfil();
            novoPerfil.Nome = form["Nome"];
            novoPerfil.NomeUsuario = form["NomeUsuario"];
            novoPerfil.Email = form["Email"];

            perfilModel.Create(novoPerfil);

            return LocalRedirect("~/Perfil");
        }
    }
}