using AppMvcBasica.Enums;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; } //enum;
        public Endereco Endereco { get; set; } //composição tem 1;
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; } //composição tem varios;
    }
}
