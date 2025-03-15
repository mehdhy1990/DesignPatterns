// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.DependencyInjection;

var service = new ServiceCollection();
service.AddTransient<IClient, GitHubClinet>();
service.AddTransient<GitHubServices>();
var serviceProvider = service.BuildServiceProvider();
var client = serviceProvider.GetRequiredService<GitHubClinet>();
var githubservice = serviceProvider.GetRequiredService<GitHubServices>();
var stars = githubservice.GetStars(repoName: "hello world");
Console.WriteLine(value: stars);