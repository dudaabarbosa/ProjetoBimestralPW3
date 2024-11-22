using System.Security.Cryptography.Xml;

namespace API_ProjetoBimestral.Models
{
    public class PedidoModel
    {
        public int pedido_id {  get; set; }
        public int id_livro { get; set; }
        public int id_cliente { get; set; }
        public DateTime data_pedido { get; set; }
        public float valor_total { get; set; }

        public PedidoModel(
            int id_livro,
            int id_cliente,
            DateTime data_pedido,
            float valor_total) 
        {
            this.id_livro = id_livro;
            this.id_cliente = id_cliente;
            this.data_pedido = data_pedido;
            this.valor_total = valor_total;
        }

    }
}
