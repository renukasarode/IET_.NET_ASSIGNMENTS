namespace NotepadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Notepad Demo");
            //while (true)
            //{
                Console.WriteLine("Enter prefered language from en:English sp:spanish gr:german");
                String lang = Console.ReadLine();
                SpellCheckerFactory spellFact = new SpellCheckerFactory();
                Ichecker checker = spellFact.getSomeSpellChecker(lang);
                Notepad spellChecker = new Notepad(checker);
                spellChecker.cut();
                spellChecker.copy();
                spellChecker.SpellCheck();

                HindiSpellChecker hindiSpell = new HindiSpellChecker();
                Notepad hindiChecker = new Notepad(hindiSpell);
                hindiChecker.cut();
                hindiChecker.SpellCheck();
                hindiChecker.paste();

                KlingSpellChecker kLingSpell = new KlingSpellChecker();
                Notepad kLingChecker = new Notepad(kLingSpell);
                kLingChecker.SpellCheck();
            }
        //}
    }

    internal class KlingSpellChecker : Ichecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("SpellCheck of KlingSpellChecker Language is Done");
        }
    }

    internal class HindiSpellChecker : Ichecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("SpellCheck of Hindi Language is Done");
        }
    }

    internal class Notepad
    {
        private static Ichecker _checker;
        public Notepad(Ichecker checker)
        {
            SpellCheckerFactory spellFact = new SpellCheckerFactory();
            if (checker == null)
            {
                _checker  = spellFact.getSomeSpellChecker("en");
            }
            else 
            {
                _checker= checker;
            }
        }

        public void cut()
        {
            Console.WriteLine("the functionality of cut is done");
        }

        public void copy()
        {
            Console.WriteLine("the functionality of copy is done");
        }

        public void paste()
        {
            Console.WriteLine("the functionality of paste is done");
        }

        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
    }

    internal class SpellCheckerFactory
    {
        internal Ichecker getSomeSpellChecker(string lang)
        {
            Ichecker checker = null;
            switch (lang)
            {
                case "en":
                    checker = new EnglishSpellChecker();
                    break;
                case "gr":
                    checker = new GermanSpellChecker();
                    break;
                case "sp":
                    checker = new SpanishSpellChecker();
                    break;
                default:
                    checker = new EnglishSpellChecker();
                    break;
            }
            return checker;
        }
    }

    internal class SpanishSpellChecker : Ichecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for the spanish language");
        }
    }

    internal class GermanSpellChecker : Ichecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for the German language");
        }
    }

    internal class EnglishSpellChecker : Ichecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for the English language");
        }
    }

    internal interface Ichecker
    {
         void DoSpellCheck();
    }
}