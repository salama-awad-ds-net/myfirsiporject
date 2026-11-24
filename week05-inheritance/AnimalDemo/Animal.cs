class Animal
{
    public string name;
    public Animal(string name)
    {
        name =  name;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}
