using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameDbViewer.Pages
{
    public class DetailsModel : PageModel
    {
        public Game Game { get; set; }

        public void OnGet(string id)
        {
            Game = Program.GameDb.Games.FirstOrDefault(game => game.Id.Equals(id));
        }
    }
}
