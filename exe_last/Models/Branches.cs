using System;
using System.Collections.Generic;

namespace exe_last.Models
{
    public partial class Branches
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Dbname { get; set; }
        public bool IsActive { get; set; }
    }
}
