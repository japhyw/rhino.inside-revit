using Autodesk.Revit.DB;

namespace RhinoInside.Revit.External.DB.Schemas
{
  public partial class SpecType
  {
    public static class Measurable
    {
      public static SpecType Acceleration => new SpecType("autodesk.spec.aec.structural:acceleration-2.0.0");
      public static SpecType AirFlow => new SpecType("autodesk.spec.aec.hvac:airFlow-2.0.0");
      public static SpecType AirFlowDensity => new SpecType("autodesk.spec.aec.hvac:airFlowDensity-2.0.0");
      public static SpecType AirFlowDividedByCoolingLoad => new SpecType("autodesk.spec.aec.hvac:airFlowDividedByCoolingLoad-2.0.0");
      public static SpecType AirFlowDividedByVolume => new SpecType("autodesk.spec.aec.hvac:airFlowDividedByVolume-2.0.0");
      public static SpecType Angle => new SpecType("autodesk.spec.aec:angle-2.0.0");
      public static SpecType AngularSpeed => new SpecType("autodesk.spec.aec.hvac:angularSpeed-2.0.0");
      public static SpecType ApparentPower => new SpecType("autodesk.spec.aec.electrical:apparentPower-2.0.0");
      public static SpecType Area => new SpecType("autodesk.spec.aec:area-2.0.0");
      public static SpecType AreaDividedByCoolingLoad => new SpecType("autodesk.spec.aec.hvac:areaDividedByCoolingLoad-2.0.0");
      public static SpecType AreaDividedByHeatingLoad => new SpecType("autodesk.spec.aec.hvac:areaDividedByHeatingLoad-2.0.0");
      public static SpecType AreaForce => new SpecType("autodesk.spec.aec.structural:areaForce-2.0.0");
      public static SpecType AreaForceScale => new SpecType("autodesk.spec.aec.structural:areaForceScale-2.0.0");
      public static SpecType AreaSpringCoefficient => new SpecType("autodesk.spec.aec.structural:areaSpringCoefficient-2.0.0");
      public static SpecType BarDiameter => new SpecType("autodesk.spec.aec.structural:barDiameter-2.0.0");
      public static SpecType CableTraySize => new SpecType("autodesk.spec.aec.electrical:cableTraySize-2.0.0");
      public static SpecType ColorTemperature => new SpecType("autodesk.spec.aec.electrical:colorTemperature-2.0.0");
      public static SpecType ConduitSize => new SpecType("autodesk.spec.aec.electrical:conduitSize-2.0.0");
      public static SpecType CoolingLoad => new SpecType("autodesk.spec.aec.hvac:coolingLoad-2.0.0");
      public static SpecType CoolingLoadDividedByArea => new SpecType("autodesk.spec.aec.hvac:coolingLoadDividedByArea-2.0.0");
      public static SpecType CoolingLoadDividedByVolume => new SpecType("autodesk.spec.aec.hvac:coolingLoadDividedByVolume-2.0.0");
      public static SpecType CostPerArea => new SpecType("autodesk.spec.aec:costPerArea-2.0.0");
      public static SpecType CostRateEnergy => new SpecType("autodesk.spec.aec.electrical:costRateEnergy-2.0.0");
      public static SpecType CostRatePower => new SpecType("autodesk.spec.aec.electrical:costRatePower-2.0.0");
      public static SpecType CrackWidth => new SpecType("autodesk.spec.aec.structural:crackWidth-2.0.0");
      public static SpecType CrossSection => new SpecType("autodesk.spec.aec.hvac:crossSection-2.0.0");
      public static SpecType Currency => new SpecType("autodesk.spec.measurable:currency-2.0.0");
      public static SpecType Current => new SpecType("autodesk.spec.aec.electrical:current-2.0.0");
      public static SpecType DecimalSheetLength => new SpecType("autodesk.spec.aec:decimalSheetLength-2.0.0");
      public static SpecType DemandFactor => new SpecType("autodesk.spec.aec.electrical:demandFactor-2.0.0");
      public static SpecType Diffusivity => new SpecType("autodesk.spec.aec.hvac:diffusivity-2.0.0");
      public static SpecType Displacement => new SpecType("autodesk.spec.aec.structural:displacement-2.0.0");
      public static SpecType Distance => new SpecType("autodesk.spec.aec:distance-2.0.0");
      public static SpecType DuctInsulationThickness => new SpecType("autodesk.spec.aec.hvac:ductInsulationThickness-2.0.0");
      public static SpecType DuctLiningThickness => new SpecType("autodesk.spec.aec.hvac:ductLiningThickness-2.0.0");
      public static SpecType DuctSize => new SpecType("autodesk.spec.aec.hvac:ductSize-2.0.0");
      public static SpecType Efficacy => new SpecType("autodesk.spec.aec.electrical:efficacy-2.0.0");
      public static SpecType ElectricalFrequency => new SpecType("autodesk.spec.aec.electrical:frequency-2.0.0");
      public static SpecType ElectricalPotential => new SpecType("autodesk.spec.aec.electrical:potential-2.0.0");
      public static SpecType ElectricalPower => new SpecType("autodesk.spec.aec.electrical:power-2.0.0");
      public static SpecType ElectricalPowerDensity => new SpecType("autodesk.spec.aec.electrical:powerDensity-2.0.0");
      public static SpecType ElectricalResistivity => new SpecType("autodesk.spec.aec.electrical:resistivity-2.0.0");
      public static SpecType ElectricalTemperature => new SpecType("autodesk.spec.aec.electrical:temperature-2.0.0");
      public static SpecType ElectricalTemperatureDifference => new SpecType("autodesk.spec.aec.electrical:temperatureDifference-2.0.0");
      public static SpecType Energy => new SpecType("autodesk.spec.aec.structural:energy-2.0.0");
      public static SpecType Factor => new SpecType("autodesk.spec.aec.hvac:factor-2.0.0");
      public static SpecType Flow => new SpecType("autodesk.spec.aec.piping:flow-2.0.0");
      public static SpecType FlowPerPower => new SpecType("autodesk.spec.aec.hvac:flowPerPower-2.0.0");
      public static SpecType Force => new SpecType("autodesk.spec.aec.structural:force-2.0.0");
      public static SpecType ForceScale => new SpecType("autodesk.spec.aec.structural:forceScale-2.0.0");
      public static SpecType HeatCapacityPerArea => new SpecType("autodesk.spec.aec.energy:heatCapacityPerArea-2.0.0");
      public static SpecType HeatGain => new SpecType("autodesk.spec.aec.hvac:heatGain-2.0.0");
      public static SpecType HeatingLoad => new SpecType("autodesk.spec.aec.hvac:heatingLoad-2.0.0");
      public static SpecType HeatingLoadDividedByArea => new SpecType("autodesk.spec.aec.hvac:heatingLoadDividedByArea-2.0.0");
      public static SpecType HeatingLoadDividedByVolume => new SpecType("autodesk.spec.aec.hvac:heatingLoadDividedByVolume-2.0.0");
      public static SpecType HeatTransferCoefficient => new SpecType("autodesk.spec.aec.energy:heatTransferCoefficient-2.0.0");
      public static SpecType HvacDensity => new SpecType("autodesk.spec.aec.hvac:density-2.0.0");
      public static SpecType HvacEnergy => new SpecType("autodesk.spec.aec.energy:energy-2.0.0");
      public static SpecType HvacFriction => new SpecType("autodesk.spec.aec.hvac:friction-2.0.0");
      public static SpecType HvacMassPerTime => new SpecType("autodesk.spec.aec.hvac:massPerTime-2.0.0");
      public static SpecType HvacPower => new SpecType("autodesk.spec.aec.hvac:power-2.0.0");
      public static SpecType HvacPowerDensity => new SpecType("autodesk.spec.aec.hvac:powerDensity-2.0.0");
      public static SpecType HvacPressure => new SpecType("autodesk.spec.aec.hvac:pressure-2.0.0");
      public static SpecType HvacRoughness => new SpecType("autodesk.spec.aec.hvac:roughness-2.0.0");
      public static SpecType HvacSlope => new SpecType("autodesk.spec.aec.hvac:slope-2.0.0");
      public static SpecType HvacTemperature => new SpecType("autodesk.spec.aec.hvac:temperature-2.0.0");
      public static SpecType HvacTemperatureDifference => new SpecType("autodesk.spec.aec.hvac:temperatureDifference-2.0.0");
      public static SpecType HvacVelocity => new SpecType("autodesk.spec.aec.hvac:velocity-2.0.0");
      public static SpecType HvacViscosity => new SpecType("autodesk.spec.aec.hvac:viscosity-2.0.0");
      public static SpecType Illuminance => new SpecType("autodesk.spec.aec.electrical:illuminance-2.0.0");
      public static SpecType IsothermalMoistureCapacity => new SpecType("autodesk.spec.aec.energy:isothermalMoistureCapacity-2.0.0");
      public static SpecType Length => new SpecType("autodesk.spec.aec:length-2.0.0");
      public static SpecType LinearForce => new SpecType("autodesk.spec.aec.structural:linearForce-2.0.0");
      public static SpecType LinearForceScale => new SpecType("autodesk.spec.aec.structural:linearForceScale-2.0.0");
      public static SpecType LinearMoment => new SpecType("autodesk.spec.aec.structural:linearMoment-2.0.0");
      public static SpecType LinearMomentScale => new SpecType("autodesk.spec.aec.structural:linearMomentScale-2.0.0");
      public static SpecType LineSpringCoefficient => new SpecType("autodesk.spec.aec.structural:lineSpringCoefficient-2.0.0");
      public static SpecType Luminance => new SpecType("autodesk.spec.aec.electrical:luminance-2.0.0");
      public static SpecType LuminousFlux => new SpecType("autodesk.spec.aec.electrical:luminousFlux-2.0.0");
      public static SpecType LuminousIntensity => new SpecType("autodesk.spec.aec.electrical:luminousIntensity-2.0.0");
      public static SpecType Mass => new SpecType("autodesk.spec.aec.structural:mass-2.0.0");
      public static SpecType MassDensity => new SpecType("autodesk.spec.aec:massDensity-2.0.0");
      public static SpecType MassPerUnitArea => new SpecType("autodesk.spec.aec.structural:massPerUnitArea-2.0.0");
      public static SpecType MassPerUnitLength => new SpecType("autodesk.spec.aec.structural:massPerUnitLength-2.0.0");
      public static SpecType Moment => new SpecType("autodesk.spec.aec.structural:moment-2.0.0");
      public static SpecType MomentOfInertia => new SpecType("autodesk.spec.aec.structural:momentOfInertia-2.0.0");
      public static SpecType MomentScale => new SpecType("autodesk.spec.aec.structural:momentScale-2.0.0");
      public static SpecType Number => new SpecType("autodesk.spec.aec:number-2.0.0");
      public static SpecType Period => new SpecType("autodesk.spec.aec.structural:period-2.0.0");
      public static SpecType Permeability => new SpecType("autodesk.spec.aec.energy:permeability-2.0.0");
      public static SpecType PipeDimension => new SpecType("autodesk.spec.aec.piping:pipeDimension-2.0.0");
      public static SpecType PipeInsulationThickness => new SpecType("autodesk.spec.aec.piping:pipeInsulationThickness-2.0.0");
      public static SpecType PipeMassPerUnitLength => new SpecType("autodesk.spec.aec.piping:pipeMassPerUnitLength-2.0.0");
      public static SpecType PipeSize => new SpecType("autodesk.spec.aec.piping:pipeSize-2.0.0");
      public static SpecType PipingDensity => new SpecType("autodesk.spec.aec.piping:density-2.0.0");
      public static SpecType PipingFriction => new SpecType("autodesk.spec.aec.piping:friction-2.0.0");
      public static SpecType PipingMass => new SpecType("autodesk.spec.aec.piping:mass-2.0.0");
      public static SpecType PipingMassPerTime => new SpecType("autodesk.spec.aec.piping:massPerTime-2.0.0");
      public static SpecType PipingPressure => new SpecType("autodesk.spec.aec.piping:pressure-2.0.0");
      public static SpecType PipingRoughness => new SpecType("autodesk.spec.aec.piping:roughness-2.0.0");
      public static SpecType PipingSlope => new SpecType("autodesk.spec.aec.piping:slope-2.0.0");
      public static SpecType PipingTemperature => new SpecType("autodesk.spec.aec.piping:temperature-2.0.0");
      public static SpecType PipingTemperatureDifference => new SpecType("autodesk.spec.aec.piping:temperatureDifference-2.0.0");
      public static SpecType PipingVelocity => new SpecType("autodesk.spec.aec.piping:velocity-2.0.0");
      public static SpecType PipingViscosity => new SpecType("autodesk.spec.aec.piping:viscosity-2.0.0");
      public static SpecType PipingVolume => new SpecType("autodesk.spec.aec.piping:volume-2.0.0");
      public static SpecType PointSpringCoefficient => new SpecType("autodesk.spec.aec.structural:pointSpringCoefficient-2.0.0");
      public static SpecType PowerPerFlow => new SpecType("autodesk.spec.aec.hvac:powerPerFlow-2.0.0");
      public static SpecType PowerPerLength => new SpecType("autodesk.spec.aec.electrical:powerPerLength-2.0.0");
      public static SpecType Pulsation => new SpecType("autodesk.spec.aec.structural:pulsation-2.0.0");
      public static SpecType ReinforcementArea => new SpecType("autodesk.spec.aec.structural:reinforcementArea-2.0.0");
      public static SpecType ReinforcementAreaPerUnitLength => new SpecType("autodesk.spec.aec.structural:reinforcementAreaPerUnitLength-2.0.0");
      public static SpecType ReinforcementCover => new SpecType("autodesk.spec.aec.structural:reinforcementCover-2.0.0");
      public static SpecType ReinforcementLength => new SpecType("autodesk.spec.aec.structural:reinforcementLength-2.0.0");
      public static SpecType ReinforcementSpacing => new SpecType("autodesk.spec.aec.structural:reinforcementSpacing-2.0.0");
      public static SpecType ReinforcementVolume => new SpecType("autodesk.spec.aec.structural:reinforcementVolume-2.0.0");
      public static SpecType Rotation => new SpecType("autodesk.spec.aec.structural:rotation-2.0.0");
      public static SpecType RotationalLineSpringCoefficient => new SpecType("autodesk.spec.aec.structural:rotationalLineSpringCoefficient-2.0.0");
      public static SpecType RotationalPointSpringCoefficient => new SpecType("autodesk.spec.aec.structural:rotationalPointSpringCoefficient-2.0.0");
      public static SpecType RotationAngle => new SpecType("autodesk.spec.aec:rotationAngle-2.0.0");
      public static SpecType SectionArea => new SpecType("autodesk.spec.aec.structural:sectionArea-2.0.0");
      public static SpecType SectionDimension => new SpecType("autodesk.spec.aec.structural:sectionDimension-2.0.0");
      public static SpecType SectionModulus => new SpecType("autodesk.spec.aec.structural:sectionModulus-2.0.0");
      public static SpecType SectionProperty => new SpecType("autodesk.spec.aec.structural:sectionProperty-2.0.0");
      public static SpecType SheetLength => new SpecType("autodesk.spec.aec:sheetLength-2.0.0");
      public static SpecType SiteAngle => new SpecType("autodesk.spec.aec:siteAngle-2.0.0");
      public static SpecType Slope => new SpecType("autodesk.spec.aec:slope-2.0.0");
      public static SpecType SpecificHeat => new SpecType("autodesk.spec.aec.energy:specificHeat-2.0.0");
      public static SpecType SpecificHeatOfVaporization => new SpecType("autodesk.spec.aec.energy:specificHeatOfVaporization-2.0.0");
      public static SpecType Speed => new SpecType("autodesk.spec.aec:speed-2.0.0");
      public static SpecType Stationing => new SpecType("autodesk.spec.aec.infrastructure:stationing-2.0.0");
      public static SpecType StationingInterval => new SpecType("autodesk.spec.aec.infrastructure:stationingInterval-2.0.0");
      public static SpecType Stress => new SpecType("autodesk.spec.aec.structural:stress-2.0.0");
      public static SpecType StructuralFrequency => new SpecType("autodesk.spec.aec.structural:frequency-2.0.0");
      public static SpecType StructuralVelocity => new SpecType("autodesk.spec.aec.structural:velocity-2.0.0");
      public static SpecType SurfaceAreaPerUnitLength => new SpecType("autodesk.spec.aec.structural:surfaceAreaPerUnitLength-2.0.0");
      public static SpecType ThermalConductivity => new SpecType("autodesk.spec.aec.energy:thermalConductivity-2.0.0");
      public static SpecType ThermalExpansionCoefficient => new SpecType("autodesk.spec.aec.structural:thermalExpansionCoefficient-2.0.0");
      public static SpecType ThermalGradientCoefficientForMoistureCapacity => new SpecType("autodesk.spec.aec.energy:thermalGradientCoefficientForMoistureCapacity-2.0.0");
      public static SpecType ThermalMass => new SpecType("autodesk.spec.aec.energy:thermalMass-2.0.0");
      public static SpecType ThermalResistance => new SpecType("autodesk.spec.aec.energy:thermalResistance-2.0.0");
      public static SpecType Time => new SpecType("autodesk.spec.aec:time-2.0.0");
      public static SpecType UnitWeight => new SpecType("autodesk.spec.aec.structural:unitWeight-2.0.0");
      public static SpecType Volume => new SpecType("autodesk.spec.aec:volume-2.0.0");
      public static SpecType WarpingConstant => new SpecType("autodesk.spec.aec.structural:warpingConstant-2.0.0");
      public static SpecType Wattage => new SpecType("autodesk.spec.aec.electrical:wattage-2.0.0");
      public static SpecType Weight => new SpecType("autodesk.spec.aec.structural:weight-2.0.0");
      public static SpecType WeightPerUnitLength => new SpecType("autodesk.spec.aec.structural:weightPerUnitLength-2.0.0");
      public static SpecType WireDiameter => new SpecType("autodesk.spec.aec.electrical:wireDiameter-2.0.0");
    }
  }
}
