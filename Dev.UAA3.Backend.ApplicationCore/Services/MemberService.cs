using Dev.UAA3.Backend.ApplicationCore.Interfaces;
using Dev.UAA3.Backend.Domain.BusinessExceptions;
using Dev.UAA3.Backend.Domain.Models;
using Dev.UAA3.Backend.Domain.Services;
using Isopoh.Cryptography.Argon2;

namespace Dev.UAA3.Backend.ApplicationCore.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public Member Login(string email, string password)
        {
            string? passwordHashed = _memberRepository.GetPasswordHashed(email);

            if (passwordHashed is null) 
                throw new MemberBadCredentialException();
        
            if(!Argon2.Verify(passwordHashed, password))
                throw new MemberBadCredentialException();

            return _memberRepository.GetByEmail(email);
        }

        public Member Register(string email, string password)
        {
            string passwordHashed = Argon2.Hash(password);

            Member memberToAdded = new Member(email, passwordHashed);
            return _memberRepository.Create(memberToAdded);
        }
    }
}
