namespace MathGameLibrary
{
    internal class Helper
    {   
       
        internal static int GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 9);

        }
    }
}