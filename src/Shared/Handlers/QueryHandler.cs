using Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Handlers
{
    public abstract class QueryHandler<TResponse, Trequest>
        where TResponse : class
        where Trequest : Request

    {
        public abstract TResponse Handle(Trequest request);
    }
}
