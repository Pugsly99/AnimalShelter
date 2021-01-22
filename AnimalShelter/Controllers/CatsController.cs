using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    //[EnableCors]
    [HttpGet("{id}")]
    public ActionResult<Cat> Get(int id)
    {
        return _db.Cats.FirstOrDefault(entry => entry.CatId == id);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get(string name, int age, string gender, string species)
    {
      var query = _db.Cats.AsQueryable();

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
    public void Post([FromBody] Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    
    public void Put(int id, [FromBody] Cat cat)
    {
        cat.CatId = id;
        _db.Entry(cat).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var CatToDelete = _db.Cats.FirstOrDefault(entry => entry.CatId  == id);
        _db.Cats.Remove(CatToDelete);
        _db.SaveChanges();
    }
  }
}
