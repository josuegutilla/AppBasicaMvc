﻿namespace AppMvcBasica.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }
        public string Lagradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Fornecedor Fornecedor { get; set; } //composição tem 1;
    }
}
