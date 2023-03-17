// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace BookmakerService.Presentation.WebAPI.Controllers
{
    using System.Net;
    using AutoMapper;
    using BookmakerService.Domain.AggregateModels.Bookmaker;
    using BookmakerService.Presentation.WebAPI.Command.Bookmaker.CreateBookmakerCommand;
    using BookmakerService.Presentation.WebAPI.Command.Bookmaker.DeleteBookmakerCommand;
    using BookmakerService.Presentation.WebAPI.Command.Bookmaker.UpdateBookmakerCommand;
    using BookmakerService.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using BookmakerService.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using BookmakerService.Presentation.WebAPI.Queries.Bookmaker.GetAllBookmakersQuery;
    using BookmakerService.Presentation.WebAPI.Queries.Bookmaker.GetByBookmakerIdQuery;
    using BookmakerService.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BookmakerController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1/Bookmaker")]
    public class BookmakerController : Controller
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookmakerController"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="mapper">The mapper.</param>
        public BookmakerController(
            IMediator mediator,
            IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        /// <summary>
        /// Creates the bookmaker asynchronous.
        /// </summary>
        /// <param name="createBookmakerDto">The create bookmaker dto.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BookmakerDetailsDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateBookmakerAsync([FromBody] CreateBookmakerDto createBookmakerDto, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.mediator.Send(new CreateBookmakerCommand
            {
                BaseUrl = createBookmakerDto.BaseUrl,
                Comments = createBookmakerDto.Comments,
                Country = createBookmakerDto.Country,
                Description = createBookmakerDto.Description,
                Name = createBookmakerDto.Name
            }, cancellationToken);

            return this.Created(string.Empty, this.mapper.Map<BookmakerDetailsDto>(bookmaker));
        }

        /// <summary>
        /// Deletes the bookmaker asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpDelete("{BookmakerId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteBookmakerAsync([FromRoute] GetByBookmakerIdDto filter, CancellationToken cancellationToken)
        {
            await this.mediator.Publish(new DeleteBookmakerCommand
            {
                BookmakerId = filter.BookmakerId
            }, cancellationToken);

            return this.Ok();
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BookmakerDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            IEnumerable<Bookmaker> bookmaker = await this.mediator.Send(new GetAllBookmakersQuery(), cancellationToken);

            return this.Ok(this.mapper.Map<IEnumerable<BookmakerDto>>(bookmaker));
        }

        /// <summary>
        /// Gets the by bookmaker identifier asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet("{BookmakerId}")]
        [ProducesResponseType(typeof(BookmakerDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetByBookmakerIdAsync([FromRoute] GetByBookmakerIdDto filter, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.mediator.Send(new GetByBookmakerIdQuery
            {
                BookmakerId = filter.BookmakerId
            }, cancellationToken);

            return this.Ok(this.mapper.Map<BookmakerDetailsDto>(bookmaker));
        }

        /// <summary>
        /// Updates the bookmaker asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="updateBookmakerDto">The update bookmaker dto.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPut("{BookmakerId}")]
        [ProducesResponseType(typeof(BookmakerDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateBookmakerAsync(
            [FromRoute] GetByBookmakerIdDto filter,
            [FromBody] UpdateBookmakerDto updateBookmakerDto,
            CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.mediator.Send(new UpdateBookmakerCommand
            {
                BookmakerId = filter.BookmakerId,
                BaseUrl = updateBookmakerDto.BaseUrl,
                Comments = updateBookmakerDto.Comments,
                Country = updateBookmakerDto.Country,
                Description = updateBookmakerDto.Description,
                Name = updateBookmakerDto.Name
            }, cancellationToken);

            return this.Ok(this.mapper.Map<BookmakerDetailsDto>(bookmaker));
        }
    }
}