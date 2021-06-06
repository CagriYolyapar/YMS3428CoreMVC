using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCIntro.CommonTools
{
    public static class SessionExtension
    {
        //Session'umızı belirleyecek metodu yaratıyoruz

        public static void SetObject(this ISession session,string key,object value)
        {

            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session,string key) where T:class //T bir referans tip olmak zorundadır
        {
            string objectString = session.GetString(key); //Session'da duran Json formattaki string'i yakalayarak objectString degişkenine attık
            if (string.IsNullOrEmpty(objectString)) return null;

            T deserializeObject = JsonConvert.DeserializeObject<T>(objectString);
            return deserializeObject;
            
        }
      

    }
}
