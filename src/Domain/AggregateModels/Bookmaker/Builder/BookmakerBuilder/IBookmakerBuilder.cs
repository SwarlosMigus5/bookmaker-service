// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Domain.AggregateModels.Bookmaker.Builder.BookmakerBuilder
{
    /// <summary>
    /// <see cref="IBookmakerBuilder"/>
    /// </summary>
    public interface IBookmakerBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Bookmaker Build();

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        IBookmakerBuilder NewBookmaker(string name, string baseUrl, string comments, string description, string country);
    }
}