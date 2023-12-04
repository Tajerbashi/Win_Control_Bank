﻿using Domain.Library.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Entities.SEC
{
    [Table("Users", Schema = "SEC")]
    public class User : BaseEntity
    {
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<GroupUser> GroupUsers { get; set; }
    }
}