using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_Task3
{
   public class Caesar_Cipher
    {
      
            public static void Caesar(char[] from, char[] alphavit)
            {
            for (int i = 0; i < from.Length; i++)
            {
                for (int j = 0; j < alphavit.Length; j++)
                {
                    if (from[i] == alphavit[j])
                    {
                        if (from[i] == 'A')
                        {
                            from[i] = 'Y';
                        }
                        else if (from[i] == 'B')
                        {
                            from[i] = 'Z';
                        }
                        else
                        {
                            from[i] = alphavit[j -3];
                        }


                    }
                }
            }
        }
        

    }
}
