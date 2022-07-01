using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "";
        public string description = "";
        public Dictionary<string, int> skills = new();
        public class aspectclass
        {
            public string aspectName {get; set;}
            public string aspectDescription {get; set;}
        }
        public List<aspectclass> aspectList = new() { {"First Aspect","High Concept" },{"Second Aspect","Trouble/Complication"} };
    }