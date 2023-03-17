// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateBookmakerCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateBookmakerCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.UpdateBookmakerCommand
{
    using BookmakerService.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerService.Domain.Exceptions;
    using Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="UpdateBookmakerCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{UpdateBookmakerCommand, Bookmaker}"/>
    public class UpdateBookmakerCommandHandler : IRequestHandler<UpdateBookmakerCommand, Bookmaker>
    {
        /// <summary>
        /// The bookmaker repository
        /// </summary>
        private readonly IBookmakerRepository bookmakerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookmakerCommandHandler"/> class.
        /// </summary>
        /// <param name="bookmakerRepository">The bookmaker repository.</param>
        public UpdateBookmakerCommandHandler(IBookmakerRepository bookmakerRepository)
        {
            this.bookmakerRepository = bookmakerRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">
        /// The bookmaker with id {request.BookmakerId} wasn't found.
        /// </exception>
        public async Task<Bookmaker> Handle(UpdateBookmakerCommand request, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.bookmakerRepository.GetAsync(request.BookmakerId, cancellationToken);

            if (bookmaker is null)
            {
                throw new NotFoundException($"The bookmaker with id {request.BookmakerId} wasn't found.");
            }

            bookmaker.Update(
                request.Name,
                request.BaseUrl,
                request.Comments,
                request.Description,
                request.Country);

            await this.bookmakerRepository.Update(bookmaker, cancellationToken);

            await this.bookmakerRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return bookmaker;
        }
    }
}