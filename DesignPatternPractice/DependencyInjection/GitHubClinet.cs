public class GitHubClinet : IClient
{
    public (string repoName, int Stars) GetRepo(string repoName)
    {
        return (repoName: repoName, Stars: repoName.Length);
    }
}