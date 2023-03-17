// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateBookmakerCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateBookmakerCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.UpdateBookmakerCommand
{
    using Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="UpdateBookmakerCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Bookmaker}"/>
    public class UpdateBookmakerCommand : IRequest<Bookmaker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookmakerCommand"/> class.
        /// </summary>
        public UpdateBookmakerCommand()
        {
            this.BaseUrl = string.Empty;
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Comments = string.Empty;
            this.Country = string.Empty;
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; init; }

        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }

        /// <summary>
        /// Gets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string Comments { get; init; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; init; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }
    }
}