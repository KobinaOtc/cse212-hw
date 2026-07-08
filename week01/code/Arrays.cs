public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array of doubles
        var multiples = new double [length];

        // Create a loop to go through the values number and length to create values that are multiples of the number.
        for (int i = 0; i < length; i++)
        {
            // Create a varible to hold the value of the multiple
            var multiple = number * (i + 1);

            // Add the multiple to the array
            multiples[i] = multiple;
        }

        // Return the array of multiples
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create a conditional to check if the amount is equal to the length of the data list. If it is, return the data list as is.
        if (amount == data.Count)
        {
            return;
        }

        // Create a variable to hold new rotated list
        List<int> rotatedList = new List<int> ();

        // Create a loop to go through thr values of the data list and rotate the values to the right by the amount specified.
        for (int i = 0; i < amount; i++)
        {
            rotatedList.Add(data[data.Count -  amount + i]);
        }

        // Add the remaining values to the rotated list
        for (int i = 0; i < data.Count - amount; i++)
        {
            rotatedList.Add(data[i]);
        }

        // Clear the data list and add the values from the roated list to the data list
        data.Clear();
        data.AddRange(rotatedList);
    }
}
