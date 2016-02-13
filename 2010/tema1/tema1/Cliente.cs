using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tema1
{
    public class Cliente : Pessoa
    {
        public int codCliente { get; set; }
        public double limite { get; set; }
        
        /// <summary>
        /// mostra a identificação de cliente
        /// </summary>
        public override void ident()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DADOS CLIENTE:");
        }
        
        /// <summary>
        /// mostra od dados do cliente
        /// </summary>
        public override void mostrarDados()
        {
            Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);
            Console.WriteLine("Cod.: {0}", codCliente);
        }
        
        /// <summary>
        /// faz a ação de compra debitando o valor do limite de credito do cliente
        /// </summary>
        /// <param name="valor">passa o valor da compra</param>
        public void comprar(double valor)
        {
            this.limite -= valor;
            Console.WriteLine("Compra efetuada com sucesso seu limite é: {0}",limite);
        }
        
        /// <summary>
        ///  faz a ação de compra porém dando a opção do cliente pagar em dinheiro
        ///   e debitando o restante do valor do limite de credito do cliente
        /// </summary>
        /// <param name="valor">passa o valor da compra</param>
        /// <param name="dinheiro">passa o valor em diinheiro</param>
        public void comprar(double valor, double dinheiro)
        {
            valor -= dinheiro;
            this.limite -= valor;
            Console.WriteLine("Compra efetuada com sucesso seu limite é: {0}", limite);
        }
    }
}
