public abstract class Animal{
    public abstract string MakeSound();

}
public class Tiger: Animal{
    public override string MakeSound()
    {
        return " Meo meo";
    }
}
public class Chicken: Animal, IEdible{
    public override string MakeSound()
    {
        return " Gay";
    }
    public string HowToEat(){
        return "Eat Chicken";
    }
}
public interface IEdible{
    public string HowToEat();

}
public abstract class Fruit: IEdible{
    public abstract string HowToEat();
}
public class Orange: Fruit{
    public override string HowToEat()
    {
        return "Eat orange";
    }
}
public class Apple: Fruit{
    public override string HowToEat()
    {
        return "Eat apple";
    }
}