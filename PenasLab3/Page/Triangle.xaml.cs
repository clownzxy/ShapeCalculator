using System.Collections.ObjectModel;

namespace PenasLab3.Page;

public partial class Triangle : ContentPage
{
	private ObservableCollection<String> _unitPicker;

	public ObservableCollection<String> UnitPicker
	{
		get => _unitPicker;
		set
		{
			_unitPicker=value;
		}
	}

	public Triangle()
	{
		InitializeComponent();

		UnitPicker = new ObservableCollection<String>
		{
			"--SELECT--",
			"cm"
		};


		BindingContext = this;
	}

	private ShapeData DataRegister()
	{
		return new ShapeData
		{
			Input1 = int.Parse(txtBase.Text),
			Input2 = int.Parse(txtHeight.Text)
	};
	}

   

    private void OnCalculateButtonClick(object sender, EventArgs e)
	{
		TriangleCalculate newCalculator = new();
		DataRegister();
		txtResult.Text = newTriangle.AreaOfTriangle().ToString();

    }
}