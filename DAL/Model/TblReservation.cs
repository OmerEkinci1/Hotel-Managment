using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblReservation
    {
        public TblReservation()
        {
            TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string RoomNumber { get; set; }
        public DateTime? EnterDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string RoomSituation { get; set; }
        public string ReservFee { get; set; }

        public virtual TblCustomer Customer { get; set; }
        public virtual ICollection<TblCase> TblCase { get; set; }
    }
}
