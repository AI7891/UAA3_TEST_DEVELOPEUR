using Dev.UAA3.Backend.ApplicationCore.Interfaces;
using Dev.UAA3.Backend.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Dev.UAA3.Backend.Infrastructure.Database.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _dbContext;
        public MemberRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Member Create(Member member)
        {
            EntityEntry<Member> element = _dbContext.Members.Add(member);
            _dbContext.SaveChanges();

            var result = element.Entity;
            return new Member(result.Id, result.Email);
        }

        public Member GetByEmail(string email)
        {
            var member = _dbContext.Members
                .Select(m => new { m.Id, m.Email })
                .Single(m => m.Email == email);

            return new Member(member.Id, member.Email);
        }

        public string? GetPasswordHashed(string email)
        {
            return _dbContext.Members.SingleOrDefault(m => m.Email == email)?.Password;
        }
    }
}
