using System;
using System.Collections.Generic;

namespace Avalonia
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            List<BlogsEntity> BlogsEntitity = new List<BlogsEntity>(){
            new BlogsEntity() {
                Article = "Lorem Ipsum", 
                Text = "Fedir fedisfsdfshklf pon", 
                ImagePath = "happy.png",
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"} },
            new BlogsEntity() 
            {Article = "Майские указы", Text = "Назначен новый министр обороны!"},
            new BlogsEntity() 
            {Article = "Это конец?", Text = "С группой 9.4 занятий больше не будет"},
        };
        }
    }
}