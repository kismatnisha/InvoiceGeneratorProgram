namespace CabInvoiceGenerato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            //UC1
            CabInvoiceGenerator cabInvoiceGeneratorApp = new CabInvoiceGenerator();
            double fare = cabInvoiceGeneratorApp.CalculatFare(2.0, 4.0);
            Console.WriteLine("The Total Fare For The Journey : " + fare);

        }
    }
}