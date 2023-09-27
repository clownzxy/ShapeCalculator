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
		if (IsValidated() == true)
		{
            var test = DataRegister().AreaOfTriangle();
            txtResult.Text = ($"{test.ToString()} {pickerUnits.SelectedItem}");
		}
		else
		{
			txtResult.Text = ($"Invalid Input");
			txtResult.TextColor = Colors.Red;
		}
		
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

	public bool IsValidated()
	{
		return true;
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