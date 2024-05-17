using System;
using System.Collections.Generic;
using Task_4_4.Models;

namespace Task_4_4.ViewModels{

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
        [
            new BlogsEntity {Article = "Заголовок 1", Text = "text 1", Tags = ["Tag11, Tag11"]},
            new BlogsEntity {Article = "Заголовок 2", Text = "text 2", Tags = ["Tag12, Tag22"]},
            new BlogsEntity {Article = "Заголовок 3", Text = "text 3", Tags = ["Tag13, Tag23"]}
        ];
        NewsEntities =
        [
            new NewsEntity { Text = "news 1", PublishTime = DateTime.Now},
            new NewsEntity { Text = "news 2", PublishTime = DateTime.Now},
            new NewsEntity { Text = "news 3", PublishTime = DateTime.Now}
        ];
    }
    public List<BlogsEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}
}