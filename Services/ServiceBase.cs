using System;
using System.Net.Http;
using System.Runtime.Serialization;
using Services.Implementations;
using Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace Services
{
    public class ServiceBase : BaseServiceImpl, IService
    {
        public ILogger Logger { get; }
        public string Error { get; set; }

        public ServiceBase(ILogger logger, HttpClient httpClient) : base (httpClient)
        {
            Logger = logger;
            httpClient.Timeout = TimeSpan.FromSeconds(510);
        }

        public T ThrowServiceException<T>()
        {
            Logger.LogError(Error);
            var obj = (T)Activator.CreateInstance(typeof(T), true, Error);
            return obj;
        }

        public T ThrowServiceException<T>(string message)
        {
            Logger.LogError(message);
            var obj = (T)Activator.CreateInstance(typeof(T), message);
            return obj;
        }

        public T ThrowServiceException<T>(string message, Exception exception)
        {
            Logger.LogError(message, exception);
            var obj = (T)Activator.CreateInstance(typeof(T), message, exception);
            return obj;
        }

        public T ThrowServiceException<T>(Exception exception)
        {
            Logger.LogError(Error, exception);
            var obj = (T)Activator.CreateInstance(typeof(T), Error, exception);
            return obj;
        }
        public T ThrowServiceException<T>(SerializationInfo info, StreamingContext context)
        {
            Logger.LogError(Error);
            var obj = (T)Activator.CreateInstance(typeof(T), info, context);
            return obj;
        }

    }
}
