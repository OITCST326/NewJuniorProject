using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AIM.Service.Entities.Models;

namespace AIM.Web.Admin.Models
{
    public class JsonQuestion
    {
        [Display(Name = @"Question Id")]
        public int? qJsonId { get; set; }

        [Display(Name = @"Question Type")]
        public TypeEnum? qJsonType { get; set; }

        [Display(Name = @"Question")]
        public string qJsonText { get; set; }

        [Display(Name = @"Question Option")]
        public IList<string> qJsonOptionList { get; set; }

        [Display(Name = @"Desired Answer")]
        public IList<string> qJsonAnswerList { get; set; }
    }
}