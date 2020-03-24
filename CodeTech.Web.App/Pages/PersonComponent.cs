using CodeTech.Web.App.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodeTech.Web.App.Pages
{
    public partial class PersonComponent : ComponentBase
    {
        [Inject]
        protected HttpClient Client { get; set; }

        public IEnumerable<Person> MyProperty { get; private set; }

        public async Task GeneratePersons(int amount)
        {

        }
    }
}
