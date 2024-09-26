
using NationalStatus.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalStatus
{
    public class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TC { get; set; }
        public int Birthday { get; set; }

        KPSPublicSoapClient client = new KPSPublicSoapClient();
        public async Task<bool> TCKimlikDoğrula()
        {
            try
            {
                var response = await client.TCKimlikNoDogrulaAsync(this.TC, this.Name, this.Surname, this.Birthday);
                return response.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
