using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblRoom
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string RoomSituation { get; set; }
        public string RoomView { get; set; }
        public string Capacity { get; set; }
    }
}
