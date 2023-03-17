// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    /// <see cref="BookmakerDto"/>
    /// </summary>
    public class BookmakerDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookmakerDto"/> class.
        /// </summary>
        public BookmakerDto()
        {
            this.BaseUrl = string.Empty;
            this.Country = string.Empty;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        public string BaseUrl { get; init; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        /// <value>The country.</value>
        public string Country { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; }

        /// <summary>
        /// Gets the uu identifier.
        /// </summary>
        /// <value>The uu identifier.</value>
        public Guid UUId { get; init; }
    }
}