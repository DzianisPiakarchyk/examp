Console.Clear();


int x_a=70;
int y_a=1;
int x_b=1;
int y_b=22;
int x_c=140;
int y_c=22;

Console.SetCursorPosition(x_a, y_a);
Console.WriteLine("+");

Console.SetCursorPosition(x_b, y_b);
Console.WriteLine("+");

Console.SetCursorPosition(x_c, y_c);
Console.WriteLine("+");

int x=x_a, y=y_a;

int count=0;

while(count<10000)
{
    int what = new Random().Next(0,3);

    if(what ==0)
    {
        x=(x+x_a)/2;
        y=(y+y_a)/2;
    }

     if(what ==1)
    {
        x=(x+x_b)/2;
        y=(y+y_b)/2;
    }

     if(what ==2)
    {
        x=(x+x_c)/2;
        y=(y+y_c)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count ++;
}