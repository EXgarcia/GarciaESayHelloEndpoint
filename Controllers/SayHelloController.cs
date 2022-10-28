//Elizar Garcia
///10/17/22
//MiniChallenge #1 "say hello?" endpoint
//This program will display the username on endpoint. 
//Peer Review: Caroline Hana-  The code works as intended and meets all the requirments also added some personality adding more then just hello nice work!




using Microsoft.AspNetCore.Mvc;

namespace GarciaESayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    [HttpGet]
    [Route("hello/{name}")]

    public string SayHello(string name)
    {
        return $"Hello {name}, nice to make your aquaintance. ";

    }

}