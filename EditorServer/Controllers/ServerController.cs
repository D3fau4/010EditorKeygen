using Microsoft.AspNetCore.Mvc;

namespace EditorServer.Controllers;


[ApiController]
[Produces("text/html")]
[Route("cgibin/")]
public class ServerController : ControllerBase
{
    [HttpGet("010editor_check_license_9b.php")]
    public ContentResult CheckLicense()
    {
        return new ContentResult 
        {
            ContentType = "text/html",
            Content = "<ss>valid</ss>"
        };
    }
}