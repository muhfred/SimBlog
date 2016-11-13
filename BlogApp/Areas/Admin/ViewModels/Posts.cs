using System.Collections;
using System.Collections.Generic;
using BlogApp.Infrastructure;
using BlogApp.Models;

namespace BlogApp.Areas.Admin.ViewModels
{
    public class PostsIndex
    {
           public PagedData<Post> Posts { get; set; }
    }
}