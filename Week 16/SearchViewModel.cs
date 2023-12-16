using System.ComponentModel.DataAnnotations;

namespace NaomiRetroCloset.Models
{
    public class SearchViewModel
    {
        public IEnumerable<ProductData> ProductData { get; set; }
        [Required(ErrorMessage ="Please enter a search term.")]
        public string SearchTerm { get; set; }
        public String Type { get; set; }

    }
}
