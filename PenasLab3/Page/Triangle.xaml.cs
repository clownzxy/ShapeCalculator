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
		/*int a = int.Parse(txtBase.Text);
		int b = int.Parse(txtHeight.Text);

		float side1 = Convert.ToSingle(a);
        float side2 = Convert.ToSingle(b);*/

        return new ShapeData
        {
			
			Input1 = float.Parse(txtBase.Text),
			Input2 = float.Parse(txtHeight.Text)
        };

	}

   

    private void OnCalculateButtonClick(object sender, EventArgs e)	
	{
        ShapeData newCalculator = new ShapeData();
		DataRegister();
		txtResult.Text = "5.000";

        //newCalculator.AreaOfTriangle().ToString("0.0000")
    }
}