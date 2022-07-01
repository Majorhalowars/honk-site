using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "";
        public string description = "";
        public Dictionary<string, int> skills = new();
        public class aspectclass(string aspectName, string aspectDescription)
        {
        }
        public List<aspectclass> aspectList = new() { {"First Aspect","High Concept" },{"Second Aspect","Trouble/Complication"} };
    }