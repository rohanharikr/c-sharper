//https://app.codility.com/programmers/lessons/7-stacks_and_queues/nesting/

using System;
using System.Collections.Generic;

class Solution {
    public int solution(string S) {
        if(string.IsNullOrEmpty(S))
            return 1;

        Stack<char> stack = new Stack<char>();
        foreach(char c in S)
        {
            if(c == '(')
                stack.Push('(');
            else if(c == ')')
            {
                if(stack.Count > 0)
                {
                    if(stack.Peek() == '(')
                    {
                        stack.Pop();
                        continue;    
                    }
                }
                return 0;
            }
        }
        return
            stack.Count == 0 ? 1 : 0;
    }
}