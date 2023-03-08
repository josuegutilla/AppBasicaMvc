using Microsoft.AspNetCore.Identity;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecdorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Fornecedor Fornecedor { get; set; } //composição tem 1;
    }
}
