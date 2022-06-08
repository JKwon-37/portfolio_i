using Microsoft.AspNetCore.Mvc;

public class HelloController : Controller
{
    [HttpGet("")]
    public string Index() 
    {
        return "This is my index!";
    }
    [HttpGet("/projects")]
    public string Projects() 
    {
        return "This are my projects!";
    }
    [HttpGet("/contact")]
    public string Contact() 
    {
        return "This is my Contacts page!";
    }
}