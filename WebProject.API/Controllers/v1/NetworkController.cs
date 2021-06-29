using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebProject.Models.Core.ResponseCore;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WebProject.Models.Core.Enums;

namespace WebProject.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NetworkController
    {
        /// <summary>
        /// Logger
        /// </summary>
        /// <value></value>
        protected readonly ILogger Logger;

        /// <summary>
        /// Config
        /// </summary>
        /// <value></value>
        private IConfiguration _Configuration { get; init; }

        /// <summary>
        /// Accessor
        /// </summary>
        /// <value></value>
        private IActionContextAccessor _ActionContextAccessor { get; init;}

        /// <summary>
        /// Http Context
        /// </summary>
        /// <value></value>
        private HttpContext _HttpContext { get; init;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="configuration"></param>
        /// <param name="actionContextAccessor"></param>
        public NetworkController(
            ILogger<NetworkController> logger,
            IConfiguration configuration,
            IActionContextAccessor actionContextAccessor
        )
        {
            Logger = logger;
            _Configuration = configuration;
            _ActionContextAccessor = actionContextAccessor;
            _HttpContext = _ActionContextAccessor.ActionContext.HttpContext;
        }

        /// <summary>
        /// Get Member Information
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        [HttpGet("ClientIp")]
        public async Task<ResponseCore<string>> GetClientIp()
        {
            ResponseCore<string> response = new ResponseCore<string>();

            try
            {
                // If Contains Header
                if(_HttpContext.Request.Headers != null)
                {
                    // Get Forwarded Headers
                    string xForwardedHeader = _HttpContext.Request.Headers["X-Forwarded-For"];
                    string xProtoHeader = _HttpContext.Request.Headers["X-Forwarded-Proto"];

                    if(!string.IsNullOrEmpty(xForwardedHeader))
                        response.Data = xForwardedHeader;

                    if(!string.IsNullOrEmpty(xProtoHeader))
                        response.Data = xProtoHeader;
                                        
                    if(xForwardedHeader == null && xProtoHeader == null)
                        response.Data = _HttpContext.Connection.RemoteIpAddress.ToString();

                    response.Data = $"xForwardedHeader : {xForwardedHeader} xProtoHeader : {xProtoHeader} others : {_HttpContext.Connection.RemoteIpAddress.ToString()}";
                }
            }
            catch (System.Exception ex)
            {
                response.Result = EnumResponseResult.Error;
                response.Message = ex.Message;

                Logger.LogCritical(ex.Message, nameof(GetClientIp), ex);
            } 

            return response;
        }
    }
}