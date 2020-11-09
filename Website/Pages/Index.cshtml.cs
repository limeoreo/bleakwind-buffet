using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Items { get; protected set; }
        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }

        public void OnGet(string SearchTerms, string[] Categories, int CalMin, int CalMax, double PriceMin, double PriceMax )
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
