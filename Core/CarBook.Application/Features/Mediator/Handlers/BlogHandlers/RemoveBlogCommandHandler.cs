﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Blogs.Mediator.Handlers.BlogHandlers
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public RemoveAuthorCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}