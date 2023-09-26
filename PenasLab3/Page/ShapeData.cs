using System.Runtime.InteropServices;

namespace PenasLab3;

public class ShapeData
{

    private decimal _input1;
    private decimal _input2;
    private decimal _input3;

    public decimal Input1
    {
        get => _input1;
        set
        {
            _input1 = value;
        }
    }

    public decimal Input2
    {
        get => _input2;
        set
        {
            _input2 = value;
        }
    }

    public decimal Input3
    {
        get => _input3;
        set
        {
            _input3 = value;
        }
    }

    public decimal Result
    {
        get {
            return AreaOfTriangle();
        }
    }

    public decimal AreaOfTriangle()
    {
        return (Input1 * Input2/2);
    }


}



