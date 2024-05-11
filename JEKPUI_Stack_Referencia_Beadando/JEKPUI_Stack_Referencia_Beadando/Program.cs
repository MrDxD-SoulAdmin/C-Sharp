namespace JEKPUI_Stack_Referencia_Beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            Stack<int> num = new Stack<int>();

            Console.WriteLine("Első Metódus: PUSH");

            Stack<int> ints = s.PushMyStackFromRandom();
            Console.WriteLine("A generált Stack elemei:\n");
            foreach (int i in ints) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Második Metódus: PEEK");
            s.PeekMyStack();

            Console.WriteLine("Harmadik Metódus: POP");
            Console.WriteLine("A stackból eltávolított elem:" + s.PopMyStack());

            Console.WriteLine("Negyedik Metódus: CONTAINS");
            s.ContainsMyStack();
            num = s.FillStackint();
            Console.WriteLine("Ötödik Metódus: CLEAR");
            s.ClearMyStack(num); 

            Console.WriteLine("Hatodik Metódus: COUNT");
            num = s.FillStackint();
            Console.WriteLine("A stack jelenlegi elemszáma:" + num.Count);
            s.OverrideMyStack(ref num);
            Console.WriteLine("A stack módosítás utáni elemszáma:" + num.Count);

            Console.WriteLine("Hetedik Metódus: TRY PEEK");

            Console.WriteLine("Kérem adja meg a test Stack számát: (1:>Normál Stack,0:>Üres Stack)");
            int be = int.Parse(Console.ReadLine());
            if (be == 0) {
                s.TryPeekMyStack(num);
            }
            else if (be == 1) {
                num = s.FillStackint();
                s.TryPeekMyStack(num);
            }

        }
    }
}
