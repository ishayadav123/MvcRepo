//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCrepo2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDetail()
        {
            this.CarDetails = new HashSet<CarDetail>();
        }
    
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string CivilIdNumber { get; set; }
        public string DOB { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string ProfilePic { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsNotificationActive { get; set; }
        public Nullable<bool> IsActive { get; set; }

        internal static object Entry(UserDetail userDtls)
        {
            throw new NotImplementedException();
        }

        public Nullable<int> DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string FcmToken { get; set; }
        public Nullable<bool> verify { get; set; }
        public string VerifiedBy { get; set; }
        public string Area { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public string Housing { get; set; }
        public string Floor { get; set; }
        public string NewPass { get; set; }
        public string ConPass { get; set; }
        public string Jadda { get; set; }
        public string Reason { get; set; }
        public string ActivatedBy { get; set; }
        public Nullable<System.DateTime> VerifiedDate { get; set; }
        public Nullable<System.DateTime> ActivatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarDetail> CarDetails { get; set; }
    }
}
