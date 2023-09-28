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

    private void OnCalculateButtonClick(object sender, EventArgs e)
    {
        if (IsValidated() == true)
        {
            var squareArea = DataRegisterArea().AreaOfSquare();
            txtSide.Text = ($"{squareArea.ToString()} {pickerUnits.SelectedItem}");
            txtResult.TextColor = Colors.Green;

        }
        else
        {
            //txtResult.Text = ($"Invalid Input, only accepts numeric input");
            //txtResult.TextColor = Colors.Red;


        }

    }
    /*
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
    }
    
    /*
    void OnClearButtonClick(object sender, EventArgs e)
    {
        //txtBase.Text = string.Empty;
        //txtHeight.Text = string.Empty;
        //txtResult.Text = string.Empty;

        pickerUnits.SelectedItem = "";
    }

    public bool IsValidated()
    {
        if (txtBasenumericValidator.IsValid == true
            && txtHeightnumericValidator.IsValid == true
)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    */
}
    