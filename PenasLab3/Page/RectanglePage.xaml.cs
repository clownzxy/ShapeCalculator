using System.Collections.ObjectModel;

namespace PenasLab3.Page;

public partial class RectanglePage : ContentPage
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
    public RectanglePage()
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


    public RectangleShape DataRegister()
    {
        RectangleShape theShape = new RectangleShape();
        theShape.Input1 = decimal.Parse(txtRectangleLength.Text);
        theShape.Input2 = decimal.Parse(txtRectangleWidth.Text);

        return theShape;
    }


    public RectangleShape DataRegisterCone()
    {
        RectangleShape theShape = new RectangleShape();
        theShape.Input1 = decimal.Parse(txtRectangleLength.Text);
        theShape.Input2 = decimal.Parse(txtRectangleWidth.Text);
        theShape.Input3 = decimal.Parse(txtRectangleHeight.Text);

        return theShape;
    }



    private void OnCalculateButtonClick(object sender, EventArgs e)
    {
        if (IsValidated() == true)
        {
            var rectangleArea = DataRegister().AreaOfRectangle();
            var rectanglePerimeter = DataRegister().PerimeterOfRectangle();
            var rectangleVolume = DataRegisterCone().VolumeOfRectangle();
            txtResult.Text = ($"{rectangleArea.ToString()} {pickerUnits.SelectedItem}");
            txtResult.TextColor = Colors.Green;
            txtRectanglePerimeterResult.Text = ($"{rectanglePerimeter.ToString()} {pickerUnits.SelectedItem}");
            txtRectanglePerimeterResult.TextColor = Colors.Green;
            txtRectangleConeResult.Text = ($"{rectangleVolume.ToString()} {pickerUnits.SelectedItem}");
            txtRectangleConeResult.TextColor = Colors.Green;
        }
        else
        {
            txtResult.Text = ($"Invalid Input, only accepts numeric input");
            txtResult.TextColor = Colors.Red;
            txtRectanglePerimeterResult.Text = ($"Invalid Input, only accepts numeric input");
            txtRectanglePerimeterResult.TextColor = Colors.Red;
            txtRectangleConeResult.Text = ($"Invalid Input, only accepts numeric input");
            txtRectangleConeResult.TextColor = Colors.Red;

        }

    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
    }

    void OnClearButtonClick(object sender, EventArgs e)
    {
        txtLength.Text = string.Empty;
        txtWidth.Text = string.Empty;
        txtResult.Text= string.Empty;
        txtRectanglePerimeterResult.Text = string.Empty;
        txtRectangleLength.Text = string.Empty;
        txtRectangleWidth.Text = string.Empty;
        txtRectangleHeight.Text = string.Empty;
        txtRectangleConeResult.Text = string.Empty;
        pickerUnits.SelectedItem = "";
    }

    public bool IsValidated()
    {
        if (txtLengthnumericValidator.IsValid==true
            &&txtRectangleHeightnumericValidator.IsValid==true
            &&txtRectangleLengthnumericValidator.IsValid==true
            &&txtRectangleWidthnumericValidator.IsValid==true
            &&txtWidthnumericValidator.IsValid==true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
