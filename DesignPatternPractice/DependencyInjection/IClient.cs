public interface IClient
{
    (string repoName, int Stars) GetRepo(string repoName);
}