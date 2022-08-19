//:zap: for this morning: create a new console application. 
//in Program.cs create a new List of strings, and save it in a 
//variable called contacts . Use the {} collection initializer to 
//add three names to the list. iterate through the list and write 
//"Hello, <name of contact>" to the console. Add three more 
//contacts to your list using the Add method. iterate through the 
//list again, and only say hello if the name is longer than 20 characters.
using System.Collections.Generic;
using System;

List<string> contacts = new List<string>()
{
    "Bob", "Mat", "Joe"
};

contacts.Add("Tim");
contacts.Add("Tom");
contacts.Add("Prince Doucan the III");

foreach (string contact in contacts)
{
    if (contact.Length > 20)
    {
        Console.WriteLine($"Hello {contact}.");
    }
}

Console.WriteLine(@"
             ,
            /|      __
           / |   ,-~ /
          Y :|  //  /
          | jj /( .^
          >-""~""-v""
         /       Y
        jo  o    |
       ( ~T~     j
        >._-' _./
       /   ""~""  |
      Y     _,  |
     /| ;-""~ _  l
    / l/ ,-""~    \
    \//\/      .- \
     Y        /    Y    
     l       I     !
     ]\      _\    /""\
    ("" ~----( ~   Y.  )
~~~~~~~~~~~~~~~~~~~~~~~~~
");