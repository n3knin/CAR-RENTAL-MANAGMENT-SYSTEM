using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Models.Core
{
    public class Session
    {

        public static int CurrentUserId { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentUserRole { get; set; }
    }
}
