using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "Name";
        public string description = "Write yourself a bio!";
        public string characterImage = "https://cdn.discordapp.com/attachments/872160747306754058/992280957795188797/unknown.png";

        public List<skillclass> skillList = new();
        public List<aspectclass> aspectList = new();
        public List<stuntclass> stuntList = new();
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
    public class stuntclass
    {
         public string stuntName {get; set;}
         public string stuntDescription {get; set;}
         public stuntclass(string stuntName, string stuntDescription)
        {
          this.stuntName = stuntName;
          this.stuntDescription = stuntDescription;
        }
    }