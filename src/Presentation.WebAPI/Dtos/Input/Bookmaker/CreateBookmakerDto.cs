// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateBookmakerDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateBookmakerDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker
{
    /// <summary>
    /// <see cref="CreateBookmakerDto"/>
    /// </summary>
    public class CreateBookmakerDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBookmakerDto"/> class.
        /// </summary>
        public CreateBookmakerDto()
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