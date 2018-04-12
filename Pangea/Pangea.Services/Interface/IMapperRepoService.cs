using Pangea.Services.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pangea.Services.Interface
{
    public interface IMapperRepoService
    {
        List<RepoModel> MapGitHubRepoToRepoModel(dynamic value);
    }
}
