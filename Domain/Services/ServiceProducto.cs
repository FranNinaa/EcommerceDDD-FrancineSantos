using Domain.Interfaces.InterfaceProducto;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class ServiceProducto : IServiceProducto
	{
		private readonly IProducto _IProducto;

		public ServiceProducto(IProducto IProducto)
		{
			_IProducto = IProducto;
		}

		public async Task AddProducto(Produto produto)
		{
			var validaNome = produto.validaPropriedadeString(produto.Nome, "Nome");
			var validaValor = produto.validaPropriedadeDecimal(produto.Valor, "Valor");

			if (validaNome && validaValor)
			{
				produto.Estado = true;
				//salva esse produto na interface IProducto
				await _IProducto.Add(produto);
			}

		}

		public async Task UpdateProducto(Produto produto)
		{
			var validaNome = produto.validaPropriedadeString(produto.Nome, "Nome");
			var validaValor = produto.validaPropriedadeDecimal(produto.Valor, "Valor");

			if (validaNome && validaValor)
			{
				
				
				await _IProducto.Update(produto);
			}
		}
	}

}
