//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventLog
    {
        public System.Guid Guid { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public string Event { get; set; }
        public string Detail { get; set; }
    }
}
