//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalClinic.Model.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public long id { get; set; }
        public string name { get; set; }
        public Nullable<long> age { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public Nullable<long> specialization_id { get; set; }
    }
}
