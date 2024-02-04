using Infrastructure.Data.Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Persistence.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext repositoryContext;
        private IProductRepository productRepository;

        public IProductRepository Product
        {
            get
            {
                if (this.productRepository == null)
                {
                    productRepository = new ProductRepository(repositoryContext);
                }

                return this.productRepository;
            }
        }

        public void Save()
        {
            repositoryContext.SaveChanges();
        }
    }
}
