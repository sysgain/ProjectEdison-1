﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Edison.Mobile.Common.WiFi
{
    public interface IWifiService
    {
        Task<IEnumerable<WifiNetwork>> GetWifiNetworks();
        Task<bool> ConnectToSecuredNetwork(string ssid, string passphrase);
    }
}
