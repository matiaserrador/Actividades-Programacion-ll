using System;

namespace Primer_ejercicio_Prg_ll
{
    class Program
    {
        static void Main(string[] args)
        {

            //int Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Setiembre, Octubre, Noviembre, Diciembre; //Defino los meses como entero 
            //Defino la cantidad de días de los meses....
            /*Enero = 31;
            Febrero = 28;
            Marzo = 31;
            Abril = 30;
            Mayo = 31;
            Junio = 30;
            Julio = 31;
            Agosto = 31;
            Setiembre = 30;
            Octubre = 31;
            Noviembre = 30;
            Diciembre = 31;*/
            int Dia;
            Dia = 0;
            /*int Mes28Feb =28;
            int Mes30 = 30;
            int Mes31 = 31;*/
            int Mes;
            Mes = 0;
            int Año =0;
            Año = Año + 1;
            Año++;
            int Acumuladorcin = 0;
            Acumuladorcin = Acumuladorcin +1;
            
            /*for (int i = 0; i + Acumuladorcin < 31; i++)
            {
                if (Enero > i)
                {
                    Console.WriteLine("Febrero"); 
                }
                else if (Febrero > i)
                {
                    Console.WriteLine("Marzo");
                }
                else if (Marzo > i)
                {
                    Console.WriteLine("Abril");
                }
                else if (Abril > i)
                {
                    Console.WriteLine("Mayo");
                }
                else if (Mayo > i)
                {
                    Console.WriteLine("Junio");
                }
                else if (Junio > i)
                {
                    Console.WriteLine("Julio");
                }
                else if (Julio > i)
                {
                    Console.WriteLine("Agosto");
                }
                else if (Agosto > i)
                {
                    Console.WriteLine("Setiembre");
                }
                else if (Setiembre > i)
                {
                    Console.WriteLine("Octubre");
                }
                else if (Octubre > i)
                {
                    Console.WriteLine("Noviembre");
                }
                else if (Noviembre > i)
                {
                    Console.WriteLine("Diciembre");
                }
            }*/
            Console.WriteLine("Buuuuuuuuuuenassss, Bienvenido al primer programita escolar de 2022... Segui las instrucciones =)");
            Console.WriteLine("");
            Console.Write("Ingrese el día... "); 
            Dia = Convert.ToInt32(Console.ReadLine()); 
            
            switch (Dia)
            {
                case 1: Console.WriteLine("02"); break;
                case 2: Console.WriteLine("03"); break;
                case 3:Console.WriteLine("04"); break;
                case 4: Console.WriteLine("05"); break;
                case 5: Console.WriteLine("06"); break;
                case 6: Console.WriteLine("07"); break;
                case 7: Console.WriteLine("08"); break;
                case 8:  Console.WriteLine("09"); break;
                case 9:  Console.WriteLine("10"); break;
                case 10:  Console.WriteLine("11"); break;
                case 11:  Console.WriteLine("12"); break;
                case 12: Console.WriteLine("13"); break;
                case 13:  Console.WriteLine("14"); break;
                case 14:  Console.WriteLine("15"); break;
                case 15:  Console.WriteLine("16"); break;
                case 16:  Console.WriteLine("17"); break;
                case 17: Console.WriteLine("18"); break;
                case 18:  Console.WriteLine("19"); break;
                case 19: Console.WriteLine("20"); break;
                case 20:  Console.WriteLine("21"); break;
                case 21:  Console.WriteLine("22"); break;
                case 22:  Console.WriteLine("23"); break;
                case 23: Console.WriteLine("24"); break;
                case 24:  Console.WriteLine("25"); break;
                case 25:  Console.WriteLine("26"); break;
                case 26:  Console.WriteLine("27"); break;
                case 27: Console.WriteLine("28"); break;
                case 28:  Console.WriteLine("29"); break;
                case 29:  Console.WriteLine("30"); break;
                case 30: Console.WriteLine("31"); break;
                case 31: Console.WriteLine("01"); break;
            }
            Console.WriteLine("");
           
            Console.Write("Ingrese el Mes... ");
            Mes = Convert.ToInt32(Console.ReadLine());
            switch (Mes)
            {
                case 1:  Console.WriteLine("de Enero"); break;
                case 2: Console.WriteLine("de Febrero"); break;
                case 3:  Console.WriteLine("de Marzo"); break;
                case 4:  Console.WriteLine("de Abril"); break;
                case 5:  Console.WriteLine("de Mayo"); break;
                case 6:  Console.WriteLine("de Junio"); break;
                case 7: Console.WriteLine("de Julio"); break;
                case 8:  Console.WriteLine("de Agosto"); break;
                case 9:  Console.WriteLine("de Setiembre"); break;
                case 10:  Console.WriteLine("de Octubre"); break;
                case 11:  Console.WriteLine("de Noviembre"); break;
                case 12:  Console.WriteLine("de Diciembre"); break;
            }
            
            if (Dia == 31 && Mes ==12)
            {
                Console.WriteLine("01 DE ENERO");
            }
            if (Dia == 28 && Mes ==1)
            {
                Console.WriteLine("01 DE FEBRERO");
            }
            if (Dia == 28 && Mes ==2)
            {
                Console.WriteLine("01 DE MARZO");
            }
            if (Dia == 31 && Mes == 3)
            {
                Console.WriteLine("01 DE ABRIL");
            }
            if (Dia==30&&Mes==4)
            {
                Console.WriteLine("01 DE MAYO");
            }
            if (Dia==31&&Mes==5)
            {
                Console.WriteLine("01 DE JUNIO");
            }
            if (Dia==30&&Mes==6)
            {
                Console.WriteLine("01 DE JULIO");
            }
            if (Dia==31&&Mes==7)
            {
                Console.WriteLine("01 AGOSTO");
            }
            if (Dia==31&&Mes==8)
            {
                Console.WriteLine("01 DE SETIEMBRE");
            }
            if (Dia==30&&Mes==9)
            {
                Console.WriteLine("01 DE OCTUBRE");
            }
            if (Dia==31&&Mes==10)
            {
                Console.WriteLine("01 DE NOVIEMBRE");
            }
            if (Dia==30&&Mes==11)
            {
                Console.WriteLine("01 DE DICIEMBRE");
            }
            //System.Convert.ToString(Dia); Convert.ToString(Mes); 
            
            Console.WriteLine("Ingrese el Año... ");
            for (Acumuladorcin =Acumuladorcin+1 ; Acumuladorcin > Año  ; Acumuladorcin++)
            {
                
                Console.ReadKey();
                Console.Write(Acumuladorcin);
                //Console.ReadKey();
            }

            //Año = Console.ReadLine();

            //Año = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();


        }
    }
}
