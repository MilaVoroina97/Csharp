//Console.SetCursorPosition(10,4); // отступ от левого края 10, отступ от верхного края 4 символа
//Console.WriteLine("+");

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;
Console.SetCursorPosition(xa, ya); 
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb); 
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc); 
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0; //счетчик, который определяет какое кол-во раз нужно будет проделать, чтобы найти отрезки и поделить их пополам

while (count < 10000)
{
    int one = new Random().Next(0,3); // для определения трех случайных точек построения треугольника
    if(one == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (one == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (one == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y); 
    Console.WriteLine("+");
    count++;
}
