using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebProject.Models.Core.Enums;
using WebProject.Models.Core.ResponseCore;
using WebProject.Models.Core.V1;

[ApiController]
[Route("api/v1/[controller]")]
public class MemberController : ControllerBase
{
    /// <summary>
    /// Logger
    /// </summary>
    /// <value></value>
    protected readonly ILogger Logger;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logger">Logger</param>
    public MemberController(ILogger<MemberController> logger)
    {
        Logger = logger;
    }

    /// <summary>
    /// Get Member Information List
    /// </summary>
    /// <returns></returns>
    [HttpGet("List")]
    public async Task<ResponseList<MemberInfo>> GetMemberListAsync()
    {
        ResponseList<MemberInfo> response = new ResponseList<MemberInfo>();

        try
        {
            
        }
        catch (System.Exception ex)
        {
            Logger.LogCritical(ex.Message, nameof(GetMemberListAsync), ex);
        }

        return response;
    }

    /// <summary>
    /// Get Member Information
    /// </summary>
    /// <param name="id">id</param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<ResponseCore<MemberInfo>> GetMemberInfo(string id)
    {
        ResponseCore<MemberInfo> response = new ResponseCore<MemberInfo>();

        try
        {
            
        }
        catch (System.Exception ex)
        {
            Logger.LogCritical(ex.Message, nameof(GetMemberListAsync), ex);
        }

        return response;
    }
}