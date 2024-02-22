using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC.Global
{
	public abstract class IFC_Function : IFC_Entity
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCAbsorbedDoseMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAccelerationMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAmountOfSubstanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAngularVelocityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAreaMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoolean
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoxAlignment
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCContextDependentMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCountMeasure
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCCurvatureMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDayInMonthNumber
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDaylightSavingHour
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDescriptiveMeasure
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionCount
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDoseEquivalentMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDynamicViscosityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricCapacitanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricChargeMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricConductanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricCurrentMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricResistanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricVoltageMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCEnergyMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFontStyle
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFontVariant
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFontWeight
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCForceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFrequencyMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCGloballyUniqueId
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCHeatFluxDensityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCHeatingValueMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCHourInDay
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIdentifier
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIlluminanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCInductanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCInteger
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIntegerCountRateMeasure
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIonConcentrationMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIsothermalMoistureCapacityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCKinematicViscosityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLabel
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLengthMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearForceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearMomentMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearStiffnessMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearVelocityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLogical
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLuminousFluxMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLuminousIntensityDistributionMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLuminousIntensityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMagneticFluxDensityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMagneticFluxMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMassDensityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMassFlowRateMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMassMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMassPerLengthMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMinuteInHour
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfElasticityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfLinearSubgradeReactionMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfRotationalSubgradeReactionMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfSubgradeReactionMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMoistureDiffusivityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMolecularWeightMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMomentOfInertiaMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMonetaryMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMonthInYearNumber
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCNormalisedRatioMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCNumericMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPHMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCParameterValue
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPlanarForceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPlaneAngleMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPositiveLengthMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPositivePlaneAngleMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPositiveRatioMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPowerMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentableText
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPressureMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRadioActivityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRatioMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReal
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRotationalFrequencyMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRotationalMassMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRotationalStiffnessMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSecondInMinute
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionModulusMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionalAreaIntegralMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCShearModulusMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSolidAngleMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundPowerMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundPressureMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSpecificHeatCapacityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSpecularExponent
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSpecularRoughness
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTemperatureGradientMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCText
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextAlignment
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextDecoration
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextFontName
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextTransformation
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalAdmittanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalConductivityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalExpansionCoefficientMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalResistanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalTransmittanceMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermodynamicTemperatureMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeStamp
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTorqueMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCVaporPermeabilityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCVolumeMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCVolumetricFlowRateMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWarpingConstantMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWarpingMomentMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCYearNumber
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAreaDensityMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBinary
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCardinalPointReference
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDate
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDateTime
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDayInWeekNumber
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDuration
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLanguageId
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCNonNegativeLengthMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPositiveInteger
	{
		public int Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundPowerLevelMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundPressureLevelMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTemperatureRateOfChangeMeasure
	{
		public double Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTime
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCURIReference
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStrippedOptional
	{
		public bool Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWellKnownTextLiteral
	{
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCComplexNumber
	{
		public List<double> Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCompoundPlaneAngleMeasure
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCArcIndex
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLineIndex
	{
		public List<int> Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySetDefinitionSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCActionSourceTypeEnum
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
	/// <summary>
	public interface IFCActionTypeEnum
	{
		public static string? PERMANENT_G {get; set;}
		public static string? VARIABLE_Q {get; set;}
		public static string? EXTRAORDINARY_A {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCActuatorTypeEnum
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
	/// <summary>
	public interface IFCAddressTypeEnum
	{
		public static string? OFFICE {get; set;}
		public static string? SITE {get; set;}
		public static string? HOME {get; set;}
		public static string? DISTRIBUTIONPOINT {get; set;}
		public static string? USERDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAheadOrBehind
	{
		public static string? AHEAD {get; set;}
		public static string? BEHIND {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminalBoxTypeEnum
	{
		public static string? CONSTANTFLOW {get; set;}
		public static string? VARIABLEFLOWPRESSUREDEPENDANT {get; set;}
		public static string? VARIABLEFLOWPRESSUREINDEPENDANT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminalTypeEnum
	{
		public static string? GRILLE {get; set;}
		public static string? REGISTER {get; set;}
		public static string? DIFFUSER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAirToAirHeatRecoveryTypeEnum
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
	/// <summary>
	public interface IFCAlarmTypeEnum
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
	/// <summary>
	public interface IFCAnalysisModelTypeEnum
	{
		public static string? IN_PLANE_LOADING_2D {get; set;}
		public static string? OUT_PLANE_LOADING_2D {get; set;}
		public static string? LOADING_3D {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAnalysisTheoryTypeEnum
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
	/// <summary>
	public interface IFCArithmeticOperatorEnum
	{
		public static string? ADD {get; set;}
		public static string? DIVIDE {get; set;}
		public static string? MULTIPLY {get; set;}
		public static string? SUBTRACT {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAssemblyPlaceEnum
	{
		public static string? SITE {get; set;}
		public static string? FACTORY {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBSplineCurveForm
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
	/// <summary>
	public interface IFCBeamTypeEnum
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
	/// <summary>
	public interface IFCBenchmarkEnum
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
	/// <summary>
	public interface IFCBoilerTypeEnum
	{
		public static string? WATER {get; set;}
		public static string? STEAM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBooleanOperator
	{
		public static string? UNION {get; set;}
		public static string? INTERSECTION {get; set;}
		public static string? DIFFERENCE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementProxyTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCableCarrierFittingTypeEnum
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
	/// <summary>
	public interface IFCCableCarrierSegmentTypeEnum
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
	/// <summary>
	public interface IFCCableSegmentTypeEnum
	{
		public static string? CABLESEGMENT {get; set;}
		public static string? CONDUCTORSEGMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCChangeActionEnum
	{
		public static string? NOCHANGE {get; set;}
		public static string? MODIFIED {get; set;}
		public static string? ADDED {get; set;}
		public static string? DELETED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCChillerTypeEnum
	{
		public static string? AIRCOOLED {get; set;}
		public static string? WATERCOOLED {get; set;}
		public static string? HEATRECOVERY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCoilTypeEnum
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
	/// <summary>
	public interface IFCColumnTypeEnum
	{
		public static string? COLUMN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCompressorTypeEnum
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
	/// <summary>
	public interface IFCCondenserTypeEnum
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
	/// <summary>
	public interface IFCConnectionTypeEnum
	{
		public static string? ATPATH {get; set;}
		public static string? ATSTART {get; set;}
		public static string? ATEND {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstraintEnum
	{
		public static string? HARD {get; set;}
		public static string? SOFT {get; set;}
		public static string? ADVISORY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCControllerTypeEnum
	{
		public static string? FLOATING {get; set;}
		public static string? PROPORTIONAL {get; set;}
		public static string? TWOPOSITION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCooledBeamTypeEnum
	{
		public static string? ACTIVE {get; set;}
		public static string? PASSIVE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCoolingTowerTypeEnum
	{
		public static string? NATURALDRAFT {get; set;}
		public static string? MECHANICALINDUCEDDRAFT {get; set;}
		public static string? MECHANICALFORCEDDRAFT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCostScheduleTypeEnum
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
	/// <summary>
	public interface IFCCoveringTypeEnum
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
	/// <summary>
	public interface IFCCurrencyEnum
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
	/// <summary>
	public interface IFCCurtainWallTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDamperTypeEnum
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
	/// <summary>
	public interface IFCDataOriginEnum
	{
		public static string? MEASURED {get; set;}
		public static string? PREDICTED {get; set;}
		public static string? SIMULATED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDerivedUnitEnum
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
	/// <summary>
	public interface IFCDimensionExtentUsage
	{
		public static string? ORIGIN {get; set;}
		public static string? TARGET {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDirectionSenseEnum
	{
		public static string? POSITIVE {get; set;}
		public static string? NEGATIVE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionChamberElementTypeEnum
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
	/// <summary>
	public interface IFCDocumentConfidentialityEnum
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
	/// <summary>
	public interface IFCDocumentStatusEnum
	{
		public static string? DRAFT {get; set;}
		public static string? FINALDRAFT {get; set;}
		public static string? FINAL {get; set;}
		public static string? REVISION {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorPanelOperationEnum
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
	/// <summary>
	public interface IFCDoorPanelPositionEnum
	{
		public static string? LEFT {get; set;}
		public static string? MIDDLE {get; set;}
		public static string? RIGHT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorStyleConstructionEnum
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
	/// <summary>
	public interface IFCDoorStyleOperationEnum
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
	/// <summary>
	public interface IFCDuctFittingTypeEnum
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
	/// <summary>
	public interface IFCDuctSegmentTypeEnum
	{
		public static string? RIGIDSEGMENT {get; set;}
		public static string? FLEXIBLESEGMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctSilencerTypeEnum
	{
		public static string? FLATOVAL {get; set;}
		public static string? RECTANGULAR {get; set;}
		public static string? ROUND {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricApplianceTypeEnum
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
	/// <summary>
	public interface IFCElectricCurrentEnum
	{
		public static string? ALTERNATING {get; set;}
		public static string? DIRECT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricDistributionPointFunctionEnum
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
	/// <summary>
	public interface IFCElectricFlowStorageDeviceTypeEnum
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
	/// <summary>
	public interface IFCElectricGeneratorTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricHeaterTypeEnum
	{
		public static string? ELECTRICPOINTHEATER {get; set;}
		public static string? ELECTRICCABLEHEATER {get; set;}
		public static string? ELECTRICMATHEATER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricMotorTypeEnum
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
	/// <summary>
	public interface IFCElectricTimeControlTypeEnum
	{
		public static string? TIMECLOCK {get; set;}
		public static string? TIMEDELAY {get; set;}
		public static string? RELAY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCElementAssemblyTypeEnum
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
	/// <summary>
	public interface IFCElementCompositionEnum
	{
		public static string? COMPLEX {get; set;}
		public static string? ELEMENT {get; set;}
		public static string? PARTIAL {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCEnergySequenceEnum
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
	/// <summary>
	public interface IFCEnvironmentalImpactCategoryEnum
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
	/// <summary>
	public interface IFCEvaporativeCoolerTypeEnum
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
	/// <summary>
	public interface IFCEvaporatorTypeEnum
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
	/// <summary>
	public interface IFCFanTypeEnum
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
	/// <summary>
	public interface IFCFilterTypeEnum
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
	/// <summary>
	public interface IFCFireSuppressionTerminalTypeEnum
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
	/// <summary>
	public interface IFCFlowDirectionEnum
	{
		public static string? SOURCE {get; set;}
		public static string? SINK {get; set;}
		public static string? SOURCEANDSINK {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowInstrumentTypeEnum
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
	/// <summary>
	public interface IFCFlowMeterTypeEnum
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
	/// <summary>
	public interface IFCFootingTypeEnum
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
	/// <summary>
	public interface IFCGasTerminalTypeEnum
	{
		public static string? GASAPPLIANCE {get; set;}
		public static string? GASBOOSTER {get; set;}
		public static string? GASBURNER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricProjectionEnum
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
	/// <summary>
	public interface IFCGlobalOrLocalEnum
	{
		public static string? GLOBAL_COORDS {get; set;}
		public static string? LOCAL_COORDS {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCHeatExchangerTypeEnum
	{
		public static string? PLATE {get; set;}
		public static string? SHELLANDTUBE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCHumidifierTypeEnum
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
	/// <summary>
	public interface IFCInternalOrExternalEnum
	{
		public static string? INTERNAL {get; set;}
		public static string? EXTERNAL {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCInventoryTypeEnum
	{
		public static string? ASSETINVENTORY {get; set;}
		public static string? SPACEINVENTORY {get; set;}
		public static string? FURNITUREINVENTORY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCJunctionBoxTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLampTypeEnum
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
	/// <summary>
	public interface IFCLayerSetDirectionEnum
	{
		public static string? AXIS1 {get; set;}
		public static string? AXIS2 {get; set;}
		public static string? AXIS3 {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightDistributionCurveEnum
	{
		public static string? TYPE_A {get; set;}
		public static string? TYPE_B {get; set;}
		public static string? TYPE_C {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightEmissionSourceEnum
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
	/// <summary>
	public interface IFCLightFixtureTypeEnum
	{
		public static string? POINTSOURCE {get; set;}
		public static string? DIRECTIONSOURCE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLoadGroupTypeEnum
	{
		public static string? LOAD_GROUP {get; set;}
		public static string? LOAD_CASE {get; set;}
		public static string? LOAD_COMBINATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLogicalOperatorEnum
	{
		public static string? LOGICALAND {get; set;}
		public static string? LOGICALOR {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMemberTypeEnum
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
	/// <summary>
	public interface IFCMotorConnectionTypeEnum
	{
		public static string? BELTDRIVE {get; set;}
		public static string? COUPLING {get; set;}
		public static string? DIRECTDRIVE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCNullStyle
	{
		public static string? NULL {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCObjectTypeEnum
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
	/// <summary>
	public interface IFCObjectiveEnum
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
	/// <summary>
	public interface IFCOccupantTypeEnum
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
	/// <summary>
	public interface IFCOutletTypeEnum
	{
		public static string? AUDIOVISUALOUTLET {get; set;}
		public static string? COMMUNICATIONSOUTLET {get; set;}
		public static string? POWEROUTLET {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPermeableCoveringOperationEnum
	{
		public static string? GRILL {get; set;}
		public static string? LOUVER {get; set;}
		public static string? SCREEN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPhysicalOrVirtualEnum
	{
		public static string? PHYSICAL {get; set;}
		public static string? VIRTUAL {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPileConstructionEnum
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
	/// <summary>
	public interface IFCPileTypeEnum
	{
		public static string? COHESION {get; set;}
		public static string? FRICTION {get; set;}
		public static string? SUPPORT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPipeFittingTypeEnum
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
	/// <summary>
	public interface IFCPipeSegmentTypeEnum
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
	/// <summary>
	public interface IFCPlateTypeEnum
	{
		public static string? CURTAIN_PANEL {get; set;}
		public static string? SHEET {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProcedureTypeEnum
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
	/// <summary>
	public interface IFCProfileTypeEnum
	{
		public static string? CURVE {get; set;}
		public static string? AREA {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectOrderRecordTypeEnum
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
	/// <summary>
	public interface IFCProjectOrderTypeEnum
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
	/// <summary>
	public interface IFCProjectedOrTrueLengthEnum
	{
		public static string? PROJECTED_LENGTH {get; set;}
		public static string? TRUE_LENGTH {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySourceEnum
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
	/// <summary>
	public interface IFCProtectiveDeviceTypeEnum
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
	/// <summary>
	public interface IFCPumpTypeEnum
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
	/// <summary>
	public interface IFCRailingTypeEnum
	{
		public static string? HANDRAIL {get; set;}
		public static string? GUARDRAIL {get; set;}
		public static string? BALUSTRADE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRampFlightTypeEnum
	{
		public static string? STRAIGHT {get; set;}
		public static string? SPIRAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRampTypeEnum
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
	/// <summary>
	public interface IFCReflectanceMethodEnum
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
	/// <summary>
	public interface IFCReinforcingBarRoleEnum
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
	/// <summary>
	public interface IFCReinforcingBarSurfaceEnum
	{
		public static string? PLAIN {get; set;}
		public static string? TEXTURED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceConsumptionEnum
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
	/// <summary>
	public interface IFCRibPlateDirectionEnum
	{
		public static string? DIRECTION_X {get; set;}
		public static string? DIRECTION_Y {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRoleEnum
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
	/// <summary>
	public interface IFCRoofTypeEnum
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
	/// <summary>
	public interface IFCSIPrefix
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
	/// <summary>
	public interface IFCSIUnitName
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
	/// <summary>
	public interface IFCSanitaryTerminalTypeEnum
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
	/// <summary>
	public interface IFCSectionTypeEnum
	{
		public static string? UNIFORM {get; set;}
		public static string? TAPERED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSensorTypeEnum
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
	/// <summary>
	public interface IFCSequenceEnum
	{
		public static string? START_START {get; set;}
		public static string? START_FINISH {get; set;}
		public static string? FINISH_START {get; set;}
		public static string? FINISH_FINISH {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCServiceLifeFactorTypeEnum
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
	/// <summary>
	public interface IFCServiceLifeTypeEnum
	{
		public static string? ACTUALSERVICELIFE {get; set;}
		public static string? EXPECTEDSERVICELIFE {get; set;}
		public static string? OPTIMISTICREFERENCESERVICELIFE {get; set;}
		public static string? PESSIMISTICREFERENCESERVICELIFE {get; set;}
		public static string? REFERENCESERVICELIFE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSlabTypeEnum
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
	/// <summary>
	public interface IFCSoundScaleEnum
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
	/// <summary>
	public interface IFCSpaceHeaterTypeEnum
	{
		public static string? CONVECTOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStackTerminalTypeEnum
	{
		public static string? BIRDCAGE {get; set;}
		public static string? COWL {get; set;}
		public static string? RAINWATERHOPPER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStairFlightTypeEnum
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
	/// <summary>
	public interface IFCStairTypeEnum
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
	/// <summary>
	public interface IFCStateEnum
	{
		public static string? READWRITE {get; set;}
		public static string? READONLY {get; set;}
		public static string? LOCKED {get; set;}
		public static string? READWRITELOCKED {get; set;}
		public static string? READONLYLOCKED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveTypeEnum
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
	/// <summary>
	public interface IFCStructuralSurfaceTypeEnum
	{
		public static string? BENDING_ELEMENT {get; set;}
		public static string? MEMBRANE_ELEMENT {get; set;}
		public static string? SHELL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceSide
	{
		public static string? POSITIVE {get; set;}
		public static string? NEGATIVE {get; set;}
		public static string? BOTH {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceTextureEnum
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
	/// <summary>
	public interface IFCSwitchingDeviceTypeEnum
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
	/// <summary>
	public interface IFCTankTypeEnum
	{
		public static string? EXPANSION {get; set;}
		public static string? PRESSUREVESSEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonTypeEnum
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
	/// <summary>
	public interface IFCTextPath
	{
		public static string? LEFT {get; set;}
		public static string? RIGHT {get; set;}
		public static string? UP {get; set;}
		public static string? DOWN {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalLoadSourceEnum
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
	/// <summary>
	public interface IFCThermalLoadTypeEnum
	{
		public static string? SENSIBLE {get; set;}
		public static string? LATENT {get; set;}
		public static string? RADIANT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeSeriesDataTypeEnum
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
	/// <summary>
	public interface IFCTimeSeriesScheduleTypeEnum
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
	/// <summary>
	public interface IFCTransformerTypeEnum
	{
		public static string? CURRENT {get; set;}
		public static string? FREQUENCY {get; set;}
		public static string? VOLTAGE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTransitionCode
	{
		public static string? DISCONTINUOUS {get; set;}
		public static string? CONTINUOUS {get; set;}
		public static string? CONTSAMEGRADIENT {get; set;}
		public static string? CONTSAMEGRADIENTSAMECURVATURE {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTransportElementTypeEnum
	{
		public static string? ELEVATOR {get; set;}
		public static string? ESCALATOR {get; set;}
		public static string? MOVINGWALKWAY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTrimmingPreference
	{
		public static string? CARTESIAN {get; set;}
		public static string? PARAMETER {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTubeBundleTypeEnum
	{
		public static string? FINNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitEnum
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
	/// <summary>
	public interface IFCUnitaryEquipmentTypeEnum
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
	/// <summary>
	public interface IFCValveTypeEnum
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
	/// <summary>
	public interface IFCVibrationIsolatorTypeEnum
	{
		public static string? COMPRESSION {get; set;}
		public static string? SPRING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWallTypeEnum
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
	/// <summary>
	public interface IFCWasteTerminalTypeEnum
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
	/// <summary>
	public interface IFCWindowPanelOperationEnum
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
	/// <summary>
	public interface IFCWindowPanelPositionEnum
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
	/// <summary>
	public interface IFCWindowStyleConstructionEnum
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
	/// <summary>
	public interface IFCWindowStyleOperationEnum
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
	/// <summary>
	public interface IFCWorkControlTypeEnum
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCActionRequestTypeEnum
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
	/// <summary>
	public interface IFCAudioVisualApplianceTypeEnum
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
	/// <summary>
	public interface IFCBSplineSurfaceForm
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
	/// <summary>
	public interface IFCBuildingElementPartTypeEnum
	{
		public static string? INSULATION {get; set;}
		public static string? PRECASTPANEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingSystemTypeEnum
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
	/// <summary>
	public interface IFCBurnerTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCableFittingTypeEnum
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
	/// <summary>
	public interface IFCChimneyTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCommunicationsApplianceTypeEnum
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
	/// <summary>
	public interface IFCComplexPropertyTemplateTypeEnum
	{
		public static string? P_COMPLEX {get; set;}
		public static string? Q_COMPLEX {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionEquipmentResourceTypeEnum
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
	/// <summary>
	public interface IFCConstructionMaterialResourceTypeEnum
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
	/// <summary>
	public interface IFCConstructionProductResourceTypeEnum
	{
		public static string? ASSEMBLY {get; set;}
		public static string? FORMWORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCostItemTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCrewResourceTypeEnum
	{
		public static string? OFFICE {get; set;}
		public static string? SITE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveInterpolationEnum
	{
		public static string? LINEAR {get; set;}
		public static string? LOG_LINEAR {get; set;}
		public static string? LOG_LOG {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDiscreteAccessoryTypeEnum
	{
		public static string? ANCHORPLATE {get; set;}
		public static string? BRACKET {get; set;}
		public static string? SHOE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionPortTypeEnum
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
	/// <summary>
	public interface IFCDistributionSystemEnum
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
	/// <summary>
	public interface IFCDoorTypeEnum
	{
		public static string? DOOR {get; set;}
		public static string? GATE {get; set;}
		public static string? TRAPDOOR {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorTypeOperationEnum
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
	/// <summary>
	public interface IFCElectricDistributionBoardTypeEnum
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
	/// <summary>
	public interface IFCEngineTypeEnum
	{
		public static string? EXTERNALCOMBUSTION {get; set;}
		public static string? INTERNALCOMBUSTION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCEventTriggerTypeEnum
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
	/// <summary>
	public interface IFCEventTypeEnum
	{
		public static string? STARTEVENT {get; set;}
		public static string? ENDEVENT {get; set;}
		public static string? INTERMEDIATEEVENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalSpatialElementTypeEnum
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
	/// <summary>
	public interface IFCFastenerTypeEnum
	{
		public static string? GLUE {get; set;}
		public static string? MORTAR {get; set;}
		public static string? WELD {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFurnitureTypeEnum
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
	/// <summary>
	public interface IFCGeographicElementTypeEnum
	{
		public static string? TERRAIN {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCGridTypeEnum
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
	/// <summary>
	public interface IFCInterceptorTypeEnum
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
	/// <summary>
	public interface IFCKnotType
	{
		public static string? UNIFORM_KNOTS {get; set;}
		public static string? QUASI_UNIFORM_KNOTS {get; set;}
		public static string? PIECEWISE_BEZIER_KNOTS {get; set;}
		public static string? UNSPECIFIED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLaborResourceTypeEnum
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
	/// <summary>
	public interface IFCMechanicalFastenerTypeEnum
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
	/// <summary>
	public interface IFCMedicalDeviceTypeEnum
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
	/// <summary>
	public interface IFCOpeningElementTypeEnum
	{
		public static string? OPENING {get; set;}
		public static string? RECESS {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPerformanceHistoryTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPermitTypeEnum
	{
		public static string? ACCESS {get; set;}
		public static string? BUILDING {get; set;}
		public static string? WORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreferredSurfaceCurveRepresentation
	{
		public static string? CURVE3D {get; set;}
		public static string? PCURVE_S1 {get; set;}
		public static string? PCURVE_S2 {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectionElementTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySetTemplateTypeEnum
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
	/// <summary>
	public interface IFCProtectiveDeviceTrippingUnitTypeEnum
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
	/// <summary>
	public interface IFCRecurrenceTypeEnum
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
	/// <summary>
	public interface IFCReinforcingBarTypeEnum
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
	/// <summary>
	public interface IFCReinforcingMeshTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCShadingDeviceTypeEnum
	{
		public static string? JALOUSIE {get; set;}
		public static string? SHUTTER {get; set;}
		public static string? AWNING {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSimplePropertyTemplateTypeEnum
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
	/// <summary>
	public interface IFCSolarDeviceTypeEnum
	{
		public static string? SOLARCOLLECTOR {get; set;}
		public static string? SOLARPANEL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialZoneTypeEnum
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
	/// <summary>
	public interface IFCStructuralCurveActivityTypeEnum
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
	/// <summary>
	public interface IFCStructuralCurveMemberTypeEnum
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
	/// <summary>
	public interface IFCStructuralSurfaceActivityTypeEnum
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
	/// <summary>
	public interface IFCStructuralSurfaceMemberTypeEnum
	{
		public static string? BENDING_ELEMENT {get; set;}
		public static string? MEMBRANE_ELEMENT {get; set;}
		public static string? SHELL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSubContractResourceTypeEnum
	{
		public static string? PURCHASE {get; set;}
		public static string? WORK {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceFeatureTypeEnum
	{
		public static string? MARK {get; set;}
		public static string? TAG {get; set;}
		public static string? TREATMENT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSystemFurnitureElementTypeEnum
	{
		public static string? PANEL {get; set;}
		public static string? WORKSURFACE {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTaskDurationEnum
	{
		public static string? ELAPSEDTIME {get; set;}
		public static string? WORKTIME {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTaskTypeEnum
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
	/// <summary>
	public interface IFCTendonAnchorTypeEnum
	{
		public static string? COUPLER {get; set;}
		public static string? FIXED_END {get; set;}
		public static string? TENSIONING_END {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitaryControlElementTypeEnum
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
	/// <summary>
	public interface IFCVoidingFeatureTypeEnum
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
	/// <summary>
	public interface IFCWindowTypeEnum
	{
		public static string? WINDOW {get; set;}
		public static string? SKYLIGHT {get; set;}
		public static string? LIGHTDOME {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowTypePartitioningEnum
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
	/// <summary>
	public interface IFCWorkCalendarTypeEnum
	{
		public static string? FIRSTSHIFT {get; set;}
		public static string? SECONDSHIFT {get; set;}
		public static string? THIRDSHIFT {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkPlanTypeEnum
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkScheduleTypeEnum
	{
		public static string? ACTUAL {get; set;}
		public static string? BASELINE {get; set;}
		public static string? PLANNED {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReferentTypeEnum
	{
		public static string? KILOPOINT {get; set;}
		public static string? MILEPOINT {get; set;}
		public static string? STATION {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTransitionCurveType
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
	/// <summary>
	public interface IFCBearingTypeDisplacementEnum
	{
		public static string? FIXED_MOVEMENT {get; set;}
		public static string? GUIDED_LONGITUDINAL {get; set;}
		public static string? GUIDED_TRANSVERSAL {get; set;}
		public static string? FREE_MOVEMENT {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBearingTypeEnum
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
	/// <summary>
	public interface IFCBridgePartTypeEnum
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
	/// <summary>
	public interface IFCBridgeTypeEnum
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
	/// <summary>
	public interface IFCCaissonFoundationTypeEnum
	{
		public static string? WELL {get; set;}
		public static string? CAISSON {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonConduitTypeEnum
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
	/// <summary>
	public interface IFCVibrationDamperTypeEnum
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
	/// <summary>
	public interface IFCAlignmentCantSegmentTypeEnum
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
	/// <summary>
	public interface IFCAlignmentHorizontalSegmentTypeEnum
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
	/// <summary>
	public interface IFCAlignmentVerticalSegmentTypeEnum
	{
		public static string? CIRCULARARC {get; set;}
		public static string? CLOTHOID {get; set;}
		public static string? CONSTANTGRADIENT {get; set;}
		public static string? PARABOLICARC {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationTypeEnum
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
	/// <summary>
	public interface IFCBuiltSystemTypeEnum
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
	/// <summary>
	public interface IFCConveyorSegmentTypeEnum
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
	/// <summary>
	public interface IFCCourseTypeEnum
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
	/// <summary>
	public interface IFCDistributionBoardTypeEnum
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
	/// <summary>
	public interface IFCEarthworksCutTypeEnum
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
	/// <summary>
	public interface IFCEarthworksFillTypeEnum
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
	/// <summary>
	public interface IFCElectricFlowTreatmentDeviceTypeEnum
	{
		public static string? ELECTRONICFILTER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFacilityPartCommonTypeEnum
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
	/// <summary>
	public interface IFCFacilityUsageEnum
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
	/// <summary>
	public interface IFCGeotechnicalStratumTypeEnum
	{
		public static string? SOLID {get; set;}
		public static string? VOID {get; set;}
		public static string? WATER {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCImpactProtectionDeviceTypeEnum
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
	/// <summary>
	public interface IFCKerbTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLiquidTerminalTypeEnum
	{
		public static string? HOSEREEL {get; set;}
		public static string? LOADINGARM {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMarineFacilityTypeEnum
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
	/// <summary>
	public interface IFCMarinePartTypeEnum
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
	/// <summary>
	public interface IFCMobileTelecommunicationsApplianceTypeEnum
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
	/// <summary>
	public interface IFCMooringDeviceTypeEnum
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
	/// <summary>
	public interface IFCNavigationElementTypeEnum
	{
		public static string? BEACON {get; set;}
		public static string? BUOY {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPavementTypeEnum
	{
		public static string? FLEXIBLE {get; set;}
		public static string? RIGID {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRailTypeEnum
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
	/// <summary>
	public interface IFCRailwayPartTypeEnum
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
	/// <summary>
	public interface IFCRailwayTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcedSoilTypeEnum
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
	/// <summary>
	public interface IFCRoadPartTypeEnum
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
	/// <summary>
	public interface IFCRoadTypeEnum
	{
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSignTypeEnum
	{
		public static string? MARKER {get; set;}
		public static string? MIRROR {get; set;}
		public static string? PICTORAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSignalTypeEnum
	{
		public static string? AUDIO {get; set;}
		public static string? MIXED {get; set;}
		public static string? VISUAL {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTrackElementTypeEnum
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
	/// <summary>
	public interface IFCVehicleTypeEnum
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
	/// <summary>
	public interface IFCVirtualElementTypeEnum
	{
		public static string? BOUNDARY {get; set;}
		public static string? CLEARANCE {get; set;}
		public static string? PROVISIONFORVOID {get; set;}
		public static string? USERDEFINED {get; set;}
		public static string? NOTDEFINED {get; set;}
		public string Value {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCActorSelect
	{
		public List<IFCActorRole>? _Roles {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAppliedValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCAxis2Placement
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _RefDirection {get; }
		public List<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBooleanOperand
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCharacterStyleSelect
	{
		public IFCColour? _Colour {get; set;}
		public IFCColour? _BackgroundColour {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationNotationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCColour
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCColourOrFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCConditionCriterionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCCsgSelect
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveFontOrScaledCurveFontSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveOrEdgeCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveStyleFontSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDateTimeSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCDefinedSymbolSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDerivedMeasureValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCDocumentSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingCalloutElement
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFillAreaStyleTileShapeSelect
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAnnotationSymbolOccurrence? _Symbol {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFillStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricSetSelect
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHatchLineDistanceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCLayeredItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCLibrarySelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightDistributionDataSourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCMeasureValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCOrientationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCPointOrVertexPoint
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationStyleSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCShell
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSimpleValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCSizeSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCSpecularHighlightSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralActivityAssignmentSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceOrFaceSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCSymbolStyleSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextFontSelect
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCTrimmingSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCVectorOrDirection
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBendingParameterSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationReferenceSelect
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCClassificationReference>? _HasReferences {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationSelect
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCClassificationReference>? _HasReferences {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoordinateReferenceSystemSelect
	{
		public List<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveOnSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDefinitionSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGridPlacementDirectionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfRotationalSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCModulusOfTranslationalSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCProcessSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProductRepresentationSelect
	{
		public List<IFCShapeAspect>? _HasShapeAspects {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProductSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySetDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRotationalStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCSegmentIndexSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCSolidOrShell
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceBoundarySelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStyleAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeOrRatioSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCTranslationalStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCWarpingStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveMeasureSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCInterferenceSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialReferenceSelect
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFC2DCompositeCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCompositeCurveSegment>? _Segments {get; }
		public LOGICAL? _SelfIntersect {get; }
		public INTEGER? _NSegments {get; }
		public LOGICAL? _ClosedCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCActionRequest
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCActor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _TheActor {get; }
		public List<IFCRelAssignsToActor>? _IsActingUpon {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCActorRole
	{
		public IFCRoleEnum? _Role {get; set;}
		public IFCLabel? _UserDefinedRole {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCActuatorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCActuatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAddress
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public List<IFCPerson>? _OfPerson {get; }
		public List<IFCOrganization>? _OfOrganization {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminalBoxType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirTerminalBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirToAirHeatRecoveryType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAirToAirHeatRecoveryTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlarmType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAlarmTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAngularDimension
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotation
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationCurveOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationFillArea
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurve? _OuterBoundary {get; }
		public List<IFCCurve>? _InnerBoundaries {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationFillAreaOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCPoint? _FillStyleTarget {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCGeometricRepresentationItem? _Item {get; }
		public IFCTextureCoordinate? _TextureCoordinates {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationSurfaceOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationSymbolOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAnnotationTextOccurrence
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCApplication
	{
		public IFCOrganization? _ApplicationDeveloper {get; set;}
		public IFCLabel? _Version {get; set;}
		public IFCLabel? _ApplicationFullName {get; set;}
		public IFCIdentifier? _ApplicationIdentifier {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAppliedValue
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAppliedValueRelationship
	{
		public IFCAppliedValue? _ComponentOfTotal {get; set;}
		public List<IFCAppliedValue>? _Components {get; set;}
		public IFCArithmeticOperatorEnum? _ArithmeticOperator {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCApproval
	{
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
		public List<IFCApprovalRelationship>? _IsRelatedWith {get; }
		public List<IFCApprovalRelationship>? _Relates {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCApprovalActorRelationship
	{
		public IFCActorSelect? _Actor {get; set;}
		public IFCApproval? _Approval {get; set;}
		public IFCActorRole? _Role {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCApprovalPropertyRelationship
	{
		public List<IFCProperty>? _ApprovedProperties {get; set;}
		public IFCApproval? _Approval {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCApprovalRelationship
	{
		public IFCApproval? _RelatingApproval {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCArbitraryClosedProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCCurve? _OuterCurve {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCArbitraryOpenProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCBoundedCurve? _Curve {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCArbitraryProfileDefWithVoids
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCCurve? _OuterCurve {get; set;}
		public List<IFCCurve>? _InnerCurves {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAsset
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
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
	/// <summary>
	public interface IFCAsymmetricIShapeProfileDef
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
	/// <summary>
	public interface IFCAxis1Placement
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _Z {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAxis2Placement2D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _RefDirection {get; }
		public List<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAxis2Placement3D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _RefDirection {get; }
		public List<IFCDirection>? _P {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBSplineCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public List<IFCCartesianPoint>? _ControlPoints {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBeam
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBeamType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBezierCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public INTEGER? _Degree {get; }
		public List<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public LOGICAL? _ClosedCurve {get; }
		public LOGICAL? _SelfIntersect {get; }
		public List<IFCCartesianPoint>? _ControlPoints {get; }
		public INTEGER? _UpperIndexOnControlPoints {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBlobTexture
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
		public IFCIdentifier? _RasterFormat {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBlock
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _XLength {get; }
		public IFCPositiveLengthMeasure? _YLength {get; }
		public IFCPositiveLengthMeasure? _ZLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoilerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBoilerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBooleanClippingResult
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBooleanOperator? _Operator {get; }
		public IFCBooleanOperand? _FirstOperand {get; }
		public IFCBooleanOperand? _SecondOperand {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBooleanResult
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBooleanOperator? _Operator {get; }
		public IFCBooleanOperand? _FirstOperand {get; }
		public IFCBooleanOperand? _SecondOperand {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryCondition
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryEdgeCondition
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryFaceCondition
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryNodeCondition
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryNodeConditionWarping
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundedCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundedSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundingBox
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPoint? _Corner {get; }
		public IFCPositiveLengthMeasure? _XDim {get; }
		public IFCPositiveLengthMeasure? _YDim {get; }
		public IFCPositiveLengthMeasure? _ZDim {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoxedHalfSpace
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCBoundingBox? _Enclosure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuilding
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _ElevationOfRefHeight {get; }
		public IFCLengthMeasure? _ElevationOfTerrain {get; }
		public IFCPostalAddress? _BuildingAddress {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementComponent
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementPart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementProxy
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementProxyType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBuildingElementProxyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingStorey
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _Elevation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCShapeProfileDef
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
	/// <summary>
	public interface IFCCableCarrierFittingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableCarrierFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableCarrierSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableCarrierSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCalendarDate
	{
		public IFCDayInMonthNumber? _DayComponent {get; set;}
		public IFCMonthInYearNumber? _MonthComponent {get; set;}
		public IFCYearNumber? _YearComponent {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianPoint
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCLengthMeasure>? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianTransformationOperator
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianTransformationOperator2D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianTransformationOperator2DnonUniform
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianTransformationOperator3D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis3 {get; }
		public List<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianTransformationOperator3DnonUniform
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Axis1 {get; }
		public IFCDirection? _Axis2 {get; }
		public IFCCartesianPoint? _LocalOrigin {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis3 {get; }
		public List<IFCDirection>? _U {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCenterLineProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCBoundedCurve? _Curve {get; set;}
		public IFCPositiveLengthMeasure? _Thickness {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCChamferEdgeFeature
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
		public IFCPositiveLengthMeasure? _Width {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCChillerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCChillerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCircle
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCircleHollowProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
		public IFCPositiveLengthMeasure? _WallThickness {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCircleProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _Radius {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassification
	{
		public IFCLabel? _Source {get; set;}
		public IFCLabel? _Edition {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationItem
	{
		public IFCClassificationNotationFacet? _Notation {get; set;}
		public IFCClassification? _ItemOf {get; set;}
		public IFCLabel? _Title {get; set;}
		public List<IFCClassificationItemRelationship>? _IsClassifiedItemIn {get; }
		public List<IFCClassificationItemRelationship>? _IsClassifyingItemIn {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationItemRelationship
	{
		public IFCClassificationItem? _RelatingItem {get; set;}
		public List<IFCClassificationItem>? _RelatedItems {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationNotation
	{
		public List<IFCClassificationNotationFacet>? _NotationFacets {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationNotationFacet
	{
		public IFCLabel? _NotationValue {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClassificationReference
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCClosedShell
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoilType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCColourRgb
	{
		public IFCLabel? _Name {get; set;}
		public IFCNormalisedRatioMeasure? _Red {get; set;}
		public IFCNormalisedRatioMeasure? _Green {get; set;}
		public IFCNormalisedRatioMeasure? _Blue {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCColourSpecification
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCColumn
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCColumnType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCColumnTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCComplexProperty
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCIdentifier? _UsageName {get; }
		public List<IFCProperty>? _HasProperties {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCompositeCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCompositeCurveSegment
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCCurve? _ParentCurve {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCompositeCurve>? _UsingCurves {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCompositeProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public List<IFCProfileDef>? _Profiles {get; set;}
		public IFCLabel? _Label {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCompressorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCompressorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCondenserType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCondenserTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCondition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCRelAssignsToGroup? _IsGroupedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConditionCriterion
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCConditionCriterionSelect? _Criterion {get; }
		public IFCDateTimeSelect? _CriterionDateTime {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConic
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectedFaceSet
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionCurveGeometry
	{
		public IFCCurveOrEdgeCurve? _CurveOnRelatingElement {get; set;}
		public IFCCurveOrEdgeCurve? _CurveOnRelatedElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionPointEccentricity
	{
		public IFCPointOrVertexPoint? _PointOnRelatingElement {get; set;}
		public IFCPointOrVertexPoint? _PointOnRelatedElement {get; set;}
		public IFCLengthMeasure? _EccentricityInX {get; set;}
		public IFCLengthMeasure? _EccentricityInY {get; set;}
		public IFCLengthMeasure? _EccentricityInZ {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionPointGeometry
	{
		public IFCPointOrVertexPoint? _PointOnRelatingElement {get; set;}
		public IFCPointOrVertexPoint? _PointOnRelatedElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionPortGeometry
	{
		public IFCAxis2Placement? _LocationAtRelatingElement {get; set;}
		public IFCAxis2Placement? _LocationAtRelatedElement {get; set;}
		public IFCProfileDef? _ProfileOfPort {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionSurfaceGeometry
	{
		public IFCSurfaceOrFaceSurface? _SurfaceOnRelatingElement {get; set;}
		public IFCSurfaceOrFaceSurface? _SurfaceOnRelatedElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstraint
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraintEnum? _ConstraintGrade {get; set;}
		public IFCLabel? _ConstraintSource {get; set;}
		public IFCActorSelect? _CreatingActor {get; set;}
		public IFCLabel? _UserDefinedGrade {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstraintAggregationRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public List<IFCConstraint>? _RelatedConstraints {get; set;}
		public IFCLogicalOperatorEnum? _LogicalAggregator {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstraintClassificationRelationship
	{
		public IFCConstraint? _ClassifiedConstraint {get; set;}
		public List<IFCClassificationNotationSelect>? _RelatedClassifications {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstraintRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public List<IFCConstraint>? _RelatedConstraints {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionEquipmentResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionMaterialResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionProductResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCContextDependentUnit
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCControl
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCControllerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCControllerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConversionBasedUnit
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCMeasureWithUnit? _ConversionFactor {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCooledBeamType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCooledBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoolingTowerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoolingTowerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoordinatedUniversalTimeOffset
	{
		public IFCHourInDay? _HourOffset {get; set;}
		public IFCMinuteInHour? _MinuteOffset {get; set;}
		public IFCAheadOrBehind? _Sense {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCostItem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCostSchedule
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCLabel? _Status {get; }
		public IFCCostScheduleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCostValue
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCovering
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCCoveringTypeEnum? _PredefinedType {get; }
		public List<IFCRelCoversSpaces>? _CoversSpaces {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoveringType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCoveringTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCraneRailAShapeProfileDef
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
	/// <summary>
	public interface IFCCraneRailFShapeProfileDef
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
	/// <summary>
	public interface IFCCrewResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCsgPrimitive3D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCsgSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCsgSelect? _TreeRootExpression {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurrencyRelationship
	{
		public IFCMonetaryUnit? _RelatingMonetaryUnit {get; set;}
		public IFCMonetaryUnit? _RelatedMonetaryUnit {get; set;}
		public IFCPositiveRatioMeasure? _ExchangeRate {get; set;}
		public IFCLibraryInformation? _RateSource {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurtainWall
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurtainWallType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCurtainWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveBoundedPlane
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPlane? _BasisSurface {get; }
		public IFCCurve? _OuterBoundary {get; }
		public List<IFCCurve>? _InnerBoundaries {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveStyle
	{
		public IFCLabel? _Name {get; set;}
		public IFCCurveFontOrScaledCurveFontSelect? _CurveFont {get; set;}
		public IFCSizeSelect? _CurveWidth {get; set;}
		public IFCColour? _CurveColour {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveStyleFont
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCCurveStyleFontPattern>? _PatternList {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveStyleFontAndScaling
	{
		public IFCLabel? _Name {get; set;}
		public IFCPositiveRatioMeasure? _CurveFontScaling {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveStyleFontPattern
	{
		public IFCLengthMeasure? _VisibleSegmentLength {get; set;}
		public IFCPositiveLengthMeasure? _InvisibleSegmentLength {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDamperType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDateAndTime
	{
		public IFCCalendarDate? _DateComponent {get; set;}
		public IFCLocalTime? _TimeComponent {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDefinedSymbol
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDefinedSymbolSelect? _Definition {get; }
		public IFCCartesianTransformationOperator2D? _Target {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDerivedProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCProfileDef? _ParentProfile {get; set;}
		public IFCCartesianTransformationOperator2D? _Operator {get; set;}
		public IFCLabel? _Label {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDerivedUnit
	{
		public List<IFCDerivedUnitElement>? _Elements {get; set;}
		public IFCDerivedUnitEnum? _UnitType {get; set;}
		public IFCLabel? _UserDefinedType {get; set;}
		public IFCDimensionalExponents? _Dimensions {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDerivedUnitElement
	{
		public IFCNamedUnit? _Unit {get; set;}
		public INTEGER? _Exponent {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDiameterDimension
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionCalloutRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public List<IFCTerminatorSymbol>? _AnnotatedBySymbols {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionCurveDirectedCallout
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionCurveTerminator
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCAnnotationCurveOccurrence? _AnnotatedCurve {get; }
		public IFCDimensionExtentUsage? _Role {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionPair
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDimensionalExponents
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
	/// <summary>
	public interface IFCDirection
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDiscreteAccessory
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDiscreteAccessoryType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionChamberElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionChamberElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDistributionChamberElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionControlElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionControlElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionFlowElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionFlowElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionPort
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsPorts>? _ConnectedFrom {get; }
		public List<IFCRelConnectsPorts>? _ConnectedTo {get; }
		public IFCFlowDirectionEnum? _FlowDirection {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDocumentElectronicFormat
	{
		public IFCLabel? _FileExtension {get; set;}
		public IFCLabel? _MimeContentType {get; set;}
		public IFCLabel? _MimeSubtype {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDocumentInformation
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCText? _Purpose {get; set;}
		public IFCText? _IntendedUse {get; set;}
		public IFCText? _Scope {get; set;}
		public IFCLabel? _Revision {get; set;}
		public IFCActorSelect? _DocumentOwner {get; set;}
		public List<IFCActorSelect>? _Editors {get; set;}
		public IFCDocumentConfidentialityEnum? _Confidentiality {get; set;}
		public IFCDocumentStatusEnum? _Status {get; set;}
		public List<IFCDocumentInformationRelationship>? _IsPointedTo {get; }
		public List<IFCDocumentInformationRelationship>? _IsPointer {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDocumentInformationRelationship
	{
		public IFCDocumentInformation? _RelatingDocument {get; set;}
		public List<IFCDocumentInformation>? _RelatedDocuments {get; set;}
		public IFCLabel? _RelationshipType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDocumentReference
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDoor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorLiningProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
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
	/// <summary>
	public interface IFCDoorPanelProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveLengthMeasure? _PanelDepth {get; }
		public IFCDoorPanelOperationEnum? _PanelOperation {get; }
		public IFCNormalisedRatioMeasure? _PanelWidth {get; }
		public IFCDoorPanelPositionEnum? _PanelPosition {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorStyle
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCDoorStyleOperationEnum? _OperationType {get; }
		public IFCDoorStyleConstructionEnum? _ConstructionType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingCallout
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingCalloutRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDraughtingCallout? _RelatingDraughtingCallout {get; set;}
		public IFCDraughtingCallout? _RelatedDraughtingCallout {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingPreDefinedColour
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingPreDefinedCurveFont
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDraughtingPreDefinedTextFont
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctFittingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctSilencerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDuctSilencerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEdge
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEdgeCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCCurve? _EdgeGeometry {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEdgeFeature
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEdgeLoop
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCOrientedEdge>? _EdgeList {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricApplianceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricDistributionPoint
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricDistributionPointFunctionEnum? _DistributionPointFunction {get; }
		public IFCLabel? _UserDefinedFunction {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricFlowStorageDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricFlowStorageDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricGeneratorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricGeneratorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricHeaterType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _ObjectTypeOf {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricMotorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricMotorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricTimeControlType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricTimeControlTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricalBaseProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
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
	/// <summary>
	public interface IFCElectricalCircuit
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCRelAssignsToGroup? _IsGroupedBy {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricalElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementAssembly
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCAssemblyPlaceEnum? _AssemblyPlace {get; }
		public IFCElementAssemblyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementComponent
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementComponentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementQuantity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCLabel? _MethodOfMeasurement {get; }
		public List<IFCPhysicalQuantity>? _Quantities {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementarySurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEllipse
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCPositiveLengthMeasure? _SemiAxis1 {get; }
		public IFCPositiveLengthMeasure? _SemiAxis2 {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEllipseProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _SemiAxis1 {get; set;}
		public IFCPositiveLengthMeasure? _SemiAxis2 {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCEnergyConversionDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEnergyConversionDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEnergyProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCEnergySequenceEnum? _EnergySequence {get; }
		public IFCLabel? _UserDefinedEnergySequence {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEnvironmentalImpactValue
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCAppliedValueSelect? _AppliedValue {get; set;}
		public IFCMeasureWithUnit? _UnitBasis {get; set;}
		public IFCDateTimeSelect? _ApplicableDate {get; set;}
		public IFCDateTimeSelect? _FixedUntilDate {get; set;}
		public List<IFCReferencesValueDocument>? _ValuesReferenced {get; }
		public List<IFCAppliedValueRelationship>? _ValueOfComponents {get; }
		public List<IFCAppliedValueRelationship>? _IsComponentIn {get; }
		public IFCLabel? _ImpactType {get; }
		public IFCEnvironmentalImpactCategoryEnum? _Category {get; }
		public IFCLabel? _UserDefinedCategory {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEquipmentElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEquipmentStandard
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEvaporativeCoolerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEvaporativeCoolerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEvaporatorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEvaporatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCExtendedMaterialProperties
	{
		public IFCMaterial? _Material {get; set;}
		public List<IFCProperty>? _ExtendedProperties {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalReference
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternallyDefinedHatchStyle
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternallyDefinedSurfaceStyle
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternallyDefinedSymbol
	{
		public IFCLabel? _Location {get; set;}
		public IFCIdentifier? _ItemReference {get; set;}
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternallyDefinedTextFont
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExtrudedAreaSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCPositiveLengthMeasure? _Depth {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFace
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFaceBound>? _Bounds {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFaceBasedSurfaceModel
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCConnectedFaceSet>? _FbsmFaces {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFaceBound
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLoop? _Bound {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFaceOuterBound
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLoop? _Bound {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFaceSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFaceBound>? _Bounds {get; }
		public IFCSurface? _FaceSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFacetedBrep
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFacetedBrepWithVoids
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
		public List<IFCClosedShell>? _Voids {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFailureConnectionCondition
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
	/// <summary>
	public interface IFCFanType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFanTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFastener
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFastenerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFeatureElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFeatureElementAddition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelProjectsElement? _ProjectsElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFeatureElementSubtraction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFillAreaStyle
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCFillStyleSelect>? _FillStyles {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFillAreaStyleHatching
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurveStyle? _HatchLineAppearance {get; }
		public IFCHatchLineDistanceSelect? _StartOfNextHatchLine {get; }
		public IFCCartesianPoint? _PointOfReferenceHatchLine {get; }
		public IFCCartesianPoint? _PatternStart {get; }
		public IFCPlaneAngleMeasure? _HatchLineAngle {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFillAreaStyleTileSymbolWithStyle
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAnnotationSymbolOccurrence? _Symbol {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFillAreaStyleTiles
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPositiveRatioMeasure? _TilingScale {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFilterType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFilterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFireSuppressionTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFireSuppressionTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowController
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowControllerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowFitting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowFittingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowInstrumentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFlowInstrumentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowMeterType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFlowMeterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowMovingDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowMovingDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowStorageDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowStorageDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowTreatmentDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowTreatmentDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFluidFlowProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
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
	/// <summary>
	public interface IFCFooting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCFootingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFuelProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCThermodynamicTemperatureMeasure? _CombustionTemperature {get; set;}
		public IFCPositiveRatioMeasure? _CarbonContent {get; set;}
		public IFCHeatingValueMeasure? _LowerHeatingValue {get; set;}
		public IFCHeatingValueMeasure? _HigherHeatingValue {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCFurnishingElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFurnishingElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFurnitureStandard
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFurnitureType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAssemblyPlaceEnum? _AssemblyPlace {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGasTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _ObjectTypeOf {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCGasTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeneralMaterialProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCMolecularWeightMeasure? _MolecularWeight {get; set;}
		public IFCNormalisedRatioMeasure? _Porosity {get; set;}
		public IFCMassDensityMeasure? _MassDensity {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCGeneralProfileProperties
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
	/// <summary>
	public interface IFCGeometricCurveSet
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCGeometricSetSelect>? _Elements {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricRepresentationContext
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public List<IFCRepresentation>? _RepresentationsInContext {get; }
		public IFCDimensionCount? _CoordinateSpaceDimension {get; }
		public IFCAxis2Placement? _WorldCoordinateSystem {get; }
		public IFCDirection? _TrueNorth {get; }
		public List<IFCGeometricRepresentationSubContext>? _HasSubContexts {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricRepresentationItem
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricRepresentationSubContext
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public List<IFCRepresentation>? _RepresentationsInContext {get; }
		public IFCDimensionCount? _CoordinateSpaceDimension {get; }
		public IFCAxis2Placement? _WorldCoordinateSystem {get; }
		public IFCDirection? _TrueNorth {get; }
		public List<IFCGeometricRepresentationSubContext>? _HasSubContexts {get; }
		public IFCGeometricRepresentationContext? _ParentContext {get; }
		public IFCPositiveRatioMeasure? _TargetScale {get; }
		public IFCGeometricProjectionEnum? _TargetView {get; }
		public IFCLabel? _UserDefinedTargetView {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeometricSet
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCGeometricSetSelect>? _Elements {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGrid
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCGridAxis>? _UAxes {get; }
		public List<IFCGridAxis>? _VAxes {get; }
		public List<IFCGridAxis>? _WAxes {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGridAxis
	{
		public IFCLabel? _AxisTag {get; set;}
		public IFCCurve? _AxisCurve {get; set;}
		public IFCBoolean? _SameSense {get; set;}
		public List<IFCGrid>? _PartOfW {get; }
		public List<IFCGrid>? _PartOfV {get; }
		public List<IFCGrid>? _PartOfU {get; }
		public List<IFCVirtualGridIntersection>? _HasIntersections {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGridPlacement
	{
		public List<IFCProduct>? _PlacesObject {get; }
		public IFCVirtualGridIntersection? _PlacementLocation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGroup
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHalfSpaceSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHeatExchangerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCHeatExchangerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHumidifierType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCHumidifierTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHygroscopicMaterialProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCPositiveRatioMeasure? _UpperVaporResistanceFactor {get; set;}
		public IFCPositiveRatioMeasure? _LowerVaporResistanceFactor {get; set;}
		public IFCIsothermalMoistureCapacityMeasure? _IsothermalMoistureCapacity {get; set;}
		public IFCVaporPermeabilityMeasure? _VaporPermeability {get; set;}
		public IFCMoistureDiffusivityMeasure? _MoistureDiffusivity {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIShapeProfileDef
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
	/// <summary>
	public interface IFCImageTexture
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCInventory
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _Jurisdiction {get; }
		public List<IFCPerson>? _ResponsiblePersons {get; }
		public IFCCostValue? _CurrentValue {get; }
		public IFCCostValue? _OriginalValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIrregularTimeSeries
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
		public List<IFCIrregularTimeSeriesValue>? _Values {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIrregularTimeSeriesValue
	{
		public List<IFCValue>? _ListValues {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCJunctionBoxType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCJunctionBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLShapeProfileDef
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
	/// <summary>
	public interface IFCLaborResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLampType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLibraryInformation
	{
		public IFCLabel? _Name {get; set;}
		public IFCLabel? _Version {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLibraryReference
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightDistributionData
	{
		public IFCPlaneAngleMeasure? _MainPlaneAngle {get; set;}
		public List<IFCPlaneAngleMeasure>? _SecondaryPlaneAngle {get; set;}
		public List<IFCLuminousIntensityDistributionMeasure>? _LuminousIntensity {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightFixtureType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLightFixtureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLightIntensityDistribution
	{
		public IFCLightDistributionCurveEnum? _LightDistributionCurve {get; set;}
		public List<IFCLightDistributionData>? _DistributionData {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLightSource
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLightSourceAmbient
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLightSourceDirectional
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLabel? _Name {get; }
		public IFCColourRgb? _LightColour {get; }
		public IFCNormalisedRatioMeasure? _AmbientIntensity {get; }
		public IFCNormalisedRatioMeasure? _Intensity {get; }
		public IFCDirection? _Orientation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLightSourceGoniometric
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
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
	/// <summary>
	public interface IFCLightSourcePositional
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
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
	/// <summary>
	public interface IFCLightSourceSpot
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
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
	/// <summary>
	public interface IFCLine
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _Pnt {get; }
		public IFCVector? _Dir {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearDimension
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLocalPlacement
	{
		public List<IFCProduct>? _PlacesObject {get; }
		public IFCObjectPlacement? _PlacementRelTo {get; }
		public IFCAxis2Placement? _RelativePlacement {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLocalTime
	{
		public IFCHourInDay? _HourComponent {get; set;}
		public IFCMinuteInHour? _MinuteComponent {get; set;}
		public IFCSecondInMinute? _SecondComponent {get; set;}
		public IFCCoordinatedUniversalTimeOffset? _Zone {get; set;}
		public IFCDaylightSavingHour? _DaylightSavingOffset {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLoop
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCManifoldSolidBrep
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMappedItem
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationMap? _MappingSource {get; }
		public IFCCartesianTransformationOperator? _MappingTarget {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterial
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCMaterialDefinitionRepresentation>? _HasRepresentation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialClassificationRelationship
	{
		public IFCMaterial? _ClassifiedMaterial {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialDefinitionRepresentation
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRepresentation>? _Representations {get; set;}
		public IFCMaterial? _RepresentedMaterial {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialLayer
	{
		public IFCMaterial? _Material {get; set;}
		public IFCLogical? _IsVentilated {get; set;}
		public IFCMaterialLayerSet? _ToMaterialLayerSet {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialLayerSet
	{
		public List<IFCMaterialLayer>? _MaterialLayers {get; set;}
		public IFCLabel? _LayerSetName {get; set;}
		public IFCLengthMeasure? _TotalThickness {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialLayerSetUsage
	{
		public IFCMaterialLayerSet? _ForLayerSet {get; set;}
		public IFCLayerSetDirectionEnum? _LayerSetDirection {get; set;}
		public IFCDirectionSenseEnum? _DirectionSense {get; set;}
		public IFCLengthMeasure? _OffsetFromReferenceLine {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialList
	{
		public List<IFCMaterial>? _Materials {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCMeasureWithUnit
	{
		public IFCValue? _ValueComponent {get; set;}
		public IFCUnit? _UnitComponent {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMechanicalConcreteMaterialProperties
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
	/// <summary>
	public interface IFCMechanicalFastener
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCPositiveLengthMeasure? _NominalLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMechanicalFastenerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMechanicalMaterialProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCDynamicViscosityMeasure? _DynamicViscosity {get; set;}
		public IFCModulusOfElasticityMeasure? _YoungModulus {get; set;}
		public IFCModulusOfElasticityMeasure? _ShearModulus {get; set;}
		public IFCPositiveRatioMeasure? _PoissonRatio {get; set;}
		public IFCThermalExpansionCoefficientMeasure? _ThermalExpansionCoefficient {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMechanicalSteelMaterialProperties
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
		public List<IFCRelaxation>? _Relaxations {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMember
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMemberType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMemberTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMetric
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
	/// <summary>
	public interface IFCMonetaryUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCMotorConnectionType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMotorConnectionTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMove
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCIdentifier? _TaskId {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
		public BOOLEAN? _IsMilestone {get; }
		public INTEGER? _Priority {get; }
		public IFCSpatialStructureElement? _MoveFrom {get; }
		public IFCSpatialStructureElement? _MoveTo {get; }
		public List<IFCText>? _PunchList {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCNamedUnit
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCObject
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCObjectDefinition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCObjectPlacement
	{
		public List<IFCProduct>? _PlacesObject {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCObjective
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
	/// <summary>
	public interface IFCOccupant
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCActorSelect? _TheActor {get; }
		public List<IFCRelAssignsToActor>? _IsActingUpon {get; }
		public IFCOccupantTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOffsetCurve2D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLengthMeasure? _Distance {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOffsetCurve3D
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLengthMeasure? _Distance {get; }
		public IFCDirection? _RefDirection {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOneDirectionRepeatFactor
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVector? _RepeatFactor {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOpenShell
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFace>? _CfsFaces {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOpeningElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public List<IFCRelFillsElement>? _HasFillings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOpticalMaterialProperties
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
	/// <summary>
	public interface IFCOrderAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCIdentifier? _TaskId {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
		public BOOLEAN? _IsMilestone {get; }
		public INTEGER? _Priority {get; }
		public IFCIdentifier? _ActionID {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOrganization
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCActorRole>? _Roles {get; set;}
		public List<IFCAddress>? _Addresses {get; set;}
		public List<IFCOrganizationRelationship>? _IsRelatedBy {get; }
		public List<IFCOrganizationRelationship>? _Relates {get; }
		public List<IFCPersonAndOrganization>? _Engages {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOrganizationRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCOrganization? _RelatingOrganization {get; set;}
		public List<IFCOrganization>? _RelatedOrganizations {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCOrientedEdge
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCEdge? _EdgeElement {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOutletType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCOutletTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOwnerHistory
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
	/// <summary>
	public interface IFCParameterizedProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPath
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCOrientedEdge>? _EdgeList {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPerformanceHistory
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCLabel? _LifeCyclePhase {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPermeableCoveringProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCPermeableCoveringOperationEnum? _OperationType {get; }
		public IFCWindowPanelPositionEnum? _PanelPosition {get; }
		public IFCPositiveLengthMeasure? _FrameDepth {get; }
		public IFCPositiveLengthMeasure? _FrameThickness {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPermit
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPerson
	{
		public IFCLabel? _FamilyName {get; set;}
		public IFCLabel? _GivenName {get; set;}
		public List<IFCLabel>? _MiddleNames {get; set;}
		public List<IFCLabel>? _PrefixTitles {get; set;}
		public List<IFCLabel>? _SuffixTitles {get; set;}
		public List<IFCActorRole>? _Roles {get; set;}
		public List<IFCAddress>? _Addresses {get; set;}
		public List<IFCPersonAndOrganization>? _EngagedIn {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPersonAndOrganization
	{
		public IFCPerson? _ThePerson {get; set;}
		public IFCOrganization? _TheOrganization {get; set;}
		public List<IFCActorRole>? _Roles {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPhysicalComplexQuantity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public List<IFCPhysicalQuantity>? _HasQuantities {get; }
		public IFCLabel? _Discrimination {get; }
		public IFCLabel? _Quality {get; }
		public IFCLabel? _Usage {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPhysicalQuantity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPhysicalSimpleQuantity
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPile
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPileTypeEnum? _PredefinedType {get; }
		public IFCPileConstructionEnum? _ConstructionType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPipeFittingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPipeFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPipeSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPipeSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPixelTexture
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
		public IFCInteger? _Width {get; set;}
		public IFCInteger? _Height {get; set;}
		public IFCInteger? _ColourComponents {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPlacement
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlanarBox
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _SizeInX {get; }
		public IFCLengthMeasure? _SizeInY {get; }
		public IFCAxis2Placement? _Placement {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlanarExtent
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _SizeInX {get; }
		public IFCLengthMeasure? _SizeInY {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlane
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlateType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPlateTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPoint
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPointOnCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCParameterValue? _PointParameter {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPointOnSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCParameterValue? _PointParameterU {get; }
		public IFCParameterValue? _PointParameterV {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPolyLoop
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCCartesianPoint>? _Polygon {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPolygonalBoundedHalfSpace
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BaseSurface {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCBoundedCurve? _PolygonalBoundary {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPolyline
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCartesianPoint>? _Points {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPort
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsPorts>? _ConnectedFrom {get; }
		public List<IFCRelConnectsPorts>? _ConnectedTo {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPostalAddress
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public List<IFCPerson>? _OfPerson {get; }
		public List<IFCOrganization>? _OfOrganization {get; }
		public IFCLabel? _InternalLocation {get; }
		public List<IFCLabel>? _AddressLines {get; }
		public IFCLabel? _PostalBox {get; }
		public IFCLabel? _Town {get; }
		public IFCLabel? _Region {get; }
		public IFCLabel? _PostalCode {get; }
		public IFCLabel? _Country {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedColour
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedCurveFont
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedDimensionSymbol
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedItem
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedPointMarkerSymbol
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedSymbol
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedTerminatorSymbol
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedTextFont
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationLayerAssignment
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCLayeredItem>? _AssignedItems {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationLayerWithStyle
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCLayeredItem>? _AssignedItems {get; set;}
		public IFCIdentifier? _Identifier {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationStyle
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationStyleAssignment
	{
		public List<IFCPresentationStyleSelect>? _Styles {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProcedure
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProcess
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProduct
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProductDefinitionShape
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRepresentation>? _Representations {get; set;}
		public List<IFCProduct>? _ShapeOfProduct {get; }
		public List<IFCShapeAspect>? _HasShapeAspects {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProductRepresentation
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRepresentation>? _Representations {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProductsOfCombustionProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCSpecificHeatCapacityMeasure? _SpecificHeatCapacity {get; set;}
		public IFCPositiveRatioMeasure? _N20Content {get; set;}
		public IFCPositiveRatioMeasure? _COContent {get; set;}
		public IFCPositiveRatioMeasure? _CO2Content {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProfileProperties
	{
		public IFCProfileDef? _ProfileDefinition {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCProject
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public List<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectOrder
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCProjectOrderTypeEnum? _PredefinedType {get; }
		public IFCLabel? _Status {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectOrderRecord
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCRelAssignsToProjectOrder>? _Records {get; }
		public IFCProjectOrderRecordTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectionCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectionElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelProjectsElement? _ProjectsElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProperty
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyBoundedValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCValue? _UpperBoundValue {get; }
		public IFCValue? _LowerBoundValue {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyConstraintRelationship
	{
		public IFCConstraint? _RelatingConstraint {get; set;}
		public List<IFCProperty>? _RelatedProperties {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyDefinition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyDependencyRelationship
	{
		public IFCProperty? _DependingProperty {get; set;}
		public IFCProperty? _DependantProperty {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCText? _Expression {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyEnumeratedValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public List<IFCValue>? _EnumerationValues {get; }
		public IFCPropertyEnumeration? _EnumerationReference {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyEnumeration
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCValue>? _EnumerationValues {get; set;}
		public IFCUnit? _Unit {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyListValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public List<IFCValue>? _ListValues {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyReferenceValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCObjectReferenceSelect? _PropertyReference {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySet
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public List<IFCProperty>? _HasProperties {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySetDefinition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySingleValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public IFCValue? _NominalValue {get; }
		public IFCUnit? _Unit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyTableValue
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
		public List<IFCValue>? _DefiningValues {get; }
		public List<IFCValue>? _DefinedValues {get; }
		public IFCText? _Expression {get; }
		public IFCUnit? _DefiningUnit {get; }
		public IFCUnit? _DefinedUnit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProtectiveDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCProtectiveDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProxy
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCObjectTypeEnum? _ProxyType {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPumpType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPumpTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityArea
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCAreaMeasure? _AreaValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityCount
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCCountMeasure? _CountValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityLength
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCLengthMeasure? _LengthValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityTime
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCTimeMeasure? _TimeValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityVolume
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCVolumeMeasure? _VolumeValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityWeight
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCMassMeasure? _WeightValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRadiusDimension
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRailing
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRailingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRailingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRailingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRamp
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRampFlight
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRampFlightType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRampFlightTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRationalBezierCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public INTEGER? _Degree {get; }
		public List<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public LOGICAL? _ClosedCurve {get; }
		public LOGICAL? _SelfIntersect {get; }
		public List<IFCCartesianPoint>? _ControlPoints {get; }
		public INTEGER? _UpperIndexOnControlPoints {get; }
		public List<REAL>? _WeightsData {get; }
		public List<REAL>? _Weights {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRectangleHollowProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
		public IFCPositiveLengthMeasure? _WallThickness {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRectangleProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRectangularPyramid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _XLength {get; }
		public IFCPositiveLengthMeasure? _YLength {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRectangularTrimmedSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCParameterValue? _U1 {get; }
		public IFCParameterValue? _V1 {get; }
		public IFCParameterValue? _U2 {get; }
		public IFCParameterValue? _V2 {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReferencesValueDocument
	{
		public IFCDocumentSelect? _ReferencedDocument {get; set;}
		public List<IFCAppliedValue>? _ReferencingValues {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRegularTimeSeries
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
		public IFCTimeMeasure? _TimeStep {get; set;}
		public List<IFCTimeSeriesValue>? _Values {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcementBarProperties
	{
		public IFCAreaMeasure? _TotalCrossSectionArea {get; set;}
		public IFCLabel? _SteelGrade {get; set;}
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; set;}
		public IFCLengthMeasure? _EffectiveDepth {get; set;}
		public IFCPositiveLengthMeasure? _NominalBarDiameter {get; set;}
		public IFCCountMeasure? _BarCount {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcementDefinitionProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCLabel? _DefinitionType {get; }
		public List<IFCSectionReinforcementProperties>? _ReinforcementSectionDefinitions {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingBar
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _BarLength {get; }
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingMesh
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
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
	/// <summary>
	public interface IFCRelAggregates
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCObjectDefinition? _RelatingObject {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssigns
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsTasks
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
		public IFCScheduleTimeControl? _TimeForTask {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToActor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCActor? _RelatingActor {get; set;}
		public IFCActorRole? _ActingRole {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToControl
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToGroup
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCGroup? _RelatingGroup {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToProcess
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCMeasureWithUnit? _QuantityInProcess {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToProduct
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToProjectOrder
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociates
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesAppliedValue
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRoot>? _RelatedObjects {get; set;}
		public IFCAppliedValue? _RelatingAppliedValue {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesApproval
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCApproval? _RelatingApproval {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesClassification
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesConstraint
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _Intent {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesDocument
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCDocumentSelect? _RelatingDocument {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesLibrary
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLibrarySelect? _RelatingLibrary {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesMaterial
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCMaterialSelect? _RelatingMaterial {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesProfileProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRoot>? _RelatedObjects {get; set;}
		public IFCProfileProperties? _RelatingProfileProperties {get; set;}
		public IFCShapeAspect? _ProfileSectionLocation {get; set;}
		public IFCOrientationSelect? _ProfileOrientation {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelConnects
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelConnectsElements
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
	/// <summary>
	public interface IFCRelConnectsPathElements
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
	/// <summary>
	public interface IFCRelConnectsPortToElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCPort? _RelatingPort {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelConnectsPorts
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
	/// <summary>
	public interface IFCRelConnectsStructuralActivity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCStructuralActivityAssignmentSelect? _RelatingElement {get; set;}
		public IFCStructuralActivity? _RelatedStructuralActivity {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelConnectsStructuralElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCStructuralMember? _RelatedStructuralMember {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelConnectsStructuralMember
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
	/// <summary>
	public interface IFCRelConnectsWithEccentricity
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
	/// <summary>
	public interface IFCRelConnectsWithRealizingElements
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _ConnectionGeometry {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCElement? _RelatedElement {get; set;}
		public List<IFCElement>? _RealizingElements {get; set;}
		public IFCLabel? _ConnectionType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelContainedInSpatialStructure
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCProduct>? _RelatedElements {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelCoversBldgElements
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingBuildingElement {get; set;}
		public List<IFCCovering>? _RelatedCoverings {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelCoversSpaces
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCCovering>? _RelatedCoverings {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDecomposes
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDefines
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDefinesByProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDefinesByType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObject>? _RelatedObjects {get; set;}
		public IFCTypeObject? _RelatingType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelFillsElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCOpeningElement? _RelatingOpeningElement {get; set;}
		public IFCElement? _RelatedBuildingElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelFlowControlElements
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCDistributionControlElement>? _RelatedControlElements {get; set;}
		public IFCDistributionFlowElement? _RelatingFlowElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelInteractionRequirements
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
	/// <summary>
	public interface IFCRelNests
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCObjectDefinition? _RelatingObject {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelOccupiesSpaces
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCActor? _RelatingActor {get; set;}
		public IFCActorRole? _ActingRole {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelOverridesProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObject>? _RelatedObjects {get; set;}
		public IFCPropertySetDefinition? _RelatingPropertyDefinition {get; set;}
		public List<IFCProperty>? _OverridingProperties {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelProjectsElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public IFCFeatureElementAddition? _RelatedFeatureElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelReferencedInSpatialStructure
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelSchedulesCostItems
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCObjectTypeEnum? _RelatedObjectsType {get; set;}
		public IFCControl? _RelatingControl {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelSequence
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
	/// <summary>
	public interface IFCRelServicesBuildings
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCSystem? _RelatingSystem {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelSpaceBoundary
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
	/// <summary>
	public interface IFCRelVoidsElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingBuildingElement {get; set;}
		public IFCFeatureElementSubtraction? _RelatedOpeningElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelationship
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelaxation
	{
		public IFCNormalisedRatioMeasure? _RelaxationValue {get; set;}
		public IFCNormalisedRatioMeasure? _InitialStress {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRepresentation
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRepresentationContext
	{
		public IFCLabel? _ContextIdentifier {get; set;}
		public IFCLabel? _ContextType {get; set;}
		public List<IFCRepresentation>? _RepresentationsInContext {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRepresentationItem
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRepresentationMap
	{
		public IFCAxis2Placement? _MappingOrigin {get; set;}
		public IFCRepresentation? _MappedRepresentation {get; set;}
		public List<IFCMappedItem>? _MapUsage {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRevolvedAreaSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCAxis1Placement? _Axis {get; }
		public IFCPlaneAngleMeasure? _Angle {get; }
		public IFCLine? _AxisLine {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRibPlateProfileProperties
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
	/// <summary>
	public interface IFCRightCircularCone
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
		public IFCPositiveLengthMeasure? _BottomRadius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRightCircularCylinder
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Height {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRoof
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRoot
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRoundedEdgeFeature
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelConnectsStructuralElement>? _HasStructuralMember {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCPositiveLengthMeasure? _FeatureLength {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRoundedRectangleProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public IFCAxis2Placement2D? _Position {get; set;}
		public IFCPositiveLengthMeasure? _XDim {get; set;}
		public IFCPositiveLengthMeasure? _YDim {get; set;}
		public IFCPositiveLengthMeasure? _RoundingRadius {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSIUnit
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCSIPrefix? _Prefix {get; set;}
		public IFCSIUnitName? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSanitaryTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSanitaryTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCScheduleTimeControl
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
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
	/// <summary>
	public interface IFCSectionProperties
	{
		public IFCSectionTypeEnum? _SectionType {get; set;}
		public IFCProfileDef? _StartProfile {get; set;}
		public IFCProfileDef? _EndProfile {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionReinforcementProperties
	{
		public IFCLengthMeasure? _LongitudinalStartPosition {get; set;}
		public IFCLengthMeasure? _LongitudinalEndPosition {get; set;}
		public IFCLengthMeasure? _TransversePosition {get; set;}
		public IFCReinforcingBarRoleEnum? _ReinforcementRole {get; set;}
		public IFCSectionProperties? _SectionDefinition {get; set;}
		public List<IFCReinforcementBarProperties>? _CrossSectionReinforcementDefinitions {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionedSpine
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCompositeCurve? _SpineCurve {get; }
		public List<IFCProfileDef>? _CrossSections {get; }
		public List<IFCAxis2Placement3D>? _CrossSectionPositions {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSensorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSensorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCServiceLife
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCServiceLifeTypeEnum? _ServiceLifeType {get; }
		public IFCTimeMeasure? _ServiceLifeDuration {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCServiceLifeFactor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCServiceLifeFactorTypeEnum? _PredefinedType {get; }
		public IFCMeasureValue? _UpperValue {get; }
		public IFCMeasureValue? _MostUsedValue {get; }
		public IFCMeasureValue? _LowerValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCShapeAspect
	{
		public List<IFCShapeModel>? _ShapeRepresentations {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCShapeModel
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public List<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCShapeRepresentation
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public List<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCShellBasedSurfaceModel
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCShell>? _SbsmBoundary {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSimpleProperty
	{
		public IFCIdentifier? _Name {get; set;}
		public List<IFCPropertyDependencyRelationship>? _PropertyForDependance {get; }
		public List<IFCPropertyDependencyRelationship>? _PropertyDependsOn {get; }
		public List<IFCComplexProperty>? _PartOfComplex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSite
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCCompoundPlaneAngleMeasure? _RefLatitude {get; }
		public IFCCompoundPlaneAngleMeasure? _RefLongitude {get; }
		public IFCLengthMeasure? _RefElevation {get; }
		public IFCLabel? _LandTitleNumber {get; }
		public IFCPostalAddress? _SiteAddress {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSlab
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSlabType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSlippageConnectionCondition
	{
		public IFCLabel? _Name {get; set;}
		public IFCLengthMeasure? _SlippageX {get; set;}
		public IFCLengthMeasure? _SlippageY {get; set;}
		public IFCLengthMeasure? _SlippageZ {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSolidModel
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCBoolean? _IsAttenuating {get; }
		public IFCSoundScaleEnum? _SoundScale {get; }
		public List<IFCSoundValue>? _SoundValues {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSoundValue
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCTimeSeries? _SoundLevelTimeSeries {get; }
		public IFCFrequencyMeasure? _Frequency {get; }
		public IFCDerivedMeasureValue? _SoundLevelSingleValue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpace
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public IFCLengthMeasure? _ElevationWithFlooring {get; }
		public List<IFCRelCoversSpaces>? _HasCoverings {get; }
		public List<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceHeaterType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpaceHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceProgram
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public IFCIdentifier? _SpaceProgramIdentifier {get; }
		public IFCAreaMeasure? _MaxRequiredArea {get; }
		public IFCAreaMeasure? _MinRequiredArea {get; }
		public IFCSpatialStructureElement? _RequestedLocation {get; }
		public IFCAreaMeasure? _StandardRequiredArea {get; }
		public List<IFCRelInteractionRequirements>? _HasInteractionReqsFrom {get; }
		public List<IFCRelInteractionRequirements>? _HasInteractionReqsTo {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceThermalLoadProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCRelDefinesByProperties>? _PropertyDefinitionOf {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
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
	/// <summary>
	public interface IFCSpaceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpaceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialStructureElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialStructureElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSphere
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStackTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStackTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStair
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStairFlight
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _RiserHeight {get; }
		public IFCPositiveLengthMeasure? _TreadLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStairFlightType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStairFlightTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralActivity
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralAnalysisModel
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCAnalysisModelTypeEnum? _PredefinedType {get; }
		public IFCAxis2Placement3D? _OrientationOf2DPlane {get; }
		public List<IFCStructuralLoadGroup>? _LoadedBy {get; }
		public List<IFCStructuralResultGroup>? _HasResults {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralConnection
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralConnectionCondition
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveConnection
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveMember
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveMemberVarying
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralItem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLinearAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLinearActionVarying
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCRelConnectsStructuralActivity? _AssignedToStructuralItem {get; }
		public BOOLEAN? _DestabilizingLoad {get; }
		public IFCStructuralReaction? _CausedBy {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCShapeAspect? _VaryingAppliedLoadLocation {get; }
		public List<IFCStructuralLoad>? _SubsequentAppliedLoads {get; }
		public List<IFCStructuralLoad>? _VaryingAppliedLoads {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoad
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadGroup
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLoadGroupTypeEnum? _PredefinedType {get; }
		public IFCActionTypeEnum? _ActionType {get; }
		public IFCActionSourceTypeEnum? _ActionSource {get; }
		public IFCRatioMeasure? _Coefficient {get; }
		public IFCLabel? _Purpose {get; }
		public List<IFCStructuralResultGroup>? _SourceOfResultGroup {get; }
		public List<IFCStructuralAnalysisModel>? _LoadGroupFor {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadLinearForce
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
	/// <summary>
	public interface IFCStructuralLoadPlanarForce
	{
		public IFCLabel? _Name {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceX {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceY {get; set;}
		public IFCPlanarForceMeasure? _PlanarForceZ {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadSingleDisplacement
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
	/// <summary>
	public interface IFCStructuralLoadSingleDisplacementDistortion
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
	/// <summary>
	public interface IFCStructuralLoadSingleForce
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
	/// <summary>
	public interface IFCStructuralLoadSingleForceWarping
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
	/// <summary>
	public interface IFCStructuralLoadStatic
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadTemperature
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralMember
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralPlanarAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralPlanarActionVarying
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public IFCRelConnectsStructuralActivity? _AssignedToStructuralItem {get; }
		public BOOLEAN? _DestabilizingLoad {get; }
		public IFCStructuralReaction? _CausedBy {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCShapeAspect? _VaryingAppliedLoadLocation {get; }
		public List<IFCStructuralLoad>? _SubsequentAppliedLoads {get; }
		public List<IFCStructuralLoad>? _VaryingAppliedLoads {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralPointAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralPointConnection
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralPointReaction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralProfileProperties
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
	/// <summary>
	public interface IFCStructuralReaction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralResultGroup
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCAnalysisTheoryTypeEnum? _TheoryType {get; }
		public IFCStructuralLoadGroup? _ResultForLoadGroup {get; }
		public List<IFCStructuralAnalysisModel>? _ResultGroupFor {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralSteelProfileProperties
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
	/// <summary>
	public interface IFCStructuralSurfaceConnection
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public IFCBoundaryCondition? _AppliedCondition {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectsStructuralMembers {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralSurfaceMember
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
		public IFCPositiveLengthMeasure? _Thickness {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralSurfaceMemberVarying
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedStructuralActivity {get; }
		public List<IFCRelConnectsStructuralMember>? _ConnectedBy {get; }
		public IFCPositiveLengthMeasure? _Thickness {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuredDimensionCallout
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCDraughtingCalloutElement>? _Contents {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedFromCallout {get; }
		public List<IFCDraughtingCalloutRelationship>? _IsRelatedToCallout {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStyleModel
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStyledItem
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public IFCLabel? _Name {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStyledRepresentation
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSubContractResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSubedge
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _EdgeStart {get; }
		public IFCVertex? _EdgeEnd {get; }
		public IFCEdge? _ParentEdge {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceCurveSweptAreaSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCSurface? _ReferenceSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceOfLinearExtrusion
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCLengthMeasure? _Depth {get; }
		public IFCVector? _ExtrusionAxis {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceOfRevolution
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis1Placement? _AxisPosition {get; }
		public IFCLine? _AxisLine {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyle
	{
		public IFCLabel? _Name {get; set;}
		public IFCSurfaceSide? _Side {get; set;}
		public List<IFCSurfaceStyleElementSelect>? _Styles {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyleLighting
	{
		public IFCColourRgb? _DiffuseTransmissionColour {get; set;}
		public IFCColourRgb? _DiffuseReflectionColour {get; set;}
		public IFCColourRgb? _TransmissionColour {get; set;}
		public IFCColourRgb? _ReflectanceColour {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyleRefraction
	{
		public IFCReal? _RefractionIndex {get; set;}
		public IFCReal? _DispersionFactor {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyleRendering
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
	/// <summary>
	public interface IFCSurfaceStyleShading
	{
		public IFCColourRgb? _SurfaceColour {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceStyleWithTextures
	{
		public List<IFCSurfaceTexture>? _Textures {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceTexture
	{
		public IFCCartesianTransformationOperator2D? _TextureTransform {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSweptAreaSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSweptDiskSolid
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCPositiveLengthMeasure? _InnerRadius {get; }
		public IFCParameterValue? _StartParam {get; }
		public IFCParameterValue? _EndParam {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSweptSurface
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCProfileDef? _SweptCurve {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSwitchingDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSwitchingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSymbolStyle
	{
		public IFCLabel? _Name {get; set;}
		public IFCSymbolStyleSelect? _StyleOfSymbol {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSystem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSystemFurnitureElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTShapeProfileDef
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
	/// <summary>
	public interface IFCTable
	{
		public List<IFCTableRow>? _Rows {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTableRow
	{
		public List<IFCValue>? _RowCells {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTankType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTankTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTask
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
		public IFCLabel? _Status {get; }
		public IFCLabel? _WorkMethod {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTelecomAddress
	{
		public IFCAddressTypeEnum? _Purpose {get; set;}
		public IFCText? _Description {get; set;}
		public IFCLabel? _UserDefinedPurpose {get; set;}
		public List<IFCPerson>? _OfPerson {get; }
		public List<IFCOrganization>? _OfOrganization {get; }
		public List<IFCLabel>? _TelephoneNumbers {get; }
		public List<IFCLabel>? _FacsimileNumbers {get; }
		public IFCLabel? _PagerNumber {get; }
		public List<IFCLabel>? _ElectronicMailAddresses {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTendon
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
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
	/// <summary>
	public interface IFCTendonAnchor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCLabel? _SteelGrade {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTerminatorSymbol
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCRepresentationItem? _Item {get; }
		public List<IFCPresentationStyleAssignment>? _Styles {get; }
		public IFCLabel? _Name {get; }
		public IFCAnnotationCurveOccurrence? _AnnotatedCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextLiteral
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPresentableText? _Literal {get; }
		public IFCAxis2Placement? _Placement {get; }
		public IFCTextPath? _Path {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextLiteralWithExtent
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPresentableText? _Literal {get; }
		public IFCAxis2Placement? _Placement {get; }
		public IFCTextPath? _Path {get; }
		public IFCPlanarExtent? _Extent {get; }
		public IFCBoxAlignment? _BoxAlignment {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextStyle
	{
		public IFCLabel? _Name {get; set;}
		public IFCTextFontSelect? _TextFontStyle {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextStyleFontModel
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCTextFontName>? _FontFamily {get; set;}
		public IFCFontStyle? _FontStyle {get; set;}
		public IFCFontVariant? _FontVariant {get; set;}
		public IFCFontWeight? _FontWeight {get; set;}
		public IFCSizeSelect? _FontSize {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextStyleForDefinedFont
	{
		public IFCColour? _Colour {get; set;}
		public IFCColour? _BackgroundColour {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextStyleTextModel
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
	/// <summary>
	public interface IFCTextStyleWithBoxCharacteristics
	{
		public IFCPositiveLengthMeasure? _BoxHeight {get; set;}
		public IFCPositiveLengthMeasure? _BoxWidth {get; set;}
		public IFCPlaneAngleMeasure? _BoxSlantAngle {get; set;}
		public IFCPlaneAngleMeasure? _BoxRotateAngle {get; set;}
		public IFCSizeSelect? _CharacterSpacing {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureCoordinate
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureCoordinateGenerator
	{
		public IFCLabel? _Mode {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureVertex
	{
		public List<IFCParameterValue>? _Coordinates {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCThermalMaterialProperties
	{
		public IFCMaterial? _Material {get; set;}
		public IFCSpecificHeatCapacityMeasure? _SpecificHeatCapacity {get; set;}
		public IFCThermodynamicTemperatureMeasure? _BoilingPoint {get; set;}
		public IFCThermodynamicTemperatureMeasure? _FreezingPoint {get; set;}
		public IFCThermalConductivityMeasure? _ThermalConductivity {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeSeries
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCTimeSeriesDataTypeEnum? _TimeSeriesDataType {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCUnit? _Unit {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeSeriesReferenceRelationship
	{
		public IFCTimeSeries? _ReferencedTimeSeries {get; set;}
		public List<IFCDocumentSelect>? _TimeSeriesReferences {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeSeriesSchedule
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelDecomposes>? _IsDecomposedBy {get; }
		public List<IFCRelDecomposes>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefines>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCDateTimeSelect>? _ApplicableDates {get; }
		public IFCTimeSeriesScheduleTypeEnum? _TimeSeriesScheduleType {get; }
		public IFCTimeSeries? _TimeSeries {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTimeSeriesValue
	{
		public List<IFCValue>? _ListValues {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTopologicalRepresentationItem
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTopologyRepresentation
	{
		public IFCRepresentationContext? _ContextOfItems {get; set;}
		public IFCLabel? _RepresentationIdentifier {get; set;}
		public IFCLabel? _RepresentationType {get; set;}
		public List<IFCRepresentationItem>? _Items {get; set;}
		public List<IFCRepresentationMap>? _RepresentationMap {get; }
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCProductRepresentation>? _OfProductRepresentation {get; }
		public List<IFCShapeAspect>? _OfShapeAspect {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransformerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTransformerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransportElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransportElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTransportElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTrapeziumProfileDef
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
	/// <summary>
	public interface IFCTrimmedCurve
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public List<IFCTrimmingSelect>? _Trim1 {get; }
		public List<IFCTrimmingSelect>? _Trim2 {get; }
		public IFCTrimmingPreference? _MasterRepresentation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTubeBundleType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTubeBundleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTwoDirectionRepeatFactor
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignments {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVector? _RepeatFactor {get; }
		public IFCVector? _SecondRepeatFactor {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTypeObject
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTypeProduct
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCUShapeProfileDef
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
	/// <summary>
	public interface IFCUnitAssignment
	{
		public List<IFCUnit>? _Units {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitaryEquipmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCUnitaryEquipmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCValveType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCValveTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVector
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _Orientation {get; }
		public IFCLengthMeasure? _Magnitude {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVertex
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVertexBasedTextureMap
	{
		public List<IFCTextureVertex>? _TextureVertices {get; set;}
		public List<IFCCartesianPoint>? _TexturePoints {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCVertexLoop
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCVertex? _LoopVertex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVertexPoint
	{
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPoint? _VertexGeometry {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVibrationIsolatorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVibrationIsolatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVirtualElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVirtualGridIntersection
	{
		public List<IFCGridAxis>? _IntersectingAxes {get; set;}
		public List<IFCLengthMeasure>? _OffsetDistances {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCWall
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWallStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWallType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWasteTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWasteTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWaterProperties
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
	/// <summary>
	public interface IFCWindow
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowLiningProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCPositiveLengthMeasure? _LiningDepth {get; }
		public IFCNormalisedRatioMeasure? _FirstTransomOffset {get; }
		public IFCNormalisedRatioMeasure? _SecondTransomOffset {get; }
		public IFCNormalisedRatioMeasure? _FirstMullionOffset {get; }
		public IFCNormalisedRatioMeasure? _SecondMullionOffset {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowPanelProperties
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public IFCWindowPanelOperationEnum? _OperationType {get; }
		public IFCWindowPanelPositionEnum? _PanelPosition {get; }
		public IFCPositiveLengthMeasure? _FrameDepth {get; }
		public IFCPositiveLengthMeasure? _FrameThickness {get; }
		public IFCShapeAspect? _ShapeAspectStyle {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowStyle
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public IFCWindowStyleConstructionEnum? _ConstructionType {get; }
		public IFCWindowStyleOperationEnum? _OperationType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkControl
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkPlan
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkSchedule
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCPerson>? _Creators {get; }
		public IFCLabel? _Purpose {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCZShapeProfileDef
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
	/// <summary>
	public interface IFCZone
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCActuator
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCActuatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAdvancedBrep
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAdvancedBrepWithVoids
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCClosedShell? _Outer {get; }
		public List<IFCClosedShell>? _Voids {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAdvancedFace
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCFaceBound>? _Bounds {get; }
		public List<IFCTextureMap>? _HasTextureMaps {get; }
		public IFCSurface? _FaceSurface {get; }
		public IFCBoolean? _SameSense {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirTerminalBox
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirTerminalBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAirToAirHeatRecovery
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAirToAirHeatRecoveryTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlarm
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCAlarmTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAudioVisualAppliance
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCAudioVisualApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAudioVisualApplianceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCAudioVisualApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBSplineCurveWithKnots
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _Degree {get; }
		public List<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UpperIndexOnControlPoints {get; }
		public List<IFCCartesianPoint>? _ControlPoints {get; }
		public List<IFCInteger>? _KnotMultiplicities {get; }
		public List<IFCParameterValue>? _Knots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _UpperIndexOnKnots {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBSplineSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public List<List<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public List<List<IFCCartesianPoint>>? _ControlPoints {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBSplineSurfaceWithKnots
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public List<List<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public List<List<IFCCartesianPoint>>? _ControlPoints {get; }
		public List<IFCInteger>? _UMultiplicities {get; }
		public List<IFCInteger>? _VMultiplicities {get; }
		public List<IFCParameterValue>? _UKnots {get; }
		public List<IFCParameterValue>? _VKnots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _KnotVUpper {get; }
		public IFCInteger? _KnotUUpper {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBeamStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoiler
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCBoilerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBoundaryCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingElementPartType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBuildingElementPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuildingSystem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCBuildingSystemTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBurner
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCBurnerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBurnerType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBurnerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableCarrierFitting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableCarrierFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableCarrierSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableCarrierSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableFitting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableFittingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCableFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCableSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCableSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianPointList
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianPointList2D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<List<IFCLengthMeasure>>? _CoordList {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCartesianPointList3D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<List<IFCLengthMeasure>>? _CoordList {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCChiller
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCChillerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCChimney
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCChimneyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCChimneyType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCChimneyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCivilElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCivilElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoil
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCColourRgbList
	{
		public List<List<IFCNormalisedRatioMeasure>>? _ColourList {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCColumnStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCColumnTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCommunicationsAppliance
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCommunicationsApplianceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCComplexPropertyTemplate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public List<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
		public IFCLabel? _UsageName {get; }
		public IFCComplexPropertyTemplateTypeEnum? _TemplateType {get; }
		public List<IFCPropertyTemplate>? _HasPropertyTemplates {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCompositeCurveOnSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCompressor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCompressorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCondenser
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCondenserTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConnectionVolumeGeometry
	{
		public IFCSolidOrShell? _VolumeOnRelatingElement {get; set;}
		public IFCSolidOrShell? _VolumeOnRelatedElement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionEquipmentResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionEquipmentResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionMaterialResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionMaterialResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionProductResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCConstructionProductResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConstructionResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCContext
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public List<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelDeclares>? _Declares {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCController
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCControllerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConversionBasedUnitWithOffset
	{
		public IFCDimensionalExponents? _Dimensions {get; set;}
		public IFCUnitEnum? _UnitType {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCMeasureWithUnit? _ConversionFactor {get; set;}
		public List<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public IFCReal? _ConversionOffset {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCooledBeam
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCooledBeamTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoolingTower
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCCoolingTowerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCoordinateOperation
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCCoordinateReferenceSystem
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public List<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCrewResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCCrewResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveBoundedSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCSurface? _BasisSurface {get; }
		public List<IFCBoundaryCurve>? _Boundaries {get; }
		public IFCBoolean? _ImplicitOuter {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCylindricalSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDamper
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionCircuit
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCLabel? _LongName {get; }
		public IFCDistributionSystemEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionSystem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public IFCLabel? _LongName {get; }
		public IFCDistributionSystemEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
		public IFCDoorTypeEnum? _PredefinedType {get; }
		public IFCDoorTypeOperationEnum? _OperationType {get; }
		public IFCLabel? _UserDefinedOperationType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDoorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDoorTypeEnum? _PredefinedType {get; }
		public IFCDoorTypeOperationEnum? _OperationType {get; }
		public IFCBoolean? _ParameterTakesPrecedence {get; }
		public IFCLabel? _UserDefinedOperationType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctFitting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDuctSilencer
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDuctSilencerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricAppliance
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricDistributionBoard
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricDistributionBoardType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricFlowStorageDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricFlowStorageDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricGenerator
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricGeneratorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricMotor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricMotorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricTimeControl
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricTimeControlTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElementAssemblyType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElementAssemblyTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEngine
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEngineTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEngineType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCEngineTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEvaporativeCooler
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEvaporativeCoolerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEvaporator
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCEvaporatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEvent
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public List<IFCRelSequence>? _IsPredecessorTo {get; }
		public List<IFCRelSequence>? _IsSuccessorFrom {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCEventTypeEnum? _PredefinedType {get; }
		public IFCEventTriggerTypeEnum? _EventTriggerType {get; }
		public IFCLabel? _UserDefinedEventTriggerType {get; }
		public IFCEventTime? _EventOccurenceTime {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEventTime
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
	/// <summary>
	public interface IFCEventType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCEventTypeEnum? _PredefinedType {get; }
		public IFCEventTriggerTypeEnum? _EventTriggerType {get; }
		public IFCLabel? _UserDefinedEventTriggerType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCExtendedProperties
	{
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public IFCIdentifier? _Name {get; }
		public IFCText? _Description {get; }
		public List<IFCProperty>? _Properties {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalInformation
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalReferenceRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCExternalReference? _RelatingReference {get; set;}
		public List<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalSpatialElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCExternalSpatialElementTypeEnum? _PredefinedType {get; }
		public List<IFCRelSpaceBoundary>? _BoundedBy {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCExternalSpatialStructureElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCExtrudedAreaSolidTapered
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCDirection? _ExtrudedDirection {get; }
		public IFCPositiveLengthMeasure? _Depth {get; }
		public IFCProfileDef? _EndSweptArea {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFan
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFanTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFilter
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFilterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFireSuppressionTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFireSuppressionTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFixedReferenceSweptAreaSolid
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCDirection? _FixedReference {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowInstrument
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCFlowInstrumentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFlowMeter
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCFlowMeterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFootingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCFootingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFurniture
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCFurnitureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeographicElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCGeographicElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeographicElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCGeographicElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHeatExchanger
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCHeatExchangerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCHumidifier
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCHumidifierTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedColourMap
	{
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCNormalisedRatioMeasure? _Opacity {get; set;}
		public IFCColourRgbList? _Colours {get; set;}
		public List<IFCPositiveInteger>? _ColourIndex {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedPolyCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPointList? _Points {get; }
		public List<IFCSegmentIndexSelect>? _Segments {get; }
		public IFCBoolean? _SelfIntersect {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedPolygonalFace
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCPositiveInteger>? _CoordIndex {get; }
		public List<IFCPolygonalFaceSet>? _ToFaceSet {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedPolygonalFaceWithVoids
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCPositiveInteger>? _CoordIndex {get; }
		public List<IFCPolygonalFaceSet>? _ToFaceSet {get; }
		public List<List<IFCPositiveInteger>>? _InnerCoordIndices {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedTextureMap
	{
		public List<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedTriangleTextureMap
	{
		public List<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
		public List<List<IFCPositiveInteger>>? _TexCoordIndex {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCInterceptor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCInterceptorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCInterceptorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCInterceptorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIntersectionCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public List<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCJunctionBox
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCJunctionBoxTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLaborResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCLaborResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLagTime
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCTimeOrRatioSelect? _LagValue {get; set;}
		public IFCTaskDurationEnum? _DurationType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCLamp
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLightFixture
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLightFixtureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMapConversion
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
	/// <summary>
	public interface IFCMaterialConstituent
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCNormalisedRatioMeasure? _Fraction {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialConstituentSet? _ToMaterialConstituentSet {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialConstituentSet
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public List<IFCMaterialConstituent>? _MaterialConstituents {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialDefinition
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialLayerWithOffsets
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCMaterial? _Material {get; }
		public IFCNonNegativeLengthMeasure? _LayerThickness {get; }
		public IFCLogical? _IsVentilated {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCLabel? _Category {get; }
		public IFCInteger? _Priority {get; }
		public IFCMaterialLayerSet? _ToMaterialLayerSet {get; }
		public IFCLayerSetDirectionEnum? _OffsetDirection {get; }
		public List<IFCLengthMeasure>? _OffsetValues {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProfile
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCProfileDef? _Profile {get; }
		public IFCInteger? _Priority {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialProfileSet? _ToMaterialProfileSet {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProfileSet
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public List<IFCMaterialProfile>? _MaterialProfiles {get; }
		public IFCCompositeProfileDef? _CompositeProfile {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProfileSetUsage
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFCMaterialProfileSet? _ForProfileSet {get; }
		public IFCCardinalPointReference? _CardinalPoint {get; }
		public IFCPositiveLengthMeasure? _ReferenceExtent {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProfileSetUsageTapering
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public IFCMaterialProfileSet? _ForProfileSet {get; }
		public IFCCardinalPointReference? _CardinalPoint {get; }
		public IFCPositiveLengthMeasure? _ReferenceExtent {get; }
		public IFCMaterialProfileSet? _ForProfileEndSet {get; }
		public IFCCardinalPointReference? _CardinalEndPoint {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialProfileWithOffsets
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCMaterialProperties>? _HasProperties {get; }
		public IFCLabel? _Name {get; }
		public IFCText? _Description {get; }
		public IFCMaterial? _Material {get; }
		public IFCProfileDef? _Profile {get; }
		public IFCInteger? _Priority {get; }
		public IFCLabel? _Category {get; }
		public IFCMaterialProfileSet? _ToMaterialProfileSet {get; }
		public List<IFCLengthMeasure>? _OffsetValues {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCMaterial? _RelatingMaterial {get; set;}
		public List<IFCMaterial>? _RelatedMaterials {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCMaterialUsageDefinition
	{
		public List<IFCRelAssociatesMaterial>? _AssociatedTo {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMedicalDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMedicalDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMedicalDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMedicalDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMemberStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCMemberTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMirroredProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public List<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public List<IFCProfileProperties>? _HasProperties {get; }
		public IFCProfileDef? _ParentProfile {get; }
		public IFCCartesianTransformationOperator2D? _Operator {get; }
		public IFCLabel? _Label {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMotorConnection
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMotorConnectionTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOpeningStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCOpeningElementTypeEnum? _PredefinedType {get; }
		public List<IFCRelFillsElement>? _HasFillings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOuterBoundaryCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOutlet
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCOutletTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPcurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCSurface? _BasisSurface {get; }
		public IFCCurve? _ReferenceCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPileType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPileTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPipeFitting
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPipeFittingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPipeSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPipeSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPlateStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPlateTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPolygonalFaceSet
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCIndexedColourMap>? _HasColours {get; }
		public List<IFCIndexedTextureMap>? _HasTextures {get; }
		public IFCBoolean? _Closed {get; }
		public List<IFCIndexedPolygonalFace>? _Faces {get; }
		public List<IFCPositiveInteger>? _PnIndex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedProperties
	{
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPreDefinedPropertySet
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public List<IFCRelDefinesByTemplate>? _IsDefinedBy {get; }
		public List<IFCRelDefinesByProperties>? _DefinesOccurrence {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPresentationItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IFCProcedureType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCProcedureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectLibrary
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public IFCLabel? _LongName {get; }
		public IFCLabel? _Phase {get; }
		public List<IFCRepresentationContext>? _RepresentationContexts {get; }
		public IFCUnitAssignment? _UnitsInContext {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelDeclares>? _Declares {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProjectedCRS
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public IFCIdentifier? _VerticalDatum {get; set;}
		public List<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
		public IFCIdentifier? _MapProjection {get; }
		public IFCIdentifier? _MapZone {get; }
		public IFCNamedUnit? _MapUnit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyAbstraction
	{
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertySetTemplate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCPropertySetTemplateTypeEnum? _TemplateType {get; }
		public IFCIdentifier? _ApplicableEntity {get; }
		public List<IFCPropertyTemplate>? _HasPropertyTemplates {get; }
		public List<IFCRelDefinesByTemplate>? _Defines {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyTemplate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public List<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPropertyTemplateDefinition
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProtectiveDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCProtectiveDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProtectiveDeviceTrippingUnit
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCProtectiveDeviceTrippingUnitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCProtectiveDeviceTrippingUnitType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCProtectiveDeviceTrippingUnitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPump
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCPumpTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantitySet
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCTypeObject>? _DefinesType {get; }
		public List<IFCRelDefinesByTemplate>? _IsDefinedBy {get; }
		public List<IFCRelDefinesByProperties>? _DefinesOccurrence {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRampType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRampTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRationalBSplineCurveWithKnots
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _Degree {get; }
		public List<IFCCartesianPoint>? _ControlPointsList {get; }
		public IFCBSplineCurveForm? _CurveForm {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UpperIndexOnControlPoints {get; }
		public List<IFCCartesianPoint>? _ControlPoints {get; }
		public List<IFCInteger>? _KnotMultiplicities {get; }
		public List<IFCParameterValue>? _Knots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _UpperIndexOnKnots {get; }
		public List<IFCReal>? _WeightsData {get; }
		public List<IFCReal>? _Weights {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRationalBSplineSurfaceWithKnots
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCInteger? _UDegree {get; }
		public IFCInteger? _VDegree {get; }
		public List<List<IFCCartesianPoint>>? _ControlPointsList {get; }
		public IFCBSplineSurfaceForm? _SurfaceForm {get; }
		public IFCLogical? _UClosed {get; }
		public IFCLogical? _VClosed {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _UUpper {get; }
		public IFCInteger? _VUpper {get; }
		public List<List<IFCCartesianPoint>>? _ControlPoints {get; }
		public List<IFCInteger>? _UMultiplicities {get; }
		public List<IFCInteger>? _VMultiplicities {get; }
		public List<IFCParameterValue>? _UKnots {get; }
		public List<IFCParameterValue>? _VKnots {get; }
		public IFCKnotType? _KnotSpec {get; }
		public IFCInteger? _KnotVUpper {get; }
		public IFCInteger? _KnotUUpper {get; }
		public List<List<IFCReal>>? _WeightsData {get; }
		public List<List<IFCReal>>? _Weights {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRecurrencePattern
	{
		public IFCRecurrenceTypeEnum? _RecurrenceType {get; set;}
		public List<IFCDayInMonthNumber>? _DayComponent {get; set;}
		public List<IFCDayInWeekNumber>? _WeekdayComponent {get; set;}
		public List<IFCMonthInYearNumber>? _MonthComponent {get; set;}
		public IFCInteger? _Position {get; set;}
		public IFCInteger? _Interval {get; set;}
		public IFCInteger? _Occurrences {get; set;}
		public List<IFCTimePeriod>? _TimePeriods {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReference
	{
		public IFCIdentifier? _TypeIdentifier {get; set;}
		public IFCIdentifier? _AttributeIdentifier {get; set;}
		public IFCLabel? _InstanceName {get; set;}
		public List<IFCInteger>? _ListPositions {get; set;}
		public IFCReference? _InnerReference {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingBarType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCReinforcingBarTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _BarLength {get; }
		public IFCReinforcingBarSurfaceEnum? _BarSurface {get; }
		public IFCLabel? _BendingShapeCode {get; }
		public List<IFCBendingParameterSelect>? _BendingParameters {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcingMeshType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
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
		public List<IFCBendingParameterSelect>? _BendingParameters {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssignsToGroupByFactor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObjectDefinition>? _RelatedObjects {get; set;}
		public IFCGroup? _RelatingGroup {get; set;}
		public IFCRatioMeasure? _Factor {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDeclares
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCContext? _RelatingContext {get; set;}
		public List<IFCDefinitionSelect>? _RelatedDefinitions {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDefinesByObject
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCObject>? _RelatedObjects {get; set;}
		public IFCObject? _RelatingObject {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelDefinesByTemplate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCPropertySetDefinition>? _RelatedPropertySets {get; set;}
		public IFCPropertySetTemplate? _RelatingTemplate {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelInterferesElements
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConnectionGeometry? _InterferenceGeometry {get; set;}
		public IFCIdentifier? _InterferenceType {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelSpaceBoundary1stLevel
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
		public List<IFCRelSpaceBoundary1stLevel>? _InnerBoundaries {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRelSpaceBoundary2ndLevel
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
		public List<IFCRelSpaceBoundary1stLevel>? _InnerBoundaries {get; }
		public IFCRelSpaceBoundary2ndLevel? _CorrespondingBoundary {get; }
		public List<IFCRelSpaceBoundary2ndLevel>? _Corresponds {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReparametrisedCompositeCurveSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCBoolean? _SameSense {get; }
		public IFCCurve? _ParentCurve {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCompositeCurve>? _UsingCurves {get; }
		public IFCParameterValue? _ParamLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceApprovalRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
		public IFCApproval? _RelatingApproval {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceConstraintRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCConstraint? _RelatingConstraint {get; set;}
		public List<IFCResourceObjectSelect>? _RelatedResourceObjects {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceLevelRelationship
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCResourceTime
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
	/// <summary>
	public interface IFCRevolvedAreaSolidTapered
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCAxis1Placement? _Axis {get; }
		public IFCPlaneAngleMeasure? _Angle {get; }
		public IFCLine? _AxisLine {get; }
		public IFCProfileDef? _EndSweptArea {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRoofType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRoofTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSanitaryTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSanitaryTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSchedulingTime
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSeamCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public List<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSensor
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCSensorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCShadingDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCShadingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCShadingDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCShadingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSimplePropertyTemplate
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public List<IFCComplexPropertyTemplate>? _PartOfComplexTemplate {get; }
		public List<IFCPropertySetTemplate>? _PartOfPsetTemplate {get; }
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
	/// <summary>
	public interface IFCSlabElementedCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSlabStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSlabTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSolarDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSolarDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSolarDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSolarDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpaceHeater
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSpaceHeaterTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialZone
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCSpatialZoneTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpatialZoneType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSpatialZoneTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSphericalSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStackTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCStackTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStairType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCStairTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCBoolean? _DestabilizingLoad {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCStructuralCurveActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralCurveReaction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCStructuralCurveActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public IFCLoadGroupTypeEnum? _PredefinedType {get; }
		public IFCActionTypeEnum? _ActionType {get; }
		public IFCActionSourceTypeEnum? _ActionSource {get; }
		public IFCRatioMeasure? _Coefficient {get; }
		public IFCLabel? _Purpose {get; }
		public List<IFCStructuralResultGroup>? _SourceOfResultGroup {get; }
		public List<IFCStructuralAnalysisModel>? _LoadGroupFor {get; }
		public List<IFCRatioMeasure>? _SelfWeightCoefficients {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadConfiguration
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCStructuralLoadOrResult>? _Values {get; set;}
		public List<List<IFCLengthMeasure>>? _Locations {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralLoadOrResult
	{
		public IFCLabel? _Name {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralSurfaceAction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCBoolean? _DestabilizingLoad {get; }
		public IFCProjectedOrTrueLengthEnum? _ProjectedOrTrue {get; }
		public IFCStructuralSurfaceActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCStructuralSurfaceReaction
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCStructuralLoad? _AppliedLoad {get; }
		public IFCGlobalOrLocalEnum? _GlobalOrLocal {get; }
		public List<IFCRelConnectsStructuralActivity>? _AssignedToStructuralItem {get; }
		public IFCStructuralSurfaceActivityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSubContractResourceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
		public List<IFCAppliedValue>? _BaseCosts {get; }
		public IFCPhysicalQuantity? _BaseQuantity {get; }
		public IFCSubContractResourceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Curve3D {get; }
		public List<IFCPcurve>? _AssociatedGeometry {get; }
		public IFCPreferredSurfaceCurveRepresentation? _MasterRepresentation {get; }
		public List<IFCSurface>? _BasisSurface {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceFeature
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSurfaceFeatureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSurfaceReinforcementArea
	{
		public IFCLabel? _Name {get; set;}
		public List<IFCLengthMeasure>? _SurfaceReinforcement1 {get; set;}
		public List<IFCLengthMeasure>? _SurfaceReinforcement2 {get; set;}
		public IFCRatioMeasure? _ShearReinforcement {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCSweptDiskSolidPolygonal
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCPositiveLengthMeasure? _InnerRadius {get; }
		public IFCParameterValue? _StartParam {get; }
		public IFCParameterValue? _EndParam {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSwitchingDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSwitchingDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSystemFurnitureElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCSystemFurnitureElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTableColumn
	{
		public IFCIdentifier? _Identifier {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCUnit? _Unit {get; set;}
		public IFCReference? _ReferencePath {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTank
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTankTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTaskTime
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
	/// <summary>
	public interface IFCTaskTimeRecurring
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
	/// <summary>
	public interface IFCTaskType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
		public IFCTaskTypeEnum? _PredefinedType {get; }
		public IFCLabel? _WorkMethod {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonAnchorType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonAnchorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonTypeEnum? _PredefinedType {get; }
		public IFCPositiveLengthMeasure? _NominalDiameter {get; }
		public IFCAreaMeasure? _CrossSectionArea {get; }
		public IFCPositiveLengthMeasure? _SheathDiameter {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTessellatedFaceSet
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCIndexedColourMap>? _HasColours {get; }
		public List<IFCIndexedTextureMap>? _HasTextures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTessellatedItem
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureVertexList
	{
		public List<List<IFCParameterValue>>? _TexCoordsList {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTimePeriod
	{
		public IFCTime? _StartTime {get; set;}
		public IFCTime? _EndTime {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCToroidalSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCPositiveLengthMeasure? _MajorRadius {get; }
		public IFCPositiveLengthMeasure? _MinorRadius {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransformer
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTransformerTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTriangulatedFaceSet
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCIndexedColourMap>? _HasColours {get; }
		public List<IFCIndexedTextureMap>? _HasTextures {get; }
		public List<List<IFCParameterValue>>? _Normals {get; }
		public IFCBoolean? _Closed {get; }
		public List<List<IFCPositiveInteger>>? _CoordIndex {get; }
		public List<IFCPositiveInteger>? _PnIndex {get; }
		public IFCInteger? _NumberOfTriangles {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTubeBundle
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCTubeBundleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTypeProcess
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ProcessType {get; }
		public List<IFCRelAssignsToProcess>? _OperatesOn {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTypeResource
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public IFCIdentifier? _Identification {get; }
		public IFCText? _LongDescription {get; }
		public IFCLabel? _ResourceType {get; }
		public List<IFCRelAssignsToResource>? _ResourceOf {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitaryControlElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _AssignedToFlowElement {get; }
		public IFCUnitaryControlElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitaryControlElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCUnitaryControlElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCUnitaryEquipment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCUnitaryEquipmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCValve
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCValveTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVibrationIsolator
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCVibrationIsolatorTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVoidingFeature
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCVoidingFeatureTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWallElementedCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCWallTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWasteTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCWasteTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowStandardCase
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCPositiveLengthMeasure? _OverallHeight {get; }
		public IFCPositiveLengthMeasure? _OverallWidth {get; }
		public IFCWindowTypeEnum? _PredefinedType {get; }
		public IFCWindowTypePartitioningEnum? _PartitioningType {get; }
		public IFCLabel? _UserDefinedPartitioningType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWindowType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCWindowTypeEnum? _PredefinedType {get; }
		public IFCWindowTypePartitioningEnum? _PartitioningType {get; }
		public IFCBoolean? _ParameterTakesPrecedence {get; }
		public IFCLabel? _UserDefinedPartitioningType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkCalendar
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCIdentifier? _Identification {get; }
		public List<IFCRelAssignsToControl>? _Controls {get; }
		public List<IFCWorkTime>? _WorkingTimes {get; }
		public List<IFCWorkTime>? _ExceptionTimes {get; }
		public IFCWorkCalendarTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWorkTime
	{
		public IFCLabel? _Name {get; set;}
		public IFCDataOriginEnum? _DataOrigin {get; set;}
		public IFCLabel? _UserDefinedDataOrigin {get; set;}
		public IFCRecurrencePattern? _RecurrencePattern {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCAlignmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DHorizontal
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public List<IFCAlignment2DHorizontalSegment>? _Segments {get; }
		public List<IFCAlignmentCurve>? _ToAlignmentCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DHorizontalSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCCurveSegment2D? _CurveGeometry {get; }
		public List<IFCAlignment2DHorizontal>? _ToHorizontal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DVerSegCircularArc
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public List<IFCAlignment2DVertical>? _ToVertical {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCBoolean? _IsConvex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DVerSegLine
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public List<IFCAlignment2DVertical>? _ToVertical {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DVerSegParabolicArc
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public List<IFCAlignment2DVertical>? _ToVertical {get; }
		public IFCPositiveLengthMeasure? _ParabolaConstant {get; }
		public IFCBoolean? _IsConvex {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DVertical
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public List<IFCAlignment2DVerticalSegment>? _Segments {get; }
		public List<IFCAlignmentCurve>? _ToAlignmentCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignment2DVerticalSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCBoolean? _TangentialContinuity {get; }
		public IFCLabel? _StartTag {get; }
		public IFCLabel? _EndTag {get; }
		public IFCLengthMeasure? _StartDistAlong {get; }
		public IFCPositiveLengthMeasure? _HorizontalLength {get; }
		public IFCLengthMeasure? _StartHeight {get; }
		public IFCRatioMeasure? _StartGradient {get; }
		public List<IFCAlignment2DVertical>? _ToVertical {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAlignment2DHorizontal? _Horizontal {get; }
		public IFCAlignment2DVertical? _Vertical {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCircularArcSegment2D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
		public IFCPositiveLengthMeasure? _Radius {get; }
		public IFCBoolean? _IsCCW {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveSegment2D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistanceExpression
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCLengthMeasure? _DistanceAlong {get; }
		public IFCLengthMeasure? _OffsetLateral {get; }
		public IFCLengthMeasure? _OffsetVertical {get; }
		public IFCLengthMeasure? _OffsetLongitudinal {get; }
		public IFCBoolean? _AlongHorizontal {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLineSegment2D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCartesianPoint? _StartPoint {get; }
		public IFCPlaneAngleMeasure? _StartDirection {get; }
		public IFCPositiveLengthMeasure? _SegmentLength {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearPlacement
	{
		public List<IFCProduct>? _PlacesObject {get; }
		public IFCAxis2Placement3D? _CartesianPosition {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearPositioningElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOffsetCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOffsetCurveByDistances
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _BasisCurve {get; }
		public IFCLabel? _Tag {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOrientationExpression
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDirection? _LateralAxisDirection {get; }
		public IFCDirection? _VerticalAxisDirection {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPositioningElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReferent
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public IFCReferentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionedSolid
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public List<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionedSolidHorizontal
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public List<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransitionCurveSegment2D
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
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
	/// <summary>
	public interface IFCTriangulatedIrregularNetwork
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCCartesianPointList3D? _Coordinates {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCIndexedColourMap>? _HasColours {get; }
		public List<IFCIndexedTextureMap>? _HasTextures {get; }
		public List<List<IFCParameterValue>>? _Normals {get; }
		public IFCBoolean? _Closed {get; }
		public List<List<IFCPositiveInteger>>? _CoordIndex {get; }
		public List<IFCPositiveInteger>? _PnIndex {get; }
		public IFCInteger? _NumberOfTriangles {get; }
		public List<IFCInteger>? _Flags {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBearing
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCBearingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBearingType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCBearingTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBridge
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCBridgeTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBridgePart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCBridgePartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCaissonFoundation
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCCaissonFoundationTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCaissonFoundationType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCaissonFoundationTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDeepFoundation
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDeepFoundationType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFacility
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFacilityPart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRelPositions
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCPositioningElement? _RelatingPositioningElement {get; set;}
		public List<IFCProduct>? _RelatedProducts {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonConduit
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCLabel? _SteelGrade {get; }
		public IFCTendonConduitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTendonConduitType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTendonConduitTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVibrationDamper
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public IFCVibrationDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVibrationDamperType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVibrationDamperTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentCant
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCPositiveLengthMeasure? _RailHeadDistance {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentCantSegment
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
	/// <summary>
	public interface IFCAlignmentHorizontal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentHorizontalSegment
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
	/// <summary>
	public interface IFCAlignmentParameterSegment
	{
		public IFCLabel? _StartTag {get; set;}
		public IFCLabel? _EndTag {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCAlignmentParameterSegment? _DesignParameters {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentVertical
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCAlignmentVerticalSegment
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
	/// <summary>
	public interface IFCAxis2PlacementLinear
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCPoint? _Location {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCDirection? _Axis {get; }
		public IFCDirection? _RefDirection {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBorehole
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuiltElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuiltElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCBuiltSystem
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public List<IFCRelAssignsToGroup>? _IsGroupedBy {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public List<IFCRelServicesBuildings>? _ServicesBuildings {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ServicesFacilities {get; }
		public IFCBuiltSystemTypeEnum? _PredefinedType {get; }
		public IFCLabel? _LongName {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCClothoid
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _ClothoidConstant {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConveyorSegment
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCConveyorSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCConveyorSegmentType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCConveyorSegmentTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCosineSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _CosineTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCourse
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCCourseTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCourseType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCCourseTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCCurveSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCompositeCurve>? _UsingCurves {get; }
		public IFCPlacement? _Placement {get; }
		public IFCCurveMeasureSelect? _SegmentStart {get; }
		public IFCCurveMeasureSelect? _SegmentLength {get; }
		public IFCCurve? _ParentCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDirectrixCurveSweptAreaSolid
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCCurveMeasureSelect? _StartParam {get; }
		public IFCCurveMeasureSelect? _EndParam {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDirectrixDerivedReferenceSweptAreaSolid
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCProfileDef? _SweptArea {get; }
		public IFCAxis2Placement3D? _Position {get; }
		public IFCCurve? _Directrix {get; }
		public IFCCurveMeasureSelect? _StartParam {get; }
		public IFCCurveMeasureSelect? _EndParam {get; }
		public IFCDirection? _FixedReference {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionBoard
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCDistributionBoardType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCDistributionBoardTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEarthworksCut
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCRelVoidsElement? _VoidsElements {get; }
		public IFCEarthworksCutTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEarthworksElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCEarthworksFill
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCEarthworksFillTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricFlowTreatmentDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCElectricFlowTreatmentDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCElectricFlowTreatmentDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCElectricFlowTreatmentDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCFacilityPartCommon
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCFacilityPartCommonTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeographicCRS
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCIdentifier? _GeodeticDatum {get; set;}
		public List<IFCCoordinateOperation>? _HasCoordinateOperation {get; }
		public List<IFCWellKnownText>? _WellKnownText {get; }
		public IFCIdentifier? _PrimeMeridian {get; }
		public IFCNamedUnit? _AngleUnit {get; }
		public IFCNamedUnit? _HeightUnit {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeomodel
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeoslice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeotechnicalAssembly
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeotechnicalElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGeotechnicalStratum
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCGeotechnicalStratumTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCGradientCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCSegment>? _Segments {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCBoundedCurve? _BaseCurve {get; }
		public IFCPlacement? _EndPoint {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCImpactProtectionDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCImpactProtectionDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCImpactProtectionDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCImpactProtectionDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCIndexedPolygonalTextureMap
	{
		public List<IFCSurfaceTexture>? _Maps {get; set;}
		public IFCTessellatedFaceSet? _MappedTo {get; set;}
		public IFCTextureVertexList? _TexCoords {get; set;}
		public List<IFCTextureCoordinateIndices>? _TexCoordIndices {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCKerb
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCKerbTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCKerbType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCKerbTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLinearElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLiquidTerminal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCLiquidTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCLiquidTerminalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCLiquidTerminalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMapConversionScaled
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
	/// <summary>
	public interface IFCMarineFacility
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCMarineFacilityTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMarinePart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCMarinePartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMobileTelecommunicationsAppliance
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCMobileTelecommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMobileTelecommunicationsApplianceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMobileTelecommunicationsApplianceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMooringDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCMooringDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCMooringDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCMooringDeviceTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCNavigationElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCNavigationElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCNavigationElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCNavigationElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCOpenCrossProfileDef
	{
		public IFCProfileTypeEnum? _ProfileType {get; set;}
		public IFCLabel? _ProfileName {get; set;}
		public List<IFCExternalReferenceRelationship>? _HasExternalReference {get; }
		public List<IFCProfileProperties>? _HasProperties {get; }
		public IFCBoolean? _HorizontalWidths {get; }
		public List<IFCNonNegativeLengthMeasure>? _Widths {get; }
		public List<IFCPlaneAngleMeasure>? _Slopes {get; }
		public List<IFCLabel>? _Tags {get; }
		public IFCCartesianPoint? _OffsetPoint {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPavement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCPavementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPavementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCPavementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPointByDistanceExpression
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurveMeasureSelect? _DistanceAlong {get; }
		public IFCLengthMeasure? _OffsetLateral {get; }
		public IFCLengthMeasure? _OffsetVertical {get; }
		public IFCLengthMeasure? _OffsetLongitudinal {get; }
		public IFCCurve? _BasisCurve {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCPolynomialCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCPlacement? _Position {get; }
		public List<IFCReal>? _CoefficientsX {get; }
		public List<IFCReal>? _CoefficientsY {get; }
		public List<IFCReal>? _CoefficientsZ {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCQuantityNumber
	{
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCExternalReferenceRelationship>? _HasExternalReferences {get; }
		public List<IFCPhysicalComplexQuantity>? _PartOfComplex {get; }
		public IFCNamedUnit? _Unit {get; }
		public IFCNumericMeasure? _NumberValue {get; }
		public IFCLabel? _Formula {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRail
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCRailTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRailType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCRailTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRailway
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCRailwayTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRailwayPart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCRailwayPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCReinforcedSoil
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCReinforcedSoilTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAdheresToElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public IFCElement? _RelatingElement {get; set;}
		public List<IFCSurfaceFeature>? _RelatedSurfaceFeatures {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRelAssociatesProfileDef
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCDefinitionSelect>? _RelatedObjects {get; set;}
		public IFCProfileDef? _RelatingProfileDef {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRigidOperation
	{
		public IFCCoordinateReferenceSystemSelect? _SourceCRS {get; set;}
		public IFCCoordinateReferenceSystem? _TargetCRS {get; set;}
		public IFCMeasureValue? _FirstCoordinate {get; set;}
		public IFCMeasureValue? _SecondCoordinate {get; set;}
		public IFCLengthMeasure? _Height {get; set;}
	}
	/// <summary>
	/// <summary>
	public interface IFCRoad
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCRoadTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCRoadPart
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCLabel? _LongName {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainsElements {get; }
		public List<IFCRelServicesBuildings>? _ServicedBySystems {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencesElements {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public IFCElementCompositionEnum? _CompositionType {get; }
		public IFCFacilityUsageEnum? _UsageType {get; }
		public IFCRoadPartTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSecondOrderPolynomialSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _QuadraticTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSectionedSurface
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCCurve? _Directrix {get; }
		public List<IFCAxis2PlacementLinear>? _CrossSectionPositions {get; }
		public List<IFCProfileDef>? _CrossSections {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSegment
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCTransitionCode? _Transition {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCCompositeCurve>? _UsingCurves {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSegmentedReferenceCurve
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public List<IFCSegment>? _Segments {get; }
		public IFCLogical? _SelfIntersect {get; }
		public IFCInteger? _NSegments {get; }
		public IFCLogical? _ClosedCurve {get; }
		public IFCBoundedCurve? _BaseCurve {get; }
		public IFCPlacement? _EndPoint {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSeventhOrderPolynomialSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
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
	/// <summary>
	public interface IFCSign
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCSignTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSignType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSignTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSignal
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public List<IFCRelConnectsPortToElement>? _HasPorts {get; }
		public List<IFCRelFlowControlElements>? _HasControlElements {get; }
		public IFCSignalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSignalType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCSignalTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSineSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _SineTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureCoordinateIndices
	{
		public List<IFCPositiveInteger>? _TexCoordIndex {get; set;}
		public IFCIndexedPolygonalFace? _TexCoordsOf {get; set;}
		public IFCIndexedPolygonalTextureMap? _ToTexMap {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTextureCoordinateIndicesWithVoids
	{
		public List<IFCPositiveInteger>? _TexCoordIndex {get; set;}
		public IFCIndexedPolygonalFace? _TexCoordsOf {get; set;}
		public IFCIndexedPolygonalTextureMap? _ToTexMap {get; }
		public List<List<IFCPositiveInteger>>? _InnerTexCoordIndices {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCThirdOrderPolynomialSpiral
	{
		public List<IFCPresentationLayerAssignment>? _LayerAssignment {get; }
		public List<IFCStyledItem>? _StyledByItem {get; }
		public IFCDimensionCount? _Dim {get; }
		public IFCAxis2Placement? _Position {get; }
		public IFCLengthMeasure? _CubicTerm {get; }
		public IFCLengthMeasure? _QuadraticTerm {get; }
		public IFCLengthMeasure? _LinearTerm {get; }
		public IFCLengthMeasure? _ConstantTerm {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTrackElement
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCTrackElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTrackElementType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCTrackElementTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransportationDevice
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCTransportationDeviceType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVehicle
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCLabel? _ObjectType {get; }
		public List<IFCRelDefinesByObject>? _IsDeclaredBy {get; }
		public List<IFCRelDefinesByObject>? _Declares {get; }
		public List<IFCRelDefinesByType>? _IsTypedBy {get; }
		public List<IFCRelDefinesByProperties>? _IsDefinedBy {get; }
		public IFCObjectPlacement? _ObjectPlacement {get; }
		public IFCProductRepresentation? _Representation {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public List<IFCRelPositions>? _PositionedRelativeTo {get; }
		public List<IFCRelReferencedInSpatialStructure>? _ReferencedInStructures {get; }
		public IFCIdentifier? _Tag {get; }
		public List<IFCRelFillsElement>? _FillsVoids {get; }
		public List<IFCRelConnectsElements>? _ConnectedTo {get; }
		public List<IFCRelInterferesElements>? _IsInterferedByElements {get; }
		public List<IFCRelInterferesElements>? _InterferesElements {get; }
		public List<IFCRelProjectsElement>? _HasProjections {get; }
		public List<IFCRelVoidsElement>? _HasOpenings {get; }
		public List<IFCRelConnectsWithRealizingElements>? _IsConnectionRealization {get; }
		public List<IFCRelSpaceBoundary>? _ProvidesBoundaries {get; }
		public List<IFCRelConnectsElements>? _ConnectedFrom {get; }
		public List<IFCRelContainedInSpatialStructure>? _ContainedInStructure {get; }
		public List<IFCRelCoversBldgElements>? _HasCoverings {get; }
		public List<IFCRelAdheresToElement>? _HasSurfaceFeatures {get; }
		public IFCVehicleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCVehicleType
	{
		public IFCGloballyUniqueId? _GlobalId {get; set;}
		public IFCOwnerHistory? _OwnerHistory {get; set;}
		public IFCLabel? _Name {get; set;}
		public IFCText? _Description {get; set;}
		public List<IFCRelAssigns>? _HasAssignments {get; }
		public List<IFCRelNests>? _Nests {get; }
		public List<IFCRelNests>? _IsNestedBy {get; }
		public List<IFCRelDeclares>? _HasContext {get; }
		public List<IFCRelAggregates>? _IsDecomposedBy {get; }
		public List<IFCRelAggregates>? _Decomposes {get; }
		public List<IFCRelAssociates>? _HasAssociations {get; }
		public IFCIdentifier? _ApplicableOccurrence {get; }
		public List<IFCPropertySetDefinition>? _HasPropertySets {get; }
		public List<IFCRelDefinesByType>? _Types {get; }
		public List<IFCRepresentationMap>? _RepresentationMaps {get; }
		public IFCLabel? _Tag {get; }
		public List<IFCRelAssignsToProduct>? _ReferencedBy {get; }
		public IFCLabel? _ElementType {get; }
		public IFCVehicleTypeEnum? _PredefinedType {get; }
	}
	/// <summary>
	/// <summary>
	public interface IFCWellKnownText
	{
		public IFCWellKnownTextLiteral? _WellKnownText {get; set;}
		public IFCCoordinateReferenceSystem? _CoordinateReferenceSystem {get; set;}
	}
}
