﻿using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Project_back_end.Models
{
    public class User : IdentityUser
    {
        // User has blogs :
        [JsonIgnore]
        public virtual ICollection<Blog>? Blogs { get; set; }
        // User has comments :


    }
}
