using System;
using System.Collections.Generic;

namespace exe_last.Models
{
    public partial class TblCuShahinContract
    {
        public int ContractId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerGroup { get; set; }
        public string ServiceId { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
        public string DateOfContract { get; set; }
        public string FileId { get; set; }
        public string FileUpload { get; set; }
        public bool? Status { get; set; }
        public bool? HasElhaghie { get; set; }
        public string ContractNumber { get; set; }
        public string ContractSubject { get; set; }
        public int? ContractOwnerId { get; set; }
        public int? CustomerId { get; set; }
        public int? ContractStatusId { get; set; }
        public int? CustomerGroupId { get; set; }
        public string ContractTitle { get; set; }
        public string Guid { get; set; }
    }
}
