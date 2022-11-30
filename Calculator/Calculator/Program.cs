namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            string input = "2*43+500-6";
            Console.WriteLine("Received input: {0}", input);
            
            
            string result = controller.Input(input);
            Console.WriteLine("Result: {0}",result);
        }
    }
}