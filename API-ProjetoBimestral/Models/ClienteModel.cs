using System.ComponentModel.DataAnnotations;

namespace API_ProjetoBimestral.Models
{
    public class ClienteModel
    {
        [Key]
        public int cliente_id {  get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string numero_residencia { get; set; }

        public ClienteModel(
            string nome,
            string email,
            string senha,
            string telefone,
            string cep,
            string numero_residencia)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.cep = cep;
            this.numero_residencia = numero_residencia;
        }
    }
}
