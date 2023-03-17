// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateBookmakerDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CreateBookmakerDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Validation.Bookmaker
{
    using BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using FluentValidation;

    /// <summary>
    /// <see cref="CreateBookmakerDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CreateBookmakerDto}"/>
    public class CreateBookmakerDtoValidator : AbstractValidator<CreateBookmakerDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBookmakerDtoValidator"/> class.
        /// </summary>
        public CreateBookmakerDtoValidator()
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