﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComfortCare.Data.Models
{
    public partial class EmployeeSkill
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }
    }
}