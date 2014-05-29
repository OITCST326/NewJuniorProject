using AIM.Admin.Service.Contract;
using System;
using System.ServiceModel;

namespace AIM.Admin.Service.TestClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Talk2WebRole();
            Talk2WorkroleViaWebRole();
            Talk2Workrole();
        }

        private static void Talk2WebRole()
        {
            var cc = new ServiceReference1.ContractClient();
            var result = cc.GetRoleInfo();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Talk2WorkroleViaWebRole()
        {
            var cc = new ServiceReference2.ContractClient();
            var result = cc.GetRoleInfo();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Talk2Workrole()
        {
            // You need to modify the endpoint address to fit yours.
            var endpoint = new EndpointAddress("net.tcp://aimadministrativeservice.cloudapp.net:10100/External");
            var binding = new NetTcpBinding(SecurityMode.None, false);
            var factory = new ChannelFactory<IUserService>(binding);
            var channel = factory.CreateChannel(endpoint);

            if (channel != null) Console.WriteLine(channel.GetUsersListAsync());
            Console.Read();
        }
    }
}