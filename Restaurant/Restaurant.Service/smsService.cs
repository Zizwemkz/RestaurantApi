using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Restaurant.Service
{
    public class smsService
    {

        public async Task<string> sendsmsToNumber(string phonenumber, int tableNo)
        {
            var message = ($"Table No:+{0} + Request your Attention", tableNo);
            var client = new HttpClient();
            var response = await client.GetStringAsync($"https://platform.clickatell.com/messages/http/send?apiKey=8VXM6498TPavdt4ZaX-uNA==&to={phonenumber}&content={message}");
            return response;
        }
    }
}
