using BasicException.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

namespace BasicException
{
    public class LogicRunner
    {
        private Logic _logic;

        public LogicRunner()
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
            { 
                Console.WriteLine("path is an empty string");
                throw;
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine("path is null");
                throw;
            }
            catch (FileNotFoundException e) 
            {
                Console.WriteLine("The file cannot be found");
                throw;
            }
            catch (DirectoryNotFoundException e) 
            { 
                Console.WriteLine("The directory cannot be found");
                throw;
            }
            catch (PathTooLongException e) 
            { 
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
                throw;
            }
            catch (UnauthorizedAccessException e) 
            {
                Console.WriteLine("Access is denied");
                throw;
            }
            catch (IOException e) 
            { 
                Console.WriteLine("path includes an incorrect or invalid syntax for file name, directory name, or volume label");
                throw;
            }
            catch (SecurityException e) 
            {
                Console.WriteLine("The caller does not have the required permission");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("unrcognized exception");
                throw;
            }
        }

        public int RunLogic3(string data)
        {
            int checkValidity;
            if(!Int32.TryParse(data, out checkValidity))
            {
                throw new ScubaException("cannot parse to int, check the data that given");
            }
            return _logic.Logic3(data);
        }

        public void RunLogic4(string data1, int data2, long data3)
        {
            try
            {
                _logic.Logic4(data1, data2, data3);
            }
            catch(NotImplementedException e)
            {
                Console.WriteLine("the function isnt impemented");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("unrcognized exception");
                throw;
            }
        }

        public void RunLogic5(string dllName)
        {
            try
            {
                _logic.Logic5(dllName);
            }
            catch (ArgumentNullException e) 
            { 
                Console.WriteLine("assemblyFile is null");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("assemblyFile is not found, or the module you are trying to load does not specify a filename extension.");
                throw;
            }
            catch (FileLoadException e) 
            {
                Console.WriteLine("A file that was found could not be loaded");
                throw;
            }
            catch (BadImageFormatException e)
            {
                Console.WriteLine("assemblyFile is not a valid assembly");
                throw;
            }
            catch (SecurityException e) 
            {
                Console.WriteLine("A codebase that does not start with 'file://' was specified without the requiredSystem.Net.WebPermission.");
                throw;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The assemblyFile parameter is an empty string");
                throw;
            }
            catch (PathTooLongException e) 
            {
                Console.WriteLine("The assembly name exceeds the system-defined maximum length");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("unrcognized exception");
                throw;
            }

        }

    }
}
