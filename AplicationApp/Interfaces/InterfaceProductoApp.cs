using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationApp.Interfaces
{
	public interface InterfaceProductoApp : InterfaceGenericsApp<Produto>
	{
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);
    }
}
