using System;
using System.ComponentModel.DataAnnotations;

namespace core.data.Model.Member
{
    public class Document
    {
        public int ID { get; set; }
        public bool IsMedia { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
        public virtual Admin? AcceptedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }
        [MaxLength(250)]
        public string Data { get; set; } = "";
        [MaxLength(20)]
        public string DocumentType { get; set; } = "";
    }
}
