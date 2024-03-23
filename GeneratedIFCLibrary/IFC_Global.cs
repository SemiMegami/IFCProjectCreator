using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC.Global
{
	#region ---- SIMPLE DATA TYPES ----
	#endregion

	#region ---- ENUMERATION TYPES ----
	#endregion

	#region ---- INTERFACES ----
	/// <summary>
	/// </summary>
	public interface IFCAbsorbedDoseMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAccelerationMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAmountOfSubstanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAngularVelocityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAreaMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoolean: IFC_Attribute
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoxAlignment: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCContextDependentMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCountMeasure: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCCurvatureMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDayInMonthNumber: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDaylightSavingHour: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDescriptiveMeasure: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionCount: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoseEquivalentMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDynamicViscosityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricCapacitanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricChargeMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricConductanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricCurrentMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricResistanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricVoltageMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEnergyMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFontStyle: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFontVariant: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFontWeight: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCForceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFrequencyMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGloballyUniqueId: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCHeatFluxDensityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCHeatingValueMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCHourInDay: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIdentifier: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIlluminanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInductanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInteger: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIntegerCountRateMeasure: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIonConcentrationMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIsothermalMoistureCapacityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCKinematicViscosityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLabel: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLengthMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearForceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearMomentMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearStiffnessMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearVelocityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLogical: IFC_Attribute
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLuminousFluxMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLuminousIntensityDistributionMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLuminousIntensityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMagneticFluxDensityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMagneticFluxMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMassDensityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMassFlowRateMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMassMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMassPerLengthMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMinuteInHour: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfElasticityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfLinearSubgradeReactionMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfRotationalSubgradeReactionMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfSubgradeReactionMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMoistureDiffusivityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMolecularWeightMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMomentOfInertiaMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMonetaryMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMonthInYearNumber: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCNormalisedRatioMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCNumericMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPHMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCParameterValue: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPlanarForceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPlaneAngleMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPositiveLengthMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPositivePlaneAngleMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPositiveRatioMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPowerMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentableText: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPressureMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRadioActivityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRatioMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReal: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRotationalFrequencyMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRotationalMassMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRotationalStiffnessMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSecondInMinute: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionModulusMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionalAreaIntegralMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCShearModulusMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSolidAngleMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundPowerMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundPressureMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpecificHeatCapacityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpecularExponent: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpecularRoughness: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTemperatureGradientMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCText: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextAlignment: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextDecoration: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextFontName: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextTransformation: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalAdmittanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalConductivityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalExpansionCoefficientMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalResistanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalTransmittanceMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermodynamicTemperatureMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeStamp: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTorqueMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVaporPermeabilityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVolumeMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVolumetricFlowRateMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWarpingConstantMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWarpingMomentMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCYearNumber: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAreaDensityMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBinary: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCardinalPointReference: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDate: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDateTime: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDayInWeekNumber: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDuration: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLanguageId: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCNonNegativeLengthMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPositiveInteger: IFC_Attribute
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundPowerLevelMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundPressureLevelMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTemperatureRateOfChangeMeasure: IFC_Attribute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTime: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCURIReference: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStrippedOptional: IFC_Attribute
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWellKnownTextLiteral: IFC_Attribute
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCComplexNumber: IFC_Attribute
	{
		public List<double> Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCompoundPlaneAngleMeasure: IFC_Attribute
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCArcIndex: IFC_Attribute
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLineIndex: IFC_Attribute
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySetDefinitionSet: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCActionSourceTypeEnum: IFC_Attribute
	{
		public static string? DEAD_LOAD_G {get; set;}
		public static string? COMPLETION_G1 {get; set;}
		public static string? LIVE_LOAD_Q {get; set;}
		public static string? SNOW_S {get; set;}
		public static string? WIND_W {get; set;}
		public static string? PRESTRESSING_P {get; set;}
		public static string? SETTLEMENT_U {get; set;}
		public static string? TEMPERATURE_T {get; set;}
		public static string? EARTHQUAKE_E {get; set;}
		public static string? FIRE {get; set;}
		public static string? IMPULSE {get; set;}
		public static string? IMPACT {get; set;}
		public static string? TRANSPORT {get; set;}
		public static string? ERECTION {get; set;}
		public static string? PROPPING {get; set;}
		public static string? SYSTEM_IMPERFECTION {get; set;}
		public static string? SHRINKAGE {get; set;}
		public static string? CREEP {get; set;}
		public static string? LACK_OF_FIT {get; set;}
		public static string? BUOYANCY {get; set;}
		public static string? ICE {get; set;}
		public static string? CURRENT {get; set;}
		public static string? WAVE {get; set;}
		public static string? RAIN {get; set;}
		public static string? BRAKES {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCActionTypeEnum: IFC_Attribute
	{
		public static string? PERMANENT_G {get; set;}
		public static string? VARIABLE_Q {get; set;}
		public static string? EXTRAORDINARY_A {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCActuatorTypeEnum: IFC_Attribute
	{
		public static string? ELECTRICACTUATOR {get; set;}
		public static string? HANDOPERATEDACTUATOR {get; set;}
		public static string? HYDRAULICACTUATOR {get; set;}
		public static string? PNEUMATICACTUATOR {get; set;}
		public static string? THERMOSTATICACTUATOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAddressTypeEnum: IFC_Attribute
	{
		public static string? OFFICE {get; set;}
		public static string? SITE {get; set;}
		public static string? HOME {get; set;}
		public static string? DISTRIBUTIONPOINT {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAheadOrBehind: IFC_Attribute
	{
		public static string? AHEAD {get; set;}
		public static string? BEHIND {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminalBoxTypeEnum: IFC_Attribute
	{
		public static string? CONSTANTFLOW {get; set;}
		public static string? VARIABLEFLOWPRESSUREDEPENDANT {get; set;}
		public static string? VARIABLEFLOWPRESSUREINDEPENDANT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminalTypeEnum: IFC_Attribute
	{
		public static string? GRILLE {get; set;}
		public static string? REGISTER {get; set;}
		public static string? DIFFUSER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAirToAirHeatRecoveryTypeEnum: IFC_Attribute
	{
		public static string? FIXEDPLATECOUNTERFLOWEXCHANGER {get; set;}
		public static string? FIXEDPLATECROSSFLOWEXCHANGER {get; set;}
		public static string? FIXEDPLATEPARALLELFLOWEXCHANGER {get; set;}
		public static string? ROTARYWHEEL {get; set;}
		public static string? RUNAROUNDCOILLOOP {get; set;}
		public static string? HEATPIPE {get; set;}
		public static string? TWINTOWERENTHALPYRECOVERYLOOPS {get; set;}
		public static string? THERMOSIPHONSEALEDTUBEHEATEXCHANGERS {get; set;}
		public static string? THERMOSIPHONCOILTYPEHEATEXCHANGERS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlarmTypeEnum: IFC_Attribute
	{
		public static string? BELL {get; set;}
		public static string? BREAKGLASSBUTTON {get; set;}
		public static string? LIGHT {get; set;}
		public static string? MANUALPULLBOX {get; set;}
		public static string? SIREN {get; set;}
		public static string? WHISTLE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAnalysisModelTypeEnum: IFC_Attribute
	{
		public static string? IN_PLANE_LOADING_2D {get; set;}
		public static string? OUT_PLANE_LOADING_2D {get; set;}
		public static string? LOADING_3D {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAnalysisTheoryTypeEnum: IFC_Attribute
	{
		public static string? FIRST_ORDER_THEORY {get; set;}
		public static string? SECOND_ORDER_THEORY {get; set;}
		public static string? THIRD_ORDER_THEORY {get; set;}
		public static string? FULL_NONLINEAR_THEORY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCArithmeticOperatorEnum: IFC_Attribute
	{
		public static string? ADD {get; set;}
		public static string? DIVIDE {get; set;}
		public static string? MULTIPLY {get; set;}
		public static string? SUBTRACT {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAssemblyPlaceEnum: IFC_Attribute
	{
		public static string? SITE {get; set;}
		public static string? FACTORY {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineCurveForm: IFC_Attribute
	{
		public static string? POLYLINE_FORM {get; set;}
		public static string? CIRCULAR_ARC {get; set;}
		public static string? ELLIPTIC_ARC {get; set;}
		public static string? PARABOLIC_ARC {get; set;}
		public static string? HYPERBOLIC_ARC {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBeamTypeEnum: IFC_Attribute
	{
		public static string? BEAM {get; set;}
		public static string? JOIST {get; set;}
		public static string? LINTEL {get; set;}
		public static string? T_BEAM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBenchmarkEnum: IFC_Attribute
	{
		public static string? GREATERTHAN {get; set;}
		public static string? GREATERTHANOREQUALTO {get; set;}
		public static string? LESSTHAN {get; set;}
		public static string? LESSTHANOREQUALTO {get; set;}
		public static string? EQUALTO {get; set;}
		public static string? NOTEQUALTO {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoilerTypeEnum: IFC_Attribute
	{
		public static string? WATER {get; set;}
		public static string? STEAM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBooleanOperator: IFC_Attribute
	{
		public static string? UNION {get; set;}
		public static string? INTERSECTION {get; set;}
		public static string? DIFFERENCE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementProxyTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierFittingTypeEnum: IFC_Attribute
	{
		public static string? BEND {get; set;}
		public static string? CROSS {get; set;}
		public static string? REDUCER {get; set;}
		public static string? TEE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierSegmentTypeEnum: IFC_Attribute
	{
		public static string? CABLELADDERSEGMENT {get; set;}
		public static string? CABLETRAYSEGMENT {get; set;}
		public static string? CABLETRUNKINGSEGMENT {get; set;}
		public static string? CONDUITSEGMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCableSegmentTypeEnum: IFC_Attribute
	{
		public static string? CABLESEGMENT {get; set;}
		public static string? CONDUCTORSEGMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCChangeActionEnum: IFC_Attribute
	{
		public static string? NOCHANGE {get; set;}
		public static string? MODIFIED {get; set;}
		public static string? ADDED {get; set;}
		public static string? DELETED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCChillerTypeEnum: IFC_Attribute
	{
		public static string? AIRCOOLED {get; set;}
		public static string? WATERCOOLED {get; set;}
		public static string? HEATRECOVERY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCoilTypeEnum: IFC_Attribute
	{
		public static string? DXCOOLINGCOIL {get; set;}
		public static string? WATERCOOLINGCOIL {get; set;}
		public static string? STEAMHEATINGCOIL {get; set;}
		public static string? WATERHEATINGCOIL {get; set;}
		public static string? ELECTRICHEATINGCOIL {get; set;}
		public static string? GASHEATINGCOIL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCColumnTypeEnum: IFC_Attribute
	{
		public static string? COLUMN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCompressorTypeEnum: IFC_Attribute
	{
		public static string? DYNAMIC {get; set;}
		public static string? RECIPROCATING {get; set;}
		public static string? ROTARY {get; set;}
		public static string? SCROLL {get; set;}
		public static string? TROCHOIDAL {get; set;}
		public static string? SINGLESTAGE {get; set;}
		public static string? BOOSTER {get; set;}
		public static string? OPENTYPE {get; set;}
		public static string? HERMETIC {get; set;}
		public static string? SEMIHERMETIC {get; set;}
		public static string? WELDEDSHELLHERMETIC {get; set;}
		public static string? ROLLINGPISTON {get; set;}
		public static string? ROTARYVANE {get; set;}
		public static string? SINGLESCREW {get; set;}
		public static string? TWINSCREW {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCondenserTypeEnum: IFC_Attribute
	{
		public static string? WATERCOOLEDSHELLTUBE {get; set;}
		public static string? WATERCOOLEDSHELLCOIL {get; set;}
		public static string? WATERCOOLEDTUBEINTUBE {get; set;}
		public static string? WATERCOOLEDBRAZEDPLATE {get; set;}
		public static string? AIRCOOLED {get; set;}
		public static string? EVAPORATIVECOOLED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionTypeEnum: IFC_Attribute
	{
		public static string? ATPATH {get; set;}
		public static string? ATSTART {get; set;}
		public static string? ATEND {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstraintEnum: IFC_Attribute
	{
		public static string? HARD {get; set;}
		public static string? SOFT {get; set;}
		public static string? ADVISORY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCControllerTypeEnum: IFC_Attribute
	{
		public static string? FLOATING {get; set;}
		public static string? PROPORTIONAL {get; set;}
		public static string? TWOPOSITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCooledBeamTypeEnum: IFC_Attribute
	{
		public static string? ACTIVE {get; set;}
		public static string? PASSIVE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCoolingTowerTypeEnum: IFC_Attribute
	{
		public static string? NATURALDRAFT {get; set;}
		public static string? MECHANICALINDUCEDDRAFT {get; set;}
		public static string? MECHANICALFORCEDDRAFT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCostScheduleTypeEnum: IFC_Attribute
	{
		public static string? BUDGET {get; set;}
		public static string? COSTPLAN {get; set;}
		public static string? ESTIMATE {get; set;}
		public static string? TENDER {get; set;}
		public static string? PRICEDBILLOFQUANTITIES {get; set;}
		public static string? UNPRICEDBILLOFQUANTITIES {get; set;}
		public static string? SCHEDULEOFRATES {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCoveringTypeEnum: IFC_Attribute
	{
		public static string? CEILING {get; set;}
		public static string? FLOORING {get; set;}
		public static string? CLADDING {get; set;}
		public static string? ROOFING {get; set;}
		public static string? INSULATION {get; set;}
		public static string? MEMBRANE {get; set;}
		public static string? SLEEVING {get; set;}
		public static string? WRAPPING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurrencyEnum: IFC_Attribute
	{
		public static string? AED {get; set;}
		public static string? AES {get; set;}
		public static string? ATS {get; set;}
		public static string? AUD {get; set;}
		public static string? BBD {get; set;}
		public static string? BEG {get; set;}
		public static string? BGL {get; set;}
		public static string? BHD {get; set;}
		public static string? BMD {get; set;}
		public static string? BND {get; set;}
		public static string? BRL {get; set;}
		public static string? BSD {get; set;}
		public static string? BWP {get; set;}
		public static string? BZD {get; set;}
		public static string? CAD {get; set;}
		public static string? CBD {get; set;}
		public static string? CHF {get; set;}
		public static string? CLP {get; set;}
		public static string? CNY {get; set;}
		public static string? CYS {get; set;}
		public static string? CZK {get; set;}
		public static string? DDP {get; set;}
		public static string? DEM {get; set;}
		public static string? DKK {get; set;}
		public static string? EGL {get; set;}
		public static string? EST {get; set;}
		public static string? EUR {get; set;}
		public static string? FAK {get; set;}
		public static string? FIM {get; set;}
		public static string? FJD {get; set;}
		public static string? FKP {get; set;}
		public static string? FRF {get; set;}
		public static string? GBP {get; set;}
		public static string? GIP {get; set;}
		public static string? GMD {get; set;}
		public static string? GRX {get; set;}
		public static string? HKD {get; set;}
		public static string? HUF {get; set;}
		public static string? ICK {get; set;}
		public static string? IDR {get; set;}
		public static string? ILS {get; set;}
		public static string? INR {get; set;}
		public static string? IRP {get; set;}
		public static string? ITL {get; set;}
		public static string? JMD {get; set;}
		public static string? JOD {get; set;}
		public static string? JPY {get; set;}
		public static string? KES {get; set;}
		public static string? KRW {get; set;}
		public static string? KWD {get; set;}
		public static string? KYD {get; set;}
		public static string? LKR {get; set;}
		public static string? LUF {get; set;}
		public static string? MTL {get; set;}
		public static string? MUR {get; set;}
		public static string? MXN {get; set;}
		public static string? MYR {get; set;}
		public static string? NLG {get; set;}
		public static string? NZD {get; set;}
		public static string? OMR {get; set;}
		public static string? PGK {get; set;}
		public static string? PHP {get; set;}
		public static string? PKR {get; set;}
		public static string? PLN {get; set;}
		public static string? PTN {get; set;}
		public static string? QAR {get; set;}
		public static string? RUR {get; set;}
		public static string? SAR {get; set;}
		public static string? SCR {get; set;}
		public static string? SEK {get; set;}
		public static string? SGD {get; set;}
		public static string? SKP {get; set;}
		public static string? THB {get; set;}
		public static string? TRL {get; set;}
		public static string? TTD {get; set;}
		public static string? TWD {get; set;}
		public static string? USD {get; set;}
		public static string? VEB {get; set;}
		public static string? VND {get; set;}
		public static string? XEU {get; set;}
		public static string? ZAR {get; set;}
		public static string? ZWD {get; set;}
		public static string? NOK {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurtainWallTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDamperTypeEnum: IFC_Attribute
	{
		public static string? CONTROLDAMPER {get; set;}
		public static string? FIREDAMPER {get; set;}
		public static string? SMOKEDAMPER {get; set;}
		public static string? FIRESMOKEDAMPER {get; set;}
		public static string? BACKDRAFTDAMPER {get; set;}
		public static string? RELIEFDAMPER {get; set;}
		public static string? BLASTDAMPER {get; set;}
		public static string? GRAVITYDAMPER {get; set;}
		public static string? GRAVITYRELIEFDAMPER {get; set;}
		public static string? BALANCINGDAMPER {get; set;}
		public static string? FUMEHOODEXHAUST {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDataOriginEnum: IFC_Attribute
	{
		public static string? MEASURED {get; set;}
		public static string? PREDICTED {get; set;}
		public static string? SIMULATED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDerivedUnitEnum: IFC_Attribute
	{
		public static string? ANGULARVELOCITYUNIT {get; set;}
		public static string? COMPOUNDPLANEANGLEUNIT {get; set;}
		public static string? DYNAMICVISCOSITYUNIT {get; set;}
		public static string? HEATFLUXDENSITYUNIT {get; set;}
		public static string? INTEGERCOUNTRATEUNIT {get; set;}
		public static string? ISOTHERMALMOISTURECAPACITYUNIT {get; set;}
		public static string? KINEMATICVISCOSITYUNIT {get; set;}
		public static string? LINEARVELOCITYUNIT {get; set;}
		public static string? MASSDENSITYUNIT {get; set;}
		public static string? MASSFLOWRATEUNIT {get; set;}
		public static string? MOISTUREDIFFUSIVITYUNIT {get; set;}
		public static string? MOLECULARWEIGHTUNIT {get; set;}
		public static string? SPECIFICHEATCAPACITYUNIT {get; set;}
		public static string? THERMALADMITTANCEUNIT {get; set;}
		public static string? THERMALCONDUCTANCEUNIT {get; set;}
		public static string? THERMALRESISTANCEUNIT {get; set;}
		public static string? THERMALTRANSMITTANCEUNIT {get; set;}
		public static string? VAPORPERMEABILITYUNIT {get; set;}
		public static string? VOLUMETRICFLOWRATEUNIT {get; set;}
		public static string? ROTATIONALFREQUENCYUNIT {get; set;}
		public static string? TORQUEUNIT {get; set;}
		public static string? MOMENTOFINERTIAUNIT {get; set;}
		public static string? LINEARMOMENTUNIT {get; set;}
		public static string? LINEARFORCEUNIT {get; set;}
		public static string? PLANARFORCEUNIT {get; set;}
		public static string? MODULUSOFELASTICITYUNIT {get; set;}
		public static string? SHEARMODULUSUNIT {get; set;}
		public static string? LINEARSTIFFNESSUNIT {get; set;}
		public static string? ROTATIONALSTIFFNESSUNIT {get; set;}
		public static string? MODULUSOFSUBGRADEREACTIONUNIT {get; set;}
		public static string? ACCELERATIONUNIT {get; set;}
		public static string? CURVATUREUNIT {get; set;}
		public static string? HEATINGVALUEUNIT {get; set;}
		public static string? IONCONCENTRATIONUNIT {get; set;}
		public static string? LUMINOUSINTENSITYDISTRIBUTIONUNIT {get; set;}
		public static string? MASSPERLENGTHUNIT {get; set;}
		public static string? MODULUSOFLINEARSUBGRADEREACTIONUNIT {get; set;}
		public static string? MODULUSOFROTATIONALSUBGRADEREACTIONUNIT {get; set;}
		public static string? PHUNIT {get; set;}
		public static string? ROTATIONALMASSUNIT {get; set;}
		public static string? SECTIONAREAINTEGRALUNIT {get; set;}
		public static string? SECTIONMODULUSUNIT {get; set;}
		public static string? SOUNDPOWERUNIT {get; set;}
		public static string? SOUNDPRESSUREUNIT {get; set;}
		public static string? TEMPERATUREGRADIENTUNIT {get; set;}
		public static string? THERMALEXPANSIONCOEFFICIENTUNIT {get; set;}
		public static string? WARPINGCONSTANTUNIT {get; set;}
		public static string? WARPINGMOMENTUNIT {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionExtentUsage: IFC_Attribute
	{
		public static string? ORIGIN {get; set;}
		public static string? TARGET {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDirectionSenseEnum: IFC_Attribute
	{
		public static string? POSITIVE {get; set;}
		public static string? NEGATIVE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionChamberElementTypeEnum: IFC_Attribute
	{
		public static string? FORMEDDUCT {get; set;}
		public static string? INSPECTIONCHAMBER {get; set;}
		public static string? INSPECTIONPIT {get; set;}
		public static string? MANHOLE {get; set;}
		public static string? METERCHAMBER {get; set;}
		public static string? SUMP {get; set;}
		public static string? TRENCH {get; set;}
		public static string? VALVECHAMBER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentConfidentialityEnum: IFC_Attribute
	{
		public static string? PUBLIC {get; set;}
		public static string? RESTRICTED {get; set;}
		public static string? CONFIDENTIAL {get; set;}
		public static string? PERSONAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentStatusEnum: IFC_Attribute
	{
		public static string? DRAFT {get; set;}
		public static string? FINALDRAFT {get; set;}
		public static string? FINAL {get; set;}
		public static string? REVISION {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorPanelOperationEnum: IFC_Attribute
	{
		public static string? SWINGING {get; set;}
		public static string? DOUBLE_ACTING {get; set;}
		public static string? SLIDING {get; set;}
		public static string? FOLDING {get; set;}
		public static string? REVOLVING {get; set;}
		public static string? ROLLINGUP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorPanelPositionEnum: IFC_Attribute
	{
		public static string? LEFT {get; set;}
		public static string? MIDDLE {get; set;}
		public static string? RIGHT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorStyleConstructionEnum: IFC_Attribute
	{
		public static string? ALUMINIUM {get; set;}
		public static string? HIGH_GRADE_STEEL {get; set;}
		public static string? STEEL {get; set;}
		public static string? WOOD {get; set;}
		public static string? ALUMINIUM_WOOD {get; set;}
		public static string? ALUMINIUM_PLASTIC {get; set;}
		public static string? PLASTIC {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorStyleOperationEnum: IFC_Attribute
	{
		public static string? SINGLE_SWING_LEFT {get; set;}
		public static string? SINGLE_SWING_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT {get; set;}
		public static string? DOUBLE_SWING_LEFT {get; set;}
		public static string? DOUBLE_SWING_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_DOUBLE_SWING {get; set;}
		public static string? SLIDING_TO_LEFT {get; set;}
		public static string? SLIDING_TO_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_SLIDING {get; set;}
		public static string? FOLDING_TO_LEFT {get; set;}
		public static string? FOLDING_TO_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_FOLDING {get; set;}
		public static string? REVOLVING {get; set;}
		public static string? ROLLINGUP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctFittingTypeEnum: IFC_Attribute
	{
		public static string? BEND {get; set;}
		public static string? CONNECTOR {get; set;}
		public static string? ENTRY {get; set;}
		public static string? EXIT {get; set;}
		public static string? JUNCTION {get; set;}
		public static string? OBSTRUCTION {get; set;}
		public static string? TRANSITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSegmentTypeEnum: IFC_Attribute
	{
		public static string? RIGIDSEGMENT {get; set;}
		public static string? FLEXIBLESEGMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSilencerTypeEnum: IFC_Attribute
	{
		public static string? FLATOVAL {get; set;}
		public static string? RECTANGULAR {get; set;}
		public static string? ROUND {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricApplianceTypeEnum: IFC_Attribute
	{
		public static string? DISHWASHER {get; set;}
		public static string? ELECTRICCOOKER {get; set;}
		public static string? FREESTANDINGFAN {get; set;}
		public static string? FREEZER {get; set;}
		public static string? FRIDGE_FREEZER {get; set;}
		public static string? HANDDRYER {get; set;}
		public static string? MICROWAVE {get; set;}
		public static string? PHOTOCOPIER {get; set;}
		public static string? REFRIGERATOR {get; set;}
		public static string? TUMBLEDRYER {get; set;}
		public static string? VENDINGMACHINE {get; set;}
		public static string? WASHINGMACHINE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricCurrentEnum: IFC_Attribute
	{
		public static string? ALTERNATING {get; set;}
		public static string? DIRECT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricDistributionPointFunctionEnum: IFC_Attribute
	{
		public static string? ALARMPANEL {get; set;}
		public static string? CONSUMERUNIT {get; set;}
		public static string? CONTROLPANEL {get; set;}
		public static string? DISTRIBUTIONBOARD {get; set;}
		public static string? GASDETECTORPANEL {get; set;}
		public static string? INDICATORPANEL {get; set;}
		public static string? MIMICPANEL {get; set;}
		public static string? MOTORCONTROLCENTRE {get; set;}
		public static string? SWITCHBOARD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowStorageDeviceTypeEnum: IFC_Attribute
	{
		public static string? BATTERY {get; set;}
		public static string? CAPACITORBANK {get; set;}
		public static string? HARMONICFILTER {get; set;}
		public static string? INDUCTORBANK {get; set;}
		public static string? UPS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricGeneratorTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricHeaterTypeEnum: IFC_Attribute
	{
		public static string? ELECTRICPOINTHEATER {get; set;}
		public static string? ELECTRICCABLEHEATER {get; set;}
		public static string? ELECTRICMATHEATER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricMotorTypeEnum: IFC_Attribute
	{
		public static string? DC {get; set;}
		public static string? INDUCTION {get; set;}
		public static string? POLYPHASE {get; set;}
		public static string? RELUCTANCESYNCHRONOUS {get; set;}
		public static string? SYNCHRONOUS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricTimeControlTypeEnum: IFC_Attribute
	{
		public static string? TIMECLOCK {get; set;}
		public static string? TIMEDELAY {get; set;}
		public static string? RELAY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElementAssemblyTypeEnum: IFC_Attribute
	{
		public static string? ACCESSORY_ASSEMBLY {get; set;}
		public static string? ARCH {get; set;}
		public static string? BEAM_GRID {get; set;}
		public static string? BRACED_FRAME {get; set;}
		public static string? GIRDER {get; set;}
		public static string? REINFORCEMENT_UNIT {get; set;}
		public static string? RIGID_FRAME {get; set;}
		public static string? SLAB_FIELD {get; set;}
		public static string? TRUSS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElementCompositionEnum: IFC_Attribute
	{
		public static string? COMPLEX {get; set;}
		public static string? ELEMENT {get; set;}
		public static string? PARTIAL {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEnergySequenceEnum: IFC_Attribute
	{
		public static string? PRIMARY {get; set;}
		public static string? SECONDARY {get; set;}
		public static string? TERTIARY {get; set;}
		public static string? AUXILIARY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEnvironmentalImpactCategoryEnum: IFC_Attribute
	{
		public static string? COMBINEDVALUE {get; set;}
		public static string? DISPOSAL {get; set;}
		public static string? EXTRACTION {get; set;}
		public static string? INSTALLATION {get; set;}
		public static string? MANUFACTURE {get; set;}
		public static string? TRANSPORTATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporativeCoolerTypeEnum: IFC_Attribute
	{
		public static string? DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER {get; set;}
		public static string? DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER {get; set;}
		public static string? DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER {get; set;}
		public static string? DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER {get; set;}
		public static string? DIRECTEVAPORATIVEAIRWASHER {get; set;}
		public static string? INDIRECTEVAPORATIVEPACKAGEAIRCOOLER {get; set;}
		public static string? INDIRECTEVAPORATIVEWETCOIL {get; set;}
		public static string? INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER {get; set;}
		public static string? INDIRECTDIRECTCOMBINATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporatorTypeEnum: IFC_Attribute
	{
		public static string? DIRECTEXPANSIONSHELLANDTUBE {get; set;}
		public static string? DIRECTEXPANSIONTUBEINTUBE {get; set;}
		public static string? DIRECTEXPANSIONBRAZEDPLATE {get; set;}
		public static string? FLOODEDSHELLANDTUBE {get; set;}
		public static string? SHELLANDCOIL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFanTypeEnum: IFC_Attribute
	{
		public static string? CENTRIFUGALFORWARDCURVED {get; set;}
		public static string? CENTRIFUGALRADIAL {get; set;}
		public static string? CENTRIFUGALBACKWARDINCLINEDCURVED {get; set;}
		public static string? CENTRIFUGALAIRFOIL {get; set;}
		public static string? TUBEAXIAL {get; set;}
		public static string? VANEAXIAL {get; set;}
		public static string? PROPELLORAXIAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFilterTypeEnum: IFC_Attribute
	{
		public static string? AIRPARTICLEFILTER {get; set;}
		public static string? ODORFILTER {get; set;}
		public static string? OILFILTER {get; set;}
		public static string? STRAINER {get; set;}
		public static string? WATERFILTER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFireSuppressionTerminalTypeEnum: IFC_Attribute
	{
		public static string? BREECHINGINLET {get; set;}
		public static string? FIREHYDRANT {get; set;}
		public static string? HOSEREEL {get; set;}
		public static string? SPRINKLER {get; set;}
		public static string? SPRINKLERDEFLECTOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowDirectionEnum: IFC_Attribute
	{
		public static string? SOURCE {get; set;}
		public static string? SINK {get; set;}
		public static string? SOURCEANDSINK {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowInstrumentTypeEnum: IFC_Attribute
	{
		public static string? PRESSUREGAUGE {get; set;}
		public static string? THERMOMETER {get; set;}
		public static string? AMMETER {get; set;}
		public static string? FREQUENCYMETER {get; set;}
		public static string? POWERFACTORMETER {get; set;}
		public static string? PHASEANGLEMETER {get; set;}
		public static string? VOLTMETER_PEAK {get; set;}
		public static string? VOLTMETER_RMS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowMeterTypeEnum: IFC_Attribute
	{
		public static string? ENERGYMETER {get; set;}
		public static string? GASMETER {get; set;}
		public static string? OILMETER {get; set;}
		public static string? WATERMETER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFootingTypeEnum: IFC_Attribute
	{
		public static string? FOOTING_BEAM {get; set;}
		public static string? PAD_FOOTING {get; set;}
		public static string? PILE_CAP {get; set;}
		public static string? STRIP_FOOTING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGasTerminalTypeEnum: IFC_Attribute
	{
		public static string? GASAPPLIANCE {get; set;}
		public static string? GASBOOSTER {get; set;}
		public static string? GASBURNER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricProjectionEnum: IFC_Attribute
	{
		public static string? GRAPH_VIEW {get; set;}
		public static string? SKETCH_VIEW {get; set;}
		public static string? MODEL_VIEW {get; set;}
		public static string? PLAN_VIEW {get; set;}
		public static string? REFLECTED_PLAN_VIEW {get; set;}
		public static string? SECTION_VIEW {get; set;}
		public static string? ELEVATION_VIEW {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGlobalOrLocalEnum: IFC_Attribute
	{
		public static string? GLOBAL_COORDS {get; set;}
		public static string? LOCAL_COORDS {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCHeatExchangerTypeEnum: IFC_Attribute
	{
		public static string? PLATE {get; set;}
		public static string? SHELLANDTUBE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCHumidifierTypeEnum: IFC_Attribute
	{
		public static string? STEAMINJECTION {get; set;}
		public static string? ADIABATICAIRWASHER {get; set;}
		public static string? ADIABATICPAN {get; set;}
		public static string? ADIABATICWETTEDELEMENT {get; set;}
		public static string? ADIABATICATOMIZING {get; set;}
		public static string? ADIABATICULTRASONIC {get; set;}
		public static string? ADIABATICRIGIDMEDIA {get; set;}
		public static string? ADIABATICCOMPRESSEDAIRNOZZLE {get; set;}
		public static string? ASSISTEDELECTRIC {get; set;}
		public static string? ASSISTEDNATURALGAS {get; set;}
		public static string? ASSISTEDPROPANE {get; set;}
		public static string? ASSISTEDBUTANE {get; set;}
		public static string? ASSISTEDSTEAM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInternalOrExternalEnum: IFC_Attribute
	{
		public static string? INTERNAL {get; set;}
		public static string? EXTERNAL {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInventoryTypeEnum: IFC_Attribute
	{
		public static string? ASSETINVENTORY {get; set;}
		public static string? SPACEINVENTORY {get; set;}
		public static string? FURNITUREINVENTORY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCJunctionBoxTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLampTypeEnum: IFC_Attribute
	{
		public static string? COMPACTFLUORESCENT {get; set;}
		public static string? FLUORESCENT {get; set;}
		public static string? HIGHPRESSUREMERCURY {get; set;}
		public static string? HIGHPRESSURESODIUM {get; set;}
		public static string? METALHALIDE {get; set;}
		public static string? TUNGSTENFILAMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLayerSetDirectionEnum: IFC_Attribute
	{
		public static string? AXIS1 {get; set;}
		public static string? AXIS2 {get; set;}
		public static string? AXIS3 {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightDistributionCurveEnum: IFC_Attribute
	{
		public static string? TYPE_A {get; set;}
		public static string? TYPE_B {get; set;}
		public static string? TYPE_C {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightEmissionSourceEnum: IFC_Attribute
	{
		public static string? COMPACTFLUORESCENT {get; set;}
		public static string? FLUORESCENT {get; set;}
		public static string? HIGHPRESSUREMERCURY {get; set;}
		public static string? HIGHPRESSURESODIUM {get; set;}
		public static string? LIGHTEMITTINGDIODE {get; set;}
		public static string? LOWPRESSURESODIUM {get; set;}
		public static string? LOWVOLTAGEHALOGEN {get; set;}
		public static string? MAINVOLTAGEHALOGEN {get; set;}
		public static string? METALHALIDE {get; set;}
		public static string? TUNGSTENFILAMENT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightFixtureTypeEnum: IFC_Attribute
	{
		public static string? POINTSOURCE {get; set;}
		public static string? DIRECTIONSOURCE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLoadGroupTypeEnum: IFC_Attribute
	{
		public static string? LOAD_GROUP {get; set;}
		public static string? LOAD_CASE {get; set;}
		public static string? LOAD_COMBINATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLogicalOperatorEnum: IFC_Attribute
	{
		public static string? LOGICALAND {get; set;}
		public static string? LOGICALOR {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMemberTypeEnum: IFC_Attribute
	{
		public static string? BRACE {get; set;}
		public static string? CHORD {get; set;}
		public static string? COLLAR {get; set;}
		public static string? MEMBER {get; set;}
		public static string? MULLION {get; set;}
		public static string? PLATE {get; set;}
		public static string? POST {get; set;}
		public static string? PURLIN {get; set;}
		public static string? RAFTER {get; set;}
		public static string? STRINGER {get; set;}
		public static string? STRUT {get; set;}
		public static string? STUD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMotorConnectionTypeEnum: IFC_Attribute
	{
		public static string? BELTDRIVE {get; set;}
		public static string? COUPLING {get; set;}
		public static string? DIRECTDRIVE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCNullStyle: IFC_Attribute
	{
		public static string? NULL {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCObjectTypeEnum: IFC_Attribute
	{
		public static string? PRODUCT {get; set;}
		public static string? PROCESS {get; set;}
		public static string? CONTROL {get; set;}
		public static string? RESOURCE {get; set;}
		public static string? ACTOR {get; set;}
		public static string? GROUP {get; set;}
		public static string? PROJECT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCObjectiveEnum: IFC_Attribute
	{
		public static string? CODECOMPLIANCE {get; set;}
		public static string? DESIGNINTENT {get; set;}
		public static string? HEALTHANDSAFETY {get; set;}
		public static string? REQUIREMENT {get; set;}
		public static string? SPECIFICATION {get; set;}
		public static string? TRIGGERCONDITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOccupantTypeEnum: IFC_Attribute
	{
		public static string? ASSIGNEE {get; set;}
		public static string? ASSIGNOR {get; set;}
		public static string? LESSEE {get; set;}
		public static string? LESSOR {get; set;}
		public static string? LETTINGAGENT {get; set;}
		public static string? OWNER {get; set;}
		public static string? TENANT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOutletTypeEnum: IFC_Attribute
	{
		public static string? AUDIOVISUALOUTLET {get; set;}
		public static string? COMMUNICATIONSOUTLET {get; set;}
		public static string? POWEROUTLET {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPermeableCoveringOperationEnum: IFC_Attribute
	{
		public static string? GRILL {get; set;}
		public static string? LOUVER {get; set;}
		public static string? SCREEN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPhysicalOrVirtualEnum: IFC_Attribute
	{
		public static string? PHYSICAL {get; set;}
		public static string? VIRTUAL {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPileConstructionEnum: IFC_Attribute
	{
		public static string? CAST_IN_PLACE {get; set;}
		public static string? COMPOSITE {get; set;}
		public static string? PRECAST_CONCRETE {get; set;}
		public static string? PREFAB_STEEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPileTypeEnum: IFC_Attribute
	{
		public static string? COHESION {get; set;}
		public static string? FRICTION {get; set;}
		public static string? SUPPORT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeFittingTypeEnum: IFC_Attribute
	{
		public static string? BEND {get; set;}
		public static string? CONNECTOR {get; set;}
		public static string? ENTRY {get; set;}
		public static string? EXIT {get; set;}
		public static string? JUNCTION {get; set;}
		public static string? OBSTRUCTION {get; set;}
		public static string? TRANSITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeSegmentTypeEnum: IFC_Attribute
	{
		public static string? FLEXIBLESEGMENT {get; set;}
		public static string? RIGIDSEGMENT {get; set;}
		public static string? GUTTER {get; set;}
		public static string? SPOOL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPlateTypeEnum: IFC_Attribute
	{
		public static string? CURTAIN_PANEL {get; set;}
		public static string? SHEET {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProcedureTypeEnum: IFC_Attribute
	{
		public static string? ADVICE_CAUTION {get; set;}
		public static string? ADVICE_NOTE {get; set;}
		public static string? ADVICE_WARNING {get; set;}
		public static string? CALIBRATION {get; set;}
		public static string? DIAGNOSTIC {get; set;}
		public static string? SHUTDOWN {get; set;}
		public static string? STARTUP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProfileTypeEnum: IFC_Attribute
	{
		public static string? CURVE {get; set;}
		public static string? AREA {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectOrderRecordTypeEnum: IFC_Attribute
	{
		public static string? CHANGE {get; set;}
		public static string? MAINTENANCE {get; set;}
		public static string? MOVE {get; set;}
		public static string? PURCHASE {get; set;}
		public static string? WORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectOrderTypeEnum: IFC_Attribute
	{
		public static string? CHANGEORDER {get; set;}
		public static string? MAINTENANCEWORKORDER {get; set;}
		public static string? MOVEORDER {get; set;}
		public static string? PURCHASEORDER {get; set;}
		public static string? WORKORDER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectedOrTrueLengthEnum: IFC_Attribute
	{
		public static string? PROJECTED_LENGTH {get; set;}
		public static string? TRUE_LENGTH {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySourceEnum: IFC_Attribute
	{
		public static string? DESIGN {get; set;}
		public static string? DESIGNMAXIMUM {get; set;}
		public static string? DESIGNMINIMUM {get; set;}
		public static string? SIMULATED {get; set;}
		public static string? ASBUILT {get; set;}
		public static string? COMMISSIONING {get; set;}
		public static string? MEASURED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTKNOWN {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDeviceTypeEnum: IFC_Attribute
	{
		public static string? FUSEDISCONNECTOR {get; set;}
		public static string? CIRCUITBREAKER {get; set;}
		public static string? RESIDUALCURRENTCIRCUITBREAKER {get; set;}
		public static string? RESIDUALCURRENTSWITCH {get; set;}
		public static string? VARISTOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPumpTypeEnum: IFC_Attribute
	{
		public static string? CIRCULATOR {get; set;}
		public static string? ENDSUCTION {get; set;}
		public static string? SPLITCASE {get; set;}
		public static string? VERTICALINLINE {get; set;}
		public static string? VERTICALTURBINE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRailingTypeEnum: IFC_Attribute
	{
		public static string? HANDRAIL {get; set;}
		public static string? GUARDRAIL {get; set;}
		public static string? BALUSTRADE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRampFlightTypeEnum: IFC_Attribute
	{
		public static string? STRAIGHT {get; set;}
		public static string? SPIRAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRampTypeEnum: IFC_Attribute
	{
		public static string? STRAIGHT_RUN_RAMP {get; set;}
		public static string? TWO_STRAIGHT_RUN_RAMP {get; set;}
		public static string? QUARTER_TURN_RAMP {get; set;}
		public static string? TWO_QUARTER_TURN_RAMP {get; set;}
		public static string? HALF_TURN_RAMP {get; set;}
		public static string? SPIRAL_RAMP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReflectanceMethodEnum: IFC_Attribute
	{
		public static string? BLINN {get; set;}
		public static string? FLAT {get; set;}
		public static string? GLASS {get; set;}
		public static string? MATT {get; set;}
		public static string? METAL {get; set;}
		public static string? MIRROR {get; set;}
		public static string? PHONG {get; set;}
		public static string? PLASTIC {get; set;}
		public static string? STRAUSS {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingBarRoleEnum: IFC_Attribute
	{
		public static string? MAIN {get; set;}
		public static string? SHEAR {get; set;}
		public static string? LIGATURE {get; set;}
		public static string? STUD {get; set;}
		public static string? PUNCHING {get; set;}
		public static string? EDGE {get; set;}
		public static string? RING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingBarSurfaceEnum: IFC_Attribute
	{
		public static string? PLAIN {get; set;}
		public static string? TEXTURED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceConsumptionEnum: IFC_Attribute
	{
		public static string? CONSUMED {get; set;}
		public static string? PARTIALLYCONSUMED {get; set;}
		public static string? NOTCONSUMED {get; set;}
		public static string? OCCUPIED {get; set;}
		public static string? PARTIALLYOCCUPIED {get; set;}
		public static string? NOTOCCUPIED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRibPlateDirectionEnum: IFC_Attribute
	{
		public static string? DIRECTION_X {get; set;}
		public static string? DIRECTION_Y {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoleEnum: IFC_Attribute
	{
		public static string? SUPPLIER {get; set;}
		public static string? MANUFACTURER {get; set;}
		public static string? CONTRACTOR {get; set;}
		public static string? SUBCONTRACTOR {get; set;}
		public static string? ARCHITECT {get; set;}
		public static string? STRUCTURALENGINEER {get; set;}
		public static string? COSTENGINEER {get; set;}
		public static string? CLIENT {get; set;}
		public static string? BUILDINGOWNER {get; set;}
		public static string? BUILDINGOPERATOR {get; set;}
		public static string? MECHANICALENGINEER {get; set;}
		public static string? ELECTRICALENGINEER {get; set;}
		public static string? PROJECTMANAGER {get; set;}
		public static string? FACILITIESMANAGER {get; set;}
		public static string? CIVILENGINEER {get; set;}
		public static string? ENGINEER {get; set;}
		public static string? OWNER {get; set;}
		public static string? CONSULTANT {get; set;}
		public static string? CONSTRUCTIONMANAGER {get; set;}
		public static string? FIELDCONSTRUCTIONMANAGER {get; set;}
		public static string? RESELLER {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoofTypeEnum: IFC_Attribute
	{
		public static string? FLAT_ROOF {get; set;}
		public static string? SHED_ROOF {get; set;}
		public static string? GABLE_ROOF {get; set;}
		public static string? HIP_ROOF {get; set;}
		public static string? HIPPED_GABLE_ROOF {get; set;}
		public static string? GAMBREL_ROOF {get; set;}
		public static string? MANSARD_ROOF {get; set;}
		public static string? BARREL_ROOF {get; set;}
		public static string? RAINBOW_ROOF {get; set;}
		public static string? BUTTERFLY_ROOF {get; set;}
		public static string? PAVILION_ROOF {get; set;}
		public static string? DOME_ROOF {get; set;}
		public static string? FREEFORM {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSIPrefix: IFC_Attribute
	{
		public static string? EXA {get; set;}
		public static string? PETA {get; set;}
		public static string? TERA {get; set;}
		public static string? GIGA {get; set;}
		public static string? MEGA {get; set;}
		public static string? KILO {get; set;}
		public static string? HECTO {get; set;}
		public static string? DECA {get; set;}
		public static string? DECI {get; set;}
		public static string? CENTI {get; set;}
		public static string? MILLI {get; set;}
		public static string? MICRO {get; set;}
		public static string? NANO {get; set;}
		public static string? PICO {get; set;}
		public static string? FEMTO {get; set;}
		public static string? ATTO {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSIUnitName: IFC_Attribute
	{
		public static string? AMPERE {get; set;}
		public static string? BECQUEREL {get; set;}
		public static string? CANDELA {get; set;}
		public static string? COULOMB {get; set;}
		public static string? CUBIC_METRE {get; set;}
		public static string? DEGREE_CELSIUS {get; set;}
		public static string? FARAD {get; set;}
		public static string? GRAM {get; set;}
		public static string? GRAY {get; set;}
		public static string? HENRY {get; set;}
		public static string? HERTZ {get; set;}
		public static string? JOULE {get; set;}
		public static string? KELVIN {get; set;}
		public static string? LUMEN {get; set;}
		public static string? LUX {get; set;}
		public static string? METRE {get; set;}
		public static string? MOLE {get; set;}
		public static string? NEWTON {get; set;}
		public static string? OHM {get; set;}
		public static string? PASCAL {get; set;}
		public static string? RADIAN {get; set;}
		public static string? SECOND {get; set;}
		public static string? SIEMENS {get; set;}
		public static string? SIEVERT {get; set;}
		public static string? SQUARE_METRE {get; set;}
		public static string? STERADIAN {get; set;}
		public static string? TESLA {get; set;}
		public static string? VOLT {get; set;}
		public static string? WATT {get; set;}
		public static string? WEBER {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSanitaryTerminalTypeEnum: IFC_Attribute
	{
		public static string? BATH {get; set;}
		public static string? BIDET {get; set;}
		public static string? CISTERN {get; set;}
		public static string? SHOWER {get; set;}
		public static string? SINK {get; set;}
		public static string? SANITARYFOUNTAIN {get; set;}
		public static string? TOILETPAN {get; set;}
		public static string? URINAL {get; set;}
		public static string? WASHHANDBASIN {get; set;}
		public static string? WCSEAT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionTypeEnum: IFC_Attribute
	{
		public static string? UNIFORM {get; set;}
		public static string? TAPERED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSensorTypeEnum: IFC_Attribute
	{
		public static string? CO2SENSOR {get; set;}
		public static string? FIRESENSOR {get; set;}
		public static string? FLOWSENSOR {get; set;}
		public static string? GASSENSOR {get; set;}
		public static string? HEATSENSOR {get; set;}
		public static string? HUMIDITYSENSOR {get; set;}
		public static string? LIGHTSENSOR {get; set;}
		public static string? MOISTURESENSOR {get; set;}
		public static string? MOVEMENTSENSOR {get; set;}
		public static string? PRESSURESENSOR {get; set;}
		public static string? SMOKESENSOR {get; set;}
		public static string? SOUNDSENSOR {get; set;}
		public static string? TEMPERATURESENSOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSequenceEnum: IFC_Attribute
	{
		public static string? START_START {get; set;}
		public static string? START_FINISH {get; set;}
		public static string? FINISH_START {get; set;}
		public static string? FINISH_FINISH {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCServiceLifeFactorTypeEnum: IFC_Attribute
	{
		public static string? A_QUALITYOFCOMPONENTS {get; set;}
		public static string? B_DESIGNLEVEL {get; set;}
		public static string? C_WORKEXECUTIONLEVEL {get; set;}
		public static string? D_INDOORENVIRONMENT {get; set;}
		public static string? E_OUTDOORENVIRONMENT {get; set;}
		public static string? F_INUSECONDITIONS {get; set;}
		public static string? G_MAINTENANCELEVEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCServiceLifeTypeEnum: IFC_Attribute
	{
		public static string? ACTUALSERVICELIFE {get; set;}
		public static string? EXPECTEDSERVICELIFE {get; set;}
		public static string? OPTIMISTICREFERENCESERVICELIFE {get; set;}
		public static string? PESSIMISTICREFERENCESERVICELIFE {get; set;}
		public static string? REFERENCESERVICELIFE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSlabTypeEnum: IFC_Attribute
	{
		public static string? FLOOR {get; set;}
		public static string? ROOF {get; set;}
		public static string? LANDING {get; set;}
		public static string? BASESLAB {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundScaleEnum: IFC_Attribute
	{
		public static string? DBA {get; set;}
		public static string? DBB {get; set;}
		public static string? DBC {get; set;}
		public static string? NC {get; set;}
		public static string? NR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceHeaterTypeEnum: IFC_Attribute
	{
		public static string? CONVECTOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStackTerminalTypeEnum: IFC_Attribute
	{
		public static string? BIRDCAGE {get; set;}
		public static string? COWL {get; set;}
		public static string? RAINWATERHOPPER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStairFlightTypeEnum: IFC_Attribute
	{
		public static string? STRAIGHT {get; set;}
		public static string? WINDER {get; set;}
		public static string? SPIRAL {get; set;}
		public static string? CURVED {get; set;}
		public static string? FREEFORM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStairTypeEnum: IFC_Attribute
	{
		public static string? STRAIGHT_RUN_STAIR {get; set;}
		public static string? TWO_STRAIGHT_RUN_STAIR {get; set;}
		public static string? QUARTER_WINDING_STAIR {get; set;}
		public static string? QUARTER_TURN_STAIR {get; set;}
		public static string? HALF_WINDING_STAIR {get; set;}
		public static string? HALF_TURN_STAIR {get; set;}
		public static string? TWO_QUARTER_WINDING_STAIR {get; set;}
		public static string? TWO_QUARTER_TURN_STAIR {get; set;}
		public static string? THREE_QUARTER_WINDING_STAIR {get; set;}
		public static string? THREE_QUARTER_TURN_STAIR {get; set;}
		public static string? SPIRAL_STAIR {get; set;}
		public static string? DOUBLE_RETURN_STAIR {get; set;}
		public static string? CURVED_RUN_STAIR {get; set;}
		public static string? TWO_CURVED_RUN_STAIR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStateEnum: IFC_Attribute
	{
		public static string? READWRITE {get; set;}
		public static string? READONLY {get; set;}
		public static string? LOCKED {get; set;}
		public static string? READWRITELOCKED {get; set;}
		public static string? READONLYLOCKED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveTypeEnum: IFC_Attribute
	{
		public static string? RIGID_JOINED_MEMBER {get; set;}
		public static string? PIN_JOINED_MEMBER {get; set;}
		public static string? CABLE {get; set;}
		public static string? TENSION_MEMBER {get; set;}
		public static string? COMPRESSION_MEMBER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceTypeEnum: IFC_Attribute
	{
		public static string? BENDING_ELEMENT {get; set;}
		public static string? MEMBRANE_ELEMENT {get; set;}
		public static string? SHELL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceSide: IFC_Attribute
	{
		public static string? POSITIVE {get; set;}
		public static string? NEGATIVE {get; set;}
		public static string? BOTH {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceTextureEnum: IFC_Attribute
	{
		public static string? BUMP {get; set;}
		public static string? OPACITY {get; set;}
		public static string? REFLECTION {get; set;}
		public static string? SELFILLUMINATION {get; set;}
		public static string? SHININESS {get; set;}
		public static string? SPECULAR {get; set;}
		public static string? TEXTURE {get; set;}
		public static string? TRANSPARENCYMAP {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSwitchingDeviceTypeEnum: IFC_Attribute
	{
		public static string? CONTACTOR {get; set;}
		public static string? EMERGENCYSTOP {get; set;}
		public static string? STARTER {get; set;}
		public static string? SWITCHDISCONNECTOR {get; set;}
		public static string? TOGGLESWITCH {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTankTypeEnum: IFC_Attribute
	{
		public static string? EXPANSION {get; set;}
		public static string? PRESSUREVESSEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonTypeEnum: IFC_Attribute
	{
		public static string? STRAND {get; set;}
		public static string? WIRE {get; set;}
		public static string? BAR {get; set;}
		public static string? COATED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextPath: IFC_Attribute
	{
		public static string? LEFT {get; set;}
		public static string? RIGHT {get; set;}
		public static string? UP {get; set;}
		public static string? DOWN {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalLoadSourceEnum: IFC_Attribute
	{
		public static string? PEOPLE {get; set;}
		public static string? LIGHTING {get; set;}
		public static string? EQUIPMENT {get; set;}
		public static string? VENTILATIONINDOORAIR {get; set;}
		public static string? VENTILATIONOUTSIDEAIR {get; set;}
		public static string? RECIRCULATEDAIR {get; set;}
		public static string? EXHAUSTAIR {get; set;}
		public static string? AIREXCHANGERATE {get; set;}
		public static string? DRYBULBTEMPERATURE {get; set;}
		public static string? RELATIVEHUMIDITY {get; set;}
		public static string? INFILTRATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalLoadTypeEnum: IFC_Attribute
	{
		public static string? SENSIBLE {get; set;}
		public static string? LATENT {get; set;}
		public static string? RADIANT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeriesDataTypeEnum: IFC_Attribute
	{
		public static string? CONTINUOUS {get; set;}
		public static string? DISCRETE {get; set;}
		public static string? DISCRETEBINARY {get; set;}
		public static string? PIECEWISEBINARY {get; set;}
		public static string? PIECEWISECONSTANT {get; set;}
		public static string? PIECEWISECONTINUOUS {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeriesScheduleTypeEnum: IFC_Attribute
	{
		public static string? ANNUAL {get; set;}
		public static string? MONTHLY {get; set;}
		public static string? WEEKLY {get; set;}
		public static string? DAILY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTransformerTypeEnum: IFC_Attribute
	{
		public static string? CURRENT {get; set;}
		public static string? FREQUENCY {get; set;}
		public static string? VOLTAGE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTransitionCode: IFC_Attribute
	{
		public static string? DISCONTINUOUS {get; set;}
		public static string? CONTINUOUS {get; set;}
		public static string? CONTSAMEGRADIENT {get; set;}
		public static string? CONTSAMEGRADIENTSAMECURVATURE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTransportElementTypeEnum: IFC_Attribute
	{
		public static string? ELEVATOR {get; set;}
		public static string? ESCALATOR {get; set;}
		public static string? MOVINGWALKWAY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTrimmingPreference: IFC_Attribute
	{
		public static string? CARTESIAN {get; set;}
		public static string? PARAMETER {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTubeBundleTypeEnum: IFC_Attribute
	{
		public static string? FINNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitEnum: IFC_Attribute
	{
		public static string? ABSORBEDDOSEUNIT {get; set;}
		public static string? AMOUNTOFSUBSTANCEUNIT {get; set;}
		public static string? AREAUNIT {get; set;}
		public static string? DOSEEQUIVALENTUNIT {get; set;}
		public static string? ELECTRICCAPACITANCEUNIT {get; set;}
		public static string? ELECTRICCHARGEUNIT {get; set;}
		public static string? ELECTRICCONDUCTANCEUNIT {get; set;}
		public static string? ELECTRICCURRENTUNIT {get; set;}
		public static string? ELECTRICRESISTANCEUNIT {get; set;}
		public static string? ELECTRICVOLTAGEUNIT {get; set;}
		public static string? ENERGYUNIT {get; set;}
		public static string? FORCEUNIT {get; set;}
		public static string? FREQUENCYUNIT {get; set;}
		public static string? ILLUMINANCEUNIT {get; set;}
		public static string? INDUCTANCEUNIT {get; set;}
		public static string? LENGTHUNIT {get; set;}
		public static string? LUMINOUSFLUXUNIT {get; set;}
		public static string? LUMINOUSINTENSITYUNIT {get; set;}
		public static string? MAGNETICFLUXDENSITYUNIT {get; set;}
		public static string? MAGNETICFLUXUNIT {get; set;}
		public static string? MASSUNIT {get; set;}
		public static string? PLANEANGLEUNIT {get; set;}
		public static string? POWERUNIT {get; set;}
		public static string? PRESSUREUNIT {get; set;}
		public static string? RADIOACTIVITYUNIT {get; set;}
		public static string? SOLIDANGLEUNIT {get; set;}
		public static string? THERMODYNAMICTEMPERATUREUNIT {get; set;}
		public static string? TIMEUNIT {get; set;}
		public static string? VOLUMEUNIT {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryEquipmentTypeEnum: IFC_Attribute
	{
		public static string? AIRHANDLER {get; set;}
		public static string? AIRCONDITIONINGUNIT {get; set;}
		public static string? SPLITSYSTEM {get; set;}
		public static string? ROOFTOPUNIT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCValveTypeEnum: IFC_Attribute
	{
		public static string? AIRRELEASE {get; set;}
		public static string? ANTIVACUUM {get; set;}
		public static string? CHANGEOVER {get; set;}
		public static string? CHECK {get; set;}
		public static string? COMMISSIONING {get; set;}
		public static string? DIVERTING {get; set;}
		public static string? DRAWOFFCOCK {get; set;}
		public static string? DOUBLECHECK {get; set;}
		public static string? DOUBLEREGULATING {get; set;}
		public static string? FAUCET {get; set;}
		public static string? FLUSHING {get; set;}
		public static string? GASCOCK {get; set;}
		public static string? GASTAP {get; set;}
		public static string? ISOLATING {get; set;}
		public static string? MIXING {get; set;}
		public static string? PRESSUREREDUCING {get; set;}
		public static string? PRESSURERELIEF {get; set;}
		public static string? REGULATING {get; set;}
		public static string? SAFETYCUTOFF {get; set;}
		public static string? STEAMTRAP {get; set;}
		public static string? STOPCOCK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationIsolatorTypeEnum: IFC_Attribute
	{
		public static string? COMPRESSION {get; set;}
		public static string? SPRING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWallTypeEnum: IFC_Attribute
	{
		public static string? STANDARD {get; set;}
		public static string? POLYGONAL {get; set;}
		public static string? SHEAR {get; set;}
		public static string? ELEMENTEDWALL {get; set;}
		public static string? PLUMBINGWALL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWasteTerminalTypeEnum: IFC_Attribute
	{
		public static string? FLOORTRAP {get; set;}
		public static string? FLOORWASTE {get; set;}
		public static string? GULLYSUMP {get; set;}
		public static string? GULLYTRAP {get; set;}
		public static string? ROOFDRAIN {get; set;}
		public static string? WASTEDISPOSALUNIT {get; set;}
		public static string? WASTETRAP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowPanelOperationEnum: IFC_Attribute
	{
		public static string? SIDEHUNGRIGHTHAND {get; set;}
		public static string? SIDEHUNGLEFTHAND {get; set;}
		public static string? TILTANDTURNRIGHTHAND {get; set;}
		public static string? TILTANDTURNLEFTHAND {get; set;}
		public static string? TOPHUNG {get; set;}
		public static string? BOTTOMHUNG {get; set;}
		public static string? PIVOTHORIZONTAL {get; set;}
		public static string? PIVOTVERTICAL {get; set;}
		public static string? SLIDINGHORIZONTAL {get; set;}
		public static string? SLIDINGVERTICAL {get; set;}
		public static string? REMOVABLECASEMENT {get; set;}
		public static string? FIXEDCASEMENT {get; set;}
		public static string? OTHEROPERATION {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowPanelPositionEnum: IFC_Attribute
	{
		public static string? LEFT {get; set;}
		public static string? MIDDLE {get; set;}
		public static string? RIGHT {get; set;}
		public static string? BOTTOM {get; set;}
		public static string? TOP {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowStyleConstructionEnum: IFC_Attribute
	{
		public static string? ALUMINIUM {get; set;}
		public static string? HIGH_GRADE_STEEL {get; set;}
		public static string? STEEL {get; set;}
		public static string? WOOD {get; set;}
		public static string? ALUMINIUM_WOOD {get; set;}
		public static string? PLASTIC {get; set;}
		public static string? OTHER_CONSTRUCTION {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowStyleOperationEnum: IFC_Attribute
	{
		public static string? SINGLE_PANEL {get; set;}
		public static string? DOUBLE_PANEL_VERTICAL {get; set;}
		public static string? DOUBLE_PANEL_HORIZONTAL {get; set;}
		public static string? TRIPLE_PANEL_VERTICAL {get; set;}
		public static string? TRIPLE_PANEL_BOTTOM {get; set;}
		public static string? TRIPLE_PANEL_TOP {get; set;}
		public static string? TRIPLE_PANEL_LEFT {get; set;}
		public static string? TRIPLE_PANEL_RIGHT {get; set;}
		public static string? TRIPLE_PANEL_HORIZONTAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkControlTypeEnum: IFC_Attribute
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCActionRequestTypeEnum: IFC_Attribute
	{
		public static string? EMAIL {get; set;}
		public static string? FAX {get; set;}
		public static string? PHONE {get; set;}
		public static string? POST {get; set;}
		public static string? VERBAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAudioVisualApplianceTypeEnum: IFC_Attribute
	{
		public static string? AMPLIFIER {get; set;}
		public static string? CAMERA {get; set;}
		public static string? DISPLAY {get; set;}
		public static string? MICROPHONE {get; set;}
		public static string? PLAYER {get; set;}
		public static string? PROJECTOR {get; set;}
		public static string? RECEIVER {get; set;}
		public static string? SPEAKER {get; set;}
		public static string? SWITCHER {get; set;}
		public static string? TELEPHONE {get; set;}
		public static string? TUNER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineSurfaceForm: IFC_Attribute
	{
		public static string? PLANE_SURF {get; set;}
		public static string? CYLINDRICAL_SURF {get; set;}
		public static string? CONICAL_SURF {get; set;}
		public static string? SPHERICAL_SURF {get; set;}
		public static string? TOROIDAL_SURF {get; set;}
		public static string? SURF_OF_REVOLUTION {get; set;}
		public static string? RULED_SURF {get; set;}
		public static string? GENERALISED_CONE {get; set;}
		public static string? QUADRIC_SURF {get; set;}
		public static string? SURF_OF_LINEAR_EXTRUSION {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementPartTypeEnum: IFC_Attribute
	{
		public static string? INSULATION {get; set;}
		public static string? PRECASTPANEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingSystemTypeEnum: IFC_Attribute
	{
		public static string? FENESTRATION {get; set;}
		public static string? FOUNDATION {get; set;}
		public static string? LOADBEARING {get; set;}
		public static string? OUTERSHELL {get; set;}
		public static string? SHADING {get; set;}
		public static string? TRANSPORT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBurnerTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCableFittingTypeEnum: IFC_Attribute
	{
		public static string? CONNECTOR {get; set;}
		public static string? ENTRY {get; set;}
		public static string? EXIT {get; set;}
		public static string? JUNCTION {get; set;}
		public static string? TRANSITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCChimneyTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCommunicationsApplianceTypeEnum: IFC_Attribute
	{
		public static string? ANTENNA {get; set;}
		public static string? COMPUTER {get; set;}
		public static string? FAX {get; set;}
		public static string? GATEWAY {get; set;}
		public static string? MODEM {get; set;}
		public static string? NETWORKAPPLIANCE {get; set;}
		public static string? NETWORKBRIDGE {get; set;}
		public static string? NETWORKHUB {get; set;}
		public static string? PRINTER {get; set;}
		public static string? REPEATER {get; set;}
		public static string? ROUTER {get; set;}
		public static string? SCANNER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCComplexPropertyTemplateTypeEnum: IFC_Attribute
	{
		public static string? P_COMPLEX {get; set;}
		public static string? Q_COMPLEX {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionEquipmentResourceTypeEnum: IFC_Attribute
	{
		public static string? DEMOLISHING {get; set;}
		public static string? EARTHMOVING {get; set;}
		public static string? ERECTING {get; set;}
		public static string? HEATING {get; set;}
		public static string? LIGHTING {get; set;}
		public static string? PAVING {get; set;}
		public static string? PUMPING {get; set;}
		public static string? TRANSPORTING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionMaterialResourceTypeEnum: IFC_Attribute
	{
		public static string? AGGREGATES {get; set;}
		public static string? CONCRETE {get; set;}
		public static string? DRYWALL {get; set;}
		public static string? FUEL {get; set;}
		public static string? GYPSUM {get; set;}
		public static string? MASONRY {get; set;}
		public static string? METAL {get; set;}
		public static string? PLASTIC {get; set;}
		public static string? WOOD {get; set;}
		public static string? NOTDEFINED {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionProductResourceTypeEnum: IFC_Attribute
	{
		public static string? ASSEMBLY {get; set;}
		public static string? FORMWORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCostItemTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCrewResourceTypeEnum: IFC_Attribute
	{
		public static string? OFFICE {get; set;}
		public static string? SITE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveInterpolationEnum: IFC_Attribute
	{
		public static string? LINEAR {get; set;}
		public static string? LOG_LINEAR {get; set;}
		public static string? LOG_LOG {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDiscreteAccessoryTypeEnum: IFC_Attribute
	{
		public static string? ANCHORPLATE {get; set;}
		public static string? BRACKET {get; set;}
		public static string? SHOE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionPortTypeEnum: IFC_Attribute
	{
		public static string? CABLE {get; set;}
		public static string? CABLECARRIER {get; set;}
		public static string? DUCT {get; set;}
		public static string? PIPE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionSystemEnum: IFC_Attribute
	{
		public static string? AIRCONDITIONING {get; set;}
		public static string? AUDIOVISUAL {get; set;}
		public static string? CHEMICAL {get; set;}
		public static string? CHILLEDWATER {get; set;}
		public static string? COMMUNICATION {get; set;}
		public static string? COMPRESSEDAIR {get; set;}
		public static string? CONDENSERWATER {get; set;}
		public static string? CONTROL {get; set;}
		public static string? CONVEYING {get; set;}
		public static string? DATA {get; set;}
		public static string? DISPOSAL {get; set;}
		public static string? DOMESTICCOLDWATER {get; set;}
		public static string? DOMESTICHOTWATER {get; set;}
		public static string? DRAINAGE {get; set;}
		public static string? EARTHING {get; set;}
		public static string? ELECTRICAL {get; set;}
		public static string? ELECTROACOUSTIC {get; set;}
		public static string? EXHAUST {get; set;}
		public static string? FIREPROTECTION {get; set;}
		public static string? FUEL {get; set;}
		public static string? GAS {get; set;}
		public static string? HAZARDOUS {get; set;}
		public static string? HEATING {get; set;}
		public static string? LIGHTING {get; set;}
		public static string? LIGHTNINGPROTECTION {get; set;}
		public static string? MUNICIPALSOLIDWASTE {get; set;}
		public static string? OIL {get; set;}
		public static string? OPERATIONAL {get; set;}
		public static string? POWERGENERATION {get; set;}
		public static string? RAINWATER {get; set;}
		public static string? REFRIGERATION {get; set;}
		public static string? SECURITY {get; set;}
		public static string? SEWAGE {get; set;}
		public static string? SIGNAL {get; set;}
		public static string? STORMWATER {get; set;}
		public static string? TELEPHONE {get; set;}
		public static string? TV {get; set;}
		public static string? VACUUM {get; set;}
		public static string? VENT {get; set;}
		public static string? VENTILATION {get; set;}
		public static string? WASTEWATER {get; set;}
		public static string? WATERSUPPLY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorTypeEnum: IFC_Attribute
	{
		public static string? DOOR {get; set;}
		public static string? GATE {get; set;}
		public static string? TRAPDOOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorTypeOperationEnum: IFC_Attribute
	{
		public static string? SINGLE_SWING_LEFT {get; set;}
		public static string? SINGLE_SWING_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT {get; set;}
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT {get; set;}
		public static string? DOUBLE_SWING_LEFT {get; set;}
		public static string? DOUBLE_SWING_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_DOUBLE_SWING {get; set;}
		public static string? SLIDING_TO_LEFT {get; set;}
		public static string? SLIDING_TO_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_SLIDING {get; set;}
		public static string? FOLDING_TO_LEFT {get; set;}
		public static string? FOLDING_TO_RIGHT {get; set;}
		public static string? DOUBLE_DOOR_FOLDING {get; set;}
		public static string? REVOLVING {get; set;}
		public static string? ROLLINGUP {get; set;}
		public static string? SWING_FIXED_LEFT {get; set;}
		public static string? SWING_FIXED_RIGHT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricDistributionBoardTypeEnum: IFC_Attribute
	{
		public static string? CONSUMERUNIT {get; set;}
		public static string? DISTRIBUTIONBOARD {get; set;}
		public static string? MOTORCONTROLCENTRE {get; set;}
		public static string? SWITCHBOARD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEngineTypeEnum: IFC_Attribute
	{
		public static string? EXTERNALCOMBUSTION {get; set;}
		public static string? INTERNALCOMBUSTION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEventTriggerTypeEnum: IFC_Attribute
	{
		public static string? EVENTRULE {get; set;}
		public static string? EVENTMESSAGE {get; set;}
		public static string? EVENTTIME {get; set;}
		public static string? EVENTCOMPLEX {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEventTypeEnum: IFC_Attribute
	{
		public static string? STARTEVENT {get; set;}
		public static string? ENDEVENT {get; set;}
		public static string? INTERMEDIATEEVENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalSpatialElementTypeEnum: IFC_Attribute
	{
		public static string? EXTERNAL {get; set;}
		public static string? EXTERNAL_EARTH {get; set;}
		public static string? EXTERNAL_WATER {get; set;}
		public static string? EXTERNAL_FIRE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFastenerTypeEnum: IFC_Attribute
	{
		public static string? GLUE {get; set;}
		public static string? MORTAR {get; set;}
		public static string? WELD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFurnitureTypeEnum: IFC_Attribute
	{
		public static string? CHAIR {get; set;}
		public static string? TABLE {get; set;}
		public static string? DESK {get; set;}
		public static string? BED {get; set;}
		public static string? FILECABINET {get; set;}
		public static string? SHELF {get; set;}
		public static string? SOFA {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGeographicElementTypeEnum: IFC_Attribute
	{
		public static string? TERRAIN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGridTypeEnum: IFC_Attribute
	{
		public static string? RECTANGULAR {get; set;}
		public static string? RADIAL {get; set;}
		public static string? TRIANGULAR {get; set;}
		public static string? IRREGULAR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInterceptorTypeEnum: IFC_Attribute
	{
		public static string? CYCLONIC {get; set;}
		public static string? GREASE {get; set;}
		public static string? OIL {get; set;}
		public static string? PETROL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCKnotType: IFC_Attribute
	{
		public static string? UNIFORM_KNOTS {get; set;}
		public static string? QUASI_UNIFORM_KNOTS {get; set;}
		public static string? PIECEWISE_BEZIER_KNOTS {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLaborResourceTypeEnum: IFC_Attribute
	{
		public static string? ADMINISTRATION {get; set;}
		public static string? CARPENTRY {get; set;}
		public static string? CLEANING {get; set;}
		public static string? CONCRETE {get; set;}
		public static string? DRYWALL {get; set;}
		public static string? ELECTRIC {get; set;}
		public static string? FINISHING {get; set;}
		public static string? FLOORING {get; set;}
		public static string? GENERAL {get; set;}
		public static string? HVAC {get; set;}
		public static string? LANDSCAPING {get; set;}
		public static string? MASONRY {get; set;}
		public static string? PAINTING {get; set;}
		public static string? PAVING {get; set;}
		public static string? PLUMBING {get; set;}
		public static string? ROOFING {get; set;}
		public static string? SITEGRADING {get; set;}
		public static string? STEELWORK {get; set;}
		public static string? SURVEYING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalFastenerTypeEnum: IFC_Attribute
	{
		public static string? ANCHORBOLT {get; set;}
		public static string? BOLT {get; set;}
		public static string? DOWEL {get; set;}
		public static string? NAIL {get; set;}
		public static string? NAILPLATE {get; set;}
		public static string? RIVET {get; set;}
		public static string? SCREW {get; set;}
		public static string? SHEARCONNECTOR {get; set;}
		public static string? STAPLE {get; set;}
		public static string? STUDSHEARCONNECTOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMedicalDeviceTypeEnum: IFC_Attribute
	{
		public static string? AIRSTATION {get; set;}
		public static string? FEEDAIRUNIT {get; set;}
		public static string? OXYGENGENERATOR {get; set;}
		public static string? OXYGENPLANT {get; set;}
		public static string? VACUUMSTATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOpeningElementTypeEnum: IFC_Attribute
	{
		public static string? OPENING {get; set;}
		public static string? RECESS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPerformanceHistoryTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPermitTypeEnum: IFC_Attribute
	{
		public static string? ACCESS {get; set;}
		public static string? BUILDING {get; set;}
		public static string? WORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreferredSurfaceCurveRepresentation: IFC_Attribute
	{
		public static string? CURVE3D {get; set;}
		public static string? PCURVE_S1 {get; set;}
		public static string? PCURVE_S2 {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectionElementTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySetTemplateTypeEnum: IFC_Attribute
	{
		public static string? PSET_TYPEDRIVENONLY {get; set;}
		public static string? PSET_TYPEDRIVENOVERRIDE {get; set;}
		public static string? PSET_OCCURRENCEDRIVEN {get; set;}
		public static string? PSET_PERFORMANCEDRIVEN {get; set;}
		public static string? QTO_TYPEDRIVENONLY {get; set;}
		public static string? QTO_TYPEDRIVENOVERRIDE {get; set;}
		public static string? QTO_OCCURRENCEDRIVEN {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDeviceTrippingUnitTypeEnum: IFC_Attribute
	{
		public static string? ELECTRONIC {get; set;}
		public static string? ELECTROMAGNETIC {get; set;}
		public static string? RESIDUALCURRENT {get; set;}
		public static string? THERMAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRecurrenceTypeEnum: IFC_Attribute
	{
		public static string? DAILY {get; set;}
		public static string? WEEKLY {get; set;}
		public static string? MONTHLY_BY_DAY_OF_MONTH {get; set;}
		public static string? MONTHLY_BY_POSITION {get; set;}
		public static string? BY_DAY_COUNT {get; set;}
		public static string? BY_WEEKDAY_COUNT {get; set;}
		public static string? YEARLY_BY_DAY_OF_MONTH {get; set;}
		public static string? YEARLY_BY_POSITION {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingBarTypeEnum: IFC_Attribute
	{
		public static string? ANCHORING {get; set;}
		public static string? EDGE {get; set;}
		public static string? LIGATURE {get; set;}
		public static string? MAIN {get; set;}
		public static string? PUNCHING {get; set;}
		public static string? RING {get; set;}
		public static string? SHEAR {get; set;}
		public static string? STUD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingMeshTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCShadingDeviceTypeEnum: IFC_Attribute
	{
		public static string? JALOUSIE {get; set;}
		public static string? SHUTTER {get; set;}
		public static string? AWNING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSimplePropertyTemplateTypeEnum: IFC_Attribute
	{
		public static string? P_SINGLEVALUE {get; set;}
		public static string? P_ENUMERATEDVALUE {get; set;}
		public static string? P_BOUNDEDVALUE {get; set;}
		public static string? P_LISTVALUE {get; set;}
		public static string? P_TABLEVALUE {get; set;}
		public static string? P_REFERENCEVALUE {get; set;}
		public static string? Q_LENGTH {get; set;}
		public static string? Q_AREA {get; set;}
		public static string? Q_VOLUME {get; set;}
		public static string? Q_COUNT {get; set;}
		public static string? Q_WEIGHT {get; set;}
		public static string? Q_TIME {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSolarDeviceTypeEnum: IFC_Attribute
	{
		public static string? SOLARCOLLECTOR {get; set;}
		public static string? SOLARPANEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialZoneTypeEnum: IFC_Attribute
	{
		public static string? CONSTRUCTION {get; set;}
		public static string? FIRESAFETY {get; set;}
		public static string? LIGHTING {get; set;}
		public static string? OCCUPANCY {get; set;}
		public static string? SECURITY {get; set;}
		public static string? THERMAL {get; set;}
		public static string? TRANSPORT {get; set;}
		public static string? VENTILATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveActivityTypeEnum: IFC_Attribute
	{
		public static string? CONST {get; set;}
		public static string? LINEAR {get; set;}
		public static string? POLYGONAL {get; set;}
		public static string? EQUIDISTANT {get; set;}
		public static string? SINUS {get; set;}
		public static string? PARABOLA {get; set;}
		public static string? DISCRETE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveMemberTypeEnum: IFC_Attribute
	{
		public static string? RIGID_JOINED_MEMBER {get; set;}
		public static string? PIN_JOINED_MEMBER {get; set;}
		public static string? CABLE {get; set;}
		public static string? TENSION_MEMBER {get; set;}
		public static string? COMPRESSION_MEMBER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceActivityTypeEnum: IFC_Attribute
	{
		public static string? CONST {get; set;}
		public static string? BILINEAR {get; set;}
		public static string? DISCRETE {get; set;}
		public static string? ISOCONTOUR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceMemberTypeEnum: IFC_Attribute
	{
		public static string? BENDING_ELEMENT {get; set;}
		public static string? MEMBRANE_ELEMENT {get; set;}
		public static string? SHELL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSubContractResourceTypeEnum: IFC_Attribute
	{
		public static string? PURCHASE {get; set;}
		public static string? WORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceFeatureTypeEnum: IFC_Attribute
	{
		public static string? MARK {get; set;}
		public static string? TAG {get; set;}
		public static string? TREATMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSystemFurnitureElementTypeEnum: IFC_Attribute
	{
		public static string? PANEL {get; set;}
		public static string? WORKSURFACE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTaskDurationEnum: IFC_Attribute
	{
		public static string? ELAPSEDTIME {get; set;}
		public static string? WORKTIME {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTaskTypeEnum: IFC_Attribute
	{
		public static string? ATTENDANCE {get; set;}
		public static string? CONSTRUCTION {get; set;}
		public static string? DEMOLITION {get; set;}
		public static string? DISMANTLE {get; set;}
		public static string? DISPOSAL {get; set;}
		public static string? INSTALLATION {get; set;}
		public static string? LOGISTIC {get; set;}
		public static string? MAINTENANCE {get; set;}
		public static string? MOVE {get; set;}
		public static string? OPERATION {get; set;}
		public static string? REMOVAL {get; set;}
		public static string? RENOVATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonAnchorTypeEnum: IFC_Attribute
	{
		public static string? COUPLER {get; set;}
		public static string? FIXED_END {get; set;}
		public static string? TENSIONING_END {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryControlElementTypeEnum: IFC_Attribute
	{
		public static string? ALARMPANEL {get; set;}
		public static string? CONTROLPANEL {get; set;}
		public static string? GASDETECTIONPANEL {get; set;}
		public static string? INDICATORPANEL {get; set;}
		public static string? MIMICPANEL {get; set;}
		public static string? HUMIDISTAT {get; set;}
		public static string? THERMOSTAT {get; set;}
		public static string? WEATHERSTATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVoidingFeatureTypeEnum: IFC_Attribute
	{
		public static string? CUTOUT {get; set;}
		public static string? NOTCH {get; set;}
		public static string? HOLE {get; set;}
		public static string? MITER {get; set;}
		public static string? CHAMFER {get; set;}
		public static string? EDGE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowTypeEnum: IFC_Attribute
	{
		public static string? WINDOW {get; set;}
		public static string? SKYLIGHT {get; set;}
		public static string? LIGHTDOME {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowTypePartitioningEnum: IFC_Attribute
	{
		public static string? SINGLE_PANEL {get; set;}
		public static string? DOUBLE_PANEL_VERTICAL {get; set;}
		public static string? DOUBLE_PANEL_HORIZONTAL {get; set;}
		public static string? TRIPLE_PANEL_VERTICAL {get; set;}
		public static string? TRIPLE_PANEL_BOTTOM {get; set;}
		public static string? TRIPLE_PANEL_TOP {get; set;}
		public static string? TRIPLE_PANEL_LEFT {get; set;}
		public static string? TRIPLE_PANEL_RIGHT {get; set;}
		public static string? TRIPLE_PANEL_HORIZONTAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkCalendarTypeEnum: IFC_Attribute
	{
		public static string? FIRSTSHIFT {get; set;}
		public static string? SECONDSHIFT {get; set;}
		public static string? THIRDSHIFT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkPlanTypeEnum: IFC_Attribute
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkScheduleTypeEnum: IFC_Attribute
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReferentTypeEnum: IFC_Attribute
	{
		public static string? KILOPOINT {get; set;}
		public static string? MILEPOINT {get; set;}
		public static string? STATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTransitionCurveType: IFC_Attribute
	{
		public static string? BIQUADRATICPARABOLA {get; set;}
		public static string? BLOSSCURVE {get; set;}
		public static string? CLOTHOIDCURVE {get; set;}
		public static string? COSINECURVE {get; set;}
		public static string? CUBICPARABOLA {get; set;}
		public static string? SINECURVE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBearingTypeDisplacementEnum: IFC_Attribute
	{
		public static string? FIXED_MOVEMENT {get; set;}
		public static string? GUIDED_LONGITUDINAL {get; set;}
		public static string? GUIDED_TRANSVERSAL {get; set;}
		public static string? FREE_MOVEMENT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBearingTypeEnum: IFC_Attribute
	{
		public static string? CYLINDRICAL {get; set;}
		public static string? SPHERICAL {get; set;}
		public static string? ELASTOMERIC {get; set;}
		public static string? POT {get; set;}
		public static string? GUIDE {get; set;}
		public static string? ROCKER {get; set;}
		public static string? ROLLER {get; set;}
		public static string? DISK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBridgePartTypeEnum: IFC_Attribute
	{
		public static string? ABUTMENT {get; set;}
		public static string? DECK {get; set;}
		public static string? DECK_SEGMENT {get; set;}
		public static string? FOUNDATION {get; set;}
		public static string? PIER {get; set;}
		public static string? PIER_SEGMENT {get; set;}
		public static string? PYLON {get; set;}
		public static string? SUBSTRUCTURE {get; set;}
		public static string? SUPERSTRUCTURE {get; set;}
		public static string? SURFACESTRUCTURE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBridgeTypeEnum: IFC_Attribute
	{
		public static string? ARCHED {get; set;}
		public static string? CABLE_STAYED {get; set;}
		public static string? CANTILEVER {get; set;}
		public static string? CULVERT {get; set;}
		public static string? FRAMEWORK {get; set;}
		public static string? GIRDER {get; set;}
		public static string? SUSPENSION {get; set;}
		public static string? TRUSS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCaissonFoundationTypeEnum: IFC_Attribute
	{
		public static string? WELL {get; set;}
		public static string? CAISSON {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonConduitTypeEnum: IFC_Attribute
	{
		public static string? DUCT {get; set;}
		public static string? COUPLER {get; set;}
		public static string? GROUTING_DUCT {get; set;}
		public static string? TRUMPET {get; set;}
		public static string? DIABOLO {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationDamperTypeEnum: IFC_Attribute
	{
		public static string? BENDING_YIELD {get; set;}
		public static string? SHEAR_YIELD {get; set;}
		public static string? AXIAL_YIELD {get; set;}
		public static string? FRICTION {get; set;}
		public static string? VISCOUS {get; set;}
		public static string? RUBBER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentCantSegmentTypeEnum: IFC_Attribute
	{
		public static string? BLOSSCURVE {get; set;}
		public static string? CONSTANTCANT {get; set;}
		public static string? COSINECURVE {get; set;}
		public static string? HELMERTCURVE {get; set;}
		public static string? LINEARTRANSITION {get; set;}
		public static string? SINECURVE {get; set;}
		public static string? VIENNESEBEND {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentHorizontalSegmentTypeEnum: IFC_Attribute
	{
		public static string? BLOSSCURVE {get; set;}
		public static string? CIRCULARARC {get; set;}
		public static string? CLOTHOID {get; set;}
		public static string? COSINECURVE {get; set;}
		public static string? CUBIC {get; set;}
		public static string? HELMERTCURVE {get; set;}
		public static string? LINE {get; set;}
		public static string? SINECURVE {get; set;}
		public static string? VIENNESEBEND {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentVerticalSegmentTypeEnum: IFC_Attribute
	{
		public static string? CIRCULARARC {get; set;}
		public static string? CLOTHOID {get; set;}
		public static string? CONSTANTGRADIENT {get; set;}
		public static string? PARABOLICARC {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationTypeEnum: IFC_Attribute
	{
		public static string? CONTOURLINE {get; set;}
		public static string? DIMENSION {get; set;}
		public static string? ISOBAR {get; set;}
		public static string? ISOLUX {get; set;}
		public static string? ISOTHERM {get; set;}
		public static string? LEADER {get; set;}
		public static string? SURVEY {get; set;}
		public static string? SYMBOL {get; set;}
		public static string? TEXT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBuiltSystemTypeEnum: IFC_Attribute
	{
		public static string? EROSIONPREVENTION {get; set;}
		public static string? FENESTRATION {get; set;}
		public static string? FOUNDATION {get; set;}
		public static string? LOADBEARING {get; set;}
		public static string? MOORING {get; set;}
		public static string? OUTERSHELL {get; set;}
		public static string? PRESTRESSING {get; set;}
		public static string? RAILWAYLINE {get; set;}
		public static string? RAILWAYTRACK {get; set;}
		public static string? REINFORCING {get; set;}
		public static string? SHADING {get; set;}
		public static string? TRACKCIRCUIT {get; set;}
		public static string? TRANSPORT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConveyorSegmentTypeEnum: IFC_Attribute
	{
		public static string? BELTCONVEYOR {get; set;}
		public static string? BUCKETCONVEYOR {get; set;}
		public static string? CHUTECONVEYOR {get; set;}
		public static string? SCREWCONVEYOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCourseTypeEnum: IFC_Attribute
	{
		public static string? ARMOUR {get; set;}
		public static string? BALLASTBED {get; set;}
		public static string? CORE {get; set;}
		public static string? FILTER {get; set;}
		public static string? PAVEMENT {get; set;}
		public static string? PROTECTION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionBoardTypeEnum: IFC_Attribute
	{
		public static string? CONSUMERUNIT {get; set;}
		public static string? DISPATCHINGBOARD {get; set;}
		public static string? DISTRIBUTIONBOARD {get; set;}
		public static string? DISTRIBUTIONFRAME {get; set;}
		public static string? MOTORCONTROLCENTRE {get; set;}
		public static string? SWITCHBOARD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEarthworksCutTypeEnum: IFC_Attribute
	{
		public static string? BASE_EXCAVATION {get; set;}
		public static string? CUT {get; set;}
		public static string? DREDGING {get; set;}
		public static string? EXCAVATION {get; set;}
		public static string? OVEREXCAVATION {get; set;}
		public static string? PAVEMENTMILLING {get; set;}
		public static string? STEPEXCAVATION {get; set;}
		public static string? TOPSOILREMOVAL {get; set;}
		public static string? TRENCH {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEarthworksFillTypeEnum: IFC_Attribute
	{
		public static string? BACKFILL {get; set;}
		public static string? COUNTERWEIGHT {get; set;}
		public static string? EMBANKMENT {get; set;}
		public static string? SLOPEFILL {get; set;}
		public static string? SUBGRADE {get; set;}
		public static string? SUBGRADEBED {get; set;}
		public static string? TRANSITIONSECTION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowTreatmentDeviceTypeEnum: IFC_Attribute
	{
		public static string? ELECTRONICFILTER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFacilityPartCommonTypeEnum: IFC_Attribute
	{
		public static string? ABOVEGROUND {get; set;}
		public static string? BELOWGROUND {get; set;}
		public static string? JUNCTION {get; set;}
		public static string? LEVELCROSSING {get; set;}
		public static string? SEGMENT {get; set;}
		public static string? SUBSTRUCTURE {get; set;}
		public static string? SUPERSTRUCTURE {get; set;}
		public static string? TERMINAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFacilityUsageEnum: IFC_Attribute
	{
		public static string? LATERAL {get; set;}
		public static string? LONGITUDINAL {get; set;}
		public static string? REGION {get; set;}
		public static string? VERTICAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGeotechnicalStratumTypeEnum: IFC_Attribute
	{
		public static string? SOLID {get; set;}
		public static string? VOID {get; set;}
		public static string? WATER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCImpactProtectionDeviceTypeEnum: IFC_Attribute
	{
		public static string? BUMPER {get; set;}
		public static string? CRASHCUSHION {get; set;}
		public static string? DAMPINGSYSTEM {get; set;}
		public static string? FENDER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCKerbTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLiquidTerminalTypeEnum: IFC_Attribute
	{
		public static string? HOSEREEL {get; set;}
		public static string? LOADINGARM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMarineFacilityTypeEnum: IFC_Attribute
	{
		public static string? BARRIERBEACH {get; set;}
		public static string? BREAKWATER {get; set;}
		public static string? CANAL {get; set;}
		public static string? DRYDOCK {get; set;}
		public static string? FLOATINGDOCK {get; set;}
		public static string? HYDROLIFT {get; set;}
		public static string? JETTY {get; set;}
		public static string? LAUNCHRECOVERY {get; set;}
		public static string? MARINEDEFENCE {get; set;}
		public static string? NAVIGATIONALCHANNEL {get; set;}
		public static string? PORT {get; set;}
		public static string? QUAY {get; set;}
		public static string? REVETMENT {get; set;}
		public static string? SHIPLIFT {get; set;}
		public static string? SHIPLOCK {get; set;}
		public static string? SHIPYARD {get; set;}
		public static string? SLIPWAY {get; set;}
		public static string? WATERWAY {get; set;}
		public static string? WATERWAYSHIPLIFT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMarinePartTypeEnum: IFC_Attribute
	{
		public static string? ABOVEWATERLINE {get; set;}
		public static string? ANCHORAGE {get; set;}
		public static string? APPROACHCHANNEL {get; set;}
		public static string? BELOWWATERLINE {get; set;}
		public static string? BERTHINGSTRUCTURE {get; set;}
		public static string? CHAMBER {get; set;}
		public static string? CILL_LEVEL {get; set;}
		public static string? COPELEVEL {get; set;}
		public static string? CORE {get; set;}
		public static string? CREST {get; set;}
		public static string? GATEHEAD {get; set;}
		public static string? GUDINGSTRUCTURE {get; set;}
		public static string? HIGHWATERLINE {get; set;}
		public static string? LANDFIELD {get; set;}
		public static string? LEEWARDSIDE {get; set;}
		public static string? LOWWATERLINE {get; set;}
		public static string? MANUFACTURING {get; set;}
		public static string? NAVIGATIONALAREA {get; set;}
		public static string? PROTECTION {get; set;}
		public static string? SHIPTRANSFER {get; set;}
		public static string? STORAGEAREA {get; set;}
		public static string? VEHICLESERVICING {get; set;}
		public static string? WATERFIELD {get; set;}
		public static string? WEATHERSIDE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMobileTelecommunicationsApplianceTypeEnum: IFC_Attribute
	{
		public static string? ACCESSPOINT {get; set;}
		public static string? BASEBANDUNIT {get; set;}
		public static string? BASETRANSCEIVERSTATION {get; set;}
		public static string? E_UTRAN_NODE_B {get; set;}
		public static string? GATEWAY_GPRS_SUPPORT_NODE {get; set;}
		public static string? MASTERUNIT {get; set;}
		public static string? MOBILESWITCHINGCENTER {get; set;}
		public static string? MSCSERVER {get; set;}
		public static string? PACKETCONTROLUNIT {get; set;}
		public static string? REMOTERADIOUNIT {get; set;}
		public static string? REMOTEUNIT {get; set;}
		public static string? SERVICE_GPRS_SUPPORT_NODE {get; set;}
		public static string? SUBSCRIBERSERVER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMooringDeviceTypeEnum: IFC_Attribute
	{
		public static string? BOLLARD {get; set;}
		public static string? LINETENSIONER {get; set;}
		public static string? MAGNETICDEVICE {get; set;}
		public static string? MOORINGHOOKS {get; set;}
		public static string? VACUUMDEVICE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCNavigationElementTypeEnum: IFC_Attribute
	{
		public static string? BEACON {get; set;}
		public static string? BUOY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPavementTypeEnum: IFC_Attribute
	{
		public static string? FLEXIBLE {get; set;}
		public static string? RIGID {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRailTypeEnum: IFC_Attribute
	{
		public static string? BLADE {get; set;}
		public static string? CHECKRAIL {get; set;}
		public static string? GUARDRAIL {get; set;}
		public static string? RACKRAIL {get; set;}
		public static string? RAIL {get; set;}
		public static string? STOCKRAIL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRailwayPartTypeEnum: IFC_Attribute
	{
		public static string? ABOVETRACK {get; set;}
		public static string? DILATIONTRACK {get; set;}
		public static string? LINESIDE {get; set;}
		public static string? LINESIDEPART {get; set;}
		public static string? PLAINTRACK {get; set;}
		public static string? SUBSTRUCTURE {get; set;}
		public static string? TRACK {get; set;}
		public static string? TRACKPART {get; set;}
		public static string? TURNOUTTRACK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRailwayTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcedSoilTypeEnum: IFC_Attribute
	{
		public static string? DYNAMICALLYCOMPACTED {get; set;}
		public static string? GROUTED {get; set;}
		public static string? REPLACED {get; set;}
		public static string? ROLLERCOMPACTED {get; set;}
		public static string? SURCHARGEPRELOADED {get; set;}
		public static string? VERTICALLYDRAINED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoadPartTypeEnum: IFC_Attribute
	{
		public static string? BICYCLECROSSING {get; set;}
		public static string? BUS_STOP {get; set;}
		public static string? CARRIAGEWAY {get; set;}
		public static string? CENTRALISLAND {get; set;}
		public static string? CENTRALRESERVE {get; set;}
		public static string? HARDSHOULDER {get; set;}
		public static string? INTERSECTION {get; set;}
		public static string? LAYBY {get; set;}
		public static string? PARKINGBAY {get; set;}
		public static string? PASSINGBAY {get; set;}
		public static string? PEDESTRIAN_CROSSING {get; set;}
		public static string? RAILWAYCROSSING {get; set;}
		public static string? REFUGEISLAND {get; set;}
		public static string? ROADSEGMENT {get; set;}
		public static string? ROADSIDE {get; set;}
		public static string? ROADSIDEPART {get; set;}
		public static string? ROADWAYPLATEAU {get; set;}
		public static string? ROUNDABOUT {get; set;}
		public static string? SHOULDER {get; set;}
		public static string? SIDEWALK {get; set;}
		public static string? SOFTSHOULDER {get; set;}
		public static string? TOLLPLAZA {get; set;}
		public static string? TRAFFICISLAND {get; set;}
		public static string? TRAFFICLANE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoadTypeEnum: IFC_Attribute
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSignTypeEnum: IFC_Attribute
	{
		public static string? MARKER {get; set;}
		public static string? MIRROR {get; set;}
		public static string? PICTORAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSignalTypeEnum: IFC_Attribute
	{
		public static string? AUDIO {get; set;}
		public static string? MIXED {get; set;}
		public static string? VISUAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTrackElementTypeEnum: IFC_Attribute
	{
		public static string? BLOCKINGDEVICE {get; set;}
		public static string? DERAILER {get; set;}
		public static string? FROG {get; set;}
		public static string? HALF_SET_OF_BLADES {get; set;}
		public static string? SLEEPER {get; set;}
		public static string? SPEEDREGULATOR {get; set;}
		public static string? TRACKENDOFALIGNMENT {get; set;}
		public static string? VEHICLESTOP {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVehicleTypeEnum: IFC_Attribute
	{
		public static string? CARGO {get; set;}
		public static string? ROLLINGSTOCK {get; set;}
		public static string? VEHICLE {get; set;}
		public static string? VEHICLEAIR {get; set;}
		public static string? VEHICLEMARINE {get; set;}
		public static string? VEHICLETRACKED {get; set;}
		public static string? VEHICLEWHEELED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVirtualElementTypeEnum: IFC_Attribute
	{
		public static string? BOUNDARY {get; set;}
		public static string? CLEARANCE {get; set;}
		public static string? PROVISIONFORVOID {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCActorSelect: IFC_Attribute
	{
		public IFC_LIST<IFCActorRole>? _Roles {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAppliedValueSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCAxis2Placement: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _RefDirection {get; }
		public IFC_LIST<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBooleanOperand: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCharacterStyleSelect: IFC_Attribute
	{
		public IFCColour? _Colour {get; set;}
		public IFCColour? _BackgroundColour {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationNotationSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCColour: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCColourOrFactor: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCConditionCriterionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCCsgSelect: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveFontOrScaledCurveFontSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveOrEdgeCurve: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveStyleFontSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDateTimeSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCDefinedSymbolSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDerivedMeasureValue: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingCalloutElement: IFC_Attribute
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFillAreaStyleTileShapeSelect: IFC_Attribute
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAnnotationSymbolOccurrence? _Symbol {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFillStyleSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricSetSelect: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHatchLineDistanceSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCLayeredItem: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCLibrarySelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightDistributionDataSourceSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCMeasureValue: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCMetricValueSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCObjectReferenceSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCOrientationSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCPointOrVertexPoint: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationStyleSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCShell: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSimpleValue: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCSizeSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCSpecularHighlightSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralActivityAssignmentSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceOrFaceSurface: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleElementSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCSymbolStyleSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextFontSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyleSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCTrimmingSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCUnit: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCValue: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCVectorOrDirection: IFC_Attribute
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBendingParameterSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationReferenceSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCClassificationReference>? _HasReferences {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationSelect: IFC_Attribute
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCClassificationReference>? _HasReferences {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoordinateReferenceSystemSelect: IFC_Attribute
	{
		public IFC_SET<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveOnSurface: IFC_Attribute
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDefinitionSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGridPlacementDirectionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfRotationalSubgradeReactionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfSubgradeReactionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCModulusOfTranslationalSubgradeReactionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCProcessSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProductRepresentationSelect: IFC_Attribute
	{
		public IFC_SET<IFCShapeAspect>? _HasShapeAspects {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProductSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySetDefinitionSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceObjectSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRotationalStiffnessSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCSegmentIndexSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCSolidOrShell: IFC_Attribute
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceBoundarySelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStyleAssignmentSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeOrRatioSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCTranslationalStiffnessSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCWarpingStiffnessSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveMeasureSelect: IFC_Attribute
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCInterferenceSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialReferenceSelect: IFC_Attribute
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFC2DCompositeCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCCompositeCurveSegment>? _Segments {get; }
		public LOGICAL? _SelfIntersect {get; }
		public INTEGER? _NSegments {get; }
		public LOGICAL? _ClosedCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCActionRequest: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCActor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _TheActor {get; }
		public IFC_SET<IFCRelAssignsToActor>? _IsActingUpon {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCActorRole: IFC_Entity
	{
		public IFCRoleEnum? _Role {get; set;}
		public IFCLabel? _UserDefinedRole {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCActuatorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCActuatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAddress: IFC_Entity
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public IFC_SET<IFCPerson>? _OfPerson {get; }
		public IFC_SET<IFCOrganization>? _OfOrganization {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminalBoxType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirTerminalBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirToAirHeatRecoveryType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirToAirHeatRecoveryTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlarmType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAlarmTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAngularDimension: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotation: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationCurveOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationFillArea: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurve? _OuterBoundary {get; }
		public IFC_SET<IFCCurve>? _InnerBoundaries {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationFillAreaOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCPoint? _FillStyleTarget {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCGeometricRepresentationItem? _Item {get; }
		public IFCTextureCoordinate? _TextureCoordinates {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationSurfaceOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationSymbolOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAnnotationTextOccurrence: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCApplication: IFC_Entity
	{
		public IFCOrganization? _ApplicationDeveloper {get; set;}
		public IFCLabel? _Version {get; set;}
		public IFCLabel? _ApplicationFullName {get; set;}
		public IFCIdentifier? _ApplicationIdentifier {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAppliedValue: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAppliedValueRelationship: IFC_Entity
	{
		public IFCAppliedValue? _ComponentOfTotal {get; set;}
		public IFC_SET<IFCAppliedValue>? _Components {get; set;}
		public IFCArithmeticOperatorEnum? _ArithmeticOperator {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCApproval: IFC_Entity
	{
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
		public IFC_SET<IFCApprovalRelationship>? _IsRelatedWith {get; }
		public IFC_SET<IFCApprovalRelationship>? _Relates {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCApprovalActorRelationship: IFC_Entity
	{
		public IFCActorSelect? _Actor {get; set;}
		public IFCApproval? _Approval {get; set;}
		public IFCActorRole? _Role {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCApprovalPropertyRelationship: IFC_Entity
	{
		public IFC_SET<IFCProperty>? _ApprovedProperties {get; set;}
		public IFCApproval? _Approval {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCApprovalRelationship: IFC_Entity
	{
		public IFCApproval? _RelatingApproval {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCArbitraryClosedProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCCurve? _OuterCurve {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCArbitraryOpenProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCBoundedCurve? _Curve {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCArbitraryProfileDefWithVoids: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCCurve? _OuterCurve {get; set;}
		public IFC_SET<IFCCurve>? _InnerCurves {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAsset: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCCostValue? _OriginalValue {get; }
		public IFCCostValue? _CurrentValue {get; }
		public IFCCostValue? _TotalReplacementCost {get; }
		public IFCActorSelect? _Owner {get; }
		public IFCActorSelect? _User {get; }
		public IFCPerson? _ResponsiblePerson {get; }
		public IFCCostValue? _DepreciatedValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAsymmetricIShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _OverallDepth {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _TopFlangeWidth {get; set;}
		public IFCPositiveLengthMeasure? _TopFlangeThickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAxis1Placement: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _Z {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAxis2Placement2D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _RefDirection {get; }
		public IFC_LIST<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAxis2Placement3D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _RefDirection {get; }
		public IFC_LIST<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public IFC_ARRAY<IFCCartesianPoint>? _ControlPoints {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBeam: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBeamType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBezierCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public INTEGER? _Degree {get; }
		public IFC_LIST<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public LOGICAL? _ClosedCurve {get; }
		public LOGICAL? _SelfIntersect {get; }
		public IFC_ARRAY<IFCCartesianPoint>? _ControlPoints {get; }
		public INTEGER? _UpperIndexOnControlPoints {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBlobTexture: IFC_Entity
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
		public IFCIdentifier? _RasterFormat {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBlock: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _XLength {get; }
		public IFCPositiveLengthMeasure? _YLength {get; }
		public IFCPositiveLengthMeasure? _ZLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoilerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBoilerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBooleanClippingResult: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBooleanOperator? _Operator {get; }
		public IFCBooleanOperand? _FirstOperand {get; }
		public IFCBooleanOperand? _SecondOperand {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBooleanResult: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBooleanOperator? _Operator {get; }
		public IFCBooleanOperand? _FirstOperand {get; }
		public IFCBooleanOperand? _SecondOperand {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryEdgeCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryFaceCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryNodeCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryNodeConditionWarping: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundedCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundedSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundingBox: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPoint? _Corner {get; }
		public IFCPositiveLengthMeasure? _XDim {get; }
		public IFCPositiveLengthMeasure? _YDim {get; }
		public IFCPositiveLengthMeasure? _ZDim {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoxedHalfSpace: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCBoundingBox? _Enclosure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuilding: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _ElevationOfRefHeight {get; }
		public IFCLengthMeasure? _ElevationOfTerrain {get; }
		public IFCPostalAddress? _BuildingAddress {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementComponent: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementPart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementProxy: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementProxyType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBuildingElementProxyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingStorey: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _Elevation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Depth {get; set;}
		public IFCPositiveLengthMeasure? _Width {get; set;}
		public IFCPositiveLengthMeasure? _WallThickness {get; set;}
		public IFCPositiveLengthMeasure? _Girth {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierFittingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableCarrierFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableCarrierSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCalendarDate: IFC_Entity
	{
		public IFCDayInMonthNumber? _DayComponent {get; set;}
		public IFCMonthInYearNumber? _MonthComponent {get; set;}
		public IFCYearNumber? _YearComponent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianPoint: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCLengthMeasure>? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianTransformationOperator: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianTransformationOperator2D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianTransformationOperator2DnonUniform: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianTransformationOperator3D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis3 {get; }
		public IFC_LIST<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianTransformationOperator3DnonUniform: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis3 {get; }
		public IFC_LIST<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCenterLineProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCBoundedCurve? _Curve {get; set;}
		public IFCPositiveLengthMeasure? _Thickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCChamferEdgeFeature: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
		public IFCPositiveLengthMeasure? _Width {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCChillerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCChillerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCircle: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCircleHollowProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
		public IFCPositiveLengthMeasure? _WallThickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCircleProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassification: IFC_Entity
	{
		public IFCLabel? _Source {get; set;}
		public IFCLabel? _Edition {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationItem: IFC_Entity
	{
		public IFCClassificationNotationFacet? _Notation {get; set;}
		public IFCClassification? _ItemOf {get; set;}
		public IFCLabel? _Title {get; set;}
		public IFC_SET<IFCClassificationItemRelationship>? _IsClassifiedItemIn {get; }
		public IFC_SET<IFCClassificationItemRelationship>? _IsClassifyingItemIn {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationItemRelationship: IFC_Entity
	{
		public IFCClassificationItem? _RelatingItem {get; set;}
		public IFC_SET<IFCClassificationItem>? _RelatedItems {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationNotation: IFC_Entity
	{
		public IFC_SET<IFCClassificationNotationFacet>? _NotationFacets {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationNotationFacet: IFC_Entity
	{
		public IFCLabel? _NotationValue {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClassificationReference: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCClosedShell: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoilType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCColourRgb: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCNormalisedRatioMeasure? _Red {get; set;}
		public IFCNormalisedRatioMeasure? _Green {get; set;}
		public IFCNormalisedRatioMeasure? _Blue {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCColourSpecification: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCColumn: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCColumnType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCColumnTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCComplexProperty: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCIdentifier? _UsageName {get; }
		public IFC_SET<IFCProperty>? _HasProperties {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCompositeCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCompositeCurveSegment: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCCurve? _ParentCurve {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCCompositeCurve>? _UsingCurves {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCompositeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFC_SET<IFCProfileDef>? _Profiles {get; set;}
		public IFCLabel? _Label {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCompressorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCompressorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCondenserType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCondenserTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCondition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCRelAssignsToGroup? _IsGroupedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConditionCriterion: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCConditionCriterionSelect? _Criterion {get; }
		public IFCDateTimeSelect? _CriterionDateTime {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConic: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectedFaceSet: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionCurveGeometry: IFC_Entity
	{
		public IFCCurveOrEdgeCurve? _CurveOnRelatingElement {get; set;}
		public IFCCurveOrEdgeCurve? _CurveOnRelatedElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionGeometry: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionPointEccentricity: IFC_Entity
	{
		public IFCPointOrVertexPoint? _PointOnRelatingElement {get; set;}
		public IFCPointOrVertexPoint? _PointOnRelatedElement {get; set;}
		public IFCLengthMeasure? _EccentricityInX {get; set;}
		public IFCLengthMeasure? _EccentricityInY {get; set;}
		public IFCLengthMeasure? _EccentricityInZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionPointGeometry: IFC_Entity
	{
		public IFCPointOrVertexPoint? _PointOnRelatingElement {get; set;}
		public IFCPointOrVertexPoint? _PointOnRelatedElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionPortGeometry: IFC_Entity
	{
		public IFCAxis2Placement? _LocationAtRelatingElement {get; set;}
		public IFCAxis2Placement? _LocationAtRelatedElement {get; set;}
		public IFCProfileDef? _ProfileOfPort {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionSurfaceGeometry: IFC_Entity
	{
		public IFCSurfaceOrFaceSurface? _SurfaceOnRelatingElement {get; set;}
		public IFCSurfaceOrFaceSurface? _SurfaceOnRelatedElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstraint: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraintEnum? _ConstraintGrade {get; set;}
		public IFCLabel? _ConstraintSource {get; set;}
		public IFCActorSelect? _CreatingActor {get; set;}
		public IFCLabel? _UserDefinedGrade {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstraintAggregationRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public IFC_LIST<IFCConstraint>? _RelatedConstraints {get; set;}
		public IFCLogicalOperatorEnum? _LogicalAggregator {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstraintClassificationRelationship: IFC_Entity
	{
		public IFCConstraint? _ClassifiedConstraint {get; set;}
		public IFC_SET<IFCClassificationNotationSelect>? _RelatedClassifications {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstraintRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public IFC_SET<IFCConstraint>? _RelatedConstraints {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionEquipmentResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionMaterialResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionProductResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCContextDependentUnit: IFC_Entity
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCControl: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCControllerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCControllerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConversionBasedUnit: IFC_Entity
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCMeasureWithUnit? _ConversionFactor {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCooledBeamType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCooledBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoolingTowerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoolingTowerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoordinatedUniversalTimeOffset: IFC_Entity
	{
		public IFCHourInDay? _HourOffset {get; set;}
		public IFCMinuteInHour? _MinuteOffset {get; set;}
		public IFCAheadOrBehind? _Sense {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCostItem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCostSchedule: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCLabel? _Status {get; }
		public IFCCostScheduleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCostValue: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCovering: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCCoveringTypeEnum? _PredefinedType {get; }
		public IFC_SET<IFCRelCoversSpaces>? _CoversSpaces {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoveringType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoveringTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCraneRailAShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _OverallHeight {get; set;}
		public IFCPositiveLengthMeasure? _BaseWidth2 {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
		public IFCPositiveLengthMeasure? _HeadWidth {get; set;}
		public IFCPositiveLengthMeasure? _HeadDepth2 {get; set;}
		public IFCPositiveLengthMeasure? _HeadDepth3 {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _BaseWidth4 {get; set;}
		public IFCPositiveLengthMeasure? _BaseDepth1 {get; set;}
		public IFCPositiveLengthMeasure? _BaseDepth2 {get; set;}
		public IFCPositiveLengthMeasure? _BaseDepth3 {get; set;}
		public IFCPositiveLengthMeasure? _CentreOfGravityInY {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCraneRailFShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _OverallHeight {get; set;}
		public IFCPositiveLengthMeasure? _HeadWidth {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
		public IFCPositiveLengthMeasure? _HeadDepth2 {get; set;}
		public IFCPositiveLengthMeasure? _HeadDepth3 {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _BaseDepth1 {get; set;}
		public IFCPositiveLengthMeasure? _BaseDepth2 {get; set;}
		public IFCPositiveLengthMeasure? _CentreOfGravityInY {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCrewResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCsgPrimitive3D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCsgSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCsgSelect? _TreeRootExpression {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurrencyRelationship: IFC_Entity
	{
		public IFCMonetaryUnit? _RelatingMonetaryUnit {get; set;}
		public IFCMonetaryUnit? _RelatedMonetaryUnit {get; set;}
		public IFCPositiveRatioMeasure? _ExchangeRate {get; set;}
		public IFCLibraryInformation? _RateSource {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurtainWall: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurtainWallType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCurtainWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveBoundedPlane: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPlane? _BasisSurface {get; }
		public IFCCurve? _OuterBoundary {get; }
		public IFC_SET<IFCCurve>? _InnerBoundaries {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCCurveFontOrScaledCurveFontSelect? _CurveFont {get; set;}
		public IFCSizeSelect? _CurveWidth {get; set;}
		public IFCColour? _CurveColour {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveStyleFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_LIST<IFCCurveStyleFontPattern>? _PatternList {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveStyleFontAndScaling: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCPositiveRatioMeasure? _CurveFontScaling {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveStyleFontPattern: IFC_Entity
	{
		public IFCLengthMeasure? _VisibleSegmentLength {get; set;}
		public IFCPositiveLengthMeasure? _InvisibleSegmentLength {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDamperType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDateAndTime: IFC_Entity
	{
		public IFCCalendarDate? _DateComponent {get; set;}
		public IFCLocalTime? _TimeComponent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDefinedSymbol: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDefinedSymbolSelect? _Definition {get; }
		public IFCCartesianTransformationOperator2D? _Target {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDerivedProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ParentProfile {get; set;}
		public IFCCartesianTransformationOperator2D? _Operator {get; set;}
		public IFCLabel? _Label {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDerivedUnit: IFC_Entity
	{
		public IFC_SET<IFCDerivedUnitElement>? _Elements {get; set;}
		public IFCDerivedUnitEnum? _UnitType {get; set;}
		public IFCLabel? _UserDefinedType {get; set;}
		public IFCDimensionalExponents? _Dimensions {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDerivedUnitElement: IFC_Entity
	{
		public IFCNamedUnit? _Unit {get; set;}
		public INTEGER? _Exponent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDiameterDimension: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionCalloutRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFC_SET<IFCTerminatorSymbol>? _AnnotatedBySymbols {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionCurveDirectedCallout: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionCurveTerminator: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCAnnotationCurveOccurrence? _AnnotatedCurve {get; }
		public IFCDimensionExtentUsage? _Role {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionPair: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDimensionalExponents: IFC_Entity
	{
		public INTEGER? _LengthExponent {get; set;}
		public INTEGER? _MassExponent {get; set;}
		public INTEGER? _TimeExponent {get; set;}
		public INTEGER? _ElectricCurrentExponent {get; set;}
		public INTEGER? _ThermodynamicTemperatureExponent {get; set;}
		public INTEGER? _AmountOfSubstanceExponent {get; set;}
		public INTEGER? _LuminousIntensityExponent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDirection: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDiscreteAccessory: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDiscreteAccessoryType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionChamberElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionChamberElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDistributionChamberElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionControlElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionControlElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionFlowElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionFlowElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionPort: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsPorts>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelConnectsPorts>? _ConnectedTo {get; }
		public IFCFlowDirectionEnum? _FlowDirection {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentElectronicFormat: IFC_Entity
	{
		public IFCLabel? _FileExtension {get; set;}
		public IFCLabel? _MimeContentType {get; set;}
		public IFCLabel? _MimeSubtype {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentInformation: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCText? _Purpose {get; set;}
		public IFCText? _IntendedUse {get; set;}
		public IFCText? _Scope {get; set;}
		public IFCLabel? _Revision {get; set;}
		public IFCActorSelect? _DocumentOwner {get; set;}
		public IFC_SET<IFCActorSelect>? _Editors {get; set;}
		public IFCDocumentConfidentialityEnum? _Confidentiality {get; set;}
		public IFCDocumentStatusEnum? _Status {get; set;}
		public IFC_SET<IFCDocumentInformationRelationship>? _IsPointedTo {get; }
		public IFC_SET<IFCDocumentInformationRelationship>? _IsPointer {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentInformationRelationship: IFC_Entity
	{
		public IFCDocumentInformation? _RelatingDocument {get; set;}
		public IFC_SET<IFCDocumentInformation>? _RelatedDocuments {get; set;}
		public IFCLabel? _RelationshipType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDocumentReference: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDoor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorLiningProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveLengthMeasure? _LiningDepth {get; }
		public IFCPositiveLengthMeasure? _ThresholdDepth {get; }
		public IFCLengthMeasure? _TransomOffset {get; }
		public IFCLengthMeasure? _LiningOffset {get; }
		public IFCLengthMeasure? _ThresholdOffset {get; }
		public IFCPositiveLengthMeasure? _CasingThickness {get; }
		public IFCPositiveLengthMeasure? _CasingDepth {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorPanelProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveLengthMeasure? _PanelDepth {get; }
		public IFCDoorPanelOperationEnum? _PanelOperation {get; }
		public IFCNormalisedRatioMeasure? _PanelWidth {get; }
		public IFCDoorPanelPositionEnum? _PanelPosition {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorStyle: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCDoorStyleOperationEnum? _OperationType {get; }
		public IFCDoorStyleConstructionEnum? _ConstructionType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingCallout: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingCalloutRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingPreDefinedColour: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingPreDefinedCurveFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDraughtingPreDefinedTextFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctFittingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSilencerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctSilencerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEdge: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEdgeCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCCurve? _EdgeGeometry {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEdgeFeature: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEdgeLoop: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCOrientedEdge>? _EdgeList {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricApplianceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricDistributionPoint: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricDistributionPointFunctionEnum? _DistributionPointFunction {get; }
		public IFCLabel? _UserDefinedFunction {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowStorageDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricFlowStorageDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricGeneratorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricGeneratorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricHeaterType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _ObjectTypeOf {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricMotorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricMotorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricTimeControlType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricTimeControlTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricalBaseProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCEnergySequenceEnum? _EnergySequence {get; }
		public IFCLabel? _UserDefinedEnergySequence {get; }
		public IFCElectricCurrentEnum? _ElectricCurrentType {get; }
		public IFCElectricVoltageMeasure? _InputVoltage {get; }
		public IFCFrequencyMeasure? _InputFrequency {get; }
		public IFCElectricCurrentMeasure? _FullLoadCurrent {get; }
		public IFCElectricCurrentMeasure? _MinimumCircuitCurrent {get; }
		public IFCPowerMeasure? _MaximumPowerInput {get; }
		public IFCPowerMeasure? _RatedPowerInput {get; }
		public INTEGER? _InputPhase {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricalCircuit: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCRelAssignsToGroup? _IsGroupedBy {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricalElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementAssembly: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCAssemblyPlaceEnum? _AssemblyPlace {get; }
		public IFCElementAssemblyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementComponent: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementComponentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementQuantity: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCLabel? _MethodOfMeasurement {get; }
		public IFC_SET<IFCPhysicalQuantity>? _Quantities {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementarySurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEllipse: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCPositiveLengthMeasure? _SemiAxis1 {get; }
		public IFCPositiveLengthMeasure? _SemiAxis2 {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEllipseProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _SemiAxis1 {get; set;}
		public IFCPositiveLengthMeasure? _SemiAxis2 {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEnergyConversionDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEnergyConversionDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEnergyProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCEnergySequenceEnum? _EnergySequence {get; }
		public IFCLabel? _UserDefinedEnergySequence {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEnvironmentalImpactValue: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
		public IFCDateTimeSelect? _ApplicableDate {get; set;}
		public IFCDateTimeSelect? _FixedUntilDate {get; set;}
		public IFC_SET<IFCReferencesValueDocument>? _ValuesReferenced {get; }
		public IFC_SET<IFCAppliedValueRelationship>? _ValueOfComponents {get; }
		public IFC_SET<IFCAppliedValueRelationship>? _IsComponentIn {get; }
		public IFCLabel? _ImpactType {get; }
		public IFCEnvironmentalImpactCategoryEnum? _Category {get; }
		public IFCLabel? _UserDefinedCategory {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEquipmentElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEquipmentStandard: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporativeCoolerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEvaporativeCoolerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporatorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEvaporatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCExtendedMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFC_SET<IFCProperty>? _ExtendedProperties {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalReference: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternallyDefinedHatchStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternallyDefinedSurfaceStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternallyDefinedSymbol: IFC_Entity
	{
		public IFCLabel? _Location {get; set;}
		public IFCIdentifier? _ItemReference {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternallyDefinedTextFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExtrudedAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCPositiveLengthMeasure? _Depth {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFace: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFaceBound>? _Bounds {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFaceBasedSurfaceModel: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCConnectedFaceSet>? _FbsmFaces {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFaceBound: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLoop? _Bound {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFaceOuterBound: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLoop? _Bound {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFaceSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFaceBound>? _Bounds {get; }
		public IFCSurface? _FaceSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFacetedBrep: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFacetedBrepWithVoids: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
		public IFC_SET<IFCClosedShell>? _Voids {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFailureConnectionCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCForceMeasure? _TensionFailureX {get; set;}
		public IFCForceMeasure? _TensionFailureY {get; set;}
		public IFCForceMeasure? _TensionFailureZ {get; set;}
		public IFCForceMeasure? _CompressionFailureX {get; set;}
		public IFCForceMeasure? _CompressionFailureY {get; set;}
		public IFCForceMeasure? _CompressionFailureZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFanType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFanTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFastener: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFastenerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFeatureElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFeatureElementAddition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelProjectsElement? _ProjectsElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFeatureElementSubtraction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFillAreaStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_SET<IFCFillStyleSelect>? _FillStyles {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFillAreaStyleHatching: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurveStyle? _HatchLineAppearance {get; }
		public IFCHatchLineDistanceSelect? _StartOfNextHatchLine {get; }
		public IFCCartesianPoint? _PointOfReferenceHatchLine {get; }
		public IFCCartesianPoint? _PatternStart {get; }
		public IFCPlaneAngleMeasure? _HatchLineAngle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFillAreaStyleTileSymbolWithStyle: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAnnotationSymbolOccurrence? _Symbol {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFillAreaStyleTiles: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPositiveRatioMeasure? _TilingScale {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFilterType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFilterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFireSuppressionTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFireSuppressionTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowController: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowControllerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowFitting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowFittingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowInstrumentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFlowInstrumentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowMeterType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFlowMeterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowMovingDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowMovingDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowStorageDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowStorageDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowTreatmentDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowTreatmentDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFluidFlowProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPropertySourceEnum? _PropertySource {get; }
		public IFCTimeSeries? _FlowConditionTimeSeries {get; }
		public IFCTimeSeries? _VelocityTimeSeries {get; }
		public IFCTimeSeries? _FlowrateTimeSeries {get; }
		public IFCMaterial? _Fluid {get; }
		public IFCTimeSeries? _PressureTimeSeries {get; }
		public IFCLabel? _UserDefinedPropertySource {get; }
		public IFCThermodynamicTemperatureMeasure? _TemperatureSingleValue {get; }
		public IFCThermodynamicTemperatureMeasure? _WetBulbTemperatureSingleValue {get; }
		public IFCTimeSeries? _WetBulbTemperatureTimeSeries {get; }
		public IFCTimeSeries? _TemperatureTimeSeries {get; }
		public IFCDerivedMeasureValue? _FlowrateSingleValue {get; }
		public IFCPositiveRatioMeasure? _FlowConditionSingleValue {get; }
		public IFCLinearVelocityMeasure? _VelocitySingleValue {get; }
		public IFCPressureMeasure? _PressureSingleValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFooting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCFootingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFuelProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCThermodynamicTemperatureMeasure? _CombustionTemperature {get; set;}
		public IFCPositiveRatioMeasure? _CarbonContent {get; set;}
		public IFCHeatingValueMeasure? _LowerHeatingValue {get; set;}
		public IFCHeatingValueMeasure? _HigherHeatingValue {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCFurnishingElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFurnishingElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFurnitureStandard: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFurnitureType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAssemblyPlaceEnum? _AssemblyPlace {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGasTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _ObjectTypeOf {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCGasTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeneralMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCMolecularWeightMeasure? _MolecularWeight {get; set;}
		public IFCNormalisedRatioMeasure? _Porosity {get; set;}
		public IFCMassDensityMeasure? _MassDensity {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGeneralProfileProperties: IFC_Entity
	{
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ProfileDefinition {get; set;}
		public IFCMassPerLengthMeasure? _PhysicalWeight {get; set;}
		public IFCPositiveLengthMeasure? _Perimeter {get; set;}
		public IFCPositiveLengthMeasure? _MinimumPlateThickness {get; set;}
		public IFCPositiveLengthMeasure? _MaximumPlateThickness {get; set;}
		public IFCAreaMeasure? _CrossSectionArea {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricCurveSet: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCGeometricSetSelect>? _Elements {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricRepresentationContext: IFC_Entity
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public IFC_SET<IFCRepresentation>? _RepresentationsInContext {get; }
		public IFCDimensionCount? _CoordinateSpaceDimension {get; }
		public IFCAxis2Placement? _WorldCoordinateSystem {get; }
		public IFCDirection? _TrueNorth {get; }
		public IFC_SET<IFCGeometricRepresentationSubContext>? _HasSubContexts {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricRepresentationItem: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricRepresentationSubContext: IFC_Entity
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public IFC_SET<IFCRepresentation>? _RepresentationsInContext {get; }
		public IFCDimensionCount? _CoordinateSpaceDimension {get; }
		public IFCAxis2Placement? _WorldCoordinateSystem {get; }
		public IFCDirection? _TrueNorth {get; }
		public IFC_SET<IFCGeometricRepresentationSubContext>? _HasSubContexts {get; }
		public IFCGeometricRepresentationContext? _ParentContext {get; }
		public IFCPositiveRatioMeasure? _TargetScale {get; }
		public IFCGeometricProjectionEnum? _TargetView {get; }
		public IFCLabel? _UserDefinedTargetView {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeometricSet: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCGeometricSetSelect>? _Elements {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGrid: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_LIST<IFCGridAxis>? _UAxes {get; }
		public IFC_LIST<IFCGridAxis>? _VAxes {get; }
		public IFC_LIST<IFCGridAxis>? _WAxes {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGridAxis: IFC_Entity
	{
		public IFCLabel? _AxisTag {get; set;}
		public IFCCurve? _AxisCurve {get; set;}
		public IFCBoolean? _SameSense {get; set;}
		public IFC_SET<IFCGrid>? _PartOfW {get; }
		public IFC_SET<IFCGrid>? _PartOfV {get; }
		public IFC_SET<IFCGrid>? _PartOfU {get; }
		public IFC_SET<IFCVirtualGridIntersection>? _HasIntersections {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGridPlacement: IFC_Entity
	{
		public IFC_SET<IFCProduct>? _PlacesObject {get; }
		public IFCVirtualGridIntersection? _PlacementLocation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGroup: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHalfSpaceSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHeatExchangerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCHeatExchangerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHumidifierType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCHumidifierTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHygroscopicMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCPositiveRatioMeasure? _UpperVaporResistanceFactor {get; set;}
		public IFCPositiveRatioMeasure? _LowerVaporResistanceFactor {get; set;}
		public IFCIsothermalMoistureCapacityMeasure? _IsothermalMoistureCapacity {get; set;}
		public IFCVaporPermeabilityMeasure? _VaporPermeability {get; set;}
		public IFCMoistureDiffusivityMeasure? _MoistureDiffusivity {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _OverallWidth {get; set;}
		public IFCPositiveLengthMeasure? _OverallDepth {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _FlangeThickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCImageTexture: IFC_Entity
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInventory: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _Jurisdiction {get; }
		public IFC_SET<IFCPerson>? _ResponsiblePersons {get; }
		public IFCCostValue? _CurrentValue {get; }
		public IFCCostValue? _OriginalValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIrregularTimeSeries: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
		public IFC_LIST<IFCIrregularTimeSeriesValue>? _Values {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIrregularTimeSeriesValue: IFC_Entity
	{
		public IFC_LIST<IFCValue>? _ListValues {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCJunctionBoxType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCJunctionBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Depth {get; set;}
		public IFCPositiveLengthMeasure? _Width {get; set;}
		public IFCPositiveLengthMeasure? _Thickness {get; set;}
		public IFCPlaneAngleMeasure? _LegSlope {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLaborResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLampType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLibraryInformation: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCLabel? _Version {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLibraryReference: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightDistributionData: IFC_Entity
	{
		public IFCPlaneAngleMeasure? _MainPlaneAngle {get; set;}
		public IFC_LIST<IFCPlaneAngleMeasure>? _SecondaryPlaneAngle {get; set;}
		public IFC_LIST<IFCLuminousIntensityDistributionMeasure>? _LuminousIntensity {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightFixtureType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLightFixtureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightIntensityDistribution: IFC_Entity
	{
		public IFCLightDistributionCurveEnum? _LightDistributionCurve {get; set;}
		public IFC_LIST<IFCLightDistributionData>? _DistributionData {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSource: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSourceAmbient: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSourceDirectional: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
		public IFCDirection? _Orientation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSourceGoniometric: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCColourRgb? _ColourAppearance {get; }
		public IFCThermodynamicTemperatureMeasure? _ColourTemperature {get; }
		public IFCLuminousFluxMeasure? _LuminousFlux {get; }
		public IFCLightEmissionSourceEnum? _LightEmissionSource {get; }
		public IFCLightDistributionDataSourceSelect? _LightDistributionDataSource {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSourcePositional: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
		public IFCCartesianPoint? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCReal? _ConstantAttenuation {get; }
		public IFCReal? _DistanceAttenuation {get; }
		public IFCReal? _QuadricAttenuation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightSourceSpot: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
		public IFCCartesianPoint? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCReal? _ConstantAttenuation {get; }
		public IFCReal? _DistanceAttenuation {get; }
		public IFCReal? _QuadricAttenuation {get; }
		public IFCDirection? _Orientation {get; }
		public IFCReal? _ConcentrationExponent {get; }
		public IFCPositivePlaneAngleMeasure? _SpreadAngle {get; }
		public IFCPositivePlaneAngleMeasure? _BeamWidthAngle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLine: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _Pnt {get; }
		public IFCVector? _Dir {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearDimension: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLocalPlacement: IFC_Entity
	{
		public IFC_SET<IFCProduct>? _PlacesObject {get; }
		public IFCObjectPlacement? _PlacementRelTo {get; }
		public IFCAxis2Placement? _RelativePlacement {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLocalTime: IFC_Entity
	{
		public IFCHourInDay? _HourComponent {get; set;}
		public IFCMinuteInHour? _MinuteComponent {get; set;}
		public IFCSecondInMinute? _SecondComponent {get; set;}
		public IFCCoordinatedUniversalTimeOffset? _Zone {get; set;}
		public IFCDaylightSavingHour? _DaylightSavingOffset {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLoop: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCManifoldSolidBrep: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMappedItem: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationMap? _MappingSource {get; }
		public IFCCartesianTransformationOperator? _MappingTarget {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterial: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_SET<IFCMaterialDefinitionRepresentation>? _HasRepresentation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialClassificationRelationship: IFC_Entity
	{
		public IFCMaterial? _ClassifiedMaterial {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialDefinitionRepresentation: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_LIST<IFCRepresentation>? _Representations {get; set;}
		public IFCMaterial? _RepresentedMaterial {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialLayer: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCLogical? _IsVentilated {get; set;}
		public IFCMaterialLayerSet? _ToMaterialLayerSet {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialLayerSet: IFC_Entity
	{
		public IFC_LIST<IFCMaterialLayer>? _MaterialLayers {get; set;}
		public IFCLabel? _LayerSetName {get; set;}
		public IFCLengthMeasure? _TotalThickness {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialLayerSetUsage: IFC_Entity
	{
		public IFCMaterialLayerSet? _ForLayerSet {get; set;}
		public IFCLayerSetDirectionEnum? _LayerSetDirection {get; set;}
		public IFCDirectionSenseEnum? _DirectionSense {get; set;}
		public IFCLengthMeasure? _OffsetFromReferenceLine {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialList: IFC_Entity
	{
		public IFC_LIST<IFCMaterial>? _Materials {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProperties: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCMeasureWithUnit: IFC_Entity
	{
		public IFCValue? _ValueComponent {get; set;}
		public IFCUnit? _UnitComponent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalConcreteMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCDynamicViscosityMeasure? _DynamicViscosity {get; set;}
		public IFCModulusOfElasticityMeasure? _YoungModulus {get; set;}
		public IFCModulusOfElasticityMeasure? _ShearModulus {get; set;}
		public IFCPositiveRatioMeasure? _PoissonRatio {get; set;}
		public IFCThermalExpansionCoefficientMeasure? _ThermalExpansionCoefficient {get; set;}
		public IFCPressureMeasure? _CompressiveStrength {get; set;}
		public IFCPositiveLengthMeasure? _MaxAggregateSize {get; set;}
		public IFCText? _AdmixturesDescription {get; set;}
		public IFCText? _Workability {get; set;}
		public IFCNormalisedRatioMeasure? _ProtectivePoreRatio {get; set;}
		public IFCText? _WaterImpermeability {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalFastener: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCPositiveLengthMeasure? _NominalLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalFastenerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCDynamicViscosityMeasure? _DynamicViscosity {get; set;}
		public IFCModulusOfElasticityMeasure? _YoungModulus {get; set;}
		public IFCModulusOfElasticityMeasure? _ShearModulus {get; set;}
		public IFCPositiveRatioMeasure? _PoissonRatio {get; set;}
		public IFCThermalExpansionCoefficientMeasure? _ThermalExpansionCoefficient {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMechanicalSteelMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCDynamicViscosityMeasure? _DynamicViscosity {get; set;}
		public IFCModulusOfElasticityMeasure? _YoungModulus {get; set;}
		public IFCModulusOfElasticityMeasure? _ShearModulus {get; set;}
		public IFCPositiveRatioMeasure? _PoissonRatio {get; set;}
		public IFCThermalExpansionCoefficientMeasure? _ThermalExpansionCoefficient {get; set;}
		public IFCPressureMeasure? _YieldStress {get; set;}
		public IFCPressureMeasure? _UltimateStress {get; set;}
		public IFCPositiveRatioMeasure? _UltimateStrain {get; set;}
		public IFCModulusOfElasticityMeasure? _HardeningModule {get; set;}
		public IFCPressureMeasure? _ProportionalStress {get; set;}
		public IFCPositiveRatioMeasure? _PlasticStrain {get; set;}
		public IFC_SET<IFCRelaxation>? _Relaxations {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMember: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMemberType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMemberTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMetric: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraintEnum? _ConstraintGrade {get; set;}
		public IFCLabel? _ConstraintSource {get; set;}
		public IFCActorSelect? _CreatingActor {get; set;}
		public IFCLabel? _UserDefinedGrade {get; set;}
		public IFCBenchmarkEnum? _Benchmark {get; set;}
		public IFCLabel? _ValueSource {get; set;}
		public IFCMetricValueSelect? _DataValue {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMonetaryUnit: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCMotorConnectionType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMotorConnectionTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMove: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCIdentifier? _TaskId {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
		public BOOLEAN? _IsMilestone {get; }
		public INTEGER? _Priority {get; }
		public IFCSpatialStructureElement? _MoveFrom {get; }
		public IFCSpatialStructureElement? _MoveTo {get; }
		public IFC_LIST<IFCText>? _PunchList {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCNamedUnit: IFC_Entity
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCObject: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCObjectDefinition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCObjectPlacement: IFC_Entity
	{
		public IFC_SET<IFCProduct>? _PlacesObject {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCObjective: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraintEnum? _ConstraintGrade {get; set;}
		public IFCLabel? _ConstraintSource {get; set;}
		public IFCActorSelect? _CreatingActor {get; set;}
		public IFCLabel? _UserDefinedGrade {get; set;}
		public IFCObjectiveEnum? _ObjectiveQualifier {get; set;}
		public IFCLabel? _UserDefinedQualifier {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOccupant: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _TheActor {get; }
		public IFC_SET<IFCRelAssignsToActor>? _IsActingUpon {get; }
		public IFCOccupantTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOffsetCurve2D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLengthMeasure? _Distance {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOffsetCurve3D: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLengthMeasure? _Distance {get; }
		public IFCDirection? _RefDirection {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOneDirectionRepeatFactor: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVector? _RepeatFactor {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOpenShell: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOpeningElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFC_SET<IFCRelFillsElement>? _HasFillings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOpticalMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCPositiveRatioMeasure? _VisibleTransmittance {get; set;}
		public IFCPositiveRatioMeasure? _SolarTransmittance {get; set;}
		public IFCPositiveRatioMeasure? _ThermalIrTransmittance {get; set;}
		public IFCPositiveRatioMeasure? _ThermalIrEmissivityBack {get; set;}
		public IFCPositiveRatioMeasure? _ThermalIrEmissivityFront {get; set;}
		public IFCPositiveRatioMeasure? _VisibleReflectanceBack {get; set;}
		public IFCPositiveRatioMeasure? _VisibleReflectanceFront {get; set;}
		public IFCPositiveRatioMeasure? _SolarReflectanceFront {get; set;}
		public IFCPositiveRatioMeasure? _SolarReflectanceBack {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOrderAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCIdentifier? _TaskId {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
		public BOOLEAN? _IsMilestone {get; }
		public INTEGER? _Priority {get; }
		public IFCIdentifier? _ActionID {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOrganization: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_LIST<IFCActorRole>? _Roles {get; set;}
		public IFC_LIST<IFCAddress>? _Addresses {get; set;}
		public IFC_SET<IFCOrganizationRelationship>? _IsRelatedBy {get; }
		public IFC_SET<IFCOrganizationRelationship>? _Relates {get; }
		public IFC_SET<IFCPersonAndOrganization>? _Engages {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOrganizationRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCOrganization? _RelatingOrganization {get; set;}
		public IFC_SET<IFCOrganization>? _RelatedOrganizations {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCOrientedEdge: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCEdge? _EdgeElement {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOutletType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCOutletTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOwnerHistory: IFC_Entity
	{
		public IFCPersonAndOrganization? _OwningUser {get; set;}
		public IFCApplication? _OwningApplication {get; set;}
		public IFCStateEnum? _State {get; set;}
		public IFCChangeActionEnum? _ChangeAction {get; set;}
		public IFCTimeStamp? _LastModifiedDate {get; set;}
		public IFCPersonAndOrganization? _LastModifyingUser {get; set;}
		public IFCApplication? _LastModifyingApplication {get; set;}
		public IFCTimeStamp? _CreationDate {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCParameterizedProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPath: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCOrientedEdge>? _EdgeList {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPerformanceHistory: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCLabel? _LifeCyclePhase {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPermeableCoveringProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPermeableCoveringOperationEnum? _OperationType {get; }
		public IFCWindowPanelPositionEnum? _PanelPosition {get; }
		public IFCPositiveLengthMeasure? _FrameDepth {get; }
		public IFCPositiveLengthMeasure? _FrameThickness {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPermit: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPerson: IFC_Entity
	{
		public IFCLabel? _FamilyName {get; set;}
		public IFCLabel? _GivenName {get; set;}
		public IFC_LIST<IFCLabel>? _MiddleNames {get; set;}
		public IFC_LIST<IFCLabel>? _PrefixTitles {get; set;}
		public IFC_LIST<IFCLabel>? _SuffixTitles {get; set;}
		public IFC_LIST<IFCActorRole>? _Roles {get; set;}
		public IFC_LIST<IFCAddress>? _Addresses {get; set;}
		public IFC_SET<IFCPersonAndOrganization>? _EngagedIn {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPersonAndOrganization: IFC_Entity
	{
		public IFCPerson? _ThePerson {get; set;}
		public IFCOrganization? _TheOrganization {get; set;}
		public IFC_LIST<IFCActorRole>? _Roles {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPhysicalComplexQuantity: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFC_SET<IFCPhysicalQuantity>? _HasQuantities {get; }
		public IFCLabel? _Discrimination {get; }
		public IFCLabel? _Quality {get; }
		public IFCLabel? _Usage {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPhysicalQuantity: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPhysicalSimpleQuantity: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPile: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPileTypeEnum? _PredefinedType {get; }
		public IFCPileConstructionEnum? _ConstructionType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeFittingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPipeFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPipeSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPixelTexture: IFC_Entity
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
		public IFCInteger? _Width {get; set;}
		public IFCInteger? _Height {get; set;}
		public IFCInteger? _ColourComponents {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPlacement: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlanarBox: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _SizeInX {get; }
		public IFCLengthMeasure? _SizeInY {get; }
		public IFCAxis2Placement? _Placement {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlanarExtent: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _SizeInX {get; }
		public IFCLengthMeasure? _SizeInY {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlane: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlateType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPlateTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPoint: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPointOnCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCParameterValue? _PointParameter {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPointOnSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCParameterValue? _PointParameterU {get; }
		public IFCParameterValue? _PointParameterV {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPolyLoop: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCCartesianPoint>? _Polygon {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPolygonalBoundedHalfSpace: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCBoundedCurve? _PolygonalBoundary {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPolyline: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCCartesianPoint>? _Points {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPort: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsPorts>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelConnectsPorts>? _ConnectedTo {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPostalAddress: IFC_Entity
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public IFC_SET<IFCPerson>? _OfPerson {get; }
		public IFC_SET<IFCOrganization>? _OfOrganization {get; }
		public IFCLabel? _InternalLocation {get; }
		public IFC_LIST<IFCLabel>? _AddressLines {get; }
		public IFCLabel? _PostalBox {get; }
		public IFCLabel? _Town {get; }
		public IFCLabel? _Region {get; }
		public IFCLabel? _PostalCode {get; }
		public IFCLabel? _Country {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedColour: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedCurveFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedDimensionSymbol: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedItem: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedPointMarkerSymbol: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedSymbol: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedTerminatorSymbol: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedTextFont: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationLayerAssignment: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCLayeredItem>? _AssignedItems {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationLayerWithStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCLayeredItem>? _AssignedItems {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationStyleAssignment: IFC_Entity
	{
		public IFC_SET<IFCPresentationStyleSelect>? _Styles {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProcedure: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProcess: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProduct: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProductDefinitionShape: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_LIST<IFCRepresentation>? _Representations {get; set;}
		public IFC_SET<IFCProduct>? _ShapeOfProduct {get; }
		public IFC_SET<IFCShapeAspect>? _HasShapeAspects {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProductRepresentation: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_LIST<IFCRepresentation>? _Representations {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProductsOfCombustionProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCSpecificHeatCapacityMeasure? _SpecificHeatCapacity {get; set;}
		public IFCPositiveRatioMeasure? _N20Content {get; set;}
		public IFCPositiveRatioMeasure? _COContent {get; set;}
		public IFCPositiveRatioMeasure? _CO2Content {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProfileProperties: IFC_Entity
	{
		public IFCProfileDef? _ProfileDefinition {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCProject: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public IFC_SET<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectOrder: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCProjectOrderTypeEnum? _PredefinedType {get; }
		public IFCLabel? _Status {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectOrderRecord: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_LIST<IFCRelAssignsToProjectOrder>? _Records {get; }
		public IFCProjectOrderRecordTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectionCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectionElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelProjectsElement? _ProjectsElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProperty: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyBoundedValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCValue? _UpperBoundValue {get; }
		public IFCValue? _LowerBoundValue {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyConstraintRelationship: IFC_Entity
	{
		public IFCConstraint? _RelatingConstraint {get; set;}
		public IFC_SET<IFCProperty>? _RelatedProperties {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyDefinition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyDependencyRelationship: IFC_Entity
	{
		public IFCProperty? _DependingProperty {get; set;}
		public IFCProperty? _DependantProperty {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCText? _Expression {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyEnumeratedValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFC_LIST<IFCValue>? _EnumerationValues {get; }
		public IFCPropertyEnumeration? _EnumerationReference {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyEnumeration: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_LIST<IFCValue>? _EnumerationValues {get; set;}
		public IFCUnit? _Unit {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyListValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFC_LIST<IFCValue>? _ListValues {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyReferenceValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCObjectReferenceSelect? _PropertyReference {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySet: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFC_SET<IFCProperty>? _HasProperties {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySetDefinition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySingleValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCValue? _NominalValue {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyTableValue: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
		public IFC_LIST<IFCValue>? _DefiningValues {get; }
		public IFC_LIST<IFCValue>? _DefinedValues {get; }
		public IFCText? _Expression {get; }
		public IFCUnit? _DefiningUnit {get; }
		public IFCUnit? _DefinedUnit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCProtectiveDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProxy: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCObjectTypeEnum? _ProxyType {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPumpType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPumpTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityArea: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCAreaMeasure? _AreaValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityCount: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCCountMeasure? _CountValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityLength: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCLengthMeasure? _LengthValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCTimeMeasure? _TimeValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityVolume: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCVolumeMeasure? _VolumeValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityWeight: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCMassMeasure? _WeightValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRadiusDimension: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRailing: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRailingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRailingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRailingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRamp: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRampFlight: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRampFlightType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRampFlightTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRationalBezierCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public INTEGER? _Degree {get; }
		public IFC_LIST<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public LOGICAL? _ClosedCurve {get; }
		public LOGICAL? _SelfIntersect {get; }
		public IFC_ARRAY<IFCCartesianPoint>? _ControlPoints {get; }
		public INTEGER? _UpperIndexOnControlPoints {get; }
		public IFC_LIST<REAL>? _WeightsData {get; }
		public IFC_ARRAY<REAL>? _Weights {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRectangleHollowProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
		public IFCPositiveLengthMeasure? _WallThickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRectangleProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRectangularPyramid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _XLength {get; }
		public IFCPositiveLengthMeasure? _YLength {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRectangularTrimmedSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCParameterValue? _U1 {get; }
		public IFCParameterValue? _V1 {get; }
		public IFCParameterValue? _U2 {get; }
		public IFCParameterValue? _V2 {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReferencesValueDocument: IFC_Entity
	{
		public IFCDocumentSelect? _ReferencedDocument {get; set;}
		public IFC_SET<IFCAppliedValue>? _ReferencingValues {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRegularTimeSeries: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
		public IFCTimeMeasure? _TimeStep {get; set;}
		public IFC_LIST<IFCTimeSeriesValue>? _Values {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcementBarProperties: IFC_Entity
	{
		public IFCAreaMeasure? _TotalCrossSectionArea {get; set;}
		public IFCLabel? _SteelGrade {get; set;}
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; set;}
		public IFCLengthMeasure? _EffectiveDepth {get; set;}
		public IFCPositiveLengthMeasure? _NominalBarDiameter {get; set;}
		public IFCCountMeasure? _BarCount {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcementDefinitionProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCLabel? _DefinitionType {get; }
		public IFC_LIST<IFCSectionReinforcementProperties>? _ReinforcementSectionDefinitions {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingBar: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _BarLength {get; }
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingMesh: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCPositiveLengthMeasure? _MeshLength {get; }
		public IFCPositiveLengthMeasure? _MeshWidth {get; }
		public IFCPositiveLengthMeasure? _LongitudinalBarNominalDiameter {get; }
		public IFCPositiveLengthMeasure? _TransverseBarNominalDiameter {get; }
		public IFCAreaMeasure? _LongitudinalBarCrossSectionArea {get; }
		public IFCAreaMeasure? _TransverseBarCrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _LongitudinalBarSpacing {get; }
		public IFCPositiveLengthMeasure? _TransverseBarSpacing {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAggregates: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCObjectDefinition? _RelatingObject {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssigns: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsTasks: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
		public IFCScheduleTimeControl? _TimeForTask {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToActor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCActor? _RelatingActor {get; set;}
		public IFCActorRole? _ActingRole {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToControl: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToGroup: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCGroup? _RelatingGroup {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToProcess: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCMeasureWithUnit? _QuantityInProcess {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToProduct: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToProjectOrder: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociates: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesAppliedValue: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRoot>? _RelatedObjects {get; set;}
		public IFCAppliedValue? _RelatingAppliedValue {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesApproval: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCApproval? _RelatingApproval {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesClassification: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesConstraint: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Intent {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesDocument: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDocumentSelect? _RelatingDocument {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesLibrary: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLibrarySelect? _RelatingLibrary {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesMaterial: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCMaterialSelect? _RelatingMaterial {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesProfileProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRoot>? _RelatedObjects {get; set;}
		public IFCProfileProperties? _RelatingProfileProperties {get; set;}
		public IFCShapeAspect? _ProfileSectionLocation {get; set;}
		public IFCOrientationSelect? _ProfileOrientation {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnects: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCElement? _RelatedElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsPathElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCElement? _RelatedElement {get; set;}
		public IFCConnectionTypeEnum? _RelatedConnectionType {get; set;}
		public IFCConnectionTypeEnum? _RelatingConnectionType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsPortToElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCPort? _RelatingPort {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsPorts: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCPort? _RelatingPort {get; set;}
		public IFCPort? _RelatedPort {get; set;}
		public IFCElement? _RealizingElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsStructuralActivity: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCStructuralActivityAssignmentSelect? _RelatingElement {get; set;}
		public IFCStructuralActivity? _RelatedStructuralActivity {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsStructuralElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCStructuralMember? _RelatedStructuralMember {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsStructuralMember: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCStructuralMember? _RelatingStructuralMember {get; set;}
		public IFCStructuralConnection? _RelatedStructuralConnection {get; set;}
		public IFCBoundaryCondition? _AppliedCondition {get; set;}
		public IFCStructuralConnectionCondition? _AdditionalConditions {get; set;}
		public IFCLengthMeasure? _SupportedLength {get; set;}
		public IFCAxis2Placement3D? _ConditionCoordinateSystem {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsWithEccentricity: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCStructuralMember? _RelatingStructuralMember {get; set;}
		public IFCStructuralConnection? _RelatedStructuralConnection {get; set;}
		public IFCBoundaryCondition? _AppliedCondition {get; set;}
		public IFCStructuralConnectionCondition? _AdditionalConditions {get; set;}
		public IFCLengthMeasure? _SupportedLength {get; set;}
		public IFCAxis2Placement3D? _ConditionCoordinateSystem {get; set;}
		public IFCConnectionGeometry? _ConnectionConstraint {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelConnectsWithRealizingElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCElement? _RelatedElement {get; set;}
		public IFC_SET<IFCElement>? _RealizingElements {get; set;}
		public IFCLabel? _ConnectionType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelContainedInSpatialStructure: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCProduct>? _RelatedElements {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelCoversBldgElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingBuildingElement {get; set;}
		public IFC_SET<IFCCovering>? _RelatedCoverings {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelCoversSpaces: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCCovering>? _RelatedCoverings {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDecomposes: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDefines: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDefinesByProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDefinesByType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObject>? _RelatedObjects {get; set;}
		public IFCTypeObject? _RelatingType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelFillsElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCOpeningElement? _RelatingOpeningElement {get; set;}
		public IFCElement? _RelatedBuildingElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelFlowControlElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCDistributionControlElement>? _RelatedControlElements {get; set;}
		public IFCDistributionFlowElement? _RelatingFlowElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelInteractionRequirements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCCountMeasure? _DailyInteraction {get; set;}
		public IFCNormalisedRatioMeasure? _ImportanceRating {get; set;}
		public IFCSpatialStructureElement? _LocationOfInteraction {get; set;}
		public IFCSpaceProgram? _RelatedSpaceProgram {get; set;}
		public IFCSpaceProgram? _RelatingSpaceProgram {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelNests: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCObjectDefinition? _RelatingObject {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelOccupiesSpaces: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCActor? _RelatingActor {get; set;}
		public IFCActorRole? _ActingRole {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelOverridesProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObject>? _RelatedObjects {get; set;}
		public IFCPropertySetDefinition? _RelatingPropertyDefinition {get; set;}
		public IFC_SET<IFCProperty>? _OverridingProperties {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelProjectsElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCFeatureElementAddition? _RelatedFeatureElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelReferencedInSpatialStructure: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelSchedulesCostItems: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelSequence: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCProcess? _RelatingProcess {get; set;}
		public IFCProcess? _RelatedProcess {get; set;}
		public IFCSequenceEnum? _SequenceType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelServicesBuildings: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCSystem? _RelatingSystem {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelSpaceBoundary: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatedBuildingElement {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCPhysicalOrVirtualEnum? _PhysicalOrVirtualBoundary {get; set;}
		public IFCInternalOrExternalEnum? _InternalOrExternalBoundary {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelVoidsElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingBuildingElement {get; set;}
		public IFCFeatureElementSubtraction? _RelatedOpeningElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelationship: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelaxation: IFC_Entity
	{
		public IFCNormalisedRatioMeasure? _RelaxationValue {get; set;}
		public IFCNormalisedRatioMeasure? _InitialStress {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRepresentation: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRepresentationContext: IFC_Entity
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public IFC_SET<IFCRepresentation>? _RepresentationsInContext {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRepresentationItem: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRepresentationMap: IFC_Entity
	{
		public IFCAxis2Placement? _MappingOrigin {get; set;}
		public IFCRepresentation? _MappedRepresentation {get; set;}
		public IFC_SET<IFCMappedItem>? _MapUsage {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRevolvedAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCAxis1Placement? _Axis {get; }
		public IFCPlaneAngleMeasure? _Angle {get; }
		public IFCLine? _AxisLine {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRibPlateProfileProperties: IFC_Entity
	{
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ProfileDefinition {get; set;}
		public IFCPositiveLengthMeasure? _Thickness {get; set;}
		public IFCPositiveLengthMeasure? _RibHeight {get; set;}
		public IFCPositiveLengthMeasure? _RibWidth {get; set;}
		public IFCPositiveLengthMeasure? _RibSpacing {get; set;}
		public IFCRibPlateDirectionEnum? _Direction {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRightCircularCone: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
		public IFCPositiveLengthMeasure? _BottomRadius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRightCircularCylinder: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRoof: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRoot: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoundedEdgeFeature: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRoundedRectangleProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
		public IFCPositiveLengthMeasure? _RoundingRadius {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSIUnit: IFC_Entity
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCSIPrefix? _Prefix {get; set;}
		public IFCSIUnitName? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSanitaryTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSanitaryTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCScheduleTimeControl: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCDateTimeSelect? _ActualStart {get; }
		public IFCDateTimeSelect? _EarlyStart {get; }
		public IFCDateTimeSelect? _LateStart {get; }
		public IFCDateTimeSelect? _ScheduleStart {get; }
		public IFCDateTimeSelect? _ActualFinish {get; }
		public IFCDateTimeSelect? _EarlyFinish {get; }
		public IFCDateTimeSelect? _LateFinish {get; }
		public IFCDateTimeSelect? _ScheduleFinish {get; }
		public IFCTimeMeasure? _ScheduleDuration {get; }
		public IFCTimeMeasure? _ActualDuration {get; }
		public IFCTimeMeasure? _RemainingTime {get; }
		public IFCTimeMeasure? _FreeFloat {get; }
		public IFCTimeMeasure? _TotalFloat {get; }
		public BOOLEAN? _IsCritical {get; }
		public IFCDateTimeSelect? _StatusTime {get; }
		public IFCTimeMeasure? _StartFloat {get; }
		public IFCTimeMeasure? _FinishFloat {get; }
		public IFCPositiveRatioMeasure? _Completion {get; }
		public IFCRelAssignsTasks? _ScheduleTimeControlAssigned {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionProperties: IFC_Entity
	{
		public IFCSectionTypeEnum? _SectionType {get; set;}
		public IFCProfileDef? _StartProfile {get; set;}
		public IFCProfileDef? _EndProfile {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionReinforcementProperties: IFC_Entity
	{
		public IFCLengthMeasure? _LongitudinalStartPosition {get; set;}
		public IFCLengthMeasure? _LongitudinalEndPosition {get; set;}
		public IFCLengthMeasure? _TransversePosition {get; set;}
		public IFCReinforcingBarRoleEnum? _ReinforcementRole {get; set;}
		public IFCSectionProperties? _SectionDefinition {get; set;}
		public IFC_SET<IFCReinforcementBarProperties>? _CrossSectionReinforcementDefinitions {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionedSpine: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCompositeCurve? _SpineCurve {get; }
		public IFC_LIST<IFCProfileDef>? _CrossSections {get; }
		public IFC_LIST<IFCAxis2Placement3D>? _CrossSectionPositions {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSensorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSensorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCServiceLife: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCServiceLifeTypeEnum? _ServiceLifeType {get; }
		public IFCTimeMeasure? _ServiceLifeDuration {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCServiceLifeFactor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCServiceLifeFactorTypeEnum? _PredefinedType {get; }
		public IFCMeasureValue? _UpperValue {get; }
		public IFCMeasureValue? _MostUsedValue {get; }
		public IFCMeasureValue? _LowerValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCShapeAspect: IFC_Entity
	{
		public IFC_LIST<IFCShapeModel>? _ShapeRepresentations {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCShapeModel: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public IFC_SET<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCShapeRepresentation: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public IFC_SET<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCShellBasedSurfaceModel: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCShell>? _SbsmBoundary {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSimpleProperty: IFC_Entity
	{
		public IFCIdentifier? _Name {get; set;}
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public IFC_SET<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public IFC_SET<IFCComplexProperty>? _PartOfComplex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSite: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCCompoundPlaneAngleMeasure? _RefLatitude {get; }
		public IFCCompoundPlaneAngleMeasure? _RefLongitude {get; }
		public IFCLengthMeasure? _RefElevation {get; }
		public IFCLabel? _LandTitleNumber {get; }
		public IFCPostalAddress? _SiteAddress {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSlab: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSlabType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSlippageConnectionCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCLengthMeasure? _SlippageX {get; set;}
		public IFCLengthMeasure? _SlippageY {get; set;}
		public IFCLengthMeasure? _SlippageZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSolidModel: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCBoolean? _IsAttenuating {get; }
		public IFCSoundScaleEnum? _SoundScale {get; }
		public IFC_LIST<IFCSoundValue>? _SoundValues {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSoundValue: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCTimeSeries? _SoundLevelTimeSeries {get; }
		public IFCFrequencyMeasure? _Frequency {get; }
		public IFCDerivedMeasureValue? _SoundLevelSingleValue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpace: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _ElevationWithFlooring {get; }
		public IFC_SET<IFCRelCoversSpaces>? _HasCoverings {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceHeaterType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpaceHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceProgram: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFCIdentifier? _SpaceProgramIdentifier {get; }
		public IFCAreaMeasure? _MaxRequiredArea {get; }
		public IFCAreaMeasure? _MinRequiredArea {get; }
		public IFCSpatialStructureElement? _RequestedLocation {get; }
		public IFCAreaMeasure? _StandardRequiredArea {get; }
		public IFC_SET<IFCRelInteractionRequirements>? _HasInteractionReqsFrom {get; }
		public IFC_SET<IFCRelInteractionRequirements>? _HasInteractionReqsTo {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceThermalLoadProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveRatioMeasure? _ApplicableValueRatio {get; }
		public IFCThermalLoadSourceEnum? _ThermalLoadSource {get; }
		public IFCPropertySourceEnum? _PropertySource {get; }
		public IFCText? _SourceDescription {get; }
		public IFCPowerMeasure? _MaximumValue {get; }
		public IFCPowerMeasure? _MinimumValue {get; }
		public IFCTimeSeries? _ThermalLoadTimeSeriesValues {get; }
		public IFCLabel? _UserDefinedThermalLoadSource {get; }
		public IFCLabel? _UserDefinedPropertySource {get; }
		public IFCThermalLoadTypeEnum? _ThermalLoadType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpaceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialStructureElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialStructureElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSphere: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStackTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStackTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStair: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStairFlight: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _RiserHeight {get; }
		public IFCPositiveLengthMeasure? _TreadLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStairFlightType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStairFlightTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralActivity: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralAnalysisModel: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCAnalysisModelTypeEnum? _PredefinedType {get; }
		public IFCAxis2Placement3D? _OrientationOf2DPlane {get; }
		public IFC_SET<IFCStructuralLoadGroup>? _LoadedBy {get; }
		public IFC_SET<IFCStructuralResultGroup>? _HasResults {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralConnection: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralConnectionCondition: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveConnection: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveMember: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveMemberVarying: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralItem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLinearAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLinearActionVarying: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCRelConnectsStructuralActivity? _AssignedToStructuralItem {get; }
		public BOOLEAN? _DestabilizingLoad {get; }
		public IFCStructuralReaction? _CausedBy {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCShapeAspect? _VaryingAppliedLoadLocation {get; }
		public IFC_LIST<IFCStructuralLoad>? _SubsequentAppliedLoads {get; }
		public IFC_LIST<IFCStructuralLoad>? _VaryingAppliedLoads {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoad: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadGroup: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLoadGroupTypeEnum? _PredefinedType {get; }
		public IFCActionTypeEnum? _ActionType {get; }
		public IFCActionSourceTypeEnum? _ActionSource {get; }
		public IFCRatioMeasure? _Coefficient {get; }
		public IFCLabel? _Purpose {get; }
		public IFC_SET<IFCStructuralResultGroup>? _SourceOfResultGroup {get; }
		public IFC_SET<IFCStructuralAnalysisModel>? _LoadGroupFor {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadLinearForce: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCLinearForceMeasure? _LinearForceX {get; set;}
		public IFCLinearForceMeasure? _LinearForceY {get; set;}
		public IFCLinearForceMeasure? _LinearForceZ {get; set;}
		public IFCLinearMomentMeasure? _LinearMomentX {get; set;}
		public IFCLinearMomentMeasure? _LinearMomentY {get; set;}
		public IFCLinearMomentMeasure? _LinearMomentZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadPlanarForce: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceX {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceY {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadSingleDisplacement: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCLengthMeasure? _DisplacementX {get; set;}
		public IFCLengthMeasure? _DisplacementY {get; set;}
		public IFCLengthMeasure? _DisplacementZ {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRX {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRY {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadSingleDisplacementDistortion: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCLengthMeasure? _DisplacementX {get; set;}
		public IFCLengthMeasure? _DisplacementY {get; set;}
		public IFCLengthMeasure? _DisplacementZ {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRX {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRY {get; set;}
		public IFCPlaneAngleMeasure? _RotationalDisplacementRZ {get; set;}
		public IFCCurvatureMeasure? _Distortion {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadSingleForce: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCForceMeasure? _ForceX {get; set;}
		public IFCForceMeasure? _ForceY {get; set;}
		public IFCForceMeasure? _ForceZ {get; set;}
		public IFCTorqueMeasure? _MomentX {get; set;}
		public IFCTorqueMeasure? _MomentY {get; set;}
		public IFCTorqueMeasure? _MomentZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadSingleForceWarping: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCForceMeasure? _ForceX {get; set;}
		public IFCForceMeasure? _ForceY {get; set;}
		public IFCForceMeasure? _ForceZ {get; set;}
		public IFCTorqueMeasure? _MomentX {get; set;}
		public IFCTorqueMeasure? _MomentY {get; set;}
		public IFCTorqueMeasure? _MomentZ {get; set;}
		public IFCWarpingMomentMeasure? _WarpingMoment {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadStatic: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadTemperature: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralMember: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralPlanarAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralPlanarActionVarying: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCRelConnectsStructuralActivity? _AssignedToStructuralItem {get; }
		public BOOLEAN? _DestabilizingLoad {get; }
		public IFCStructuralReaction? _CausedBy {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCShapeAspect? _VaryingAppliedLoadLocation {get; }
		public IFC_LIST<IFCStructuralLoad>? _SubsequentAppliedLoads {get; }
		public IFC_LIST<IFCStructuralLoad>? _VaryingAppliedLoads {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralPointAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralPointConnection: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralPointReaction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralProfileProperties: IFC_Entity
	{
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ProfileDefinition {get; set;}
		public IFCMassPerLengthMeasure? _PhysicalWeight {get; set;}
		public IFCPositiveLengthMeasure? _Perimeter {get; set;}
		public IFCPositiveLengthMeasure? _MinimumPlateThickness {get; set;}
		public IFCPositiveLengthMeasure? _MaximumPlateThickness {get; set;}
		public IFCAreaMeasure? _CrossSectionArea {get; set;}
		public IFCMomentOfInertiaMeasure? _TorsionalConstantX {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaYZ {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaY {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaZ {get; set;}
		public IFCWarpingConstantMeasure? _WarpingConstant {get; set;}
		public IFCLengthMeasure? _ShearCentreZ {get; set;}
		public IFCLengthMeasure? _ShearCentreY {get; set;}
		public IFCAreaMeasure? _ShearDeformationAreaZ {get; set;}
		public IFCAreaMeasure? _ShearDeformationAreaY {get; set;}
		public IFCSectionModulusMeasure? _MaximumSectionModulusY {get; set;}
		public IFCSectionModulusMeasure? _MinimumSectionModulusY {get; set;}
		public IFCSectionModulusMeasure? _MaximumSectionModulusZ {get; set;}
		public IFCSectionModulusMeasure? _MinimumSectionModulusZ {get; set;}
		public IFCSectionModulusMeasure? _TorsionalSectionModulus {get; set;}
		public IFCLengthMeasure? _CentreOfGravityInX {get; set;}
		public IFCLengthMeasure? _CentreOfGravityInY {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralReaction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralResultGroup: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCAnalysisTheoryTypeEnum? _TheoryType {get; }
		public IFCStructuralLoadGroup? _ResultForLoadGroup {get; }
		public IFC_SET<IFCStructuralAnalysisModel>? _ResultGroupFor {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSteelProfileProperties: IFC_Entity
	{
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ProfileDefinition {get; set;}
		public IFCMassPerLengthMeasure? _PhysicalWeight {get; set;}
		public IFCPositiveLengthMeasure? _Perimeter {get; set;}
		public IFCPositiveLengthMeasure? _MinimumPlateThickness {get; set;}
		public IFCPositiveLengthMeasure? _MaximumPlateThickness {get; set;}
		public IFCAreaMeasure? _CrossSectionArea {get; set;}
		public IFCMomentOfInertiaMeasure? _TorsionalConstantX {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaYZ {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaY {get; set;}
		public IFCMomentOfInertiaMeasure? _MomentOfInertiaZ {get; set;}
		public IFCWarpingConstantMeasure? _WarpingConstant {get; set;}
		public IFCLengthMeasure? _ShearCentreZ {get; set;}
		public IFCLengthMeasure? _ShearCentreY {get; set;}
		public IFCAreaMeasure? _ShearDeformationAreaZ {get; set;}
		public IFCAreaMeasure? _ShearDeformationAreaY {get; set;}
		public IFCSectionModulusMeasure? _MaximumSectionModulusY {get; set;}
		public IFCSectionModulusMeasure? _MinimumSectionModulusY {get; set;}
		public IFCSectionModulusMeasure? _MaximumSectionModulusZ {get; set;}
		public IFCSectionModulusMeasure? _MinimumSectionModulusZ {get; set;}
		public IFCSectionModulusMeasure? _TorsionalSectionModulus {get; set;}
		public IFCLengthMeasure? _CentreOfGravityInX {get; set;}
		public IFCLengthMeasure? _CentreOfGravityInY {get; set;}
		public IFCAreaMeasure? _ShearAreaZ {get; set;}
		public IFCAreaMeasure? _ShearAreaY {get; set;}
		public IFCPositiveRatioMeasure? _PlasticShapeFactorY {get; set;}
		public IFCPositiveRatioMeasure? _PlasticShapeFactorZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceConnection: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceMember: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
		public IFCPositiveLengthMeasure? _Thickness {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceMemberVarying: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFC_SET<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
		public IFCPositiveLengthMeasure? _Thickness {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuredDimensionCallout: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCDraughtingCalloutElement>? _Contents {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public IFC_SET<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStyleModel: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStyledItem: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStyledRepresentation: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSubContractResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSubedge: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCEdge? _ParentEdge {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceCurveSweptAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCSurface? _ReferenceSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceOfLinearExtrusion: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCLengthMeasure? _Depth {get; }
		public IFCVector? _ExtrusionAxis {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceOfRevolution: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis1Placement? _AxisPosition {get; }
		public IFCLine? _AxisLine {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCSurfaceSide? _Side {get; set;}
		public IFC_SET<IFCSurfaceStyleElementSelect>? _Styles {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleLighting: IFC_Entity
	{
		public IFCColourRgb? _DiffuseTransmissionColour {get; set;}
		public IFCColourRgb? _DiffuseReflectionColour {get; set;}
		public IFCColourRgb? _TransmissionColour {get; set;}
		public IFCColourRgb? _ReflectanceColour {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleRefraction: IFC_Entity
	{
		public IFCReal? _RefractionIndex {get; set;}
		public IFCReal? _DispersionFactor {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleRendering: IFC_Entity
	{
		public IFCColourRgb? _SurfaceColour {get; set;}
		public IFCNormalisedRatioMeasure? _Transparency {get; set;}
		public IFCColourOrFactor? _DiffuseColour {get; set;}
		public IFCColourOrFactor? _TransmissionColour {get; set;}
		public IFCColourOrFactor? _DiffuseTransmissionColour {get; set;}
		public IFCColourOrFactor? _ReflectionColour {get; set;}
		public IFCColourOrFactor? _SpecularColour {get; set;}
		public IFCSpecularHighlightSelect? _SpecularHighlight {get; set;}
		public IFCReflectanceMethodEnum? _ReflectanceMethod {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleShading: IFC_Entity
	{
		public IFCColourRgb? _SurfaceColour {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceStyleWithTextures: IFC_Entity
	{
		public IFC_LIST<IFCSurfaceTexture>? _Textures {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceTexture: IFC_Entity
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSweptAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSweptDiskSolid: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCPositiveLengthMeasure? _InnerRadius {get; }
		public IFCParameterValue? _StartParam {get; }
		public IFCParameterValue? _EndParam {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSweptSurface: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSwitchingDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSwitchingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSymbolStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCSymbolStyleSelect? _StyleOfSymbol {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSystem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSystemFurnitureElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Depth {get; set;}
		public IFCPositiveLengthMeasure? _FlangeWidth {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _FlangeThickness {get; set;}
		public IFCPlaneAngleMeasure? _WebSlope {get; set;}
		public IFCPlaneAngleMeasure? _FlangeSlope {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTable: IFC_Entity
	{
		public IFC_LIST<IFCTableRow>? _Rows {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTableRow: IFC_Entity
	{
		public IFC_LIST<IFCValue>? _RowCells {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTankType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTankTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTask: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTelecomAddress: IFC_Entity
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public IFC_SET<IFCPerson>? _OfPerson {get; }
		public IFC_SET<IFCOrganization>? _OfOrganization {get; }
		public IFC_LIST<IFCLabel>? _TelephoneNumbers {get; }
		public IFC_LIST<IFCLabel>? _FacsimileNumbers {get; }
		public IFCLabel? _PagerNumber {get; }
		public IFC_LIST<IFCLabel>? _ElectronicMailAddresses {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTendon: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCTendonTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCForceMeasure? _TensionForce {get; }
		public IFCPressureMeasure? _PreStress {get; }
		public IFCNormalisedRatioMeasure? _FrictionCoefficient {get; }
		public IFCPositiveLengthMeasure? _AnchorageSlip {get; }
		public IFCPositiveLengthMeasure? _MinCurvatureRadius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonAnchor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTerminatorSymbol: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFC_SET<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCAnnotationCurveOccurrence? _AnnotatedCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextLiteral: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPresentableText? _Literal {get; }
		public IFCAxis2Placement? _Placement {get; }
		public IFCTextPath? _Path {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextLiteralWithExtent: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPresentableText? _Literal {get; }
		public IFCAxis2Placement? _Placement {get; }
		public IFCTextPath? _Path {get; }
		public IFCPlanarExtent? _Extent {get; }
		public IFCBoxAlignment? _BoxAlignment {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyle: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCTextFontSelect? _TextFontStyle {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyleFontModel: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_LIST<IFCTextFontName>? _FontFamily {get; set;}
		public IFCFontStyle? _FontStyle {get; set;}
		public IFCFontVariant? _FontVariant {get; set;}
		public IFCFontWeight? _FontWeight {get; set;}
		public IFCSizeSelect? _FontSize {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyleForDefinedFont: IFC_Entity
	{
		public IFCColour? _Colour {get; set;}
		public IFCColour? _BackgroundColour {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyleTextModel: IFC_Entity
	{
		public IFCSizeSelect? _TextIndent {get; set;}
		public IFCTextAlignment? _TextAlign {get; set;}
		public IFCTextDecoration? _TextDecoration {get; set;}
		public IFCSizeSelect? _LetterSpacing {get; set;}
		public IFCSizeSelect? _WordSpacing {get; set;}
		public IFCTextTransformation? _TextTransform {get; set;}
		public IFCSizeSelect? _LineHeight {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextStyleWithBoxCharacteristics: IFC_Entity
	{
		public IFCPositiveLengthMeasure? _BoxHeight {get; set;}
		public IFCPositiveLengthMeasure? _BoxWidth {get; set;}
		public IFCPlaneAngleMeasure? _BoxSlantAngle {get; set;}
		public IFCPlaneAngleMeasure? _BoxRotateAngle {get; set;}
		public IFCSizeSelect? _CharacterSpacing {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureCoordinate: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureCoordinateGenerator: IFC_Entity
	{
		public IFCLabel? _Mode {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureMap: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureVertex: IFC_Entity
	{
		public IFC_LIST<IFCParameterValue>? _Coordinates {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCThermalMaterialProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public IFCSpecificHeatCapacityMeasure? _SpecificHeatCapacity {get; set;}
		public IFCThermodynamicTemperatureMeasure? _BoilingPoint {get; set;}
		public IFCThermodynamicTemperatureMeasure? _FreezingPoint {get; set;}
		public IFCThermalConductivityMeasure? _ThermalConductivity {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeries: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeriesReferenceRelationship: IFC_Entity
	{
		public IFCTimeSeries? _ReferencedTimeSeries {get; set;}
		public IFC_SET<IFCDocumentSelect>? _TimeSeriesReferences {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeriesSchedule: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelDecomposes>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefines>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_LIST<IFCDateTimeSelect>? _ApplicableDates {get; }
		public IFCTimeSeriesScheduleTypeEnum? _TimeSeriesScheduleType {get; }
		public IFCTimeSeries? _TimeSeries {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTimeSeriesValue: IFC_Entity
	{
		public IFC_LIST<IFCValue>? _ListValues {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTopologicalRepresentationItem: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTopologyRepresentation: IFC_Entity
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public IFC_SET<IFCRepresentationItem>? _Items {get; set;}
		public IFC_SET<IFCRepresentationMap>? _RepresentationMap {get; }
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public IFC_SET<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransformerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTransformerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransportElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransportElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTransportElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTrapeziumProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _BottomXDim {get; set;}
		public IFCPositiveLengthMeasure? _TopXDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
		public IFCLengthMeasure? _TopXOffset {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTrimmedCurve: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFC_SET<IFCTrimmingSelect>? _Trim1 {get; }
		public IFC_SET<IFCTrimmingSelect>? _Trim2 {get; }
		public IFCTrimmingPreference? _MasterRepresentation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTubeBundleType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTubeBundleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTwoDirectionRepeatFactor: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVector? _RepeatFactor {get; }
		public IFCVector? _SecondRepeatFactor {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTypeObject: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTypeProduct: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCUShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Depth {get; set;}
		public IFCPositiveLengthMeasure? _FlangeWidth {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _FlangeThickness {get; set;}
		public IFCPlaneAngleMeasure? _FlangeSlope {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitAssignment: IFC_Entity
	{
		public IFC_SET<IFCUnit>? _Units {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryEquipmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCUnitaryEquipmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCValveType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCValveTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVector: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Orientation {get; }
		public IFCLengthMeasure? _Magnitude {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVertex: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVertexBasedTextureMap: IFC_Entity
	{
		public IFC_LIST<IFCTextureVertex>? _TextureVertices {get; set;}
		public IFC_LIST<IFCCartesianPoint>? _TexturePoints {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCVertexLoop: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _LoopVertex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVertexPoint: IFC_Entity
	{
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPoint? _VertexGeometry {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationIsolatorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVibrationIsolatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVirtualElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVirtualGridIntersection: IFC_Entity
	{
		public IFC_LIST<IFCGridAxis>? _IntersectingAxes {get; set;}
		public IFC_LIST<IFCLengthMeasure>? _OffsetDistances {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWall: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWallStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWallType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWasteTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWasteTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWaterProperties: IFC_Entity
	{
		public IFCMaterial? _Material {get; set;}
		public BOOLEAN? _IsPotable {get; set;}
		public IFCIonConcentrationMeasure? _Hardness {get; set;}
		public IFCIonConcentrationMeasure? _AlkalinityConcentration {get; set;}
		public IFCIonConcentrationMeasure? _AcidityConcentration {get; set;}
		public IFCNormalisedRatioMeasure? _ImpuritiesContent {get; set;}
		public IFCPHMeasure? _PHLevel {get; set;}
		public IFCNormalisedRatioMeasure? _DissolvedSolidsContent {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCWindow: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowLiningProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveLengthMeasure? _LiningDepth {get; }
		public IFCNormalisedRatioMeasure? _FirstTransomOffset {get; }
		public IFCNormalisedRatioMeasure? _SecondTransomOffset {get; }
		public IFCNormalisedRatioMeasure? _FirstMullionOffset {get; }
		public IFCNormalisedRatioMeasure? _SecondMullionOffset {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowPanelProperties: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFCWindowPanelOperationEnum? _OperationType {get; }
		public IFCWindowPanelPositionEnum? _PanelPosition {get; }
		public IFCPositiveLengthMeasure? _FrameDepth {get; }
		public IFCPositiveLengthMeasure? _FrameThickness {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowStyle: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCWindowStyleConstructionEnum? _ConstructionType {get; }
		public IFCWindowStyleOperationEnum? _OperationType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkControl: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_SET<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkPlan: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_SET<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkSchedule: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_SET<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCZShapeProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Depth {get; set;}
		public IFCPositiveLengthMeasure? _FlangeWidth {get; set;}
		public IFCPositiveLengthMeasure? _WebThickness {get; set;}
		public IFCPositiveLengthMeasure? _FlangeThickness {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCZone: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCActuator: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCActuatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAdvancedBrep: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAdvancedBrepWithVoids: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
		public IFC_SET<IFCClosedShell>? _Voids {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAdvancedFace: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_SET<IFCFaceBound>? _Bounds {get; }
		public IFC_SET<IFCTextureMap>? _HasTextureMaps {get; }
		public IFCSurface? _FaceSurface {get; }
		public IFCBoolean? _SameSense {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirTerminalBox: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirTerminalBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAirToAirHeatRecovery: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirToAirHeatRecoveryTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlarm: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCAlarmTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAudioVisualAppliance: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAudioVisualApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAudioVisualApplianceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAudioVisualApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineCurveWithKnots: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _Degree {get; }
		public IFC_LIST<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UpperIndexOnControlPoints {get; }
		public IFC_ARRAY<IFCCartesianPoint>? _ControlPoints {get; }
		public IFC_LIST<IFCInteger>? _KnotMultiplicities {get; }
		public IFC_LIST<IFCParameterValue>? _Knots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _UpperIndexOnKnots {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public IFC_LIST<IFC_LIST<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public IFC_ARRAY<IFC_ARRAY<IFCCartesianPoint>>? _ControlPoints {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBSplineSurfaceWithKnots: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public IFC_LIST<IFC_LIST<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public IFC_ARRAY<IFC_ARRAY<IFCCartesianPoint>>? _ControlPoints {get; }
		public IFC_LIST<IFCInteger>? _UMultiplicities {get; }
		public IFC_LIST<IFCInteger>? _VMultiplicities {get; }
		public IFC_LIST<IFCParameterValue>? _UKnots {get; }
		public IFC_LIST<IFCParameterValue>? _VKnots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _KnotVUpper {get; }
		public IFCInteger? _KnotUUpper {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBeamStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoiler: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCBoilerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBoundaryCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingElementPartType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBuildingElementPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuildingSystem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCBuildingSystemTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBurner: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCBurnerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBurnerType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBurnerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierFitting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableCarrierFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableCarrierSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableCarrierSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableFitting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableFittingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCableSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianPointList: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianPointList2D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFC_LIST<IFCLengthMeasure>>? _CoordList {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCartesianPointList3D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFC_LIST<IFCLengthMeasure>>? _CoordList {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCChiller: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCChillerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCChimney: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCChimneyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCChimneyType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCChimneyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCivilElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCivilElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoil: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCColourRgbList: IFC_Entity
	{
		public IFC_LIST<IFC_LIST<IFCNormalisedRatioMeasure>>? _ColourList {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCColumnStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCColumnTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCommunicationsAppliance: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCommunicationsApplianceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCComplexPropertyTemplate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public IFC_SET<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
		public IFCLabel? _UsageName {get; }
		public IFCComplexPropertyTemplateTypeEnum? _TemplateType {get; }
		public IFC_SET<IFCPropertyTemplate>? _HasPropertyTemplates {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCompositeCurveOnSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCompressor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCompressorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCondenser: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCondenserTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConnectionVolumeGeometry: IFC_Entity
	{
		public IFCSolidOrShell? _VolumeOnRelatingElement {get; set;}
		public IFCSolidOrShell? _VolumeOnRelatedElement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionEquipmentResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionEquipmentResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionMaterialResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionMaterialResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionProductResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionProductResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConstructionResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCContext: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public IFC_SET<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelDeclares>? _Declares {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCController: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCControllerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConversionBasedUnitWithOffset: IFC_Entity
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCMeasureWithUnit? _ConversionFactor {get; set;}
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public IFCReal? _ConversionOffset {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCooledBeam: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCooledBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoolingTower: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCoolingTowerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCoordinateOperation: IFC_Entity
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCCoordinateReferenceSystem: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public IFC_SET<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCrewResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCCrewResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveBoundedSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFC_SET<IFCBoundaryCurve>? _Boundaries {get; }
		public IFCBoolean? _ImplicitOuter {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCylindricalSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDamper: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionCircuit: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCLabel? _LongName {get; }
		public IFCDistributionSystemEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionSystem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCLabel? _LongName {get; }
		public IFCDistributionSystemEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
		public IFCDoorTypeEnum? _PredefinedType {get; }
		public IFCDoorTypeOperationEnum? _OperationType {get; }
		public IFCLabel? _UserDefinedOperationType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDoorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDoorTypeEnum? _PredefinedType {get; }
		public IFCDoorTypeOperationEnum? _OperationType {get; }
		public IFCBoolean? _ParameterTakesPrecedence {get; }
		public IFCLabel? _UserDefinedOperationType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctFitting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDuctSilencer: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctSilencerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricAppliance: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricDistributionBoard: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricDistributionBoardType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowStorageDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricFlowStorageDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricGenerator: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricGeneratorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricMotor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricMotorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricTimeControl: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricTimeControlTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElementAssemblyType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElementAssemblyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEngine: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEngineTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEngineType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEngineTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporativeCooler: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEvaporativeCoolerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEvaporator: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEvaporatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEvent: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFC_SET<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFC_SET<IFCRelSequence>? _IsSuccessorFrom {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCEventTypeEnum? _PredefinedType {get; }
		public IFCEventTriggerTypeEnum? _EventTriggerType {get; }
		public IFCLabel? _UserDefinedEventTriggerType {get; }
		public IFCEventTime? _EventOccurenceTime {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEventTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCDateTime? _ActualDate {get; set;}
		public IFCDateTime? _EarlyDate {get; set;}
		public IFCDateTime? _LateDate {get; set;}
		public IFCDateTime? _ScheduleDate {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCEventType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCEventTypeEnum? _PredefinedType {get; }
		public IFCEventTriggerTypeEnum? _EventTriggerType {get; }
		public IFCLabel? _UserDefinedEventTriggerType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCExtendedProperties: IFC_Entity
	{
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFCIdentifier? _Name {get; }
		public IFCText? _Description {get; }
		public IFC_SET<IFCProperty>? _Properties {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalInformation: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalReferenceRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCExternalReference? _RelatingReference {get; set;}
		public IFC_SET<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalSpatialElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCExternalSpatialElementTypeEnum? _PredefinedType {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCExternalSpatialStructureElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCExtrudedAreaSolidTapered: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCPositiveLengthMeasure? _Depth {get; }
		public IFCProfileDef? _EndSweptArea {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFan: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFanTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFilter: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFilterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFireSuppressionTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFireSuppressionTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFixedReferenceSweptAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCDirection? _FixedReference {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowInstrument: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCFlowInstrumentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFlowMeter: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFlowMeterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFootingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFootingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFurniture: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCFurnitureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeographicElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCGeographicElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeographicElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCGeographicElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHeatExchanger: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCHeatExchangerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCHumidifier: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCHumidifierTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedColourMap: IFC_Entity
	{
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCNormalisedRatioMeasure? _Opacity {get; set;}
		public IFCColourRgbList? _Colours {get; set;}
		public IFC_LIST<IFCPositiveInteger>? _ColourIndex {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedPolyCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPointList? _Points {get; }
		public IFC_LIST<IFCSegmentIndexSelect>? _Segments {get; }
		public IFCBoolean? _SelfIntersect {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedPolygonalFace: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCPositiveInteger>? _CoordIndex {get; }
		public IFC_SET<IFCPolygonalFaceSet>? _ToFaceSet {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedPolygonalFaceWithVoids: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCPositiveInteger>? _CoordIndex {get; }
		public IFC_SET<IFCPolygonalFaceSet>? _ToFaceSet {get; }
		public IFC_LIST<IFC_LIST<IFCPositiveInteger>>? _InnerCoordIndices {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedTextureMap: IFC_Entity
	{
		public IFC_LIST<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedTriangleTextureMap: IFC_Entity
	{
		public IFC_LIST<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
		public IFC_LIST<IFC_LIST<IFCPositiveInteger>>? _TexCoordIndex {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCInterceptor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCInterceptorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCInterceptorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCInterceptorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIntersectionCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public IFC_LIST<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCJunctionBox: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCJunctionBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLaborResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCLaborResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLagTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCTimeOrRatioSelect? _LagValue {get; set;}
		public IFCTaskDurationEnum? _DurationType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCLamp: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLightFixture: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLightFixtureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMapConversion: IFC_Entity
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
		public IFCLengthMeasure? _Eastings {get; set;}
		public IFCLengthMeasure? _Northings {get; set;}
		public IFCLengthMeasure? _OrthogonalHeight {get; set;}
		public IFCReal? _XAxisAbscissa {get; set;}
		public IFCReal? _XAxisOrdinate {get; set;}
		public IFCReal? _Scale {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialConstituent: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCNormalisedRatioMeasure? _Fraction {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialConstituentSet? _ToMaterialConstituentSet {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialConstituentSet: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFC_SET<IFCMaterialConstituent>? _MaterialConstituents {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialDefinition: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialLayerWithOffsets: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCMaterial? _Material {get; }
		public IFCNonNegativeLengthMeasure? _LayerThickness {get; }
		public IFCLogical? _IsVentilated {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCLabel? _Category {get; }
		public IFCInteger? _Priority {get; }
		public IFCMaterialLayerSet? _ToMaterialLayerSet {get; }
		public IFCLayerSetDirectionEnum? _OffsetDirection {get; }
		public IFC_ARRAY<IFCLengthMeasure>? _OffsetValues {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProfile: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCProfileDef? _Profile {get; }
		public IFCInteger? _Priority {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialProfileSet? _ToMaterialProfileSet {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProfileSet: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFC_LIST<IFCMaterialProfile>? _MaterialProfiles {get; }
		public IFCCompositeProfileDef? _CompositeProfile {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProfileSetUsage: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFCMaterialProfileSet? _ForProfileSet {get; }
		public IFCCardinalPointReference? _CardinalPoint {get; }
		public IFCPositiveLengthMeasure? _ReferenceExtent {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProfileSetUsageTapering: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFCMaterialProfileSet? _ForProfileSet {get; }
		public IFCCardinalPointReference? _CardinalPoint {get; }
		public IFCPositiveLengthMeasure? _ReferenceExtent {get; }
		public IFCMaterialProfileSet? _ForProfileEndSet {get; }
		public IFCCardinalPointReference? _CardinalEndPoint {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialProfileWithOffsets: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCProfileDef? _Profile {get; }
		public IFCInteger? _Priority {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialProfileSet? _ToMaterialProfileSet {get; }
		public IFC_ARRAY<IFCLengthMeasure>? _OffsetValues {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCMaterial? _RelatingMaterial {get; set;}
		public IFC_SET<IFCMaterial>? _RelatedMaterials {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMaterialUsageDefinition: IFC_Entity
	{
		public IFC_SET<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMedicalDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMedicalDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMedicalDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMedicalDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMemberStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCMemberTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMirroredProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public IFC_SET<IFCProfileProperties>? _HasProperties {get; }
		public IFCProfileDef? _ParentProfile {get; }
		public IFCCartesianTransformationOperator2D? _Operator {get; }
		public IFCLabel? _Label {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMotorConnection: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMotorConnectionTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOpeningStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCOpeningElementTypeEnum? _PredefinedType {get; }
		public IFC_SET<IFCRelFillsElement>? _HasFillings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOuterBoundaryCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOutlet: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCOutletTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPcurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCCurve? _ReferenceCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPileType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPileTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeFitting: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPipeFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPipeSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPipeSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPlateStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPlateTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPolygonalFaceSet: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCIndexedColourMap>? _HasColours {get; }
		public IFC_SET<IFCIndexedTextureMap>? _HasTextures {get; }
		public IFCBoolean? _Closed {get; }
		public IFC_LIST<IFCIndexedPolygonalFace>? _Faces {get; }
		public IFC_LIST<IFCPositiveInteger>? _PnIndex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedProperties: IFC_Entity
	{
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPreDefinedPropertySet: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFC_SET<IFCRelDefinesByTemplate>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _DefinesOccurrence {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPresentationItem: IFC_Entity
	{
	}
	/// <summary>
	/// </summary>
	public interface IFCProcedureType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCProcedureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectLibrary: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public IFC_SET<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelDeclares>? _Declares {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProjectedCRS: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public IFCIdentifier? _VerticalDatum {get; set;}
		public IFC_SET<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
		public IFCIdentifier? _MapProjection {get; }
		public IFCIdentifier? _MapZone {get; }
		public IFCNamedUnit? _MapUnit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyAbstraction: IFC_Entity
	{
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertySetTemplate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCPropertySetTemplateTypeEnum? _TemplateType {get; }
		public IFCIdentifier? _ApplicableEntity {get; }
		public IFC_SET<IFCPropertyTemplate>? _HasPropertyTemplates {get; }
		public IFC_SET<IFCRelDefinesByTemplate>? _Defines {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyTemplate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public IFC_SET<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPropertyTemplateDefinition: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCProtectiveDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDeviceTrippingUnit: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCProtectiveDeviceTrippingUnitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCProtectiveDeviceTrippingUnitType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCProtectiveDeviceTrippingUnitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPump: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPumpTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantitySet: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCTypeObject>? _DefinesType {get; }
		public IFC_SET<IFCRelDefinesByTemplate>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _DefinesOccurrence {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRampType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRationalBSplineCurveWithKnots: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _Degree {get; }
		public IFC_LIST<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UpperIndexOnControlPoints {get; }
		public IFC_ARRAY<IFCCartesianPoint>? _ControlPoints {get; }
		public IFC_LIST<IFCInteger>? _KnotMultiplicities {get; }
		public IFC_LIST<IFCParameterValue>? _Knots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _UpperIndexOnKnots {get; }
		public IFC_LIST<IFCReal>? _WeightsData {get; }
		public IFC_ARRAY<IFCReal>? _Weights {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRationalBSplineSurfaceWithKnots: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public IFC_LIST<IFC_LIST<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public IFC_ARRAY<IFC_ARRAY<IFCCartesianPoint>>? _ControlPoints {get; }
		public IFC_LIST<IFCInteger>? _UMultiplicities {get; }
		public IFC_LIST<IFCInteger>? _VMultiplicities {get; }
		public IFC_LIST<IFCParameterValue>? _UKnots {get; }
		public IFC_LIST<IFCParameterValue>? _VKnots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _KnotVUpper {get; }
		public IFCInteger? _KnotUUpper {get; }
		public IFC_LIST<IFC_LIST<IFCReal>>? _WeightsData {get; }
		public IFC_ARRAY<IFC_ARRAY<IFCReal>>? _Weights {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRecurrencePattern: IFC_Entity
	{
		public IFCRecurrenceTypeEnum? _RecurrenceType {get; set;}
		public IFC_SET<IFCDayInMonthNumber>? _DayComponent {get; set;}
		public IFC_SET<IFCDayInWeekNumber>? _WeekdayComponent {get; set;}
		public IFC_SET<IFCMonthInYearNumber>? _MonthComponent {get; set;}
		public IFCInteger? _Position {get; set;}
		public IFCInteger? _Interval {get; set;}
		public IFCInteger? _Occurrences {get; set;}
		public IFC_LIST<IFCTimePeriod>? _TimePeriods {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReference: IFC_Entity
	{
		public IFCIdentifier? _TypeIdentifier {get; set;}
		public IFCIdentifier? _AttributeIdentifier {get; set;}
		public IFCLabel? _InstanceName {get; set;}
		public IFC_LIST<IFCInteger>? _ListPositions {get; set;}
		public IFCReference? _InnerReference {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingBarType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCReinforcingBarTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _BarLength {get; }
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; }
		public IFCLabel? _BendingShapeCode {get; }
		public IFC_LIST<IFCBendingParameterSelect>? _BendingParameters {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcingMeshType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCReinforcingMeshTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _MeshLength {get; }
		public IFCPositiveLengthMeasure? _MeshWidth {get; }
		public IFCPositiveLengthMeasure? _LongitudinalBarNominalDiameter {get; }
		public IFCPositiveLengthMeasure? _TransverseBarNominalDiameter {get; }
		public IFCAreaMeasure? _LongitudinalBarCrossSectionArea {get; }
		public IFCAreaMeasure? _TransverseBarCrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _LongitudinalBarSpacing {get; }
		public IFCPositiveLengthMeasure? _TransverseBarSpacing {get; }
		public IFCLabel? _BendingShapeCode {get; }
		public IFC_LIST<IFCBendingParameterSelect>? _BendingParameters {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssignsToGroupByFactor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCGroup? _RelatingGroup {get; set;}
		public IFCRatioMeasure? _Factor {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDeclares: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCContext? _RelatingContext {get; set;}
		public IFC_SET<IFCDefinitionSelect>? _RelatedDefinitions {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDefinesByObject: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCObject>? _RelatedObjects {get; set;}
		public IFCObject? _RelatingObject {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelDefinesByTemplate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCPropertySetDefinition>? _RelatedPropertySets {get; set;}
		public IFCPropertySetTemplate? _RelatingTemplate {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelInterferesElements: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _InterferenceGeometry {get; set;}
		public IFCIdentifier? _InterferenceType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelSpaceBoundary1stLevel: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCSpaceBoundarySelect? _RelatingSpace {get; set;}
		public IFCElement? _RelatedBuildingElement {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCPhysicalOrVirtualEnum? _PhysicalOrVirtualBoundary {get; set;}
		public IFCInternalOrExternalEnum? _InternalOrExternalBoundary {get; set;}
		public IFCRelSpaceBoundary1stLevel? _ParentBoundary {get; set;}
		public IFC_SET<IFCRelSpaceBoundary1stLevel>? _InnerBoundaries {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRelSpaceBoundary2ndLevel: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCSpaceBoundarySelect? _RelatingSpace {get; set;}
		public IFCElement? _RelatedBuildingElement {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCPhysicalOrVirtualEnum? _PhysicalOrVirtualBoundary {get; set;}
		public IFCInternalOrExternalEnum? _InternalOrExternalBoundary {get; set;}
		public IFCRelSpaceBoundary1stLevel? _ParentBoundary {get; set;}
		public IFC_SET<IFCRelSpaceBoundary1stLevel>? _InnerBoundaries {get; }
		public IFCRelSpaceBoundary2ndLevel? _CorrespondingBoundary {get; }
		public IFC_SET<IFCRelSpaceBoundary2ndLevel>? _Corresponds {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReparametrisedCompositeCurveSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCBoolean? _SameSense {get; }
		public IFCCurve? _ParentCurve {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCCompositeCurve>? _UsingCurves {get; }
		public IFCParameterValue? _ParamLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceApprovalRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
		public IFCApproval? _RelatingApproval {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceConstraintRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public IFC_SET<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceLevelRelationship: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCResourceTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCDuration? _ScheduleWork {get; set;}
		public IFCPositiveRatioMeasure? _ScheduleUsage {get; set;}
		public IFCDateTime? _ScheduleStart {get; set;}
		public IFCDateTime? _ScheduleFinish {get; set;}
		public IFCLabel? _ScheduleContour {get; set;}
		public IFCDuration? _LevelingDelay {get; set;}
		public IFCBoolean? _IsOverAllocated {get; set;}
		public IFCDateTime? _StatusTime {get; set;}
		public IFCDuration? _ActualWork {get; set;}
		public IFCPositiveRatioMeasure? _ActualUsage {get; set;}
		public IFCDateTime? _ActualStart {get; set;}
		public IFCDateTime? _ActualFinish {get; set;}
		public IFCDuration? _RemainingWork {get; set;}
		public IFCPositiveRatioMeasure? _RemainingUsage {get; set;}
		public IFCPositiveRatioMeasure? _Completion {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRevolvedAreaSolidTapered: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCAxis1Placement? _Axis {get; }
		public IFCPlaneAngleMeasure? _Angle {get; }
		public IFCLine? _AxisLine {get; }
		public IFCProfileDef? _EndSweptArea {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRoofType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRoofTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSanitaryTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSanitaryTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSchedulingTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSeamCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public IFC_LIST<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSensor: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCSensorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCShadingDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCShadingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCShadingDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCShadingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSimplePropertyTemplate: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFC_SET<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public IFC_SET<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
		public IFCSimplePropertyTemplateTypeEnum? _TemplateType {get; }
		public IFCLabel? _PrimaryMeasureType {get; }
		public IFCLabel? _SecondaryMeasureType {get; }
		public IFCPropertyEnumeration? _Enumerators {get; }
		public IFCUnit? _PrimaryUnit {get; }
		public IFCUnit? _SecondaryUnit {get; }
		public IFCLabel? _Expression {get; }
		public IFCStateEnum? _AccessState {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSlabElementedCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSlabStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSolarDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSolarDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSolarDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSolarDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpaceHeater: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSpaceHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialZone: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCSpatialZoneTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpatialZoneType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpatialZoneTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSphericalSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStackTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCStackTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStairType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStairTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCBoolean? _DestabilizingLoad {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCStructuralCurveActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralCurveReaction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCStructuralCurveActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFCLoadGroupTypeEnum? _PredefinedType {get; }
		public IFCActionTypeEnum? _ActionType {get; }
		public IFCActionSourceTypeEnum? _ActionSource {get; }
		public IFCRatioMeasure? _Coefficient {get; }
		public IFCLabel? _Purpose {get; }
		public IFC_SET<IFCStructuralResultGroup>? _SourceOfResultGroup {get; }
		public IFC_SET<IFCStructuralAnalysisModel>? _LoadGroupFor {get; }
		public IFC_LIST<IFCRatioMeasure>? _SelfWeightCoefficients {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadConfiguration: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_LIST<IFCStructuralLoadOrResult>? _Values {get; set;}
		public IFC_LIST<IFC_LIST<IFCLengthMeasure>>? _Locations {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralLoadOrResult: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceAction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCBoolean? _DestabilizingLoad {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCStructuralSurfaceActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCStructuralSurfaceReaction: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFC_SET<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCStructuralSurfaceActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSubContractResourceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
		public IFC_LIST<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCSubContractResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public IFC_LIST<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public IFC_SET<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceFeature: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSurfaceFeatureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSurfaceReinforcementArea: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFC_LIST<IFCLengthMeasure>? _SurfaceReinforcement1 {get; set;}
		public IFC_LIST<IFCLengthMeasure>? _SurfaceReinforcement2 {get; set;}
		public IFCRatioMeasure? _ShearReinforcement {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCSweptDiskSolidPolygonal: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCPositiveLengthMeasure? _InnerRadius {get; }
		public IFCParameterValue? _StartParam {get; }
		public IFCParameterValue? _EndParam {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSwitchingDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSwitchingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSystemFurnitureElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSystemFurnitureElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTableColumn: IFC_Entity
	{
		public IFCIdentifier? _Identifier {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCUnit? _Unit {get; set;}
		public IFCReference? _ReferencePath {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTank: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTankTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTaskTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCTaskDurationEnum? _DurationType {get; set;}
		public IFCDuration? _ScheduleDuration {get; set;}
		public IFCDateTime? _ScheduleStart {get; set;}
		public IFCDateTime? _ScheduleFinish {get; set;}
		public IFCDateTime? _EarlyStart {get; set;}
		public IFCDateTime? _EarlyFinish {get; set;}
		public IFCDateTime? _LateStart {get; set;}
		public IFCDateTime? _LateFinish {get; set;}
		public IFCDuration? _FreeFloat {get; set;}
		public IFCDuration? _TotalFloat {get; set;}
		public IFCBoolean? _IsCritical {get; set;}
		public IFCDateTime? _StatusTime {get; set;}
		public IFCDuration? _ActualDuration {get; set;}
		public IFCDateTime? _ActualStart {get; set;}
		public IFCDateTime? _ActualFinish {get; set;}
		public IFCDuration? _RemainingTime {get; set;}
		public IFCPositiveRatioMeasure? _Completion {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTaskTimeRecurring: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCTaskDurationEnum? _DurationType {get; set;}
		public IFCDuration? _ScheduleDuration {get; set;}
		public IFCDateTime? _ScheduleStart {get; set;}
		public IFCDateTime? _ScheduleFinish {get; set;}
		public IFCDateTime? _EarlyStart {get; set;}
		public IFCDateTime? _EarlyFinish {get; set;}
		public IFCDateTime? _LateStart {get; set;}
		public IFCDateTime? _LateFinish {get; set;}
		public IFCDuration? _FreeFloat {get; set;}
		public IFCDuration? _TotalFloat {get; set;}
		public IFCBoolean? _IsCritical {get; set;}
		public IFCDateTime? _StatusTime {get; set;}
		public IFCDuration? _ActualDuration {get; set;}
		public IFCDateTime? _ActualStart {get; set;}
		public IFCDateTime? _ActualFinish {get; set;}
		public IFCDuration? _RemainingTime {get; set;}
		public IFCPositiveRatioMeasure? _Completion {get; set;}
		public IFCRecurrencePattern? _Recurrence {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTaskType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCTaskTypeEnum? _PredefinedType {get; }
		public IFCLabel? _WorkMethod {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonAnchorType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonAnchorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _SheathDiameter {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTessellatedFaceSet: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCIndexedColourMap>? _HasColours {get; }
		public IFC_SET<IFCIndexedTextureMap>? _HasTextures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTessellatedItem: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureVertexList: IFC_Entity
	{
		public IFC_LIST<IFC_LIST<IFCParameterValue>>? _TexCoordsList {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTimePeriod: IFC_Entity
	{
		public IFCTime? _StartTime {get; set;}
		public IFCTime? _EndTime {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCToroidalSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _MajorRadius {get; }
		public IFCPositiveLengthMeasure? _MinorRadius {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransformer: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTransformerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTriangulatedFaceSet: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCIndexedColourMap>? _HasColours {get; }
		public IFC_SET<IFCIndexedTextureMap>? _HasTextures {get; }
		public IFC_LIST<IFC_LIST<IFCParameterValue>>? _Normals {get; }
		public IFCBoolean? _Closed {get; }
		public IFC_LIST<IFC_LIST<IFCPositiveInteger>>? _CoordIndex {get; }
		public IFC_LIST<IFCPositiveInteger>? _PnIndex {get; }
		public IFCInteger? _NumberOfTriangles {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTubeBundle: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTubeBundleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTypeProcess: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public IFC_SET<IFCRelAssignsToProcess>? _OperatesOn {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTypeResource: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public IFC_SET<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryControlElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCUnitaryControlElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryControlElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCUnitaryControlElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCUnitaryEquipment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCUnitaryEquipmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCValve: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCValveTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationIsolator: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCVibrationIsolatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVoidingFeature: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCVoidingFeatureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWallElementedCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWasteTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCWasteTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowStandardCase: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
		public IFCWindowTypeEnum? _PredefinedType {get; }
		public IFCWindowTypePartitioningEnum? _PartitioningType {get; }
		public IFCLabel? _UserDefinedPartitioningType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWindowType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWindowTypeEnum? _PredefinedType {get; }
		public IFCWindowTypePartitioningEnum? _PartitioningType {get; }
		public IFCBoolean? _ParameterTakesPrecedence {get; }
		public IFCLabel? _UserDefinedPartitioningType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkCalendar: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCIdentifier? _Identification {get; }
		public IFC_SET<IFCRelAssignsToControl>? _Controls {get; }
		public IFC_SET<IFCWorkTime>? _WorkingTimes {get; }
		public IFC_SET<IFCWorkTime>? _ExceptionTimes {get; }
		public IFCWorkCalendarTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWorkTime: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCRecurrencePattern? _RecurrencePattern {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCAlignmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DHorizontal: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFC_LIST<IFCAlignment2DHorizontalSegment>? _Segments {get; }
		public IFC_SET<IFCAlignmentCurve>? _ToAlignmentCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DHorizontalSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCCurveSegment2D? _CurveGeometry {get; }
		public IFC_SET<IFCAlignment2DHorizontal>? _ToHorizontal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DVerSegCircularArc: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public IFC_SET<IFCAlignment2DVertical>? _ToVertical {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCBoolean? _IsConvex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DVerSegLine: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public IFC_SET<IFCAlignment2DVertical>? _ToVertical {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DVerSegParabolicArc: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public IFC_SET<IFCAlignment2DVertical>? _ToVertical {get; }
		public IFCPositiveLengthMeasure? _ParabolaConstant {get; }
		public IFCBoolean? _IsConvex {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DVertical: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFC_LIST<IFCAlignment2DVerticalSegment>? _Segments {get; }
		public IFC_SET<IFCAlignmentCurve>? _ToAlignmentCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignment2DVerticalSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public IFC_SET<IFCAlignment2DVertical>? _ToVertical {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAlignment2DHorizontal? _Horizontal {get; }
		public IFCAlignment2DVertical? _Vertical {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCircularArcSegment2D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCBoolean? _IsCCW {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveSegment2D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistanceExpression: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _DistanceAlong {get; }
		public IFCLengthMeasure? _OffsetLateral {get; }
		public IFCLengthMeasure? _OffsetVertical {get; }
		public IFCLengthMeasure? _OffsetLongitudinal {get; }
		public IFCBoolean? _AlongHorizontal {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLineSegment2D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearPlacement: IFC_Entity
	{
		public IFC_SET<IFCProduct>? _PlacesObject {get; }
		public IFCAxis2Placement3D? _CartesianPosition {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearPositioningElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOffsetCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOffsetCurveByDistances: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOrientationExpression: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _LateralAxisDirection {get; }
		public IFCDirection? _VerticalAxisDirection {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPositioningElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReferent: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCReferentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionedSolid: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFC_LIST<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionedSolidHorizontal: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFC_LIST<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransitionCurveSegment2D: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
		public IFCPositiveLengthMeasure? _StartRadius {get; }
		public IFCPositiveLengthMeasure? _EndRadius {get; }
		public IFCBoolean? _IsStartRadiusCCW {get; }
		public IFCBoolean? _IsEndRadiusCCW {get; }
		public IFCTransitionCurveType? _TransitionCurveType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTriangulatedIrregularNetwork: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCIndexedColourMap>? _HasColours {get; }
		public IFC_SET<IFCIndexedTextureMap>? _HasTextures {get; }
		public IFC_LIST<IFC_LIST<IFCParameterValue>>? _Normals {get; }
		public IFCBoolean? _Closed {get; }
		public IFC_LIST<IFC_LIST<IFCPositiveInteger>>? _CoordIndex {get; }
		public IFC_LIST<IFCPositiveInteger>? _PnIndex {get; }
		public IFCInteger? _NumberOfTriangles {get; }
		public IFC_LIST<IFCInteger>? _Flags {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBearing: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCBearingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBearingType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBearingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBridge: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCBridgeTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBridgePart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCBridgePartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCaissonFoundation: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCCaissonFoundationTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCaissonFoundationType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCaissonFoundationTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDeepFoundation: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDeepFoundationType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFacility: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFacilityPart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRelPositions: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCPositioningElement? _RelatingPositioningElement {get; set;}
		public IFC_SET<IFCProduct>? _RelatedProducts {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonConduit: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCTendonConduitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTendonConduitType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonConduitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationDamper: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCVibrationDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVibrationDamperType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVibrationDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentCant: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCPositiveLengthMeasure? _RailHeadDistance {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentCantSegment: IFC_Entity
	{
		public IFCLabel? _StartTag {get; set;}
		public IFCLabel? _EndTag {get; set;}
		public IFCLengthMeasure? _StartDistAlong {get; set;}
		public IFCNonNegativeLengthMeasure? _HorizontalLength {get; set;}
		public IFCLengthMeasure? _StartCantLeft {get; set;}
		public IFCLengthMeasure? _EndCantLeft {get; set;}
		public IFCLengthMeasure? _StartCantRight {get; set;}
		public IFCLengthMeasure? _EndCantRight {get; set;}
		public IFCAlignmentCantSegmentTypeEnum? _PredefinedType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentHorizontal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentHorizontalSegment: IFC_Entity
	{
		public IFCLabel? _StartTag {get; set;}
		public IFCLabel? _EndTag {get; set;}
		public IFCCartesianPoint? _StartPoint {get; set;}
		public IFCPlaneAngleMeasure? _StartDirection {get; set;}
		public IFCLengthMeasure? _StartRadiusOfCurvature {get; set;}
		public IFCLengthMeasure? _EndRadiusOfCurvature {get; set;}
		public IFCNonNegativeLengthMeasure? _SegmentLength {get; set;}
		public IFCPositiveLengthMeasure? _GravityCenterLineHeight {get; set;}
		public IFCAlignmentHorizontalSegmentTypeEnum? _PredefinedType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentParameterSegment: IFC_Entity
	{
		public IFCLabel? _StartTag {get; set;}
		public IFCLabel? _EndTag {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCAlignmentParameterSegment? _DesignParameters {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentVertical: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCAlignmentVerticalSegment: IFC_Entity
	{
		public IFCLabel? _StartTag {get; set;}
		public IFCLabel? _EndTag {get; set;}
		public IFCLengthMeasure? _StartDistAlong {get; set;}
		public IFCNonNegativeLengthMeasure? _HorizontalLength {get; set;}
		public IFCLengthMeasure? _StartHeight {get; set;}
		public IFCRatioMeasure? _StartGradient {get; set;}
		public IFCRatioMeasure? _EndGradient {get; set;}
		public IFCLengthMeasure? _RadiusOfCurvature {get; set;}
		public IFCAlignmentVerticalSegmentTypeEnum? _PredefinedType {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCAxis2PlacementLinear: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCPoint? _Location {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _RefDirection {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBorehole: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuiltElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuiltElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCBuiltSystem: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFC_SET<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ServicesFacilities {get; }
		public IFCBuiltSystemTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCClothoid: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _ClothoidConstant {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConveyorSegment: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCConveyorSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCConveyorSegmentType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCConveyorSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCosineSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _CosineTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCourse: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCCourseTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCourseType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCourseTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCCurveSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCCompositeCurve>? _UsingCurves {get; }
		public IFCPlacement? _Placement {get; }
		public IFCCurveMeasureSelect? _SegmentStart {get; }
		public IFCCurveMeasureSelect? _SegmentLength {get; }
		public IFCCurve? _ParentCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDirectrixCurveSweptAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCCurveMeasureSelect? _StartParam {get; }
		public IFCCurveMeasureSelect? _EndParam {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDirectrixDerivedReferenceSweptAreaSolid: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCCurveMeasureSelect? _StartParam {get; }
		public IFCCurveMeasureSelect? _EndParam {get; }
		public IFCDirection? _FixedReference {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionBoard: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCDistributionBoardType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEarthworksCut: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCEarthworksCutTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEarthworksElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCEarthworksFill: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCEarthworksFillTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowTreatmentDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricFlowTreatmentDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCElectricFlowTreatmentDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricFlowTreatmentDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCFacilityPartCommon: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCFacilityPartCommonTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeographicCRS: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public IFC_SET<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
		public IFC_SET<IFCWellKnownText>? _WellKnownText {get; }
		public IFCIdentifier? _PrimeMeridian {get; }
		public IFCNamedUnit? _AngleUnit {get; }
		public IFCNamedUnit? _HeightUnit {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeomodel: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeoslice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeotechnicalAssembly: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeotechnicalElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGeotechnicalStratum: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCGeotechnicalStratumTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCGradientCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCSegment>? _Segments {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCBoundedCurve? _BaseCurve {get; }
		public IFCPlacement? _EndPoint {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCImpactProtectionDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCImpactProtectionDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCImpactProtectionDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCImpactProtectionDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCIndexedPolygonalTextureMap: IFC_Entity
	{
		public IFC_LIST<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
		public IFC_SET<IFCTextureCoordinateIndices>? _TexCoordIndices {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCKerb: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCKerbTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCKerbType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCKerbTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLinearElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLiquidTerminal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLiquidTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCLiquidTerminalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLiquidTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMapConversionScaled: IFC_Entity
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
		public IFCLengthMeasure? _Eastings {get; set;}
		public IFCLengthMeasure? _Northings {get; set;}
		public IFCLengthMeasure? _OrthogonalHeight {get; set;}
		public IFCReal? _XAxisAbscissa {get; set;}
		public IFCReal? _XAxisOrdinate {get; set;}
		public IFCReal? _Scale {get; set;}
		public IFCReal? _FactorX {get; set;}
		public IFCReal? _FactorY {get; set;}
		public IFCReal? _FactorZ {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCMarineFacility: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCMarineFacilityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMarinePart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCMarinePartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMobileTelecommunicationsAppliance: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMobileTelecommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMobileTelecommunicationsApplianceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMobileTelecommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMooringDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCMooringDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCMooringDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMooringDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCNavigationElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCNavigationElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCNavigationElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCNavigationElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCOpenCrossProfileDef: IFC_Entity
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public IFC_SET<IFCProfileProperties>? _HasProperties {get; }
		public IFCBoolean? _HorizontalWidths {get; }
		public IFC_LIST<IFCNonNegativeLengthMeasure>? _Widths {get; }
		public IFC_LIST<IFCPlaneAngleMeasure>? _Slopes {get; }
		public IFC_LIST<IFCLabel>? _Tags {get; }
		public IFCCartesianPoint? _OffsetPoint {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPavement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCPavementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPavementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPavementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPointByDistanceExpression: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurveMeasureSelect? _DistanceAlong {get; }
		public IFCLengthMeasure? _OffsetLateral {get; }
		public IFCLengthMeasure? _OffsetVertical {get; }
		public IFCLengthMeasure? _OffsetLongitudinal {get; }
		public IFCCurve? _BasisCurve {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCPolynomialCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPlacement? _Position {get; }
		public IFC_LIST<IFCReal>? _CoefficientsX {get; }
		public IFC_LIST<IFCReal>? _CoefficientsY {get; }
		public IFC_LIST<IFCReal>? _CoefficientsZ {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCQuantityNumber: IFC_Entity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFC_SET<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCNumericMeasure? _NumberValue {get; }
		public IFCLabel? _Formula {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRail: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCRailTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRailType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRailTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRailway: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCRailwayTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRailwayPart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCRailwayPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCReinforcedSoil: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCReinforcedSoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAdheresToElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFC_SET<IFCSurfaceFeature>? _RelatedSurfaceFeatures {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRelAssociatesProfileDef: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCDefinitionSelect>? _RelatedObjects {get; set;}
		public IFCProfileDef? _RelatingProfileDef {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRigidOperation: IFC_Entity
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
		public IFCMeasureValue? _FirstCoordinate {get; set;}
		public IFCMeasureValue? _SecondCoordinate {get; set;}
		public IFCLengthMeasure? _Height {get; set;}
	}
	/// <summary>
	/// </summary>
	public interface IFCRoad: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCRoadTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCRoadPart: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFC_SET<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCRoadPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSecondOrderPolynomialSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _QuadraticTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSectionedSurface: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFC_LIST<IFCAxis2PlacementLinear>? _CrossSectionPositions {get; }
		public IFC_LIST<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSegment: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_SET<IFCCompositeCurve>? _UsingCurves {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSegmentedReferenceCurve: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFC_LIST<IFCSegment>? _Segments {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCBoundedCurve? _BaseCurve {get; }
		public IFCPlacement? _EndPoint {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSeventhOrderPolynomialSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _SepticTerm {get; }
		public IFCLengthMeasure? _SexticTerm {get; }
		public IFCLengthMeasure? _QuinticTerm {get; }
		public IFCLengthMeasure? _QuarticTerm {get; }
		public IFCLengthMeasure? _CubicTerm {get; }
		public IFCLengthMeasure? _QuadraticTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSign: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCSignTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSignType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSignTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSignal: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFC_SET<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public IFC_SET<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSignalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSignalType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSignalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSineSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _SineTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureCoordinateIndices: IFC_Entity
	{
		public IFC_LIST<IFCPositiveInteger>? _TexCoordIndex {get; set;}
		public IFCIndexedPolygonalFace? _TexCoordsOf {get; set;}
		public IFCIndexedPolygonalTextureMap? _ToTexMap {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTextureCoordinateIndicesWithVoids: IFC_Entity
	{
		public IFC_LIST<IFCPositiveInteger>? _TexCoordIndex {get; set;}
		public IFCIndexedPolygonalFace? _TexCoordsOf {get; set;}
		public IFCIndexedPolygonalTextureMap? _ToTexMap {get; }
		public IFC_LIST<IFC_LIST<IFCPositiveInteger>>? _InnerTexCoordIndices {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCThirdOrderPolynomialSpiral: IFC_Entity
	{
		public IFC_SET<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public IFC_SET<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _CubicTerm {get; }
		public IFCLengthMeasure? _QuadraticTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTrackElement: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCTrackElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTrackElementType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTrackElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransportationDevice: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCTransportationDeviceType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVehicle: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFC_SET<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public IFC_SET<IFCRelDefinesByObject>? _Declares {get; }
		public IFC_SET<IFCRelDefinesByType>? _IsTypedBy {get; }
		public IFC_SET<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFC_SET<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFC_SET<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public IFC_SET<IFCRelFillsElement>? _FillsVoids {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedTo {get; }
		public IFC_SET<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public IFC_SET<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFC_SET<IFCRelProjectsElement>? _HasProjections {get; }
		public IFC_SET<IFCRelVoidsElement>? _HasOpenings {get; }
		public IFC_SET<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public IFC_SET<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public IFC_SET<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public IFC_SET<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFC_SET<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFC_SET<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCVehicleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCVehicleType: IFC_Entity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFC_SET<IFCRelAssigns>? _HasAssignments {get; }
		public IFC_SET<IFCRelNests>? _Nests {get; }
		public IFC_SET<IFCRelNests>? _IsNestedBy {get; }
		public IFC_SET<IFCRelDeclares>? _HasContext {get; }
		public IFC_SET<IFCRelAggregates>? _IsDecomposedBy {get; }
		public IFC_SET<IFCRelAggregates>? _Decomposes {get; }
		public IFC_SET<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public IFC_SET<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public IFC_SET<IFCRelDefinesByType>? _Types {get; }
		public IFC_LIST<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFC_SET<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVehicleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// </summary>
	public interface IFCWellKnownText: IFC_Entity
	{
		public IFCWellKnownTextLiteral? _WellKnownText {get; set;}
		public IFCCoordinateReferenceSystem? _CoordinateReferenceSystem {get; set;}
	}
	#endregion

	#region ---- ENTITIES ----
	#endregion
}
