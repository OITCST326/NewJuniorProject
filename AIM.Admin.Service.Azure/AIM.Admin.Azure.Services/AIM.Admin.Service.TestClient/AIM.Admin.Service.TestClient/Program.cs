using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ServiceModel;
using AIM.Admin.Service.TestClient.ServiceReference1;
using AIM.Admin.Service.TestClient.ServiceReference2;
using AIM.Admin.Service.Contract;

namespace AIM.Admin.Service.TestClient
{
    class Program
    {  
        static void Main(string[] args)
        {
            Talk2WebRole();
            Talk2WorkroleViaWebRole();
            Talk2Workrole();
        }

        static void Talk2WebRole()
        {
            ServiceReference1.ContractClient cc = new ServiceReference1.ContractClient();
            var result = cc.GetRoleInfo();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Talk2WorkroleViaWebRole()
        {
            ServiceReference2.ContractClient cc = new ServiceReference2.ContractClient();
            var result = cc.GetRoleInfo();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Talk2Workrole()
        {
            ChannelFactory<AIM.Admin.Service.Contract.IContract> factory;
            AIM.Admin.Service.Contract.IContract channel;
            
            // You need to modify the endpoint address to fit yours.
            EndpointAddress endpoint = new EndpointAddress("net.tcp://aimadministrativeservice.cloudapp.net:10100/External");

            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None, false); 
            factory = new ChannelFactory<AIM.Admin.Service.Contract.IContract>(binding);

            channel = factory.CreateChannel(endpoint);

            Console.WriteLine(channel.GetRoleInfo());
            Console.Read();
        }

    }
}
