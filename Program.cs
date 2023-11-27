namespace Solving_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// READ MATRIX(M*N) FROM USER

			Console.Write("Enter number of rows => ");
			int m = int.Parse(Console.ReadLine());

			Console.Write("Enter number of columns => ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("\n==============================================\n");

			if (m >= n)
				throw new Exception("Columns must be greater than rows");

			double[,] matrix = new double[m, n];

			Console.WriteLine("Enter every row");

			for (int i = 0; i < m; i++)
			{
				string[] rowItems = Console.ReadLine().Split(" ");

				if (rowItems.Length != n)
					throw new Exception($"Invalid row length");
				

				for (int j = 0; j < n; j++)
					matrix[i, j] = double.Parse(rowItems[j]);
				
			}

			Console.WriteLine("\n==============================================\n");

			// Get matrix solution
			string solution = Matrix.SolveMatrix(matrix);

			Console.WriteLine("Matrix Solution => " + solution);
		}
	}
}