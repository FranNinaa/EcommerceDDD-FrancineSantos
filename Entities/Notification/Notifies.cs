using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notification
{
	public class Notifies
	{
		public Notifies()
		{
			Notificacoes = new List<Notifies>();
		}

		//para ñ mapear essa coluna no banco de dados
		[NotMapped]
		public string NomePropriedade { get; set; }

		[NotMapped]
		public string Mensagem { get; set; }

		[NotMapped]
		public List<Notifies> Notificacoes;

		public bool validaPropriedadeString(string valor, string nomePropriedade)
		{
			if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				Notificacoes.Add(new Notifies { 
					Mensagem ="Campo obrigatório",
					NomePropriedade = nomePropriedade

				});
				
				return false;
			}
			return true;
		}

		public bool validaPropriedadeInt(int valor, string nomePropriedade)
		{
			if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				Notificacoes.Add(new Notifies
				{
					Mensagem = "Valor deve ser maior de 0",
					NomePropriedade = nomePropriedade

				});

				return false;
			}
			return true;
		}

		public bool validaPropriedadeDecimal(decimal valor, string nomePropriedade)
		{
			if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				Notificacoes.Add(new Notifies
				{
					Mensagem = "Campo obrigatório",
					NomePropriedade = nomePropriedade

				});

				return false;
			}
			return true;
		}



	}
}
