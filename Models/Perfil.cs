using System;
using System.Collections.Generic;
using System.IO;
namespace Instadev_SENAI.Models
{
    public class Perfil : InstadevBase
    {
        public string Nome { get; set; }
        
        public string NomeUsuario { get; set; }
        
        public string Email { get; set; }
        
        private const string PATH = "Database/ Perfil.csv";

        public Perfil()
        {
            CreateFolderAndFile(PATH);
        }

        public void Create(Perfil p)
        {
            string[] linhas = {PrepararLinha(p)};
            File.AppendAllLines(PATH, linhas);
        }
        private string PrepararLinha(Perfil p)
        {
            return $"{p.Nome}, {p.NomeUsuario}, {p.Email}";
        }
        public void Delete(Perfil p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] = p.Nome.ToString);
            RewriteCSV(PATH, linhas);
        }
        public List<Perfil> ReadAll()
        {
            List<Perfil> usuarios = new List<Perfil>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Perfil usuario = new Perfil();
                usuario.Nome        = linha[0];
                usuario.NomeUsuario = linha[1];
                usuario.Email       = linha[2];

                usuarios.Add(usuario);
            }
            return usuarios;
        }
        public void Update(Perfil p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == p.NomeUsuario.ToString());
            linhas.Add(PrepararLinha(p));
            RewriteCSV(PATH, linhas);
        }
    }
}