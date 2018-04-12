using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pangea.Services.Interface
{
    public interface IQueryRepoService
    {
        Task<dynamic> ProcessRepo(string repoUrl);
    }
}
