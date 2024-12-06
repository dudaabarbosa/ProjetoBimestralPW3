using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_ProjetoBimestral.Models
{
    public class LivroModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int livro_id {  get; set; }
        public string nome_livro { get; set; }
        public byte[] img_livro { get; set; }
        public string? url_img_livro { get; set; }
        public string autor {  get; set; }
        public float preco {  get; set; }
        public string paginas { get; set; }
        public string editora { get; set; }
        public string publicacao { get; set; }

        public LivroModel(
            string nome_livro,
            byte[] img_livro,
            string autor,
            float preco,
            string paginas,
            string editora,
            string publicacao) 
        {
            this.nome_livro = nome_livro;
            this.autor = autor;
            this.img_livro = img_livro;
            this.preco = preco;
            this.paginas = paginas;
            this.editora = editora;
            this.publicacao = publicacao;
        }
    }
}
