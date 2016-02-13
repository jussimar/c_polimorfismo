using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    public class Funcionario : Pessoa
    {
        public int codFuncionario { get; set; }
        public double salario { get; set; }

        /// <summary>
        /// identifica que é um funcionario
        /// </summary>
        public override void ident()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DADOS FUNCIONARIO:");
        }

        /// <summary>
        /// mostra os dados do funcionario
        /// </summary>
        public override void mostrarDados()
        {
            Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);
            Console.WriteLine("Cod.: {0}", codFuncionario);
            Console.WriteLine("Salario: {0}", salario);
        }
    }
}
