//https://leetcode.com/problems/pascals-triangle/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> triangle = [[1]];
        
        if(numRows == 1)
            return triangle;

        for(int i = 1; i < numRows; i++)
        {
            IList<int> prev = triangle[i - 1];
            IList<int> row = [];

            for(int j = 0; j <= i; j++)
            {  
                if(j == 0 || j == i)
                    row.Add(1);
                else
                    row.Add(prev[j - 1] + prev[j]);
            }    

            triangle.Add(row);    
        }
       
        return triangle;
    }
}