#include <cs50.h>
#include <stdio.h>

int main(void)
{
    long card = get_long("Card number: ");
    int digits = 0;
    long cardTestDigits = card;

    do
    {
        cardTestDigits /= 10;
        digits++;
    }
    while (cardTestDigits != 0);

    long pos = 10;
    long pos2 = 1;
    long check = 0;
    long check2 = 0;
    long even = 0;
    int firstDigit = 0;
    int secondDigit = 0;
    for (int i = 1; i <= digits; i++)
    {
        if ((i % 2) == 0)
        {
            check = card % pos;
            check /= pos2;
            check *= 2;
            check2 = check % 10;
            even += check2;
            check2 = check % 100;
            check2 /= 10;
            even += check2;
        }
        pos *= 10;
        pos2 *= 10;
    }

    pos = 10;
    pos2 = 1;
    check = 0;

    for (int i = 1; i <= digits; i++)
    {
        if ((i % 2) == 1)
        {
            check = card % pos;
            check /= pos2;
            even += check;
        }
        pos *= 10;
        pos2 *= 10;
    }

    pos = 10;
    pos2 = 1;
    check = 0;

    for (int i = 1; i <= digits; i++)
    {
        secondDigit = firstDigit;
        check = card % pos;
        check /= pos2;
        firstDigit = check;

        pos *= 10;
        pos2 *= 10;
    }

    if ((even % 10) == 0)
    {
        if (digits == 15 && (((firstDigit == 3) && (secondDigit == 4)) ||
                             ((firstDigit == 3) && (secondDigit == 7))))
        {
            printf("AMEX\n");
        }
        else if (digits == 16 && (((firstDigit == 5) && (secondDigit == 1)) ||
                                  ((firstDigit == 5) && (secondDigit == 3)) ||
                                  ((firstDigit == 5) && (secondDigit == 4)) ||
                                  ((firstDigit == 5) && (secondDigit == 5))))
        {
            printf("MASTERCARD\n");
        }
        else if ((digits == 13 || digits == 16) && ((firstDigit == 4)))
        {
            printf("VISA\n");
        }
        else
        {
            printf("INVALID\n");
        }
    }
    else
    {
        printf("INVALID\n");
    }
}
