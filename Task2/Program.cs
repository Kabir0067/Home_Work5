
    char CheckGrade(int grade)
    {
        char gradeLetter;

        if (grade >= 90 && grade <= 100)
        {
            gradeLetter = 'A';
        }
        else if (grade >= 80 && grade <= 89)
        {
            gradeLetter = 'B';
        }
        else if (grade >= 70 && grade <= 79)
        {
            gradeLetter = 'C';
        }
        else if (grade >= 60 && grade <= 69)
        {
            gradeLetter = 'D';
        }
        else
        {
            gradeLetter = 'F';
        }

        return gradeLetter;
    }

   
    {
        int studentGrade;
        Console.Write("Bali donishjuro doxil kuned: ");
        if (int.TryParse(Console.ReadLine(), out studentGrade))
        {
            char gradeLetter = CheckGrade(studentGrade);
            Console.WriteLine(gradeLetter);
        }
        else
        {
            Console.WriteLine("NOOO");
        }
    }

