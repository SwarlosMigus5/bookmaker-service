// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Domain.AggregateModels.Bookmaker.Builder.BookmakerBuilder
{
    /// <summary>
    /// <see cref="BookmakerBuilder"/>
    /// </summary>
    /// <seealso cref="IBookmakerBuilder" />
    internal class BookmakerBuilder : IBookmakerBuilder
    {
        /// <summary>
        /// The bookmaker
        /// </summary>
        private Bookmaker bookmaker;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Bookmaker Build()
        {
            return bookmaker;
        }

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        public IBookmakerBuilder NewBookmaker(string name, string baseUrl, string comments, string description, string country)
        {
            bookmaker = new Bookmaker(name, baseUrl, comments, description, country);

            return this;
        }
    }
}