using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Behaviors;


namespace PenasLab3.Page;



public partial class SquarePage : ContentPage
{
    private ObservableCollection<String> _unitPicker;

    public ObservableCollection<String> UnitPicker
    {
        get => _unitPicker;
        set
        {
            _unitPicker = value;
        }
    }

    public SquarePage()
	{
		InitializeComponent();

        UnitPicker = new ObservableCollection<String> {
      "in",
      "m",
      "cm",
      "km"
    };

        BindingContext = this;
    }


    public SquareShape DataRegisterArea()
    {
        SquareShape theShape = new SquareShape();
        theShape.Input1 = decimal.Parse(txtSide.Text);

        return theShape;
    }

    public SquareShape DataRegisterPerimeter()
    {
        SquareShape theShape = new SquareShape();
        theShape.Input1 = decimal.Parse(txtSide.Text);

        return theShape;
    }

    public SquareShape DataRegisterVolumeCube()
    {
        SquareShape theShape = new SquareShape();
        theShape.Input1 = decimal.Parse(txtSide.Text);

        return theShape;
    }

    private void OnCalculateButtonClick(object sender, EventArgs e)
    {
        if (IsValidated() == true)
        {
            var squareArea = DataRegisterArea().AreaOfSquare();
            var squarePerimeter = DataRegisterPerimeter().PerimeterOfSquare();
            var squareVolume = DataRegisterVolumeCube().CubeVolumeOfSquare();
            txtResult.Text = ($"{squareArea.ToString()} {pickerUnits.SelectedItem}");
            txtResult.TextColor = Colors.Green;
            txtResultPerimeter.Text = ($"{squarePerimeter.ToString()} {pickerUnits.SelectedItem}");
            txtResultPerimeter.TextColor = Colors.Green;
            txtCubeVolume.Text = ($"{squareVolume.ToString()} {pickerUnits.SelectedItem}");
            txtCubeVolume.TextColor = Colors.Green;

        }
        else
        {
            txtResult.Text = ($"Invalid Input, only accepts numeric input");
            txtResult.TextColor = Colors.Red;
            txtResultPerimeter.Text = ($"Invalid Input, only accepts numeric input");
            txtResultPerimeter.TextColor = Colors.Red;
            txtCubeVolume.Text = ($"Invalid Input, only accepts numeric input");
            txtCubeVolume.TextColor = Colors.Red;


        }

    }

    public bool IsValidated()
    {
        if (txtSidenumericValidator.IsValid == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
    }
    
    
    void OnClearButtonClick(object sender, EventArgs e)
    {
        txtResult.Text = string.Empty;
        txtSide.Text = string.Empty;
        txtResultPerimeter.Text= string.Empty;
        txtCubeVolume.Text= string.Empty;

        pickerUnits.SelectedItem = "";
    }

    
   
}
    