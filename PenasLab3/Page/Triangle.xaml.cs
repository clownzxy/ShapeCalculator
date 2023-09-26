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
			"in",
			"m",
			"cm",
			"km"
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
		var test = DataRegister().AreaOfTriangle();
		txtResult.Text = ($"{test.ToString()} {pickerUnits.SelectedItem}");
		//txtResult.Text = newCalculator.AreaOfTriangle().ToString();

        //newCalculator.AreaOfTriangle().ToString("0.0000")
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
    }

	void OnClearButtonClick(object sender, EventArgs e)
	{
		txtBase.Text= string.Empty;
		txtHeight.Text= string.Empty;
		txtResult.Text = string.Empty;
        pickerUnits.SelectedItem="";
	}


}