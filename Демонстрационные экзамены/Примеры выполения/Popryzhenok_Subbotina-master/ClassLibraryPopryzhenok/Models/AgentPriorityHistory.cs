//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryPopryzhenok.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentPriorityHistory
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public int PriorityValue { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}
