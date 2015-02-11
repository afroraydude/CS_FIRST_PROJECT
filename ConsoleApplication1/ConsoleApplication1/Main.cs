using System.IO;
using System;

namespace AfroDudeCS {
    
    public class CubeVol {
        long width;
        long length;
        long height;
        
        public void GetVals() {
            Console.Writeline("Give length: ");
            length = Console.ReadLine();
            Console.Writeline("Give width: ");
            width = Console.ReadLine();
            Console.Writeline("Give height: ");
            height = Console.ReadLine();
        }
        
        public void GetVolume(long l, long w, long h) {
            return l*w*h;
        } 
        public void Display() {
            GetVals();
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Volume: {0}", GetVolume());
        }
        
    }
    
    class Program {
        CubeVol cv = new CubeVol();
        
        static void Main(string[] args) {
            cv.Display();
            
        }
    }
}
