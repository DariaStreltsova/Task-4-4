using System;
using System.Collections.Generic;

namespace Avalonia
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            BlogEnities = List<BlogEnities>
            (
            new BlogEnity{Article = "Зоголовок 1"; Text = "Текст 1"; TagsList = new string []("Tag 1, Tag 2")},
            new BlogEnity{Article = "Зоголовок 2"; Text = "Текст 2"; TagsList = new string []("Tag 3, Tag 4")},
            new BlogEnity{Article = "Зоголовок 3"; Text = "Текст 3"; TagsList = new string []("Tag 5, Tag 6")}
            )
        }
    }
}