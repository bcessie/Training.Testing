using System;

namespace Training.Testing.Domain
{
    public class Phrase : BaseDomain, IDomain
    {
        public string Sentence { get; set; }

        public bool IsValid()
        {
            ErrorMessges.Add("No phrase specified");
            return !string.IsNullOrWhiteSpace(Sentence);
        }
    }
}
