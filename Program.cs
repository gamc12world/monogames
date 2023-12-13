using System;
using System.Runtime.Intrinsics.Arm;
Console.WriteLine("enter the number");
var input=Convert.ToDouble(Console.ReadLine());
if (input<=10 || input>=1){
    Console.WriteLine("vaild");
}
else{
    Console.WriteLine("invaild");
}
Console.WriteLine("enter the height of image");
var height=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the width of image");
var width=Convert.ToDouble(Console.ReadLine());
Console.WriteLine(height/width==16/9);
if (height<=0 || width<=0){
    Console.WriteLine("enter the correct value");
}
else if(height/width==16.0/9.0){
         Console.WriteLine("your image is landscape");
}
else{
    Console.WriteLine("your image is portrait");
}
Console.WriteLine("can you enter the speed limit of your car");
var speedlimit=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter the speed of car");
var carspeed=Convert.ToInt16(Console.ReadLine());
int demeritpoint=0;
if(carspeed<=speedlimit){
    Console.WriteLine("ok go");
    }
    else{
        int speeddiffernec=carspeed-speedlimit;
        Console.WriteLine(speeddiffernec); 
        for (int counter = 5; counter<=speeddiffernec; counter++)
        {
            if(counter%5==0){
                demeritpoint++;
            }
        }
        Console.WriteLine(demeritpoint);
    }
if (demeritpoint>=12)
{
        Console.WriteLine("license invaild");

    
}
enum aman{
   speed
}