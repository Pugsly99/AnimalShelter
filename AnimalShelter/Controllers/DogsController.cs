using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet("{id}")]
    public ActionResult<Dog> Get(int id)
    {
        return _db.Dogs.FirstOrDefault(entry => entry.DogId == id);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get(string name, int age, string gender, string species)
    {
      var query = _db.Dogs.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }
  }
}