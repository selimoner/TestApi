using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Application.Interfaces.UnitOfWorks;
using TestApi.Domain.Entities;

namespace TestApi.Application.Features.Stores.Queries.GetAllStores
{
    public class GetAllStoresQueryHandler : IRequestHandler<GetAllStoresQueryRequest, IList<GetAllStoresQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllStoresQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllStoresQueryResponse>> Handle(GetAllStoresQueryRequest request, CancellationToken cancellationToken)
        {
            var stores = await unitOfWork.GetReadRepository<Store>().GetAllAsync();

            List<GetAllStoresQueryResponse> response= new List<GetAllStoresQueryResponse>();

            foreach(var store in stores)
            {
                response.Add(new GetAllStoresQueryResponse
                {
                    Name = store.Name,
                    Priorty = store.Priorty,
                });
            }

            return response;
        }
    }
}
