using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visma_QA_task
{
    internal class Band
    {
        private List<string> adjectives = new List<string> { "Stunning", "Delightful", "Wild", "Useless", "Great", "Drunken", "Crazy", "Quiet", "Bright", "Scrumptious" };
        private List<string> nouns = new List<string> { "Compass", "Banana", "Geck", "Sausage", "Fairy", "Melons", "Buffalo", "Programmers", "Mustangs", "Joysticks" };
        private List<BandMember> members = new List<BandMember>();
        private string bandName;
        private int bandMemberCounter = 0;
        private List<string> NameList()
        {
            return new List<string>
            {
                "Bodrum Salvador",
                "Hilary Ouse",
                "Indigo Violet",
                "Hans Down",
                "Shequondolisa Bivouac",
                "Ingredia Nutrisha",
                "Fig Nelson",
                "Benjamin Elalent",
                "Gustav Purpleson",
                "Elon Gated"
            };
        }

        public void DisplayBandInfo()
        {
            Console.WriteLine("Band Name: " + bandName);
            Console.WriteLine("Band Members:");
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine(members[i].Name + " - " + members[i].Role);
            }
        }

        public void GenerateBandName()
        {
            string randomAdjective = GetRandomItem(adjectives);
            string randomNoun = GetRandomItem(nouns);
            bandName = randomAdjective + " " + randomNoun;
            Console.WriteLine("Generated band name: " + bandName);
        }

        public void CreateCustomBandName(string adjective, string noun)
        {
            bandName = adjective + " " + noun;
            Console.WriteLine("Custom band name created: " + bandName);
        }

        public void AddBandMember()
        {
            string[] roles = { "Vocalist", "Bass Guitarist", "Drummer", "Electric Guitarist" };
            List<string> missingRoles = new List<string>();

            foreach (string role in roles) //this loop is used to keep the band composition
            {
                bool roleMissing = true;
                foreach (var member in members)
                {
                    if (member.Role == role)
                    {
                        roleMissing = false;
                        break;
                    }
                }

                if (roleMissing)
                {
                    missingRoles.Add(role);
                }
            }

            if (missingRoles.Count > 0)
            {
                string name = GetRandomItem(NameList());
                string role = missingRoles[0];
                members.Add(new BandMember(name, role));
                Console.WriteLine(name + " has joined as " + role);
            }
            else
            {
                Console.WriteLine("Band is already full! Cannot add more members.");
            }
        }
        public void RemoveBandMember()
        {
            if (members.Count > 0)
            {
                Console.WriteLine("Current Band Members:");
                for (int i = 0; i < members.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + members[i].Name + " - " + members[i].Role);
                }
                Console.Write("Enter the number of the band member to remove: ");
                if (int.TryParse(Console.ReadLine(), out int memberIndex) && memberIndex >= 1 && memberIndex <= members.Count)
                {
                    BandMember removedMember = members[memberIndex - 1];
                    members.RemoveAt(memberIndex - 1);
                    Console.WriteLine(removedMember.Name + " has been removed from the band.");
                    bandMemberCounter--;
                }
                else
                {
                    Console.WriteLine("Invalid band member selection!");
                }
            }
            else
            {
                Console.WriteLine("The band has no members to remove!");
            }
        }

        public void AddNewAdjective(string newAdjective)
        {
            adjectives.Add(newAdjective);
            Console.WriteLine("New adjective added: " + newAdjective);
        }

        public void AddNewNoun(string newNoun)
        {
            nouns.Add(newNoun);
            Console.WriteLine("New noun added: " + newNoun);
        }

        public void Regenerate()
        {
            GenerateBandName();
            members.Clear();
            bandMemberCounter = 0;
            Console.WriteLine("The band has been regenerated.");
        }

        public int GetAdjectivesCount()
        {
            return adjectives.Count;
        }

        public int GetNounsCount()
        {
            return nouns.Count;
        }

        private string GetRandomItem(List<string> items)
        {
            Random rand = new Random();
            int index = rand.Next(items.Count);
            return items[index];
        }

        public string GetAdjectiveByIndex(int index)
        {
            if (index >= 0 && index < adjectives.Count)
            {
                return adjectives[index];
            }
            return null;
        }

        public string GetNounByIndex(int index)
        {
            if (index >= 0 && index < nouns.Count)
            {
                return nouns[index];
            }
            return null;
        }
    }
}
