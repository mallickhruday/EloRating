namespace EloRating.Core.Identity
{
    public interface ISecurityTokenFactory
    {
        string Create(string username);
    }
}
