using System;
using System.Collections.Generic;
using MyLibrary;
using System.Linq;
using System.Linq.Expressions;
using MyLibrary.Helpers;

namespace Chinook.Data
{
    public class InvoiceLineData : EntityData<InvoiceLine>
    {
        public InvoiceLine GetByPk(int invoiceLineId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                return context.InvoiceLines.FirstOrDefault(x => x.InvoiceLineId == invoiceLineId);
            }
        }

        public override List<InvoiceLine> GetAll(Expression<Func<InvoiceLine, bool>> predicate = null)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.InvoiceLines
                    select new
                    {
                        InvoiceLine =x,
                        TrackName = x.Track.Name
                    };

                var list = query.ToList();
                foreach (var x in list)
                {
                    x.InvoiceLine.TrackName= x.TrackName;
                }
                
                return list.ConvertAll(x => x.InvoiceLine);
            }
        }
        
        public List<Invoice> GetInvoices(int invoiceLineId)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var invoiceId =  context.InvoiceLines.FirstOrDefault(x => x.InvoiceLineId == invoiceLineId)?.InvoiceId;
                if (!invoiceId.HasValue)
                    return null;

                var query = from x in context.Invoices
                    where x.InvoiceId == invoiceId
                    select x;

                return query.ToList();
            }
        }
    }
}
