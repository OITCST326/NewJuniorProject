using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AIM.Service.Entities.Models
{
    [DataContract(Name = "Status")]
    public enum StatusEnum : int
    {
        [EnumMember]
        [Display(Name = "Inital Application Not Submitted")]
        InitalApplicationNonSubmitted = 0,

        [EnumMember]
        [Display(Name = "Phone Interview Queue")]
        PhoneInterviewQueue = 1,

        [EnumMember]
        [Display(Name = "In Person Interview Queue")]
        InPersonInterviewQueue = 2,

        [EnumMember]
        [Display(Name = "Check Reference Queue")]
        CheckReferenceQueue = 3,

        [EnumMember]
        [Display(Name = "Rejected")]
        Rejected = 4,

        [EnumMember]
        [Display(Name = "Pending Review Queue")]
        PendingReviewQueue = 5,

        [EnumMember]
        [Display(Name = "Hired Status")]
        HiredStatus = 6
    }
}