using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

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

    [HttpGet("List")]
    public async Task<IActionResult> GetMemberListAsync()
    {
        try
        {
            
        }
        catch (System.Exception ex)
        {
            Logger.LogCritical(ex.Message, nameof(GetMemberListAsync), ex);
        }

        List<string> test = new ();
        return Ok(test);
    }
}