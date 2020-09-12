﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace BlazorSimpleSurvey.Models
{
    public partial class Users
    {
        public Users()
        {
            Logs = new HashSet<Logs>();
            SurveyAnswer = new HashSet<SurveyAnswer>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityProvider { get; set; }
        public string AuthenticationType { get; set; }
        public string Objectidentifier { get; set; }
        public string SignupMethod { get; set; }
        public string LastIpaddress { get; set; }
        public int LastAuthTime { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string LastidpAccessToken { get; set; }

        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<SurveyAnswer> SurveyAnswer { get; set; }
    }
}