// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Mappers
{
    using AutoMapper;
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using BookmakerService.Presentation.WebAPI.Dtos.Output.Bookmaker;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<Bookmaker, BookmakerDetailsDto>();

            this.CreateMap<Bookmaker, BookmakerDto>();
        }
    }
}