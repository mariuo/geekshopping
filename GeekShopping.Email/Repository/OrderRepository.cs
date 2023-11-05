﻿#nullable disable

using Microsoft.EntityFrameworkCore;
using GeekShopping.Email.Model.Context;

namespace GeekShopping.Email.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContextOptions<MySQLContext> _context;

        public OrderRepository(DbContextOptions<MySQLContext> context)
        {
            _context = context;
    
        }

        public async Task UpdateOrderPaymentStatus(long orderHeaderId, bool status)
        {
            //await using var _db = new MySQLContext(_context);
            //var header = await _db.Headers.FirstOrDefaultAsync(o => o.Id == orderHeaderId);

            //if (header != null)
            //{
            //    header.PaymentStatus = status;
            //    await _db.SaveChangesAsync();
            //}
        }

        Task IOrderRepository.UpdateOrderPaymentStatus(long orderHeaderId, bool paid)
        {
            throw new System.NotImplementedException();
        }
    }
}
