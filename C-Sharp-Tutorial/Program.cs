public class MyFirstApp
{
    public static void Main()
    {
        float vat = 19;
        float productA = 3.99f;
        float productB = 11.99f;
        float productC = 5.75f;

        float summed = productA + productB + productC;
        float totalTax = (summed / 100) * vat;

        summed += totalTax;

        Console.WriteLine(summed);
    }
}