using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //CONSOLE APP ASSIGNMENT - PART 1

        //Creating and initializing a one-dimensional STRING ARRAY.
        string[] userArray = new string[] { "str1-", "str2-", "str3-", "str4-", "str5-", "str6-" };

        //Collecting user input of text-string.
        Console.WriteLine("Enter your text string: ");
        Console.WriteLine(); //inserting a blank line in the output.
        string strEntry = Console.ReadLine();

        //Loop for concatenating each userArray text-string element with the user text-string input.
        for (int i = 0; i < userArray.Length; i++)
        {
            userArray[i] = userArray[i] + strEntry;
        }
        Console.WriteLine(); //inserting a blank line in the output.

        //Loop for printing off each string in the edited usrArray

        Console.WriteLine("Here are your concatenated strings: ");
        Console.WriteLine(); //inserting a blank line in the output.
        for (int j = 0; j < userArray.Length; j++)
        {
            Console.WriteLine(userArray[j]);
        }
        Console.ReadLine();



        //CONSOLE APP ASSIGNMENT PART 2

        /*Infinite Loop is a loop that never terminates or ends and repeats indefinitely. 
        It is a loop in which the test condition does not evaluate to false and 
        the loop continues forever until an external force is used to end it.*/

        //An infinite loop can be created using either a 'for loop' or a 'while loop'    

        //Inserting a while loop to illustratine an infinite loop that prints off each string in the edited userArray forever using a while loop.

        bool loopControl = true;

        while (loopControl) //Without logic to influence the value of the control variable, the loop persists forever.
        {
            Console.WriteLine("Here is the output of your infinite loop \nfixed by toggling the value of the control variable: ");
            Console.WriteLine(); //inserting a blank line in the output.
            for (int j = 0; j < userArray.Length; j++)
            {
                Console.WriteLine(userArray[j]);
            }
            loopControl = false; //logical solution to fix the infinite loop by toggling the value of the loop control variable "loopControl".
        }
        Console.ReadLine();



        //CONSOLE APP ASSIGNMENT PART 3

        //Iteration loop control using a “<” operator.
        Console.WriteLine("Here is the output of your “<” operator controlled loop: ");
        Console.WriteLine(); //inserting a blank line in the output.
        int loopControl1 = 0;
        while (loopControl1 < userArray.Length)
        {
            Console.WriteLine(userArray[loopControl1]);
            loopControl1++;
        }
        Console.ReadLine();


        //Iteration loop control using a “<=” operator
        Console.WriteLine("Here is the output of your “<=” operator controlled loop: ");
        Console.WriteLine(); //inserting a blank line in the output.
        int loopControl2 = 0;
        while (loopControl2 <= userArray.Length - 1)
        {
            Console.WriteLine(userArray[loopControl2]);
            loopControl2++;
        }
        Console.ReadLine();



        //CONSOLE APP ASSIGNMENT PART 4

        //declaring and initializing a STRING LIST that contains unique text strings as elements.

        List<string> britishCities = new List<string> {"Edinburgh", "London", "Cardiff", "Glasgow", "Liverpool", 
            "Birmingham", "Swansea", "Belfast", "Newcastle", "Manchester"};

        //asking the user to input text to search for in the STRING LIST.
        Console.WriteLine("Enter the name of a city in the United Kingdom: ");
        //collecting user keyboard input of text string to be matched to any of the STRING LIST text-string entries.
        string selectedCity = Console.ReadLine();

        /*creating a loop that iterates through the STRING LIST to find a match for the user input and 
        then displays the list index of the list item that contains the matching text-string on the screen.*/

        foreach (string city in britishCities)
        {
            if (selectedCity == city)
            {
                int matchIndex = britishCities.IndexOf(city);
                if (matchIndex >= 0)
                {
                    Console.WriteLine("List item that matches your selected city was found at index: " + matchIndex);
                }
            }
        }

        //adding code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
        //the List<T>.Contains(T) Method is used to check whether an element is in the List<T> or not.
        //Note: the default output value of the List<T>.Contains(T) Method statement is boolean false. 
        bool isStrInList = britishCities.Contains(selectedCity);
        
        if (isStrInList != true)
            {
            Console.WriteLine("Your city selection has not been found on the list. "); //notifying the user their input is not on the list.
            }

        //Adding code that STOPS THE LOOP from executing once a match has been found.
        //exit from the foreach loop by using the break keyword.

        foreach (string city in britishCities)
            if (selectedCity == city)
            {
                break;
            }
        Console.WriteLine(); //inserting a blank line in the output.
        Console.WriteLine("The foreach loop has been STOPPED after a match was found!");              
        Console.ReadLine();



        //CONSOLE APP ASSIGNMENT PART 5

        //creating and initializing a LIST OF STRINGS that has at least two identical strings in the list.
        List<string> birdNames = new List<string> {"Crow", "Eagle", "Dove", "Robin", "Hawk", "Dove", "Parrot", "Dove", "Finch", "Sparrow"};

        //asking the user to select text to search for in the list.
        Console.WriteLine("Enter the name of your favourite bird: ");
        
        //collecting user keyboard input of text string to be matched to any of the LIST OF STRINGS text-string entries.
        string favouriteBird = Console.ReadLine();

        /*creating a loop that iterates through the list and then displays the indices of the 
        list that contain matching text on the screen whilst ensuring to remove any break statements 
        that may prevent the code from returning multiple matches.*/

        foreach (string name in birdNames)
        {
            if (favouriteBird == name)
            {
                int theMatchIndex = birdNames.IndexOf(name);
                if (theMatchIndex >= 0)
                {
                    Console.WriteLine("List item that matches your favourite bird was found at index: " + theMatchIndex);
                }
            }   

        }

        bool isNameInList = birdNames.Contains(favouriteBird);

        /*Adding code to the loop to check if the user put in text that isn't on the list and, if they did, 
        tells the user their input is not on the list. (No need to provide any additional chances for the user to enter text.)*/

        //List<T>.Contains(T) Method will be used to check whether an element is in the List<T> or not.

        if (isNameInList != true)
        {
            Console.WriteLine("Your favourite bird has not been found on the list. "); //notifying the user their input is not on the list.
        }
        Console.ReadLine();


        //CONSOLE APP ASSIGNMENT PART 6

        //creating and initializing a LIST OF STRINGS that has at least two identical strings in the list.
        List<string> listOfFruits = new List<string> { "Apple", "Banana", "Pear", "Guava", "Strawberry", "Pear", "Mango", "Pear", "Grape", "Papaya" };

        //creating a new empty list to store the unique elements.
        List<string> uniqueList = new List<string>();

        /*creating a foreach loop that evaluates each item in the list, and displays a message showing the string and 
        whether or not it has already appeared in the list.*/

        int duplicateCount = 0;
        string duplicatedFruit = "";

        foreach (string fruit in listOfFruits)
        {
            bool isFruitInList = listOfFruits.Contains(fruit);
            bool isFruitInUniqueList = uniqueList.Contains(fruit);
                       
            if(isFruitInList == true && isFruitInUniqueList == true)
                {
                    Console.WriteLine("The fruit " + fruit + " " + "already appears in the unique list of fruits!");
                    Console.WriteLine(); //inserting a blank line in the output.
                    duplicateCount++;
                    duplicatedFruit = fruit;
                }
            else
                {
                    uniqueList.Add(fruit);
                    Console.WriteLine("The fruit " + fruit + " has not been duplicated!");
                    Console.WriteLine(); //inserting a blank line in the output.
                }            
        }
        Console.WriteLine(); //inserting a blank line in the output.
        Console.WriteLine("The fruit " + duplicatedFruit + " " + "has been duplicated" + " " + duplicateCount + " times in the LIST OF STRINGS!");
        Console.WriteLine(); //inserting a blank line in the output.
        Console.ReadLine();
    }
}

