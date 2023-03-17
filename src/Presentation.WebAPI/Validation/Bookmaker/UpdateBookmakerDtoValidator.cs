// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateBookmakerDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// UpdateBookmakerDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Validation.Bookmaker
{
    using BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using FluentValidation;

    /// <summary>
    /// <see cref="UpdateBookmakerDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{UpdateBookmakerDto}"/>
    public class UpdateBookmakerDtoValidator : AbstractValidator<UpdateBookmakerDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBookmakerDtoValidator"/> class.
        /// </summary>
        public UpdateBookmakerDtoValidator()
        {
            this.RuleFor(x => x.BaseUrl)
                .NotEmpty()
                    .WithMessage("The Base URL shouldn't be empty.");

            this.RuleFor(x => x.Country)
                .NotEmpty()
                    .WithMessage("The Country shouldn't be empty.");

            this.RuleFor(x => x.Description)
                .NotEmpty()
                    .WithMessage("The Description shouldn't be empty.");

            this.RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("The Name shouldn't be empty.");
        }
    }
}