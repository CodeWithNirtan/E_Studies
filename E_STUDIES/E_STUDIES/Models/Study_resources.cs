//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_STUDIES.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Study_resources
    {
        public int Resources_id { get; set; }
        public string Title { get; set; }
        public string Url_link { get; set; }
        public Nullable<int> userid { get; set; }
        public Nullable<bool> Res_status { get; set; }
        public string res_desc { get; set; }
        public string res_img { get; set; }
    
        public virtual User User { get; set; }
    }
}
