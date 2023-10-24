using System.ComponentModel.DataAnnotations;

namespace TextMatch.Models
{
    public class TextMatchViewModel
    {
        
        public string? Text { get; set; }

        [Display(Name = "Match Against")]
        public string? Subtext { get; set; }
    }
}