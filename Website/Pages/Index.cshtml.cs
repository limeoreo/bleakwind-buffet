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
        public int? CalMin;
        public int? CalMax;
        public double? PriceMin;
        public double? PriceMax;

        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] MPAARatings { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        public void OnGet(double? PriceMin, double? PriceMax, int? CalMin, int? CalMax )
        {
            //Items = Menu.FilterByCalories(Items, CalMin, CalMax);
            //Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);

            Items = Menu.FullMenu() ;
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CalMin = CalMin;
            this.CalMax = CalMax;
            // Search item name and description for the SearchTerms
            if (SearchTerms != null)
            {
                Items = Items.Where(item => (item.ToString() != null && item.ToString().Contains(
                    SearchTerms, StringComparison.InvariantCultureIgnoreCase)) ||(item.Description != null && item.Description.Contains(
                        SearchTerms, StringComparison.InvariantCultureIgnoreCase)));
            }
            // Filter by category 
            if (Categories != null && Categories.Length != 0)
            {
                Items = Items.Where(item => (Categories.Contains("drinks") && Menu.Drinks().Contains(item))
                || (Categories.Contains("entrees") && Menu.Entrees().Contains(item))
                || (Categories.Contains("sides") && Menu.Sides().Contains(item)));
            }
            if (PriceMin != null || PriceMax != null)
            {
                Items = Items.Where(item => (PriceMin == null && item.Price <= PriceMax) || (PriceMax == null && item.Price >= PriceMin)
                || (PriceMin!= null && PriceMax != null && item.Price >= PriceMin && item.Price <= PriceMax));
            }
            if (CalMin != null || CalMax != null)
            {
                Items = Items.Where(item => (CalMin == null && item.Calories <= CalMax) || (CalMax == null && item.Calories >= CalMin)
                || (CalMin != null && CalMax != null && item.Calories >= CalMin && item.Calories <= CalMax));
            }
        }
    }
}
