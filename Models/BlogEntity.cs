using System;
using System.Collections.Generic;

namespace Avalonia
{
    public class BlogEntity : MainWindowViewModel
    {
        public string Article {get; set;}
        public string Text {get; set;}
        public List<string> Tags {get; set;}
        public string ImagePath {get; set;}
    }
}