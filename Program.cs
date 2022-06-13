namespace abstract_siniflar{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe());

            Console.WriteLine("**********");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());

            Console.WriteLine("**********");
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe());
        }
    }
}