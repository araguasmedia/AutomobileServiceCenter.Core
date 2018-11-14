using System;
using System.Collections.Generic;
using System.Text;
using ASC.Business.Interfaces;
using ASC.DataAccess.Interfaces;
using ASC.Models.Models;
using System.Threading.Tasks;
using System.Linq;

namespace ASC.Business
{
    public class ServiceRequestMessageOperations : IServiceRequestMessageOperations
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceRequestMessageOperations(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateServiceRequestMessageAsync(ServiceRequestMessage message)
        {
            using (_unitOfWork)
            {
                await _unitOfWork.Repository<ServiceRequestMessage>().AddAsync(message);
                _unitOfWork.CommitTransaction();
            }
        }

        public async Task<List<ServiceRequestMessage>> GetServiceRequestMessageAsync(string ServiceRequestId)
        {
            var serviceRequestMessages = await _unitOfWork.Repository<ServiceRequestMessage>()
                .FindAllByPartitionKeyAsync(ServiceRequestId);
            return serviceRequestMessages.ToList();
        }
    }
}
