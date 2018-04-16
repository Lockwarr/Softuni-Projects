using System;
using System.Collections.Generic;
using System.Text;


class Box
{
    private double volume;
    private double LSA;
    private double SA;
    public void GetVolume(double length, double width, double height)
    {
        this.volume = length * width * height;
    }
    public void GetLSA(double length,double width,double height)
    {
        this.LSA = 2 * length * height + 2 * width * height;
    }
    public void GetSA(double length, double width, double height)
    {
        this.SA = 2 * length * width + 2 * length * height + 2 * width * height;
    }
    public override string ToString()
    {
        return $"Surface Area - {string.Format("{0:N2}",SA)}"
            +Environment.NewLine +$"Lateral Surface Area - {string.Format("{0:N2}", LSA)}" 
            + Environment.NewLine + $"Volume - {string.Format("{0:N2}", volume)}";
    }
}
