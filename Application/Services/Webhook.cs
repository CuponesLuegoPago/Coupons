using System.Text;

namespace Coupons.Application.Services
{
    public class WebHook
    {
        public async void SendWebHook(string ErrorMessage){
             try
        {
            // URL of the external server that will receive the webhook
            string webhookUrl = "https://hooks.slack.com/services/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";

            // Webhook body (in JSON format)
            string jsonBody = "{'text' : '" + ErrorMessage + "'}";

            // Configuring the HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Configuring the content of the request in JSON format
                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                //Send the request POST to the external server
                HttpResponseMessage response = await client.PostAsync(webhookUrl, content);

                //Verify if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // The request was successful
                    Console.WriteLine("The WebHook has been successfully");
                }
                else
                {
                    // The request failed
                    Console.WriteLine("The webhook could not be sent");
                }
            }
        }
        catch (Exception ex)
        {
            // The request was an error
            Console.WriteLine("An error occured while sending the webhook");
            Console.WriteLine(ex.Message);
        }
        }
    }
}