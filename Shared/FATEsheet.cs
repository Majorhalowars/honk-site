using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace honksite.Shared;

    public class FATEsheet
    {
        public string name = "";
        public string description = "";
        public Dictionary<string, int> skills = new();

        public class aspect : IEquatable<aspect>
        {
            public string aspectName { get; set;}
            public string aspectDescription { get; set;}

            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                aspect objAsAspect = obj as aspect;
                if (objAsAspect == null) return false;
                else return Equals(objAsAspect);
            }
            public override int GetHashCode()
            {
                return aspectName;
            }
            public bool Equals(aspect other)
            {
                if (other == null) return false;
                return (this.aspectName.Equals(other.aspectName));
            }
        }
        public List<aspect> aspectList = new() { { aspectName = "First Aspect", aspectDescription = "High Concept" },{ aspectName = "Second Aspect", aspectDescription = "Trouble/Complication" }};
    }
    
    
