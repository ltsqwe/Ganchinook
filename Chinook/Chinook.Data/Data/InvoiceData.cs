using System;
using System.Collections.Generic;
using MyLibrary;
using System.Linq;
using System.Linq.Expressions;

namespace Chinook.Data
{
    public class InvoiceData : EntityData<Invoice>
    {
        public Invoice GetByPk(int invoiceId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                return context.Invoices.FirstOrDefault(x => x.InvoiceId == invoiceId);
            }
        }

        public override List<Invoice> GetAll(Expression<Func<Invoice, bool>> predicate = null)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Invoices
                    select x;

                return query.ToList();
            }
        }
    }
}
