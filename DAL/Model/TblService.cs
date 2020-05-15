using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblService
    {
        public TblService()
        {
            TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Type { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string ServiceFee { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual ICollection<TblCase> TblCase { get; set; }
    }
}
