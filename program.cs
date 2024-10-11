using System;

string? userInput;
bool wrongSelection = false;
decimal output = 0m;
string phrase = "";

// Get choice on what to convert
do
{
    Console.Clear();
    wrongSelection = false;
    Console.WriteLine("Welcome to the unit conversion program.");
    Console.WriteLine("Choose one of the options below:");
    Console.WriteLine("1. length conversion");
    Console.WriteLine("2. volume conversion");
    Console.WriteLine("3. currency conversion");
    Console.WriteLine("4. area conversion \n");
    Console.WriteLine("Or type exit to exit the program");
    userInput = Console.ReadLine();

    if (string.IsNullOrEmpty(userInput))
    {
        Console.WriteLine("Please Enter a valid number");
        Thread.Sleep(800);
        wrongSelection = true;
        continue;
    }

    userInput.ToLower().Trim();

    if (userInput != "exit" && userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
    {
        Console.WriteLine("Please Enter a valid number");
        Thread.Sleep(800);
        wrongSelection = true;
    }
} while ((userInput == null && userInput != "exit") || wrongSelection == true);

//Get User Input (numbers) and call methods
userInput.Trim().ToLower();

switch (userInput)
{
    case "1":
        LengthConversion();
        break;

    case "2":
        VolumeConversion();
        break;

    case "3":
        CurrencyConversion();
        break;

    case "4":
        AreaConversion();
        break;
}

//Create conversion methods
void LengthConversion()
{
    string? convertFromSelection;
    string? convertToSelection;
    string? userValue;

    do
    {
        Console.Clear();
        wrongSelection = false;
        Console.WriteLine("Convert from:");
        Console.WriteLine("1. meter");
        Console.WriteLine("2. kilometer");
        Console.WriteLine("3. cm");
        Console.WriteLine("4. foot");

        convertFromSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertFromSelection) || (convertFromSelection != "1" && convertFromSelection != "2" && convertFromSelection != "3" && convertFromSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertFromSelection == null || wrongSelection == true);

    do
    {
        wrongSelection = false;
        Console.WriteLine("Convert to:");
        Console.WriteLine("1. meter");
        Console.WriteLine("2. kilometer");
        Console.WriteLine("3. cm");
        Console.WriteLine("4. foot");

        convertToSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertToSelection) || (convertToSelection != "1" && convertToSelection != "2" && convertToSelection != "3" && convertToSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertToSelection == null || wrongSelection == true);

    Console.WriteLine("Write the value to convert");
    userValue = Console.ReadLine();

    if (userValue != null)
    {
        userValue.Trim().ToLower();
    }

    if (!decimal.TryParse(userValue, out decimal convertedValue) || convertedValue < 0)
    {
        Console.WriteLine("Value can't be converted, try again.");
        return;
    }

    string addedSelection = convertFromSelection + convertToSelection;

    switch (addedSelection)
    {
        case "12":
            output = convertedValue / 1000m;
            phrase = $"Your value of {convertedValue:0.0}m equals {output:0.0}km";
            break;

        case "13":
            output = convertedValue * 100m;
            phrase = $"Your value of {convertedValue:0.0}m equals {output:0}cm";
            break;

        case "14":
            output = convertedValue * 3.281m;
            phrase = $"Your value of {convertedValue:0.0}m equals {output:0.0}ft";
            break;

        case "21":
            output = convertedValue * 1000m;
            phrase = $"Your value of {convertedValue:0.0}km equals {output:0.0}m";
            break;

        case "23":
            output = convertedValue * 100000m;
            phrase = $"Your value of {convertedValue:0.0}km equals {output:0}cm";
            break;

        case "24":
            output = convertedValue * 3281m;
            phrase = $"Your value of {convertedValue:0.0}km equals {output:0.0}ft";
            break;

        case "31":
            output = convertedValue * 0.01m;
            phrase = $"Your value of {convertedValue:0}cm equals {output:0.0}m";
            break;

        case "32":
            output = convertedValue / 100000m;
            phrase = $"Your value of {convertedValue:0}cm equals {output:0.0}km";
            break;

        case "34":
            output = convertedValue / 30.48m;
            phrase = $"Your value of {convertedValue:0}cm equals {output:0.0}ft";
            break;

        case "41":
            output = convertedValue / 3.281m;
            phrase = $"Your value of {convertedValue:0.0}ft equals {output:0.0}m";
            break;

        case "42":
            output = convertedValue / 3281m;
            phrase = $"Your value of {convertedValue:0.0}ft equals {output:0.0}km";
            break;

        case "43":
            output = convertedValue * 30.48m;
            phrase = $"Your value of {convertedValue:0.0}ft equals {output:0}cm";
            break;

        default:
            output = convertedValue;
            phrase = $"Your chose the same units, therefor your input ({output:0.0}) remains the same";
            break;
    }
    Console.WriteLine(phrase);
}

void VolumeConversion()
{
    string? convertFromSelection;
    string? convertToSelection;
    string? userValue;

    do
    {
        Console.Clear();
        wrongSelection = false;
        Console.WriteLine("Convert from:");
        Console.WriteLine("1. ml");
        Console.WriteLine("2. l");
        Console.WriteLine("3. cm³");
        Console.WriteLine("4. m³");
        Console.WriteLine("5. gallon");

        convertFromSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertFromSelection) || (convertFromSelection != "1" && convertFromSelection != "2" && convertFromSelection != "3" && convertFromSelection != "4" && convertFromSelection != "5"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertFromSelection == null || wrongSelection == true);

    do
    {
        wrongSelection = false;
        Console.WriteLine("Convert to:");
        Console.WriteLine("1. ml");
        Console.WriteLine("2. l");
        Console.WriteLine("3. cm³");
        Console.WriteLine("4. m³");
        Console.WriteLine("5. gallon");

        convertToSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertToSelection) || (convertToSelection != "1" && convertToSelection != "2" && convertToSelection != "3" && convertToSelection != "4" && convertToSelection != "5"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertToSelection == null || wrongSelection == true);

    Console.WriteLine("Write the value to convert");
    userValue = Console.ReadLine();

    if (userValue != null)
    {
        userValue.Trim().ToLower();
    }

    if (!decimal.TryParse(userValue, out decimal convertedValue) || convertedValue < 0)
    {
        Console.WriteLine("Value can't be converted, try again.");
        return;
    }

    string addedSelection = convertFromSelection + convertToSelection;

    switch (addedSelection)
    {
        case "12":
            output = convertedValue / 1000m;
            phrase = $"Your value of {convertedValue:0}ml equals {output:0.0}l";
            break;

        case "13":
            output = convertedValue;
            phrase = $"Your value of {convertedValue:0}ml equals {output:0}cm³";
            break;

        case "14":
            output = convertedValue / 1000000m;
            phrase = $"Your value of {convertedValue:0}ml equals {output:0.000}m³";
            break;

        case "15":
            output = convertedValue / 3785m;
            phrase = $"Your value of {convertedValue:0}ml equals {output:0.0}gallons";
            break;

        case "21":
            output = convertedValue * 1000m;
            phrase = $"Your value of {convertedValue:0.0}l equals {output:0}ml";
            break;

        case "23":
            output = convertedValue * 1000m;
            phrase = $"Your value of {convertedValue:0.0}l equals {output:0}cm³";
            break;

        case "24":
            output = convertedValue / 1000m;
            phrase = $"Your value of {convertedValue:0.0}l equals {output:0.000}m³";
            break;

        case "25":
            output = convertedValue / 3.785m;
            phrase = $"Your value of {convertedValue:0.0}l equals {output:0.0}gallons";
            break;

        case "31":
            output = convertedValue;
            phrase = $"Your value of {convertedValue:0}cm³ equals {output:0}ml";
            break;

        case "32":
            output = convertedValue / 1000m;
            phrase = $"Your value of {convertedValue:0}cm³ equals {output:0.0}l";
            break;

        case "34":
            output = convertedValue / 1000000m;
            phrase = $"Your value of {convertedValue:0}cm³ equals {output:0.000}m³";
            break;

        case "35":
            output = convertedValue / 3785m;
            phrase = $"Your value of {convertedValue:0}cm³ equals {output:0.0}gallons";
            break;

        case "41":
            output = convertedValue * 1000000m;
            phrase = $"Your value of {convertedValue:0.0}m³ equals {output:0}ml";
            break;

        case "42":
            output = convertedValue * 1000m;
            phrase = $"Your value of {convertedValue:0.0}m³ equals {output:0.0}l";
            break;

        case "43":
            output = convertedValue * 1000000m;
            phrase = $"Your value of {convertedValue:0.0}m³ equals {output:0}cm³";
            break;

        case "45":
            output = convertedValue * 264.2m;
            phrase = $"Your value of {convertedValue:0.0}m³ equals {output:0.0}gallons";
            break;

        case "51":
            output = convertedValue * 3785m;
            phrase = $"Your value of {convertedValue:0.0}gallons equals {output:0}ml";
            break;

        case "52":
            output = convertedValue * 3.785m;
            phrase = $"Your value of {convertedValue:0.0}gallons equals {output:0.0}l";
            break;

        case "53":
            output = convertedValue * 3785m;
            phrase = $"Your value of {convertedValue:0.0}gallons equals {output:0}cm³";
            break;

        case "54":
            output = convertedValue / 264.2m;
            phrase = $"Your value of {convertedValue:0.0}gallons equals {output:0.000}m³";
            break;
        default:
            output = convertedValue;
            phrase = $"Your chose the same units, therefor your input ({output:0.0}) remains the same";
            break;
    }
    Console.WriteLine(phrase);
}

void CurrencyConversion()
{
    string? convertFromSelection;
    string? convertToSelection;
    string? userValue;

    do
    {
        Console.Clear();
        wrongSelection = false;
        Console.WriteLine("Convert from:");
        Console.WriteLine("1. USD");
        Console.WriteLine("2. Euro");
        Console.WriteLine("3. Pound sterling");
        Console.WriteLine("4. MAD");

        convertFromSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertFromSelection) || (convertFromSelection != "1" && convertFromSelection != "2" && convertFromSelection != "3" && convertFromSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertFromSelection == null || wrongSelection == true);

    do
    {
        wrongSelection = false;
        Console.WriteLine("Convert to:");
        Console.WriteLine("1. USD");
        Console.WriteLine("2. Euro");
        Console.WriteLine("3. Pound sterling");
        Console.WriteLine("4. MAD");

        convertToSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertToSelection) || (convertToSelection != "1" && convertToSelection != "2" && convertToSelection != "3" && convertToSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertToSelection == null || wrongSelection == true);

    Console.WriteLine("Write the value to convert");
    userValue = Console.ReadLine();

    if (userValue != null)
    {
        userValue.Trim().ToLower();
    }

    if (!decimal.TryParse(userValue, out decimal convertedValue) || convertedValue < 0)
    {
        Console.WriteLine("Value can't be converted, try again.");
        return;
    }

    string addedSelection = convertFromSelection + convertToSelection;

    switch (addedSelection)
    {
        case "12":
            output = convertedValue * 0.914m;
            phrase = $"The value of {convertedValue:0.0}$ currently is {output:0.0}€";
            break;

        case "13":
            output = convertedValue * 0.7659m;
            phrase = $"The value of {convertedValue:0.0}$ currently is {output:0.0}£";
            break;

        case "14":
            output = convertedValue * 9.8126m;
            phrase = $"The value of {convertedValue:0.0}$ currently is {output:0.0}MAD";
            break;

        case "21":
            output = convertedValue * 1.0932m;
            phrase = $"The value of {convertedValue:0.0}€ currently is {output:0.0}$";
            break;

        case "23":
            output = convertedValue * 0.8371m;
            phrase = $"The value of {convertedValue:0.0}€ currently is {output:0.0}£";
            break;

        case "24":
            output = convertedValue * 10.7278m;
            phrase = $"The value of {convertedValue:0.0}€ currently is {output:0.0}MAD";
            break;

        case "31":
            output = convertedValue * 1.3059m;
            phrase = $"The value of {convertedValue:0.0}£ currently is {output:0.0}$";
            break;

        case "32":
            output = convertedValue * 1.1946m;
            phrase = $"The value of {convertedValue:0.0}£ currently is {output:0.0}€";
            break;

        case "34":
            output = convertedValue * 12.8165m;
            phrase = $"The value of {convertedValue:0.0}£ currently is {output:0.0}MAD";
            break;

        case "41":
            output = convertedValue * 0.101902m;
            phrase = $"The value of {convertedValue:0.0}MAD currently is {output:0.0}$";
            break;

        case "42":
            output = convertedValue * 0.09321m;
            phrase = $"The value of {convertedValue:0.0}MAD currently is {output:0.0}€";
            break;

        case "43":
            output = convertedValue * 0.07801m;
            phrase = $"The value of {convertedValue:0.0}MAD currently is {output:0.0}£";
            break;

        default:
            output = convertedValue;
            phrase = $"Your chose the same units, therefor your input ({output:0.0}) remains the same";
            break;
    }
    Console.WriteLine(phrase);
    Console.WriteLine("Values are lastly updated on 11/10/2024.");
}

void AreaConversion()
{
    string? convertFromSelection;
    string? convertToSelection;
    string? userValue;

    do
    {
        Console.Clear();
        wrongSelection = false;
        Console.WriteLine("Convert from:");
        Console.WriteLine("1. m² (Centiare)");
        Console.WriteLine("2. km²");
        Console.WriteLine("3. hm² (Hectare)");
        Console.WriteLine("4. dam² (Are)");

        convertFromSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertFromSelection) || (convertFromSelection != "1" && convertFromSelection != "2" && convertFromSelection != "3" && convertFromSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertFromSelection == null || wrongSelection == true);

    do
    {
        wrongSelection = false;
        Console.WriteLine("Convert to:");
        Console.WriteLine("1. m² (Centiare)");
        Console.WriteLine("2. km²");
        Console.WriteLine("3. hm² (Hectare)");
        Console.WriteLine("4. dam² (Are)");

        convertToSelection = Console.ReadLine();
        if (string.IsNullOrEmpty(convertToSelection) || (convertToSelection != "1" && convertToSelection != "2" && convertToSelection != "3" && convertToSelection != "4"))
        {
            Console.WriteLine("Please enter a valid choice");
            Thread.Sleep(800);
            wrongSelection = true;
            continue;
        }
    } while (convertToSelection == null || wrongSelection == true);

    Console.WriteLine("Write the value to convert");
    userValue = Console.ReadLine();

    if (userValue != null)
    {
        userValue.Trim().ToLower();
    }

    if (!decimal.TryParse(userValue, out decimal convertedValue) || convertedValue < 0)
    {
        Console.WriteLine("Value can't be converted, try again.");
        return;
    }

    string addedSelection = convertFromSelection + convertToSelection;

    switch (addedSelection)
    {
        case "12":
            output = convertedValue / 1000000m;
            phrase = $"Your value of {convertedValue:0.0}m² equals {output:0.0}km²";
            break;

        case "13":
            output = convertedValue / 10000m;
            phrase = $"Your value of {convertedValue:0.0}m² equals {output:0}hm²";
            break;

        case "14":
            output = convertedValue * 0.01m;
            phrase = $"Your value of {convertedValue:0.0}m² equals {output:0.0}dam²";
            break;

        case "21":
            output = convertedValue * 1000000m;
            phrase = $"Your value of {convertedValue:0.0}km² equals {output:0.0}m²";
            break;

        case "23":
            output = convertedValue * 100m;
            phrase = $"Your value of {convertedValue:0.0}km² equals {output:0}hm²";
            break;

        case "24":
            output = convertedValue * 10000m;
            phrase = $"Your value of {convertedValue:0.0}km² equals {output:0.0}dam²";
            break;

        case "31":
            output = convertedValue * 10000m;
            phrase = $"Your value of {convertedValue:0}hm² equals {output:0.0}m²";
            break;

        case "32":
            output = convertedValue * 0.01m;
            phrase = $"Your value of {convertedValue:0}hm² equals {output:0.0}km²";
            break;

        case "34":
            output = convertedValue * 100m;
            phrase = $"Your value of {convertedValue:0}hm² equals {output:0.0}dam²";
            break;

        case "41":
            output = convertedValue * 100m;
            phrase = $"Your value of {convertedValue:0.0}dam² equals {output:0.0}m²";
            break;

        case "42":
            output = convertedValue / 10000m;
            phrase = $"Your value of {convertedValue:0.0}dam² equals {output:0.0}km²";
            break;

        case "43":
            output = convertedValue * 0.01m;
            phrase = $"Your value of {convertedValue:0.0}dam² equals {output:0}hm²";
            break;

        default:
            output = convertedValue;
            phrase = $"Your chose the same units, therefor your input ({output:0.0}) remains the same";
            break;
    }
    Console.WriteLine(phrase);
}