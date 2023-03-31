# AddressTools
A simple NuGet library for dealing with physical addresses. 

To add from GitHub Packages, you will first need to add a [Personal Access Token for GitHub](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).
Then you can add the BrewCode NuGet repo by running this `dotnet` command:
```
dotnet nuget add source "https://nuget.pkg.github.com/Let-s-Brew/index.json" --name "BrewCodeGitHub" --username "YOUR_GITHUB_LOGIN" -- password "YOUR_ACCESS_TOKEN"
```

Replace `YOUR_GITHUB_USERNAME` and `YOUR_ACCESS_TOKEN` with your GitHub login and token, respectively.

Currently, only `CivicAddress` class from package `BrewCode.AddressTools.Models` is available. Validators will be added soon.