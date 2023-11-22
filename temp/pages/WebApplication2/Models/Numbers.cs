namespace WebApplication2.Models; 

public class Numbers {
    public List<int> GetRandomNumbers(int count) {
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++) {
            numbers.Add(rnd.Next(0,100));
        }
        return numbers;
    }
}