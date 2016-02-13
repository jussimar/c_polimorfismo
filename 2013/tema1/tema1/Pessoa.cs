using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }


        public abstract void mostrarDados();

        /// <summary>
        /// identificação genérica
        /// </summary>
        public virtual void ident()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DADOS:");
        }
    }
}
