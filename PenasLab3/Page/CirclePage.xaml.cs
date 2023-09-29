using System.Collections.ObjectModel;

namespace PenasLab3.Page;

public partial class CirclePage : ContentPage
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

    public CirclePage()
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

    public CircleShape DataRegisterArea()
    {
        CircleShape theShape = new CircleShape();
        theShape.Input1 = decimal.Parse(txtRadius.Text);

        return theShape;
    }
    

    private void OnCalculateButtonClick(object sender, EventArgs e)
    {
        if (IsValidated() == true)
        {
            var circleArea = DataRegisterArea().AreaOfCircle();
            var circlePerimeter = DataRegisterArea().PerimeterOfCircle();
            var circleVolume = DataRegisterArea().VolumeOfCircle();
            txtResult.Text = ($"{circleArea.ToString("0.00")} {pickerUnits.SelectedItem}");
            txtResult.TextColor = Colors.Green;
            txtResultPerimeter.Text = ($"{circlePerimeter.ToString("0.00")} {pickerUnits.SelectedItem}");
            txtResultPerimeter.TextColor = Colors.Green;
            txtCubeVolume.Text = ($"{circleVolume.ToString("0.00")} {pickerUnits.SelectedItem}");
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
        if (txtRadiusnumericValidator.IsValid == true)
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
        txtRadius.Text= string.Empty;
        txtResultPerimeter.Text = string.Empty;
        txtCubeVolume.Text = string.Empty;

        pickerUnits.SelectedItem = "";
    }
}

