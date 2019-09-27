using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DXBlazorMasterDetail.Data
{
    public class AdventureWorksService
    {
        private readonly AWContext _context = new AWContext();


        public AdventureWorksService()
        {
        }


        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> customers = await (_context.Customer.AsNoTracking().Select(c => c)).ToListAsync();

            return customers;
        }

        public async Task<List<Order>> GetOrders()
        {
            List<Order> orders = await (_context.Order.AsNoTracking().Select(o => new Order()
            {
                SalesOrderID = o.SalesOrderID,
                CustomerID = o.CustomerID,
                OrderDate = o.OrderDate,
                SalesOrderNumber = o.SalesOrderNumber,
                SubTotal = o.SubTotal,
                TaxAmt = o.TaxAmt,
                Freight = o.Freight,
                TotalDue = o.TotalDue
            })).ToListAsync();

            return orders;
        }

        public async Task<List<ProductOrderLine>> GetOrderDetail()
        {
            List<ProductOrderLine> orderDetail = await (_context.ProductOrderLine.AsNoTracking().Select(o => new ProductOrderLine()
            {
                SalesOrderID = o.SalesOrderID,
                SalesOrderDetailID = o.SalesOrderDetailID,
                Name = o.Name,
                ThumbnailPhotoFileName = o.ThumbnailPhotoFileName,
                CategoryName = o.CategoryName,
                OrderQty = o.OrderQty,
                UnitPrice = o.UnitPrice,
                LineTotal = o.LineTotal
                
            })).ToListAsync();

            return orderDetail;
        }
    }

}