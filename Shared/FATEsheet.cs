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

        public FATEsheet()
        {
            this.aspectList.Add(new aspectclass("High Concept Name","Describe it with a few words") );
        }

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
    