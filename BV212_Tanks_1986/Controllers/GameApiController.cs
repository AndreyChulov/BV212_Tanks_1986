using System.Drawing;
using Microsoft.AspNetCore.Mvc;

namespace BV212_Tanks_1986.Controllers;

[ApiController]
public class GameApiController : ControllerBase
{
    [HttpPost]
    [Route("move")]
    public void Move()
    {
        
    }
    
    [HttpPost]
    [Route("attack")]
    public void Attack()
    {
        
    }
    
    [HttpPost]
    [Route("die")]
    public void Die()
    {
        
    }
    
    [HttpPost]
    [Route("restore")]
    public void Restore()
    {
        
    }

    [HttpPost]
    [Route("pay")]
    public void Pay()
    {
        
    }

    [HttpGet]
    [Route("getCurrentPosition")]
    public string GetCurrentPosition()
    {
        return String.Empty;
    }
}