using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public DateTime CreateDate { get; set; }
        public int isStatus { get; set; }
        public int isDeleted { get; set; }
        public DateTime isDeletedDate { get; set; }
    }
}
