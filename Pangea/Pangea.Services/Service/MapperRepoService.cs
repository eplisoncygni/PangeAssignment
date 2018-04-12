using Pangea.Services.Interface;
using Pangea.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pangea.Services.Service
{
   public class MapperRepoService : IMapperRepoService
    {
        public List<RepoModel> MapGitHubRepoToRepoModel(dynamic pangeaRepos)
        {

            var repoModel = new List<RepoModel>();
            foreach (var repo in pangeaRepos)
            {
                repoModel.Add(new RepoModel()
                {
                    ImageUrl = repo["owner"]["avatar_url"],
                    Language = repo["language"],
                    Name = repo["name"],
                    Starred = repo["stargazers_count"]
                });
            };

            return repoModel;
        }
    }
}
