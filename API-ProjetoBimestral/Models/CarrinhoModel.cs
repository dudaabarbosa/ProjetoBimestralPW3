using System.ComponentModel.DataAnnotations;

namespace API_ProjetoBimestral.Models
{
    public class CarrinhoModel
    {
        [Key]
        public int carrinho_id { get; set; }
        public int id_livro { get; set; }
        public int id_cliente { get; set; }
        public int? quantidade { get; set; }
        public CarrinhoModel(int id_livro, int id_cliente)
        {
            this.id_cliente = id_cliente;
            this.id_livro = id_livro;
        }
    }
}
