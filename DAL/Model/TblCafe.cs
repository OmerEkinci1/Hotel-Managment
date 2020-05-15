using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblCafe
    {
        public TblCafe()
        {
            TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Price { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual ICollection<TblCase> TblCase { get; set; }
    }
}
