﻿using System;
using System.ServiceModel;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(String name);

    }
}
