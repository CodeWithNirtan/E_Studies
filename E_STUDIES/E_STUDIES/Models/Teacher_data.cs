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
    
    public partial class Teacher_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher_data()
        {
            this.Student_data = new HashSet<Student_data>();
        }
    
        public int Teacher_data_id { get; set; }
        public string Fullname { get; set; }
        public string Teacher_image { get; set; }
        public Nullable<long> phone { get; set; }
        public Nullable<int> userid { get; set; }
        public string Teacher_address { get; set; }
        public string Marital_status { get; set; }
        public Nullable<int> age { get; set; }
        public string gender { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_data> Student_data { get; set; }
        public virtual User User { get; set; }
    }
}
