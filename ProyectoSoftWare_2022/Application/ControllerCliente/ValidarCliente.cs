using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftWare_2022.Data.Models;

namespace ProyectoSoftWare_2022.Application.ControllerCliente
{
    class ValidarCliente
    {
        public bool Valido(string _nombre, string _apellido, string _dni, string _email)
        {

            if (((_nombre == "") || (_apellido == "") || (_dni == "") || (_email == "")))
            {
                Console.WriteLine("Los datos son vacios");
                return false;
            }
            if ((_nombre == null) || (_apellido == null) || (_dni == null) || (_email == null))
            {
                Console.WriteLine("Los datos son Nulls");
                return false;
            }
            return true;
        }
    }
}
