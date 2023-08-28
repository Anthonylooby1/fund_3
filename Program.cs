// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// static void PrintList(List<string> MyList)
// {
//     // Your code here
//     foreach(string name in MyList)
//     {
//         Console.WriteLine(name);
//     }
// }
// List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
// PrintList(TestStringList);

// static void SumOfNumbers(List<int> IntList)
// {
//     // Your code here
//     int sum = 0;
//     foreach( int num in IntList)
//     {
//         int newSum = sum + num;
//         sum = newSum;
//     }
//     Console.Write(sum);
// }
// List<int> TestIntList = new List<int>() {2,7,12,9,3};
// // You should get back 33 in this example
// SumOfNumbers(TestIntList);

// using System.ComponentModel.DataAnnotations;
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;

// static int FindMax(List<int> IntList)
// {
//     // Your code here
//     int max = 0;
//     foreach(int num in IntList)
//     {
//         if(num > max)
//         {
//             max = num;
//         }
//         Console.WriteLine(max);
//     }
//     return max;
// }
// List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// // You should get back 17 in this example
// FindMax(TestIntList2);

// static List<int> SquareValues(List<int> IntList)
// {
//     // Your code here
//     foreach(int i in IntList)
//     {
//         int square = IntList[i]*IntList[i];
//         Console.WriteLine(square);
//     }
//     return square;
// }
// List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// // You should get back [1,4,9,16,25], think about how you will show that this worked
// SquareValues(TestIntList3);


// static int[] NonNegatives(int[] IntArray)
// {
//     // Your code here
//     foreach(int i in IntArray)
//     {
//         if(IntArray[i] < 0)
//         {
//             IntArray[i] = 0;
//         }
//     }
        // return IntArray;
// }
// int[] TestIntArray = new int[] {-1,2,3,-4,5};
// // You should get back [0,2,3,0,5], think about how you will show that this worked
// NonNegatives(TestIntArray);


static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    // Your code here
    foreach(KeyValuePair<string,string> name in MyDictionary)
    {
        Console.WriteLine($"Your {name.Key} is {name.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    // Your code here
    foreach(KeyValuePair<string,string> term in MyDictionary)
    {
        if(term.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
    
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
List<string> Names = new List<string>(){
    "Frank",
    "bob",
    "dylan"
};
List<int> Numbers = new List<int>(){
    30,
    40,
    50
};

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    Dictionary<string, int> NameDict = new();
    for(int i = 0; i < Names.Count; i++)
    {
        NameDict.Add($"{Names[i]}", Numbers[i]);
    }
    foreach(KeyValuePair<string,int> NewName in NameDict)
    {
        Console.WriteLine($"{NewName.Key}: {NewName.Value}");
    }
    return NameDict;

}   
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here


