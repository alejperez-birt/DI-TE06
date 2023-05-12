using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class CLienteVO
    {
        private string iDCliente;
        private string nombreEmpresa;
        private string nombreContacto;
        private string categoriaContacto;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigoPostal;
        private string pais;
        private string telefono;
        private string fax;
        public CLienteVO()
        {
        }

        public CLienteVO(string iDCliente, string nombreEmpresa, string nombreContacto, string categoriaContacto, string direccion, string ciudad, string region, string codigoPostal, string pais, string telefono, string fax)
        {
            this.iDCliente = iDCliente;
            this.nombreEmpresa = nombreEmpresa;
            this.nombreContacto = nombreContacto;
            this.categoriaContacto = categoriaContacto;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.region = region;
            this.codigoPostal = codigoPostal;
            this.pais = pais;
            this.telefono = telefono;
            this.fax = fax;
        }


        public string IDCliente { get => iDCliente; set => iDCliente = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string CategoriaContacto { get => categoriaContacto; set => categoriaContacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }

        public override string ToString()
        {
            return IDCliente + " - " + NombreEmpresa;
        }
    }
}