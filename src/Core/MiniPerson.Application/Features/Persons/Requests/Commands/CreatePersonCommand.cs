﻿using MiniPerson.Domain.DTO;
using MediatR;

namespace MiniPerson.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreatePersonCommand : IRequest<long>
    {
        public PersonDto PersonDto { get; set; }
    }
}
