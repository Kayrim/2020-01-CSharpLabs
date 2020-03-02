using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace lab_26_NUnit_Tests
{
    public class OOP_Code
    {

        /* 
         
            Pass in array of numbers   [10,11,15,25..

            While loop ==> add one to each number  [11,12,16

            Do..While loop ==> add 3 to each number  [14,15,19..

            Foreach loop ==> double each number  [28,30,38...

            Create a Cat class with string Name and int Age.   Have a Constructor.

            Create a list of Cats and foreach loop => create new cat with name 
                    'Cat'+number' and Age=number
                    eg first cat is called 'Cat28' and has Age 28.

            Print the list of cats with names and ages

            Return the total of all the ages of all cats!

         */

        public int Test_600_OOP_Array_While_Do_ForEach_Cat_List_Ages_Total(int[] array)
        {
            return -1;
        }


        /* 
         WPF Person Generator

        Create 100 people with random name, age and date every second and display.



        Create a timer.  Set it to a given amount.

        Every second create a new instance of a Person class.

        class Person{
          public int PersonID{get;set;}
          public string Name{get;set;}
          public DateTime DateOfBirth {get;set;}
        }


        Generate a random name by picking it from an array of given names.
        Also generate a random date (year, month, day) 
        and give this person a random date of birth from this.

        # Person Class
        Create a class Person with name, age and dateofbirth.

        # Random Name And Age and Date

        Create some arrays to hold random names eg 10 names  (JSON Generator?)

        Use a randomise function to pick a random name from the array

        Also date constructed from dd/mm/yyyy where dd,mm and yyyy are randomly generated

        # Instance

        Using our random data instantiate a new instance of our Person class 
        to create a new object

        # List
        Add this new instance to a list of people  myList.add(person01)


        # Timer
        Repeat every second for 100 seconds  system.threading.thread.sleep(1000)


        # WPF Display New Person
        Put this onto a WPF app and push to a label, with the new person appearing every second
         
        Test will pass in an integer for the number of seconds to run the test, and return an integer
        of the number of people generated after the given number of seconds
         
         */

        public int Random_Person_Generator(int years)
        {
            return -1;
        }


    }



}
