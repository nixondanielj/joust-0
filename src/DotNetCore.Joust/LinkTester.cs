using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DotNetCore.Joust
{
    public class LinkTester : IJoust
    {
        public bool IsLinkValid(string url)
        {
            if (!IsValidFormat(url))
            {
                return false;
            }
            try
            {
                var response = MakeRequest(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            catch (HttpRequestException) { }
            return false;
        }

        private bool IsValidFormat(string url)
        {
            return url != null && Regex.IsMatch(url, @"^http(s?)://(.*?\.)?[a-z0-9]+\.[a-z]{2,10}$",
                RegexOptions.IgnoreCase);
        }

        private HttpResponseMessage MakeRequest(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    return client.GetAsync(url).Result;
                }
                catch (AggregateException e)
                {
                    throw e.InnerException;
                }
            }
        }
    }
}