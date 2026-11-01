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
        // Step 1: Create an array of doubles with the specified size 'length'.
        // Step 2: Loop from index 0 up to length - 1.
        // Step 3: At each index i, calculate the multiple as number * (i + 1).
        // Step 4: Assign the calculated value to the corresponding array index.
        // Step 5: Return the populated array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
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
        // Step 1: Calculate the starting index of the slice to move, which is (data.Count - amount).
        // Step 2: Use GetRange to extract the last 'amount' elements into a temporary list.
        // Step 3: Remove those last 'amount' elements from the end of the original list using RemoveRange.
        // Step 4: Insert the extracted slice at the very beginning (index 0) using InsertRange.

        int startIndex = data.Count - amount;
        List<int> slice = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);
        data.InsertRange(0, slice);
    }
}
