using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public interface IResponse<T>
    {
        int Page { get; set; }
        int PageSize { get; set; }
        List<T> Results { get; set; }
    }

    public interface IRequest
    {
        int Page { get; set; }
        int PageSize { get; set; }
    }

    public interface IRequestHandlerAsync<RequestType, ResponseType, ResultType>
        where RequestType : class, IRequest
        where ResponseType : class, IResponse<ResultType>
    {
        Task<ResponseType> HandleAsync(RequestType request);
    }

    public class GenericHandlerAsync<T>
        : IRequestHandlerAsync<Request, Response<T>, T>
    {
        public async Task<Response<T>> HandleAsync(Request request)
        {
            return await Task.Factory.StartNew<Response<T>>(() =>
            {
                return new Response<T>
                {
                    Page = request.Page,
                    PageSize = request.PageSize,
                    Results = new List<T>()
                };
            });
        }
    }

    public class Request
        : IRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class Response<T>
        : IResponse<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<T> Results { get; set; }
    }
}
