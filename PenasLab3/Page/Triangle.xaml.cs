using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

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

	public ShapeData DataRegister()
	{
		/*int a = int.Parse(txtBase.Text);
		int b = int.Parse(txtHeight.Text);

		float side1 = Convert.ToSingle(a);
        float side2 = Convert.ToSingle(b);*/
		ShapeData theShape = new ShapeData();
		theShape.Input1 = decimal.Parse(txtBase.Text);
		theShape.Input2 = decimal.Parse(txtHeight.Text);

		return theShape;
	}

   

    private void OnCalculateButtonClick(object sender, EventArgs e)	
	{
		var test = DataRegister().Result;
		txtResult.Text = test.ToString();
		//txtResult.Text = newCalculator.AreaOfTriangle().ToString();

        //newCalculator.AreaOfTriangle().ToString("0.0000")
    }
}