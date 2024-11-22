using System.ComponentModel.DataAnnotations;

namespace API_ProjetoBimestral.Models
{
    public class VendedorModel
    {
        [Key]
        public int vendedor_id {  get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string CNPJ { get; set; }
        public string cpf {  get; set; }
    }
}
