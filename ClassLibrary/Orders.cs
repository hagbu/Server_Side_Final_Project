//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int id { get; set; }
        public Nullable<int> movie_number { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public Nullable<int> user_seats_amount { get; set; }
        public string user_seats_positions { get; set; }
    
        public virtual Movies Movies { get; set; }
    }
}
