//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankomatSimulazione
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banche_Funzionalita
    {
        public long Id { get; set; }
        public long IdBanca { get; set; }
        public long IdFunzionalita { get; set; }
    
        public virtual Banche Banche { get; set; }
        public virtual Funzionalita Funzionalita { get; set; }
    }
}
