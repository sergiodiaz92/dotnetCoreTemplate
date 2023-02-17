using BlogApp.Application.DTOs;
using BlogApp.Application.Features.Posts.Requests.Queries;
using BlogApp.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Application.Features.Posts.Handlers.Queries
{
    public class GetPostsQueryHandler : IRequestHandler<GetPostsQuery, Result<List<PostDTO>>>
    {
        public Task<Result<List<PostDTO>>> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result<List<PostDTO>>.Success(new List<PostDTO>() { }, "Posts retrived."));
        }
    }
}
