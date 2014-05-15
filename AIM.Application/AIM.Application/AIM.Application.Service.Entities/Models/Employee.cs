using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Employee : ITrackable
    {
        public Employee()
        {
            this.Users = new List<User>();
        }

        [DataMember]
        public int employeeId { get; set; }

        [DataMember]
        public PermissionsEnum? permissions { get; set; }

        [DataMember]
        public int? jobId { get; set; }

        [DataMember]
        public Job Job { get; set; }

        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}