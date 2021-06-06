using CoreMVCIntro.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro.VMClasses
{
    public class AppUserVM
    {
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }

    }
}
