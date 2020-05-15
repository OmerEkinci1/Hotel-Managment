using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblCafe = new HashSet<TblCafe>();
            TblReservation = new HashSet<TblReservation>();
            TblService = new HashSet<TblService>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTc { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerBornDate { get; set; }
        public string CustomerMedeni { get; set; }
        public string CustomerGender { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }

        public virtual ICollection<TblCafe> TblCafe { get; set; }
        public virtual ICollection<TblReservation> TblReservation { get; set; }
        public virtual ICollection<TblService> TblService { get; set; }
    }
}
