using core.data.Model.Person;
using System;

namespace core.logic.ApiModel.PersonModel
{
    public class RelativeModel
    {
        public int Id { get; set; }
        public Relation Relation { get; set; }
        public PersonModel? Person { get; set; }
        public byte[]? RowVersion { get; internal set; }
    }
}
