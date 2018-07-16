using GOTHouses.APIgot;
using GOTHouses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Data.Entity;
using System.Drawing;
using System.Web.Http.Results;

namespace GOTHouses.Controllers
{
    public class HousesController : ApiController
    {
        private readonly GOTHousesDB Db = new GOTHousesDB();

        [HttpGet, Route("api/houses")]
        public IHttpActionResult GetHouses()
        {
            var houses = Db.Houses
                .Select(h => new GetHouses
                {
                    Id = h.Id,
                    Name = h.Name,
                    Symbol = h.Symbol,
                    Description = h.Description,

                })
                .OrderBy(h => h.Id)
                .ToList();

            if (houses.Count == 0)
            {
                return NotFound();
            }

            return Ok(houses);
        }

        [HttpGet, Route("api/houses/{id:int}")]
        public IHttpActionResult GetHouses(int? id)
        {
            var houses = Db.Houses
                .Where(h => h.Id == id)
                .Select(h => new GetSingleHouse
                {
                    Id = h.Id,
                    Name = h.Name,
                    Symbol = h.Symbol,
                    Description = h.Description,

                })
                .FirstOrDefault();

            if (houses == null)
            {
                return NotFound();
            }

            return Ok(houses);
        }


        [HttpGet, Route("api/houses/{id:int}/characters")]
        public IHttpActionResult GetCharacters(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            var character = Db.Characters
                .Where(c => c.HouseFK == id)
                .Select(c => new GetCharacters
                {
                    Id = c.Id,
                    Name = c.Name,
                    Family = c.Family,
                    Photo = c.Photo,
                    Video = c.Video,
                    Description = c.Description

                })
               .OrderBy(c => c.Id)
               .ToList();

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }

        [HttpGet, Route("api/characters/{id:int}")]
        public IHttpActionResult GetSingleCharacter(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var character = Db.Characters
                .Where(c => c.Id == id)
                .Select(c => new GetSingleCharacter
                {
                    Id = c.Id,
                    Name = c.Name,
                    Family = c.Family,
                    Photo = c.Photo,
                    Video = c.Video,
                    Description = c.Description

                })
               .FirstOrDefault();

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }
    }
}