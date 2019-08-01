using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GigMatcher.Areas.Identity.Pages.Account.Manage
{
    public class ProfileModel : PageModel
    {
        public string StatusMessage { get; set; }
        public void OnGet()
        {
        }
    }
}