// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Domain.AggregateModels.Bookmaker.Repository
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerService.Domain.SeedWork;

    /// <summary>
    /// <see cref="IBookmakerRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Bookmaker}" />
    public interface IBookmakerRepository : IRepository<Bookmaker>
    {
        /// <summary>
        /// Gets the bookmaker by base URL and country asynchronous.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="country">The country.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<Bookmaker> GetBookmakerByBaseUrlAndCountryAsync(string baseUrl, string country, CancellationToken cancellationToken);
    }
}