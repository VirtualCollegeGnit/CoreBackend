using System;

namespace core.logic.ApiModel.PersonModel
{
    public class RemarkModel
    {
        public int Id { get; set; }
        public PersonModel? GivenBy { get; set; }
        public string? Description { get; set; }
        public int Rating { get; set; }
        public DateTime DateTime { get; set; }
        public byte[]? RowVersion { get; internal set; }
    }
}