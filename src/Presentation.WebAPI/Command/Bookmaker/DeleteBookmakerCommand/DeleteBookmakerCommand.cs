// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteBookmakerCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteBookmakerCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.DeleteBookmakerCommand
{
    using MediatR;

    /// <summary>
    /// <see cref="DeleteBookmakerCommand"/>
    /// </summary>
    /// <seealso cref="INotification"/>
    public class DeleteBookmakerCommand : INotification
    {
        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }
    }
}