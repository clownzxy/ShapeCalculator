using System.Runtime.InteropServices;

namespace PenasLab3;

public class ShapeData
{

    private float _input1;
    private float _input2;
    private float _input3;

    public float Input1
    {
        get => _input1;
        set
        {
            _input1 = value;
        }
    }

    public float Input2
    {
        get => _input2;
        set
        {
            _input2 = value;
        }
    }

    public float Input3
    {
        get => _input3;
        set
        {
            _input3 = value;
        }
    }

    public float AreaOfTriangle()
    {
        return (Input1 * Input2 / 2);
    }


}



