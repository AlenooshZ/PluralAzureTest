using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace HelloserviceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                ServiceMetadataBehavior serviceBehavoiur = new ServiceMetadataBehavior()
                {
                    HttpGetEnabled = true
                };

                host.AddServiceEndpoint(typeof(HelloService.IHelloService), new BasicHttpBinding(), "HelloService");
                host.Description.Behaviors.Add(serviceBehavoiur);
                host.Open();
                Console.WriteLine("Service Started @ " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
