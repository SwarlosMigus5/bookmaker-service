// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteBookmakerCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteBookmakerCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.DeleteBookmakerCommand
{
    using BookmakerService.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerService.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="DeleteBookmakerCommandHandler"/>
    /// </summary>
    /// <seealso cref="INotificationHandler{DeleteBookmakerCommand}"/>
    public class DeleteBookmakerCommandHandler : INotificationHandler<DeleteBookmakerCommand>
    {
        /// <summary>
        /// The bookmaker repository
        /// </summary>
        private readonly IBookmakerRepository bookmakerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBookmakerCommandHandler"/> class.
        /// </summary>
        /// <param name="bookmakerRepository">The bookmaker repository.</param>
        public DeleteBookmakerCommandHandler(IBookmakerRepository bookmakerRepository)
        {
            this.bookmakerRepository = bookmakerRepository;
        }

        /// <summary>
        /// Handles a notification
        /// </summary>
        /// <param name="notification">The notification</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="NotFoundException">
        /// The bookmaker with id {notification.BookmakerId} wasn't found.
        /// </exception>
        public async Task Handle(DeleteBookmakerCommand notification, CancellationToken cancellationToken)
        {
            var bookmaker = await this.bookmakerRepository.GetAsync(notification.BookmakerId, cancellationToken);

            if (bookmaker is null)
            {
                throw new NotFoundException($"The bookmaker with id {notification.BookmakerId} wasn't found.");
            }

            await this.bookmakerRepository.Remove(bookmaker, cancellationToken);

            await this.bookmakerRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}