using MVCLocalGlobalization.App_LocalResources.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLocalGlobalization.Models
{
    public class UserModel
    {
        // Bind local resource with model

        [Display(Name ="Name", ResourceType=typeof(Index))]
        public string Name { get; set; }

        [Display(Name = "Address", ResourceType = typeof(Index))]
        public string Address { get; set; }

    }
}