using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region ATRIBUTOS

        protected string apellido;
        protected string nombre;
        protected int dni;

        #endregion

        #region PROPIEDADES

        public string Apellido
        {
            get { return apellido; }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    apellido = value;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
            }
        }
        public int Dni
        {
            get { return dni; }
            set
            {
                if (Validaciones.only_numer(value.ToString()) )
                {
                    dni = value;
                } }
        }


        #endregion

        #region CONSTRUCTORES

        public Persona()
        {

        }

        public Persona(string auxNombre, string auxApellido ) : this()
        {
            this.apellido = auxApellido;
            this.nombre = auxNombre;
        }
        #endregion



    }
}
