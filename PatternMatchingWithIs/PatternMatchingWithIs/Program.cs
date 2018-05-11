using System;

namespace PatternMatchingWithIs
{
    class Program
    {
        static void Main(string[] args)
        {
            var usb = new UsbKey();
            TypeCastingWithoutPatternMatching(usb);
            TypeCastingWithPatternMatching(usb);
            PatternMathcingInSwitchStatement(usb);
            Console.ReadLine();
        }

        // The old way
        private static void TypeCastingWithoutPatternMatching(Storage storage)
        {
            if (storage == null)
            {
                throw new ArgumentNullException();
            }

            if (storage is UsbKey)
            {
                UsbKey usbKey = (UsbKey) storage;
                if (usbKey.IsPluggedIn)
                {
                    usbKey.Unload();
                    Console.WriteLine("USB Drive Unloaded.");
                }
                else throw new NotImplementedException();
            }
            else if (storage is Dvd)
            {
            }
            else throw new NotImplementedException();
        }

        // C# 7.0 way
        // You can declare the variable in the same line
        private static void TypeCastingWithPatternMatching(Storage storage)
        {
            if (storage is null)
            {
                throw new ArgumentNullException();
            }
            if ((storage is UsbKey usbDrive) && usbDrive.IsPluggedIn)
            {
                usbDrive.Unload();
                Console.WriteLine("USB Drive Unloaded.");
            }
            else if (storage is Dvd dvd && dvd.IsInserted)
            {
            }
            else throw new NotImplementedException();
        }

        // Pattern Matching in a Switch Statement
        private static void PatternMathcingInSwitchStatement(Storage storage)
        {
            switch(storage)
            {
                case UsbKey usbKey when usbKey.IsPluggedIn:
                    usbKey.Unload();
                    Console.WriteLine("USB Drive Unloaded.");
                    break;
                case Dvd dvd when dvd.IsInserted:
                    break;
                case null:
                default:
                    throw new ArgumentNullException();
            }
        }
    }

    public abstract class Storage
    {
        public bool Unload()
        {
            return true;
        }
    }

    public class UsbKey : Storage
    {
        public bool IsPluggedIn { get; set; }

        public UsbKey()
        {
            IsPluggedIn = true;
        }
    }

    public class Dvd : Storage
    {
        public bool IsInserted { get; set; }

        public Dvd()
        {
            IsInserted = true;
        }
    }
}
