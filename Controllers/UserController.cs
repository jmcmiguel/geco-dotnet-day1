using Microsoft.AspNetCore.Mvc;

namespace dotnet_day1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult getUser(){

        User user = new User();
        user.name = "John Michael";
        user.department = "Devops";
        user.position = "MS Solutions Trainee";
        user.id = 123;

        return Ok(user);
    }

   [HttpGet("{id}")]
   public IActionResult getUsers(string id){

    return Ok(id);
   }

   [HttpPost("name/{name}/id/{id:int}")]
   public IActionResult getUserName(string name, int id){

    if(name == "" || id == 0){
        return BadRequest("ID and Name Parameter is required.");
    }

    return Ok($"my name is {name} and {id}");
   }

   [HttpPatch("/id/{id:int}/name/{name:alpha}")]
   public IActionResult updateUserName(string name, int id){

    return Ok($"Updated: User with ID:{id} and Name:{name}");
   }

   [HttpDelete("{id}")]
   public IActionResult deleteUser(int id){
    return Ok($"Deleted User with ID:{id}");
   }

}
