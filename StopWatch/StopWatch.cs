public class StopWatch{
    DateTime startTime;
    DateTime endTime;


    public StopWatch(){
        this.startTime = DateTime.Now;
    }
    public void Start(){
        this.startTime = DateTime.Now;
    }
    public void Stop(){
        this.endTime = DateTime.Now;
    }
    public void GetElapsedTime(){
        TimeSpan elapsedTime = endTime - startTime;
        Console.WriteLine(elapsedTime.TotalSeconds);
    }
}