using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Har du gått ut gymnasiet? (Svara j för ja eller n för nej):");
        string svar = Console.ReadLine();

        if (svar.ToLower() == "j")
        {
            Console.WriteLine("Hur gammal är du?");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 22)
                {
                    Console.WriteLine("Vi vill gärna anställa dig.");
                }
                else
                {
                    Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig ålder. Var god ange en giltig ålder.");
            }
        }
        else
        {
            Console.WriteLine("Tack för ditt svar. Vi letar tyvärr efter annan personal just nu.");
        }
        Console.ReadKey();
    }
}
