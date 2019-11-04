using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatorio")]
        [StringLength(60, ErrorMessage ="O nome deve ter menos de 60 caracteres")]
        [MinLength(3, ErrorMessage ="O nome deve ter mais de 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatorio")]
        [EmailAddress(ErrorMessage ="Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatorio")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }


        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegVendas> Vendas { get; set; } = new List<RegVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNasc, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNasc = dataNasc;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RegVendas sr)
        {
            Vendas.Add(sr);
        }

        public void RemoveVendas(RegVendas sr)
        {
            Vendas.Remove(sr);
        }

        public double TotalVendas(DateTime initial, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Montante);
        }

    }
}
