using System;
using System.Collections.Generic;

namespace DAL.Model { 
    public partial class TblCase
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Move { get; set; }
        public string Fee { get; set; }
        public int? ReservationId { get; set; }
        public int? CafeId { get; set; }
        public int? ServiceId { get; set; }
        public int? StockId { get; set; }

        public virtual TblCafe Cafe { get; set; }
        public virtual TblCategory Category { get; set; }
        public virtual TblReservation Reservation { get; set; }
        public virtual TblService Service { get; set; }
        public virtual TblStock Stock { get; set; }
    }
}
