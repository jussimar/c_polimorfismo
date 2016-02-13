using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public class Ferramenta
    {
        /// <summary>
        /// chama os métodos ident e mostrar dedados de acordo com o tipo do parametro
        /// </summary>
        /// <param name="p">passa um objeto do tipo pessoa</param>
        public static void mostrar(Pessoa p)
        {
            p.ident();
            p.mostrarDados();

        }
    }
}
