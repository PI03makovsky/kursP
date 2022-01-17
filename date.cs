using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class date
{
    private int day; // день
    private int month; // месяц
    private int year; // год
}

public void init(int d, int m, int y){
    day = d;
    month = m;
    year = y;
}
public void enterD(){
   
Console.Write("Введите дату: ");
day= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите месяц: ");
month= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите год: ");
year= Convert.ToInt32(Console.ReadLine());

}
public void print(){
   Console.WriteLine($"День: {day}  Месяц: {month}  Год: {year}$");
}