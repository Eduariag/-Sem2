 // Из трехзначного числа убрать среднюю и оставшиеся вывести на экран

/*
int CutNumber (int num)
{
    int ed= num %10;
    int sot=num /100;
    int result= sot*10 +  ed;
    return result;
}
int RandNum= new Random().Next(100,1000);
int newNum=CutNumber(RandNum);
Console.WriteLine($" number {RandNum} is {newNum}");
*/


// Показать случайное двухзначное число и показать большую цифру

int Rand (int num)
{
    int ed=num%10;
    int ten=num/10;

    int max=ed;
    if(max<ten) max=ten;
    return max;
}
int RandNum=new Random().Next(10,100);
int NewNum=Rand (RandNum);
Console.WriteLine($" Random number: {RandNum} is high number: {NewNum}");


