using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIM.Admin.Service.Contract;
using Microsoft.WindowsAzure.ServiceRuntime;
using System.ServiceModel;

namespace AIM.Admin.Service.WorkerRole
{
    class WCFServices : IContract
    {
        // Return the current work role's name and instance id
        public string GetRoleInfo()
        {
            RoleInstance currentRoleInstance = RoleEnvironment.CurrentRoleInstance;
            string RoleName = currentRoleInstance.Role.Name;
            string RoleInstanceID = currentRoleInstance.Id;
            return (string.Format("You are talking to role {0}, instance ID {1}\n.", RoleName, RoleInstanceID));
        }

        // Return the channel between the client & the work role
        public string GetCommunicationChannel()
        {
            return (string.Format("You are talking via {0}.", OperationContext.Current.Channel.LocalAddress.Uri.ToString()));
        }
    }
}

