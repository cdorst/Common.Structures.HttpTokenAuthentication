using Common.Structures.HttpAuthentication;
using System.Net.Http.Headers;

namespace Common.Structures.HttpTokenAuthentication
{
    public class TokenAuthenticationCredentials : IHttpAuthentication
    {
        private const string token = nameof(token);

        public TokenAuthenticationCredentials(string user, string secret)
        {
            Secret = secret;
        }

        public string Secret { get; set; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(token, Secret);
    }
}
