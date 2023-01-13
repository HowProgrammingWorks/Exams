﻿#include <stdio.h>
#include <conio.h>
#include <windows.h>
const int KP_8=56, KP_4=52, KP_2=50, KP_6=54;
const int ENTER = 13,F=102,H=104;
const int mine = 9;
void HelpMenu() {
    system("cls");
    printf("\t\tEnter - Взаємодія з полем\n\t\tF - Поставити флаг\n\t\tУПРАВЛІННЯ:\n\t\t 8  \n\t\t4 6 \t \n\t\t 2\n");
    system("pause");
}
void GameStart(int MinesCount, int ** FieldMines,int ** FieldView,int Height, int Width) {
    int End = 1, i = 0, j = 0, iO = 0, jO = 0;
    int MinesLeft = MinesCount, MinesStat = MinesCount, Flags = MinesCount, Cursor = 0;
    system("cls");
    do { 
        system("cls");
        printf("\tКількість флажків: %d\t Кількість мін: %d; H - Допомогти\n\n",Flags,MinesStat);
        for (i = 0; i <Height; i++) {
            printf("\t\t\t");
            for (j = 0; j < Width; j++) {
                switch (FieldView[i][j]) {
                case -1: printf(" "); break;
                case -2: printf("-"); break;
                case 10: printf("/"); break;
                case 11:printf("P"); break;
                case 0: printf("0"); break;
                default: printf("%d", FieldView[i][j]); break;
                }
            }
            printf("\n");
        }
        Cursor = _getch();
        switch (Cursor) {
        case KP_8:
            if (iO > 0) {
                iO--;
                if (FieldView[iO + 1][jO] <=-1)FieldView[iO + 1][jO] = 0;
             }else iO = 0; 
             if(FieldView[iO][jO] == 0)FieldView[iO][jO] = -1;  break;

        case KP_2:
            if (iO < Height -1) {
                iO++;
                if (FieldView[iO - 1][jO] <= -1)FieldView[iO - 1][jO] = 0;
            }else iO = Height -1; 
            if (FieldView[iO][jO] == 0)FieldView[iO][jO] = -1;
            break;

        case KP_4:
            if (jO > 0) {
                jO--;
                if (FieldView[iO][jO + 1] <= -1)FieldView[iO][jO + 1] = 0;
            }else jO = 0; 
            if (FieldView[iO][jO] == 0)FieldView[iO][jO] = -1; break;

        case KP_6:
            if (jO <Width -1) {
                jO++;
                if(FieldView[iO][jO-1] <= -1)FieldView[iO][jO-1] = 0;
            } else jO = Width -1; 
            if (FieldView[iO][jO] == 0) FieldView[iO][jO] = -1; break;

        case ENTER: if (FieldMines[iO][jO] != mine) {
            if (FieldView[iO][jO] != 11) { FieldMines[iO][jO] == 0 ? FieldView[iO][jO] = 10 : FieldView[iO][jO] = FieldMines[iO][jO]; }
        }else {
            system("cls");
            for (i = 0; i <Height;i++) {
                printf("\t\t\t");
                for (j = 0; j < Width; j++) {
                    if (FieldMines[i][j] == mine) {
                        printf("*");
                    }
                    else {
                        printf("0");
                    } 
                }
                printf("\n");
            }
            printf("\t\tКАБУМ!!!!!!\n\t\tВаш рекорд: %d\n", MinesCount); End = 0; system("pause");
        } break;
        case F:if (FieldView[iO][jO] == -1 ) {
            if (FieldMines[iO][jO] == mine) {
                MinesCount--; Flags--; FieldView[iO][jO] = 11;
            }else {
                Flags--;
                FieldView[iO][jO] = 11;
            }
        }else if(FieldView[iO][jO] == 11){
            FieldView[iO][jO] = -1;
            Flags++;
            if (FieldMines[iO][jO] == 9) {
                MinesCount++;
            }
        } break;
        case H:HelpMenu(); break;
        } 
        if (MinesCount == 0) {
            End = 0;
            system("cls");
            printf("\t\tПЕРЕМОГА!!! ВИ ЗМОГЛИ!!!\n");
            system("pause");
       }
    } while (End);
}
void FieldFilling(int Difficulty, int Height, int Width) {
    int i = 0, j = 0;
    int MinesLeft = 0, Flags = 0;
    system("cls");
    Flags = MinesLeft = Height * Width * (Difficulty / 100.0);
    int** Playground;
    int** PlaygroundOn;
    Playground = (int**)malloc(Height * sizeof(int*));
    PlaygroundOn = (int**)malloc(Height * sizeof(int*));
    for (i = 0; i < Height; i++)
    {
        Playground[i] = (int*)malloc(Width * sizeof(int));
        PlaygroundOn[i] = (int*)malloc(Width * sizeof(int));
        for (j = 0; j < Width; j++)
        {
            Playground[i][j] = 0;
            PlaygroundOn[i][j] = 0;
        }
    }
    PlaygroundOn[0][0] = -1;
    do {
        i = rand() % Height; j = rand() % Width;
        if ((Playground[i][j] >= 0 && Playground[i][j] <= mine - 1) && Playground[i][j] != mine) {
            Playground[i][j] = mine;
            if (((i + 1) < Height) && Playground[i + 1][j] != mine) { Playground[i + 1][j] += 1; }
            if (((i - 1) >= 0) && Playground[i - 1][j] != mine) { Playground[i - 1][j] += 1; }
            if (((j - 1) >= 0) && Playground[i][j - 1] != mine) { Playground[i][j - 1] += 1; }
            if (((j + 1) < Width) && Playground[i][j + 1] != mine) { Playground[i][j + 1] += 1; }
            if (((i - 1) >= 0) && ((j - 1) >= 0) && Playground[i - 1][j - 1] != mine) { Playground[i - 1][j - 1] += 1; }
            if (((i + 1) < Height) && ((j + 1) < Width) && Playground[i + 1][j + 1] != mine) { Playground[i + 1][j + 1] += 1; }
            if (((i - 1) >= 0) && ((j + 1) < Width) && Playground[i - 1][j + 1] != mine) { Playground[i - 1][j + 1] += 1; }
            if (((i + 1) < Height) && ((j - 1) >= 0) && Playground[i + 1][j - 1] != mine) { Playground[i + 1][j - 1] += 1; }
            MinesLeft--;
        }
    } while (MinesLeft != 0);
    GameStart(Flags, Playground, PlaygroundOn, Height, Width);
    for (i = 0; i < Height; i++) {
        free(PlaygroundOn[i]);
        free(Playground[i]);
    }
    free(PlaygroundOn);
    free(Playground);
}
void FieldSize(int Difficulty) {
    int Height = 0, Width = 0;
 do {
        system("cls");
        printf("\t\tРозмірність поля:\n\n");
        printf("\tВведіть висоту поля: "); scanf_s("%d", &Height);
        printf("\tВведіть ширину поля: "); scanf_s("%d", &Width);
    } while (Height < 2 || Width < 2);
    FieldFilling(Difficulty, Height, Width);
}
int DifficultyMenu() {
    int Diffuculty = 0,MenuChoose = 0,MenuOption = 0;
    int Exit = 1;
    system("cls");
    do {
        printf("\t\tВиберіть рівень складності:\n\n");
        switch (1) {
        case 1:MenuOption == 0 ? printf("\t> Легко\n"):       printf("\tЛегко\n");
        case 2:MenuOption == 1 ? printf("\t> Середнє\n") : printf("\tСереднє\n");
        case 3:MenuOption == 2 ? printf("\t> Важко\n") : printf("\tВажко\n");
        case 4:MenuOption == 3 ? printf("\t> Хардкор\n") : printf("\tХардкор\n");
        case 5:MenuOption == 4 ? printf("\t> Налаштувати\n") : printf("\tНалаштувати\n");
        case 6:MenuOption == 5 ? printf("\t> Назад\n") : printf("\tНазад\n");
        }
        MenuChoose = _getch();
        switch (MenuChoose) {
        case KP_8: MenuOption > 0 ? MenuOption-- : MenuOption = 5; break;
        case KP_2 :MenuOption < 5 ? MenuOption++ : MenuOption = 0; break;
        case ENTER:
            switch (MenuOption) {
            case 0: Diffuculty = 15; break;
            case 1: Diffuculty = 25; break;
            case 2: Diffuculty = 50; break;
            case 3: Diffuculty = 75; break;
            case 4:
                do {
                    system("cls");
                    printf("\t\tВведіть відсоток заповненості поля мінами: ");
                    scanf_s("%d", &Diffuculty);
                } while (Diffuculty > 99 || Diffuculty <= 0);
                break;
            case 5: return 0; break;
            }; Exit = 0; break;
        }
        system("cls");
    } while (Exit);
    FieldSize(Diffuculty);
}
void MenuHello() {
    int MenuChoose = 0, MenuOption = 0;
    int Exit = 1;
    do {
        printf("\t\tСАПЕР V 0.0.4. BETA \n\n");
        switch (1) {
        case 1:  MenuOption == 0 ?  printf("\t> Нова гра\n"):printf("\tНова гра\n");
        case 2:  MenuOption == 1 ? printf("\t> Допомога\n") : printf("\tДопомога\n");
        case 3:  MenuOption == 2 ? printf("\t> Вихід\n"):  printf("\tВихід\n");}
        MenuChoose = _getch();
        switch (MenuChoose) {
        case KP_8: MenuOption > 0 ? MenuOption-- : MenuOption = 2; break;
        case KP_2:MenuOption < 2 ? MenuOption++ : MenuOption = 0; break;
        case ENTER:
            switch (MenuOption) {
            case 0:DifficultyMenu(); break;
            case 1:HelpMenu(); break;
            case 2:Exit = 0; break;
            }
            break;
        }
        system("cls");
    }while(Exit); 
    printf("\tДо зустрічі!\n");
}
int main() {
    SetConsoleOutputCP(1251);
    MenuHello();
}