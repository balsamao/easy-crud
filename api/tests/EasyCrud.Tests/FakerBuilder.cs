using Bogus;

namespace EasyCrud.Tests
{
    public class FakerBuilder
    {
        private static string _language;

        public static FakerBuilder New()
        {
            _language = "pt_BR";

            return new FakerBuilder();
        }

        public FakerBuilder ApplyLanaguage(string linguagem)
        {
            _language = linguagem;

            return this;
        }

        public Faker Build()
        {
            return new Faker(_language);
        }
    }
}
