using BizLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.ViewModels
{
    public class HomeVM
    {
        public List<Team> Team { get; set; }
        public List<Settings> Settings { get; set; }
    }
}
