using DataStructures;

class mainmeth
{
    static void Main()
    {

       

        LinkedListImpl li=new LinkedListImpl();
        li.Add(0);
        li.Add(1);
        li.Add(2);
        li.Add(3);
        li.Add(4);
        li.Add(5);


        li.printAll();
        Console.WriteLine("-----------------");
       li.deleteByIndex(1);
        li.printAll();
        /*li.AddByIndex(0, "addded in 0 index");
        Console.WriteLine("-----------------");
        li.printAll();*/

    }
}