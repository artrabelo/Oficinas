using System;

/*
    Oficina 2.1 do curso de Fundamentos de Desenvolvimento de Aplicações com Visual C#
    Encontrar uma solução para dependência entre métodos.
*/

namespace ConsoleApp3
{
    public class Pedido
    {
        public int codigoPedido;
        public string dataPedido;
        public string cpfCliente;

        /*
            Solução: Adiciona-se apenas o atributo codigoItem ao invés do objeto ItemPedido,
            já que um pedido possui apenas um item de pedido, removendo a dependência.
        */
        public int codigoItem;

        //public ItemPedido pedido; // Problema de dependência
    }

    public class ItemPedido
    {
        public int codigoItem;
        public string descricao;
        public float valorItem;
    }
}
