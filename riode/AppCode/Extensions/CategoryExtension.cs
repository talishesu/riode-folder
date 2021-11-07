using Microsoft.AspNetCore.Html;
using riode.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace riode.AppCode.Extensions
{
    static public partial class Extension
    {
        static public IEnumerable<Categories> GetChildCategories(this Categories parent)
        {
            if (parent.BigCategoryId != null)
                yield return parent;

            foreach (var child in parent.Children.SelectMany(c => c.GetChildCategories()))
            {
                yield return child;
            }
        }

        static public HtmlString GetCategoriesRaw(this IEnumerable<Categories> categories)
        {
            if (categories == null || !categories.Any())
            {
                return HtmlString.Empty;
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("<ul class='widget-body filter-items search-ul'>");

            foreach (var category in categories.Where(c => c.DeletedDate == null && c.BigCategoryId == null))
            {
                AppendChildren(category);
            }


            sb.Append("</ul>");

            //return sb.ToString();
            return new HtmlString(sb.ToString());


            void AppendChildren(Categories parent)
            {
                if (parent.Children.Any())
                {
                    sb.Append($"<li class='with-ul'><a href='#'>{parent.Name}</a><ul>");

                }
                else
                {
                    sb.Append($"<li><a href='#'>{parent.Name}</a>");
                }
                

                foreach (var category in parent.Children.Where(c => c.DeletedDate == null))
                {
                    AppendChildren(category);
                }

                if (parent.Children.Any())
                {
                    sb.Append($"</ul></li>");
                }
                else
                {
                    sb.Append($"</li>");
                }

                
            }
        }
    }
}
