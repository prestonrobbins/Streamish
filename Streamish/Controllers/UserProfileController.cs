using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Streamish.Models;
using Streamish.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Streamish.Controllers
{
    public class UserProfileController : Controller
    {

        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        [HttpGet("GetAllUserProfiles")]
        public ActionResult GetAllUserProfiles()
        {
            var userProfiles = _userProfileRepository.GetAllUserProfiles();
            return Ok(userProfiles);
        }

        // GET: UserProfileController/Details/5
        [HttpGet("{id}")]
        public ActionResult GetUserProfileById(int id)
        {
            return Ok(_userProfileRepository.GetUserProfileById(id));
        }

       

        // POST: UserProfileController/Create
        [HttpPost]
        public ActionResult AddUserProfile(UserProfile user)
        {
            _userProfileRepository.AddUserProfile(user);
            return CreatedAtAction("Get", new { id = user.Id }, user);
        }

        // GET: UserProfileController/Edit/5
        [HttpPut("{id}")]
        public ActionResult Update(int id,  UserProfile user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _userProfileRepository.Update(user);
            return NoContent();
        }


        // GET: UserProfileController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _userProfileRepository.Delete(id);
            return NoContent();
        }

        // POST: UserProfileController/Delete/5       
    }
}
