using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatronusNext
{
    class ConnectToServer
    {
        public static bool TryToRegist()
        {
            return true;
        }

        public static async Task<bool> TryToSignInAsync(string name,string password)
        {
            var response = await LoginAsync(name, password);

            if (response.IsError)
                return false;

            await ResourceDataClient.SetBearer(response.AccessToken);

            return true;
        }

        private async Task DownloadFilesAsync()
        {
            if (Program.ImageExists())
                await ResourceDataClient.DownloadFile("Image.png");
            if (Log.LogExists())
                await ResourceDataClient.DownloadFile("Sesion.log");
            if (SerialData.DataExists())
                await ResourceDataClient.DownloadFile("Data.ev");
        }


        private static TokenClient _tokenClient;

        public static async Task<TokenResponse> LoginAsync(string user, string password)
        {
            //Console.Title = "Console ResourceOwner Flow RefreshToken";

            var disco = await DiscoveryClient.GetAsync("http://localhost:5000");
            //if (disco.IsError) throw new Exception(disco.Error);

            _tokenClient = new TokenClient(
                disco.TokenEndpoint,
                "StachronusNextClient",
                "StachronusNextClient");

            return await RequestTokenAsync(user, password);
        }

        public static async Task RunRefreshAsync(TokenResponse response, int milliseconds)
        {
            var refresh_token = response.RefreshToken;

            while (true)
            {
                response = await RefreshTokenAsync(refresh_token);

                // Get the resource data using the new tokens...
                //await ResourceDataClient.GetDataAndDisplayInConsoleAsync(response.AccessToken);

                if (response.RefreshToken != refresh_token)
                {
                    refresh_token = response.RefreshToken;
                }

                Task.Delay(milliseconds).Wait();
            }
        }
        private static async Task<TokenResponse> RequestTokenAsync(string user, string password)
        {
            return await _tokenClient.RequestResourceOwnerPasswordAsync(
                user,
                password,
                "email openid SatronusNextResource offline_access");
        }

        private static async Task<TokenResponse> RefreshTokenAsync(string refreshToken)
        {
            return await _tokenClient.RequestRefreshTokenAsync(refreshToken);
        }

}
}
