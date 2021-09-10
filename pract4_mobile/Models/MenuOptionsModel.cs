using System;
using System.Collections.Generic;
using System.Text;

namespace pract4_mobile.Models
{
    public class MenuOptionsModel
    {
        public MenuOptionsModel(string title, string image, string detail)
        {
            Title = title;
            Image = image;
            Detail = detail;
        }

        public string Title { get; }
        public string Image { get; }
        public string Detail { get; }
    }
}
