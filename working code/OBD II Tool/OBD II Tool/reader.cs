using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBDIIEngineLibrary;

namespace OBD_II_Tool
{
    class reader
    {
        
        public Int16 antwort;

        public void getRPM(String COMP)
        {
            OBDIIEngine harv = new OBDIIEngine(COMP);
            harv.OpenPort();
            this.antwort = Convert.ToInt16(harv.GetSpeedKmh());
            harv.ClosePort();
            
        }



        
        public Int16 getRPM(){return antwort;}

        }
    }



