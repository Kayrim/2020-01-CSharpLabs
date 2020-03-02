using System;

namespace lab_18_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            string word = "elephant";
            // foreach
            foreach (char c in word){
                Console.WriteLine(c);
            }
            // while
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }


            // do.while
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);

            /*
             
             
             ### Continue

If we don't want to process a certain loop then 'continue' goes to next loop

### Break

If we have finished processing then 'break' exits the loop

Count from 1 to 100

	if not divisible by 5 then 'continue' to next loop

	print item

	if equal to 90 then break


									5,10,15......85,90
                                    
             
             */

            for (int k = 5; k <= 90; k+=5)
            {

                if (k % 5 != 0) continue;



                Console.Write(k+ "  ");
                //if (k == 90) break;
            }



            // GOTO
            // Older programs used GOTO to JUMP IN PROGRAM
            // Never use GOTO but it DOES EXIST

            Console.WriteLine("Start here");
            goto a;
            //Console.WriteLine("This is never printed");
            a:
            Console.WriteLine("Jumped to this point");
            Console.WriteLine("Continue execution");


            // RETURN
            // If we are in a METHOD then we can EXIT THE LOOP AND ALSO
            // exit the method at the same time, using RETURN keyword

            DoThis();


            void DoThis()
            {

                for(int num1 = 1; num1 < 100; num1++)
                {
                    if (num1 == 10)
                    {
                        return;
                    }

                    Console.WriteLine($"In method DoThis - num1 is {num1}");
                }

            }


            // THROW
            // In some bigger applications they want to track when errors occur eg form validation
            for(int num2 = 0; num2 < 10; num2++)
            {
                if (num2 == 5)
                {
                    throw new Exception("invalid number");
                }
            }
        }
    }
}
