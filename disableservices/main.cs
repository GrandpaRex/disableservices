using System.Threading.Tasks;
using static CitizenFX.Core.Native.API;
using FivePD.API;
using static FivePD.API.Utilities;

namespace disableservices
{
    #pragma warning disable CS1998
    public class main : Plugin
    {
        internal main()
        {
            Events.OnServiceCalled += OnServiceCalled;
        }

        public async Task OnServiceCalled(Services service)
        {
            if (service is Services.Ambulance)
            {
                await Delay(500);
                CancelService(Services.Ambulance);
                DisplayNotification("~r~Ambulance canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.AirAmbulance)
            {
                await Delay(500);
                CancelService(Services.AirAmbulance);
                DisplayNotification("~r~Air Ambulance canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.FireDept)
            {
                await Delay(500);
                CancelService(Services.FireDept);
                DisplayNotification("~r~Fire Department canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.Coroner)
            {
                await Delay(500);
                CancelService(Services.Coroner);
                DisplayNotification("~r~Coroner canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.AnimalControl)
            {
                await Delay(500);
                CancelService(Services.AnimalControl);
                DisplayNotification("~r~Animal Control canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.TowTruck)
            {
                await Delay(500);
                CancelService(Services.TowTruck);
                DisplayNotification("~r~Tow truck canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.Mechanic)
            {
                await Delay(500);
                CancelService(Services.Mechanic);
                DisplayNotification("~r~Mechanic canceled! ~w~Services are disabled on this server");
            }
            else if (service is Services.PrisonTransport)
            {
                await Delay(500);
                CancelService(Services.PrisonTransport);
                DisplayNotification("~r~Prison Transport canceled! ~w~Services are disabled on this server");
            }
        }

        internal static void DisplayNotification(string text)
        {
            BeginTextCommandThefeedPost("STRING");
            AddTextComponentString(text);
            EndTextCommandThefeedPostTicker(true, true);
        }
    }
}
