using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "";
        public string description = "";
        public Dictionary<string, skill> skills = new();

        public class aspect : IEquatable<Part>
        {
            public string aspectName { get; set;}
            public string aspectDescription { get; set;}
        }
        public List<aspect> aspectList = new() { { aspectName = "First Aspect", aspectDescription = "High Concept" },{ aspectName = "Second Aspect", aspectDescription = "Trouble/Complication" }};
    }
    
    
