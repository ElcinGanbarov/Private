using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspWebSiteH.Models;

namespace AspWebSiteH.TagHelpers
{
    public class PriceTagHelper:TagHelper
    {
        Product product = new Product();
        public decimal CurrentPrice { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.Attributes.SetAttribute("class", "form-control");
            output.Attributes.SetAttribute("asp-for", product.Price);

            //output.Content.SetContent(this.CurrentPrice.ToString("0.00"));
        }
    }
}
