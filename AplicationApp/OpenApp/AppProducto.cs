using AplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProducto;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationApp.OpenApp
{
	public class AppProducto : InterfaceProductoApp
	{
		IProducto  _IProducto;
		IServiceProducto _IServiceProducto;
		public AppProducto(IProducto producto, IServiceProducto serviceProducto) 
		{
			 producto = _IProducto;
			 serviceProducto = _IServiceProducto;
		}

		public async Task Add(Produto objeto)
		{
			await _IProducto.Add(objeto);
		}

		public async Task AddProducto(Produto produto)
		{
			await _IServiceProducto.AddProducto(produto);
		}

		public async Task UpdateProducto(Produto produto)
		{
			await _IServiceProducto.UpdateProducto(produto);
		}

		public async Task Delete(Produto Objeto)
		{
			await _IProducto.Delete(Objeto);
		}

		public async Task<Produto> GetEntityById(int Id)
		{
			return await _IProducto.GetEntityById(Id);
		}

		public async Task<List<Produto>> List()
		{
			return await _IProducto.List();
		}

		public async Task Update(Produto Objeto)
		{
			await _IProducto.Update(Objeto);
		}

		
	}

}
