//Объединил задачу 10 и 13, так как вход очень похож, а вывод можно объединить.
//Напишите программу, которая принимает на вход число и на выходе показывает вторую и третью цифру этого числа, при их наличии.
Console.Clear();
Console.WriteLine("Please, enter three digit or more value");//three digit or more - трехзначное и более значение.
string input = Console.ReadLine();//input - ввод
int [] array = new int[input.Length];
for(int i = 0; i < input.Length; i++)
{
    if(int.TryParse(input[i].ToString(), out int number))
    {
        array[i] = number;
    }
    else
    {
        Console.WriteLine("Please, repeat the entering integer value");
        return;
    }
}
if(array.Length >= 3)
{
    Console.WriteLine("2-nd value = " + array[1] + "; 3-rd value = " + array[2]);
}
else
{
    Console.WriteLine("Array countains less than three values");
}