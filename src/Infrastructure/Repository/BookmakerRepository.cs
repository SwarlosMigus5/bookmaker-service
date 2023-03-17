// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Infrastructure.Repository
{
    using System.Threading;
    using System.Threading.Tasks;
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using BookmakerService.Domain.AggregateModels.Bookmaker.Repository;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// <see cref="BookmakerRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Bookmaker}" />
    /// <seealso cref="IBookmakerRepository" />
    internal class BookmakerRepository : GenericRepository<Bookmaker>, IBookmakerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookmakerRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public BookmakerRepository(BookmakerServiceDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the bookmaker by base URL and country asynchronous.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="country">The country.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Bookmaker> GetBookmakerByBaseUrlAndCountryAsync(string baseUrl, string country, CancellationToken cancellationToken)
        {
            return await this.Entities.SingleOrDefaultAsync(b =>
                b.BaseUrl == baseUrl &&
                b.Country == country);
        }
    }
}