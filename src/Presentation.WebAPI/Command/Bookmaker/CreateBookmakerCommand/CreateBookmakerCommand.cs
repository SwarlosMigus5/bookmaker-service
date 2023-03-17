// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateBookmakerCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateBookmakerCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Command.Bookmaker.CreateBookmakerCommand
{
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="CreateBookmakerCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Bookmaker}"/>
    public class CreateBookmakerCommand : IRequest<Bookmaker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBookmakerCommand"/> class.
        /// </summary>
        public CreateBookmakerCommand()
        {
            this.BaseUrl = string.Empty;
            this.Country = string.Empty;
            this.Description = string.Empty;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; init; }

        /// <summary>
        /// Gets the comments.
        /// </summary>
        /// <value>The comments.</value>
        public string? Comments { get; init; }

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