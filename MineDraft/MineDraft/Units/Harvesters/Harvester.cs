using System;
using System.Collections.Generic;
using System.Text;


public abstract class Harvester :Unit
{
    private double oreOutput;

    public double OreOutput
    {
        get { return oreOutput; }
        private set {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }

    }

    private double energyRequired;

    public double EnergyRequired
    {
        get { return energyRequired; }
        protected set
        {
            if(value>= 10000 || value<0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequired = value;
        }
    }
    protected Harvester(string id,double oreOutput, double energyRequired):
        base(id)
    {
        OreOutput = oreOutput;
        EnergyRequired = energyRequired;
    }

    public override string ToString()
    {
        return $"{Type} Harvester - {Id}" + Environment.NewLine +
               $"Ore Output: { OreOutput}" + Environment.NewLine + 
               $"Energy Requirement: { EnergyRequired}";
    }

}
