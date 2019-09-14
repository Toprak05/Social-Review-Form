using SDKWebPortalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDKWebPortalWebAPI.Repository
{
    //This interface contains only the declaration of the methods.
    public interface IPostRepository
    {
        List<OutputList> GetPosts();//This method sends the data as a list.

        OutputList GetPost(int? postId);//This method sends the data as a list and takes an argument named postId

        Task<int> AddPost(Input post);//This method adds the data to database and takes an argument named post and it's type Input.

        Task<int> DeletePost(int houseid);//This method takes an houseid to delete the post.
    }
}
