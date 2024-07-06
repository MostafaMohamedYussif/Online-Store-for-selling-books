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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepositoy
    {
        private ApplicationDbContext db ;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
            
        }

        
        
       

        public void Update(OrderHeader category)
        {
            db.OrderHeaders.Update(category);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus =null)
        {
            var orderFromDb= db.OrderHeaders.FirstOrDefault(u=>u.Id==id) ;
            if(orderFromDb!=null)
            {
                orderFromDb.OrderStatus = orderStatus;
            }
            if(!string.IsNullOrEmpty(paymentStatus))
            {
                orderFromDb.PaymentStatus = paymentStatus;
            }
        }

        public void UpdateStripePaymentId(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDb = db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if (!string.IsNullOrEmpty(sessionId))
            {
                orderFromDb.SessionId = sessionId;

            }
            if(!string.IsNullOrEmpty(paymentIntentId))
            {
                orderFromDb.PaymentIntentId = paymentIntentId;
                orderFromDb.PaymentDate = DateTime.Now;
            }
        }
    }
}
