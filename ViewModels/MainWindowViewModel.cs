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
            new BlogsEntity {Article = "Article 1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ac lacus eros. Quisque ut neque condimentum ipsum eleifend euismod vel ac ligula. Vivamus urna diam, sodales eu est in, iaculis tempor nibh. Curabitur pulvinar ligula et velit faucibus imperdiet. Sed ex sem, bibendum sit amet vehicula ac, euismod at nulla. Praesent finibus augue ultrices, lobortis libero quis, lobortis ipsum. Mauris aliquam nulla porta, mattis urna non, hendrerit mi", Tags = ["Tag1, Tag2"], ImagePath = "r.jpg"},
            new BlogsEntity {Article = "Article 2", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ac lacus eros. Quisque ut neque condimentum ipsum eleifend euismod vel ac ligula. Vivamus urna diam, sodales eu est in, iaculis tempor nibh. Curabitur pulvinar ligula et velit faucibus imperdiet. Sed ex sem, bibendum sit amet vehicula ac, euismod at nulla. Praesent finibus augue ultrices, lobortis libero quis, lobortis ipsum. Mauris aliquam nulla porta, mattis urna non, hendrerit mi", Tags = ["Tag3, Tag4"], ImagePath = "r.jpg"},
            new BlogsEntity {Article = "Article 3", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ac lacus eros. Quisque ut neque condimentum ipsum eleifend euismod vel ac ligula. Vivamus urna diam, sodales eu est in, iaculis tempor nibh. Curabitur pulvinar ligula et velit faucibus imperdiet. Sed ex sem, bibendum sit amet vehicula ac, euismod at nulla. Praesent finibus augue ultrices, lobortis libero quis, lobortis ipsum. Mauris aliquam nulla porta, mattis urna non, hendrerit mi", Tags = ["Tag5, Tag6"], ImagePath = "r.jpg"},
        ];
        NewsEntities =
        [
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut a velit eu ligula euismod porta vulputate non lacus. Nulla tortor sem, faucibus eu nulla sed, elementum aliquet arcu. Maecenas dignissim tortor sed ex imperdiet viverra. Phasellus nec arcu at tortor auctor tempor non vel purus. In id nisi a urna commodo tincidunt. Morbi vel dui sem. Aenean viverra risus ut cursus tempus.", PublishTime = DateTime.Now},
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut a velit eu ligula euismod porta vulputate non lacus. Nulla tortor sem, faucibus eu nulla sed, elementum aliquet arcu. Maecenas dignissim tortor sed ex imperdiet viverra. Phasellus nec arcu at tortor auctor tempor non vel purus. In id nisi a urna commodo tincidunt. Morbi vel dui sem. Aenean viverra risus ut cursus tempus.", PublishTime = DateTime.Now},
            new NewsEntity { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut a velit eu ligula euismod porta vulputate non lacus. Nulla tortor sem, faucibus eu nulla sed, elementum aliquet arcu. Maecenas dignissim tortor sed ex imperdiet viverra. Phasellus nec arcu at tortor auctor tempor non vel purus. In id nisi a urna commodo tincidunt. Morbi vel dui sem. Aenean viverra risus ut cursus tempus.", PublishTime = DateTime.Now},
        ];
    }
    public List<BlogsEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}
}