//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace speedyRecruitApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skill
    {
        public int Skill_Id { get; set; }
        public string Skill_Type { get; set; }
        public int Candidate_Id { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}
