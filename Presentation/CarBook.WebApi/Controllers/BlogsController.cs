using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Queries.TagCloudQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ekleme Başarılı");
        }


        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpadeteBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command); ;
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetLast3BlogsWithAuthors")]
        public async Task<IActionResult> GetLast3BlogsWithAuthors()
        {
            var values = _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        }

        [HttpGet("GetAllBlogsWithAuthors")]
        public async Task<IActionResult> GetAllBlogsWithAuthors()
        {
            var values = _mediator.Send(new GetAllBlogsWithAuthorsQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
