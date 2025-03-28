using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BuildingBlocks.Exception;

public class GrpcExceptionInterceptor : Interceptor
{
    public GrpcExceptionInterceptor(ILogger<GrpcExceptionInterceptor> logger)
    {
    }

    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        try
        {
            return await continuation(request, context);
        }
        catch (System.Exception exception)
        {
            throw new RpcException(new Status(StatusCode.Cancelled, exception.Message));
        }
    }
}
