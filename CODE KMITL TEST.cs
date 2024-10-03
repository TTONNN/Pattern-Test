

//    Console.Write("Enter Number: ");
//    int A = int.Parse(Console.ReadLine());  


    int A = 7;
//  
Console.WriteLine("Code 1");

    for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        /*

        int.Parse()             รับค่าเป็นตัวเลขเท่านั้น
        int.TryParse()          รับเป็นตัวเลขเหมือนกัน เเต่สามารถใช้ if else check error ได้
        Console.ReadLine()      อ่านข้อความที่พิมพ์ไป
        Console.Write()         เขียนข้อความที่ต้องการตอนเริ่ม run
        Console.WriteLine()     สร้างข้อความเเบบขึ้นบรรทัดใหม่

        */
    /*    
        Console.Write("Enter Number: ");
        int lines = int.Parse(Console.ReadLine());  

        for (int x = 1; x <= lines; x++)
        {
            for (int y = 1; y <= x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    */
//        

Console.WriteLine("Code 2");

            for (int i = A; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
//

Console.WriteLine("Code 3");

    for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
            for (int i = A - 1; i >= 1; i--)       //เอาA -1 เพื่อให้บรรทักต่อกัน
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
//      
Console.WriteLine("Code 4");

     for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= A; j++)
            {
                if (i == 1 || i == A || j == 1 || j == A)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

//
/*for (int j = 1; j <= A - i; j++)
        create j1 and plus loop function untill middle function not work
*/
Console.WriteLine("Code 5");

        for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= A - i; j++)  //A=6     //สร้างช่องว่างเพราะj++ไปเรื่อยๆจนกว่า j <= A - i //บรรทัดเเรก 1 <= 6-1 มันเป็นจริงก็สร้างหนึ่งช่อง พอloopรอบ2 2 <= 6-1 ก็ยังจริง ทำเเบบนี้จนกว่าสมการไม่จริงก็ได้ช่องว่า5ช่อง
            {                                           //บรรทัดต่อไป j <= A - i ตัวiเพิ่มขึ้นเรื่อยๆทำให้เป็น1 <= 6-2 พอloopรอบ2 2 <= 6-2
                Console.Write(" "); 
            }
            
            for (int k = 1; k <= (2 * i - 1); k++)      //2*1=2-1=1  2*2=4-1=3
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }

//
Console.WriteLine("Code 6");

            for (int i = A; i >= 1; i--)        //ทำไปเรื่อยๆจนกว่า มันจะน้อยกว่า1 คือ0
        {

            for (int j = 1; j <= A - i; j++)    // middle 6-6=0 6-5=1 ไปเรื่อยๆ   //jรอบเเรกมันไม่ทำงานทำให้j=1ในรอบ2 พอเป็นรอบ3j=2
            {
                Console.Write(" ");             //รอบที่ 2: เมื่อA = 6, i = 5, ดังนั้น A - i = 6 - 5 = 1 ตรวจสอบว่า j <= 1เป็นจริง เลยทำ1ครั้ง
            }                                   //รอบ3 1<=6-4 1<=2 จริง เว้นวรรคหนึ่งครั้ง 2<=2จริงเว้นวรรคอีกครั้ง 3<=2 ไม่จริงไม่เว้นวรรเเล้ว
                                                //รอบ4 1<= 6-3 ทำเเบบ บรรทัดบน
    
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
//

Console.WriteLine("Code 7");

        for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= A - i; j++)  
            {                                           
                Console.Write(" "); 
            }
            
            for (int k = 1; k <= (2 * i - 1); k++)      
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
        for (int i = A - 1; i >= 1; i--)        
        {

            for (int j = 1; j <= A - i; j++)    
            {
                Console.Write(" ");            
            }                                   
                                                
    
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

//
Console.WriteLine("Code 8");

        for (int i = 1; i <= A; i++)
        {
            for (int j = 1; j <= A - i; j++)
            {
                Console.Write(" "); 
            }
            
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine(); 
        }        
//
// for (int j = i; j < A; j++) == for (int j = 1; j <= A - i; j++)
//
Console.WriteLine("Code 9");    //เอาcode4 มาประยุกต์
        for (int i = 1; i <= A; i++)
        {

            for (int j = i; j < A; j++)     //A=6   //บรรทักเเรก 1 < 6 จริง สร้างช่องว่างหนึ่งช่อง รอบ2 2 < 6 จริง ห็ทำไแเรื่อยๆถึง 5<6ถึงหยุด
            {                                       //บรรทัดใหม่เริ่มจาก 2 < 6 บรรทัดใหม่อีก 3 < 6 เลขพวกนี้จากนั้นก็เพิ่มขึ้นเรื่อยๆ
                Console.Write(" ");
            }


            for (int j = 1; j <= (2 * i - 1); j++)     //เเบบเดียวกับcode4 สร้างตัวเเรก2*1=2-1=1 ตัว2 2*2=4-1=3 ไปเรื่อยๆ5 7 9 11
            {
                if (j == 1 || j == (2 * i - 1) || i == A)   //สร้างตามเงื่อนไขด้านบนคล้ายcode4 เเล้ว
                {                                           //ตัวเเลกมี* ตัวสุดท้ายมี* เเละเเถวสุดท้าย มี*
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(); 
        }

//

Console.WriteLine("Code 10");
    for (int i = 0; i < A; i++)
        {
            for (int j = 0; j < A; j++)
            {
                if (j == i || j == (A - i - 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

//
        