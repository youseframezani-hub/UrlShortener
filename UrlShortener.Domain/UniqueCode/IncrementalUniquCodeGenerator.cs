using System.Linq;

namespace UrlShortener.Domain.UniqueCode
{
    public class IncrementalUniquCodeGenerator : UniquCodeGenerator
    {
        private static string Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789";
        private static int Base => Alphabet.Length;

        private readonly INcrementalNumberSource _uniquNumberRepository;

        public IncrementalUniquCodeGenerator(INcrementalNumberSource uniquNumberRepository)
        {
            _uniquNumberRepository = uniquNumberRepository;
        }

        public string GetUniqueCode()
        {
            var uniquNumber = _uniquNumberRepository.GetTheLatestNewNumber();
            string uniqueCode = this.Encode(uniquNumber);
            return uniqueCode;
        }


        private string Encode(long i)
        {
            if (i == 0) return Alphabet[0].ToString();

            var s = string.Empty;

            while (i > 0)
            {
                s += Alphabet[(int)(i % Base)];
                i = i / Base;
            }

            return string.Join(string.Empty, s.Reverse());
        }

        private int Decode(string s)
        {
            var i = 0;

            foreach (var c in s)
            {
                i = (i * Base) + Alphabet.IndexOf(c);
            }

            return i;
        }
    }
}
