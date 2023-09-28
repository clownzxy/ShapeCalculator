using CommunityToolkit.Maui.Behaviors;
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
            _unitPicker = value;
        }
    }

    public Triangle()
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

    public ShapeData DataRegister()
    {
        ShapeData theShape = new ShapeData();
        theShape.Input1 = decimal.Parse(txtBase.Text);
        theShape.Input2 = decimal.Parse(txtHeight.Text);

        return theShape;
    }

    private void OnCalculateButtonClick(object sender, EventArgs e)
    {
        if (IsValidated() == true)
        {
            var triangleArea = DataRegister().AreaOfTriangle();
            var trianglePerimeter = DataRegister().PerimeterOfTriangle();
            txtResult.Text = ($"{triangleArea.ToString()} {pickerUnits.SelectedItem}");
            txtResult.TextColor = Colors.Green;
            txtPerimeterResult.Text = ($"{trianglePerimeter.ToString()} {pickerUnits.SelectedItem}");
            txtPerimeterResult.TextColor = Colors.Green;
        }
        else
        {
            txtResult.Text = ($"Invalid Input, only accepts numeric input");
            txtResult.TextColor = Colors.Red;
            txtPerimeterResult.Text = ($"Invalid Input, only accepts numeric input");
            txtPerimeterResult.TextColor = Colors.Red;
        }

    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
    }

    void OnClearButtonClick(object sender, EventArgs e)
    {
        txtBase.Text = string.Empty;
        txtHeight.Text = string.Empty;
        txtResult.Text = string.Empty;
        pickerUnits.SelectedItem = "";
    }

    public bool IsValidated()
    {
        if (txtBasenumericValidator.IsValid == true 
            && txtHeightnumericValidator.IsValid == true
            && txtSide1numericValidator.IsValid==true
            && txtSide2tnumericValidator.IsValid==true
            && txtSide3tnumericValidator.IsValid==true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

class NumericValidationBehaviorPage : ContentPage
{
    public NumericValidationBehaviorPage()
    {
        var entry = new Entry
        {
            Keyboard = Keyboard.Numeric
        };

        var validStyle = new Style(typeof(Entry));
        validStyle.Setters.Add(new Setter
        {
            Property = Entry.TextColorProperty,
            Value = Colors.Green
        });

        var invalidStyle = new Style(typeof(Entry));
        invalidStyle.Setters.Add(new Setter
        {
            Property = Entry.TextColorProperty,
            Value = Colors.Red
        });

        var numericValidationBehavior = new NumericValidationBehavior
        {
            InvalidStyle = invalidStyle,
            ValidStyle = validStyle,
            Flags = ValidationFlags.ValidateOnValueChanged,
            MinimumValue = 1.0,
            MaximumValue = 100.0,
            MaximumDecimalPlaces = 2
        };

        entry.Behaviors.Add(numericValidationBehavior);

        Content = entry;
    }
}