using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando cliente
            Cliente c = new Cliente();
            c.nome = "José";
            c.sobrenome = "Santana";
            c.codCliente = 123;
            c.limite = 3000;

            //c.ident();
            //c.mostrarDados();

            Ferramenta.mostrar(c);

            c.comprar(200);
            c.comprar(300, 100);

            //Instanciando funcionario
            Funcionario f = new Funcionario();
            f.nome = "José";
            f.sobrenome = "Santana";
            f.codFuncionario = 123;
            f.salario = 2000;

            //f.ident();
            //f.mostrarDados();

            Ferramenta.mostrar(f);

            Console.ReadKey();
        }
    }
}
