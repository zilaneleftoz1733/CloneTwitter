using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserDescription { get; set; }
        public string? UserHeaderPicture { get; set; }
        public string? UserBackground { get; set; }
        public string? UserFront { get; set; }
        public string? UserLocation { get; set; }
        public string? UserUrl { get; set; }
        public bool UserProtected { get; set; }
        public int UserPinnedPost { get; set; }// string de olabilir sor 
        public string? UserVerifiedType { get; set; }
        public bool UserVerified { get; set; }
    }
}
