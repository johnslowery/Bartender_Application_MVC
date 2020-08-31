using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender_App.Models
{
    public static class Repository
    {
        private static List<UserTypeModel> responses = new List<UserTypeModel>();
        public static IEnumerable<UserTypeModel> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(UserTypeModel response)
        {
            responses.Add(response);
        }
    }
}
