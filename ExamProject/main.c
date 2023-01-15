#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <windows.h>
#include <math.h>

#define  width 65
#define height 25

typedef struct
{
    int x,y;
    int w;
} TRacket;

typedef struct
{
    float x,y;
    int ix,iy;
    float alfa;
    float speed;
} TBall;

char mas[height][width+1];
TRacket racket;
TBall ball;
int hitCnt = 0;
int maxHitCnt = 0;

void moveBall (float x, float y)
{
    ball.x = x;
    ball.y = y;
    ball.ix = (int)round(ball.x);
    ball.iy = (int)round(ball.y);
}

void initBall()
{
    moveBall(2,2);
    ball.alfa = -1;
    ball.speed = 0.5;
}

void putBall ()
{
    mas[ball.iy][ball.ix] = '*';
}

void autoMoveBall()
{
    if (ball.alfa < 0) ball.alfa += M_PI*2;
    if(ball.alfa > M_PI*2) ball.alfa -= M_PI*2;

    TBall bl= ball;
    moveBall(ball.x + cos(ball.alfa) * ball.speed,
             ball.y + sin(ball.alfa)* ball.speed);

    if ((mas[ball.iy][ball.ix]== '#') ||   (mas[ball.iy][ball.ix]== '@'))
    {
        if (mas[ball.iy][ball.ix]== '@')
            hitCnt++;
        if(ball.ix != bl.ix && (ball.iy != bl.iy))
        {
            if (mas[bl.iy][ball.ix]== mas[ball.iy][bl.ix])
                bl.alfa = bl.alfa + M_PI;
            else
            {
                if (mas[bl.iy][ball.ix]== '#')
                    bl.alfa = (2*M_PI - bl.alfa)+ M_PI;
                else
                    bl.alfa = (2*M_PI - bl.alfa);
            }
        }
        else if (ball.iy == bl.iy)
            bl.alfa = (2*M_PI - bl.alfa)+ M_PI;
        else
            bl.alfa = (2*M_PI - bl.alfa);

        ball = bl;
        autoMoveBall();
    }
}

void initRacket()
{
    racket.w = 7;
    racket.x = (width - racket.w)/2;
    racket.y = height - 1;
}

void PutRacket()
{
    for(int i=racket.x; i<racket.x +racket.w; i++)
        mas[racket.y][i]= '@';
}

void init()
{
    for(int i=0; i<width; i++)
        mas[0][i] = '#';
    mas[0][width]='\0';

    strncpy(mas[1],mas[0], width+1);
    for(int i=1; i<width-1; i++)
        mas[1][i] = ' ';

    for(int i=2; i<height; i++)
        strncpy(mas[i],mas[1],width+1);

    for(int i=13; i<20; i++)
        mas[12][i] = '#';

    for(int i=22; i<30; i++)
        mas[5][i] = '#';

    for(int i=50; i<60; i++)
        mas[9][i] = '#';
}

void show()
{
    for(int i=0; i<height; i++)
    {
        printf("%s", mas[i]);
        if(i == 3)
            printf ("   hit %i", hitCnt);
        if(i == 4)
            printf ("   max %i",maxHitCnt);

        if (i < height - 1)
            printf("\n");
    }
}

void moveRacket(int x)
{
    racket.x = x;
    if (racket.x < 1)
        racket.x = 1;
    if (racket.x + racket.w >= width)
        racket.x= width - 1 - racket.w;
}

void setcur(int x, int y )
{
    COORD coord;
    coord.X = x;
    coord.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}

int main()
{
    char c;
    BOOL run = FALSE;
    initRacket();
    initBall();

    do
    {
        setcur(0,0);
        if (run)
            autoMoveBall();
        if (ball.iy > height)
        {
            run = FALSE;
            if (hitCnt > maxHitCnt)
                maxHitCnt = hitCnt;
            hitCnt = 0;
        }
        init();
        PutRacket();
        putBall();
        show();

        if (GetKeyState('A') < 0) moveRacket(racket.x - 1);
        if (GetKeyState('D') < 0) moveRacket(racket.x + 1);
        if (GetKeyState('W') < 0) run = TRUE;
        if(!run)
            moveBall(racket.x + racket.w / 2, racket.y - 1);
        Sleep(10);
    }
    while (GetKeyState(VK_ESCAPE) >= 0);
    return 0;
}
