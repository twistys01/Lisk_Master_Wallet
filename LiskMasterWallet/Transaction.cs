//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiskMasterWallet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public string Id { get; set; }
        public long Block { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public decimal Amount { get; set; }
        public int TType { get; set; }
        public System.DateTime Created { get; set; }
        public decimal Fee { get; set; }
    }
}