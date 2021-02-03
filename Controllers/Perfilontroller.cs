using System;
using Instadev_SENAI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Instadev_SENAI.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
        
    {
        Perfil perfilModel = new Perfil();

        public IActionResult Index()
        {
            ViewBag.Perfil = perfilModel.ReadAll();
            return View();
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