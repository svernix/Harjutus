
Console.WriteLine("tere, mis on teie vanus?");
int vanus = 0;
vanus = int.Parse(Console.ReadLine());
do
{
    Console.WriteLine("mis on teie vanus?");
    vanus++;
    vanus = int.Parse(Console.ReadLine());
} while (vanus < 0);
if (vanus > 0)
{
    
    Console.WriteLine("vanus sobib!");
}

//Console.WriteLine("mis on aastaarv?");
//int aastaarv = 0;
//aastaarv = int.Parse(Console.ReadLine());
//while (aastaarv <1 )
//{

//    Console.WriteLine("paroool peab olema vahemikus 1 kuni 2025");
//    aastaarv++;
//    aastaarv = int.Parse(Console.ReadLine());
//}
//if ( aastaarv < 2025)
//{
//    Console.WriteLine("sobib!");
//}
