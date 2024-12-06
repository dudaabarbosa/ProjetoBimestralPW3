namespace API_ProjetoBimestral.Models
{
    public record LivroModelPost
    {
        public string nome_livro { get; set; }
        public string autor { get; set; }
        public float preco { get; set; }
        public string paginas { get; set; }       
        public string publicacao { get; set; }
        public string editora { get; set; }
        public string img_livro { get; set; }
    }
}
