using Bulky.DataAccess.Repository.IRepository;
using Bulky.DataAcess.Data;
using Bulky.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext db ;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
            
        }

        
        
       

        public void Update(OrderDetail category)
        {
            db.OrderDetails.Update(category);
        }
    }
}
