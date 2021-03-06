﻿using System;
using System.Collections.Generic;
using System.Text;
using ASC.Models.Models;
using System.Threading.Tasks;

namespace ASC.Business.Interfaces
{
    public interface IServiceRequestMessageOperations
    {
        Task CreateServiceRequestMessageAsync(ServiceRequestMessage message);
        Task<List<ServiceRequestMessage>> GetServiceRequestMessageAsync(string serviceRequestId);
    }
}
