using Entities.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
	[Table ("Produtos")]
	public class Produto : Notifies
	{
		[Column ("PRO_ID")]
		[Display (Name = "Código")]
		public int Id { get; set; }

		[Column ("PRO_NOME")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		[Column ("PRO_VALOR")]
		[Display(Name = "Valor")]
		public decimal Valor { get; set; }

		[Column ("PRO_ESTADO")]
		[Display(Name = "Código")]
		public bool Estado { get; set; }

		
		
	}
}
