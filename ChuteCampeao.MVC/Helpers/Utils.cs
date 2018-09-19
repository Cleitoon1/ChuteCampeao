using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.Helpers
{
    public class Utils
    {
        public static IEnumerable<SelectListItem> ListarStatus()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Value = "true", Text = "Ativo" },
                new SelectListItem() { Value = "false", Text = "Inativo" },
            };
        }
    }
}