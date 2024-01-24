using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Singleton
{

    // וריאנט של סינגלטון שמאפשר יצירה של מספר מסוים של אובייקטים
    internal class Mouse
    {
        private static Mouse [] instance=new Mouse[2];
        static int counter = -1;
        protected Mouse()
        {
            Console.WriteLine("Mouse ctor");
        }
        public static Mouse GetInstance()
        {
            counter++;
            if (  instance[counter%2] == null)
            { 
                 instance[counter % 2] = new Mouse();
            }           
          
            return instance[counter % 2];
        }

    }
}
