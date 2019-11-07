using Microsoft.AspNetCore.Identity;
using System;

namespace Monopoly.Data.Models
{
    public class MonopolyUser : IdentityUser
    {
        public string Test { get; set; }
    }
}
