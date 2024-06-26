﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Blogs.Mediator.Handlers.BlogHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateAuthorCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.BlogID);
            values.AuthorID = request.AuthorID;
            values.CategoryID = request.CategoryID;
            values.CoverImageUrl = request.CoverImageUrl;
            values.CreatedDate = request.CreatedDate;
            values.Title = request.Title;
            values.Desription = request.Description;
            await _repository.UpdateAsync(values);
        }
    }
}