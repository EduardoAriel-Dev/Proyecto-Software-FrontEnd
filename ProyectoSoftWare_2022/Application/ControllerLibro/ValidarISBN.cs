using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Application.ControllerLibro
{
    class ValidarISBN
    {
        public bool _ISBN_Valido(string _ISBN)
        {
            using (var contexto = new MyDbContext())
            {
                var ListClient = contexto.libros.Where(X => X.ISBN == _ISBN).ToList();
                if (ListClient.Count == 0)
                {
                    Console.WriteLine("Ese Libro no lo tenemos");
                    return true;
                }
                else
                {
                    Console.WriteLine("Libro Encontrado");
                    return false;
                }

            }
        }
    }
}
