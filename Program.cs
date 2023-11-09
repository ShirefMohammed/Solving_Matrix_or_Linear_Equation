namespace Solving_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// get matrix rows and coulmns number
			Console.Write("enter rows: ");
			int m = int.Parse(Console.ReadLine());

			Console.Write("enter columns: ");
			int n = int.Parse(Console.ReadLine());

			if (n != m + 1)
			{
				throw new Exception("columns must be equal rows + 1");
			}

			double[,] matrix = new double[m, n];

			// get matrix items
			Console.WriteLine($"enter {m} rows, every row with {n} items, also items have only one space between them");

			for (int i = 0; i < m; i++)
			{
				string[] rowItems = Console.ReadLine().Split(" ");

				if (rowItems.Length > n)
				{
					throw new Exception($"max columns is {n}");
				}

				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = double.Parse(rowItems[j]);
				}
			}

			Console.WriteLine("------------------------------------------------------");

			// solve matrix
			string solution = Matrix.SolveMatrix(matrix);

			// print solution
			Console.WriteLine(solution);
		}
	}
}