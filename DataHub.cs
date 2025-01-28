using Microsoft.AspNetCore.SignalR;

namespace ServerSignalR
{
    public class DataHub : Hub
    {
        public async Task SendData(string data)
        {
            //await Clients.All.SendAsync("ReceiveData", data);
            await Clients.Others.SendAsync("ReceiveData", data);
        }
    }

}
