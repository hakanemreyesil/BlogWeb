namespace BlogApi.Token
{
    public interface ITokenHandler
    {
        BlogApi.DTO.Token CreateAccessToken(int minute);
    }
}
