using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebStyleDemo.Models;

namespace WebStyleDemo.Services {
    /// <summary>
    /// Manages HTTP requests (Our handmade C# HTTP client like 'axios' in web development)
    /// </summary>
    public class HttpService : IService {
        // Singleton
        private static HttpService instance;
        public static HttpService Instance {
            get {
                if (instance == null) {
                    instance = new HttpService ();
                }

                return instance;
            }
        }

        private HttpClient client;
        private CookieContainer cookieContainer;
        private HttpClientHandler clientHandler;

        private HttpService () { }

        /// <summary>
        /// Creates the C# HTTP client
        /// </summary>
        public void Initialize () {
            cookieContainer = new CookieContainer ();
            clientHandler = new HttpClientHandler { AllowAutoRedirect = true, UseCookies = true, CookieContainer = cookieContainer };
            client = new HttpClient (clientHandler);
        }

        /// <summary>
        /// Cleans variables
        /// </summary>
        public void Dispose () {
            cookieContainer = null;
            clientHandler = null;
            client = null;
        }

        /// <summary>
        /// Makes a HTTP Get request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        async public Task<T> Get<T> (string url, string accessToken) {
            HttpResponseMessage response;
            string responseString;
            T data;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Bearer", accessToken);

            response = await client.GetAsync (url);
            response.EnsureSuccessStatusCode ();
            responseString = await response.Content.ReadAsStringAsync ();

            data = JsonService.Instance.Deserialize<T> (responseString);

            return data;
        }

        /// <summary>
        /// Makes a HTTP POST request
        /// </summary>
        /// <typeparam name="PayloadType"></typeparam>
        /// <param name="url"></param>
        /// <param name="payload">Serializable payload</param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        async public Task Post<PayloadType> (string url, PayloadType payload, string accessToken) {
            string serializedPayload = JsonService.Instance.Serialize (payload);
            StringContent body = new StringContent (serializedPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Bearer", accessToken);

            response = await client.PostAsync (url, body);
            response.EnsureSuccessStatusCode ();
        }

        /// <summary>
        /// Makes a HTTP POST request
        /// </summary>
        /// <typeparam name="PayloadType"></typeparam>
        /// <typeparam name="ResponseType"></typeparam>
        /// <param name="url"></param>
        /// <param name="payload">Serializable payload</param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        async public Task<ResponseType> Post<PayloadType, ResponseType> (string url, PayloadType payload, string accessToken) {
            string serializedPayload = JsonService.Instance.Serialize (payload);
            StringContent body = new StringContent (serializedPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response;
            string responseString;
            ResponseType data;

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Bearer", accessToken);

            response = await client.PostAsync (url, body);
            response.EnsureSuccessStatusCode ();
            responseString = await response.Content.ReadAsStringAsync ();

            data = JsonService.Instance.Deserialize<ResponseType> (responseString);

            return data;
        }
    }
}