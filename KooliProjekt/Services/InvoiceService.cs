using KooliProjekt.Data;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ApplicationDbContext _context;

        public InvoiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<Invoice>> List(int page, int pageSize)
        {
            return await _context.Invoices
                .Include(invoiceItem => invoiceItem.Lines)
                .Include(invoiceItem => invoiceItem.Event)
                .Include(invoiceItem => invoiceItem.Customer)
                .OrderByDescending(invoiceItem => invoiceItem.InvoiceDate)
                .GetPagedAsync(page, pageSize);
        }

        public async Task<Invoice?> Get(int id)
        {
            return await _context.Invoices
                .Include(invoiceItem => invoiceItem.Lines)
                .Include(invoiceItem => invoiceItem.Event)
                .Include(invoiceItem => invoiceItem.Customer)
                .Where(invoiceItem => invoiceItem.Id == id)
                .FirstOrDefaultAsync();
        }
        public async Task Save(Invoice invoiceItem)
        {
            if (invoiceItem.Id == 0)
            {
                _context.Invoices.Add(invoiceItem);
            }
            else
            {
                _context.Invoices.Update(invoiceItem);
            }

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _context.Invoices
                .Where(invoiceItem => invoiceItem.Id == id)
                .ExecuteDeleteAsync();
        }
    }
}
