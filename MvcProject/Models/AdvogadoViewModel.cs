using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcProject.Models
{
    [Serializable]
    public class AdvogadoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do advogado e obrigatorio")]
        [StringLength(100, ErrorMessage = "Nome deve ter no maximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Senioridade e obrigatoria")]
        public Senioridade Senioridade { get; set; }

        [Required(ErrorMessage = "Logradouro e obrigatorio")]
        [StringLength(200, ErrorMessage = "Logradouro deve ter no maximo 200 caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Bairro e obrigatorio")]
        [StringLength(100, ErrorMessage = "Bairro deve ter no maximo 100 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Estado e obrigatorio")]
        [StringLength(2, ErrorMessage = "Estado deve ter 2 caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "CEP e obrigatorio")]
        [StringLength(9, ErrorMessage = "CEP deve ter 9 caracteres")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Numero e obrigatorio")]
        [StringLength(10, ErrorMessage = "Numero deve ter no maximo 10 caracteres")]
        public string Numero { get; set; }

        [StringLength(100, ErrorMessage = "Complemento deve ter no maximo 100 caracteres")]
        public string Complemento { get; set; }

        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        // Propriedades para dropdowns
        public SelectList Estados { get; set; }
        public SelectList Senioridades { get; set; }
    }
}
