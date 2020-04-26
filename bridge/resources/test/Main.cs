using System;
using GTANetworkAPI;

namespace test
{
    public class Main : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void ResourceStart()
        {
            NAPI.Util.ConsoleOutput("Hello World2 (mines)!");
        }
       
        
    }
}