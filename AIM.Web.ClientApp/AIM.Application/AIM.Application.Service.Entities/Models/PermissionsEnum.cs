using System.Runtime.Serialization;

namespace AIM.Application.Service.Entities.Models
{
    [DataContract(Name = "EmployeePermissions")]
    public enum PermissionsEnum : int
    {
        [EnumMember]
        Employee = 0,

        [EnumMember]
        HiringManager = 1,

        [EnumMember]
        HiringSpecialist = 2,

        [EnumMember]
        StaffingExpert = 3,

        [EnumMember]
        StoreManager = 4,

        [EnumMember]
        SystemAdmin = 5
    }
}