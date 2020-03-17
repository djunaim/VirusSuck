using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------------------------------------
            // Lists 
            //----------------------------------------------------------------------------------------------------------------------------
            // in arrays, can put anything in it for javascript. in C# lists can't do that, need to specify what goes in there
            // angle brackets specify what thing list contains
            // Lists are good for when you have all the same kind of thing and want to loop over things. General purpose stuff
            var names = new List<string>();

            // Add method appends new thing at the end of the list
            // Here the Add method takes a string item since that is what is specified in the angle bracket
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");

            // Insert method adds item at the specified index
            names.Insert(0, "Shebola");

            // removes stupidity from list
            // Remove method removes actual item
            names.Remove("Stupidity");
            // RemoveAt will rempve item at that specific index
            names.RemoveAt(3);

            // add multiple items
            // adding curly brackets at the end is collection initializer
            var people = new List<string> { "Nathan", "Martin", "Jameka"};
            // AddRange method can add a whole collection to a different collection
            names.AddRange(people);

            // remove multiple things
            // RemoveRange method removes multiple things - 1st parameter is starting index and 2nd parameter is how many we want to remove
            // Count is 1 base and index is 0 base so need to subtract 1 more thing
            names.RemoveRange(names.Count - 3, 3);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}.");
            }

            //----------------------------------------------------------------------------------------------------------------------------
            // Dictionaries 
            //----------------------------------------------------------------------------------------------------------------------------

            // want to store both name and symptoms of virus
            // Dictionaries require 2 arguments: key and value. The key is custom to me and value is whatever I define it.
            // Dictionaries are keyed by whatever you have defined it as
            // Dictionaries are good if you want to read things over and over again
            // Cannot add 2 dictionary entries with the same key. Will error out if have 2 same keys
            // Not good at ading stuff, but good at reading and finding things
            var symptoms = new Dictionary<string, string>();
            symptoms.Add("COVID-19", "Dry cough, fever, respoiratory problems, cancels everything");
            symptoms.Add("Ebola", "Fever, headache, muscle pain, and chills");
            symptoms.Add("Spanish Flu", "fever, a dry cough, fatigue, and difficulty breathing");
            symptoms.Add("SARS", "fever, dry cough, headache, muschle aches, and difficulty breathing");
            symptoms.Add("Rabies", "fever, headaches, excess salivation, muscle spasms, paralyzsis, and mental confusion");

            // get value of single thing based on key
            var covidSymptoms = symptoms["COVID-19"];

            // remove entire single item based on key
            symptoms.Remove("Ebola");

            // collection initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            // looping over key, value pair
            // destructuring - turning into smaller things
            // turning it into the smaller things of what the dictionary is
            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} has the following symptoms: {symptom}");
            }

            // loop over virus names and look for the name in the symptoms dictionary
            // will cause error if name doesn't exist in disctionary and don't have conditions to catch it
            foreach (var name in names)
            {
                // ContainsKey method sees if there is a key that exists in the dictionary and will return boolean value
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");

                }
                else
                {
                    Console.WriteLine($"The {name}  virus is unknown...");
                }
            }

            //----------------------------------------------------------------------------------------------------------------------------
            // Queues/Stacks
            //----------------------------------------------------------------------------------------------------------------------------

            // get collections of things and get things out 1 at a time and not have it in the collection anymore
            // 1st in, 1st out = how you put it in, is also the same order how you can remove it
            // if it was Stack collection, it would be last in, first out
            var diseasesToCure = new Queue<string>();

            // adding to end of queue
            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            // remove 
            // doesn't take in any arguments due to FIFO rule
            diseasesToCure.Dequeue();

            //----------------------------------------------------------------------------------------------------------------------------
            // Hashset
            //----------------------------------------------------------------------------------------------------------------------------

            // can only have value in there once
            // adding to hashsets slow, but returning values is fast
            // good for heave read operations
            var vectors = new HashSet<string>();

            // Add method takes string and hashes it, which turns it into series of bytes and use it as key for thing and string as value
            // if it sees duplicate, will see the same bytes and knows to ignore it
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");

            //----------------------------------------------------------------------------------------------------------------------------
            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry cough");
            covid19.Symptoms.Add("Cancels everything except work");
            covid19.NumOfDeathsWorldWide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry cough");
            spanishFlu.NumOfDeathsWorldWide = 50000000;

            var rabies = new Virus("Rabies", 11);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("Excess salivation");
            rabies.NumOfDeathsWorldWide = 200000;

            // creating a list of our kind of Virus class
            // added the viruses we created
            var viruses = new List<Virus> { covid19, spanishFlu, rabies };
            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumOfDeathsWorldWide} world wide.");

                // comma separated list of virus symtptoms
                Console.WriteLine($"{virus.Name} has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }

        }
    }
}
