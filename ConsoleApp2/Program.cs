//task1
//#include <iostream>
//#include <cctype>

//int main()
//{
//    char ch;
//    std::cout << "Enter a character: ";
//    std::cin >> ch;

//    if (std::isalpha(ch))
//    {
//        std::cout << "The character is a letter." << std::endl;
//    }
//    else if (std::isdigit(ch))
//    {
//        std::cout << "The character is a digit." << std::endl;
//    }
//    else if (std::ispunct(ch))
//    {
//        std::cout << "The character is a punctuation mark." << std::endl;
//    }
//    else
//    {
//        std::cout << "The character is something else." << std::endl;
//    }

//    return 0;
//}
//task2
//#include <iostream>

//int main()
//{
//    double costPerMinute, totalCost;
//    int fromOperator, toOperator, minutes;

//    std::cout << "Enter the duration of the call in minutes: ";
//    std::cin >> minutes;
//    std::cout << "Choose the operator you are calling from (1, 2, or 3): ";
//    std::cin >> fromOperator;
//    std::cout << "Choose the operator you are calling to (1, 2, or 3): ";
//    std::cin >> toOperator;

//    if (fromOperator == 1 && toOperator == 2)
//    {
//        costPerMinute = 0.5;
//    }
//    else if (fromOperator == 1 && toOperator == 3)
//    {
//        costPerMinute = 0.7;
//    }
//    else if (fromOperator == 2 && toOperator == 1)
//    {
//        costPerMinute = 0.6;
//    }
//    else if (fromOperator == 2 && toOperator == 3)
//    {
//        costPerMinute = 0.8;
//    }
//    else if (fromOperator == 3 && toOperator == 1)
//    {
//        costPerMinute = 0.65;
//    }
//    else if (fromOperator == 3 && toOperator == 2)
//    {
//        costPerMinute = 0.75;
//    }
//    else
//    {
//        costPerMinute = 0.3;
//    }

//    totalCost = minutes * costPerMinute;
//    std::cout << "The total cost of the call is: $" << totalCost << std::endl;

//    return 0;
//}
//task3
//#include <iostream>

//int main()
//{
//    int choice;
//    double desiredIncome, actualIncome, codeLines, lateness, fine;

//    std::cout << "Menu:\n";
//    std::cout << "1. Calculate lines of code needed for desired income.\n";
//    std::cout << "2. Calculate allowed lateness for desired income.\n";
//    std::cout << "3. Calculate actual income based on code lines and lateness.\n";
//    std::cout << "Enter your choice: ";
//    std::cin >> choice;

//    switch (choice)
//    {
//        case 1:
//            std::cout << "Enter desired income: ";
//            std::cin >> desiredIncome;
//            std::cout << "Enter number of lateness: ";
//            std::cin >> lateness;
//            fine = (lateness / 3) * 20;
//            codeLines = (desiredIncome + fine) / 0.5;
//            std::cout << "Vasya needs to write " << codeLines << " lines of code." << std::endl;
//            break;

//        case 2:
//            std::cout << "Enter lines of code written: ";
//            std::cin >> codeLines;
//            std::cout << "Enter desired income: ";
//            std::cin >> desiredIncome;
//            actualIncome = codeLines * 0.5;
//            lateness = (actualIncome - desiredIncome) / 20 * 3;
//            if (lateness < 0) lateness = 0;
//            std::cout << "Vasya can be late " << lateness << " times." << std::endl;
//            break;

//        case 3:
//            std::cout << "Enter lines of code written: ";
//            std::cin >> codeLines;
//            std::cout << "Enter number of lateness: ";
//            std::cin >> lateness;
//            actualIncome = codeLines * 0.5;
//            fine = (lateness / 3) * 20;
//            actualIncome -= fine;
//            if (actualIncome <= 0)
//            {
//                std::cout << "Vasya won't get any payment." << std::endl;
//            }
//            else
//            {
//                std::cout << "Vasya will receive $" << actualIncome << std::endl;
//            }
//            break;

//        default:
//            std::cout << "Invalid choice!" << std::endl;
//            break;
//    }

//    return 0;
//}
