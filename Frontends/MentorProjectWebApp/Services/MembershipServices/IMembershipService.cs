﻿namespace MentorProjectWebApp.Services.MembershipServices
{
    using MentorProjectWebApp.Dtos.MembershipDtos;
    using MentorProjectWebApp.Repositories;

    public interface IMembershipService : IGenericRepository<CreateMembershipDto, UpdateMembershipDto, ResultMembershipDto, ResultMembershipByIdDto, int>
    {
    }

}