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
    
    public partial class GameEsrbContentDescriptor
    {
        public System.Guid GameGuid { get; set; }
        public int EsrbContentDescriptorId { get; set; }
        public string UserName { get; set; }
    
        public virtual EsrbContentDescriptor EsrbContentDescriptor { get; set; }
        public virtual Game Game { get; set; }
    }
}
