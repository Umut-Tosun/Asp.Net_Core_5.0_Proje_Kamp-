using core_projem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_projem.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<CommentUser>
            {
                new CommentUser
                {
                    ID=1,
                    UserName="umut"

                },
                new CommentUser
                {
                    ID=2,
                    UserName="melih"

                },

            };
        
            return View(values);
        }
    }
}
