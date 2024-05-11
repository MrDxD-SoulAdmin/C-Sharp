namespace JEKPUI_Stack_Referencia_Beadando
{
    internal class MyStack
    {

        public Stack<int> PushMyStackFromRandom()
        {
            Random R = new Random();
            Stack<int> numbers = new Stack<int>();
            int size = 0, a = 0, f = 0;
            Console.WriteLine("Kérem adja meg a méretet, alsó és felső generálási határt (méret,alsóhatár,felsőhatár)!\n");
            string tmp = Console.ReadLine();
            List<string> s = new List<string>();
            s.AddRange(tmp.Split(","));

            size = int.Parse(s[0]);
            a = int.Parse(s[1]);
            f = int.Parse(s[2]);

            int count = 0;
            while (count <= size) {
                numbers.Push(R.Next(a, f));
                count++;
            }
            return numbers;

        }

        public void PeekMyStack()
        {
            Stack<string> strings = new Stack<string>();
            Console.WriteLine("Kérem adjon meg adatorak ','-vel elválasztva!\n");
            string tmp = Console.ReadLine();
            foreach (string s in tmp.Split(",")) {
                strings.Push(s);
            }
            Console.WriteLine("A megadott elemek Satckje:\n");
            foreach (string s in strings) {
                Console.WriteLine(s);
            }
            Console.WriteLine("A megadott input legutolsó eleme:" + strings.Peek());
        }

        public int PopMyStack()
        {
            Random R = new Random();
            Stack<int> numbers = new Stack<int>();
            int size = 0, a = 0, f = 0;
            Console.WriteLine("Kérem adja meg a méretet, alsó és felső generálási határt (méret,alsóhatár,felsőhatár)!\n");
            string tmp = Console.ReadLine();
            List<string> s = new List<string>();
            s.AddRange(tmp.Split(","));

            size = int.Parse(s[0]);
            a = int.Parse(s[1]);
            f = int.Parse(s[2]);

            int count = 0;
            while (count <= size) {
                numbers.Push(R.Next(a, f));
                count++;
            }
            Console.WriteLine("A generált Stack elemei:\n");
            foreach (int i in numbers) {
                Console.WriteLine(i);
            }
            int ext = numbers.Pop();
            Console.WriteLine(" A Stack új elemei:\n");
            foreach (int i in numbers) {
                Console.WriteLine(i);
            }
            return ext;

        }

        public void ContainsMyStack()
        {
            Stack<string> strings = new Stack<string>();

            Console.WriteLine("Kérem adja meg a stack elemeinek számát!\n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem adjon meg " + size + " elemet!");
            while (size != 0) {
                strings.Push(Console.ReadLine());
                size--;
            }

            Console.WriteLine("A elemek Satckje:\n");
            foreach (string s in strings) {
                Console.WriteLine(s);
            }
            Console.WriteLine("Kérem adja meg a keresett értéket:");
            string keresett = Console.ReadLine();
            bool cont = strings.Contains(keresett);
            if (cont == true) {
                Console.WriteLine("A stack tartalmazza a :" + keresett + " elemet!");
            }
            else {
                Console.WriteLine("A stack nem tartalmazza a :" + keresett + " elemet!");
            }
        }

        public void OverrideMyStack(ref Stack<int> nums)
        {
            nums = new Stack<int>();
            nums.Push(500);
        }

        public void ClearMyStack(Stack<int> a)
        {
            Console.Write("A Stack elemei:");
            foreach (var item in a) {
                Console.Write(item + ",");
            }
            Console.WriteLine("\nTörlés!");
            a.Clear();
            Console.WriteLine("A Stack Sikeresen kiürítve! Új elemszám:" + a.Count);
        }

        public void TryPeekMyStack(Stack<int> ints)
        {
            if (ints.TryPeek(out int elem) == true) {
                Console.WriteLine("A stack Elemi:\n");
                foreach (var item in ints) {
                    Console.Write(item + " ");
                }
                Console.WriteLine("Sikeres Peek! A Peekelt elem:" + elem);
            }
            else {
                Console.WriteLine("\nA Peek Sikertelen mert a Stack üres!");
            }
        }

        public Stack<int> FillStackint()
        {
            Stack<int> intstack = new Stack<int>();
            intstack.Push(0);
            intstack.Push(1);
            intstack.Push(2);
            intstack.Push(3);
            intstack.Push(4);
            intstack.Push(5);

            return intstack;
        }
    }
}