﻿using System.Net;

namespace RestClient
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    internal class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient() 
        { 
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " +  response.StatusCode);
                }
                
                //Process the response stream...(cloud be JSON, XML or HTML)

                using(Stream  responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using( StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }

                //End of using ResponseStream
            }

            //End of using response

            return strResponseValue;
        }
    }
}
