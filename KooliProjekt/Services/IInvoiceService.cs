﻿using KooliProjekt.Data;

namespace KooliProjekt.Services
{
    public interface IInvoiceService
    {
        Task<PagedResult<Invoice>> List(int page, int pageSize);
        Task<Invoice?> Get(int id);
        Task Save(Invoice invoiceItem);
        Task Delete(int id);
    }
}
