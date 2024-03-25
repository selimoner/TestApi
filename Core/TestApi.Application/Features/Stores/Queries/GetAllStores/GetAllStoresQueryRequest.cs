using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Application.Features.Stores.Queries.GetAllStores
{
    public class GetAllStoresQueryRequest:IRequest<IList<GetAllStoresQueryResponse>>
    {

    }
}
