using Common.Structures.HttpAuthentication;

namespace Common.Structures.HttpTokenAuthentication
{
    public class TokenAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        public TokenAuthenticationCredentials(string secret) : base(PrefixType.token, secret)
        {
        }
    }
}
