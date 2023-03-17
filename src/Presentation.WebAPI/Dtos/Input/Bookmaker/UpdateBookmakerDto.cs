// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateBookmakerDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateBookmakerDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker
{
    /// <summary>
    /// <see cref="UpdateBookmakerDto"/>
    /// </summary>
    public class UpdateBookmakerDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookmakerDto"/> class.
        /// </summary>
        public UpdateBookmakerDto()
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