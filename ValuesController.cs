using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SDKWebPortalWebAPI.Models;
using SDKWebPortalWebAPI.Repository;

namespace SDKWebPortalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IPostRepository postRepository;
        public ValuesController(IPostRepository _postRepository)
        {
            postRepository = _postRepository;
        }

        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("GetPost")]
        public IActionResult GetPost(int? postId) //Gets the records by postId.
        {
            if (postId == null) //If postId is equal to null, returns BadRequest.
            {
                return BadRequest(); //Returns BadRequest.
            }

            try //Lines of code that may have errors are written into the try block.
            {
                var post = postRepository.GetPost(postId); //Compares by the postId.

                if (post == null)  //If post is equal to null, returns NotFound.
                {
                    return NotFound(); //Returns NotFound.
                }

                return Ok(post); //Returns Ok.
            }
            catch (Exception) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                return BadRequest(); //Returns BadRequest.
            }
        }

        [HttpGet]
        [Route("GetPosts")]
        public IActionResult GetPosts() //Gets the record as a list.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                var post = postRepository.GetPosts(); //Compares by the post.

                if (post == null) //If post is equal to null, returns NotFound.
                {
                    return NotFound(); //Returns NotFound.
                }

                return Ok(post); //Returns Ok.
            }
            catch (Exception) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                return BadRequest(); //Returns BadRequest.
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Input input) //Gets posts by Input type.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                postRepository.AddPost(input); //Adds post as an Input type.
                return Ok(); //Returns Ok.
            }
            catch (Exception) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                return BadRequest(); //Returns BadRequest.
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id) //Deletes the post by id.
        {
            try //Lines of code that may have errors are written into the try block.
            {
                var post = postRepository.DeletePost(id); //Equals the ids each other and deletes the record.

                if (post == null) //If the post is equal to null, returns NotFound.
                {
                    return NotFound(); //Returns NotFound.
                }

                return Ok(id); //Returns Ok.
            }
            catch (Exception) //If any error occurs in the try block, the codes in the try block are jumped into the catch block without executing the other codes in the try block.
            {
                return BadRequest(); //Returns BadRequest.
            }
        }
    }
}
