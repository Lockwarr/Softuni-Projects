using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester:Harvester
{
    public override string Type => "Sonic";

    public SonicHarvester(string id,double oreOutput,double energyRequired,int sonicFactor)
        :base (id,oreOutput,energyRequired)
    {
        EnergyRequired = energyRequired / sonicFactor;
    }
}
