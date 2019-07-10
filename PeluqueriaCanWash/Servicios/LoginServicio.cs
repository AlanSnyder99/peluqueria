using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PeluqueriaCanWash.Dto;
using PeluqueriaCanWash.Models;

namespace PeluqueriaCanWash.Servicios
{
    public class LoginServicio
    {
        private CanWashEntities _db = new CanWashEntities();

        public string Email { get; set; }
        public string Password { get; set; }


        public int VerificarLogin(LoginServicio buscado)
        {
            Usuario usuarioDb = _db.Usuario.SingleOrDefault(x => x.Email == buscado.Email && x.Password == buscado.Password);
            if (usuarioDb != null)
            {
                return usuarioDb.Id;
            }
            else
            {
                return 0;
            }
        }

    }
}