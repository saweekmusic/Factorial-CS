# Factorial

### What we must do?
In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.

Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#).

More details about factorial can be found [here](https://www.wikiwand.com/en/Factorial)

### What we did?
1. Мы создали переменную sum в который у нас будет записывается ответ вычислений. Сразу в эту переменную вкладываем число 1, ибо при умножении на 0 будет 0.
2. Делаем проверку. Если наше число будет меньше 0 или больше 12 (как сказано в задаче) - мы используем класс ArgumentOutOfRangeException для возвращения того, что число выходит за рамки допустимых.
3. В противном случае, если входное число равно 0 то мы возвращаем один (как сказано в задаче).
4. В противном случае мы делаем цикл FOR, который будет циклировать пока переменная i (которая считает круги, и заранее равна 1) меньше или равна заданному числу, и с каждым кругом добавляет к i по единице. И с каждым кругом мы делаем такую операцию.
5. 
```cs
sum *= i;
```
Иными словами каждый раз мы к sum приумножаем число i и сохраняем в ту же переменную sum.

#FUNDAMENTALS #ALGORITHMS #NUMBERS

[Factorial CS](https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc/train/csharp)
