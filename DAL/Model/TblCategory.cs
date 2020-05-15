using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblCase> TblCase { get; set; }
    }
}
