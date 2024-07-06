using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAcess.Data;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;

        }





        public void Update(ProductImage obj)
        {
            db.ProductImages.Update(obj);
        }

    }
}
