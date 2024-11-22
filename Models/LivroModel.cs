using System.ComponentModel.DataAnnotations;

namespace API_ProjetoBimestral.Models
{
    public class LivroModel
    {
        [Key]
        public int livro_id {  get; set; }
        public string nome_livro { get; set; }
        public string autor {  get; set; }
        public float preco {  get; set; }
        public int paginas { get; set; }
        public string editora { get; set; }
        public string publicacao { get; set; }

        public LivroModel(
            string nome_livro,
            string autor,
            float preco,
            int paginas,
            string editora,
            string publicacao) 
        {
            this.nome_livro = nome_livro;
            this.autor = autor;
            this.preco = preco;
            this.paginas = paginas;
            this.editora = editora;
            this.publicacao = publicacao;
        }
    }
}
