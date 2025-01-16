using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{
    public enum Gender { male, female }
    public class FamilyMembers
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
        public FamilyMembers? Mother { get; set; }
        public FamilyMembers? Father { get; set; }
        public FamilyMembers? spouse { get; set; } //супруг

        public FamilyMembers[] GetGrandMotherName()
        {
            return new FamilyMembers[] { Mother?.Mother, Father?.Mother };
        }

        public FamilyMembers[] GetGrandFatherName()
        {
            return new FamilyMembers[] { Mother?.Father, Father?.Father };
        }

        public FamilyMembers[] GetCloseRelatives()
        {
            
        }
    }
}