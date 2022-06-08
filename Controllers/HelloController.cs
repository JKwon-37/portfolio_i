using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    [HttpGet("")]
    public string Index() 
    {
        return "Hello World! From the HelloController!";
    }
}