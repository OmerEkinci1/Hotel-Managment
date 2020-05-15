using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblAnnouncement
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Announcement { get; set; }
    }
}
