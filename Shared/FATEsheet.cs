using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "Name";
        public string description = "Write yourself a bio!";
        public Dictionary<string, int> skills = new();
        
        public List<aspectclass> aspectList = new();
    }
    public class aspectclass
    {
         public string aspectName {get; set;}
         public string aspectDescription {get; set;}
         public aspectclass(string aspectName, string aspectDescription)
        {
          this.aspectName = aspectName;
          this.aspectDescription = aspectDescription;
        }
    }
    