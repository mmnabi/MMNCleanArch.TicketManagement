using MMNCleanArch.TicketManagement.Application.Models.Authentication;

namespace MMNCleanArch.TicketManagement.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}
