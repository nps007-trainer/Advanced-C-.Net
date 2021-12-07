using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections;

namespace Caching
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ObjectCache cache = MemoryCache.Default;
            //add cache 
            cache.Add("CacheName", "Value1", null);
            cache.Add("CacheName2", 0, null);
            
            // create cache item policy 
            var cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(60.0),
            };
            //add cache with cache item policy 
            cache.Add("CacheName3", "Expires In A Minute", cacheItemPolicy);
            //add cache with CacheItem object 
            var cacheItem = new CacheItem("fullName", "Nandini Shamdasani");
            cache.Add(cacheItem, cacheItemPolicy);
           
            //get cache value and print 
            Console.WriteLine("Full Name " + cache.Get("fullName"));
           
            //print all cache 
            Console.WriteLine("All key-values");
            PrintAllCache(cache);
           
            //remove cache 
            cache.Remove("CacheName");
            //update cache value, from 0 to 1 (it works best with data that changes)
            cache.Set("CacheName2", 1, null);
           
            //print all cache key value again to check updates 
            Console.WriteLine("All key-values after updates");
            PrintAllCache(cache);
            Console.ReadLine();
        }
        public static void PrintAllCache(ObjectCache cache)
        {
            //loop through all key-value pairs and print them
            foreach (var item in cache)
            {
                Console.WriteLine("cache object key-value: " + item.Key + "-" + item.Value);
            }

        }
        
    }
}
