﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Following
    {
        [Key]
        public int UserId { get; set; }
        public int FollowedId { get; set; }
        public int isStatus { get; set; }
    }
}
