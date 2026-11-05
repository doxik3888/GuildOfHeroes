public class Hero {
    public string Name;
    public int Health;
    public int Level;
    public int Experience;
    
    public Hero(string name, int health) {
        Name = name;
        Health = health;
        Level = 1;
        Experience = 0;
    }
}

public class Person {
    public string Name;

    public Person(string name) {
        Name = name;
    }
}