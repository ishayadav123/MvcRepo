using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCrepo2.Models
{
    public class InsertViewModel
    {
        public InsertViewModel()
        {
            UserDetailsData = new List<UserDetailsNew>();
            CarLicenseDetails = new List<CarDetails>();
        }

       public List<UserDetailsNew> UserDetailsData { get; set; }
       public List<CarDetails> CarLicenseDetails { get; set; }
    }
    public class UserDetailsNew 
    { 
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHash { get; set; }
        public string CivilIdNumber { get; set; }
        public string DOB { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public int? RoleId { get; set; }
        public string ProfilePic { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsNotificationActive { get; set; }
        public bool? IsActive { get; set; }

    }

    public class CarDetails
    {
        public string CarLicense { get; set; }
        public int CarId { get; set; }
    }
}