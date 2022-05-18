using System;
using System.Collections.Generic;
using System.Text;


//Another solution is to use a stack with the importance of order of operations
namespace Calc2
{
    class calculator
    {
		public static int Calculation(string expr)
		{
			if (ValidParentheses(expr) == false)
				throw new System.NotSupportedException("Not Valid parentheses!!!");

			char[] ch = expr.ToCharArray();

			Stack<int> nums = new Stack<int>();
			Stack<char> ops = new Stack<char>();

			for (int i = 0; i < ch.Length; i++)
			{
				//if current char is a whitespace skip it
				if (ch[i] == ' ')
					continue;

				// if current char is a number, push it to stack nums
				if (ch[i] >= '0' && ch[i] <= '9')
				{
					StringBuilder st = new StringBuilder();

					// if number is more than 1 digit
					while (i < ch.Length && ch[i] >= '0' && ch[i] <= '9')
						st.Append(ch[i++]);

					nums.Push(int.Parse(st.ToString()));

					// Right now the i points to the character next to the digit, since the for loop also increases the i, we would skip one char position; we need to decrease the value of i by 1 to correct the offset.
					i--;
				}

				// if Current char is an opening brace, push it to 'ops'
				else if (ch[i] == '(')
					ops.Push(ch[i]);

				// Closing brace encountered, solve entire brace
				else if (ch[i] == ')')
				{
					while (ops.Peek() != '(')
						nums.Push(ActivationOp(ops.Pop(), nums.Pop(), nums.Pop()));

					ops.Pop();
				}

				// Current char is operator.
				else if (ch[i] == '+' || ch[i] == '-' || ch[i] == 'X' || ch[i] == '/')
				{

					// While top of 'ops' has same or greater precedence to current char, which is an operator. Apply operator on top of 'ops' to top two elements in values stack
					while (ops.Count > 0 && previous(ch[i], ops.Peek()))
						nums.Push(ActivationOp(ops.Pop(), nums.Pop(), nums.Pop()));

					// Push current char to 'ops'.
					ops.Push(ch[i]);
				}
			}

			// Entire expression has been parsed at this point, apply remaining ops to remaining nums
			while (ops.Count > 0)
				nums.Push(ActivationOp(ops.Pop(), nums.Pop(), nums.Pop()));

			// Top of 'nums' contains result, return it
			return nums.Pop();
		}

		//Check for balanced brackets
		private static bool ValidParentheses(String s)
		{
			Stack<char> brace = new Stack<char>();
			foreach (var curr in s)
			{
				switch (curr)
				{
					case '(':
						brace.Push(')');
						break;
					case '[':
						brace.Push(']');
						break;
					case '{':
						brace.Push('}');
						break;
					case ')':
					case ']':
					case '}':
						if (brace.Count == 0 || brace.Pop() != curr)
							return false;
						break;

				}
			}

			return brace.Count == 0;
		}


		// Returns true if 'op2' has higher or same precedence as 'op1', otherwise returns false.
		private static bool previous(char op1, char op2)
		{
			if (op2 == '(' || op2 == ')')
				return false;

			if ((op1 == 'X' || op1 == '/') && (op2 == '+' || op2 == '-'))
				return false;

			else
				return true;
		}

		//Activation operator
		private static int ActivationOp(char op, int n1, int n2)
		{
			switch (op)
			{
				case '+':
					return n2 + n1;
				case '-':
					return n2 - n1;
				case 'X':
					return n2 * n1;
				case '/':
					if (n1 == 0)
						throw new System.NotSupportedException("Can not divide by zero!!!");
					return n2 / n1;
			}
			return 0;
		}

	}
}
