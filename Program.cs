using System;

namespace lop_problem_9_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("숫자를 입력하시오(2~10000): ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num < 2 || num > 10000)
                    {
                        Console.WriteLine("범위를 벗어난 값입니다. 2~10000 사이의 정수를 입력해주세요.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    continue;
                }

                List<int> div_num = new List<int>(); //div = 약수(divisor)
                List<int> prime_num = new List<int>(); //prime_num = 소수(prime_number)

                // 약수 저장
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        div_num.Add(i);
                    }
                }
                // 약수중에 소수 판별
                for (int i = 0; i < div_num.Count; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < div_num[i]; j++)
                    {
                        if (div_num[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        prime_num.Add(div_num[i]);
                    }
                }
                if (prime_num.Count == 0)
                {
                    Console.Write(num + "은 소수입니다.");
                }
                else
                {
                    Console.Write(num + "의 약수 중에서 소수는 ");
                    foreach (int prime in prime_num)
                    {
                        Console.Write(prime + " ");
                    }
                    Console.Write("입니다.");
                }
                break;
            }
        }
    }
}