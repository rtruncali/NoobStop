using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using MVCForum.Domain.DomainModel;
using MVCForum.Domain.DomainModel.Enums;
using MVCForum.Website.Application;


namespace MVCForum.Website.ViewModels
{
    public class BubbleImageModel
    {
        public Guid BubbleImageID { get; set; }

        [StringLength(150, MinimumLength = 4)]
        public string Title { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string ImageAuthor { get; set; }

        
    }
}