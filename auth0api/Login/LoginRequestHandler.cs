using System.Threading.Tasks;
using auth0api.Data;
using auth0api.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace auth0api.Login
{
    public class LoginRequest : IRequest
    {
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class LoginRequestHandler : IAsyncRequestHandler<LoginRequest>
    {
        private readonly ApplicationDbContext _dbContext;

        public LoginRequestHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Handle(LoginRequest message)
        {
            var existingUser = await _dbContext.Users.SingleOrDefaultAsync(u => u.ExternalId == message.ExternalId);

            if (existingUser == null)
            {
                await _dbContext.Users.AddAsync(new ApplicationUser
                {
                    ExternalId = message.ExternalId,
                    Username = message.Username,
                    Email = message.Email,
                    FirstName = message.FirstName,
                    LastName = message.LastName
                });
            }
            else
            {
                existingUser.Username = message.Username;
                existingUser.Email = message.Email;
                existingUser.FirstName = message.FirstName;
                existingUser.LastName = message.LastName;
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
