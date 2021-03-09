using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TheWayShop.MVCUI.Extensions
{
    public static class Extensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string jsonObject = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonObject);
        }

        public static T GetObject<T>(this ISession session, string key)
            where T : class
        {
            string jsonObject = session.GetString(key);

            if (!string.IsNullOrEmpty(jsonObject))
                return JsonConvert.DeserializeObject<T>(jsonObject);

            return null;
        }
    }
}
