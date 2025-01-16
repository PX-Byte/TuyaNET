﻿using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaTokenResult : ITuyaTokenResult {
    public string access_token { get; set; }
    public int expire_time { get; set; }
    public string refresh_token { get; set; }
    public string uid { get; set; }
}