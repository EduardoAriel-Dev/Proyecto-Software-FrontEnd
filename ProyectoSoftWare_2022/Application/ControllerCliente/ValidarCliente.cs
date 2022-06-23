
namespace ProyectoSoftWare_2022.Application.ControllerCliente
{
    class ValidarCliente
    {
        public bool Valido(string _nombre, string _apellido, string _dni, string _email)
        {

            if (((_nombre == "") || (_apellido == "") || (_dni == "") || (_email == "")))
            {
                return false;
            }
            if ((_nombre == null) || (_apellido == null) || (_dni == null) || (_email == null))
            {
                return false;
            }
            return true;
        }
    }
}
