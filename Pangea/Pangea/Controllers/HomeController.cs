using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pangea.Models;
using Pangea.Services.Interface;

namespace Pangea.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQueryRepoService _queryRepoService;
        private readonly IMapperRepoService _mapperRepoService;
        private readonly IMapper _mapper;

        public HomeController(IQueryRepoService queryRepoService, IMapperRepoService mapperRepoService, IMapper mapper)
        {
             _queryRepoService = queryRepoService;
            _mapperRepoService = mapperRepoService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            dynamic pangeaRepos = _queryRepoService.ProcessRepo("test").Result;

            var repos = _mapperRepoService.MapGitHubRepoToRepoModel(pangeaRepos);
            List<RepoListViewModel> mappedRepos = _mapper.Map<List<RepoListViewModel>>(repos);
            
            return View(mappedRepos);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
