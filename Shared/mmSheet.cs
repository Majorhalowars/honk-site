using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared
{
    public class mmSheet
    {
        public string name = "Name";
        public string powerLevel = "PL";
        public string imageUrl = "https://art.ngfiles.com/images/2110000/2110060_sabtastic_kenku-wizard-commission.png?f1633212952";
        public List<string> powers = new();
        public List<string> equipment = new();
        public List<string> advantages = new();
        public List<string> skills = new();
        public string complications = "";
        public Dictionary<string, int> stats = new() { { "Strength", 0 }, { "Agilty", 0 }, { "Fighting", 0 }, { "Awareness", 0 }, { "Stamina", 0 }, { "Dexterity", 0 }, { "Intellect", 0 }, { "Presence", 0 } };
        public Dictionary<string, int> spentPoints = new() { { "Abilities", 0 }, { "Skills", 0 }, { "Powers", 0 }, { "Defenses", 0 }, { "Advantages", 0 } };
        public Dictionary<string, int> defense = new() { { "Dodge", 0 }}
        
        }
}