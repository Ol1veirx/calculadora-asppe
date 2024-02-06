using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPPE___SOMA.Models
{
    public class Equipes
    {
        public int Id {  get; set; }
        public string Nome { get; set; }

		[DisplayFormat(DataFormatString = "{0:0.000}")]
		public double Peso { get; set;}
        public int Quantidade { get; set; }

		[DisplayFormat(DataFormatString = "{0:0.00}")] 
        public double Pontos {  get; set; }

		[DisplayFormat(DataFormatString = "{0:0.000}")]
        [Display(Name = "Maior Peixe")]
		public double MaiorPeixe {  get; set; }
    }
}
