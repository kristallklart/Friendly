//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Friendly.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.User_Location_Purposes = new HashSet<User_Location_Purpose>();
        }
    
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime Birthdate { get; set; }
        public byte[] Picture { get; set; }
        public string Profession { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
        public string Industry { get; set; }
    
        public virtual FieldOfProfession FieldOfProfession { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Location_Purpose> User_Location_Purposes { get; set; }
    }
}
