//itproger lesson 2
// using System;

// namespace study{

//     class Program{

//         static void Main(){
//             Console.WriteLine("hello c#");
//             Console.Write("hell");//без перевода на новую строку
//             // \n - для первода на новую строку
//             //Console.ReadKey(); - ждет от пользоватеся одного символа, после закрывает консоль
//             //Console.ReadLine(); - позволяет вводить множество значений, и завершает программу только после нажатия enter
//         }

//     }

// }

//itproger lesson 3
// using System;
// namespace study{
//     class Program{
//         static void Main(){

//             int number = 3;
//             Console.WriteLine(5-number + " eto wot");

//             uint k = 3;    //только положительные числа(почему-то в конце проценты)
//             byte koo = 255;(doesn't work) 
//             short = 256;     //до 32 тысяч 
//             short, int, long
//             float dotnum = 34.34f;
//             float(f(в конце значения всегда f )), double(d(в конце значения всегда d))

//             string word = "word";
//             Console.WriteLine(word, 5);

//             char symvol = 'f';
//             Console.WriteLine(symvol);

//             bool isHappy = true;
//             Console.WriteLine(isHappy);

//             int num1=0, num2=0;

//             num1=Convert.ToInt32(Console.ReadLine());
//             num2=Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine(num2);
//             Console.WriteLine(num1);
//          }
//     }
// }

//itproger lesson 4 
// using System;
// namespace study{
//     class Program{
//         static void Main(){

//             // float user_input = float.Parse(Console.ReadLine()!); // знак ! нужен, чтоб код работал корректно(warning CS8604)
//             // //user_input = float.Parse(Console.ReadLine());
//             // //user_input = Convert.ToDouble(Console.ReadLine()); //если поменять тип перемнной на double
//             // //Console.WriteLine(user_input);

//             // float result; 
//             // result = user_input + 10f;
//             // result +=5; // скороченные операции 
//             // result++;  // + 1
//             // Console.WriteLine(result);

//             //const int ggg = 5;  // константа 
//             // Console.WriteLine(Math.PI);  //класс math, со всякими приколами 
//             // Console.WriteLine(Math.Ceiling(4.22f)); //округление к большему 
//             // Console.WriteLine(Math.Floor(3.9f)); //округление к меньшему 
//             // Console.WriteLine(Math.Round(4,3)); //округление в зависимости от числа 

//             // Console.WriteLine(Math.Min(2, 5)); // минимальное значение 
//             // Console.WriteLine(Math.Max(2, 5)); //максимальное значение 
//             // Console.WriteLine(Math.Pow(2, 2)); //возведение в степень

//             Console.Write("введите радиус круга: ");
//             double radius = Convert.ToDouble(Console.ReadLine()!);
//             double area = Math.PI * Math.Pow(radius, 2); 
//             Console.WriteLine("площадь круга с радиусом {0} равна {1}", radius, area);
//         }
//     }
// }


//itproger lesson 5 
// using System;
// namespace study{
//     class Program{
//         static void Main(){
//             //int a = Convert.ToInt32(Console.ReadLine()!); 
//             //string b = "hello";
//             //bool isHappy = true; 

//             // if(!isHappy/* a/b */){
//             //     Console.WriteLine("nt");
//             // }
//             // else{
//             //     Console.WriteLine("not nt");
//             // }

//             // if(isHappy && a == 5/* and is &&, or is ||*/){
//             //     Console.WriteLine("gg");
//             // }


//             // Console.Write("enter the name: ");
//             // string role = Console.ReadLine()!;
//             // if(role == "admin"){
//             //     Console.WriteLine("you have access to the data");
//             // }
//             // else{
//             //     Console.WriteLine("you are not admin");
//             // }

//         }
//     }
// }

//itproger lesson 6
// using System;
// namespace study{
//     class Program{
//         static void Main(){
//             short user_input = Convert.ToInt16(Console.ReadLine()!);

//             switch(user_input){
//                 case 1: 
//                 Console.WriteLine("your input is 1");
//                 break;
//                 case 4:
//                 Console.WriteLine("your input is 4");
//                 break;
//                 default:
//                 Console.WriteLine("no right input");
//                 break;
//             }
//         }
//     }
// }

//itproger lesson 7
using System;
namespace study{
    class Program{
        static void Main(){
            // for(byte i = 0; i <5; i++ ){
            //     Console.WriteLine("i is {0}", i);
            // }

            // byte i = 1; 
            // short q;
            // for(;;){
            //     Console.WriteLine("i is {0}", i);
            //     Console.WriteLine("choose 2 for exit");
            //     q = Convert.ToInt16(Console.ReadLine()!);
            //     switch(q){
            //         case 2:
            //             Console.WriteLine("in process...");
            //             return;
            //         default:
            //             Console.WriteLine("good choice");
            //             break;
            //     }
            // }

            // byte i = 0;
            // do{
            //     Console.WriteLine("i is {0}", i);
            //     i++;
            // } while(i<10);

            
        }
    }
}
