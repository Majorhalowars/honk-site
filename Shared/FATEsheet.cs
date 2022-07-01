using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "";
        public string description = "";
        public Dictionary<string, int> skills = new();
        
        public List<aspectclass> aspectList = new();
        
    }
    public class aspectclass
        {
            public string aspectName {get; set;}
            public string aspectDescription {get; set;}
        }