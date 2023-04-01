using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();
            var jefferUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Jefferson"),
                new Claim("LastName", "Estrada"),
                new Claim(ClaimTypes.Name, "jestrada@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            },
        authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimous)));
        }
    }
}
