﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Infrastructure.Configuration
{
    using BookmakerService.Domain.AggregateModels.Bookmaker.Repository;
    using BookmakerService.Infrastructure.Repository;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the infrastructure services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IBookmakerRepository, BookmakerRepository>();
        }
    }
}