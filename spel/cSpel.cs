// namespace som används
using System;
using System.Collections.Generic;
using System.Threading;

namespace spel
{
    // public = klassen kan användas av andra projekt
    // private = nås endast av den egna klassen
    // standard är 'internal' = endast det egna projektet kan använda
    public class cSpel {
        // klassens attribut
        private int start;
        private int stopp;
        private int reaktion;

        // hämtar TickCount för start
        public void StartaSpelet() {
            start = Environment.TickCount;
        }
    
        // hämtar TickCount för spelarens stopp-signal 
        public void StoppaSpelet() {
            stopp = Environment.TickCount;
        }
    
        // slumpvis fördröjning 3-10 sek 
        public void SlumpvisDelay() {
            Random slumpen = new Random();
            int antSek = slumpen.Next(3,11);
            antSek *= 1000;
            Thread.Sleep(antSek);
        }

        // beräknar spelarens reaktions-tid i millisekunder
        public void BeraknaReaktionstid() {
            reaktion = stopp - start;            
        }
            
        // property/egenskap för reaktionstiden 
        public int Reaktion { 
            // get returnerar värdet på attributet
            get {
                return reaktion;
            } 
        }
    }
}