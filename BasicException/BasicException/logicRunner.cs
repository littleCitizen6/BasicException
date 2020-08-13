using BasicException.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

namespace BasicException
{
    public class logicRunner
    {
        private Logic _logic;

        public logicRunner()
        {
            _logic = new Logic();
        }

        public int RunLogic1(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ScubaException("the array is empty");
            }
            return _logic.Logic1(numbers);
        }

        public void RunLogic2(string inputFileName, string outputFileName)
        {
            try
            {
                _logic.Logic2(inputFileName, outputFileName);
            }
            catch (ArgumentNullException e) 
            { Console.WriteLine("path is an empty string");
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine("path is null"); 
            }
            catch (FileNotFoundException e) 
            {
                Console.WriteLine("The file cannot be found"); 
            }
            catch (DirectoryNotFoundException e) 
            { 
                Console.WriteLine("The directory cannot be found"); 
            }
            catch (PathTooLongException e) 
            { 
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length"); 
            }
            catch (UnauthorizedAccessException e) 
            {
                Console.WriteLine("Access is denied");
            }
            catch (IOException e) 
            { 
                Console.WriteLine("path includes an incorrect or invalid syntax for file name, directory name, or volume label"); 
            }
            catch (SecurityException e) 
            {
                Console.WriteLine("The caller does not have the required permission");
            }
        }

        public int Logic3(string data)
        {
            return Int32.Parse(data);
        }

        public void Logic4(string data1, int data2, long data3)
        {
            throw new NotImplementedException("This method is not implemeted");
        }

        public void Logic5(string dllName)
        {
            Assembly.LoadFrom(dllName);
        }

    }
}
