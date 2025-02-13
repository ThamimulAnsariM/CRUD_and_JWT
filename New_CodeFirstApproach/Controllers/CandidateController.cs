using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using New_CodeFirstApproach.Data;
using New_CodeFirstApproach.Model;
using New_CodeFirstApproach.Model.Entities;

namespace New_CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ApplicationDBContext dbcontext;

        public CandidateController(ApplicationDBContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        [HttpGet]
        public IActionResult GetAllCandidates() 
        {
            var candiates=dbcontext.Candidates.ToList();
            return Ok(candiates);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetByCandidatesId(Guid id)
        {
            var candidate=dbcontext.Candidates.Find(id);
            if(candidate is null)
            {
                return NotFound();
            }
            return Ok(candidate);
        }
        [HttpPost]
        public IActionResult AddCandidate(AddCandidate addCandidate)
        {
            var candiatesEntity = new Candidate()
            {
                Name = addCandidate.Name,
                phone = addCandidate.phone,
                Address = addCandidate.Address,
                salary = addCandidate.salary
            };
            dbcontext.Candidates.Add(candiatesEntity);
            dbcontext.SaveChanges();
            return Ok(candiatesEntity);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateCandidate(Guid id,UpdateCandidate _updateCandidate)
        {

           var candidate=dbcontext.Candidates.Find(id);
            if(candidate is null)
            {
                return NotFound();
            }
            candidate.Name=_updateCandidate.Name;
            candidate.phone = _updateCandidate.phone;
            candidate.Address= _updateCandidate.Address;
            candidate.salary = _updateCandidate.salary;
            dbcontext.SaveChanges();
            return Ok(candidate);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteCandidate(Guid id)
        {
            var candidate = dbcontext.Candidates.Find(id);
            if(candidate is null)
            {
                return NotFound();
            }
            dbcontext.Candidates.Remove(candidate);
            dbcontext.SaveChanges();
            return Ok();
        }
    }
}
