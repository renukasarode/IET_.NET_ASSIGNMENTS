namespace ReportDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the choice 1:PDF 2:MSWORD 3:xcel 4:XML 5:JSON");
                int choice = Convert.ToInt32(Console.ReadLine());
                ReportFactory factory = new ReportFactory();
                Report report = factory.getSomeReport(choice);
                switch (choice)
                {
                    case 1:
                        report.GenerateReport();
                        break;
                    case 2:
                        report.GenerateReport();
                        break;
                    case 3:
                        report.GenerateReport();
                        break;
                    case 4:
                        report.GenerateReport();
                        break;
                    case 5:
                        report.GenerateReport();
                        break;

                    default:
                        Console.WriteLine("You have Entered Wrong Choice");
                        break;
                }
                Console.WriteLine("you want to continue y/n?");
                String ans = Console.ReadLine();
                if(ans=="n")
                {
                    break;
                }

            }

        }
    }

    internal class ReportFactory
    {
        internal Report getSomeReport(int choice)
        {
            Report report = null;
            switch (choice)
            {
                case 1:
                    report = new Pdf();
                    break;

                case 2:
                    report = new MsWord();
                    break;

                case 3:
                    report = new Excel();
                    break;

                case 4:
                    report = new XmL();
                    break;

                case 5:
                    report = new JSON();
                    break;

                default:
                    Console.WriteLine("You have Entered the Wrong choice");
                    break;
            }
            return report;
        }
    }

    internal abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();

        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();

            Console.WriteLine("Report generated successfully...");
        }


    }

    internal abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();

        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();   
            Save();

            Console.WriteLine("Report generated successfully...");
        }



    }

    internal class JSON : SpecialReport
    {
        public JSON()
        {
        }

        protected override void Parse()
        {
            Console.WriteLine("JSON is Parsed...");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("JSON is Re-Validated...");
        }

        protected override void Save()
        {
            Console.WriteLine("JSON is Saved...");
        }

        protected override void Validate()
        {
            Console.WriteLine("JSON is Validated...");
        }
    }

    internal class XmL : SpecialReport
    {
        public XmL()
        {
        }

        protected override void Parse()
        {
            Console.WriteLine("XmL is Parsed...");
        }

        protected override void ReValidate()
        {
            Console.WriteLine("XmL is Re-Validated...");
        }

        protected override void Save()
        {
            Console.WriteLine("XmL is Saved...");
        }

        protected override void Validate()
        {
            Console.WriteLine("XmL is Validated...");
        }
    }

    internal class Excel : Report
    {
        public Excel()
        {
        }

        protected override void Parse()
        {
            Console.WriteLine("Excel is Parsed...");
        }

        protected override void Save()
        {
            Console.WriteLine("Excel is Saved...");
        }

        protected override void Validate()
        {
            Console.WriteLine("Excel is Validated...");
        }
    }

    internal class MsWord : Report
    {
        public MsWord()
        {
        }

        protected override void Parse()
        {
            Console.WriteLine("MsWord is Parsed...");
        }

        protected override void Save()
        {
            Console.WriteLine("MsWord is Saved...");
        }

        protected override void Validate()
        {
            Console.WriteLine("MsWord is Validated...");
        }
    }

    internal class Pdf : Report
    {
        public Pdf()
        {
        }

        protected override void Parse()
        {
            Console.WriteLine("Pdf is Parsed...");
        }

        protected override void Save()
        {
            Console.WriteLine("Pdf is Saved...");
        }

        protected override void Validate()
        {
            Console.WriteLine("Pdf is Validated...");
        }
    }
}
