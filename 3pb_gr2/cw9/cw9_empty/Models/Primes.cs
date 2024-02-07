using System.Globalization;

namespace cw9_empty;

public class Primes
{
    public static bool IsPrime(int number){
        if(number<2) return false;
        for(int i=2;i*i<=number;i++){
            if(number%i==0) return false;
        }
        return true;
    }
    public static List<int> GetPrimes(int limit){
        List<int> primes = new List<int>();
        int number = 2;
        primes.Add(number);
        while(primes.Count<limit){
            number++;
            if(IsPrime(number)){
                primes.Add(number);
            }
        }
        return primes;
    }
}
