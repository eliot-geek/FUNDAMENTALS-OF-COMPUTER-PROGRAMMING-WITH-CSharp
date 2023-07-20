namespace Less00HistoryNutshell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // History in a Nutshell
            /* In ancient Egypt people used sun dials, which measure time with the help of numeral systems. It divided the time between sunrise and sunset into 12 parts.
            In modern times, the decimal system is the most widely spread numeral system. numeral systems – duodecimal and sexagesimal with bases 12 and 60 respectively.
            The number 60 is the smallest number that can be divided by 1, 2, 3, 4, 5, 6, 10, 12, 15, 20 and 30 without a remainder. 

            Applications of the Sexagesimal Numeral System
            The presented facts explain why a day contains (only) 24 hours, the hour has 60 minutes and the minute has 60 seconds. 
            This is a result of the fact that the ancient Egyptians divided the day after they had started using the duodecimal numeral system. 
            The division of hours and minutes into 60 equal parts is a result of the work of ancient Greek astronomers, who did their calculations using the sexagesimal
            numeral system, which was created by the Sumerians and used by the Babylonians.
            
            Numeral Systems
            What Are Numeral Systems? Numeral systems are a way of representing numbers by a finite type-set of graphical signs called digits. 
            We must note that today the most widely spread one is the Arabic numeral system. It uses the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9, as its alphabet.
            which is the best numeral system that we should use? To answer it, we must decide what the optimal way to depict a number (the digit count in the number) is and the number of digits the
            given numeral system uses – its base. Mathematically it can be proven that the best ratio between the length of depiction and the number of used digits
            is accomplished by using Euler's number (e = 2,718281828), which is the base of natural logarithms.

            Working in a system with such base e is extremely inconvenient and impractical because that number cannot be represented as a ratio of two natural numbers. 
            This gives us grounds to conclude that the optimal base of a numeral system is either 2 or 3. Although the number 3 is closer to the Neper number, it is unsuitable for
            technical implementation. Because of that the binary numeral system is the only one suitable for practical use and it is used in the modern computers and electronic devices.

            Positional Numeral Systems
            A positional numeral system is a system, in which the position of the digits is significant for the value of the number.
            For example, in the number 351 the digit 1 has a value of 1, while in the number 1024 it has a value of 1000.

            Non-Positional Numeral Systems
            Besides the positional numeral systems, there are also non-positional numeral systems, 
            in which the value of each digit is a constant and does not strictly depend on its position in the number.
            Such numeral systems are the Roman and Greek numeral systems. 

            The Binary Numeral System – Foundation of Computing Technology
            The binary numeral system is the system, which is used to represent and process numbers in modern computing machines.

            Decimal Numbers
            Numbers represented in the decimal numeral system, are given in a primal appearance, meaning that they are easy to be understood by humans.

            Binary Numbers
            The numbers represented in the binary numeral system are represented in a secondary aspect – which means that they are easy to be understood by the computing machine.
            If a binary number ends in 0 it is even, if it ends in 1 it is odd.

            Converting From Binary to Decimal Numeral System
            11001(2) = 1×24 + 1×23 + 0×22 + 0×21 + 1×20 = 16(10) + 8(10) + 1(10) = 25(10)
            From this follows that 11001(2) = 25(10)

            Converting from Decimal to Binary Numeral System
            When transitioning from decimal to binary numeral system, we convert a decimal number into a binary one. To accomplish this, we divide it by 2 with a remainder.
            148:2=74 with remainder 0;
            74:2=37 with remainder 0;
            37:2=18 with remainder 1;
            18:2=9 with remainder 0;
            9:2=4 with remainder 1;
            4:2=2 with remainder 0;
            2:2=1 with remainder 0;
            1:2=0 with remainder 1;

            i.e. 148(10) = 10010100 (2)


            Operations with Binary Numbers
            0 + 0 = 0   0 - 0 = 0   0 × 0 = 0
            1 + 0 = 1   1 - 0 = 1   1 × 0 = 0
            0 + 1 = 1   1 - 1 = 0   0 × 1 = 0
            1 + 1 = 10  10 - 1 = 1  1 × 1 = 1

            Bitwise "and"
            10111011 AND 00000001 = 00000001
            int result = integer1 & integer2;

            Bitwise "or"
            10111011 OR 00000100 = 10111111
            int result = integer1 | integer2;

            Bitwise "exclusive or"
            10111011 XOR 01010101 = 11101110
            int result = integer1 ^ integer2;

            Bitwise Negation
            NOT 10111011 = 01000100
            int result = ~integer1;



            Hexadecimal Numbers
            With hexadecimal numbers we have the number 16 for a system base, which implies the use of 16 digits to represent all possible values from 0 to 15 inclusive.
            A=10, B=11, C=12, D=13, E=14, F=15
            D1E(16) = E*16^0 + 1*16^1 + D*16^2 = 14*1 + 1*16 + 13*256 = 3358(10).
            Transition from decimal to hexadecimal numeral system is done by dividing the decimal number by 16 and taking the remainders in reverse order. Example:
            3358 / 16 = 209 + remainder 14 (E)
            209 / 16 = 13 + remainder 1 (1)
            13 / 16 = 0 + remainder 13 (D)
            We take the remainders in reverse order and get the number D1E(16).

            Fast Transition from Binary to Hexadecimal Numbers
            The fast conversion from binary to hexadecimal numbers can be quickly and easily done by dividing the binary number into groups of four bits (splitting it into half-bytes). 
            If the number of digits is not divisible by four, leading zeros in the highest-orders are added. 
            After the division and the eventual addition of zeros, all the groups are replaced with their corresponding digits.
            Let’s look at the following: 1110011110(2).
            1. We divide it into half-bytes and add the leading zeros
            Example: 0011 1001 1110.
            2. We replace every half-byte with the corresponding hexadecimal digit and we get 39E(16).
            Therefore 1110011110 (2) = 39E(16).

            Numeral Systems – Summary
            - Transitioning from a decimal to a k-based numeral system is done by consecutively dividing the decimal to the base of the k system and the remainders 
            (their corresponding digit in the k based system) are accumulated in reverse order.
            - Transitioning from a k-based numeral system to decimal is done by multiplying the last digit of the k-based number by k0, the one before it by k1, 
            the next one by k2 and so on, and the products are the added up.
            - Transitioning from a k-based numeral system to a p-based numeral system is done by intermediately converting to the decimal system 
            (excluding hexadecimal and binary numeral systems).
            - Transitioning from a binary to hexadecimal numeral system and back is done by converting each sequence of 4 binary bits into 
            its corresponding hexadecimal number and vice versa.


             */
            
            
            Console.WriteLine("Hello, History in a Nutshell!");
        }
    }
}