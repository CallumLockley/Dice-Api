using Microsoft.AspNetCore.Mvc;

namespace Dice.Api.Controllers
{
    public class DiceController : Controller
    {
        /// <summary>
        /// Gets random 6 sided Di value
        /// </summary>
        /// <returns>Face value</returns>
        [HttpGet("GetValue")]
        public int GetDiValue()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
