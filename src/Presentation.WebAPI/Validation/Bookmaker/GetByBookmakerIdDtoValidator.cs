// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByBookmakerIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByBookmakerIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Validation.Bookmaker
{
    using BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetByBookmakerIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetByBookmakerIdDto}"/>
    public class GetByBookmakerIdDtoValidator : AbstractValidator<GetByBookmakerIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByBookmakerIdDtoValidator"/> class.
        /// </summary>
        public GetByBookmakerIdDtoValidator()
        {
            this.RuleFor(x => x.BookmakerId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The BookmakerId shouldn't have the default value.");
        }
    }
}