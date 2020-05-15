using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblStock
    {
        public TblStock()
        {
            TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }

        public virtual ICollection<TblCase> TblCase { get; set; }
    }
}
