using System.IO;
using System;

namespace AfroDudeCS {
    
    class CubeVol {
        long width;
        long length;
        long height;
        
        public void getVals() {
            Console.Writeline("Give length: ");
            length = Console.ReadLine();
            Console.Writeline("Give width: ");
            width = Console.ReadLine();
            Console.Writeline("Give height: ");
            h
        }
        
        public void GetVolume(long l, long w, long h) {
            return l*w*h;
        } 
        
        
    }
    
    class Program {
        CubeVol cv = new CubeVol();
        
        static void Main(string[] args) {
            
        }
    }
}
