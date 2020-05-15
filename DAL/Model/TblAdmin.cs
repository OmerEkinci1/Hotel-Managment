using System;
using System.Collections.Generic;

namespace DAL.Model
{
    public partial class TblAdmin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminTc { get; set; }
        public string AdminPhone { get; set; }
        public string AdminPosition { get; set; }
        public string AdminBornDate { get; set; }
        public string AdminStartDate { get; set; }
        public string AdminSalary { get; set; }
        public string AdminAddress { get; set; }
        public string AdminUsername { get; set; }
        public string AdmimPasword { get; set; }
    }
}
