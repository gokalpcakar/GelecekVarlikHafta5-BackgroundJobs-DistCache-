﻿using AutoMapper;
using Icarus.DB.Entities;
using Icarus.Model.User;

namespace Icarus.API.Infrastructure
{
    public class MappingProfile : Profile
    {      
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
        }
    }
}