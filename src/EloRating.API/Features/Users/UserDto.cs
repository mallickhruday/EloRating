using EloRating.Core.Models;
using System;

namespace EloRating.API.Features.Users
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public static UserDto FromUser(User user)
            => new UserDto
            {
                UserId = user.UserId,
                Username = user.Username
            };
    }
}
