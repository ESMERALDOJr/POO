namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine();
            Console.WriteLine($"Diretor");
            Console.WriteLine();
        }
    }
}