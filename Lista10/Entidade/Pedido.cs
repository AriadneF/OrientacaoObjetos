using Lista10.Entidade.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lista10.Entidade
{
    public class Pedido
    {
        public DateTime Data { get; set; }
        public Status Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime data, Status status, Cliente cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (ItemPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Data do pedido: " + Data.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.AppendLine("Status do pedido: " + Status);
            stringBuilder.AppendLine("Cliente: " + Cliente);
            stringBuilder.AppendLine("Itens:");
            foreach (ItemPedido item in Itens)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            stringBuilder.AppendLine("Total: $" + Total().ToString("F2"));
            return stringBuilder.ToString();
        }
    }
}