using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace mgr_1_2_TI.Structure
{
    public static class SessionHelper
    {
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            var out_var = JsonSerializer.Deserialize<T>(value);

#pragma warning disable CS8603 // Possible null reference return.
            return out_var == null ? default(T) : out_var;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public static void ObjectToJson<T>(this ISession session, string key, T value)
        {
            var serialised = JsonSerializer.Serialize<T>(value);
            session.SetString(key, serialised);
        }
    }
}