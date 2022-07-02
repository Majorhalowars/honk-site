using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "Name";
        public string description = "Write yourself a bio!";

        public List<skillclass> skillList = new();
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
    public class skillclass
    {
         public string skillName {get; set;}
         public int skillLevel {get; set;}
         public skillclass(string skillName, int skillLevel)
        {
          this.skillName = skillName;
          this.skillLevel = skillLevel;
        }
    }