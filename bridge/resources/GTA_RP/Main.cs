using System;
using GTANetworkAPI;

namespace GTA_RP{
    public class Main : Script{
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart(){
            NAPI.Util.ConsoleOutput("Hello from visual studio");
        }
    }
}
