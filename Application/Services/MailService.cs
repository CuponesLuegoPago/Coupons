using System.Text;
using System.Text.Json;
using Coupons.Models;

namespace Coupons.Application.Services
{
    public class MailService
    {
        public async void MailerSend(){
           
            //Url of the api
            string url = "https://api.mailersend.com/v1/email";

            //credentials of the api
            string Token = "mlsn.c2562e842d265e41064902366cca44e94edb210541c7bc906e9a6c24cf12db10";

            //Creation to object Email
            var email = new Email
            {
                from = new From
                {
                    email = "info@trial-zr6ke4njee9gon12.mlsender.net"
                },
                to = new To[]{
                    new To{
                        email = ""
                        }
                },
                subject = "",
                text = "",
                html = ""
            };

            //Serialization of the object to json
            string jsonBody = JsonSerializer.Serialize(email);

            //Creation of the request with a http
            using (HttpClient client = new HttpClient())
            {

                //configuration to Headers
                client.DefaultRequestHeaders.Add("ContentType", "application/json");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);

                //Creation of the request
                StringContent Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                //Send the request
                HttpResponseMessage response = await client.PostAsync(url, Content);

                //Validation of the request
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Email Send");
                }
                else
                {
                    Console.WriteLine("Error to send email");
                }
            }
        }
    }
}