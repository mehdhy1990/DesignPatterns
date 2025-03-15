public class GitHubServices
{
    private readonly IClient _client;

    public GitHubServices(IClient client)
    {
        _client = client;
    }
    public int GetStars(string repoName)
    {
        return _client.GetRepo(repoName: repoName).Stars;
    }
}