#include <cs50.h>
#include <stdio.h>

void spaces(int n);
void blocks(int n);

int main(void)
{
    int n;
    do
    {
        n = get_int("Height: ");
    }
    while (n < 1 || n > 8);

    for (int i = 1; i <= n; i++)
    {
        spaces(n - i);
        blocks(i);
        spaces(2);
        blocks(i);
        printf("\n");
    }
}

void spaces(int n)
{
    for (int i = 0; i < n; i++)
    {
        printf(" ");
    }
}

void blocks(int n)
{
    for (int i = 0; i < n; i++)
    {
        printf("#");
    }
}
