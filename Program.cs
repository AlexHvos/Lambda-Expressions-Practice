int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 };
int[] evenArray = GetFiltered(array, number => {
    if (number % 2 == 0) {
           return true;
       }
       return false;
});
int[] notEvenArray = GetFiltered(array, number => {
    if (number % 2 != 0) {
           return true;
       }
       return false;
});
int[] has3Array = GetFiltered(array, number => {
    if ((Convert.ToString(number)).Contains('3')) {
           return true;
       }
       return false;
});
int[] hasSameNumberArray = GetFiltered(array, number =>{
    string numWord = Convert.ToString(number);
       if (numWord.Length == 1) {
           return true;
       }
       return numWord.All(ch => ch == numWord[0]);
});
//
Console.WriteLine("Original array items:");
Print(array);
Console.WriteLine("\n********************");
Console.WriteLine("Even array items:");
Print(evenArray);
Console.WriteLine("\n********************");
Console.WriteLine("Not even array items:");
Print(notEvenArray);
Console.WriteLine("\n********************");
Console.WriteLine("Has 3 array items:");
Print(has3Array);
Console.WriteLine("\n********************");
Console.WriteLine("Has same number array items:");
Print(hasSameNumberArray);
Console.WriteLine("\n********************");

static void Print(int[] list) {
    foreach (int item in list) {
        Console.Write($"{item} ");
    }
}

static int[] GetFiltered(int[] list, Func<int,bool> method) {
    List<int> newList = new List<int>();
    foreach (int y in list) {
        if (method(y) == true) {
            newList.Add(y);
        }
    }
    return newList.ToArray();
}