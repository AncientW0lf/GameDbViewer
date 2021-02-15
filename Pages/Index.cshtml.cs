using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GameDbViewer.Pages
{
    public class IndexModel : PageModel
    {
        public int Pg { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int pg)
        {
            Pg = pg;
        }
    }
}
