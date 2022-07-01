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

            public override string ToString()
            {
                return "name: " + aspectName + " desc: " + aspectDescription;
            }
        }
        public List<aspectclass> aspectList = new();
    }