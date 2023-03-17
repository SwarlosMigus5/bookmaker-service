// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllBookmakersQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetAllBookmakersQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Queries.Bookmaker.GetAllBookmakersQuery
{
    using Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="GetAllBookmakersQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Bookmaker}}" />
    public class GetAllBookmakersQuery : IRequest<IEnumerable<Bookmaker>>
    {
    }
}