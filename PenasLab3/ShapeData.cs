namespace PenasLab3;

public class ShapeData
{
	
		private int _input1;
		private int _input2;
		private int _input3;	

		public int Input1
		{
			get => _input1;
			set { _input1 = value; }
		}

		public int Input2
		{
			get => _input2;
			set
			{
				_input2 = value;
			}
		}

		public int Input3
		{
			get => _input3;
			set
			{
				_input3 = value;
			}
		}

	
}

public class Triangle : ShapeData
{
	public int AreaOfTriangle()
	{
		return (Input1 * Input2 / 2);
	}
}