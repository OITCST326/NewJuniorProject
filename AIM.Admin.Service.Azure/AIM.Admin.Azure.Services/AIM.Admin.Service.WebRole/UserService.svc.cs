using AIM.Admin.Service.Contract;
using AIM.Admin.Service.Contract.Models;
using Microsoft.WindowsAzure.ServiceRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.Client;

namespace AIM.Admin.Service.WebRole
{
    public class UserService : IUserService
    {
        public async Task<IEnumerable<User>> GetUsersListAsync()
        {
            IEnumerable<User> usersList = null;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                using ((IDisposable)myClient)
                {
                    try
                    {
                        usersList = myClient.GetUsersListAsync().Result;
                    }
                    catch (AggregateException aggEx)
                    {
                        var baseEx = aggEx.Flatten().GetBaseException();
                        var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                        Console.WriteLine(baseEx.Message + innerExMsg);
                    }
                    finally
                    {
                        var channel = myClient as IClientChannel;
                        if (channel != null && channel.State == CommunicationState.Faulted)
                        {
                            channel.Abort();
                        }
                    }
                }

            return (usersList);
        }

        public async Task<User> GetUserAsync(int? id)
        {
            User user = null;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                try
                {
                    // Get User List
                    user = myClient.GetUserAsync(id).Result;
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = myClient as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }
            return (user);
        }

        public async Task<User> GetUserLoginAsync(string userName, string password)
        {
            User user = null;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                try
                {
                    // Get User by UserName and Password
                    user = myClient.GetUserLoginAsync(userName, password).Result;
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = myClient as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }

            return (user);
        }

        public async Task<User> UpdateUserAsync(User entity)
        {
            User originalUser = null;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                try
                {
                    // Get original User
                    originalUser = myClient.GetUserAsync(entity.UserId).Result;

                    // Start change-tracking the User
                    var changeTracker = new ChangeTrackingCollection<User>(originalUser);

                    // Modify User with changes
                    originalUser = entity;

                    // Submit changes
                    User changedUser = changeTracker.GetChanges().SingleOrDefault();
                    User updatedUser = myClient.UpdateUserAsync(changedUser).Result;

                    //Merge changes
                    changeTracker.MergeChanges(updatedUser);
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = myClient as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }

            return (originalUser);
        }

        public async Task<User> CreateUserAsync(User entity)
        {
            User user = null;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                try
                {
                    // Create new user
                    user = myClient.CreateUserAsync(entity).Result;
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = myClient as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }

            return (user);
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            bool deleteUser = false;

            var roles = RoleEnvironment.Roles["AIM.Admin.Service.WorkerRole"];
            foreach (IUserService myClient in from instance in roles.Instances
                                              select instance.InstanceEndpoints["Internal"]
                                                  into workRoleInternalEndPoint
                                                  let binding = new NetTcpBinding(SecurityMode.None, false)
                                                  let myEndpoint = new EndpointAddress(String.Format("net.tcp://{0}/Internal",
                                                      workRoleInternalEndPoint.IPEndpoint))
                                                  select new ChannelFactory<IUserService>(binding, myEndpoint)
                                                      into myChanFac
                                                      select myChanFac.CreateChannel())
                try
                {
                    // Delete user
                    deleteUser = myClient.DeleteUserAsync(id).Result;
                }
                catch (AggregateException aggEx)
                {
                    var baseEx = aggEx.Flatten().GetBaseException();
                    var innerExMsg = baseEx.InnerException != null ? "\r\n" + baseEx.InnerException.Message : "";
                    Console.WriteLine(baseEx.Message + innerExMsg);
                }
                finally
                {
                    var channel = myClient as IClientChannel;
                    if (channel != null && channel.State == CommunicationState.Faulted)
                    {
                        channel.Abort();
                    }
                }

            return (deleteUser);
        }
    }
}