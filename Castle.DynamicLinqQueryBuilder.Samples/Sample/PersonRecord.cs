using System;
using System.ComponentModel;

namespace Castle.DynamicLinqQueryBuilder.Samples.Sample
{
    public class PersonRecord
    {
        [Description("Searches FirstName property")]
        public string FirstName { get; set; }
        [Description("Searches LastName property")]
        public string LastName { get; set; }
        [Description("Searches Age property")]
        public int Age { get; set; }
        [Description("Searches Birthday property")]
        public DateTime Birthday { get; set; }
        [Description("Searches Address property")]
        public string Address { get; set; }
        [Description("Searches City property")]
        public string City { get; set; }
        [Description("Searches State property")]
        public string State { get; set; }
        [Description("Searches ZipCode property")]
        public string ZipCode { get; set; }

    }
}