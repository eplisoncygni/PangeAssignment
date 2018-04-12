using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Pangea.Models
{
    public class RepoListViewModel
    {
        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Starred")]
        public string Starred { get; set; }

        [DisplayName("Language")]
        public string Language { get; set; }

        [DisplayName("Avatar")]
        public string ImageUrl { get; set; }
    }
}
