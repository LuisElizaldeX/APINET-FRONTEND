namespace frontendnet.Models;

public class AuthUser
{
    public required String Email { get; set; }
    public required string Nombre { get; set; }
    public required string Rol { get; set; }
    public required string Jwt { get; set; }
}