namespace Common.Structures.HttpTokenAuthentication
{
    public class TokenAuthenticationCredentials : HttpAuthentication.HttpAuthentication
    {
        private const string token = nameof(token);

        public TokenAuthenticationCredentials(string secret) : base(token, secret)
        {
        }
    }
}
