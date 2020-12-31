using Github.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Github.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set;}
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        public byte Genre { get; set; } 
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime GetDateTime()
        {
            
                return DateTime.Parse(String.Format("{0} {1}", Date, Time));
            
        }
    }
}