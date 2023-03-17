// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByBookmakerIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByBookmakerIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker
{
    /// <summary>
    /// <see cref="GetByBookmakerIdDto"/>
    /// </summary>
    public class GetByBookmakerIdDto
    {
        /// <summary>
        /// Gets the bookmaker identifier.
        /// </summary>
        /// <value>The bookmaker identifier.</value>
        public Guid BookmakerId { get; init; }
    }
}