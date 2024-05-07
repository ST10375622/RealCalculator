namespace RealCalculator
{
	public partial class Form1 : Form
	{

		//declare variables 
		string currentInput = "";
		double result = 0;
		string operation = "";
		bool operationPressed = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void OneBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void TwoBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void ThreeBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void FourBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void FiveBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void SixBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void SevenBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void EightBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void NineBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}

		private void ZeroBtn_Click(object sender, EventArgs e)
		{

			Button button = (Button)sender;
			currentInput += button.Text;
			FirstTxtBox.Text = currentInput;
		}
		private void Evaluate()
		{
			if (operationPressed)
			{
				double secondNumber = double.Parse(currentInput);

				switch (operation)
				{
					case "+":
						result += secondNumber;
						break;
					case "-":
						result -= secondNumber;
						break;
					case "*":
						result *= secondNumber;
						break;
					case "/":
						if (secondNumber != 0)
						{
							result /= secondNumber;
						}
						else
						{
							FirstTxtBox.Text = "Cannot divide by zero";
						}
						break;
				}

				FirstTxtBox.Text = result.ToString();
				currentInput = "";
				operationPressed = false;
			}
		}

		private void Addittion_Click(object sender, EventArgs e)
		{
			if (operationPressed)
			{
				Evaluate();
			}

			Button button = (Button)sender;
			operation = button.Text;
			result = double.Parse(currentInput);
			currentInput = "";
			operationPressed = true;
		}

		private void Subtraction_Click(object sender, EventArgs e)
		{
			if (operationPressed)
			{
				Evaluate();
			}

			Button button = (Button)sender;
			operation = button.Text;
			result = double.Parse(currentInput);
			currentInput = "";
			operationPressed = true;
		}

		private void Multiplication_Click(object sender, EventArgs e)
		{
			if (operationPressed)
			{
				Evaluate();
			}

			Button button = (Button)sender;
			operation = button.Text;
			result = double.Parse(currentInput);
			currentInput = "";
			operationPressed = true;
		}

		private void Division_Click(object sender, EventArgs e)
		{
			if (operationPressed)
			{
				Evaluate();
			}

			Button button = (Button)sender;
			operation = button.Text;
			result = double.Parse(currentInput);
			currentInput = "";
			operationPressed = true;
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			currentInput = "";
			result = 0;
			operation = "";
			operationPressed = false;
			FirstTxtBox.Text = "";
		}

		private void Equals_Click(object sender, EventArgs e)
		{
			Evaluate();
		}
	}
}
