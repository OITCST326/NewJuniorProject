/****************************** Module Header ******************************\
* Module Name:  WCFService.cs
* Project:	    CSAzureWCFServices
* Copyright (c) Microsoft Corporation.
* 
* This class implements AIM.Admin.Service.Contract.IContract interface.   
* Methods directly returns information about the current work role.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using AIM.Admin.Service.Contract;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using System.ServiceModel;

namespace AIMWorkerRole
{
    // Implement the wcf contract AIM.Admin.Service.Contract.IContract
    class WCFService:AIM.Admin.Service.Contract.IContract
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
