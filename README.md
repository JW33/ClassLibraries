# ClassLibraries

A class library project written for better understanding of class libraries and unit testing.

PrimeCalculations project will allow you to do a number of things with prime numbers from checking to generating. 

Examples: 

    IsPrime(7) //true
    IsPrime(8) //false
    int value = GetPrimeNumber(100) // value = 54		
    int value = GetLargestPrime(100) //value = 97
    int value = GetLargestPrime(700) // value = 691
    List<int> list = GetListOfPrimes(3); //list = 2, 3, 5


ArrayCalculations project will allow you to get the mean, median or mode of an array or list.

Examples: 	

    double value = GetMean(new int[] {1, 2, 3, 4, 5}) //value = 3
    double value = GetMean(new int[] {1, 2, 3, 4}) //value = 2.5
    List<int> list = GetMode(new int[] {1, 2, 2, 3, 4); //list = 2


Both have 100% unit test coverage
