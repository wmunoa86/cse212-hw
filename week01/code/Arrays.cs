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
        // Plan:
        // 1. Create an array of type double with size 'length'.
        // 2. Loop from 0 to length - 1.
        // 3. At each position i, calculate the multiple: number * (i + 1).
        //    (i + 1) because we want to start from multiple 1, not 0.
        // 4. Store the calculated multiple at position i in the array.
        // 5. Finally, return the array with the calculated multiples.

        var multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
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
        // Plan:
        // 1. The list should be rotated to the right by 'amount' positions.
        // 2. To do this, we can take the last 'amount' elements and move them to the front.
        // 3. The remaining elements will be moved after those.
        // 4. We will use GetRange to get the parts:
        //    - lastPart: the last 'amount' elements
        //    - firstPart: the first data.Count - amount elements
        // 5. Clear the original list and then add lastPart first and then firstPart.
        // 6. This way, we modify the original list as required.

        int count = data.Count;
        if (amount <= 0 || amount > count)
            return; // Do nothing if amount is out of the valid range.

        var lastPart = data.GetRange(count - amount, amount);     // Last 'amount' elements
        var firstPart = data.GetRange(0, count - amount);         // First remaining elements

        data.Clear();                      // Clear the original list
        data.AddRange(lastPart);           // Add the right part first
        data.AddRange(firstPart);          // Add the rest at the end
    }


}
