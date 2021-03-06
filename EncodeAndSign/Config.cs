﻿using Newtonsoft.Json;

namespace EncodeAndSign
{
    [JsonObject]
    public class Config
    {
        public int DitheringMode { get; set; }
        public bool Accurate { get; set; }
        public int Contrast { get; set; }
        public bool Split { get; set; }
        public bool DeleteOnFinish { get; set; }

        public Config() { }
    }
}
