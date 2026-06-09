using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diem = {8, 7, 6, 9, 9, 9, 9, 9, 10, 5, 4, 4};
        //     for (int i = diem.Length - 1; i >= 0; i--)
        //     {
        //         if (i == 0)
        //         {
        //         Console.Write(diem[i]);
        //         }
             
        //     else 
        //     {
        //           Console.Write(diem[i] + "; ");S
        //     }
        //     }
        // for ( int i = 0; i <= 5; i++)
        //     {
        //         Console.Write(diem[i] + "; ");
        //     }
        //     for (int i = diem.Length - 1; i >= 6; i--)
        //     {
        //         if ( i == 6)
        //         {
        //             Console.Write(diem[i]);
                    
        //         } else
        //         {
        //             Console.Write(diem[i] + "; ");
        //         }
        //     }
        int diemtmp = 4;
        int viTri = 8;
        for (int i = 0; i < diem.Length; i++)
            {
                if ( i == viTri - 1)
                {
                    //Console.Write(diemtmp + "; ");

                }
                if ( i ==  diem.Length - 1)
                {
                    //Console.Write(diem[i]);
                
                }
                else
                {
                    //Console.Write(diem[i] + "; ");
                }
                
            }
            int[] diemtmp2 = new int[diem.Length + 1];
            for (int i = 0; i < viTri - 1; i++)
            {
                diemtmp2[i] = diem[i];
            }
            diemtmp2[viTri - 1] = diemtmp;
            for (int i = viTri; i < diemtmp2.Length; i++)
            {
                diemtmp2[i] = diem[i - 2];
            }
            for (int i = 0; i < diemtmp2.Length; i++)
            { 
                Console.Write(diemtmp2[i] + ";  ");
            }
            //for (int i = 0; i <)
            //diemtmp2[vitri - 1] = 
            
            // for (int i = 0; i < diem.Length; i++)
            // {
            //     Console.Write(diem[i] + "; ");
            // }
         }
    }
}