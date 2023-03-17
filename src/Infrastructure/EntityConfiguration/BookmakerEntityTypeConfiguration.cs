// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Infrastructure.EntityConfiguration
{
    using System;
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="BookmakerEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Bookmaker}"/>
    internal class BookmakerEntityTypeConfiguration : EntityTypeConfiguration<Bookmaker>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Bookmaker";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Bookmaker> builder)
        {
            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.BaseUrl)
                .IsRequired()
                .HasMaxLength(120);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.Country)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasData(
                CreateBookmaker(
                    1,
                    Guid.Parse("749e2e24-9b1b-4210-ae6d-4275d12c41f7"),
                    "Betano",
                    "https://www.betano.pt/",
                    string.Empty,
                    "Casa de apostas portuguesa Betano.",
                    "Portugal"),
                CreateBookmaker(
                    2,
                    Guid.Parse("ae32838d-2820-4c64-b73b-6bd04c497ec2"),
                    "Betclic",
                    "https://www.betclic.pt/",
                    string.Empty,
                    "Casa de apostas portuguesa Betclic",
                    "Portugal"),
                CreateBookmaker(
                    3,
                    Guid.Parse("6521ef65-1c7e-4c35-944d-c864ac16fda6"),
                    "ESC Online",
                    "https://www.estorilsolcasinos.pt/pt",
                    string.Empty,
                    "Casa de apostas portuguesa ESC Online",
                    "Portugal"),
                CreateBookmaker(
                    4,
                    Guid.Parse("64a3706f-ba1b-4797-8638-963032550786"),
                    "SolVerde",
                    "https://apostas.solverde.pt/home",
                    string.Empty,
                    "Casa de apostas portuguesa SolVerde",
                    "Portugal"),
                CreateBookmaker(
                    5,
                    Guid.Parse("5088765d-b7cf-4752-95d8-d479a8ca554d"),
                    "Placard",
                    "https://www.placard.pt/apostas",
                    string.Empty,
                    "Casa de apostas portuguesa Placard",
                    "Portugal"),
                CreateBookmaker(
                    6,
                    Guid.Parse("29ec9761-132a-43b2-a541-198196bae977"),
                    "Casino Portugal",
                    "https://www.casinoportugal.pt/",
                    string.Empty,
                    "Casa de apostas portuguesa Casino Portugal",
                    "Portugal"),
                CreateBookmaker(
                    7,
                    Guid.Parse("03cd7fc5-79ef-4655-b02b-a1ecddae75e1"),
                    "Bwin",
                    "https://sports.bwin.pt/pt/sports",
                    string.Empty,
                    "Casa de apostas portuguesa Bwin",
                    "Portugal"));
        }

        /// <summary>
        /// Creates the bookmaker.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="country">The country.</param>
        /// <returns></returns>
        private static Bookmaker CreateBookmaker(
            long id,
            Guid bookmakerId,
            string name,
            string baseUrl,
            string comments,
            string description,
            string country)
        {
            Bookmaker bookmaker = new();

            bookmaker.Update(name, baseUrl, comments, description, country);

            bookmaker.UpdateEntityBase(DateTime.Now, DateTime.Now, bookmakerId, id);

            return bookmaker;
        }
    }
}