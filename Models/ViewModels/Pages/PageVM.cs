﻿using CmsShop.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace CmsShop.Models.ViewModels.Pages
{
    public class PageVM
    {
        public PageVM()
        {

        }
        public PageVM(PageDTO row)
        {
            Id = row.Id;
            Title = row.Title;
            Slug = row.Slug;
            Body = row.Body;
            Sorting = row.Sorting;
            HasSideBar = row.HasSideBar;
            
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public int Sorting { get; set; }
        public bool HasSideBar { get; set; }
    }
}