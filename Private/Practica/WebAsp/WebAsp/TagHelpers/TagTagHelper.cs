using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAsp.TagHelpers
{
    public class TagTagHelper:TagHelper
    {
        public decimal  CurrentPrice { get; set; }
        public decimal? DiscountPrice { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h6";
            output.Attributes.SetAttribute("class", "card-subtitle mb-2 text-muted");
            if (DiscountPrice == null)
            {
                output.Content.SetHtmlContent("<span>" + this.CurrentPrice.ToString("0.##") + "</span>");

            }
            else
            {
              output.Content.SetHtmlContent("<del>"+this.CurrentPrice.ToString("0.##")+"</del>"+" "+"<span>" + this.DiscountPrice.Value.ToString("0.##") + "</span>");

            }
        }
    }
}
