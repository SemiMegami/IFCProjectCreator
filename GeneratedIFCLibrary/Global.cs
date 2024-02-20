using System;
using System.Collections.Generic;
namespace IFC.Global
{
	/// <summary>
	/// <summary>
	public interface IfcAbsorbedDoseMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAccelerationMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAmountOfSubstanceMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAngularVelocityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAreaMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBoolean: IfcSimpleValue, IfcModulusOfRotationalSubgradeReactionSelect, IfcModulusOfSubgradeReactionSelect, IfcModulusOfTranslationalSubgradeReactionSelect, IfcRotationalStiffnessSelect, IfcTranslationalStiffnessSelect, IfcWarpingStiffnessSelect
	{
		public bool Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBoxAlignment
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcContextDependentMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCountMeasure: IfcMeasureValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurvatureMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDayInMonthNumber
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDaylightSavingHour
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDescriptiveMeasure: IfcMeasureValue, IfcSizeSelect
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionCount
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoseEquivalentMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDynamicViscosityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricCapacitanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricChargeMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricConductanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricCurrentMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricResistanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricVoltageMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEnergyMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFontStyle
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFontVariant
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFontWeight
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcForceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFrequencyMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGloballyUniqueId
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcHeatFluxDensityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcHeatingValueMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcHourInDay
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcIdentifier: IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcIlluminanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcInductanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcInteger: IfcSimpleValue
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcIntegerCountRateMeasure: IfcDerivedMeasureValue
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcIonConcentrationMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcIsothermalMoistureCapacityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcKinematicViscosityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLabel: IfcConditionCriterionSelect, IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLengthMeasure: IfcMeasureValue, IfcSizeSelect, IfcBendingParameterSelect, IfcCurveMeasureSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearForceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearMomentMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearStiffnessMeasure: IfcDerivedMeasureValue, IfcTranslationalStiffnessSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearVelocityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLogical: IfcSimpleValue
	{
		public bool Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLuminousFluxMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLuminousIntensityDistributionMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLuminousIntensityMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMagneticFluxDensityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMagneticFluxMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMassDensityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMassFlowRateMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMassMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMassPerLengthMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMinuteInHour
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfElasticityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfLinearSubgradeReactionMeasure: IfcDerivedMeasureValue, IfcModulusOfTranslationalSubgradeReactionSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfRotationalSubgradeReactionMeasure: IfcDerivedMeasureValue, IfcModulusOfRotationalSubgradeReactionSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfSubgradeReactionMeasure: IfcDerivedMeasureValue, IfcModulusOfSubgradeReactionSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMoistureDiffusivityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMolecularWeightMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMomentOfInertiaMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMonetaryMeasure: IfcAppliedValueSelect, IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMonthInYearNumber
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcNormalisedRatioMeasure: IfcColourOrFactor, IfcMeasureValue, IfcSizeSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcNumericMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPHMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcParameterValue: IfcMeasureValue, IfcTrimmingSelect, IfcCurveMeasureSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPlanarForceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPlaneAngleMeasure: IfcMeasureValue, IfcOrientationSelect, IfcBendingParameterSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPositiveLengthMeasure: IfcHatchLineDistanceSelect, IfcMeasureValue, IfcSizeSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPositivePlaneAngleMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPositiveRatioMeasure: IfcMeasureValue, IfcSizeSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPowerMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentableText
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPressureMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRadioActivityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRatioMeasure: IfcAppliedValueSelect, IfcMeasureValue, IfcSizeSelect, IfcTimeOrRatioSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReal: IfcSimpleValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRotationalFrequencyMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRotationalMassMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRotationalStiffnessMeasure: IfcDerivedMeasureValue, IfcRotationalStiffnessSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSecondInMinute
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionModulusMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionalAreaIntegralMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcShearModulusMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSolidAngleMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundPowerMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundPressureMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpecificHeatCapacityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpecularExponent: IfcSpecularHighlightSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpecularRoughness: IfcSpecularHighlightSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTemperatureGradientMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcText: IfcMetricValueSelect, IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTextAlignment
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTextDecoration
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTextFontName
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTextTransformation
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalAdmittanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalConductivityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalExpansionCoefficientMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalResistanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalTransmittanceMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermodynamicTemperatureMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeStamp: IfcDerivedMeasureValue, IfcSimpleValue
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTorqueMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVaporPermeabilityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVolumeMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVolumetricFlowRateMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWarpingConstantMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWarpingMomentMeasure: IfcDerivedMeasureValue, IfcWarpingStiffnessSelect
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcYearNumber
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAreaDensityMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBinary: IfcSimpleValue
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCardinalPointReference
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDate: IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDateTime: IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDayInWeekNumber
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDuration: IfcSimpleValue, IfcTimeOrRatioSelect
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLanguageId
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcNonNegativeLengthMeasure: IfcMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPositiveInteger: IfcSimpleValue
	{
		public int Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundPowerLevelMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundPressureLevelMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTemperatureRateOfChangeMeasure: IfcDerivedMeasureValue
	{
		public double Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTime: IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcURIReference: IfcSimpleValue
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStrippedOptional
	{
		public bool Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWellKnownTextLiteral
	{
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcComplexNumber: IfcMeasureValue
	{
		public List<double>? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCompoundPlaneAngleMeasure: IfcDerivedMeasureValue
	{
		public List<int>? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcArcIndex: IfcSegmentIndexSelect
	{
		public List<int>? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLineIndex: IfcSegmentIndexSelect
	{
		public List<int>? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySetDefinitionSet: IfcPropertySetDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActionSourceTypeEnum
	{
		public static string? DEAD_LOAD_G { get;  }
		public static string? COMPLETION_G1 { get;  }
		public static string? LIVE_LOAD_Q { get;  }
		public static string? SNOW_S { get;  }
		public static string? WIND_W { get;  }
		public static string? PRESTRESSING_P { get;  }
		public static string? SETTLEMENT_U { get;  }
		public static string? TEMPERATURE_T { get;  }
		public static string? EARTHQUAKE_E { get;  }
		public static string? FIRE { get;  }
		public static string? IMPULSE { get;  }
		public static string? IMPACT { get;  }
		public static string? TRANSPORT { get;  }
		public static string? ERECTION { get;  }
		public static string? PROPPING { get;  }
		public static string? SYSTEM_IMPERFECTION { get;  }
		public static string? SHRINKAGE { get;  }
		public static string? CREEP { get;  }
		public static string? LACK_OF_FIT { get;  }
		public static string? BUOYANCY { get;  }
		public static string? ICE { get;  }
		public static string? CURRENT { get;  }
		public static string? WAVE { get;  }
		public static string? RAIN { get;  }
		public static string? BRAKES { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcActionTypeEnum
	{
		public static string? PERMANENT_G { get;  }
		public static string? VARIABLE_Q { get;  }
		public static string? EXTRAORDINARY_A { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcActuatorTypeEnum
	{
		public static string? ELECTRICACTUATOR { get;  }
		public static string? HANDOPERATEDACTUATOR { get;  }
		public static string? HYDRAULICACTUATOR { get;  }
		public static string? PNEUMATICACTUATOR { get;  }
		public static string? THERMOSTATICACTUATOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAddressTypeEnum
	{
		public static string? OFFICE { get;  }
		public static string? SITE { get;  }
		public static string? HOME { get;  }
		public static string? DISTRIBUTIONPOINT { get;  }
		public static string? USERDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAheadOrBehind
	{
		public static string? AHEAD { get;  }
		public static string? BEHIND { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminalBoxTypeEnum
	{
		public static string? CONSTANTFLOW { get;  }
		public static string? VARIABLEFLOWPRESSUREDEPENDANT { get;  }
		public static string? VARIABLEFLOWPRESSUREINDEPENDANT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminalTypeEnum
	{
		public static string? GRILLE { get;  }
		public static string? REGISTER { get;  }
		public static string? DIFFUSER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAirToAirHeatRecoveryTypeEnum
	{
		public static string? FIXEDPLATECOUNTERFLOWEXCHANGER { get;  }
		public static string? FIXEDPLATECROSSFLOWEXCHANGER { get;  }
		public static string? FIXEDPLATEPARALLELFLOWEXCHANGER { get;  }
		public static string? ROTARYWHEEL { get;  }
		public static string? RUNAROUNDCOILLOOP { get;  }
		public static string? HEATPIPE { get;  }
		public static string? TWINTOWERENTHALPYRECOVERYLOOPS { get;  }
		public static string? THERMOSIPHONSEALEDTUBEHEATEXCHANGERS { get;  }
		public static string? THERMOSIPHONCOILTYPEHEATEXCHANGERS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAlarmTypeEnum
	{
		public static string? BELL { get;  }
		public static string? BREAKGLASSBUTTON { get;  }
		public static string? LIGHT { get;  }
		public static string? MANUALPULLBOX { get;  }
		public static string? SIREN { get;  }
		public static string? WHISTLE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAnalysisModelTypeEnum
	{
		public static string? IN_PLANE_LOADING_2D { get;  }
		public static string? OUT_PLANE_LOADING_2D { get;  }
		public static string? LOADING_3D { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAnalysisTheoryTypeEnum
	{
		public static string? FIRST_ORDER_THEORY { get;  }
		public static string? SECOND_ORDER_THEORY { get;  }
		public static string? THIRD_ORDER_THEORY { get;  }
		public static string? FULL_NONLINEAR_THEORY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcArithmeticOperatorEnum
	{
		public static string? ADD { get;  }
		public static string? DIVIDE { get;  }
		public static string? MULTIPLY { get;  }
		public static string? SUBTRACT { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAssemblyPlaceEnum
	{
		public static string? SITE { get;  }
		public static string? FACTORY { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineCurveForm
	{
		public static string? POLYLINE_FORM { get;  }
		public static string? CIRCULAR_ARC { get;  }
		public static string? ELLIPTIC_ARC { get;  }
		public static string? PARABOLIC_ARC { get;  }
		public static string? HYPERBOLIC_ARC { get;  }
		public static string? UNSPECIFIED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBeamTypeEnum
	{
		public static string? BEAM { get;  }
		public static string? JOIST { get;  }
		public static string? LINTEL { get;  }
		public static string? T_BEAM { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBenchmarkEnum
	{
		public static string? GREATERTHAN { get;  }
		public static string? GREATERTHANOREQUALTO { get;  }
		public static string? LESSTHAN { get;  }
		public static string? LESSTHANOREQUALTO { get;  }
		public static string? EQUALTO { get;  }
		public static string? NOTEQUALTO { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBoilerTypeEnum
	{
		public static string? WATER { get;  }
		public static string? STEAM { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBooleanOperator
	{
		public static string? UNION { get;  }
		public static string? INTERSECTION { get;  }
		public static string? DIFFERENCE { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementProxyTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierFittingTypeEnum
	{
		public static string? BEND { get;  }
		public static string? CROSS { get;  }
		public static string? REDUCER { get;  }
		public static string? TEE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierSegmentTypeEnum
	{
		public static string? CABLELADDERSEGMENT { get;  }
		public static string? CABLETRAYSEGMENT { get;  }
		public static string? CABLETRUNKINGSEGMENT { get;  }
		public static string? CONDUITSEGMENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCableSegmentTypeEnum
	{
		public static string? CABLESEGMENT { get;  }
		public static string? CONDUCTORSEGMENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcChangeActionEnum
	{
		public static string? NOCHANGE { get;  }
		public static string? MODIFIED { get;  }
		public static string? ADDED { get;  }
		public static string? DELETED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcChillerTypeEnum
	{
		public static string? AIRCOOLED { get;  }
		public static string? WATERCOOLED { get;  }
		public static string? HEATRECOVERY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCoilTypeEnum
	{
		public static string? DXCOOLINGCOIL { get;  }
		public static string? WATERCOOLINGCOIL { get;  }
		public static string? STEAMHEATINGCOIL { get;  }
		public static string? WATERHEATINGCOIL { get;  }
		public static string? ELECTRICHEATINGCOIL { get;  }
		public static string? GASHEATINGCOIL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcColumnTypeEnum
	{
		public static string? COLUMN { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCompressorTypeEnum
	{
		public static string? DYNAMIC { get;  }
		public static string? RECIPROCATING { get;  }
		public static string? ROTARY { get;  }
		public static string? SCROLL { get;  }
		public static string? TROCHOIDAL { get;  }
		public static string? SINGLESTAGE { get;  }
		public static string? BOOSTER { get;  }
		public static string? OPENTYPE { get;  }
		public static string? HERMETIC { get;  }
		public static string? SEMIHERMETIC { get;  }
		public static string? WELDEDSHELLHERMETIC { get;  }
		public static string? ROLLINGPISTON { get;  }
		public static string? ROTARYVANE { get;  }
		public static string? SINGLESCREW { get;  }
		public static string? TWINSCREW { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCondenserTypeEnum
	{
		public static string? WATERCOOLEDSHELLTUBE { get;  }
		public static string? WATERCOOLEDSHELLCOIL { get;  }
		public static string? WATERCOOLEDTUBEINTUBE { get;  }
		public static string? WATERCOOLEDBRAZEDPLATE { get;  }
		public static string? AIRCOOLED { get;  }
		public static string? EVAPORATIVECOOLED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionTypeEnum
	{
		public static string? ATPATH { get;  }
		public static string? ATSTART { get;  }
		public static string? ATEND { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraintEnum
	{
		public static string? HARD { get;  }
		public static string? SOFT { get;  }
		public static string? ADVISORY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcControllerTypeEnum
	{
		public static string? FLOATING { get;  }
		public static string? PROPORTIONAL { get;  }
		public static string? TWOPOSITION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCooledBeamTypeEnum
	{
		public static string? ACTIVE { get;  }
		public static string? PASSIVE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCoolingTowerTypeEnum
	{
		public static string? NATURALDRAFT { get;  }
		public static string? MECHANICALINDUCEDDRAFT { get;  }
		public static string? MECHANICALFORCEDDRAFT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCostScheduleTypeEnum
	{
		public static string? BUDGET { get;  }
		public static string? COSTPLAN { get;  }
		public static string? ESTIMATE { get;  }
		public static string? TENDER { get;  }
		public static string? PRICEDBILLOFQUANTITIES { get;  }
		public static string? UNPRICEDBILLOFQUANTITIES { get;  }
		public static string? SCHEDULEOFRATES { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCoveringTypeEnum
	{
		public static string? CEILING { get;  }
		public static string? FLOORING { get;  }
		public static string? CLADDING { get;  }
		public static string? ROOFING { get;  }
		public static string? INSULATION { get;  }
		public static string? MEMBRANE { get;  }
		public static string? SLEEVING { get;  }
		public static string? WRAPPING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCurrencyEnum
	{
		public static string? AED { get;  }
		public static string? AES { get;  }
		public static string? ATS { get;  }
		public static string? AUD { get;  }
		public static string? BBD { get;  }
		public static string? BEG { get;  }
		public static string? BGL { get;  }
		public static string? BHD { get;  }
		public static string? BMD { get;  }
		public static string? BND { get;  }
		public static string? BRL { get;  }
		public static string? BSD { get;  }
		public static string? BWP { get;  }
		public static string? BZD { get;  }
		public static string? CAD { get;  }
		public static string? CBD { get;  }
		public static string? CHF { get;  }
		public static string? CLP { get;  }
		public static string? CNY { get;  }
		public static string? CYS { get;  }
		public static string? CZK { get;  }
		public static string? DDP { get;  }
		public static string? DEM { get;  }
		public static string? DKK { get;  }
		public static string? EGL { get;  }
		public static string? EST { get;  }
		public static string? EUR { get;  }
		public static string? FAK { get;  }
		public static string? FIM { get;  }
		public static string? FJD { get;  }
		public static string? FKP { get;  }
		public static string? FRF { get;  }
		public static string? GBP { get;  }
		public static string? GIP { get;  }
		public static string? GMD { get;  }
		public static string? GRX { get;  }
		public static string? HKD { get;  }
		public static string? HUF { get;  }
		public static string? ICK { get;  }
		public static string? IDR { get;  }
		public static string? ILS { get;  }
		public static string? INR { get;  }
		public static string? IRP { get;  }
		public static string? ITL { get;  }
		public static string? JMD { get;  }
		public static string? JOD { get;  }
		public static string? JPY { get;  }
		public static string? KES { get;  }
		public static string? KRW { get;  }
		public static string? KWD { get;  }
		public static string? KYD { get;  }
		public static string? LKR { get;  }
		public static string? LUF { get;  }
		public static string? MTL { get;  }
		public static string? MUR { get;  }
		public static string? MXN { get;  }
		public static string? MYR { get;  }
		public static string? NLG { get;  }
		public static string? NZD { get;  }
		public static string? OMR { get;  }
		public static string? PGK { get;  }
		public static string? PHP { get;  }
		public static string? PKR { get;  }
		public static string? PLN { get;  }
		public static string? PTN { get;  }
		public static string? QAR { get;  }
		public static string? RUR { get;  }
		public static string? SAR { get;  }
		public static string? SCR { get;  }
		public static string? SEK { get;  }
		public static string? SGD { get;  }
		public static string? SKP { get;  }
		public static string? THB { get;  }
		public static string? TRL { get;  }
		public static string? TTD { get;  }
		public static string? TWD { get;  }
		public static string? USD { get;  }
		public static string? VEB { get;  }
		public static string? VND { get;  }
		public static string? XEU { get;  }
		public static string? ZAR { get;  }
		public static string? ZWD { get;  }
		public static string? NOK { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCurtainWallTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDamperTypeEnum
	{
		public static string? CONTROLDAMPER { get;  }
		public static string? FIREDAMPER { get;  }
		public static string? SMOKEDAMPER { get;  }
		public static string? FIRESMOKEDAMPER { get;  }
		public static string? BACKDRAFTDAMPER { get;  }
		public static string? RELIEFDAMPER { get;  }
		public static string? BLASTDAMPER { get;  }
		public static string? GRAVITYDAMPER { get;  }
		public static string? GRAVITYRELIEFDAMPER { get;  }
		public static string? BALANCINGDAMPER { get;  }
		public static string? FUMEHOODEXHAUST { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDataOriginEnum
	{
		public static string? MEASURED { get;  }
		public static string? PREDICTED { get;  }
		public static string? SIMULATED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDerivedUnitEnum
	{
		public static string? ANGULARVELOCITYUNIT { get;  }
		public static string? COMPOUNDPLANEANGLEUNIT { get;  }
		public static string? DYNAMICVISCOSITYUNIT { get;  }
		public static string? HEATFLUXDENSITYUNIT { get;  }
		public static string? INTEGERCOUNTRATEUNIT { get;  }
		public static string? ISOTHERMALMOISTURECAPACITYUNIT { get;  }
		public static string? KINEMATICVISCOSITYUNIT { get;  }
		public static string? LINEARVELOCITYUNIT { get;  }
		public static string? MASSDENSITYUNIT { get;  }
		public static string? MASSFLOWRATEUNIT { get;  }
		public static string? MOISTUREDIFFUSIVITYUNIT { get;  }
		public static string? MOLECULARWEIGHTUNIT { get;  }
		public static string? SPECIFICHEATCAPACITYUNIT { get;  }
		public static string? THERMALADMITTANCEUNIT { get;  }
		public static string? THERMALCONDUCTANCEUNIT { get;  }
		public static string? THERMALRESISTANCEUNIT { get;  }
		public static string? THERMALTRANSMITTANCEUNIT { get;  }
		public static string? VAPORPERMEABILITYUNIT { get;  }
		public static string? VOLUMETRICFLOWRATEUNIT { get;  }
		public static string? ROTATIONALFREQUENCYUNIT { get;  }
		public static string? TORQUEUNIT { get;  }
		public static string? MOMENTOFINERTIAUNIT { get;  }
		public static string? LINEARMOMENTUNIT { get;  }
		public static string? LINEARFORCEUNIT { get;  }
		public static string? PLANARFORCEUNIT { get;  }
		public static string? MODULUSOFELASTICITYUNIT { get;  }
		public static string? SHEARMODULUSUNIT { get;  }
		public static string? LINEARSTIFFNESSUNIT { get;  }
		public static string? ROTATIONALSTIFFNESSUNIT { get;  }
		public static string? MODULUSOFSUBGRADEREACTIONUNIT { get;  }
		public static string? ACCELERATIONUNIT { get;  }
		public static string? CURVATUREUNIT { get;  }
		public static string? HEATINGVALUEUNIT { get;  }
		public static string? IONCONCENTRATIONUNIT { get;  }
		public static string? LUMINOUSINTENSITYDISTRIBUTIONUNIT { get;  }
		public static string? MASSPERLENGTHUNIT { get;  }
		public static string? MODULUSOFLINEARSUBGRADEREACTIONUNIT { get;  }
		public static string? MODULUSOFROTATIONALSUBGRADEREACTIONUNIT { get;  }
		public static string? PHUNIT { get;  }
		public static string? ROTATIONALMASSUNIT { get;  }
		public static string? SECTIONAREAINTEGRALUNIT { get;  }
		public static string? SECTIONMODULUSUNIT { get;  }
		public static string? SOUNDPOWERUNIT { get;  }
		public static string? SOUNDPRESSUREUNIT { get;  }
		public static string? TEMPERATUREGRADIENTUNIT { get;  }
		public static string? THERMALEXPANSIONCOEFFICIENTUNIT { get;  }
		public static string? WARPINGCONSTANTUNIT { get;  }
		public static string? WARPINGMOMENTUNIT { get;  }
		public static string? USERDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionExtentUsage
	{
		public static string? ORIGIN { get;  }
		public static string? TARGET { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDirectionSenseEnum
	{
		public static string? POSITIVE { get;  }
		public static string? NEGATIVE { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionChamberElementTypeEnum
	{
		public static string? FORMEDDUCT { get;  }
		public static string? INSPECTIONCHAMBER { get;  }
		public static string? INSPECTIONPIT { get;  }
		public static string? MANHOLE { get;  }
		public static string? METERCHAMBER { get;  }
		public static string? SUMP { get;  }
		public static string? TRENCH { get;  }
		public static string? VALVECHAMBER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentConfidentialityEnum
	{
		public static string? PUBLIC { get;  }
		public static string? RESTRICTED { get;  }
		public static string? CONFIDENTIAL { get;  }
		public static string? PERSONAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentStatusEnum
	{
		public static string? DRAFT { get;  }
		public static string? FINALDRAFT { get;  }
		public static string? FINAL { get;  }
		public static string? REVISION { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorPanelOperationEnum
	{
		public static string? SWINGING { get;  }
		public static string? DOUBLE_ACTING { get;  }
		public static string? SLIDING { get;  }
		public static string? FOLDING { get;  }
		public static string? REVOLVING { get;  }
		public static string? ROLLINGUP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorPanelPositionEnum
	{
		public static string? LEFT { get;  }
		public static string? MIDDLE { get;  }
		public static string? RIGHT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorStyleConstructionEnum
	{
		public static string? ALUMINIUM { get;  }
		public static string? HIGH_GRADE_STEEL { get;  }
		public static string? STEEL { get;  }
		public static string? WOOD { get;  }
		public static string? ALUMINIUM_WOOD { get;  }
		public static string? ALUMINIUM_PLASTIC { get;  }
		public static string? PLASTIC { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorStyleOperationEnum
	{
		public static string? SINGLE_SWING_LEFT { get;  }
		public static string? SINGLE_SWING_RIGHT { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT { get;  }
		public static string? DOUBLE_SWING_LEFT { get;  }
		public static string? DOUBLE_SWING_RIGHT { get;  }
		public static string? DOUBLE_DOOR_DOUBLE_SWING { get;  }
		public static string? SLIDING_TO_LEFT { get;  }
		public static string? SLIDING_TO_RIGHT { get;  }
		public static string? DOUBLE_DOOR_SLIDING { get;  }
		public static string? FOLDING_TO_LEFT { get;  }
		public static string? FOLDING_TO_RIGHT { get;  }
		public static string? DOUBLE_DOOR_FOLDING { get;  }
		public static string? REVOLVING { get;  }
		public static string? ROLLINGUP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctFittingTypeEnum
	{
		public static string? BEND { get;  }
		public static string? CONNECTOR { get;  }
		public static string? ENTRY { get;  }
		public static string? EXIT { get;  }
		public static string? JUNCTION { get;  }
		public static string? OBSTRUCTION { get;  }
		public static string? TRANSITION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSegmentTypeEnum
	{
		public static string? RIGIDSEGMENT { get;  }
		public static string? FLEXIBLESEGMENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSilencerTypeEnum
	{
		public static string? FLATOVAL { get;  }
		public static string? RECTANGULAR { get;  }
		public static string? ROUND { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricApplianceTypeEnum
	{
		public static string? DISHWASHER { get;  }
		public static string? ELECTRICCOOKER { get;  }
		public static string? FREESTANDINGFAN { get;  }
		public static string? FREEZER { get;  }
		public static string? FRIDGE_FREEZER { get;  }
		public static string? HANDDRYER { get;  }
		public static string? MICROWAVE { get;  }
		public static string? PHOTOCOPIER { get;  }
		public static string? REFRIGERATOR { get;  }
		public static string? TUMBLEDRYER { get;  }
		public static string? VENDINGMACHINE { get;  }
		public static string? WASHINGMACHINE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricCurrentEnum
	{
		public static string? ALTERNATING { get;  }
		public static string? DIRECT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricDistributionPointFunctionEnum
	{
		public static string? ALARMPANEL { get;  }
		public static string? CONSUMERUNIT { get;  }
		public static string? CONTROLPANEL { get;  }
		public static string? DISTRIBUTIONBOARD { get;  }
		public static string? GASDETECTORPANEL { get;  }
		public static string? INDICATORPANEL { get;  }
		public static string? MIMICPANEL { get;  }
		public static string? MOTORCONTROLCENTRE { get;  }
		public static string? SWITCHBOARD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowStorageDeviceTypeEnum
	{
		public static string? BATTERY { get;  }
		public static string? CAPACITORBANK { get;  }
		public static string? HARMONICFILTER { get;  }
		public static string? INDUCTORBANK { get;  }
		public static string? UPS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricGeneratorTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricHeaterTypeEnum
	{
		public static string? ELECTRICPOINTHEATER { get;  }
		public static string? ELECTRICCABLEHEATER { get;  }
		public static string? ELECTRICMATHEATER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricMotorTypeEnum
	{
		public static string? DC { get;  }
		public static string? INDUCTION { get;  }
		public static string? POLYPHASE { get;  }
		public static string? RELUCTANCESYNCHRONOUS { get;  }
		public static string? SYNCHRONOUS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricTimeControlTypeEnum
	{
		public static string? TIMECLOCK { get;  }
		public static string? TIMEDELAY { get;  }
		public static string? RELAY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElementAssemblyTypeEnum
	{
		public static string? ACCESSORY_ASSEMBLY { get;  }
		public static string? ARCH { get;  }
		public static string? BEAM_GRID { get;  }
		public static string? BRACED_FRAME { get;  }
		public static string? GIRDER { get;  }
		public static string? REINFORCEMENT_UNIT { get;  }
		public static string? RIGID_FRAME { get;  }
		public static string? SLAB_FIELD { get;  }
		public static string? TRUSS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElementCompositionEnum
	{
		public static string? COMPLEX { get;  }
		public static string? ELEMENT { get;  }
		public static string? PARTIAL { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEnergySequenceEnum
	{
		public static string? PRIMARY { get;  }
		public static string? SECONDARY { get;  }
		public static string? TERTIARY { get;  }
		public static string? AUXILIARY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEnvironmentalImpactCategoryEnum
	{
		public static string? COMBINEDVALUE { get;  }
		public static string? DISPOSAL { get;  }
		public static string? EXTRACTION { get;  }
		public static string? INSTALLATION { get;  }
		public static string? MANUFACTURE { get;  }
		public static string? TRANSPORTATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporativeCoolerTypeEnum
	{
		public static string? DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER { get;  }
		public static string? DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER { get;  }
		public static string? DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER { get;  }
		public static string? DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER { get;  }
		public static string? DIRECTEVAPORATIVEAIRWASHER { get;  }
		public static string? INDIRECTEVAPORATIVEPACKAGEAIRCOOLER { get;  }
		public static string? INDIRECTEVAPORATIVEWETCOIL { get;  }
		public static string? INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER { get;  }
		public static string? INDIRECTDIRECTCOMBINATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporatorTypeEnum
	{
		public static string? DIRECTEXPANSIONSHELLANDTUBE { get;  }
		public static string? DIRECTEXPANSIONTUBEINTUBE { get;  }
		public static string? DIRECTEXPANSIONBRAZEDPLATE { get;  }
		public static string? FLOODEDSHELLANDTUBE { get;  }
		public static string? SHELLANDCOIL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFanTypeEnum
	{
		public static string? CENTRIFUGALFORWARDCURVED { get;  }
		public static string? CENTRIFUGALRADIAL { get;  }
		public static string? CENTRIFUGALBACKWARDINCLINEDCURVED { get;  }
		public static string? CENTRIFUGALAIRFOIL { get;  }
		public static string? TUBEAXIAL { get;  }
		public static string? VANEAXIAL { get;  }
		public static string? PROPELLORAXIAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFilterTypeEnum
	{
		public static string? AIRPARTICLEFILTER { get;  }
		public static string? ODORFILTER { get;  }
		public static string? OILFILTER { get;  }
		public static string? STRAINER { get;  }
		public static string? WATERFILTER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFireSuppressionTerminalTypeEnum
	{
		public static string? BREECHINGINLET { get;  }
		public static string? FIREHYDRANT { get;  }
		public static string? HOSEREEL { get;  }
		public static string? SPRINKLER { get;  }
		public static string? SPRINKLERDEFLECTOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowDirectionEnum
	{
		public static string? SOURCE { get;  }
		public static string? SINK { get;  }
		public static string? SOURCEANDSINK { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowInstrumentTypeEnum
	{
		public static string? PRESSUREGAUGE { get;  }
		public static string? THERMOMETER { get;  }
		public static string? AMMETER { get;  }
		public static string? FREQUENCYMETER { get;  }
		public static string? POWERFACTORMETER { get;  }
		public static string? PHASEANGLEMETER { get;  }
		public static string? VOLTMETER_PEAK { get;  }
		public static string? VOLTMETER_RMS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowMeterTypeEnum
	{
		public static string? ENERGYMETER { get;  }
		public static string? GASMETER { get;  }
		public static string? OILMETER { get;  }
		public static string? WATERMETER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFootingTypeEnum
	{
		public static string? FOOTING_BEAM { get;  }
		public static string? PAD_FOOTING { get;  }
		public static string? PILE_CAP { get;  }
		public static string? STRIP_FOOTING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGasTerminalTypeEnum
	{
		public static string? GASAPPLIANCE { get;  }
		public static string? GASBOOSTER { get;  }
		public static string? GASBURNER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricProjectionEnum
	{
		public static string? GRAPH_VIEW { get;  }
		public static string? SKETCH_VIEW { get;  }
		public static string? MODEL_VIEW { get;  }
		public static string? PLAN_VIEW { get;  }
		public static string? REFLECTED_PLAN_VIEW { get;  }
		public static string? SECTION_VIEW { get;  }
		public static string? ELEVATION_VIEW { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGlobalOrLocalEnum
	{
		public static string? GLOBAL_COORDS { get;  }
		public static string? LOCAL_COORDS { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcHeatExchangerTypeEnum
	{
		public static string? PLATE { get;  }
		public static string? SHELLANDTUBE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcHumidifierTypeEnum
	{
		public static string? STEAMINJECTION { get;  }
		public static string? ADIABATICAIRWASHER { get;  }
		public static string? ADIABATICPAN { get;  }
		public static string? ADIABATICWETTEDELEMENT { get;  }
		public static string? ADIABATICATOMIZING { get;  }
		public static string? ADIABATICULTRASONIC { get;  }
		public static string? ADIABATICRIGIDMEDIA { get;  }
		public static string? ADIABATICCOMPRESSEDAIRNOZZLE { get;  }
		public static string? ASSISTEDELECTRIC { get;  }
		public static string? ASSISTEDNATURALGAS { get;  }
		public static string? ASSISTEDPROPANE { get;  }
		public static string? ASSISTEDBUTANE { get;  }
		public static string? ASSISTEDSTEAM { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcInternalOrExternalEnum
	{
		public static string? INTERNAL { get;  }
		public static string? EXTERNAL { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcInventoryTypeEnum
	{
		public static string? ASSETINVENTORY { get;  }
		public static string? SPACEINVENTORY { get;  }
		public static string? FURNITUREINVENTORY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcJunctionBoxTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLampTypeEnum
	{
		public static string? COMPACTFLUORESCENT { get;  }
		public static string? FLUORESCENT { get;  }
		public static string? HIGHPRESSUREMERCURY { get;  }
		public static string? HIGHPRESSURESODIUM { get;  }
		public static string? METALHALIDE { get;  }
		public static string? TUNGSTENFILAMENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLayerSetDirectionEnum
	{
		public static string? AXIS1 { get;  }
		public static string? AXIS2 { get;  }
		public static string? AXIS3 { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLightDistributionCurveEnum
	{
		public static string? TYPE_A { get;  }
		public static string? TYPE_B { get;  }
		public static string? TYPE_C { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLightEmissionSourceEnum
	{
		public static string? COMPACTFLUORESCENT { get;  }
		public static string? FLUORESCENT { get;  }
		public static string? HIGHPRESSUREMERCURY { get;  }
		public static string? HIGHPRESSURESODIUM { get;  }
		public static string? LIGHTEMITTINGDIODE { get;  }
		public static string? LOWPRESSURESODIUM { get;  }
		public static string? LOWVOLTAGEHALOGEN { get;  }
		public static string? MAINVOLTAGEHALOGEN { get;  }
		public static string? METALHALIDE { get;  }
		public static string? TUNGSTENFILAMENT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLightFixtureTypeEnum
	{
		public static string? POINTSOURCE { get;  }
		public static string? DIRECTIONSOURCE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLoadGroupTypeEnum
	{
		public static string? LOAD_GROUP { get;  }
		public static string? LOAD_CASE { get;  }
		public static string? LOAD_COMBINATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLogicalOperatorEnum
	{
		public static string? LOGICALAND { get;  }
		public static string? LOGICALOR { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMemberTypeEnum
	{
		public static string? BRACE { get;  }
		public static string? CHORD { get;  }
		public static string? COLLAR { get;  }
		public static string? MEMBER { get;  }
		public static string? MULLION { get;  }
		public static string? PLATE { get;  }
		public static string? POST { get;  }
		public static string? PURLIN { get;  }
		public static string? RAFTER { get;  }
		public static string? STRINGER { get;  }
		public static string? STRUT { get;  }
		public static string? STUD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMotorConnectionTypeEnum
	{
		public static string? BELTDRIVE { get;  }
		public static string? COUPLING { get;  }
		public static string? DIRECTDRIVE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcNullStyle: IfcPresentationStyleSelect
	{
		public static string? NULL { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcObjectTypeEnum
	{
		public static string? PRODUCT { get;  }
		public static string? PROCESS { get;  }
		public static string? CONTROL { get;  }
		public static string? RESOURCE { get;  }
		public static string? ACTOR { get;  }
		public static string? GROUP { get;  }
		public static string? PROJECT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcObjectiveEnum
	{
		public static string? CODECOMPLIANCE { get;  }
		public static string? DESIGNINTENT { get;  }
		public static string? HEALTHANDSAFETY { get;  }
		public static string? REQUIREMENT { get;  }
		public static string? SPECIFICATION { get;  }
		public static string? TRIGGERCONDITION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcOccupantTypeEnum
	{
		public static string? ASSIGNEE { get;  }
		public static string? ASSIGNOR { get;  }
		public static string? LESSEE { get;  }
		public static string? LESSOR { get;  }
		public static string? LETTINGAGENT { get;  }
		public static string? OWNER { get;  }
		public static string? TENANT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcOutletTypeEnum
	{
		public static string? AUDIOVISUALOUTLET { get;  }
		public static string? COMMUNICATIONSOUTLET { get;  }
		public static string? POWEROUTLET { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPermeableCoveringOperationEnum
	{
		public static string? GRILL { get;  }
		public static string? LOUVER { get;  }
		public static string? SCREEN { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPhysicalOrVirtualEnum
	{
		public static string? PHYSICAL { get;  }
		public static string? VIRTUAL { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPileConstructionEnum
	{
		public static string? CAST_IN_PLACE { get;  }
		public static string? COMPOSITE { get;  }
		public static string? PRECAST_CONCRETE { get;  }
		public static string? PREFAB_STEEL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPileTypeEnum
	{
		public static string? COHESION { get;  }
		public static string? FRICTION { get;  }
		public static string? SUPPORT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeFittingTypeEnum
	{
		public static string? BEND { get;  }
		public static string? CONNECTOR { get;  }
		public static string? ENTRY { get;  }
		public static string? EXIT { get;  }
		public static string? JUNCTION { get;  }
		public static string? OBSTRUCTION { get;  }
		public static string? TRANSITION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeSegmentTypeEnum
	{
		public static string? FLEXIBLESEGMENT { get;  }
		public static string? RIGIDSEGMENT { get;  }
		public static string? GUTTER { get;  }
		public static string? SPOOL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPlateTypeEnum
	{
		public static string? CURTAIN_PANEL { get;  }
		public static string? SHEET { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProcedureTypeEnum
	{
		public static string? ADVICE_CAUTION { get;  }
		public static string? ADVICE_NOTE { get;  }
		public static string? ADVICE_WARNING { get;  }
		public static string? CALIBRATION { get;  }
		public static string? DIAGNOSTIC { get;  }
		public static string? SHUTDOWN { get;  }
		public static string? STARTUP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProfileTypeEnum
	{
		public static string? CURVE { get;  }
		public static string? AREA { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectOrderRecordTypeEnum
	{
		public static string? CHANGE { get;  }
		public static string? MAINTENANCE { get;  }
		public static string? MOVE { get;  }
		public static string? PURCHASE { get;  }
		public static string? WORK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectOrderTypeEnum
	{
		public static string? CHANGEORDER { get;  }
		public static string? MAINTENANCEWORKORDER { get;  }
		public static string? MOVEORDER { get;  }
		public static string? PURCHASEORDER { get;  }
		public static string? WORKORDER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectedOrTrueLengthEnum
	{
		public static string? PROJECTED_LENGTH { get;  }
		public static string? TRUE_LENGTH { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySourceEnum
	{
		public static string? DESIGN { get;  }
		public static string? DESIGNMAXIMUM { get;  }
		public static string? DESIGNMINIMUM { get;  }
		public static string? SIMULATED { get;  }
		public static string? ASBUILT { get;  }
		public static string? COMMISSIONING { get;  }
		public static string? MEASURED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTKNOWN { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDeviceTypeEnum
	{
		public static string? FUSEDISCONNECTOR { get;  }
		public static string? CIRCUITBREAKER { get;  }
		public static string? RESIDUALCURRENTCIRCUITBREAKER { get;  }
		public static string? RESIDUALCURRENTSWITCH { get;  }
		public static string? VARISTOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPumpTypeEnum
	{
		public static string? CIRCULATOR { get;  }
		public static string? ENDSUCTION { get;  }
		public static string? SPLITCASE { get;  }
		public static string? VERTICALINLINE { get;  }
		public static string? VERTICALTURBINE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRailingTypeEnum
	{
		public static string? HANDRAIL { get;  }
		public static string? GUARDRAIL { get;  }
		public static string? BALUSTRADE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRampFlightTypeEnum
	{
		public static string? STRAIGHT { get;  }
		public static string? SPIRAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRampTypeEnum
	{
		public static string? STRAIGHT_RUN_RAMP { get;  }
		public static string? TWO_STRAIGHT_RUN_RAMP { get;  }
		public static string? QUARTER_TURN_RAMP { get;  }
		public static string? TWO_QUARTER_TURN_RAMP { get;  }
		public static string? HALF_TURN_RAMP { get;  }
		public static string? SPIRAL_RAMP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReflectanceMethodEnum
	{
		public static string? BLINN { get;  }
		public static string? FLAT { get;  }
		public static string? GLASS { get;  }
		public static string? MATT { get;  }
		public static string? METAL { get;  }
		public static string? MIRROR { get;  }
		public static string? PHONG { get;  }
		public static string? PLASTIC { get;  }
		public static string? STRAUSS { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingBarRoleEnum
	{
		public static string? MAIN { get;  }
		public static string? SHEAR { get;  }
		public static string? LIGATURE { get;  }
		public static string? STUD { get;  }
		public static string? PUNCHING { get;  }
		public static string? EDGE { get;  }
		public static string? RING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingBarSurfaceEnum
	{
		public static string? PLAIN { get;  }
		public static string? TEXTURED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceConsumptionEnum
	{
		public static string? CONSUMED { get;  }
		public static string? PARTIALLYCONSUMED { get;  }
		public static string? NOTCONSUMED { get;  }
		public static string? OCCUPIED { get;  }
		public static string? PARTIALLYOCCUPIED { get;  }
		public static string? NOTOCCUPIED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRibPlateDirectionEnum
	{
		public static string? DIRECTION_X { get;  }
		public static string? DIRECTION_Y { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRoleEnum
	{
		public static string? SUPPLIER { get;  }
		public static string? MANUFACTURER { get;  }
		public static string? CONTRACTOR { get;  }
		public static string? SUBCONTRACTOR { get;  }
		public static string? ARCHITECT { get;  }
		public static string? STRUCTURALENGINEER { get;  }
		public static string? COSTENGINEER { get;  }
		public static string? CLIENT { get;  }
		public static string? BUILDINGOWNER { get;  }
		public static string? BUILDINGOPERATOR { get;  }
		public static string? MECHANICALENGINEER { get;  }
		public static string? ELECTRICALENGINEER { get;  }
		public static string? PROJECTMANAGER { get;  }
		public static string? FACILITIESMANAGER { get;  }
		public static string? CIVILENGINEER { get;  }
		public static string? ENGINEER { get;  }
		public static string? OWNER { get;  }
		public static string? CONSULTANT { get;  }
		public static string? CONSTRUCTIONMANAGER { get;  }
		public static string? FIELDCONSTRUCTIONMANAGER { get;  }
		public static string? RESELLER { get;  }
		public static string? USERDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRoofTypeEnum
	{
		public static string? FLAT_ROOF { get;  }
		public static string? SHED_ROOF { get;  }
		public static string? GABLE_ROOF { get;  }
		public static string? HIP_ROOF { get;  }
		public static string? HIPPED_GABLE_ROOF { get;  }
		public static string? GAMBREL_ROOF { get;  }
		public static string? MANSARD_ROOF { get;  }
		public static string? BARREL_ROOF { get;  }
		public static string? RAINBOW_ROOF { get;  }
		public static string? BUTTERFLY_ROOF { get;  }
		public static string? PAVILION_ROOF { get;  }
		public static string? DOME_ROOF { get;  }
		public static string? FREEFORM { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSIPrefix
	{
		public static string? EXA { get;  }
		public static string? PETA { get;  }
		public static string? TERA { get;  }
		public static string? GIGA { get;  }
		public static string? MEGA { get;  }
		public static string? KILO { get;  }
		public static string? HECTO { get;  }
		public static string? DECA { get;  }
		public static string? DECI { get;  }
		public static string? CENTI { get;  }
		public static string? MILLI { get;  }
		public static string? MICRO { get;  }
		public static string? NANO { get;  }
		public static string? PICO { get;  }
		public static string? FEMTO { get;  }
		public static string? ATTO { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSIUnitName
	{
		public static string? AMPERE { get;  }
		public static string? BECQUEREL { get;  }
		public static string? CANDELA { get;  }
		public static string? COULOMB { get;  }
		public static string? CUBIC_METRE { get;  }
		public static string? DEGREE_CELSIUS { get;  }
		public static string? FARAD { get;  }
		public static string? GRAM { get;  }
		public static string? GRAY { get;  }
		public static string? HENRY { get;  }
		public static string? HERTZ { get;  }
		public static string? JOULE { get;  }
		public static string? KELVIN { get;  }
		public static string? LUMEN { get;  }
		public static string? LUX { get;  }
		public static string? METRE { get;  }
		public static string? MOLE { get;  }
		public static string? NEWTON { get;  }
		public static string? OHM { get;  }
		public static string? PASCAL { get;  }
		public static string? RADIAN { get;  }
		public static string? SECOND { get;  }
		public static string? SIEMENS { get;  }
		public static string? SIEVERT { get;  }
		public static string? SQUARE_METRE { get;  }
		public static string? STERADIAN { get;  }
		public static string? TESLA { get;  }
		public static string? VOLT { get;  }
		public static string? WATT { get;  }
		public static string? WEBER { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSanitaryTerminalTypeEnum
	{
		public static string? BATH { get;  }
		public static string? BIDET { get;  }
		public static string? CISTERN { get;  }
		public static string? SHOWER { get;  }
		public static string? SINK { get;  }
		public static string? SANITARYFOUNTAIN { get;  }
		public static string? TOILETPAN { get;  }
		public static string? URINAL { get;  }
		public static string? WASHHANDBASIN { get;  }
		public static string? WCSEAT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionTypeEnum
	{
		public static string? UNIFORM { get;  }
		public static string? TAPERED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSensorTypeEnum
	{
		public static string? CO2SENSOR { get;  }
		public static string? FIRESENSOR { get;  }
		public static string? FLOWSENSOR { get;  }
		public static string? GASSENSOR { get;  }
		public static string? HEATSENSOR { get;  }
		public static string? HUMIDITYSENSOR { get;  }
		public static string? LIGHTSENSOR { get;  }
		public static string? MOISTURESENSOR { get;  }
		public static string? MOVEMENTSENSOR { get;  }
		public static string? PRESSURESENSOR { get;  }
		public static string? SMOKESENSOR { get;  }
		public static string? SOUNDSENSOR { get;  }
		public static string? TEMPERATURESENSOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSequenceEnum
	{
		public static string? START_START { get;  }
		public static string? START_FINISH { get;  }
		public static string? FINISH_START { get;  }
		public static string? FINISH_FINISH { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcServiceLifeFactorTypeEnum
	{
		public static string? A_QUALITYOFCOMPONENTS { get;  }
		public static string? B_DESIGNLEVEL { get;  }
		public static string? C_WORKEXECUTIONLEVEL { get;  }
		public static string? D_INDOORENVIRONMENT { get;  }
		public static string? E_OUTDOORENVIRONMENT { get;  }
		public static string? F_INUSECONDITIONS { get;  }
		public static string? G_MAINTENANCELEVEL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcServiceLifeTypeEnum
	{
		public static string? ACTUALSERVICELIFE { get;  }
		public static string? EXPECTEDSERVICELIFE { get;  }
		public static string? OPTIMISTICREFERENCESERVICELIFE { get;  }
		public static string? PESSIMISTICREFERENCESERVICELIFE { get;  }
		public static string? REFERENCESERVICELIFE { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSlabTypeEnum
	{
		public static string? FLOOR { get;  }
		public static string? ROOF { get;  }
		public static string? LANDING { get;  }
		public static string? BASESLAB { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundScaleEnum
	{
		public static string? DBA { get;  }
		public static string? DBB { get;  }
		public static string? DBC { get;  }
		public static string? NC { get;  }
		public static string? NR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceHeaterTypeEnum
	{
		public static string? CONVECTOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStackTerminalTypeEnum
	{
		public static string? BIRDCAGE { get;  }
		public static string? COWL { get;  }
		public static string? RAINWATERHOPPER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStairFlightTypeEnum
	{
		public static string? STRAIGHT { get;  }
		public static string? WINDER { get;  }
		public static string? SPIRAL { get;  }
		public static string? CURVED { get;  }
		public static string? FREEFORM { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStairTypeEnum
	{
		public static string? STRAIGHT_RUN_STAIR { get;  }
		public static string? TWO_STRAIGHT_RUN_STAIR { get;  }
		public static string? QUARTER_WINDING_STAIR { get;  }
		public static string? QUARTER_TURN_STAIR { get;  }
		public static string? HALF_WINDING_STAIR { get;  }
		public static string? HALF_TURN_STAIR { get;  }
		public static string? TWO_QUARTER_WINDING_STAIR { get;  }
		public static string? TWO_QUARTER_TURN_STAIR { get;  }
		public static string? THREE_QUARTER_WINDING_STAIR { get;  }
		public static string? THREE_QUARTER_TURN_STAIR { get;  }
		public static string? SPIRAL_STAIR { get;  }
		public static string? DOUBLE_RETURN_STAIR { get;  }
		public static string? CURVED_RUN_STAIR { get;  }
		public static string? TWO_CURVED_RUN_STAIR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStateEnum
	{
		public static string? READWRITE { get;  }
		public static string? READONLY { get;  }
		public static string? LOCKED { get;  }
		public static string? READWRITELOCKED { get;  }
		public static string? READONLYLOCKED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveTypeEnum
	{
		public static string? RIGID_JOINED_MEMBER { get;  }
		public static string? PIN_JOINED_MEMBER { get;  }
		public static string? CABLE { get;  }
		public static string? TENSION_MEMBER { get;  }
		public static string? COMPRESSION_MEMBER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceTypeEnum
	{
		public static string? BENDING_ELEMENT { get;  }
		public static string? MEMBRANE_ELEMENT { get;  }
		public static string? SHELL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceSide
	{
		public static string? POSITIVE { get;  }
		public static string? NEGATIVE { get;  }
		public static string? BOTH { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceTextureEnum
	{
		public static string? BUMP { get;  }
		public static string? OPACITY { get;  }
		public static string? REFLECTION { get;  }
		public static string? SELFILLUMINATION { get;  }
		public static string? SHININESS { get;  }
		public static string? SPECULAR { get;  }
		public static string? TEXTURE { get;  }
		public static string? TRANSPARENCYMAP { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSwitchingDeviceTypeEnum
	{
		public static string? CONTACTOR { get;  }
		public static string? EMERGENCYSTOP { get;  }
		public static string? STARTER { get;  }
		public static string? SWITCHDISCONNECTOR { get;  }
		public static string? TOGGLESWITCH { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTankTypeEnum
	{
		public static string? EXPANSION { get;  }
		public static string? PRESSUREVESSEL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonTypeEnum
	{
		public static string? STRAND { get;  }
		public static string? WIRE { get;  }
		public static string? BAR { get;  }
		public static string? COATED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTextPath
	{
		public static string? LEFT { get;  }
		public static string? RIGHT { get;  }
		public static string? UP { get;  }
		public static string? DOWN { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalLoadSourceEnum
	{
		public static string? PEOPLE { get;  }
		public static string? LIGHTING { get;  }
		public static string? EQUIPMENT { get;  }
		public static string? VENTILATIONINDOORAIR { get;  }
		public static string? VENTILATIONOUTSIDEAIR { get;  }
		public static string? RECIRCULATEDAIR { get;  }
		public static string? EXHAUSTAIR { get;  }
		public static string? AIREXCHANGERATE { get;  }
		public static string? DRYBULBTEMPERATURE { get;  }
		public static string? RELATIVEHUMIDITY { get;  }
		public static string? INFILTRATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalLoadTypeEnum
	{
		public static string? SENSIBLE { get;  }
		public static string? LATENT { get;  }
		public static string? RADIANT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeriesDataTypeEnum
	{
		public static string? CONTINUOUS { get;  }
		public static string? DISCRETE { get;  }
		public static string? DISCRETEBINARY { get;  }
		public static string? PIECEWISEBINARY { get;  }
		public static string? PIECEWISECONSTANT { get;  }
		public static string? PIECEWISECONTINUOUS { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeriesScheduleTypeEnum
	{
		public static string? ANNUAL { get;  }
		public static string? MONTHLY { get;  }
		public static string? WEEKLY { get;  }
		public static string? DAILY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTransformerTypeEnum
	{
		public static string? CURRENT { get;  }
		public static string? FREQUENCY { get;  }
		public static string? VOLTAGE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTransitionCode
	{
		public static string? DISCONTINUOUS { get;  }
		public static string? CONTINUOUS { get;  }
		public static string? CONTSAMEGRADIENT { get;  }
		public static string? CONTSAMEGRADIENTSAMECURVATURE { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTransportElementTypeEnum
	{
		public static string? ELEVATOR { get;  }
		public static string? ESCALATOR { get;  }
		public static string? MOVINGWALKWAY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTrimmingPreference
	{
		public static string? CARTESIAN { get;  }
		public static string? PARAMETER { get;  }
		public static string? UNSPECIFIED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTubeBundleTypeEnum
	{
		public static string? FINNED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitEnum
	{
		public static string? ABSORBEDDOSEUNIT { get;  }
		public static string? AMOUNTOFSUBSTANCEUNIT { get;  }
		public static string? AREAUNIT { get;  }
		public static string? DOSEEQUIVALENTUNIT { get;  }
		public static string? ELECTRICCAPACITANCEUNIT { get;  }
		public static string? ELECTRICCHARGEUNIT { get;  }
		public static string? ELECTRICCONDUCTANCEUNIT { get;  }
		public static string? ELECTRICCURRENTUNIT { get;  }
		public static string? ELECTRICRESISTANCEUNIT { get;  }
		public static string? ELECTRICVOLTAGEUNIT { get;  }
		public static string? ENERGYUNIT { get;  }
		public static string? FORCEUNIT { get;  }
		public static string? FREQUENCYUNIT { get;  }
		public static string? ILLUMINANCEUNIT { get;  }
		public static string? INDUCTANCEUNIT { get;  }
		public static string? LENGTHUNIT { get;  }
		public static string? LUMINOUSFLUXUNIT { get;  }
		public static string? LUMINOUSINTENSITYUNIT { get;  }
		public static string? MAGNETICFLUXDENSITYUNIT { get;  }
		public static string? MAGNETICFLUXUNIT { get;  }
		public static string? MASSUNIT { get;  }
		public static string? PLANEANGLEUNIT { get;  }
		public static string? POWERUNIT { get;  }
		public static string? PRESSUREUNIT { get;  }
		public static string? RADIOACTIVITYUNIT { get;  }
		public static string? SOLIDANGLEUNIT { get;  }
		public static string? THERMODYNAMICTEMPERATUREUNIT { get;  }
		public static string? TIMEUNIT { get;  }
		public static string? VOLUMEUNIT { get;  }
		public static string? USERDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryEquipmentTypeEnum
	{
		public static string? AIRHANDLER { get;  }
		public static string? AIRCONDITIONINGUNIT { get;  }
		public static string? SPLITSYSTEM { get;  }
		public static string? ROOFTOPUNIT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcValveTypeEnum
	{
		public static string? AIRRELEASE { get;  }
		public static string? ANTIVACUUM { get;  }
		public static string? CHANGEOVER { get;  }
		public static string? CHECK { get;  }
		public static string? COMMISSIONING { get;  }
		public static string? DIVERTING { get;  }
		public static string? DRAWOFFCOCK { get;  }
		public static string? DOUBLECHECK { get;  }
		public static string? DOUBLEREGULATING { get;  }
		public static string? FAUCET { get;  }
		public static string? FLUSHING { get;  }
		public static string? GASCOCK { get;  }
		public static string? GASTAP { get;  }
		public static string? ISOLATING { get;  }
		public static string? MIXING { get;  }
		public static string? PRESSUREREDUCING { get;  }
		public static string? PRESSURERELIEF { get;  }
		public static string? REGULATING { get;  }
		public static string? SAFETYCUTOFF { get;  }
		public static string? STEAMTRAP { get;  }
		public static string? STOPCOCK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationIsolatorTypeEnum
	{
		public static string? COMPRESSION { get;  }
		public static string? SPRING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWallTypeEnum
	{
		public static string? STANDARD { get;  }
		public static string? POLYGONAL { get;  }
		public static string? SHEAR { get;  }
		public static string? ELEMENTEDWALL { get;  }
		public static string? PLUMBINGWALL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWasteTerminalTypeEnum
	{
		public static string? FLOORTRAP { get;  }
		public static string? FLOORWASTE { get;  }
		public static string? GULLYSUMP { get;  }
		public static string? GULLYTRAP { get;  }
		public static string? ROOFDRAIN { get;  }
		public static string? WASTEDISPOSALUNIT { get;  }
		public static string? WASTETRAP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowPanelOperationEnum
	{
		public static string? SIDEHUNGRIGHTHAND { get;  }
		public static string? SIDEHUNGLEFTHAND { get;  }
		public static string? TILTANDTURNRIGHTHAND { get;  }
		public static string? TILTANDTURNLEFTHAND { get;  }
		public static string? TOPHUNG { get;  }
		public static string? BOTTOMHUNG { get;  }
		public static string? PIVOTHORIZONTAL { get;  }
		public static string? PIVOTVERTICAL { get;  }
		public static string? SLIDINGHORIZONTAL { get;  }
		public static string? SLIDINGVERTICAL { get;  }
		public static string? REMOVABLECASEMENT { get;  }
		public static string? FIXEDCASEMENT { get;  }
		public static string? OTHEROPERATION { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowPanelPositionEnum
	{
		public static string? LEFT { get;  }
		public static string? MIDDLE { get;  }
		public static string? RIGHT { get;  }
		public static string? BOTTOM { get;  }
		public static string? TOP { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowStyleConstructionEnum
	{
		public static string? ALUMINIUM { get;  }
		public static string? HIGH_GRADE_STEEL { get;  }
		public static string? STEEL { get;  }
		public static string? WOOD { get;  }
		public static string? ALUMINIUM_WOOD { get;  }
		public static string? PLASTIC { get;  }
		public static string? OTHER_CONSTRUCTION { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowStyleOperationEnum
	{
		public static string? SINGLE_PANEL { get;  }
		public static string? DOUBLE_PANEL_VERTICAL { get;  }
		public static string? DOUBLE_PANEL_HORIZONTAL { get;  }
		public static string? TRIPLE_PANEL_VERTICAL { get;  }
		public static string? TRIPLE_PANEL_BOTTOM { get;  }
		public static string? TRIPLE_PANEL_TOP { get;  }
		public static string? TRIPLE_PANEL_LEFT { get;  }
		public static string? TRIPLE_PANEL_RIGHT { get;  }
		public static string? TRIPLE_PANEL_HORIZONTAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkControlTypeEnum
	{
		public static string? ACTUAL { get;  }
		public static string? BASELINE { get;  }
		public static string? PLANNED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcActionRequestTypeEnum
	{
		public static string? EMAIL { get;  }
		public static string? FAX { get;  }
		public static string? PHONE { get;  }
		public static string? POST { get;  }
		public static string? VERBAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAudioVisualApplianceTypeEnum
	{
		public static string? AMPLIFIER { get;  }
		public static string? CAMERA { get;  }
		public static string? DISPLAY { get;  }
		public static string? MICROPHONE { get;  }
		public static string? PLAYER { get;  }
		public static string? PROJECTOR { get;  }
		public static string? RECEIVER { get;  }
		public static string? SPEAKER { get;  }
		public static string? SWITCHER { get;  }
		public static string? TELEPHONE { get;  }
		public static string? TUNER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineSurfaceForm
	{
		public static string? PLANE_SURF { get;  }
		public static string? CYLINDRICAL_SURF { get;  }
		public static string? CONICAL_SURF { get;  }
		public static string? SPHERICAL_SURF { get;  }
		public static string? TOROIDAL_SURF { get;  }
		public static string? SURF_OF_REVOLUTION { get;  }
		public static string? RULED_SURF { get;  }
		public static string? GENERALISED_CONE { get;  }
		public static string? QUADRIC_SURF { get;  }
		public static string? SURF_OF_LINEAR_EXTRUSION { get;  }
		public static string? UNSPECIFIED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementPartTypeEnum
	{
		public static string? INSULATION { get;  }
		public static string? PRECASTPANEL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingSystemTypeEnum
	{
		public static string? FENESTRATION { get;  }
		public static string? FOUNDATION { get;  }
		public static string? LOADBEARING { get;  }
		public static string? OUTERSHELL { get;  }
		public static string? SHADING { get;  }
		public static string? TRANSPORT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBurnerTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCableFittingTypeEnum
	{
		public static string? CONNECTOR { get;  }
		public static string? ENTRY { get;  }
		public static string? EXIT { get;  }
		public static string? JUNCTION { get;  }
		public static string? TRANSITION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcChimneyTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCommunicationsApplianceTypeEnum
	{
		public static string? ANTENNA { get;  }
		public static string? COMPUTER { get;  }
		public static string? FAX { get;  }
		public static string? GATEWAY { get;  }
		public static string? MODEM { get;  }
		public static string? NETWORKAPPLIANCE { get;  }
		public static string? NETWORKBRIDGE { get;  }
		public static string? NETWORKHUB { get;  }
		public static string? PRINTER { get;  }
		public static string? REPEATER { get;  }
		public static string? ROUTER { get;  }
		public static string? SCANNER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcComplexPropertyTemplateTypeEnum
	{
		public static string? P_COMPLEX { get;  }
		public static string? Q_COMPLEX { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionEquipmentResourceTypeEnum
	{
		public static string? DEMOLISHING { get;  }
		public static string? EARTHMOVING { get;  }
		public static string? ERECTING { get;  }
		public static string? HEATING { get;  }
		public static string? LIGHTING { get;  }
		public static string? PAVING { get;  }
		public static string? PUMPING { get;  }
		public static string? TRANSPORTING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionMaterialResourceTypeEnum
	{
		public static string? AGGREGATES { get;  }
		public static string? CONCRETE { get;  }
		public static string? DRYWALL { get;  }
		public static string? FUEL { get;  }
		public static string? GYPSUM { get;  }
		public static string? MASONRY { get;  }
		public static string? METAL { get;  }
		public static string? PLASTIC { get;  }
		public static string? WOOD { get;  }
		public static string? NOTDEFINED { get;  }
		public static string? USERDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionProductResourceTypeEnum
	{
		public static string? ASSEMBLY { get;  }
		public static string? FORMWORK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCostItemTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCrewResourceTypeEnum
	{
		public static string? OFFICE { get;  }
		public static string? SITE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveInterpolationEnum
	{
		public static string? LINEAR { get;  }
		public static string? LOG_LINEAR { get;  }
		public static string? LOG_LOG { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDiscreteAccessoryTypeEnum
	{
		public static string? ANCHORPLATE { get;  }
		public static string? BRACKET { get;  }
		public static string? SHOE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionPortTypeEnum
	{
		public static string? CABLE { get;  }
		public static string? CABLECARRIER { get;  }
		public static string? DUCT { get;  }
		public static string? PIPE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionSystemEnum
	{
		public static string? AIRCONDITIONING { get;  }
		public static string? AUDIOVISUAL { get;  }
		public static string? CHEMICAL { get;  }
		public static string? CHILLEDWATER { get;  }
		public static string? COMMUNICATION { get;  }
		public static string? COMPRESSEDAIR { get;  }
		public static string? CONDENSERWATER { get;  }
		public static string? CONTROL { get;  }
		public static string? CONVEYING { get;  }
		public static string? DATA { get;  }
		public static string? DISPOSAL { get;  }
		public static string? DOMESTICCOLDWATER { get;  }
		public static string? DOMESTICHOTWATER { get;  }
		public static string? DRAINAGE { get;  }
		public static string? EARTHING { get;  }
		public static string? ELECTRICAL { get;  }
		public static string? ELECTROACOUSTIC { get;  }
		public static string? EXHAUST { get;  }
		public static string? FIREPROTECTION { get;  }
		public static string? FUEL { get;  }
		public static string? GAS { get;  }
		public static string? HAZARDOUS { get;  }
		public static string? HEATING { get;  }
		public static string? LIGHTING { get;  }
		public static string? LIGHTNINGPROTECTION { get;  }
		public static string? MUNICIPALSOLIDWASTE { get;  }
		public static string? OIL { get;  }
		public static string? OPERATIONAL { get;  }
		public static string? POWERGENERATION { get;  }
		public static string? RAINWATER { get;  }
		public static string? REFRIGERATION { get;  }
		public static string? SECURITY { get;  }
		public static string? SEWAGE { get;  }
		public static string? SIGNAL { get;  }
		public static string? STORMWATER { get;  }
		public static string? TELEPHONE { get;  }
		public static string? TV { get;  }
		public static string? VACUUM { get;  }
		public static string? VENT { get;  }
		public static string? VENTILATION { get;  }
		public static string? WASTEWATER { get;  }
		public static string? WATERSUPPLY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorTypeEnum
	{
		public static string? DOOR { get;  }
		public static string? GATE { get;  }
		public static string? TRAPDOOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorTypeOperationEnum
	{
		public static string? SINGLE_SWING_LEFT { get;  }
		public static string? SINGLE_SWING_RIGHT { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT { get;  }
		public static string? DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT { get;  }
		public static string? DOUBLE_SWING_LEFT { get;  }
		public static string? DOUBLE_SWING_RIGHT { get;  }
		public static string? DOUBLE_DOOR_DOUBLE_SWING { get;  }
		public static string? SLIDING_TO_LEFT { get;  }
		public static string? SLIDING_TO_RIGHT { get;  }
		public static string? DOUBLE_DOOR_SLIDING { get;  }
		public static string? FOLDING_TO_LEFT { get;  }
		public static string? FOLDING_TO_RIGHT { get;  }
		public static string? DOUBLE_DOOR_FOLDING { get;  }
		public static string? REVOLVING { get;  }
		public static string? ROLLINGUP { get;  }
		public static string? SWING_FIXED_LEFT { get;  }
		public static string? SWING_FIXED_RIGHT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricDistributionBoardTypeEnum
	{
		public static string? CONSUMERUNIT { get;  }
		public static string? DISTRIBUTIONBOARD { get;  }
		public static string? MOTORCONTROLCENTRE { get;  }
		public static string? SWITCHBOARD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEngineTypeEnum
	{
		public static string? EXTERNALCOMBUSTION { get;  }
		public static string? INTERNALCOMBUSTION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEventTriggerTypeEnum
	{
		public static string? EVENTRULE { get;  }
		public static string? EVENTMESSAGE { get;  }
		public static string? EVENTTIME { get;  }
		public static string? EVENTCOMPLEX { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEventTypeEnum
	{
		public static string? STARTEVENT { get;  }
		public static string? ENDEVENT { get;  }
		public static string? INTERMEDIATEEVENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalSpatialElementTypeEnum
	{
		public static string? EXTERNAL { get;  }
		public static string? EXTERNAL_EARTH { get;  }
		public static string? EXTERNAL_WATER { get;  }
		public static string? EXTERNAL_FIRE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFastenerTypeEnum
	{
		public static string? GLUE { get;  }
		public static string? MORTAR { get;  }
		public static string? WELD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFurnitureTypeEnum
	{
		public static string? CHAIR { get;  }
		public static string? TABLE { get;  }
		public static string? DESK { get;  }
		public static string? BED { get;  }
		public static string? FILECABINET { get;  }
		public static string? SHELF { get;  }
		public static string? SOFA { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGeographicElementTypeEnum
	{
		public static string? TERRAIN { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGridTypeEnum
	{
		public static string? RECTANGULAR { get;  }
		public static string? RADIAL { get;  }
		public static string? TRIANGULAR { get;  }
		public static string? IRREGULAR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcInterceptorTypeEnum
	{
		public static string? CYCLONIC { get;  }
		public static string? GREASE { get;  }
		public static string? OIL { get;  }
		public static string? PETROL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcKnotType
	{
		public static string? UNIFORM_KNOTS { get;  }
		public static string? QUASI_UNIFORM_KNOTS { get;  }
		public static string? PIECEWISE_BEZIER_KNOTS { get;  }
		public static string? UNSPECIFIED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLaborResourceTypeEnum
	{
		public static string? ADMINISTRATION { get;  }
		public static string? CARPENTRY { get;  }
		public static string? CLEANING { get;  }
		public static string? CONCRETE { get;  }
		public static string? DRYWALL { get;  }
		public static string? ELECTRIC { get;  }
		public static string? FINISHING { get;  }
		public static string? FLOORING { get;  }
		public static string? GENERAL { get;  }
		public static string? HVAC { get;  }
		public static string? LANDSCAPING { get;  }
		public static string? MASONRY { get;  }
		public static string? PAINTING { get;  }
		public static string? PAVING { get;  }
		public static string? PLUMBING { get;  }
		public static string? ROOFING { get;  }
		public static string? SITEGRADING { get;  }
		public static string? STEELWORK { get;  }
		public static string? SURVEYING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalFastenerTypeEnum
	{
		public static string? ANCHORBOLT { get;  }
		public static string? BOLT { get;  }
		public static string? DOWEL { get;  }
		public static string? NAIL { get;  }
		public static string? NAILPLATE { get;  }
		public static string? RIVET { get;  }
		public static string? SCREW { get;  }
		public static string? SHEARCONNECTOR { get;  }
		public static string? STAPLE { get;  }
		public static string? STUDSHEARCONNECTOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMedicalDeviceTypeEnum
	{
		public static string? AIRSTATION { get;  }
		public static string? FEEDAIRUNIT { get;  }
		public static string? OXYGENGENERATOR { get;  }
		public static string? OXYGENPLANT { get;  }
		public static string? VACUUMSTATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcOpeningElementTypeEnum
	{
		public static string? OPENING { get;  }
		public static string? RECESS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPerformanceHistoryTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPermitTypeEnum
	{
		public static string? ACCESS { get;  }
		public static string? BUILDING { get;  }
		public static string? WORK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPreferredSurfaceCurveRepresentation
	{
		public static string? CURVE3D { get;  }
		public static string? PCURVE_S1 { get;  }
		public static string? PCURVE_S2 { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectionElementTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySetTemplateTypeEnum
	{
		public static string? PSET_TYPEDRIVENONLY { get;  }
		public static string? PSET_TYPEDRIVENOVERRIDE { get;  }
		public static string? PSET_OCCURRENCEDRIVEN { get;  }
		public static string? PSET_PERFORMANCEDRIVEN { get;  }
		public static string? QTO_TYPEDRIVENONLY { get;  }
		public static string? QTO_TYPEDRIVENOVERRIDE { get;  }
		public static string? QTO_OCCURRENCEDRIVEN { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDeviceTrippingUnitTypeEnum
	{
		public static string? ELECTRONIC { get;  }
		public static string? ELECTROMAGNETIC { get;  }
		public static string? RESIDUALCURRENT { get;  }
		public static string? THERMAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRecurrenceTypeEnum
	{
		public static string? DAILY { get;  }
		public static string? WEEKLY { get;  }
		public static string? MONTHLY_BY_DAY_OF_MONTH { get;  }
		public static string? MONTHLY_BY_POSITION { get;  }
		public static string? BY_DAY_COUNT { get;  }
		public static string? BY_WEEKDAY_COUNT { get;  }
		public static string? YEARLY_BY_DAY_OF_MONTH { get;  }
		public static string? YEARLY_BY_POSITION { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingBarTypeEnum
	{
		public static string? ANCHORING { get;  }
		public static string? EDGE { get;  }
		public static string? LIGATURE { get;  }
		public static string? MAIN { get;  }
		public static string? PUNCHING { get;  }
		public static string? RING { get;  }
		public static string? SHEAR { get;  }
		public static string? STUD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingMeshTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcShadingDeviceTypeEnum
	{
		public static string? JALOUSIE { get;  }
		public static string? SHUTTER { get;  }
		public static string? AWNING { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSimplePropertyTemplateTypeEnum
	{
		public static string? P_SINGLEVALUE { get;  }
		public static string? P_ENUMERATEDVALUE { get;  }
		public static string? P_BOUNDEDVALUE { get;  }
		public static string? P_LISTVALUE { get;  }
		public static string? P_TABLEVALUE { get;  }
		public static string? P_REFERENCEVALUE { get;  }
		public static string? Q_LENGTH { get;  }
		public static string? Q_AREA { get;  }
		public static string? Q_VOLUME { get;  }
		public static string? Q_COUNT { get;  }
		public static string? Q_WEIGHT { get;  }
		public static string? Q_TIME { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSolarDeviceTypeEnum
	{
		public static string? SOLARCOLLECTOR { get;  }
		public static string? SOLARPANEL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialZoneTypeEnum
	{
		public static string? CONSTRUCTION { get;  }
		public static string? FIRESAFETY { get;  }
		public static string? LIGHTING { get;  }
		public static string? OCCUPANCY { get;  }
		public static string? SECURITY { get;  }
		public static string? THERMAL { get;  }
		public static string? TRANSPORT { get;  }
		public static string? VENTILATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveActivityTypeEnum
	{
		public static string? CONST { get;  }
		public static string? LINEAR { get;  }
		public static string? POLYGONAL { get;  }
		public static string? EQUIDISTANT { get;  }
		public static string? SINUS { get;  }
		public static string? PARABOLA { get;  }
		public static string? DISCRETE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveMemberTypeEnum
	{
		public static string? RIGID_JOINED_MEMBER { get;  }
		public static string? PIN_JOINED_MEMBER { get;  }
		public static string? CABLE { get;  }
		public static string? TENSION_MEMBER { get;  }
		public static string? COMPRESSION_MEMBER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceActivityTypeEnum
	{
		public static string? CONST { get;  }
		public static string? BILINEAR { get;  }
		public static string? DISCRETE { get;  }
		public static string? ISOCONTOUR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceMemberTypeEnum
	{
		public static string? BENDING_ELEMENT { get;  }
		public static string? MEMBRANE_ELEMENT { get;  }
		public static string? SHELL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSubContractResourceTypeEnum
	{
		public static string? PURCHASE { get;  }
		public static string? WORK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceFeatureTypeEnum
	{
		public static string? MARK { get;  }
		public static string? TAG { get;  }
		public static string? TREATMENT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSystemFurnitureElementTypeEnum
	{
		public static string? PANEL { get;  }
		public static string? WORKSURFACE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTaskDurationEnum
	{
		public static string? ELAPSEDTIME { get;  }
		public static string? WORKTIME { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTaskTypeEnum
	{
		public static string? ATTENDANCE { get;  }
		public static string? CONSTRUCTION { get;  }
		public static string? DEMOLITION { get;  }
		public static string? DISMANTLE { get;  }
		public static string? DISPOSAL { get;  }
		public static string? INSTALLATION { get;  }
		public static string? LOGISTIC { get;  }
		public static string? MAINTENANCE { get;  }
		public static string? MOVE { get;  }
		public static string? OPERATION { get;  }
		public static string? REMOVAL { get;  }
		public static string? RENOVATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonAnchorTypeEnum
	{
		public static string? COUPLER { get;  }
		public static string? FIXED_END { get;  }
		public static string? TENSIONING_END { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryControlElementTypeEnum
	{
		public static string? ALARMPANEL { get;  }
		public static string? CONTROLPANEL { get;  }
		public static string? GASDETECTIONPANEL { get;  }
		public static string? INDICATORPANEL { get;  }
		public static string? MIMICPANEL { get;  }
		public static string? HUMIDISTAT { get;  }
		public static string? THERMOSTAT { get;  }
		public static string? WEATHERSTATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVoidingFeatureTypeEnum
	{
		public static string? CUTOUT { get;  }
		public static string? NOTCH { get;  }
		public static string? HOLE { get;  }
		public static string? MITER { get;  }
		public static string? CHAMFER { get;  }
		public static string? EDGE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowTypeEnum
	{
		public static string? WINDOW { get;  }
		public static string? SKYLIGHT { get;  }
		public static string? LIGHTDOME { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowTypePartitioningEnum
	{
		public static string? SINGLE_PANEL { get;  }
		public static string? DOUBLE_PANEL_VERTICAL { get;  }
		public static string? DOUBLE_PANEL_HORIZONTAL { get;  }
		public static string? TRIPLE_PANEL_VERTICAL { get;  }
		public static string? TRIPLE_PANEL_BOTTOM { get;  }
		public static string? TRIPLE_PANEL_TOP { get;  }
		public static string? TRIPLE_PANEL_LEFT { get;  }
		public static string? TRIPLE_PANEL_RIGHT { get;  }
		public static string? TRIPLE_PANEL_HORIZONTAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkCalendarTypeEnum
	{
		public static string? FIRSTSHIFT { get;  }
		public static string? SECONDSHIFT { get;  }
		public static string? THIRDSHIFT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkPlanTypeEnum
	{
		public static string? ACTUAL { get;  }
		public static string? BASELINE { get;  }
		public static string? PLANNED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkScheduleTypeEnum
	{
		public static string? ACTUAL { get;  }
		public static string? BASELINE { get;  }
		public static string? PLANNED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReferentTypeEnum
	{
		public static string? KILOPOINT { get;  }
		public static string? MILEPOINT { get;  }
		public static string? STATION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTransitionCurveType
	{
		public static string? BIQUADRATICPARABOLA { get;  }
		public static string? BLOSSCURVE { get;  }
		public static string? CLOTHOIDCURVE { get;  }
		public static string? COSINECURVE { get;  }
		public static string? CUBICPARABOLA { get;  }
		public static string? SINECURVE { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBearingTypeDisplacementEnum
	{
		public static string? FIXED_MOVEMENT { get;  }
		public static string? GUIDED_LONGITUDINAL { get;  }
		public static string? GUIDED_TRANSVERSAL { get;  }
		public static string? FREE_MOVEMENT { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBearingTypeEnum
	{
		public static string? CYLINDRICAL { get;  }
		public static string? SPHERICAL { get;  }
		public static string? ELASTOMERIC { get;  }
		public static string? POT { get;  }
		public static string? GUIDE { get;  }
		public static string? ROCKER { get;  }
		public static string? ROLLER { get;  }
		public static string? DISK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBridgePartTypeEnum
	{
		public static string? ABUTMENT { get;  }
		public static string? DECK { get;  }
		public static string? DECK_SEGMENT { get;  }
		public static string? FOUNDATION { get;  }
		public static string? PIER { get;  }
		public static string? PIER_SEGMENT { get;  }
		public static string? PYLON { get;  }
		public static string? SUBSTRUCTURE { get;  }
		public static string? SUPERSTRUCTURE { get;  }
		public static string? SURFACESTRUCTURE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBridgeTypeEnum
	{
		public static string? ARCHED { get;  }
		public static string? CABLE_STAYED { get;  }
		public static string? CANTILEVER { get;  }
		public static string? CULVERT { get;  }
		public static string? FRAMEWORK { get;  }
		public static string? GIRDER { get;  }
		public static string? SUSPENSION { get;  }
		public static string? TRUSS { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCaissonFoundationTypeEnum
	{
		public static string? WELL { get;  }
		public static string? CAISSON { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonConduitTypeEnum
	{
		public static string? DUCT { get;  }
		public static string? COUPLER { get;  }
		public static string? GROUTING_DUCT { get;  }
		public static string? TRUMPET { get;  }
		public static string? DIABOLO { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationDamperTypeEnum
	{
		public static string? BENDING_YIELD { get;  }
		public static string? SHEAR_YIELD { get;  }
		public static string? AXIAL_YIELD { get;  }
		public static string? FRICTION { get;  }
		public static string? VISCOUS { get;  }
		public static string? RUBBER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentCantSegmentTypeEnum
	{
		public static string? BLOSSCURVE { get;  }
		public static string? CONSTANTCANT { get;  }
		public static string? COSINECURVE { get;  }
		public static string? HELMERTCURVE { get;  }
		public static string? LINEARTRANSITION { get;  }
		public static string? SINECURVE { get;  }
		public static string? VIENNESEBEND { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentHorizontalSegmentTypeEnum
	{
		public static string? BLOSSCURVE { get;  }
		public static string? CIRCULARARC { get;  }
		public static string? CLOTHOID { get;  }
		public static string? COSINECURVE { get;  }
		public static string? CUBIC { get;  }
		public static string? HELMERTCURVE { get;  }
		public static string? LINE { get;  }
		public static string? SINECURVE { get;  }
		public static string? VIENNESEBEND { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentVerticalSegmentTypeEnum
	{
		public static string? CIRCULARARC { get;  }
		public static string? CLOTHOID { get;  }
		public static string? CONSTANTGRADIENT { get;  }
		public static string? PARABOLICARC { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationTypeEnum
	{
		public static string? CONTOURLINE { get;  }
		public static string? DIMENSION { get;  }
		public static string? ISOBAR { get;  }
		public static string? ISOLUX { get;  }
		public static string? ISOTHERM { get;  }
		public static string? LEADER { get;  }
		public static string? SURVEY { get;  }
		public static string? SYMBOL { get;  }
		public static string? TEXT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcBuiltSystemTypeEnum
	{
		public static string? EROSIONPREVENTION { get;  }
		public static string? FENESTRATION { get;  }
		public static string? FOUNDATION { get;  }
		public static string? LOADBEARING { get;  }
		public static string? MOORING { get;  }
		public static string? OUTERSHELL { get;  }
		public static string? PRESTRESSING { get;  }
		public static string? RAILWAYLINE { get;  }
		public static string? RAILWAYTRACK { get;  }
		public static string? REINFORCING { get;  }
		public static string? SHADING { get;  }
		public static string? TRACKCIRCUIT { get;  }
		public static string? TRANSPORT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcConveyorSegmentTypeEnum
	{
		public static string? BELTCONVEYOR { get;  }
		public static string? BUCKETCONVEYOR { get;  }
		public static string? CHUTECONVEYOR { get;  }
		public static string? SCREWCONVEYOR { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcCourseTypeEnum
	{
		public static string? ARMOUR { get;  }
		public static string? BALLASTBED { get;  }
		public static string? CORE { get;  }
		public static string? FILTER { get;  }
		public static string? PAVEMENT { get;  }
		public static string? PROTECTION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionBoardTypeEnum
	{
		public static string? CONSUMERUNIT { get;  }
		public static string? DISPATCHINGBOARD { get;  }
		public static string? DISTRIBUTIONBOARD { get;  }
		public static string? DISTRIBUTIONFRAME { get;  }
		public static string? MOTORCONTROLCENTRE { get;  }
		public static string? SWITCHBOARD { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEarthworksCutTypeEnum
	{
		public static string? BASE_EXCAVATION { get;  }
		public static string? CUT { get;  }
		public static string? DREDGING { get;  }
		public static string? EXCAVATION { get;  }
		public static string? OVEREXCAVATION { get;  }
		public static string? PAVEMENTMILLING { get;  }
		public static string? STEPEXCAVATION { get;  }
		public static string? TOPSOILREMOVAL { get;  }
		public static string? TRENCH { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcEarthworksFillTypeEnum
	{
		public static string? BACKFILL { get;  }
		public static string? COUNTERWEIGHT { get;  }
		public static string? EMBANKMENT { get;  }
		public static string? SLOPEFILL { get;  }
		public static string? SUBGRADE { get;  }
		public static string? SUBGRADEBED { get;  }
		public static string? TRANSITIONSECTION { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowTreatmentDeviceTypeEnum
	{
		public static string? ELECTRONICFILTER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFacilityPartCommonTypeEnum
	{
		public static string? ABOVEGROUND { get;  }
		public static string? BELOWGROUND { get;  }
		public static string? JUNCTION { get;  }
		public static string? LEVELCROSSING { get;  }
		public static string? SEGMENT { get;  }
		public static string? SUBSTRUCTURE { get;  }
		public static string? SUPERSTRUCTURE { get;  }
		public static string? TERMINAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcFacilityUsageEnum
	{
		public static string? LATERAL { get;  }
		public static string? LONGITUDINAL { get;  }
		public static string? REGION { get;  }
		public static string? VERTICAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcGeotechnicalStratumTypeEnum
	{
		public static string? SOLID { get;  }
		public static string? VOID { get;  }
		public static string? WATER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcImpactProtectionDeviceTypeEnum
	{
		public static string? BUMPER { get;  }
		public static string? CRASHCUSHION { get;  }
		public static string? DAMPINGSYSTEM { get;  }
		public static string? FENDER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcKerbTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcLiquidTerminalTypeEnum
	{
		public static string? HOSEREEL { get;  }
		public static string? LOADINGARM { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMarineFacilityTypeEnum
	{
		public static string? BARRIERBEACH { get;  }
		public static string? BREAKWATER { get;  }
		public static string? CANAL { get;  }
		public static string? DRYDOCK { get;  }
		public static string? FLOATINGDOCK { get;  }
		public static string? HYDROLIFT { get;  }
		public static string? JETTY { get;  }
		public static string? LAUNCHRECOVERY { get;  }
		public static string? MARINEDEFENCE { get;  }
		public static string? NAVIGATIONALCHANNEL { get;  }
		public static string? PORT { get;  }
		public static string? QUAY { get;  }
		public static string? REVETMENT { get;  }
		public static string? SHIPLIFT { get;  }
		public static string? SHIPLOCK { get;  }
		public static string? SHIPYARD { get;  }
		public static string? SLIPWAY { get;  }
		public static string? WATERWAY { get;  }
		public static string? WATERWAYSHIPLIFT { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMarinePartTypeEnum
	{
		public static string? ABOVEWATERLINE { get;  }
		public static string? ANCHORAGE { get;  }
		public static string? APPROACHCHANNEL { get;  }
		public static string? BELOWWATERLINE { get;  }
		public static string? BERTHINGSTRUCTURE { get;  }
		public static string? CHAMBER { get;  }
		public static string? CILL_LEVEL { get;  }
		public static string? COPELEVEL { get;  }
		public static string? CORE { get;  }
		public static string? CREST { get;  }
		public static string? GATEHEAD { get;  }
		public static string? GUDINGSTRUCTURE { get;  }
		public static string? HIGHWATERLINE { get;  }
		public static string? LANDFIELD { get;  }
		public static string? LEEWARDSIDE { get;  }
		public static string? LOWWATERLINE { get;  }
		public static string? MANUFACTURING { get;  }
		public static string? NAVIGATIONALAREA { get;  }
		public static string? PROTECTION { get;  }
		public static string? SHIPTRANSFER { get;  }
		public static string? STORAGEAREA { get;  }
		public static string? VEHICLESERVICING { get;  }
		public static string? WATERFIELD { get;  }
		public static string? WEATHERSIDE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMobileTelecommunicationsApplianceTypeEnum
	{
		public static string? ACCESSPOINT { get;  }
		public static string? BASEBANDUNIT { get;  }
		public static string? BASETRANSCEIVERSTATION { get;  }
		public static string? E_UTRAN_NODE_B { get;  }
		public static string? GATEWAY_GPRS_SUPPORT_NODE { get;  }
		public static string? MASTERUNIT { get;  }
		public static string? MOBILESWITCHINGCENTER { get;  }
		public static string? MSCSERVER { get;  }
		public static string? PACKETCONTROLUNIT { get;  }
		public static string? REMOTERADIOUNIT { get;  }
		public static string? REMOTEUNIT { get;  }
		public static string? SERVICE_GPRS_SUPPORT_NODE { get;  }
		public static string? SUBSCRIBERSERVER { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcMooringDeviceTypeEnum
	{
		public static string? BOLLARD { get;  }
		public static string? LINETENSIONER { get;  }
		public static string? MAGNETICDEVICE { get;  }
		public static string? MOORINGHOOKS { get;  }
		public static string? VACUUMDEVICE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcNavigationElementTypeEnum
	{
		public static string? BEACON { get;  }
		public static string? BUOY { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcPavementTypeEnum
	{
		public static string? FLEXIBLE { get;  }
		public static string? RIGID { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRailTypeEnum
	{
		public static string? BLADE { get;  }
		public static string? CHECKRAIL { get;  }
		public static string? GUARDRAIL { get;  }
		public static string? RACKRAIL { get;  }
		public static string? RAIL { get;  }
		public static string? STOCKRAIL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRailwayPartTypeEnum
	{
		public static string? ABOVETRACK { get;  }
		public static string? DILATIONTRACK { get;  }
		public static string? LINESIDE { get;  }
		public static string? LINESIDEPART { get;  }
		public static string? PLAINTRACK { get;  }
		public static string? SUBSTRUCTURE { get;  }
		public static string? TRACK { get;  }
		public static string? TRACKPART { get;  }
		public static string? TURNOUTTRACK { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRailwayTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcedSoilTypeEnum
	{
		public static string? DYNAMICALLYCOMPACTED { get;  }
		public static string? GROUTED { get;  }
		public static string? REPLACED { get;  }
		public static string? ROLLERCOMPACTED { get;  }
		public static string? SURCHARGEPRELOADED { get;  }
		public static string? VERTICALLYDRAINED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRoadPartTypeEnum
	{
		public static string? BICYCLECROSSING { get;  }
		public static string? BUS_STOP { get;  }
		public static string? CARRIAGEWAY { get;  }
		public static string? CENTRALISLAND { get;  }
		public static string? CENTRALRESERVE { get;  }
		public static string? HARDSHOULDER { get;  }
		public static string? INTERSECTION { get;  }
		public static string? LAYBY { get;  }
		public static string? PARKINGBAY { get;  }
		public static string? PASSINGBAY { get;  }
		public static string? PEDESTRIAN_CROSSING { get;  }
		public static string? RAILWAYCROSSING { get;  }
		public static string? REFUGEISLAND { get;  }
		public static string? ROADSEGMENT { get;  }
		public static string? ROADSIDE { get;  }
		public static string? ROADSIDEPART { get;  }
		public static string? ROADWAYPLATEAU { get;  }
		public static string? ROUNDABOUT { get;  }
		public static string? SHOULDER { get;  }
		public static string? SIDEWALK { get;  }
		public static string? SOFTSHOULDER { get;  }
		public static string? TOLLPLAZA { get;  }
		public static string? TRAFFICISLAND { get;  }
		public static string? TRAFFICLANE { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcRoadTypeEnum
	{
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSignTypeEnum
	{
		public static string? MARKER { get;  }
		public static string? MIRROR { get;  }
		public static string? PICTORAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcSignalTypeEnum
	{
		public static string? AUDIO { get;  }
		public static string? MIXED { get;  }
		public static string? VISUAL { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcTrackElementTypeEnum
	{
		public static string? BLOCKINGDEVICE { get;  }
		public static string? DERAILER { get;  }
		public static string? FROG { get;  }
		public static string? HALF_SET_OF_BLADES { get;  }
		public static string? SLEEPER { get;  }
		public static string? SPEEDREGULATOR { get;  }
		public static string? TRACKENDOFALIGNMENT { get;  }
		public static string? VEHICLESTOP { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVehicleTypeEnum
	{
		public static string? CARGO { get;  }
		public static string? ROLLINGSTOCK { get;  }
		public static string? VEHICLE { get;  }
		public static string? VEHICLEAIR { get;  }
		public static string? VEHICLEMARINE { get;  }
		public static string? VEHICLETRACKED { get;  }
		public static string? VEHICLEWHEELED { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcVirtualElementTypeEnum
	{
		public static string? BOUNDARY { get;  }
		public static string? CLEARANCE { get;  }
		public static string? PROVISIONFORVOID { get;  }
		public static string? USERDEFINED { get;  }
		public static string? NOTDEFINED { get;  }
		public string? Value { get;  }
	}
	/// <summary>
	/// <summary>
	public interface IfcActorSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAppliedValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAxis2Placement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBooleanOperand
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCharacterStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationNotationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColour: IfcFillStyleSelect, IfcSymbolStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColourOrFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConditionCriterionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCsgSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveFontOrScaledCurveFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveOrEdgeCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveStyleFontSelect: IfcCurveFontOrScaledCurveFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDateTimeSelect: IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDefinedSymbolSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDerivedMeasureValue: IfcValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingCalloutElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillAreaStyleTileShapeSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricSetSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHatchLineDistanceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLayeredItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLibrarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightDistributionDataSourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMeasureValue: IfcValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrientationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointOrVertexPoint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShell
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSimpleValue: IfcValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSizeSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpecularHighlightSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralActivityAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceOrFaceSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSymbolStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTrimmingSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcValue: IfcAppliedValueSelect, IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVectorOrDirection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBendingParameterSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoordinateReferenceSystemSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveOnSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGridPlacementDirectionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfRotationalSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcModulusOfTranslationalSubgradeReactionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProcessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProductRepresentationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProductSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySetDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRotationalStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSegmentIndexSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSolidOrShell
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceBoundarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStyleAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeOrRatioSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTranslationalStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWarpingStiffnessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveMeasureSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcInterferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface Ifc2DCompositeCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActionRequest
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActorRole: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActuatorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAddress: IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminalBoxType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirToAirHeatRecoveryType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlarmType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAngularDimension
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationCurveOccurrence: IfcDraughtingCalloutElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationFillArea
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationFillAreaOccurrence
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationOccurrence
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationSurfaceOccurrence
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationSymbolOccurrence: IfcDraughtingCalloutElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAnnotationTextOccurrence: IfcDraughtingCalloutElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcApplication
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAppliedValue: IfcObjectReferenceSelect, IfcMetricValueSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAppliedValueRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcApproval: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcApprovalActorRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcApprovalPropertyRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcApprovalRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcArbitraryClosedProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcArbitraryOpenProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcArbitraryProfileDefWithVoids
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAsset
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAsymmetricIShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAxis1Placement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAxis2Placement2D: IfcAxis2Placement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAxis2Placement3D: IfcAxis2Placement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBeam
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBeamType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBezierCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBlobTexture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBlock
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoilerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBooleanClippingResult
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBooleanResult: IfcBooleanOperand, IfcCsgSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryEdgeCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryFaceCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryNodeCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryNodeConditionWarping
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundedCurve: IfcCurveOrEdgeCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundedSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundingBox
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoxedHalfSpace
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuilding
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementComponent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementPart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementProxy
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementProxyType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingStorey
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierFittingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCalendarDate: IfcDateTimeSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianPoint: IfcTrimmingSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianTransformationOperator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianTransformationOperator2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianTransformationOperator2DnonUniform
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianTransformationOperator3D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianTransformationOperator3DnonUniform
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCenterLineProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcChamferEdgeFeature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcChillerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCircle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCircleHollowProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCircleProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassification: IfcClassificationReferenceSelect, IfcClassificationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationItemRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationNotation: IfcClassificationNotationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationNotationFacet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClassificationReference: IfcClassificationNotationSelect, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClosedShell: IfcShell, IfcSolidOrShell
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoilType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColourRgb: IfcColourOrFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColourSpecification: IfcColour
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColumn
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColumnType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcComplexProperty
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompositeCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompositeCurveSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompositeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompressorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCondenserType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConditionCriterion
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConic
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectedFaceSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionCurveGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionPointEccentricity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionPointGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionPortGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionSurfaceGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraint: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraintAggregationRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraintClassificationRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraintRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionEquipmentResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionMaterialResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionProductResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcContextDependentUnit: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcControl
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcControllerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConversionBasedUnit: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCooledBeamType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoolingTowerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoordinatedUniversalTimeOffset
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCostItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCostSchedule
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCostValue: IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCovering
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoveringType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCraneRailAShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCraneRailFShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCrewResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCsgPrimitive3D: IfcBooleanOperand, IfcCsgSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCsgSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurrencyRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurtainWall
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurtainWallType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurve: IfcGeometricSetSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveBoundedPlane
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveStyle: IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveStyleFont: IfcCurveStyleFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveStyleFontAndScaling: IfcCurveFontOrScaledCurveFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveStyleFontPattern
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDamperType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDateAndTime: IfcDateTimeSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDefinedSymbol
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDerivedProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDerivedUnit: IfcUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDerivedUnitElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDiameterDimension
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionCalloutRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionCurveDirectedCallout
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionCurveTerminator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionPair
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionalExponents
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDirection: IfcOrientationSelect, IfcVectorOrDirection, IfcGridPlacementDirectionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDiscreteAccessory
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDiscreteAccessoryType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionChamberElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionChamberElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionControlElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionControlElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionFlowElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionFlowElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionPort
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentElectronicFormat
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentInformation: IfcDocumentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentInformationRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDocumentReference: IfcDocumentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorLiningProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorPanelProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorStyle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingCallout
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingCalloutRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingPreDefinedColour
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingPreDefinedCurveFont
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDraughtingPreDefinedTextFont
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctFittingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSilencerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEdge
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEdgeCurve: IfcCurveOrEdgeCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEdgeFeature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEdgeLoop
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricApplianceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricDistributionPoint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowStorageDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricGeneratorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricHeaterType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricMotorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricTimeControlType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricalBaseProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricalCircuit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricalElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElement: IfcStructuralActivityAssignmentSelect, IfcInterferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementAssembly
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementComponent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementComponentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementQuantity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementarySurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEllipse
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEllipseProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEnergyConversionDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEnergyConversionDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEnergyProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEnvironmentalImpactValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEquipmentElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEquipmentStandard
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporativeCoolerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporatorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExtendedMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalReference: IfcLightDistributionDataSourceSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternallyDefinedHatchStyle: IfcFillStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternallyDefinedSurfaceStyle: IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternallyDefinedSymbol: IfcDefinedSymbolSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternallyDefinedTextFont: IfcTextFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExtrudedAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFace
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFaceBasedSurfaceModel: IfcSurfaceOrFaceSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFaceBound
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFaceOuterBound
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFaceSurface: IfcSurfaceOrFaceSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFacetedBrep
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFacetedBrepWithVoids
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFailureConnectionCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFanType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFastener
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFastenerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFeatureElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFeatureElementAddition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFeatureElementSubtraction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillAreaStyle: IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillAreaStyleHatching: IfcFillStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillAreaStyleTileSymbolWithStyle: IfcFillAreaStyleTileShapeSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFillAreaStyleTiles: IfcFillStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFilterType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFireSuppressionTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowController
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowControllerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowFitting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowFittingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowInstrumentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowMeterType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowMovingDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowMovingDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowStorageDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowStorageDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowTreatmentDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowTreatmentDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFluidFlowProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFooting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFuelProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFurnishingElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFurnishingElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFurnitureStandard
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFurnitureType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGasTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeneralMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeneralProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricCurveSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricRepresentationContext: IfcCoordinateReferenceSystemSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricRepresentationItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricRepresentationSubContext
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeometricSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGrid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGridAxis
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGridPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGroup: IfcSpatialReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHalfSpaceSolid: IfcBooleanOperand
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHeatExchangerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHumidifierType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHygroscopicMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcImageTexture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcInventory
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIrregularTimeSeries
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIrregularTimeSeriesValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcJunctionBoxType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLaborResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLampType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLibraryInformation: IfcLibrarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLibraryReference: IfcLibrarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightDistributionData
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightFixtureType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightIntensityDistribution: IfcLightDistributionDataSourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSourceAmbient
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSourceDirectional
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSourceGoniometric
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSourcePositional
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightSourceSpot
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLine
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearDimension
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLocalPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLocalTime: IfcDateTimeSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLoop
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcManifoldSolidBrep
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMappedItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterial: IfcMaterialSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialClassificationRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialDefinitionRepresentation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialLayer: IfcMaterialSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialLayerSet: IfcMaterialSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialLayerSetUsage: IfcMaterialSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialList: IfcMaterialSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMeasureWithUnit: IfcAppliedValueSelect, IfcConditionCriterionSelect, IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalConcreteMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalFastener
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalFastenerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMechanicalSteelMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMember
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMemberType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMetric
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMonetaryUnit: IfcUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMotorConnectionType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMove
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcNamedUnit: IfcUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcObject
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcObjectDefinition: IfcDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcObjectPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcObjective
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOccupant
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOffsetCurve2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOffsetCurve3D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOneDirectionRepeatFactor: IfcHatchLineDistanceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOpenShell: IfcShell
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOpeningElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOpticalMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrderAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrganization: IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrganizationRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrientedEdge
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOutletType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOwnerHistory
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcParameterizedProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPath
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPerformanceHistory
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPermeableCoveringProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPermit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPerson: IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPersonAndOrganization: IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPhysicalComplexQuantity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPhysicalQuantity: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPhysicalSimpleQuantity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPile
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeFittingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPixelTexture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlanarBox
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlanarExtent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlane
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlateType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPoint: IfcGeometricSetSelect, IfcPointOrVertexPoint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointOnCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointOnSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPolyLoop
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPolygonalBoundedHalfSpace
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPolyline
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPort
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPostalAddress
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedColour: IfcColour
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedCurveFont: IfcCurveStyleFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedDimensionSymbol
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedPointMarkerSymbol
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedSymbol: IfcDefinedSymbolSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedTerminatorSymbol
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedTextFont: IfcTextFontSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationLayerAssignment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationLayerWithStyle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationStyle: IfcStyleAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationStyleAssignment: IfcStyleAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProcedure
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProcess: IfcProcessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProduct: IfcProductSelect, IfcSpatialReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProductDefinitionShape: IfcProductRepresentationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProductRepresentation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProductsOfCombustionProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProfileDef: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProject
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectOrder
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectOrderRecord
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectionCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectionElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProperty
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyBoundedValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyConstraintRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyDefinition: IfcDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyDependencyRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyEnumeratedValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyEnumeration
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyListValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyReferenceValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySetDefinition: IfcPropertySetDefinitionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySingleValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyTableValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProxy
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPumpType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityArea
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityCount
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityLength
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityVolume
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityWeight
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRadiusDimension
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRailing
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRailingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRamp
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRampFlight
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRampFlightType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRationalBezierCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRectangleHollowProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRectangleProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRectangularPyramid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRectangularTrimmedSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReferencesValueDocument
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRegularTimeSeries
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcementBarProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcementDefinitionProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingBar
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingMesh
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAggregates
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssigns
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsTasks
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToActor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToControl
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToGroup
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToProcess
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToProduct
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToProjectOrder
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociates
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesAppliedValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesApproval
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesClassification
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesConstraint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesDocument
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesLibrary
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesMaterial
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnects
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsPathElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsPortToElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsPorts
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsStructuralActivity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsStructuralElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsStructuralMember
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsWithEccentricity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelConnectsWithRealizingElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelContainedInSpatialStructure
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelCoversBldgElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelCoversSpaces
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDecomposes
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDefines
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDefinesByProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDefinesByType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelFillsElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelFlowControlElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelInteractionRequirements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelNests
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelOccupiesSpaces
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelOverridesProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelProjectsElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelReferencedInSpatialStructure
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelSchedulesCostItems
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelSequence
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelServicesBuildings
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelSpaceBoundary
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelVoidsElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelaxation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRepresentation: IfcLayeredItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRepresentationContext
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRepresentationItem: IfcLayeredItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRepresentationMap: IfcProductRepresentationSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResource: IfcResourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRevolvedAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRibPlateProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRightCircularCone
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRightCircularCylinder
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoof
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoot
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoundedEdgeFeature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoundedRectangleProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSIUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSanitaryTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcScheduleTimeControl
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionReinforcementProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionedSpine
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSensorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcServiceLife
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcServiceLifeFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShapeAspect: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShapeModel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShapeRepresentation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShellBasedSurfaceModel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSimpleProperty
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSite
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSlab
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSlabType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSlippageConnectionCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSolidModel: IfcBooleanOperand, IfcSolidOrShell
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSoundValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpace: IfcSpaceBoundarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceHeaterType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceProgram
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceThermalLoadProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialStructureElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialStructureElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSphere
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStackTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStair
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStairFlight
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStairFlightType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralActivity
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralAnalysisModel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralConnection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralConnectionCondition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveConnection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveMember
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveMemberVarying
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralItem: IfcStructuralActivityAssignmentSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLinearAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLinearActionVarying
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoad
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadGroup
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadLinearForce
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadPlanarForce
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadSingleDisplacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadSingleDisplacementDistortion
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadSingleForce
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadSingleForceWarping
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadStatic
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadTemperature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralMember
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralPlanarAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralPlanarActionVarying
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralPointAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralPointConnection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralPointReaction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralReaction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralResultGroup
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSteelProfileProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceConnection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceMember
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceMemberVarying
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuredDimensionCallout
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStyleModel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStyledItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStyledRepresentation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSubContractResource
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSubedge
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurface: IfcGeometricSetSelect, IfcSurfaceOrFaceSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceCurveSweptAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceOfLinearExtrusion
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceOfRevolution
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyle: IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleLighting: IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleRefraction: IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleRendering
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleShading: IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceStyleWithTextures: IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceTexture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSweptAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSweptDiskSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSweptSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSwitchingDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSymbolStyle: IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSystem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSystemFurnitureElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTable: IfcMetricValueSelect, IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTableRow
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTankType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTask
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTelecomAddress
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendon
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonAnchor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTerminatorSymbol
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextLiteral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextLiteralWithExtent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyle: IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyleFontModel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyleForDefinedFont: IfcCharacterStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyleTextModel: IfcTextStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextStyleWithBoxCharacteristics: IfcTextStyleSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureCoordinate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureCoordinateGenerator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureVertex
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcThermalMaterialProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeries: IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeriesReferenceRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeriesSchedule
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimeSeriesValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTopologicalRepresentationItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTopologyRepresentation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransformerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransportElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransportElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTrapeziumProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTrimmedCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTubeBundleType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTwoDirectionRepeatFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTypeObject
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTypeProduct: IfcProductSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitAssignment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryEquipmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcValveType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVector: IfcVectorOrDirection, IfcHatchLineDistanceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVertex
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVertexBasedTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVertexLoop
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVertexPoint: IfcPointOrVertexPoint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationIsolatorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVirtualElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVirtualGridIntersection: IfcGridPlacementDirectionSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWall
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWallStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWallType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWasteTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWaterProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindow
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowLiningProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowPanelProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowStyle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkControl
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkPlan
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkSchedule
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcZShapeProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcZone
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcActuator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAdvancedBrep
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAdvancedBrepWithVoids
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAdvancedFace
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirTerminalBox
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAirToAirHeatRecovery
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlarm
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAudioVisualAppliance
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAudioVisualApplianceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineCurveWithKnots
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBSplineSurfaceWithKnots
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBeamStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoiler
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBoundaryCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingElementPartType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildingSystem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBurner
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBurnerType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierFitting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableCarrierSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableFitting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableFittingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCableSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianPointList
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianPointList2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCartesianPointList3D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcChiller
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcChimney
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcChimneyType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCivilElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCivilElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoil
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColourRgbList
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcColumnStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCommunicationsAppliance
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCommunicationsApplianceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcComplexPropertyTemplate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompositeCurveOnSurface: IfcCurveOnSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCompressor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCondenser
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConnectionVolumeGeometry
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionEquipmentResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionMaterialResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionProductResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstructionResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcContext
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcController
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConversionBasedUnitWithOffset
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCooledBeam
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoolingTower
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoordinateOperation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCoordinateReferenceSystem: IfcCoordinateReferenceSystemSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCrewResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveBoundedSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCylindricalSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDamper
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionCircuit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionSystem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDoorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctFitting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDuctSilencer
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricAppliance
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricDistributionBoard
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricDistributionBoardType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowStorageDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricGenerator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricMotor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricTimeControl
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElementAssemblyType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEngine
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEngineType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporativeCooler
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEvaporator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEvent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEventTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEventType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExtendedProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalInformation: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalReferenceRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalSpatialElement: IfcSpaceBoundarySelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExternalSpatialStructureElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcExtrudedAreaSolidTapered
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFan
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFilter
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFireSuppressionTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFixedReferenceSweptAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowInstrument
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFlowMeter
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFootingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFurniture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeographicElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeographicElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHeatExchanger
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcHumidifier
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedColourMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedPolyCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedPolygonalFace
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedPolygonalFaceWithVoids
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedTriangleTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcInterceptor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcInterceptorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIntersectionCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcJunctionBox
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLaborResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLagTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLamp
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLightFixture
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMapConversion
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialConstituent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialConstituentSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialDefinition: IfcMaterialSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialLayerWithOffsets
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProfile
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProfileSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProfileSetUsage
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProfileSetUsageTapering
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialProfileWithOffsets
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMaterialUsageDefinition: IfcMaterialSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMedicalDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMedicalDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMemberStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMirroredProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMotorConnection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOpeningStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOuterBoundaryCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOutlet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPcurve: IfcCurveOnSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPileType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeFitting
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPipeSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPlateStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPolygonalFaceSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedProperties
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPreDefinedPropertySet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPresentationItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProcedureType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectLibrary
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProjectedCRS
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyAbstraction: IfcResourceObjectSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertySetTemplate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyTemplate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPropertyTemplateDefinition
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDeviceTrippingUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcProtectiveDeviceTrippingUnitType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPump
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantitySet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRampType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRationalBSplineCurveWithKnots
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRationalBSplineSurfaceWithKnots
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRecurrencePattern
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReference: IfcAppliedValueSelect, IfcMetricValueSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingBarType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcingMeshType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssignsToGroupByFactor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDeclares
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDefinesByObject
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelDefinesByTemplate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelInterferesElements
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelSpaceBoundary1stLevel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelSpaceBoundary2ndLevel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReparametrisedCompositeCurveSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceApprovalRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceConstraintRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceLevelRelationship
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcResourceTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRevolvedAreaSolidTapered
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoofType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSanitaryTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSchedulingTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSeamCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSensor
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShadingDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShadingDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSimplePropertyTemplate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSlabElementedCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSlabStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSolarDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSolarDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpaceHeater
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialElement: IfcInterferenceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialZone
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpatialZoneType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSphericalSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStackTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStairType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralCurveReaction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadConfiguration
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralLoadOrResult
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceAction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcStructuralSurfaceReaction
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSubContractResourceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceCurve: IfcCurveOnSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceFeature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceReinforcementArea
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSweptDiskSolidPolygonal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSwitchingDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSystemFurnitureElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTableColumn
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTank
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTaskTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTaskTimeRecurring
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTaskType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonAnchorType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTessellatedFaceSet: IfcBooleanOperand
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTessellatedItem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureVertexList
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTimePeriod
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcToroidalSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransformer
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTriangulatedFaceSet
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTubeBundle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTypeProcess: IfcProcessSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTypeResource: IfcResourceSelect
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryControlElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryControlElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUnitaryEquipment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcValve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationIsolator
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVoidingFeature
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWallElementedCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWasteTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowStandardCase
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWindowType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkCalendar
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWorkTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DHorizontal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DHorizontalSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DVerSegCircularArc
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DVerSegLine
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DVerSegParabolicArc
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DVertical
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignment2DVerticalSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCircularArcSegment2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveSegment2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistanceExpression
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLineSegment2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearPositioningElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOffsetCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOffsetCurveByDistances
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrientationExpression
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPositioningElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReferent
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionedSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionedSolidHorizontal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransitionCurveSegment2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTriangulatedIrregularNetwork
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBearing
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBearingType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBridge
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBridgePart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCaissonFoundation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCaissonFoundationType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDeepFoundation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDeepFoundationType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFacility
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFacilityPart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelPositions
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonConduit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTendonConduitType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationDamper
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVibrationDamperType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentCant
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentCantSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentHorizontal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentHorizontalSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentParameterSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentVertical
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAlignmentVerticalSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAxis2PlacementLinear
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBorehole
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuiltElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuiltElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuiltSystem
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcClothoid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConveyorSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConveyorSegmentType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCosineSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCourse
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCourseType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDirectrixCurveSweptAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDirectrixDerivedReferenceSweptAreaSolid
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionBoard
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDistributionBoardType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEarthworksCut
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEarthworksElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcEarthworksFill
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowTreatmentDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcElectricFlowTreatmentDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFacilityPartCommon
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeographicCRS
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeomodel
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeoslice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeotechnicalAssembly
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeotechnicalElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGeotechnicalStratum
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGradientCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcImpactProtectionDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcImpactProtectionDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcIndexedPolygonalTextureMap
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcKerb
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcKerbType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLinearElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLiquidTerminal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLiquidTerminalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMapConversionScaled
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMarineFacility
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMarinePart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMobileTelecommunicationsAppliance
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMobileTelecommunicationsApplianceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMooringDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMooringDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcNavigationElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcNavigationElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOpenCrossProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPavement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPavementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointByDistanceExpression
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPolynomialCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcQuantityNumber
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRail
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRailType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRailway
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRailwayPart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcReinforcedSoil
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAdheresToElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRelAssociatesProfileDef
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRigidOperation
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoad
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcRoadPart
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSecondOrderPolynomialSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSectionedSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSegment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSegmentedReferenceCurve
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSeventhOrderPolynomialSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSign
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSignType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSignal
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSignalType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSineSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureCoordinateIndices
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTextureCoordinateIndicesWithVoids
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcThirdOrderPolynomialSpiral
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTrackElement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTrackElementType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransportationDevice
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTransportationDeviceType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVehicle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVehicleType
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcWellKnownText
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAddToBeginOfList
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBaseAxis
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBooleanChoose
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuild2Axes
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcBuildAxes
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCorrectDimensions
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCorrectFillAreaStyle
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCorrectLocalPlacement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCorrectObjectAssignment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCorrectUnitAssignment
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCrossProduct
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveDim
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcCurveWeightsPositive
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDeriveDimensionalExponents
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionsForSiUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDotProduct
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcFirstProjAxis
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLeapYear
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcListToArray
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcLoopHeadToTail
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMlsTotalThickness
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcNormalise
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcOrthogonalComplement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPathHeadToTail
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSameAxis2Placement
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSameCartesianPoint
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSameDirection
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSameValidPrecision
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSameValue
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcScalarTimesVector
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSecondProjAxis
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcShapeRepresentationTypes
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTopologyRepresentationTypes
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUniquePropertyName
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcValidCalendarDate
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcValidTime
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVectorDifference
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcVectorSum
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcAssociatedSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConsecutiveSegments
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConstraintsParamBSpline
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcConvertDirectionInto2D
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcGetBasisSurface
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcMakeArrayOfArray
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointListDim
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSurfaceWeightsPositive
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcTaperedSweptAreaProfiles
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUniqueDefinitionNames
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUniquePropertySetNames
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUniquePropertyTemplateNames
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcUniqueQuantityNames
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcDimensionsForSIUnit
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcPointDim
	{
	}
	/// <summary>
	/// <summary>
	public interface IfcSegmentDim
	{
	}
}
