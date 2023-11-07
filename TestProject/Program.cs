int[] numbers = {4, 8, 15, 16, 23, 42 };
int total = 0;  // Initialize 'total' to zero outside the loop
bool found = false;  // Initialize 'found' to false outside the loop

foreach (int number in numbers)
{
   
    total += number;

    if (number == 42)
    {
         found = true;
    }
}

if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");