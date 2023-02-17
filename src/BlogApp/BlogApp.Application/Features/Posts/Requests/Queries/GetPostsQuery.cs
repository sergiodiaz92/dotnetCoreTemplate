using BlogApp.Application.DTOs;
using BlogApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Features.Posts.Requests.Queries
{
    public class GetPostsQuery : IRequest<Result<List<PostDTO>>>
    {

    }
}
