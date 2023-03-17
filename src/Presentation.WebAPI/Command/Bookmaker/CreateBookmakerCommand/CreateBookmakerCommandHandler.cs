// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateBookmakerCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateBookmakerCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.CreateBookmakerCommand
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using BookmakerService.Domain.AggregateModels.Bookmaker.Builder.BookmakerBuilder;
    using BookmakerService.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerService.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="CreateBookmakerCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{CreateBookmakerCommand,Bookmaker}" />
    public class CreateBookmakerCommandHandler : IRequestHandler<CreateBookmakerCommand, Bookmaker>
    {
        /// <summary>
        /// The bookmaker builder
        /// </summary>
        private readonly IBookmakerBuilder bookmakerBuilder;

        /// <summary>
        /// The bookmaker repository
        /// </summary>
        private readonly IBookmakerRepository bookmakerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBookmakerCommandHandler"/> class.
        /// </summary>
        /// <param name="bookmakerRepository">The bookmaker repository.</param>
        /// <param name="bookmakerBuilder">The bookmaker builder.</param>
        public CreateBookmakerCommandHandler(
            IBookmakerRepository bookmakerRepository,
            IBookmakerBuilder bookmakerBuilder)
        {
            this.bookmakerRepository = bookmakerRepository;
            this.bookmakerBuilder = bookmakerBuilder;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="DuplicatedException">The bookmaker with base url {request.BaseUrl} in {request.Country} is duplicated.</exception>
        public async Task<Bookmaker> Handle(CreateBookmakerCommand request, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.bookmakerRepository.GetBookmakerByBaseUrlAndCountryAsync(
                request.BaseUrl,
                request.Country,
                cancellationToken);

            if (bookmaker is not null)
            {
                throw new DuplicatedException($"The bookmaker with base url {request.BaseUrl} in {request.Country} is duplicated.");
            }

            bookmaker = this.bookmakerBuilder
                .NewBookmaker(
                    request.Name,
                    request.BaseUrl,
                    request.Comments,
                    request.Description,
                    request.Country)
                .Build();

            await this.bookmakerRepository.AddAsync(bookmaker, cancellationToken);

            await this.bookmakerRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return bookmaker;
        }
    }
}