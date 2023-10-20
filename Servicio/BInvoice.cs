using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class BInvoice
    {

        public List<Invoice> GetByDate(DateTime date)
        {
            DInvoice dInvoice = new DInvoice();
            var invoices = dInvoice.Get();
            var result = invoices.Where(x=>x.Date == date).ToList();
            return result;


        }
    }
}
