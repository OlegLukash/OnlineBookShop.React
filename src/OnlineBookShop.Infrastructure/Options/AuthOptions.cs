using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace OnlineBookShop.Infrastructure.Options
{
    public class AuthOptions
    {
        public string Audience { get; set; }
        public string Authority { get; set; }
    }
}
