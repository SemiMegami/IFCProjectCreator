	/// <summary>
	/// TYPE IfcAbsorbedDoseMeasure = REAL;
	/// <para>TYPE IfcAbsorbedDoseMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcAbsorbedDoseMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcAbsorbedDoseMeasure() { }
		IfcAbsorbedDoseMeasure(double value) { Value = value; }
		public static implicit operator IfcAbsorbedDoseMeasure(double value) { return new IfcAbsorbedDoseMeasure(double);}
		public static implicit operator double(IfcAbsorbedDoseMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcAccelerationMeasure = REAL;
	/// <para>TYPE IfcAccelerationMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcAccelerationMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcAccelerationMeasure() { }
		IfcAccelerationMeasure(double value) { Value = value; }
		public static implicit operator IfcAccelerationMeasure(double value) { return new IfcAccelerationMeasure(double);}
		public static implicit operator double(IfcAccelerationMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcAmountOfSubstanceMeasure = REAL;
	/// <para>TYPE IfcAmountOfSubstanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcAmountOfSubstanceMeasure : REAL, IfcMeasureValue
	{
		IfcAmountOfSubstanceMeasure() { }
		IfcAmountOfSubstanceMeasure(double value) { Value = value; }
		public static implicit operator IfcAmountOfSubstanceMeasure(double value) { return new IfcAmountOfSubstanceMeasure(double);}
		public static implicit operator double(IfcAmountOfSubstanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcAngularVelocityMeasure = REAL;
	/// <para>TYPE IfcAngularVelocityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcAngularVelocityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcAngularVelocityMeasure() { }
		IfcAngularVelocityMeasure(double value) { Value = value; }
		public static implicit operator IfcAngularVelocityMeasure(double value) { return new IfcAngularVelocityMeasure(double);}
		public static implicit operator double(IfcAngularVelocityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcAreaMeasure = REAL;
	/// <para>TYPE IfcAreaMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcAreaMeasure : REAL, IfcMeasureValue
	{
		IfcAreaMeasure() { }
		IfcAreaMeasure(double value) { Value = value; }
		public static implicit operator IfcAreaMeasure(double value) { return new IfcAreaMeasure(double);}
		public static implicit operator double(IfcAreaMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcBoolean = BOOLEAN;
	/// <para>TYPE IfcBoolean = BOOLEAN;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcBoolean : BOOLEAN, IfcSimpleValue
	{
		IfcBoolean() { }
		IfcBoolean(bool value) { Value = value; }
		public static implicit operator IfcBoolean(bool value) { return new IfcBoolean(bool);}
		public static implicit operator bool(IfcBoolean value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcBoxAlignment = IfcLabel;
	/// <para>TYPE IfcBoxAlignment = IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['top-left', 'top-middle', 'top-right', 'middle-left', 'center', 'middle-right', 'bottom-left', 'bottom-middle', 'bottom-right'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcBoxAlignment : IfcLabel
	{
		IfcBoxAlignment() { }
		IfcBoxAlignment(string value) { Value = value; }
		public static implicit operator IfcBoxAlignment(string value) { return new IfcBoxAlignment(string);}
		public static implicit operator string(IfcBoxAlignment value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcContextDependentMeasure = REAL;
	/// <para>TYPE IfcContextDependentMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcContextDependentMeasure : REAL, IfcMeasureValue
	{
		IfcContextDependentMeasure() { }
		IfcContextDependentMeasure(double value) { Value = value; }
		public static implicit operator IfcContextDependentMeasure(double value) { return new IfcContextDependentMeasure(double);}
		public static implicit operator double(IfcContextDependentMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcCountMeasure = NUMBER;
	/// <para>TYPE IfcCountMeasure = NUMBER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcCountMeasure : NUMBER, IfcMeasureValue
	{
		IfcCountMeasure() { }
		IfcCountMeasure(double value) { Value = value; }
		public static implicit operator IfcCountMeasure(double value) { return new IfcCountMeasure(double);}
		public static implicit operator double(IfcCountMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcCurvatureMeasure = REAL;
	/// <para>TYPE IfcCurvatureMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcCurvatureMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcCurvatureMeasure() { }
		IfcCurvatureMeasure(double value) { Value = value; }
		public static implicit operator IfcCurvatureMeasure(double value) { return new IfcCurvatureMeasure(double);}
		public static implicit operator double(IfcCurvatureMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDayInMonthNumber = INTEGER;
	/// <para>TYPE IfcDayInMonthNumber = INTEGER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDayInMonthNumber : INTEGER
	{
		IfcDayInMonthNumber() { }
		IfcDayInMonthNumber(int value) { Value = value; }
		public static implicit operator IfcDayInMonthNumber(int value) { return new IfcDayInMonthNumber(int);}
		public static implicit operator int(IfcDayInMonthNumber value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDaylightSavingHour = INTEGER;
	/// <para>TYPE IfcDaylightSavingHour = INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : { 0 <= SELF <= 2 };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDaylightSavingHour : INTEGER
	{
		IfcDaylightSavingHour() { }
		IfcDaylightSavingHour(int value) { Value = value; }
		public static implicit operator IfcDaylightSavingHour(int value) { return new IfcDaylightSavingHour(int);}
		public static implicit operator int(IfcDaylightSavingHour value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDescriptiveMeasure = STRING;
	/// <para>TYPE IfcDescriptiveMeasure = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDescriptiveMeasure : STRING, IfcMeasureValue, IfcSizeSelect
	{
		IfcDescriptiveMeasure() { }
		IfcDescriptiveMeasure(string value) { Value = value; }
		public static implicit operator IfcDescriptiveMeasure(string value) { return new IfcDescriptiveMeasure(string);}
		public static implicit operator string(IfcDescriptiveMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDimensionCount = INTEGER;
	/// <para>TYPE IfcDimensionCount = INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : { 0 < SELF <= 3 };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDimensionCount : INTEGER
	{
		IfcDimensionCount() { }
		IfcDimensionCount(int value) { Value = value; }
		public static implicit operator IfcDimensionCount(int value) { return new IfcDimensionCount(int);}
		public static implicit operator int(IfcDimensionCount value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDoseEquivalentMeasure = REAL;
	/// <para>TYPE IfcDoseEquivalentMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDoseEquivalentMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcDoseEquivalentMeasure() { }
		IfcDoseEquivalentMeasure(double value) { Value = value; }
		public static implicit operator IfcDoseEquivalentMeasure(double value) { return new IfcDoseEquivalentMeasure(double);}
		public static implicit operator double(IfcDoseEquivalentMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcDynamicViscosityMeasure = REAL;
	/// <para>TYPE IfcDynamicViscosityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcDynamicViscosityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcDynamicViscosityMeasure() { }
		IfcDynamicViscosityMeasure(double value) { Value = value; }
		public static implicit operator IfcDynamicViscosityMeasure(double value) { return new IfcDynamicViscosityMeasure(double);}
		public static implicit operator double(IfcDynamicViscosityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricCapacitanceMeasure = REAL;
	/// <para>TYPE IfcElectricCapacitanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricCapacitanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcElectricCapacitanceMeasure() { }
		IfcElectricCapacitanceMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricCapacitanceMeasure(double value) { return new IfcElectricCapacitanceMeasure(double);}
		public static implicit operator double(IfcElectricCapacitanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricChargeMeasure = REAL;
	/// <para>TYPE IfcElectricChargeMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricChargeMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcElectricChargeMeasure() { }
		IfcElectricChargeMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricChargeMeasure(double value) { return new IfcElectricChargeMeasure(double);}
		public static implicit operator double(IfcElectricChargeMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricConductanceMeasure = REAL;
	/// <para>TYPE IfcElectricConductanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricConductanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcElectricConductanceMeasure() { }
		IfcElectricConductanceMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricConductanceMeasure(double value) { return new IfcElectricConductanceMeasure(double);}
		public static implicit operator double(IfcElectricConductanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricCurrentMeasure = REAL;
	/// <para>TYPE IfcElectricCurrentMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricCurrentMeasure : REAL, IfcMeasureValue
	{
		IfcElectricCurrentMeasure() { }
		IfcElectricCurrentMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricCurrentMeasure(double value) { return new IfcElectricCurrentMeasure(double);}
		public static implicit operator double(IfcElectricCurrentMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricResistanceMeasure = REAL;
	/// <para>TYPE IfcElectricResistanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricResistanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcElectricResistanceMeasure() { }
		IfcElectricResistanceMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricResistanceMeasure(double value) { return new IfcElectricResistanceMeasure(double);}
		public static implicit operator double(IfcElectricResistanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcElectricVoltageMeasure = REAL;
	/// <para>TYPE IfcElectricVoltageMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcElectricVoltageMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcElectricVoltageMeasure() { }
		IfcElectricVoltageMeasure(double value) { Value = value; }
		public static implicit operator IfcElectricVoltageMeasure(double value) { return new IfcElectricVoltageMeasure(double);}
		public static implicit operator double(IfcElectricVoltageMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcEnergyMeasure = REAL;
	/// <para>TYPE IfcEnergyMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcEnergyMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcEnergyMeasure() { }
		IfcEnergyMeasure(double value) { Value = value; }
		public static implicit operator IfcEnergyMeasure(double value) { return new IfcEnergyMeasure(double);}
		public static implicit operator double(IfcEnergyMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcFontStyle = STRING;
	/// <para>TYPE IfcFontStyle = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['normal','italic','oblique'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcFontStyle : STRING
	{
		IfcFontStyle() { }
		IfcFontStyle(string value) { Value = value; }
		public static implicit operator IfcFontStyle(string value) { return new IfcFontStyle(string);}
		public static implicit operator string(IfcFontStyle value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcFontVariant = STRING;
	/// <para>TYPE IfcFontVariant = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['normal','small-caps'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcFontVariant : STRING
	{
		IfcFontVariant() { }
		IfcFontVariant(string value) { Value = value; }
		public static implicit operator IfcFontVariant(string value) { return new IfcFontVariant(string);}
		public static implicit operator string(IfcFontVariant value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcFontWeight = STRING;
	/// <para>TYPE IfcFontWeight = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['normal','small-caps','100','200','300','400','500','600','700','800','900'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcFontWeight : STRING
	{
		IfcFontWeight() { }
		IfcFontWeight(string value) { Value = value; }
		public static implicit operator IfcFontWeight(string value) { return new IfcFontWeight(string);}
		public static implicit operator string(IfcFontWeight value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcForceMeasure = REAL;
	/// <para>TYPE IfcForceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcForceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcForceMeasure() { }
		IfcForceMeasure(double value) { Value = value; }
		public static implicit operator IfcForceMeasure(double value) { return new IfcForceMeasure(double);}
		public static implicit operator double(IfcForceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcFrequencyMeasure = REAL;
	/// <para>TYPE IfcFrequencyMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcFrequencyMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcFrequencyMeasure() { }
		IfcFrequencyMeasure(double value) { Value = value; }
		public static implicit operator IfcFrequencyMeasure(double value) { return new IfcFrequencyMeasure(double);}
		public static implicit operator double(IfcFrequencyMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcGloballyUniqueId = STRING(22) FIXED;
	/// <para>TYPE IfcGloballyUniqueId = STRING(22) FIXED;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcGloballyUniqueId : STRING
	{
		IfcGloballyUniqueId() { }
		IfcGloballyUniqueId(string value) { Value = value; }
		public static implicit operator IfcGloballyUniqueId(string value) { return new IfcGloballyUniqueId(string);}
		public static implicit operator string(IfcGloballyUniqueId value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcHeatFluxDensityMeasure = REAL;
	/// <para>TYPE IfcHeatFluxDensityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcHeatFluxDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcHeatFluxDensityMeasure() { }
		IfcHeatFluxDensityMeasure(double value) { Value = value; }
		public static implicit operator IfcHeatFluxDensityMeasure(double value) { return new IfcHeatFluxDensityMeasure(double);}
		public static implicit operator double(IfcHeatFluxDensityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcHeatingValueMeasure = REAL;
	/// <para>TYPE IfcHeatingValueMeasure = REAL;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF > 0.;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcHeatingValueMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcHeatingValueMeasure() { }
		IfcHeatingValueMeasure(double value) { Value = value; }
		public static implicit operator IfcHeatingValueMeasure(double value) { return new IfcHeatingValueMeasure(double);}
		public static implicit operator double(IfcHeatingValueMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcHourInDay = INTEGER;
	/// <para>TYPE IfcHourInDay = INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : { 0 <= SELF < 24 };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcHourInDay : INTEGER
	{
		IfcHourInDay() { }
		IfcHourInDay(int value) { Value = value; }
		public static implicit operator IfcHourInDay(int value) { return new IfcHourInDay(int);}
		public static implicit operator int(IfcHourInDay value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcIdentifier = STRING;
	/// <para>TYPE IfcIdentifier = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcIdentifier : STRING, IfcSimpleValue
	{
		IfcIdentifier() { }
		IfcIdentifier(string value) { Value = value; }
		public static implicit operator IfcIdentifier(string value) { return new IfcIdentifier(string);}
		public static implicit operator string(IfcIdentifier value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcIlluminanceMeasure = REAL;
	/// <para>TYPE IfcIlluminanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcIlluminanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcIlluminanceMeasure() { }
		IfcIlluminanceMeasure(double value) { Value = value; }
		public static implicit operator IfcIlluminanceMeasure(double value) { return new IfcIlluminanceMeasure(double);}
		public static implicit operator double(IfcIlluminanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcInductanceMeasure = REAL;
	/// <para>TYPE IfcInductanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcInductanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcInductanceMeasure() { }
		IfcInductanceMeasure(double value) { Value = value; }
		public static implicit operator IfcInductanceMeasure(double value) { return new IfcInductanceMeasure(double);}
		public static implicit operator double(IfcInductanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcInteger = INTEGER;
	/// <para>TYPE IfcInteger = INTEGER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcInteger : INTEGER, IfcSimpleValue
	{
		IfcInteger() { }
		IfcInteger(int value) { Value = value; }
		public static implicit operator IfcInteger(int value) { return new IfcInteger(int);}
		public static implicit operator int(IfcInteger value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcIntegerCountRateMeasure = INTEGER;
	/// <para>TYPE IfcIntegerCountRateMeasure = INTEGER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcIntegerCountRateMeasure : INTEGER, IfcDerivedMeasureValue
	{
		IfcIntegerCountRateMeasure() { }
		IfcIntegerCountRateMeasure(int value) { Value = value; }
		public static implicit operator IfcIntegerCountRateMeasure(int value) { return new IfcIntegerCountRateMeasure(int);}
		public static implicit operator int(IfcIntegerCountRateMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcIonConcentrationMeasure = REAL;
	/// <para>TYPE IfcIonConcentrationMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcIonConcentrationMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcIonConcentrationMeasure() { }
		IfcIonConcentrationMeasure(double value) { Value = value; }
		public static implicit operator IfcIonConcentrationMeasure(double value) { return new IfcIonConcentrationMeasure(double);}
		public static implicit operator double(IfcIonConcentrationMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcIsothermalMoistureCapacityMeasure = REAL;
	/// <para>TYPE IfcIsothermalMoistureCapacityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcIsothermalMoistureCapacityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcIsothermalMoistureCapacityMeasure() { }
		IfcIsothermalMoistureCapacityMeasure(double value) { Value = value; }
		public static implicit operator IfcIsothermalMoistureCapacityMeasure(double value) { return new IfcIsothermalMoistureCapacityMeasure(double);}
		public static implicit operator double(IfcIsothermalMoistureCapacityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcKinematicViscosityMeasure = REAL;
	/// <para>TYPE IfcKinematicViscosityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcKinematicViscosityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcKinematicViscosityMeasure() { }
		IfcKinematicViscosityMeasure(double value) { Value = value; }
		public static implicit operator IfcKinematicViscosityMeasure(double value) { return new IfcKinematicViscosityMeasure(double);}
		public static implicit operator double(IfcKinematicViscosityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLabel = STRING;
	/// <para>TYPE IfcLabel = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLabel : STRING, IfcConditionCriterionSelect, IfcSimpleValue
	{
		IfcLabel() { }
		IfcLabel(string value) { Value = value; }
		public static implicit operator IfcLabel(string value) { return new IfcLabel(string);}
		public static implicit operator string(IfcLabel value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLengthMeasure = REAL;
	/// <para>TYPE IfcLengthMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLengthMeasure : REAL, IfcMeasureValue, IfcSizeSelect
	{
		IfcLengthMeasure() { }
		IfcLengthMeasure(double value) { Value = value; }
		public static implicit operator IfcLengthMeasure(double value) { return new IfcLengthMeasure(double);}
		public static implicit operator double(IfcLengthMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLinearForceMeasure = REAL;
	/// <para>TYPE IfcLinearForceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLinearForceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLinearForceMeasure() { }
		IfcLinearForceMeasure(double value) { Value = value; }
		public static implicit operator IfcLinearForceMeasure(double value) { return new IfcLinearForceMeasure(double);}
		public static implicit operator double(IfcLinearForceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLinearMomentMeasure = REAL;
	/// <para>TYPE IfcLinearMomentMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLinearMomentMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLinearMomentMeasure() { }
		IfcLinearMomentMeasure(double value) { Value = value; }
		public static implicit operator IfcLinearMomentMeasure(double value) { return new IfcLinearMomentMeasure(double);}
		public static implicit operator double(IfcLinearMomentMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLinearStiffnessMeasure = REAL;
	/// <para>TYPE IfcLinearStiffnessMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLinearStiffnessMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLinearStiffnessMeasure() { }
		IfcLinearStiffnessMeasure(double value) { Value = value; }
		public static implicit operator IfcLinearStiffnessMeasure(double value) { return new IfcLinearStiffnessMeasure(double);}
		public static implicit operator double(IfcLinearStiffnessMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLinearVelocityMeasure = REAL;
	/// <para>TYPE IfcLinearVelocityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLinearVelocityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLinearVelocityMeasure() { }
		IfcLinearVelocityMeasure(double value) { Value = value; }
		public static implicit operator IfcLinearVelocityMeasure(double value) { return new IfcLinearVelocityMeasure(double);}
		public static implicit operator double(IfcLinearVelocityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLogical = LOGICAL;
	/// <para>TYPE IfcLogical = LOGICAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLogical : LOGICAL, IfcSimpleValue
	{
		IfcLogical() { }
		IfcLogical(bool value) { Value = value; }
		public static implicit operator IfcLogical(bool value) { return new IfcLogical(bool);}
		public static implicit operator bool(IfcLogical value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLuminousFluxMeasure = REAL;
	/// <para>TYPE IfcLuminousFluxMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLuminousFluxMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLuminousFluxMeasure() { }
		IfcLuminousFluxMeasure(double value) { Value = value; }
		public static implicit operator IfcLuminousFluxMeasure(double value) { return new IfcLuminousFluxMeasure(double);}
		public static implicit operator double(IfcLuminousFluxMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLuminousIntensityDistributionMeasure = REAL;
	/// <para>TYPE IfcLuminousIntensityDistributionMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLuminousIntensityDistributionMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcLuminousIntensityDistributionMeasure() { }
		IfcLuminousIntensityDistributionMeasure(double value) { Value = value; }
		public static implicit operator IfcLuminousIntensityDistributionMeasure(double value) { return new IfcLuminousIntensityDistributionMeasure(double);}
		public static implicit operator double(IfcLuminousIntensityDistributionMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcLuminousIntensityMeasure = REAL;
	/// <para>TYPE IfcLuminousIntensityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcLuminousIntensityMeasure : REAL, IfcMeasureValue
	{
		IfcLuminousIntensityMeasure() { }
		IfcLuminousIntensityMeasure(double value) { Value = value; }
		public static implicit operator IfcLuminousIntensityMeasure(double value) { return new IfcLuminousIntensityMeasure(double);}
		public static implicit operator double(IfcLuminousIntensityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMagneticFluxDensityMeasure = REAL;
	/// <para>TYPE IfcMagneticFluxDensityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMagneticFluxDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMagneticFluxDensityMeasure() { }
		IfcMagneticFluxDensityMeasure(double value) { Value = value; }
		public static implicit operator IfcMagneticFluxDensityMeasure(double value) { return new IfcMagneticFluxDensityMeasure(double);}
		public static implicit operator double(IfcMagneticFluxDensityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMagneticFluxMeasure = REAL;
	/// <para>TYPE IfcMagneticFluxMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMagneticFluxMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMagneticFluxMeasure() { }
		IfcMagneticFluxMeasure(double value) { Value = value; }
		public static implicit operator IfcMagneticFluxMeasure(double value) { return new IfcMagneticFluxMeasure(double);}
		public static implicit operator double(IfcMagneticFluxMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMassDensityMeasure = REAL;
	/// <para>TYPE IfcMassDensityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMassDensityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMassDensityMeasure() { }
		IfcMassDensityMeasure(double value) { Value = value; }
		public static implicit operator IfcMassDensityMeasure(double value) { return new IfcMassDensityMeasure(double);}
		public static implicit operator double(IfcMassDensityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMassFlowRateMeasure = REAL;
	/// <para>TYPE IfcMassFlowRateMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMassFlowRateMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMassFlowRateMeasure() { }
		IfcMassFlowRateMeasure(double value) { Value = value; }
		public static implicit operator IfcMassFlowRateMeasure(double value) { return new IfcMassFlowRateMeasure(double);}
		public static implicit operator double(IfcMassFlowRateMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMassMeasure = REAL;
	/// <para>TYPE IfcMassMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMassMeasure : REAL, IfcMeasureValue
	{
		IfcMassMeasure() { }
		IfcMassMeasure(double value) { Value = value; }
		public static implicit operator IfcMassMeasure(double value) { return new IfcMassMeasure(double);}
		public static implicit operator double(IfcMassMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMassPerLengthMeasure = REAL;
	/// <para>TYPE IfcMassPerLengthMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMassPerLengthMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMassPerLengthMeasure() { }
		IfcMassPerLengthMeasure(double value) { Value = value; }
		public static implicit operator IfcMassPerLengthMeasure(double value) { return new IfcMassPerLengthMeasure(double);}
		public static implicit operator double(IfcMassPerLengthMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMinuteInHour = INTEGER;
	/// <para>TYPE IfcMinuteInHour = INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : {0 <= SELF <= 59 };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMinuteInHour : INTEGER
	{
		IfcMinuteInHour() { }
		IfcMinuteInHour(int value) { Value = value; }
		public static implicit operator IfcMinuteInHour(int value) { return new IfcMinuteInHour(int);}
		public static implicit operator int(IfcMinuteInHour value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcModulusOfElasticityMeasure = REAL;
	/// <para>TYPE IfcModulusOfElasticityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcModulusOfElasticityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcModulusOfElasticityMeasure() { }
		IfcModulusOfElasticityMeasure(double value) { Value = value; }
		public static implicit operator IfcModulusOfElasticityMeasure(double value) { return new IfcModulusOfElasticityMeasure(double);}
		public static implicit operator double(IfcModulusOfElasticityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcModulusOfLinearSubgradeReactionMeasure = REAL;
	/// <para>TYPE IfcModulusOfLinearSubgradeReactionMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcModulusOfLinearSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcModulusOfLinearSubgradeReactionMeasure() { }
		IfcModulusOfLinearSubgradeReactionMeasure(double value) { Value = value; }
		public static implicit operator IfcModulusOfLinearSubgradeReactionMeasure(double value) { return new IfcModulusOfLinearSubgradeReactionMeasure(double);}
		public static implicit operator double(IfcModulusOfLinearSubgradeReactionMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcModulusOfRotationalSubgradeReactionMeasure = REAL;
	/// <para>TYPE IfcModulusOfRotationalSubgradeReactionMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcModulusOfRotationalSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcModulusOfRotationalSubgradeReactionMeasure() { }
		IfcModulusOfRotationalSubgradeReactionMeasure(double value) { Value = value; }
		public static implicit operator IfcModulusOfRotationalSubgradeReactionMeasure(double value) { return new IfcModulusOfRotationalSubgradeReactionMeasure(double);}
		public static implicit operator double(IfcModulusOfRotationalSubgradeReactionMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcModulusOfSubgradeReactionMeasure = REAL;
	/// <para>TYPE IfcModulusOfSubgradeReactionMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcModulusOfSubgradeReactionMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcModulusOfSubgradeReactionMeasure() { }
		IfcModulusOfSubgradeReactionMeasure(double value) { Value = value; }
		public static implicit operator IfcModulusOfSubgradeReactionMeasure(double value) { return new IfcModulusOfSubgradeReactionMeasure(double);}
		public static implicit operator double(IfcModulusOfSubgradeReactionMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMoistureDiffusivityMeasure = REAL;
	/// <para>TYPE IfcMoistureDiffusivityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMoistureDiffusivityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMoistureDiffusivityMeasure() { }
		IfcMoistureDiffusivityMeasure(double value) { Value = value; }
		public static implicit operator IfcMoistureDiffusivityMeasure(double value) { return new IfcMoistureDiffusivityMeasure(double);}
		public static implicit operator double(IfcMoistureDiffusivityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMolecularWeightMeasure = REAL;
	/// <para>TYPE IfcMolecularWeightMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMolecularWeightMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMolecularWeightMeasure() { }
		IfcMolecularWeightMeasure(double value) { Value = value; }
		public static implicit operator IfcMolecularWeightMeasure(double value) { return new IfcMolecularWeightMeasure(double);}
		public static implicit operator double(IfcMolecularWeightMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMomentOfInertiaMeasure = REAL;
	/// <para>TYPE IfcMomentOfInertiaMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMomentOfInertiaMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcMomentOfInertiaMeasure() { }
		IfcMomentOfInertiaMeasure(double value) { Value = value; }
		public static implicit operator IfcMomentOfInertiaMeasure(double value) { return new IfcMomentOfInertiaMeasure(double);}
		public static implicit operator double(IfcMomentOfInertiaMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMonetaryMeasure = REAL;
	/// <para>TYPE IfcMonetaryMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMonetaryMeasure : REAL, IfcAppliedValueSelect, IfcDerivedMeasureValue
	{
		IfcMonetaryMeasure() { }
		IfcMonetaryMeasure(double value) { Value = value; }
		public static implicit operator IfcMonetaryMeasure(double value) { return new IfcMonetaryMeasure(double);}
		public static implicit operator double(IfcMonetaryMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcMonthInYearNumber = INTEGER;
	/// <para>TYPE IfcMonthInYearNumber = INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : { 1<= SELF <= 12 };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcMonthInYearNumber : INTEGER
	{
		IfcMonthInYearNumber() { }
		IfcMonthInYearNumber(int value) { Value = value; }
		public static implicit operator IfcMonthInYearNumber(int value) { return new IfcMonthInYearNumber(int);}
		public static implicit operator int(IfcMonthInYearNumber value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcNormalisedRatioMeasure = IfcRatioMeasure;
	/// <para>TYPE IfcNormalisedRatioMeasure = IfcRatioMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : {0.0 <= SELF <= 1.0};</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcNormalisedRatioMeasure : IfcRatioMeasure, IfcColourOrFactor, IfcMeasureValue, IfcSizeSelect
	{
		IfcNormalisedRatioMeasure() { }
		IfcNormalisedRatioMeasure(double value) { Value = value; }
		public static implicit operator IfcNormalisedRatioMeasure(double value) { return new IfcNormalisedRatioMeasure(double);}
		public static implicit operator double(IfcNormalisedRatioMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcNumericMeasure = NUMBER;
	/// <para>TYPE IfcNumericMeasure = NUMBER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcNumericMeasure : NUMBER, IfcMeasureValue
	{
		IfcNumericMeasure() { }
		IfcNumericMeasure(double value) { Value = value; }
		public static implicit operator IfcNumericMeasure(double value) { return new IfcNumericMeasure(double);}
		public static implicit operator double(IfcNumericMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPHMeasure = REAL;
	/// <para>TYPE IfcPHMeasure = REAL;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : {0.0 <= SELF <= 14.0};</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPHMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcPHMeasure() { }
		IfcPHMeasure(double value) { Value = value; }
		public static implicit operator IfcPHMeasure(double value) { return new IfcPHMeasure(double);}
		public static implicit operator double(IfcPHMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcParameterValue = REAL;
	/// <para>TYPE IfcParameterValue = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcParameterValue : REAL, IfcMeasureValue, IfcTrimmingSelect
	{
		IfcParameterValue() { }
		IfcParameterValue(double value) { Value = value; }
		public static implicit operator IfcParameterValue(double value) { return new IfcParameterValue(double);}
		public static implicit operator double(IfcParameterValue value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPlanarForceMeasure = REAL;
	/// <para>TYPE IfcPlanarForceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPlanarForceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcPlanarForceMeasure() { }
		IfcPlanarForceMeasure(double value) { Value = value; }
		public static implicit operator IfcPlanarForceMeasure(double value) { return new IfcPlanarForceMeasure(double);}
		public static implicit operator double(IfcPlanarForceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPlaneAngleMeasure = REAL;
	/// <para>TYPE IfcPlaneAngleMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPlaneAngleMeasure : REAL, IfcMeasureValue, IfcOrientationSelect
	{
		IfcPlaneAngleMeasure() { }
		IfcPlaneAngleMeasure(double value) { Value = value; }
		public static implicit operator IfcPlaneAngleMeasure(double value) { return new IfcPlaneAngleMeasure(double);}
		public static implicit operator double(IfcPlaneAngleMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPositiveLengthMeasure = IfcLengthMeasure;
	/// <para>TYPE IfcPositiveLengthMeasure = IfcLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF > 0.;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPositiveLengthMeasure : IfcLengthMeasure, IfcHatchLineDistanceSelect, IfcMeasureValue, IfcSizeSelect
	{
		IfcPositiveLengthMeasure() { }
		IfcPositiveLengthMeasure(double value) { Value = value; }
		public static implicit operator IfcPositiveLengthMeasure(double value) { return new IfcPositiveLengthMeasure(double);}
		public static implicit operator double(IfcPositiveLengthMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPositivePlaneAngleMeasure = IfcPlaneAngleMeasure;
	/// <para>TYPE IfcPositivePlaneAngleMeasure = IfcPlaneAngleMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF > 0.;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPositivePlaneAngleMeasure : IfcPlaneAngleMeasure, IfcMeasureValue
	{
		IfcPositivePlaneAngleMeasure() { }
		IfcPositivePlaneAngleMeasure(double value) { Value = value; }
		public static implicit operator IfcPositivePlaneAngleMeasure(double value) { return new IfcPositivePlaneAngleMeasure(double);}
		public static implicit operator double(IfcPositivePlaneAngleMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPositiveRatioMeasure = IfcRatioMeasure;
	/// <para>TYPE IfcPositiveRatioMeasure = IfcRatioMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF > 0.;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPositiveRatioMeasure : IfcRatioMeasure, IfcMeasureValue, IfcSizeSelect
	{
		IfcPositiveRatioMeasure() { }
		IfcPositiveRatioMeasure(double value) { Value = value; }
		public static implicit operator IfcPositiveRatioMeasure(double value) { return new IfcPositiveRatioMeasure(double);}
		public static implicit operator double(IfcPositiveRatioMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPowerMeasure = REAL;
	/// <para>TYPE IfcPowerMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPowerMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcPowerMeasure() { }
		IfcPowerMeasure(double value) { Value = value; }
		public static implicit operator IfcPowerMeasure(double value) { return new IfcPowerMeasure(double);}
		public static implicit operator double(IfcPowerMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPresentableText = STRING;
	/// <para>TYPE IfcPresentableText = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPresentableText : STRING
	{
		IfcPresentableText() { }
		IfcPresentableText(string value) { Value = value; }
		public static implicit operator IfcPresentableText(string value) { return new IfcPresentableText(string);}
		public static implicit operator string(IfcPresentableText value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcPressureMeasure = REAL;
	/// <para>TYPE IfcPressureMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcPressureMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcPressureMeasure() { }
		IfcPressureMeasure(double value) { Value = value; }
		public static implicit operator IfcPressureMeasure(double value) { return new IfcPressureMeasure(double);}
		public static implicit operator double(IfcPressureMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcRadioActivityMeasure = REAL;
	/// <para>TYPE IfcRadioActivityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcRadioActivityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcRadioActivityMeasure() { }
		IfcRadioActivityMeasure(double value) { Value = value; }
		public static implicit operator IfcRadioActivityMeasure(double value) { return new IfcRadioActivityMeasure(double);}
		public static implicit operator double(IfcRadioActivityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcRatioMeasure = REAL;
	/// <para>TYPE IfcRatioMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcRatioMeasure : REAL, IfcAppliedValueSelect, IfcMeasureValue, IfcSizeSelect
	{
		IfcRatioMeasure() { }
		IfcRatioMeasure(double value) { Value = value; }
		public static implicit operator IfcRatioMeasure(double value) { return new IfcRatioMeasure(double);}
		public static implicit operator double(IfcRatioMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcReal = REAL;
	/// <para>TYPE IfcReal = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcReal : REAL, IfcSimpleValue
	{
		IfcReal() { }
		IfcReal(double value) { Value = value; }
		public static implicit operator IfcReal(double value) { return new IfcReal(double);}
		public static implicit operator double(IfcReal value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcRotationalFrequencyMeasure = REAL;
	/// <para>TYPE IfcRotationalFrequencyMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcRotationalFrequencyMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcRotationalFrequencyMeasure() { }
		IfcRotationalFrequencyMeasure(double value) { Value = value; }
		public static implicit operator IfcRotationalFrequencyMeasure(double value) { return new IfcRotationalFrequencyMeasure(double);}
		public static implicit operator double(IfcRotationalFrequencyMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcRotationalMassMeasure = REAL;
	/// <para>TYPE IfcRotationalMassMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcRotationalMassMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcRotationalMassMeasure() { }
		IfcRotationalMassMeasure(double value) { Value = value; }
		public static implicit operator IfcRotationalMassMeasure(double value) { return new IfcRotationalMassMeasure(double);}
		public static implicit operator double(IfcRotationalMassMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcRotationalStiffnessMeasure = REAL;
	/// <para>TYPE IfcRotationalStiffnessMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcRotationalStiffnessMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcRotationalStiffnessMeasure() { }
		IfcRotationalStiffnessMeasure(double value) { Value = value; }
		public static implicit operator IfcRotationalStiffnessMeasure(double value) { return new IfcRotationalStiffnessMeasure(double);}
		public static implicit operator double(IfcRotationalStiffnessMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSecondInMinute = REAL;
	/// <para>TYPE IfcSecondInMinute = REAL;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : { 0. <= SELF < 60. };</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSecondInMinute : REAL
	{
		IfcSecondInMinute() { }
		IfcSecondInMinute(double value) { Value = value; }
		public static implicit operator IfcSecondInMinute(double value) { return new IfcSecondInMinute(double);}
		public static implicit operator double(IfcSecondInMinute value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSectionModulusMeasure = REAL;
	/// <para>TYPE IfcSectionModulusMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSectionModulusMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcSectionModulusMeasure() { }
		IfcSectionModulusMeasure(double value) { Value = value; }
		public static implicit operator IfcSectionModulusMeasure(double value) { return new IfcSectionModulusMeasure(double);}
		public static implicit operator double(IfcSectionModulusMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSectionalAreaIntegralMeasure = REAL;
	/// <para>TYPE IfcSectionalAreaIntegralMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSectionalAreaIntegralMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcSectionalAreaIntegralMeasure() { }
		IfcSectionalAreaIntegralMeasure(double value) { Value = value; }
		public static implicit operator IfcSectionalAreaIntegralMeasure(double value) { return new IfcSectionalAreaIntegralMeasure(double);}
		public static implicit operator double(IfcSectionalAreaIntegralMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcShearModulusMeasure = REAL;
	/// <para>TYPE IfcShearModulusMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcShearModulusMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcShearModulusMeasure() { }
		IfcShearModulusMeasure(double value) { Value = value; }
		public static implicit operator IfcShearModulusMeasure(double value) { return new IfcShearModulusMeasure(double);}
		public static implicit operator double(IfcShearModulusMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSolidAngleMeasure = REAL;
	/// <para>TYPE IfcSolidAngleMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSolidAngleMeasure : REAL, IfcMeasureValue
	{
		IfcSolidAngleMeasure() { }
		IfcSolidAngleMeasure(double value) { Value = value; }
		public static implicit operator IfcSolidAngleMeasure(double value) { return new IfcSolidAngleMeasure(double);}
		public static implicit operator double(IfcSolidAngleMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSoundPowerMeasure = REAL;
	/// <para>TYPE IfcSoundPowerMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSoundPowerMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcSoundPowerMeasure() { }
		IfcSoundPowerMeasure(double value) { Value = value; }
		public static implicit operator IfcSoundPowerMeasure(double value) { return new IfcSoundPowerMeasure(double);}
		public static implicit operator double(IfcSoundPowerMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSoundPressureMeasure = REAL;
	/// <para>TYPE IfcSoundPressureMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSoundPressureMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcSoundPressureMeasure() { }
		IfcSoundPressureMeasure(double value) { Value = value; }
		public static implicit operator IfcSoundPressureMeasure(double value) { return new IfcSoundPressureMeasure(double);}
		public static implicit operator double(IfcSoundPressureMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSpecificHeatCapacityMeasure = REAL;
	/// <para>TYPE IfcSpecificHeatCapacityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSpecificHeatCapacityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcSpecificHeatCapacityMeasure() { }
		IfcSpecificHeatCapacityMeasure(double value) { Value = value; }
		public static implicit operator IfcSpecificHeatCapacityMeasure(double value) { return new IfcSpecificHeatCapacityMeasure(double);}
		public static implicit operator double(IfcSpecificHeatCapacityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSpecularExponent = REAL;
	/// <para>TYPE IfcSpecularExponent = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSpecularExponent : REAL, IfcSpecularHighlightSelect
	{
		IfcSpecularExponent() { }
		IfcSpecularExponent(double value) { Value = value; }
		public static implicit operator IfcSpecularExponent(double value) { return new IfcSpecularExponent(double);}
		public static implicit operator double(IfcSpecularExponent value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcSpecularRoughness = REAL;
	/// <para>TYPE IfcSpecularRoughness = REAL;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : {0.0 <= SELF <= 1.0};</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcSpecularRoughness : REAL, IfcSpecularHighlightSelect
	{
		IfcSpecularRoughness() { }
		IfcSpecularRoughness(double value) { Value = value; }
		public static implicit operator IfcSpecularRoughness(double value) { return new IfcSpecularRoughness(double);}
		public static implicit operator double(IfcSpecularRoughness value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTemperatureGradientMeasure = REAL;
	/// <para>TYPE IfcTemperatureGradientMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTemperatureGradientMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcTemperatureGradientMeasure() { }
		IfcTemperatureGradientMeasure(double value) { Value = value; }
		public static implicit operator IfcTemperatureGradientMeasure(double value) { return new IfcTemperatureGradientMeasure(double);}
		public static implicit operator double(IfcTemperatureGradientMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcText = STRING;
	/// <para>TYPE IfcText = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcText : STRING, IfcMetricValueSelect, IfcSimpleValue
	{
		IfcText() { }
		IfcText(string value) { Value = value; }
		public static implicit operator IfcText(string value) { return new IfcText(string);}
		public static implicit operator string(IfcText value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTextAlignment = STRING;
	/// <para>TYPE IfcTextAlignment = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['left', 'right', 'center', 'justify'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTextAlignment : STRING
	{
		IfcTextAlignment() { }
		IfcTextAlignment(string value) { Value = value; }
		public static implicit operator IfcTextAlignment(string value) { return new IfcTextAlignment(string);}
		public static implicit operator string(IfcTextAlignment value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTextDecoration = STRING;
	/// <para>TYPE IfcTextDecoration = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['none', 'underline', 'overline', 'line-through', 'blink'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTextDecoration : STRING
	{
		IfcTextDecoration() { }
		IfcTextDecoration(string value) { Value = value; }
		public static implicit operator IfcTextDecoration(string value) { return new IfcTextDecoration(string);}
		public static implicit operator string(IfcTextDecoration value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTextFontName = STRING;
	/// <para>TYPE IfcTextFontName = STRING;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTextFontName : STRING
	{
		IfcTextFontName() { }
		IfcTextFontName(string value) { Value = value; }
		public static implicit operator IfcTextFontName(string value) { return new IfcTextFontName(string);}
		public static implicit operator string(IfcTextFontName value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTextTransformation = STRING;
	/// <para>TYPE IfcTextTransformation = STRING;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF IN ['capitalize', 'uppercase', 'lowercase', 'none'];</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTextTransformation : STRING
	{
		IfcTextTransformation() { }
		IfcTextTransformation(string value) { Value = value; }
		public static implicit operator IfcTextTransformation(string value) { return new IfcTextTransformation(string);}
		public static implicit operator string(IfcTextTransformation value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermalAdmittanceMeasure = REAL;
	/// <para>TYPE IfcThermalAdmittanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermalAdmittanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcThermalAdmittanceMeasure() { }
		IfcThermalAdmittanceMeasure(double value) { Value = value; }
		public static implicit operator IfcThermalAdmittanceMeasure(double value) { return new IfcThermalAdmittanceMeasure(double);}
		public static implicit operator double(IfcThermalAdmittanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermalConductivityMeasure = REAL;
	/// <para>TYPE IfcThermalConductivityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermalConductivityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcThermalConductivityMeasure() { }
		IfcThermalConductivityMeasure(double value) { Value = value; }
		public static implicit operator IfcThermalConductivityMeasure(double value) { return new IfcThermalConductivityMeasure(double);}
		public static implicit operator double(IfcThermalConductivityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermalExpansionCoefficientMeasure = REAL;
	/// <para>TYPE IfcThermalExpansionCoefficientMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermalExpansionCoefficientMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcThermalExpansionCoefficientMeasure() { }
		IfcThermalExpansionCoefficientMeasure(double value) { Value = value; }
		public static implicit operator IfcThermalExpansionCoefficientMeasure(double value) { return new IfcThermalExpansionCoefficientMeasure(double);}
		public static implicit operator double(IfcThermalExpansionCoefficientMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermalResistanceMeasure = REAL;
	/// <para>TYPE IfcThermalResistanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermalResistanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcThermalResistanceMeasure() { }
		IfcThermalResistanceMeasure(double value) { Value = value; }
		public static implicit operator IfcThermalResistanceMeasure(double value) { return new IfcThermalResistanceMeasure(double);}
		public static implicit operator double(IfcThermalResistanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermalTransmittanceMeasure = REAL;
	/// <para>TYPE IfcThermalTransmittanceMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermalTransmittanceMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcThermalTransmittanceMeasure() { }
		IfcThermalTransmittanceMeasure(double value) { Value = value; }
		public static implicit operator IfcThermalTransmittanceMeasure(double value) { return new IfcThermalTransmittanceMeasure(double);}
		public static implicit operator double(IfcThermalTransmittanceMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcThermodynamicTemperatureMeasure = REAL;
	/// <para>TYPE IfcThermodynamicTemperatureMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcThermodynamicTemperatureMeasure : REAL, IfcMeasureValue
	{
		IfcThermodynamicTemperatureMeasure() { }
		IfcThermodynamicTemperatureMeasure(double value) { Value = value; }
		public static implicit operator IfcThermodynamicTemperatureMeasure(double value) { return new IfcThermodynamicTemperatureMeasure(double);}
		public static implicit operator double(IfcThermodynamicTemperatureMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTimeMeasure = REAL;
	/// <para>TYPE IfcTimeMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTimeMeasure : REAL, IfcMeasureValue
	{
		IfcTimeMeasure() { }
		IfcTimeMeasure(double value) { Value = value; }
		public static implicit operator IfcTimeMeasure(double value) { return new IfcTimeMeasure(double);}
		public static implicit operator double(IfcTimeMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTimeStamp = INTEGER;
	/// <para>TYPE IfcTimeStamp = INTEGER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTimeStamp : INTEGER, IfcDerivedMeasureValue
	{
		IfcTimeStamp() { }
		IfcTimeStamp(int value) { Value = value; }
		public static implicit operator IfcTimeStamp(int value) { return new IfcTimeStamp(int);}
		public static implicit operator int(IfcTimeStamp value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcTorqueMeasure = REAL;
	/// <para>TYPE IfcTorqueMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcTorqueMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcTorqueMeasure() { }
		IfcTorqueMeasure(double value) { Value = value; }
		public static implicit operator IfcTorqueMeasure(double value) { return new IfcTorqueMeasure(double);}
		public static implicit operator double(IfcTorqueMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcVaporPermeabilityMeasure = REAL;
	/// <para>TYPE IfcVaporPermeabilityMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcVaporPermeabilityMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcVaporPermeabilityMeasure() { }
		IfcVaporPermeabilityMeasure(double value) { Value = value; }
		public static implicit operator IfcVaporPermeabilityMeasure(double value) { return new IfcVaporPermeabilityMeasure(double);}
		public static implicit operator double(IfcVaporPermeabilityMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcVolumeMeasure = REAL;
	/// <para>TYPE IfcVolumeMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcVolumeMeasure : REAL, IfcMeasureValue
	{
		IfcVolumeMeasure() { }
		IfcVolumeMeasure(double value) { Value = value; }
		public static implicit operator IfcVolumeMeasure(double value) { return new IfcVolumeMeasure(double);}
		public static implicit operator double(IfcVolumeMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcVolumetricFlowRateMeasure = REAL;
	/// <para>TYPE IfcVolumetricFlowRateMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcVolumetricFlowRateMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcVolumetricFlowRateMeasure() { }
		IfcVolumetricFlowRateMeasure(double value) { Value = value; }
		public static implicit operator IfcVolumetricFlowRateMeasure(double value) { return new IfcVolumetricFlowRateMeasure(double);}
		public static implicit operator double(IfcVolumetricFlowRateMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcWarpingConstantMeasure = REAL;
	/// <para>TYPE IfcWarpingConstantMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcWarpingConstantMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcWarpingConstantMeasure() { }
		IfcWarpingConstantMeasure(double value) { Value = value; }
		public static implicit operator IfcWarpingConstantMeasure(double value) { return new IfcWarpingConstantMeasure(double);}
		public static implicit operator double(IfcWarpingConstantMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcWarpingMomentMeasure = REAL;
	/// <para>TYPE IfcWarpingMomentMeasure = REAL;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcWarpingMomentMeasure : REAL, IfcDerivedMeasureValue
	{
		IfcWarpingMomentMeasure() { }
		IfcWarpingMomentMeasure(double value) { Value = value; }
		public static implicit operator IfcWarpingMomentMeasure(double value) { return new IfcWarpingMomentMeasure(double);}
		public static implicit operator double(IfcWarpingMomentMeasure value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcYearNumber = INTEGER;
	/// <para>TYPE IfcYearNumber = INTEGER;</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public class IfcYearNumber : INTEGER
	{
		IfcYearNumber() { }
		IfcYearNumber(int value) { Value = value; }
		public static implicit operator IfcYearNumber(int value) { return new IfcYearNumber(int);}
		public static implicit operator int(IfcYearNumber value) { return value.Value;}
	}
	/// <summary>
	/// TYPE IfcActorSelect = SELECT
	/// <para>TYPE IfcActorSelect = SELECT</para>
	/// <para>	(IfcOrganization</para>
	/// <para>	,IfcPerson</para>
	/// <para>	,IfcPersonAndOrganization);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcActorSelect
	{
	}
	/// <summary>
	/// TYPE IfcAppliedValueSelect = SELECT
	/// <para>TYPE IfcAppliedValueSelect = SELECT</para>
	/// <para>	(IfcRatioMeasure</para>
	/// <para>	,IfcMeasureWithUnit</para>
	/// <para>	,IfcMonetaryMeasure);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcAppliedValueSelect
	{
	}
	/// <summary>
	/// TYPE IfcAxis2Placement = SELECT
	/// <para>TYPE IfcAxis2Placement = SELECT</para>
	/// <para>	(IfcAxis2Placement2D</para>
	/// <para>	,IfcAxis2Placement3D);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcAxis2Placement
	{
	}
	/// <summary>
	/// TYPE IfcBooleanOperand = SELECT
	/// <para>TYPE IfcBooleanOperand = SELECT</para>
	/// <para>	(IfcSolidModel</para>
	/// <para>	,IfcHalfSpaceSolid</para>
	/// <para>	,IfcBooleanResult</para>
	/// <para>	,IfcCsgPrimitive3D);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcBooleanOperand
	{
	}
	/// <summary>
	/// TYPE IfcCharacterStyleSelect = SELECT
	/// <para>TYPE IfcCharacterStyleSelect = SELECT</para>
	/// <para>	(IfcTextStyleForDefinedFont);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcCharacterStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcClassificationNotationSelect = SELECT
	/// <para>TYPE IfcClassificationNotationSelect = SELECT</para>
	/// <para>	(IfcClassificationNotation</para>
	/// <para>	,IfcClassificationReference);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcClassificationNotationSelect
	{
	}
	/// <summary>
	/// TYPE IfcColour = SELECT
	/// <para>TYPE IfcColour = SELECT</para>
	/// <para>	(IfcColourSpecification</para>
	/// <para>	,IfcPreDefinedColour);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcColour, IfcFillStyleSelect, IfcSymbolStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcColourOrFactor = SELECT
	/// <para>TYPE IfcColourOrFactor = SELECT</para>
	/// <para>	(IfcColourRgb</para>
	/// <para>	,IfcNormalisedRatioMeasure);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcColourOrFactor
	{
	}
	/// <summary>
	/// TYPE IfcConditionCriterionSelect = SELECT
	/// <para>TYPE IfcConditionCriterionSelect = SELECT</para>
	/// <para>	(IfcLabel</para>
	/// <para>	,IfcMeasureWithUnit);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcConditionCriterionSelect
	{
	}
	/// <summary>
	/// TYPE IfcCsgSelect = SELECT
	/// <para>TYPE IfcCsgSelect = SELECT</para>
	/// <para>	(IfcBooleanResult</para>
	/// <para>	,IfcCsgPrimitive3D);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcCsgSelect
	{
	}
	/// <summary>
	/// TYPE IfcCurveFontOrScaledCurveFontSelect = SELECT
	/// <para>TYPE IfcCurveFontOrScaledCurveFontSelect = SELECT</para>
	/// <para>	(IfcCurveStyleFontSelect</para>
	/// <para>	,IfcCurveStyleFontAndScaling);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcCurveFontOrScaledCurveFontSelect
	{
	}
	/// <summary>
	/// TYPE IfcCurveOrEdgeCurve = SELECT
	/// <para>TYPE IfcCurveOrEdgeCurve = SELECT</para>
	/// <para>	(IfcBoundedCurve</para>
	/// <para>	,IfcEdgeCurve);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcCurveOrEdgeCurve
	{
	}
	/// <summary>
	/// TYPE IfcCurveStyleFontSelect = SELECT
	/// <para>TYPE IfcCurveStyleFontSelect = SELECT</para>
	/// <para>	(IfcPreDefinedCurveFont</para>
	/// <para>	,IfcCurveStyleFont);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcCurveStyleFontSelect, IfcCurveFontOrScaledCurveFontSelect
	{
	}
	/// <summary>
	/// TYPE IfcDateTimeSelect = SELECT
	/// <para>TYPE IfcDateTimeSelect = SELECT</para>
	/// <para>	(IfcCalendarDate</para>
	/// <para>	,IfcLocalTime</para>
	/// <para>	,IfcDateAndTime);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcDateTimeSelect, IfcMetricValueSelect
	{
	}
	/// <summary>
	/// TYPE IfcDefinedSymbolSelect = SELECT
	/// <para>TYPE IfcDefinedSymbolSelect = SELECT</para>
	/// <para>	(IfcPreDefinedSymbol</para>
	/// <para>	,IfcExternallyDefinedSymbol);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcDefinedSymbolSelect
	{
	}
	/// <summary>
	/// TYPE IfcDerivedMeasureValue = SELECT
	/// <para>TYPE IfcDerivedMeasureValue = SELECT</para>
	/// <para>	(IfcVolumetricFlowRateMeasure</para>
	/// <para>	,IfcTimeStamp</para>
	/// <para>	,IfcThermalTransmittanceMeasure</para>
	/// <para>	,IfcThermalResistanceMeasure</para>
	/// <para>	,IfcThermalAdmittanceMeasure</para>
	/// <para>	,IfcPressureMeasure</para>
	/// <para>	,IfcPowerMeasure</para>
	/// <para>	,IfcMassFlowRateMeasure</para>
	/// <para>	,IfcMassDensityMeasure</para>
	/// <para>	,IfcLinearVelocityMeasure</para>
	/// <para>	,IfcKinematicViscosityMeasure</para>
	/// <para>	,IfcIntegerCountRateMeasure</para>
	/// <para>	,IfcHeatFluxDensityMeasure</para>
	/// <para>	,IfcFrequencyMeasure</para>
	/// <para>	,IfcEnergyMeasure</para>
	/// <para>	,IfcElectricVoltageMeasure</para>
	/// <para>	,IfcDynamicViscosityMeasure</para>
	/// <para>	,IfcCompoundPlaneAngleMeasure</para>
	/// <para>	,IfcAngularVelocityMeasure</para>
	/// <para>	,IfcThermalConductivityMeasure</para>
	/// <para>	,IfcMolecularWeightMeasure</para>
	/// <para>	,IfcVaporPermeabilityMeasure</para>
	/// <para>	,IfcMoistureDiffusivityMeasure</para>
	/// <para>	,IfcIsothermalMoistureCapacityMeasure</para>
	/// <para>	,IfcSpecificHeatCapacityMeasure</para>
	/// <para>	,IfcMonetaryMeasure</para>
	/// <para>	,IfcMagneticFluxDensityMeasure</para>
	/// <para>	,IfcMagneticFluxMeasure</para>
	/// <para>	,IfcLuminousFluxMeasure</para>
	/// <para>	,IfcForceMeasure</para>
	/// <para>	,IfcInductanceMeasure</para>
	/// <para>	,IfcIlluminanceMeasure</para>
	/// <para>	,IfcElectricResistanceMeasure</para>
	/// <para>	,IfcElectricConductanceMeasure</para>
	/// <para>	,IfcElectricChargeMeasure</para>
	/// <para>	,IfcDoseEquivalentMeasure</para>
	/// <para>	,IfcElectricCapacitanceMeasure</para>
	/// <para>	,IfcAbsorbedDoseMeasure</para>
	/// <para>	,IfcRadioActivityMeasure</para>
	/// <para>	,IfcRotationalFrequencyMeasure</para>
	/// <para>	,IfcTorqueMeasure</para>
	/// <para>	,IfcAccelerationMeasure</para>
	/// <para>	,IfcLinearForceMeasure</para>
	/// <para>	,IfcLinearStiffnessMeasure</para>
	/// <para>	,IfcModulusOfSubgradeReactionMeasure</para>
	/// <para>	,IfcModulusOfElasticityMeasure</para>
	/// <para>	,IfcMomentOfInertiaMeasure</para>
	/// <para>	,IfcPlanarForceMeasure</para>
	/// <para>	,IfcRotationalStiffnessMeasure</para>
	/// <para>	,IfcShearModulusMeasure</para>
	/// <para>	,IfcLinearMomentMeasure</para>
	/// <para>	,IfcLuminousIntensityDistributionMeasure</para>
	/// <para>	,IfcCurvatureMeasure</para>
	/// <para>	,IfcMassPerLengthMeasure</para>
	/// <para>	,IfcModulusOfLinearSubgradeReactionMeasure</para>
	/// <para>	,IfcModulusOfRotationalSubgradeReactionMeasure</para>
	/// <para>	,IfcRotationalMassMeasure</para>
	/// <para>	,IfcSectionalAreaIntegralMeasure</para>
	/// <para>	,IfcSectionModulusMeasure</para>
	/// <para>	,IfcTemperatureGradientMeasure</para>
	/// <para>	,IfcThermalExpansionCoefficientMeasure</para>
	/// <para>	,IfcWarpingConstantMeasure</para>
	/// <para>	,IfcWarpingMomentMeasure</para>
	/// <para>	,IfcSoundPowerMeasure</para>
	/// <para>	,IfcSoundPressureMeasure</para>
	/// <para>	,IfcHeatingValueMeasure</para>
	/// <para>	,IfcPHMeasure</para>
	/// <para>	,IfcIonConcentrationMeasure);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcDerivedMeasureValue, IfcValue
	{
	}
	/// <summary>
	/// TYPE IfcDocumentSelect = SELECT
	/// <para>TYPE IfcDocumentSelect = SELECT</para>
	/// <para>	(IfcDocumentReference</para>
	/// <para>	,IfcDocumentInformation);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcDocumentSelect
	{
	}
	/// <summary>
	/// TYPE IfcDraughtingCalloutElement = SELECT
	/// <para>TYPE IfcDraughtingCalloutElement = SELECT</para>
	/// <para>	(IfcAnnotationCurveOccurrence</para>
	/// <para>	,IfcAnnotationTextOccurrence</para>
	/// <para>	,IfcAnnotationSymbolOccurrence);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcDraughtingCalloutElement
	{
	}
	/// <summary>
	/// TYPE IfcFillAreaStyleTileShapeSelect = SELECT
	/// <para>TYPE IfcFillAreaStyleTileShapeSelect = SELECT</para>
	/// <para>	(IfcFillAreaStyleTileSymbolWithStyle);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcFillAreaStyleTileShapeSelect
	{
	}
	/// <summary>
	/// TYPE IfcFillStyleSelect = SELECT
	/// <para>TYPE IfcFillStyleSelect = SELECT</para>
	/// <para>	(IfcFillAreaStyleHatching</para>
	/// <para>	,IfcFillAreaStyleTiles</para>
	/// <para>	,IfcColour</para>
	/// <para>	,IfcExternallyDefinedHatchStyle);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcFillStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcGeometricSetSelect = SELECT
	/// <para>TYPE IfcGeometricSetSelect = SELECT</para>
	/// <para>	(IfcPoint</para>
	/// <para>	,IfcCurve</para>
	/// <para>	,IfcSurface);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcGeometricSetSelect
	{
	}
	/// <summary>
	/// TYPE IfcHatchLineDistanceSelect = SELECT
	/// <para>TYPE IfcHatchLineDistanceSelect = SELECT</para>
	/// <para>	(IfcOneDirectionRepeatFactor</para>
	/// <para>	,IfcPositiveLengthMeasure);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcHatchLineDistanceSelect
	{
	}
	/// <summary>
	/// TYPE IfcLayeredItem = SELECT
	/// <para>TYPE IfcLayeredItem = SELECT</para>
	/// <para>	(IfcRepresentationItem</para>
	/// <para>	,IfcRepresentation);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcLayeredItem
	{
	}
	/// <summary>
	/// TYPE IfcLibrarySelect = SELECT
	/// <para>TYPE IfcLibrarySelect = SELECT</para>
	/// <para>	(IfcLibraryReference</para>
	/// <para>	,IfcLibraryInformation);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcLibrarySelect
	{
	}
	/// <summary>
	/// TYPE IfcLightDistributionDataSourceSelect = SELECT
	/// <para>TYPE IfcLightDistributionDataSourceSelect = SELECT</para>
	/// <para>	(IfcExternalReference</para>
	/// <para>	,IfcLightIntensityDistribution);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcLightDistributionDataSourceSelect
	{
	}
	/// <summary>
	/// TYPE IfcMaterialSelect = SELECT
	/// <para>TYPE IfcMaterialSelect = SELECT</para>
	/// <para>	(IfcMaterial</para>
	/// <para>	,IfcMaterialList</para>
	/// <para>	,IfcMaterialLayerSetUsage</para>
	/// <para>	,IfcMaterialLayerSet</para>
	/// <para>	,IfcMaterialLayer);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcMaterialSelect
	{
	}
	/// <summary>
	/// TYPE IfcMeasureValue = SELECT
	/// <para>TYPE IfcMeasureValue = SELECT</para>
	/// <para>	(IfcVolumeMeasure</para>
	/// <para>	,IfcTimeMeasure</para>
	/// <para>	,IfcThermodynamicTemperatureMeasure</para>
	/// <para>	,IfcSolidAngleMeasure</para>
	/// <para>	,IfcPositiveRatioMeasure</para>
	/// <para>	,IfcRatioMeasure</para>
	/// <para>	,IfcPositivePlaneAngleMeasure</para>
	/// <para>	,IfcPlaneAngleMeasure</para>
	/// <para>	,IfcParameterValue</para>
	/// <para>	,IfcNumericMeasure</para>
	/// <para>	,IfcMassMeasure</para>
	/// <para>	,IfcPositiveLengthMeasure</para>
	/// <para>	,IfcLengthMeasure</para>
	/// <para>	,IfcElectricCurrentMeasure</para>
	/// <para>	,IfcDescriptiveMeasure</para>
	/// <para>	,IfcCountMeasure</para>
	/// <para>	,IfcContextDependentMeasure</para>
	/// <para>	,IfcAreaMeasure</para>
	/// <para>	,IfcAmountOfSubstanceMeasure</para>
	/// <para>	,IfcLuminousIntensityMeasure</para>
	/// <para>	,IfcNormalisedRatioMeasure</para>
	/// <para>	,IfcComplexNumber);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcMeasureValue, IfcValue
	{
	}
	/// <summary>
	/// TYPE IfcMetricValueSelect = SELECT
	/// <para>TYPE IfcMetricValueSelect = SELECT</para>
	/// <para>	(IfcDateTimeSelect</para>
	/// <para>	,IfcMeasureWithUnit</para>
	/// <para>	,IfcTable</para>
	/// <para>	,IfcText</para>
	/// <para>	,IfcTimeSeries</para>
	/// <para>	,IfcCostValue);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcMetricValueSelect
	{
	}
	/// <summary>
	/// TYPE IfcObjectReferenceSelect = SELECT
	/// <para>TYPE IfcObjectReferenceSelect = SELECT</para>
	/// <para>	(IfcMaterial</para>
	/// <para>	,IfcPerson</para>
	/// <para>	,IfcDateAndTime</para>
	/// <para>	,IfcMaterialList</para>
	/// <para>	,IfcOrganization</para>
	/// <para>	,IfcCalendarDate</para>
	/// <para>	,IfcLocalTime</para>
	/// <para>	,IfcPersonAndOrganization</para>
	/// <para>	,IfcMaterialLayer</para>
	/// <para>	,IfcExternalReference</para>
	/// <para>	,IfcTimeSeries</para>
	/// <para>	,IfcAddress</para>
	/// <para>	,IfcAppliedValue);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcObjectReferenceSelect
	{
	}
	/// <summary>
	/// TYPE IfcOrientationSelect = SELECT
	/// <para>TYPE IfcOrientationSelect = SELECT</para>
	/// <para>	(IfcPlaneAngleMeasure</para>
	/// <para>	,IfcDirection);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcOrientationSelect
	{
	}
	/// <summary>
	/// TYPE IfcPointOrVertexPoint = SELECT
	/// <para>TYPE IfcPointOrVertexPoint = SELECT</para>
	/// <para>	(IfcPoint</para>
	/// <para>	,IfcVertexPoint);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcPointOrVertexPoint
	{
	}
	/// <summary>
	/// TYPE IfcPresentationStyleSelect = SELECT
	/// <para>TYPE IfcPresentationStyleSelect = SELECT</para>
	/// <para>	(IfcNullStyle</para>
	/// <para>	,IfcCurveStyle</para>
	/// <para>	,IfcSymbolStyle</para>
	/// <para>	,IfcFillAreaStyle</para>
	/// <para>	,IfcTextStyle</para>
	/// <para>	,IfcSurfaceStyle);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcPresentationStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcShell = SELECT
	/// <para>TYPE IfcShell = SELECT</para>
	/// <para>	(IfcClosedShell</para>
	/// <para>	,IfcOpenShell);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcShell
	{
	}
	/// <summary>
	/// TYPE IfcSimpleValue = SELECT
	/// <para>TYPE IfcSimpleValue = SELECT</para>
	/// <para>	(IfcInteger</para>
	/// <para>	,IfcReal</para>
	/// <para>	,IfcBoolean</para>
	/// <para>	,IfcIdentifier</para>
	/// <para>	,IfcText</para>
	/// <para>	,IfcLabel</para>
	/// <para>	,IfcLogical);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSimpleValue, IfcValue
	{
	}
	/// <summary>
	/// TYPE IfcSizeSelect = SELECT
	/// <para>TYPE IfcSizeSelect = SELECT</para>
	/// <para>	(IfcRatioMeasure</para>
	/// <para>	,IfcLengthMeasure</para>
	/// <para>	,IfcDescriptiveMeasure</para>
	/// <para>	,IfcPositiveLengthMeasure</para>
	/// <para>	,IfcNormalisedRatioMeasure</para>
	/// <para>	,IfcPositiveRatioMeasure);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSizeSelect
	{
	}
	/// <summary>
	/// TYPE IfcSpecularHighlightSelect = SELECT
	/// <para>TYPE IfcSpecularHighlightSelect = SELECT</para>
	/// <para>	(IfcSpecularExponent</para>
	/// <para>	,IfcSpecularRoughness);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSpecularHighlightSelect
	{
	}
	/// <summary>
	/// TYPE IfcStructuralActivityAssignmentSelect = SELECT
	/// <para>TYPE IfcStructuralActivityAssignmentSelect = SELECT</para>
	/// <para>	(IfcStructuralItem</para>
	/// <para>	,IfcElement);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcStructuralActivityAssignmentSelect
	{
	}
	/// <summary>
	/// TYPE IfcSurfaceOrFaceSurface = SELECT
	/// <para>TYPE IfcSurfaceOrFaceSurface = SELECT</para>
	/// <para>	(IfcSurface</para>
	/// <para>	,IfcFaceSurface</para>
	/// <para>	,IfcFaceBasedSurfaceModel);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSurfaceOrFaceSurface
	{
	}
	/// <summary>
	/// TYPE IfcSurfaceStyleElementSelect = SELECT
	/// <para>TYPE IfcSurfaceStyleElementSelect = SELECT</para>
	/// <para>	(IfcSurfaceStyleShading</para>
	/// <para>	,IfcSurfaceStyleLighting</para>
	/// <para>	,IfcSurfaceStyleWithTextures</para>
	/// <para>	,IfcExternallyDefinedSurfaceStyle</para>
	/// <para>	,IfcSurfaceStyleRefraction);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSurfaceStyleElementSelect
	{
	}
	/// <summary>
	/// TYPE IfcSymbolStyleSelect = SELECT
	/// <para>TYPE IfcSymbolStyleSelect = SELECT</para>
	/// <para>	(IfcColour);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcSymbolStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcTextFontSelect = SELECT
	/// <para>TYPE IfcTextFontSelect = SELECT</para>
	/// <para>	(IfcPreDefinedTextFont</para>
	/// <para>	,IfcExternallyDefinedTextFont);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcTextFontSelect
	{
	}
	/// <summary>
	/// TYPE IfcTextStyleSelect = SELECT
	/// <para>TYPE IfcTextStyleSelect = SELECT</para>
	/// <para>	(IfcTextStyleWithBoxCharacteristics</para>
	/// <para>	,IfcTextStyleTextModel);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcTextStyleSelect
	{
	}
	/// <summary>
	/// TYPE IfcTrimmingSelect = SELECT
	/// <para>TYPE IfcTrimmingSelect = SELECT</para>
	/// <para>	(IfcCartesianPoint</para>
	/// <para>	,IfcParameterValue);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcTrimmingSelect
	{
	}
	/// <summary>
	/// TYPE IfcUnit = SELECT
	/// <para>TYPE IfcUnit = SELECT</para>
	/// <para>	(IfcDerivedUnit</para>
	/// <para>	,IfcNamedUnit</para>
	/// <para>	,IfcMonetaryUnit);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcUnit
	{
	}
	/// <summary>
	/// TYPE IfcValue = SELECT
	/// <para>TYPE IfcValue = SELECT</para>
	/// <para>	(IfcMeasureValue</para>
	/// <para>	,IfcSimpleValue</para>
	/// <para>	,IfcDerivedMeasureValue);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcValue
	{
	}
	/// <summary>
	/// TYPE IfcVectorOrDirection = SELECT
	/// <para>TYPE IfcVectorOrDirection = SELECT</para>
	/// <para>	(IfcDirection</para>
	/// <para>	,IfcVector);</para>
	/// <para>END_TYPE;</para>
	/// <summary>
	public interface IfcVectorOrDirection
	{
	}
	/// <summary>
	/// ENTITY Ifc2DCompositeCurve
	/// <para>ENTITY Ifc2DCompositeCurve</para>
	/// <para> SUBTYPE OF (IfcCompositeCurve);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcCompositeCurve.ClosedCurve;</para>
	/// <para>	WR2 : SELF\IfcCurve.Dim = 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class Ifc2DCompositeCurve : IfcCompositeCurve
	{
		public Ifc2DCompositeCurve() : base()
		{
		}
		public Ifc2DCompositeCurve(List<IfcCompositeCurveSegment> Segments, LOGICAL SelfIntersect) : base (Segments, SelfIntersect)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcActionRequest
	/// <para>ENTITY IfcActionRequest</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	RequestID : IfcIdentifier;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR2 : RequestID;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcActionRequest : IfcControl
	{
		public IfcIdentifier RequestID { get; set; }
		public IfcActionRequest() : base()
		{
			RequestID = new IfcIdentifier();
		}
		public IfcActionRequest(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier RequestID) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.RequestID = RequestID;
		}
	}
	/// <summary>
	/// ENTITY IfcActor
	/// <para>ENTITY IfcActor</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcOccupant))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para>	TheActor : IfcActorSelect;</para>
	/// <para> INVERSE</para>
	/// <para>	IsActingUpon : SET [0:?] OF IfcRelAssignsToActor FOR RelatingActor;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcActor : IfcObject
	{
		public IfcActorSelect TheActor { get; set; }
		public IfcActor() : base()
		{
			TheActor = new IfcActorSelect();
		}
		public IfcActor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcActorSelect TheActor) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.TheActor = TheActor;
		}
	}
	/// <summary>
	/// ENTITY IfcActorRole;
	/// <para>ENTITY IfcActorRole;</para>
	/// <para>	Role : IfcRoleEnum;</para>
	/// <para>	UserDefinedRole : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (Role <> IfcRoleEnum.USERDEFINED) OR</para>
	/// <para>            ((Role = IfcRoleEnum.USERDEFINED) AND</para>
	/// <para>              EXISTS(SELF.UserDefinedRole));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcActorRoleENTITY
	{
		public IfcRoleEnum Role { get; set; }
		public IfcLabel? UserDefinedRole { get; set; }
		public IfcText? Description { get; set; }
		public IfcActorRole() : base()
		{
			Role = new IfcRoleEnum();
		}
		public IfcActorRole(IfcRoleEnum Role, IfcLabel UserDefinedRole, IfcText Description) : base ()
		{
			this.Role = Role;
			this.UserDefinedRole = UserDefinedRole;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcActuatorType
	/// <para>ENTITY IfcActuatorType</para>
	/// <para> SUBTYPE OF (IfcDistributionControlElementType);</para>
	/// <para>	PredefinedType : IfcActuatorTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcActuatorType : IfcDistributionControlElementType
	{
		public IfcActuatorTypeEnum PredefinedType { get; set; }
		public IfcActuatorType() : base()
		{
			PredefinedType = new IfcActuatorTypeEnum();
		}
		public IfcActuatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcActuatorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcAddress
	/// <para>ENTITY IfcAddress</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPostalAddress</para>
	/// <para>	,IfcTelecomAddress));</para>
	/// <para>	Purpose : OPTIONAL IfcAddressTypeEnum;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	UserDefinedPurpose : OPTIONAL IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	OfPerson : SET [0:?] OF IfcPerson FOR Addresses;</para>
	/// <para>	OfOrganization : SET [0:?] OF IfcOrganization FOR Addresses;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (NOT(EXISTS(Purpose))) OR</para>
	/// <para>            ((Purpose <> IfcAddressTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((Purpose = IfcAddressTypeEnum.USERDEFINED) AND</para>
	/// <para>              EXISTS(SELF.UserDefinedPurpose)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcAddressENTITY, IfcObjectReferenceSelect
	{
		public IfcAddressTypeEnum? Purpose { get; set; }
		public IfcText? Description { get; set; }
		public IfcLabel? UserDefinedPurpose { get; set; }
		public IfcAddress() : base()
		{
		}
		public IfcAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose) : base ()
		{
			this.Purpose = Purpose;
			this.Description = Description;
			this.UserDefinedPurpose = UserDefinedPurpose;
		}
	}
	/// <summary>
	/// ENTITY IfcAirTerminalBoxType
	/// <para>ENTITY IfcAirTerminalBoxType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcAirTerminalBoxTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcAirTerminalBoxTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcAirTerminalBoxTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAirTerminalBoxType : IfcFlowControllerType
	{
		public IfcAirTerminalBoxTypeEnum PredefinedType { get; set; }
		public IfcAirTerminalBoxType() : base()
		{
			PredefinedType = new IfcAirTerminalBoxTypeEnum();
		}
		public IfcAirTerminalBoxType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcAirTerminalBoxTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcAirTerminalType
	/// <para>ENTITY IfcAirTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcAirTerminalTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcAirTerminalTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcAirTerminalTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAirTerminalType : IfcFlowTerminalType
	{
		public IfcAirTerminalTypeEnum PredefinedType { get; set; }
		public IfcAirTerminalType() : base()
		{
			PredefinedType = new IfcAirTerminalTypeEnum();
		}
		public IfcAirTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcAirTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcAirToAirHeatRecoveryType
	/// <para>ENTITY IfcAirToAirHeatRecoveryType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcAirToAirHeatRecoveryTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcAirToAirHeatRecoveryTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAirToAirHeatRecoveryType : IfcEnergyConversionDeviceType
	{
		public IfcAirToAirHeatRecoveryTypeEnum PredefinedType { get; set; }
		public IfcAirToAirHeatRecoveryType() : base()
		{
			PredefinedType = new IfcAirToAirHeatRecoveryTypeEnum();
		}
		public IfcAirToAirHeatRecoveryType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcAirToAirHeatRecoveryTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcAlarmType
	/// <para>ENTITY IfcAlarmType</para>
	/// <para> SUBTYPE OF (IfcDistributionControlElementType);</para>
	/// <para>	PredefinedType : IfcAlarmTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAlarmType : IfcDistributionControlElementType
	{
		public IfcAlarmTypeEnum PredefinedType { get; set; }
		public IfcAlarmType() : base()
		{
			PredefinedType = new IfcAlarmTypeEnum();
		}
		public IfcAlarmType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcAlarmTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcAngularDimension
	/// <para>ENTITY IfcAngularDimension</para>
	/// <para> SUBTYPE OF (IfcDimensionCurveDirectedCallout);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAngularDimension : IfcDimensionCurveDirectedCallout
	{
		public IfcAngularDimension() : base()
		{
		}
		public IfcAngularDimension(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotation
	/// <para>ENTITY IfcAnnotation</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para> INVERSE</para>
	/// <para>	ContainedInStructure : SET [0:1] OF IfcRelContainedInSpatialStructure FOR RelatedElements;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotation : IfcProduct
	{
		public IfcAnnotation() : base()
		{
		}
		public IfcAnnotation(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationCurveOccurrence
	/// <para>ENTITY IfcAnnotationCurveOccurrence</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDimensionCurve</para>
	/// <para>	,IfcProjectionCurve))</para>
	/// <para> SUBTYPE OF (IfcAnnotationOccurrence);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(SELF\IfcStyledItem.Item)) OR</para>
	/// <para>             ('IFC2X3.IFCCURVE' IN TYPEOF (SELF\IfcStyledItem.Item));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationCurveOccurrence : IfcAnnotationOccurrence, IfcDraughtingCalloutElement
	{
		public IfcAnnotationCurveOccurrence() : base()
		{
		}
		public IfcAnnotationCurveOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationFillArea
	/// <para>ENTITY IfcAnnotationFillArea</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	OuterBoundary : IfcCurve;</para>
	/// <para>	InnerBoundaries : OPTIONAL SET [1:?] OF IfcCurve;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationFillArea : IfcGeometricRepresentationItem
	{
		public IfcCurve OuterBoundary { get; set; }
		public List<IfcCurve>? InnerBoundaries { get; set; }
		public IfcAnnotationFillArea() : base()
		{
			OuterBoundary = new IfcCurve();
		}
		public IfcAnnotationFillArea(IfcCurve OuterBoundary, List<IfcCurve> InnerBoundaries) : base ()
		{
			this.OuterBoundary = OuterBoundary;
			this.InnerBoundaries = InnerBoundaries;
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationFillAreaOccurrence
	/// <para>ENTITY IfcAnnotationFillAreaOccurrence</para>
	/// <para> SUBTYPE OF (IfcAnnotationOccurrence);</para>
	/// <para>	FillStyleTarget : OPTIONAL IfcPoint;</para>
	/// <para>	GlobalOrLocal : OPTIONAL IfcGlobalOrLocalEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(SELF\IfcStyledItem.Item)) OR</para>
	/// <para>             ('IFC2X3.IFCANNOTATIONFILLAREA' IN TYPEOF (SELF\IfcStyledItem.Item));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationFillAreaOccurrence : IfcAnnotationOccurrence
	{
		public IfcPoint? FillStyleTarget { get; set; }
		public IfcGlobalOrLocalEnum? GlobalOrLocal { get; set; }
		public IfcAnnotationFillAreaOccurrence() : base()
		{
		}
		public IfcAnnotationFillAreaOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name, IfcPoint FillStyleTarget, IfcGlobalOrLocalEnum GlobalOrLocal) : base (Item, Styles, Name)
		{
			this.FillStyleTarget = FillStyleTarget;
			this.GlobalOrLocal = GlobalOrLocal;
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationOccurrence
	/// <para>ENTITY IfcAnnotationOccurrence</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAnnotationCurveOccurrence</para>
	/// <para>	,IfcAnnotationFillAreaOccurrence</para>
	/// <para>	,IfcAnnotationSurfaceOccurrence</para>
	/// <para>	,IfcAnnotationSymbolOccurrence</para>
	/// <para>	,IfcAnnotationTextOccurrence))</para>
	/// <para> SUBTYPE OF (IfcStyledItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcAnnotationOccurrence : IfcStyledItem
	{
		public IfcAnnotationOccurrence() : base()
		{
		}
		public IfcAnnotationOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationSurface
	/// <para>ENTITY IfcAnnotationSurface</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Item : IfcGeometricRepresentationItem;</para>
	/// <para>	TextureCoordinates : OPTIONAL IfcTextureCoordinate;</para>
	/// <para> WHERE</para>
	/// <para>	WR01 : SIZEOF([</para>
	/// <para>               'IFC2X3.IFCSURFACE',</para>
	/// <para>               'IFC2X3.IFCSHELLBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCFACEBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCSOLIDMODEL',</para>
	/// <para>               'IFC2X3.IFCBOOLEANRESULT',</para>
	/// <para>               'IFC2X3.IFCCSGPRIMITIVE3D'] </para>
	/// <para>              * TYPEOF(Item)</para>
	/// <para>               ) >= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationSurface : IfcGeometricRepresentationItem
	{
		public IfcGeometricRepresentationItem Item { get; set; }
		public IfcTextureCoordinate? TextureCoordinates { get; set; }
		public IfcAnnotationSurface() : base()
		{
			Item = new IfcGeometricRepresentationItem();
		}
		public IfcAnnotationSurface(IfcGeometricRepresentationItem Item, IfcTextureCoordinate TextureCoordinates) : base ()
		{
			this.Item = Item;
			this.TextureCoordinates = TextureCoordinates;
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationSurfaceOccurrence
	/// <para>ENTITY IfcAnnotationSurfaceOccurrence</para>
	/// <para> SUBTYPE OF (IfcAnnotationOccurrence);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(SELF\IfcStyledItem.Item)) OR </para>
	/// <para>             (SIZEOF(</para>
	/// <para>              ['IFC2X3.IFCSURFACE',</para>
	/// <para>               'IFC2X3.IFCFACEBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCSHELLBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCSOLIDMODEL'] *</para>
	/// <para>              TYPEOF(SELF\IfcStyledItem.Item)) > 0);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationSurfaceOccurrence : IfcAnnotationOccurrence
	{
		public IfcAnnotationSurfaceOccurrence() : base()
		{
		}
		public IfcAnnotationSurfaceOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationSymbolOccurrence
	/// <para>ENTITY IfcAnnotationSymbolOccurrence</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcTerminatorSymbol))</para>
	/// <para> SUBTYPE OF (IfcAnnotationOccurrence);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(SELF\IfcStyledItem.Item)) OR</para>
	/// <para>             ('IFC2X3.IFCDEFINEDSYMBOL' IN TYPEOF (SELF\IfcStyledItem.Item));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationSymbolOccurrence : IfcAnnotationOccurrence, IfcDraughtingCalloutElement
	{
		public IfcAnnotationSymbolOccurrence() : base()
		{
		}
		public IfcAnnotationSymbolOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcAnnotationTextOccurrence
	/// <para>ENTITY IfcAnnotationTextOccurrence</para>
	/// <para> SUBTYPE OF (IfcAnnotationOccurrence);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(SELF\IfcStyledItem.Item)) OR</para>
	/// <para>             ('IFC2X3.IFCTEXTLITERAL' IN TYPEOF (SELF\IfcStyledItem.Item));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAnnotationTextOccurrence : IfcAnnotationOccurrence, IfcDraughtingCalloutElement
	{
		public IfcAnnotationTextOccurrence() : base()
		{
		}
		public IfcAnnotationTextOccurrence(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcApplication;
	/// <para>ENTITY IfcApplication;</para>
	/// <para>	ApplicationDeveloper : IfcOrganization;</para>
	/// <para>	Version : IfcLabel;</para>
	/// <para>	ApplicationFullName : IfcLabel;</para>
	/// <para>	ApplicationIdentifier : IfcIdentifier;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR1 : ApplicationIdentifier;</para>
	/// <para>	UR2 : ApplicationFullName, Version;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcApplicationENTITY
	{
		public IfcOrganization ApplicationDeveloper { get; set; }
		public IfcLabel Version { get; set; }
		public IfcLabel ApplicationFullName { get; set; }
		public IfcIdentifier ApplicationIdentifier { get; set; }
		public IfcApplication() : base()
		{
			ApplicationDeveloper = new IfcOrganization();
			Version = new IfcLabel();
			ApplicationFullName = new IfcLabel();
			ApplicationIdentifier = new IfcIdentifier();
		}
		public IfcApplication(IfcOrganization ApplicationDeveloper, IfcLabel Version, IfcLabel ApplicationFullName, IfcIdentifier ApplicationIdentifier) : base ()
		{
			this.ApplicationDeveloper = ApplicationDeveloper;
			this.Version = Version;
			this.ApplicationFullName = ApplicationFullName;
			this.ApplicationIdentifier = ApplicationIdentifier;
		}
	}
	/// <summary>
	/// ENTITY IfcAppliedValue
	/// <para>ENTITY IfcAppliedValue</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCostValue</para>
	/// <para>	,IfcEnvironmentalImpactValue));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	AppliedValue : OPTIONAL IfcAppliedValueSelect;</para>
	/// <para>	UnitBasis : OPTIONAL IfcMeasureWithUnit;</para>
	/// <para>	ApplicableDate : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	FixedUntilDate : OPTIONAL IfcDateTimeSelect;</para>
	/// <para> INVERSE</para>
	/// <para>	ValuesReferenced : SET [0:?] OF IfcReferencesValueDocument FOR ReferencingValues;</para>
	/// <para>	ValueOfComponents : SET [0:?] OF IfcAppliedValueRelationship FOR ComponentOfTotal;</para>
	/// <para>	IsComponentIn : SET [0:?] OF IfcAppliedValueRelationship FOR Components;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS (AppliedValue) OR </para>
	/// <para>            EXISTS (ValueOfComponents);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcAppliedValueENTITY, IfcObjectReferenceSelect
	{
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcAppliedValueSelect? AppliedValue { get; set; }
		public IfcMeasureWithUnit? UnitBasis { get; set; }
		public IfcDateTimeSelect? ApplicableDate { get; set; }
		public IfcDateTimeSelect? FixedUntilDate { get; set; }
		public IfcAppliedValue() : base()
		{
		}
		public IfcAppliedValue(IfcLabel Name, IfcText Description, IfcAppliedValueSelect AppliedValue, IfcMeasureWithUnit UnitBasis, IfcDateTimeSelect ApplicableDate, IfcDateTimeSelect FixedUntilDate) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.AppliedValue = AppliedValue;
			this.UnitBasis = UnitBasis;
			this.ApplicableDate = ApplicableDate;
			this.FixedUntilDate = FixedUntilDate;
		}
	}
	/// <summary>
	/// ENTITY IfcAppliedValueRelationship;
	/// <para>ENTITY IfcAppliedValueRelationship;</para>
	/// <para>	ComponentOfTotal : IfcAppliedValue;</para>
	/// <para>	Components : SET [1:?] OF IfcAppliedValue;</para>
	/// <para>	ArithmeticOperator : IfcArithmeticOperatorEnum;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAppliedValueRelationshipENTITY
	{
		public IfcAppliedValue ComponentOfTotal { get; set; }
		public List<IfcAppliedValue> Components { get; set; }
		public IfcArithmeticOperatorEnum ArithmeticOperator { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcAppliedValueRelationship() : base()
		{
			ComponentOfTotal = new IfcAppliedValue();
			Components = new List<IfcAppliedValue>();
			ArithmeticOperator = new IfcArithmeticOperatorEnum();
		}
		public IfcAppliedValueRelationship(IfcAppliedValue ComponentOfTotal, List<IfcAppliedValue> Components, IfcArithmeticOperatorEnum ArithmeticOperator, IfcLabel Name, IfcText Description) : base ()
		{
			this.ComponentOfTotal = ComponentOfTotal;
			this.Components = Components;
			this.ArithmeticOperator = ArithmeticOperator;
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcApproval;
	/// <para>ENTITY IfcApproval;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	ApprovalDateTime : IfcDateTimeSelect;</para>
	/// <para>	ApprovalStatus : OPTIONAL IfcLabel;</para>
	/// <para>	ApprovalLevel : OPTIONAL IfcLabel;</para>
	/// <para>	ApprovalQualifier : OPTIONAL IfcText;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Identifier : IfcIdentifier;</para>
	/// <para> INVERSE</para>
	/// <para>	Actors : SET [0:?] OF IfcApprovalActorRelationship FOR Approval;</para>
	/// <para>	IsRelatedWith : SET [0:?] OF IfcApprovalRelationship FOR RelatedApproval;</para>
	/// <para>	Relates : SET [0:?] OF IfcApprovalRelationship FOR RelatingApproval;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcApprovalENTITY
	{
		public IfcText? Description { get; set; }
		public IfcDateTimeSelect ApprovalDateTime { get; set; }
		public IfcLabel? ApprovalStatus { get; set; }
		public IfcLabel? ApprovalLevel { get; set; }
		public IfcText? ApprovalQualifier { get; set; }
		public IfcLabel Name { get; set; }
		public IfcIdentifier Identifier { get; set; }
		public IfcApproval() : base()
		{
			ApprovalDateTime = new IfcDateTimeSelect();
			Name = new IfcLabel();
			Identifier = new IfcIdentifier();
		}
		public IfcApproval(IfcText Description, IfcDateTimeSelect ApprovalDateTime, IfcLabel ApprovalStatus, IfcLabel ApprovalLevel, IfcText ApprovalQualifier, IfcLabel Name, IfcIdentifier Identifier) : base ()
		{
			this.Description = Description;
			this.ApprovalDateTime = ApprovalDateTime;
			this.ApprovalStatus = ApprovalStatus;
			this.ApprovalLevel = ApprovalLevel;
			this.ApprovalQualifier = ApprovalQualifier;
			this.Name = Name;
			this.Identifier = Identifier;
		}
	}
	/// <summary>
	/// ENTITY IfcApprovalActorRelationship;
	/// <para>ENTITY IfcApprovalActorRelationship;</para>
	/// <para>	Actor : IfcActorSelect;</para>
	/// <para>	Approval : IfcApproval;</para>
	/// <para>	Role : IfcActorRole;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcApprovalActorRelationshipENTITY
	{
		public IfcActorSelect Actor { get; set; }
		public IfcApproval Approval { get; set; }
		public IfcActorRole Role { get; set; }
		public IfcApprovalActorRelationship() : base()
		{
			Actor = new IfcActorSelect();
			Approval = new IfcApproval();
			Role = new IfcActorRole();
		}
		public IfcApprovalActorRelationship(IfcActorSelect Actor, IfcApproval Approval, IfcActorRole Role) : base ()
		{
			this.Actor = Actor;
			this.Approval = Approval;
			this.Role = Role;
		}
	}
	/// <summary>
	/// ENTITY IfcApprovalPropertyRelationship;
	/// <para>ENTITY IfcApprovalPropertyRelationship;</para>
	/// <para>	ApprovedProperties : SET [1:?] OF IfcProperty;</para>
	/// <para>	Approval : IfcApproval;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcApprovalPropertyRelationshipENTITY
	{
		public List<IfcProperty> ApprovedProperties { get; set; }
		public IfcApproval Approval { get; set; }
		public IfcApprovalPropertyRelationship() : base()
		{
			ApprovedProperties = new List<IfcProperty>();
			Approval = new IfcApproval();
		}
		public IfcApprovalPropertyRelationship(List<IfcProperty> ApprovedProperties, IfcApproval Approval) : base ()
		{
			this.ApprovedProperties = ApprovedProperties;
			this.Approval = Approval;
		}
	}
	/// <summary>
	/// ENTITY IfcApprovalRelationship;
	/// <para>ENTITY IfcApprovalRelationship;</para>
	/// <para>	RelatedApproval : IfcApproval;</para>
	/// <para>	RelatingApproval : IfcApproval;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcApprovalRelationshipENTITY
	{
		public IfcApproval RelatedApproval { get; set; }
		public IfcApproval RelatingApproval { get; set; }
		public IfcText? Description { get; set; }
		public IfcLabel Name { get; set; }
		public IfcApprovalRelationship() : base()
		{
			RelatedApproval = new IfcApproval();
			RelatingApproval = new IfcApproval();
			Name = new IfcLabel();
		}
		public IfcApprovalRelationship(IfcApproval RelatedApproval, IfcApproval RelatingApproval, IfcText Description, IfcLabel Name) : base ()
		{
			this.RelatedApproval = RelatedApproval;
			this.RelatingApproval = RelatingApproval;
			this.Description = Description;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcArbitraryClosedProfileDef
	/// <para>ENTITY IfcArbitraryClosedProfileDef</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcArbitraryProfileDefWithVoids))</para>
	/// <para> SUBTYPE OF (IfcProfileDef);</para>
	/// <para>	OuterCurve : IfcCurve;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : OuterCurve.Dim = 2;</para>
	/// <para>	WR2 : NOT('IFC2X3.IFCLINE' IN TYPEOF(OuterCurve));</para>
	/// <para>	WR3 : NOT('IFC2X3.IFCOFFSETCURVE2D' IN TYPEOF(OuterCurve));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcArbitraryClosedProfileDef : IfcProfileDef
	{
		public IfcCurve OuterCurve { get; set; }
		public IfcArbitraryClosedProfileDef() : base()
		{
			OuterCurve = new IfcCurve();
		}
		public IfcArbitraryClosedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcCurve OuterCurve) : base (ProfileType, ProfileName)
		{
			this.OuterCurve = OuterCurve;
		}
	}
	/// <summary>
	/// ENTITY IfcArbitraryOpenProfileDef
	/// <para>ENTITY IfcArbitraryOpenProfileDef</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCenterLineProfileDef))</para>
	/// <para> SUBTYPE OF (IfcProfileDef);</para>
	/// <para>	Curve : IfcBoundedCurve;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : ('IFC2X3.IFCCENTERLINEPROFILEDEF' IN TYPEOF(SELF)) OR </para>
	/// <para>              (SELF\IfcProfileDef.ProfileType = IfcProfileTypeEnum.CURVE);</para>
	/// <para>	WR12 : Curve.Dim = 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcArbitraryOpenProfileDef : IfcProfileDef
	{
		public IfcBoundedCurve Curve { get; set; }
		public IfcArbitraryOpenProfileDef() : base()
		{
			Curve = new IfcBoundedCurve();
		}
		public IfcArbitraryOpenProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcBoundedCurve Curve) : base (ProfileType, ProfileName)
		{
			this.Curve = Curve;
		}
	}
	/// <summary>
	/// ENTITY IfcArbitraryProfileDefWithVoids
	/// <para>ENTITY IfcArbitraryProfileDefWithVoids</para>
	/// <para> SUBTYPE OF (IfcArbitraryClosedProfileDef);</para>
	/// <para>	InnerCurves : SET [1:?] OF IfcCurve;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcProfileDef.ProfileType = AREA;</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* InnerCurves | temp.Dim <> 2)) = 0;</para>
	/// <para>	WR3 : SIZEOF(QUERY(temp <* InnerCurves | 'IFC2X3.IFCLINE' IN TYPEOF(temp))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcArbitraryProfileDefWithVoids : IfcArbitraryClosedProfileDef
	{
		public List<IfcCurve> InnerCurves { get; set; }
		public IfcArbitraryProfileDefWithVoids() : base()
		{
			InnerCurves = new List<IfcCurve>();
		}
		public IfcArbitraryProfileDefWithVoids(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcCurve OuterCurve, List<IfcCurve> InnerCurves) : base (ProfileType, ProfileName, OuterCurve)
		{
			this.InnerCurves = InnerCurves;
		}
	}
	/// <summary>
	/// ENTITY IfcAsset
	/// <para>ENTITY IfcAsset</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para>	AssetID : IfcIdentifier;</para>
	/// <para>	OriginalValue : IfcCostValue;</para>
	/// <para>	CurrentValue : IfcCostValue;</para>
	/// <para>	TotalReplacementCost : IfcCostValue;</para>
	/// <para>	Owner : IfcActorSelect;</para>
	/// <para>	User : IfcActorSelect;</para>
	/// <para>	ResponsiblePerson : IfcPerson;</para>
	/// <para>	IncorporationDate : IfcCalendarDate;</para>
	/// <para>	DepreciatedValue : IfcCostValue;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcGroup.IsGroupedBy.RelatedObjects | NOT('IFC2X3.IFCELEMENT' IN TYPEOF(Temp)))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAsset : IfcGroup
	{
		public IfcIdentifier AssetID { get; set; }
		public IfcCostValue OriginalValue { get; set; }
		public IfcCostValue CurrentValue { get; set; }
		public IfcCostValue TotalReplacementCost { get; set; }
		public IfcActorSelect Owner { get; set; }
		public IfcActorSelect User { get; set; }
		public IfcPerson ResponsiblePerson { get; set; }
		public IfcCalendarDate IncorporationDate { get; set; }
		public IfcCostValue DepreciatedValue { get; set; }
		public IfcAsset() : base()
		{
			AssetID = new IfcIdentifier();
			OriginalValue = new IfcCostValue();
			CurrentValue = new IfcCostValue();
			TotalReplacementCost = new IfcCostValue();
			Owner = new IfcActorSelect();
			User = new IfcActorSelect();
			ResponsiblePerson = new IfcPerson();
			IncorporationDate = new IfcCalendarDate();
			DepreciatedValue = new IfcCostValue();
		}
		public IfcAsset(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier AssetID, IfcCostValue OriginalValue, IfcCostValue CurrentValue, IfcCostValue TotalReplacementCost, IfcActorSelect Owner, IfcActorSelect User, IfcPerson ResponsiblePerson, IfcCalendarDate IncorporationDate, IfcCostValue DepreciatedValue) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.AssetID = AssetID;
			this.OriginalValue = OriginalValue;
			this.CurrentValue = CurrentValue;
			this.TotalReplacementCost = TotalReplacementCost;
			this.Owner = Owner;
			this.User = User;
			this.ResponsiblePerson = ResponsiblePerson;
			this.IncorporationDate = IncorporationDate;
			this.DepreciatedValue = DepreciatedValue;
		}
	}
	/// <summary>
	/// ENTITY IfcAsymmetricIShapeProfileDef
	/// <para>ENTITY IfcAsymmetricIShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcIShapeProfileDef);</para>
	/// <para>	TopFlangeWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	TopFlangeThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	TopFlangeFilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAsymmetricIShapeProfileDef : IfcIShapeProfileDef
	{
		public IfcPositiveLengthMeasure TopFlangeWidth { get; set; }
		public IfcPositiveLengthMeasure? TopFlangeThickness { get; set; }
		public IfcPositiveLengthMeasure? TopFlangeFilletRadius { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcAsymmetricIShapeProfileDef() : base()
		{
			TopFlangeWidth = new IfcPositiveLengthMeasure();
		}
		public IfcAsymmetricIShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure OverallWidth, IfcPositiveLengthMeasure OverallDepth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcPositiveLengthMeasure FilletRadius, IfcPositiveLengthMeasure TopFlangeWidth, IfcPositiveLengthMeasure TopFlangeThickness, IfcPositiveLengthMeasure TopFlangeFilletRadius, IfcPositiveLengthMeasure CentreOfGravityInY) : base (ProfileType, ProfileName, Position, OverallWidth, OverallDepth, WebThickness, FlangeThickness, FilletRadius)
		{
			this.TopFlangeWidth = TopFlangeWidth;
			this.TopFlangeThickness = TopFlangeThickness;
			this.TopFlangeFilletRadius = TopFlangeFilletRadius;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcAxis1Placement
	/// <para>ENTITY IfcAxis1Placement</para>
	/// <para> SUBTYPE OF (IfcPlacement);</para>
	/// <para>	Axis : OPTIONAL IfcDirection;</para>
	/// <para> DERIVE</para>
	/// <para>	Z : IfcDirection := NVL (IfcNormalise(Axis), IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcDirection([0.0,0.0,1.0]));</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);</para>
	/// <para>	WR2 : SELF\IfcPlacement.Location.Dim = 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAxis1Placement : IfcPlacement
	{
		public IfcDirection? Axis { get; set; }
		public IfcAxis1Placement() : base()
		{
		}
		public IfcAxis1Placement(IfcCartesianPoint Location, IfcDirection Axis) : base (Location)
		{
			this.Axis = Axis;
		}
	}
	/// <summary>
	/// ENTITY IfcAxis2Placement2D
	/// <para>ENTITY IfcAxis2Placement2D</para>
	/// <para> SUBTYPE OF (IfcPlacement);</para>
	/// <para>	RefDirection : OPTIONAL IfcDirection;</para>
	/// <para> DERIVE</para>
	/// <para>	P : LIST [2:2] OF IfcDirection := IfcBuild2Axes(RefDirection);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (NOT (EXISTS (RefDirection))) OR (RefDirection.Dim = 2);</para>
	/// <para>	WR2 : SELF\IfcPlacement.Location.Dim = 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAxis2Placement2D : IfcPlacement, IfcAxis2Placement
	{
		public IfcDirection? RefDirection { get; set; }
		public IfcAxis2Placement2D() : base()
		{
		}
		public IfcAxis2Placement2D(IfcCartesianPoint Location, IfcDirection RefDirection) : base (Location)
		{
			this.RefDirection = RefDirection;
		}
	}
	/// <summary>
	/// ENTITY IfcAxis2Placement3D
	/// <para>ENTITY IfcAxis2Placement3D</para>
	/// <para> SUBTYPE OF (IfcPlacement);</para>
	/// <para>	Axis : OPTIONAL IfcDirection;</para>
	/// <para>	RefDirection : OPTIONAL IfcDirection;</para>
	/// <para> DERIVE</para>
	/// <para>	P : LIST [3:3] OF IfcDirection := IfcBuildAxes(Axis, RefDirection);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcPlacement.Location.Dim = 3;</para>
	/// <para>	WR2 : (NOT (EXISTS (Axis))) OR (Axis.Dim = 3);</para>
	/// <para>	WR3 : (NOT (EXISTS (RefDirection))) OR (RefDirection.Dim = 3);</para>
	/// <para>	WR4 : (NOT (EXISTS (Axis))) OR (NOT (EXISTS (RefDirection))) OR (IfcCrossProduct(Axis,RefDirection).Magnitude > 0.0);</para>
	/// <para>	WR5 : NOT ((EXISTS (Axis)) XOR (EXISTS (RefDirection)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcAxis2Placement3D : IfcPlacement, IfcAxis2Placement
	{
		public IfcDirection? Axis { get; set; }
		public IfcDirection? RefDirection { get; set; }
		public IfcAxis2Placement3D() : base()
		{
		}
		public IfcAxis2Placement3D(IfcCartesianPoint Location, IfcDirection Axis, IfcDirection RefDirection) : base (Location)
		{
			this.Axis = Axis;
			this.RefDirection = RefDirection;
		}
	}
	/// <summary>
	/// ENTITY IfcBSplineCurve
	/// <para>ENTITY IfcBSplineCurve</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBezierCurve))</para>
	/// <para> SUBTYPE OF (IfcBoundedCurve);</para>
	/// <para>	Degree : INTEGER;</para>
	/// <para>	ControlPointsList : LIST [2:?] OF IfcCartesianPoint;</para>
	/// <para>	CurveForm : IfcBSplineCurveForm;</para>
	/// <para>	ClosedCurve : LOGICAL;</para>
	/// <para>	SelfIntersect : LOGICAL;</para>
	/// <para> DERIVE</para>
	/// <para>	ControlPoints : ARRAY [0:255] OF IfcCartesianPoint := IfcListToArray(ControlPointsList,0,UpperIndexOnControlPoints);</para>
	/// <para>	UpperIndexOnControlPoints : INTEGER := (SIZEOF(ControlPointsList) - 1);</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : SIZEOF(QUERY(Temp <* ControlPointsList |</para>
	/// <para>               Temp.Dim <> ControlPointsList[1].Dim))</para>
	/// <para>             = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBSplineCurve : IfcBoundedCurve
	{
		public INTEGER Degree { get; set; }
		public List<IfcCartesianPoint> ControlPointsList { get; set; }
		public IfcBSplineCurveForm CurveForm { get; set; }
		public LOGICAL ClosedCurve { get; set; }
		public LOGICAL SelfIntersect { get; set; }
		public IfcBSplineCurve() : base()
		{
			Degree = new INTEGER();
			ControlPointsList = new List<IfcCartesianPoint>();
			CurveForm = new IfcBSplineCurveForm();
			ClosedCurve = new LOGICAL();
			SelfIntersect = new LOGICAL();
		}
		public IfcBSplineCurve(INTEGER Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, LOGICAL ClosedCurve, LOGICAL SelfIntersect) : base ()
		{
			this.Degree = Degree;
			this.ControlPointsList = ControlPointsList;
			this.CurveForm = CurveForm;
			this.ClosedCurve = ClosedCurve;
			this.SelfIntersect = SelfIntersect;
		}
	}
	/// <summary>
	/// ENTITY IfcBeam
	/// <para>ENTITY IfcBeam</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBeam : IfcBuildingElement
	{
		public IfcBeam() : base()
		{
		}
		public IfcBeam(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBeamType
	/// <para>ENTITY IfcBeamType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcBeamTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBeamType : IfcBuildingElementType
	{
		public IfcBeamTypeEnum PredefinedType { get; set; }
		public IfcBeamType() : base()
		{
			PredefinedType = new IfcBeamTypeEnum();
		}
		public IfcBeamType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcBeamTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcBezierCurve
	/// <para>ENTITY IfcBezierCurve</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRationalBezierCurve))</para>
	/// <para> SUBTYPE OF (IfcBSplineCurve);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBezierCurve : IfcBSplineCurve
	{
		public IfcBezierCurve() : base()
		{
		}
		public IfcBezierCurve(INTEGER Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, LOGICAL ClosedCurve, LOGICAL SelfIntersect) : base (Degree, ControlPointsList, CurveForm, ClosedCurve, SelfIntersect)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBlobTexture
	/// <para>ENTITY IfcBlobTexture</para>
	/// <para> SUBTYPE OF (IfcSurfaceTexture);</para>
	/// <para>	RasterFormat : IfcIdentifier;</para>
	/// <para>	RasterCode : BOOLEAN;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SELF.RasterFormat IN ['BMP', 'JPG', 'GIF', 'PNG'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBlobTexture : IfcSurfaceTexture
	{
		public IfcIdentifier RasterFormat { get; set; }
		public BOOLEAN RasterCode { get; set; }
		public IfcBlobTexture() : base()
		{
			RasterFormat = new IfcIdentifier();
			RasterCode = new BOOLEAN();
		}
		public IfcBlobTexture(BOOLEAN RepeatS, BOOLEAN RepeatT, IfcSurfaceTextureEnum TextureType, IfcCartesianTransformationOperator2D TextureTransform, IfcIdentifier RasterFormat, BOOLEAN RasterCode) : base (RepeatS, RepeatT, TextureType, TextureTransform)
		{
			this.RasterFormat = RasterFormat;
			this.RasterCode = RasterCode;
		}
	}
	/// <summary>
	/// ENTITY IfcBlock
	/// <para>ENTITY IfcBlock</para>
	/// <para> SUBTYPE OF (IfcCsgPrimitive3D);</para>
	/// <para>	XLength : IfcPositiveLengthMeasure;</para>
	/// <para>	YLength : IfcPositiveLengthMeasure;</para>
	/// <para>	ZLength : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBlock : IfcCsgPrimitive3D
	{
		public IfcPositiveLengthMeasure XLength { get; set; }
		public IfcPositiveLengthMeasure YLength { get; set; }
		public IfcPositiveLengthMeasure ZLength { get; set; }
		public IfcBlock() : base()
		{
			XLength = new IfcPositiveLengthMeasure();
			YLength = new IfcPositiveLengthMeasure();
			ZLength = new IfcPositiveLengthMeasure();
		}
		public IfcBlock(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure XLength, IfcPositiveLengthMeasure YLength, IfcPositiveLengthMeasure ZLength) : base (Position)
		{
			this.XLength = XLength;
			this.YLength = YLength;
			this.ZLength = ZLength;
		}
	}
	/// <summary>
	/// ENTITY IfcBoilerType
	/// <para>ENTITY IfcBoilerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcBoilerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcBoilerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcBoilerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoilerType : IfcEnergyConversionDeviceType
	{
		public IfcBoilerTypeEnum PredefinedType { get; set; }
		public IfcBoilerType() : base()
		{
			PredefinedType = new IfcBoilerTypeEnum();
		}
		public IfcBoilerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcBoilerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcBooleanClippingResult
	/// <para>ENTITY IfcBooleanClippingResult</para>
	/// <para> SUBTYPE OF (IfcBooleanResult);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : ('IFC2X3.IFCSWEPTAREASOLID' IN TYPEOF(FirstOperand)) OR ('IFC2X3.IFCBOOLEANCLIPPINGRESULT' IN TYPEOF(FirstOperand));</para>
	/// <para>	WR2 : ('IFC2X3.IFCHALFSPACESOLID' IN TYPEOF(SecondOperand));</para>
	/// <para>	WR3 : Operator = DIFFERENCE;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBooleanClippingResult : IfcBooleanResult
	{
		public IfcBooleanClippingResult() : base()
		{
		}
		public IfcBooleanClippingResult(IfcBooleanOperator Operator, IfcBooleanOperand FirstOperand, IfcBooleanOperand SecondOperand) : base (Operator, FirstOperand, SecondOperand)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBooleanResult
	/// <para>ENTITY IfcBooleanResult</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBooleanClippingResult))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Operator : IfcBooleanOperator;</para>
	/// <para>	FirstOperand : IfcBooleanOperand;</para>
	/// <para>	SecondOperand : IfcBooleanOperand;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := FirstOperand.Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : FirstOperand.Dim = SecondOperand.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBooleanResult : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		public IfcBooleanOperator Operator { get; set; }
		public IfcBooleanOperand FirstOperand { get; set; }
		public IfcBooleanOperand SecondOperand { get; set; }
		public IfcBooleanResult() : base()
		{
			Operator = new IfcBooleanOperator();
			FirstOperand = new IfcBooleanOperand();
			SecondOperand = new IfcBooleanOperand();
		}
		public IfcBooleanResult(IfcBooleanOperator Operator, IfcBooleanOperand FirstOperand, IfcBooleanOperand SecondOperand) : base ()
		{
			this.Operator = Operator;
			this.FirstOperand = FirstOperand;
			this.SecondOperand = SecondOperand;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundaryCondition
	/// <para>ENTITY IfcBoundaryCondition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBoundaryEdgeCondition</para>
	/// <para>	,IfcBoundaryFaceCondition</para>
	/// <para>	,IfcBoundaryNodeCondition));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBoundaryConditionENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcBoundaryCondition() : base()
		{
		}
		public IfcBoundaryCondition(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundaryEdgeCondition
	/// <para>ENTITY IfcBoundaryEdgeCondition</para>
	/// <para> SUBTYPE OF (IfcBoundaryCondition);</para>
	/// <para>	LinearStiffnessByLengthX : OPTIONAL IfcModulusOfLinearSubgradeReactionMeasure;</para>
	/// <para>	LinearStiffnessByLengthY : OPTIONAL IfcModulusOfLinearSubgradeReactionMeasure;</para>
	/// <para>	LinearStiffnessByLengthZ : OPTIONAL IfcModulusOfLinearSubgradeReactionMeasure;</para>
	/// <para>	RotationalStiffnessByLengthX : OPTIONAL IfcModulusOfRotationalSubgradeReactionMeasure;</para>
	/// <para>	RotationalStiffnessByLengthY : OPTIONAL IfcModulusOfRotationalSubgradeReactionMeasure;</para>
	/// <para>	RotationalStiffnessByLengthZ : OPTIONAL IfcModulusOfRotationalSubgradeReactionMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundaryEdgeCondition : IfcBoundaryCondition
	{
		public IfcModulusOfLinearSubgradeReactionMeasure? LinearStiffnessByLengthX { get; set; }
		public IfcModulusOfLinearSubgradeReactionMeasure? LinearStiffnessByLengthY { get; set; }
		public IfcModulusOfLinearSubgradeReactionMeasure? LinearStiffnessByLengthZ { get; set; }
		public IfcModulusOfRotationalSubgradeReactionMeasure? RotationalStiffnessByLengthX { get; set; }
		public IfcModulusOfRotationalSubgradeReactionMeasure? RotationalStiffnessByLengthY { get; set; }
		public IfcModulusOfRotationalSubgradeReactionMeasure? RotationalStiffnessByLengthZ { get; set; }
		public IfcBoundaryEdgeCondition() : base()
		{
		}
		public IfcBoundaryEdgeCondition(IfcLabel Name, IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthX, IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthY, IfcModulusOfLinearSubgradeReactionMeasure LinearStiffnessByLengthZ, IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthX, IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthY, IfcModulusOfRotationalSubgradeReactionMeasure RotationalStiffnessByLengthZ) : base (Name)
		{
			this.LinearStiffnessByLengthX = LinearStiffnessByLengthX;
			this.LinearStiffnessByLengthY = LinearStiffnessByLengthY;
			this.LinearStiffnessByLengthZ = LinearStiffnessByLengthZ;
			this.RotationalStiffnessByLengthX = RotationalStiffnessByLengthX;
			this.RotationalStiffnessByLengthY = RotationalStiffnessByLengthY;
			this.RotationalStiffnessByLengthZ = RotationalStiffnessByLengthZ;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundaryFaceCondition
	/// <para>ENTITY IfcBoundaryFaceCondition</para>
	/// <para> SUBTYPE OF (IfcBoundaryCondition);</para>
	/// <para>	LinearStiffnessByAreaX : OPTIONAL IfcModulusOfSubgradeReactionMeasure;</para>
	/// <para>	LinearStiffnessByAreaY : OPTIONAL IfcModulusOfSubgradeReactionMeasure;</para>
	/// <para>	LinearStiffnessByAreaZ : OPTIONAL IfcModulusOfSubgradeReactionMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundaryFaceCondition : IfcBoundaryCondition
	{
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaX { get; set; }
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaY { get; set; }
		public IfcModulusOfSubgradeReactionMeasure? LinearStiffnessByAreaZ { get; set; }
		public IfcBoundaryFaceCondition() : base()
		{
		}
		public IfcBoundaryFaceCondition(IfcLabel Name, IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaX, IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaY, IfcModulusOfSubgradeReactionMeasure LinearStiffnessByAreaZ) : base (Name)
		{
			this.LinearStiffnessByAreaX = LinearStiffnessByAreaX;
			this.LinearStiffnessByAreaY = LinearStiffnessByAreaY;
			this.LinearStiffnessByAreaZ = LinearStiffnessByAreaZ;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundaryNodeCondition
	/// <para>ENTITY IfcBoundaryNodeCondition</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBoundaryNodeConditionWarping))</para>
	/// <para> SUBTYPE OF (IfcBoundaryCondition);</para>
	/// <para>	LinearStiffnessX : OPTIONAL IfcLinearStiffnessMeasure;</para>
	/// <para>	LinearStiffnessY : OPTIONAL IfcLinearStiffnessMeasure;</para>
	/// <para>	LinearStiffnessZ : OPTIONAL IfcLinearStiffnessMeasure;</para>
	/// <para>	RotationalStiffnessX : OPTIONAL IfcRotationalStiffnessMeasure;</para>
	/// <para>	RotationalStiffnessY : OPTIONAL IfcRotationalStiffnessMeasure;</para>
	/// <para>	RotationalStiffnessZ : OPTIONAL IfcRotationalStiffnessMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundaryNodeCondition : IfcBoundaryCondition
	{
		public IfcLinearStiffnessMeasure? LinearStiffnessX { get; set; }
		public IfcLinearStiffnessMeasure? LinearStiffnessY { get; set; }
		public IfcLinearStiffnessMeasure? LinearStiffnessZ { get; set; }
		public IfcRotationalStiffnessMeasure? RotationalStiffnessX { get; set; }
		public IfcRotationalStiffnessMeasure? RotationalStiffnessY { get; set; }
		public IfcRotationalStiffnessMeasure? RotationalStiffnessZ { get; set; }
		public IfcBoundaryNodeCondition() : base()
		{
		}
		public IfcBoundaryNodeCondition(IfcLabel Name, IfcLinearStiffnessMeasure LinearStiffnessX, IfcLinearStiffnessMeasure LinearStiffnessY, IfcLinearStiffnessMeasure LinearStiffnessZ, IfcRotationalStiffnessMeasure RotationalStiffnessX, IfcRotationalStiffnessMeasure RotationalStiffnessY, IfcRotationalStiffnessMeasure RotationalStiffnessZ) : base (Name)
		{
			this.LinearStiffnessX = LinearStiffnessX;
			this.LinearStiffnessY = LinearStiffnessY;
			this.LinearStiffnessZ = LinearStiffnessZ;
			this.RotationalStiffnessX = RotationalStiffnessX;
			this.RotationalStiffnessY = RotationalStiffnessY;
			this.RotationalStiffnessZ = RotationalStiffnessZ;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundaryNodeConditionWarping
	/// <para>ENTITY IfcBoundaryNodeConditionWarping</para>
	/// <para> SUBTYPE OF (IfcBoundaryNodeCondition);</para>
	/// <para>	WarpingStiffness : OPTIONAL IfcWarpingMomentMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundaryNodeConditionWarping : IfcBoundaryNodeCondition
	{
		public IfcWarpingMomentMeasure? WarpingStiffness { get; set; }
		public IfcBoundaryNodeConditionWarping() : base()
		{
		}
		public IfcBoundaryNodeConditionWarping(IfcLabel Name, IfcLinearStiffnessMeasure LinearStiffnessX, IfcLinearStiffnessMeasure LinearStiffnessY, IfcLinearStiffnessMeasure LinearStiffnessZ, IfcRotationalStiffnessMeasure RotationalStiffnessX, IfcRotationalStiffnessMeasure RotationalStiffnessY, IfcRotationalStiffnessMeasure RotationalStiffnessZ, IfcWarpingMomentMeasure WarpingStiffness) : base (Name, LinearStiffnessX, LinearStiffnessY, LinearStiffnessZ, RotationalStiffnessX, RotationalStiffnessY, RotationalStiffnessZ)
		{
			this.WarpingStiffness = WarpingStiffness;
		}
	}
	/// <summary>
	/// ENTITY IfcBoundedCurve
	/// <para>ENTITY IfcBoundedCurve</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBSplineCurve</para>
	/// <para>	,IfcCompositeCurve</para>
	/// <para>	,IfcPolyline</para>
	/// <para>	,IfcTrimmedCurve))</para>
	/// <para> SUBTYPE OF (IfcCurve);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBoundedCurve : IfcCurve, IfcCurveOrEdgeCurve
	{
		public IfcBoundedCurve() : base()
		{
		}
		public IfcBoundedCurve() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBoundedSurface
	/// <para>ENTITY IfcBoundedSurface</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCurveBoundedPlane</para>
	/// <para>	,IfcRectangularTrimmedSurface))</para>
	/// <para> SUBTYPE OF (IfcSurface);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundedSurface : IfcSurface
	{
		public IfcBoundedSurface() : base()
		{
		}
		public IfcBoundedSurface() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBoundingBox
	/// <para>ENTITY IfcBoundingBox</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Corner : IfcCartesianPoint;</para>
	/// <para>	XDim : IfcPositiveLengthMeasure;</para>
	/// <para>	YDim : IfcPositiveLengthMeasure;</para>
	/// <para>	ZDim : IfcPositiveLengthMeasure;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoundingBox : IfcGeometricRepresentationItem
	{
		public IfcCartesianPoint Corner { get; set; }
		public IfcPositiveLengthMeasure XDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }
		public IfcPositiveLengthMeasure ZDim { get; set; }
		public IfcBoundingBox() : base()
		{
			Corner = new IfcCartesianPoint();
			XDim = new IfcPositiveLengthMeasure();
			YDim = new IfcPositiveLengthMeasure();
			ZDim = new IfcPositiveLengthMeasure();
		}
		public IfcBoundingBox(IfcCartesianPoint Corner, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure ZDim) : base ()
		{
			this.Corner = Corner;
			this.XDim = XDim;
			this.YDim = YDim;
			this.ZDim = ZDim;
		}
	}
	/// <summary>
	/// ENTITY IfcBoxedHalfSpace
	/// <para>ENTITY IfcBoxedHalfSpace</para>
	/// <para> SUBTYPE OF (IfcHalfSpaceSolid);</para>
	/// <para>	Enclosure : IfcBoundingBox;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : NOT ('IFC2X3.IFCCURVEBOUNDEDPLANE' IN TYPEOF(SELF\IfcHalfSpaceSolid.BaseSurface));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBoxedHalfSpace : IfcHalfSpaceSolid
	{
		public IfcBoundingBox Enclosure { get; set; }
		public IfcBoxedHalfSpace() : base()
		{
			Enclosure = new IfcBoundingBox();
		}
		public IfcBoxedHalfSpace(IfcSurface BaseSurface, BOOLEAN AgreementFlag, IfcBoundingBox Enclosure) : base (BaseSurface, AgreementFlag)
		{
			this.Enclosure = Enclosure;
		}
	}
	/// <summary>
	/// ENTITY IfcBuilding
	/// <para>ENTITY IfcBuilding</para>
	/// <para> SUBTYPE OF (IfcSpatialStructureElement);</para>
	/// <para>	ElevationOfRefHeight : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ElevationOfTerrain : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	BuildingAddress : OPTIONAL IfcPostalAddress;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBuilding : IfcSpatialStructureElement
	{
		public IfcLengthMeasure? ElevationOfRefHeight { get; set; }
		public IfcLengthMeasure? ElevationOfTerrain { get; set; }
		public IfcPostalAddress? BuildingAddress { get; set; }
		public IfcBuilding() : base()
		{
		}
		public IfcBuilding(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcLengthMeasure ElevationOfRefHeight, IfcLengthMeasure ElevationOfTerrain, IfcPostalAddress BuildingAddress) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, LongName, CompositionType)
		{
			this.ElevationOfRefHeight = ElevationOfRefHeight;
			this.ElevationOfTerrain = ElevationOfTerrain;
			this.BuildingAddress = BuildingAddress;
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElement
	/// <para>ENTITY IfcBuildingElement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBeam</para>
	/// <para>	,IfcBuildingElementComponent</para>
	/// <para>	,IfcBuildingElementProxy</para>
	/// <para>	,IfcColumn</para>
	/// <para>	,IfcCovering</para>
	/// <para>	,IfcCurtainWall</para>
	/// <para>	,IfcDoor</para>
	/// <para>	,IfcFooting</para>
	/// <para>	,IfcMember</para>
	/// <para>	,IfcPile</para>
	/// <para>	,IfcPlate</para>
	/// <para>	,IfcRailing</para>
	/// <para>	,IfcRamp</para>
	/// <para>	,IfcRampFlight</para>
	/// <para>	,IfcRoof</para>
	/// <para>	,IfcSlab</para>
	/// <para>	,IfcStair</para>
	/// <para>	,IfcStairFlight</para>
	/// <para>	,IfcWall</para>
	/// <para>	,IfcWindow))</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBuildingElement : IfcElement
	{
		public IfcBuildingElement() : base()
		{
		}
		public IfcBuildingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElementComponent
	/// <para>ENTITY IfcBuildingElementComponent</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBuildingElementPart</para>
	/// <para>	,IfcReinforcingElement))</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBuildingElementComponent : IfcBuildingElement
	{
		public IfcBuildingElementComponent() : base()
		{
		}
		public IfcBuildingElementComponent(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElementPart
	/// <para>ENTITY IfcBuildingElementPart</para>
	/// <para> SUBTYPE OF (IfcBuildingElementComponent);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBuildingElementPart : IfcBuildingElementComponent
	{
		public IfcBuildingElementPart() : base()
		{
		}
		public IfcBuildingElementPart(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElementProxy
	/// <para>ENTITY IfcBuildingElementProxy</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	CompositionType : OPTIONAL IfcElementCompositionEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBuildingElementProxy : IfcBuildingElement
	{
		public IfcElementCompositionEnum? CompositionType { get; set; }
		public IfcBuildingElementProxy() : base()
		{
		}
		public IfcBuildingElementProxy(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElementCompositionEnum CompositionType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.CompositionType = CompositionType;
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElementProxyType
	/// <para>ENTITY IfcBuildingElementProxyType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcBuildingElementProxyTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBuildingElementProxyType : IfcBuildingElementType
	{
		public IfcBuildingElementProxyTypeEnum PredefinedType { get; set; }
		public IfcBuildingElementProxyType() : base()
		{
			PredefinedType = new IfcBuildingElementProxyTypeEnum();
		}
		public IfcBuildingElementProxyType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcBuildingElementProxyTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingElementType
	/// <para>ENTITY IfcBuildingElementType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBeamType</para>
	/// <para>	,IfcBuildingElementProxyType</para>
	/// <para>	,IfcColumnType</para>
	/// <para>	,IfcCoveringType</para>
	/// <para>	,IfcCurtainWallType</para>
	/// <para>	,IfcMemberType</para>
	/// <para>	,IfcPlateType</para>
	/// <para>	,IfcRailingType</para>
	/// <para>	,IfcRampFlightType</para>
	/// <para>	,IfcSlabType</para>
	/// <para>	,IfcStairFlightType</para>
	/// <para>	,IfcWallType))</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcBuildingElementType : IfcElementType
	{
		public IfcBuildingElementType() : base()
		{
		}
		public IfcBuildingElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcBuildingStorey
	/// <para>ENTITY IfcBuildingStorey</para>
	/// <para> SUBTYPE OF (IfcSpatialStructureElement);</para>
	/// <para>	Elevation : OPTIONAL IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcBuildingStorey : IfcSpatialStructureElement
	{
		public IfcLengthMeasure? Elevation { get; set; }
		public IfcBuildingStorey() : base()
		{
		}
		public IfcBuildingStorey(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcLengthMeasure Elevation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, LongName, CompositionType)
		{
			this.Elevation = Elevation;
		}
	}
	/// <summary>
	/// ENTITY IfcCShapeProfileDef
	/// <para>ENTITY IfcCShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para>	Width : IfcPositiveLengthMeasure;</para>
	/// <para>	WallThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	Girth : IfcPositiveLengthMeasure;</para>
	/// <para>	InternalFilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	CentreOfGravityInX : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Girth < (Depth / 2.);</para>
	/// <para>	WR2 : NOT(EXISTS(InternalFilletRadius)) OR</para>
	/// <para>            ((InternalFilletRadius <= Width/2.) AND (InternalFilletRadius <= Depth/2.));</para>
	/// <para>	WR3 : (WallThickness < Width/2.) AND (WallThickness < Depth/2.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure Width { get; set; }
		public IfcPositiveLengthMeasure WallThickness { get; set; }
		public IfcPositiveLengthMeasure Girth { get; set; }
		public IfcPositiveLengthMeasure? InternalFilletRadius { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInX { get; set; }
		public IfcCShapeProfileDef() : base()
		{
			Depth = new IfcPositiveLengthMeasure();
			Width = new IfcPositiveLengthMeasure();
			WallThickness = new IfcPositiveLengthMeasure();
			Girth = new IfcPositiveLengthMeasure();
		}
		public IfcCShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure Width, IfcPositiveLengthMeasure WallThickness, IfcPositiveLengthMeasure Girth, IfcPositiveLengthMeasure InternalFilletRadius, IfcPositiveLengthMeasure CentreOfGravityInX) : base (ProfileType, ProfileName, Position)
		{
			this.Depth = Depth;
			this.Width = Width;
			this.WallThickness = WallThickness;
			this.Girth = Girth;
			this.InternalFilletRadius = InternalFilletRadius;
			this.CentreOfGravityInX = CentreOfGravityInX;
		}
	}
	/// <summary>
	/// ENTITY IfcCableCarrierFittingType
	/// <para>ENTITY IfcCableCarrierFittingType</para>
	/// <para> SUBTYPE OF (IfcFlowFittingType);</para>
	/// <para>	PredefinedType : IfcCableCarrierFittingTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCableCarrierFittingTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCableCarrierFittingTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCableCarrierFittingType : IfcFlowFittingType
	{
		public IfcCableCarrierFittingTypeEnum PredefinedType { get; set; }
		public IfcCableCarrierFittingType() : base()
		{
			PredefinedType = new IfcCableCarrierFittingTypeEnum();
		}
		public IfcCableCarrierFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCableCarrierFittingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCableCarrierSegmentType
	/// <para>ENTITY IfcCableCarrierSegmentType</para>
	/// <para> SUBTYPE OF (IfcFlowSegmentType);</para>
	/// <para>	PredefinedType : IfcCableCarrierSegmentTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCableCarrierSegmentType : IfcFlowSegmentType
	{
		public IfcCableCarrierSegmentTypeEnum PredefinedType { get; set; }
		public IfcCableCarrierSegmentType() : base()
		{
			PredefinedType = new IfcCableCarrierSegmentTypeEnum();
		}
		public IfcCableCarrierSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCableCarrierSegmentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCableSegmentType
	/// <para>ENTITY IfcCableSegmentType</para>
	/// <para> SUBTYPE OF (IfcFlowSegmentType);</para>
	/// <para>	PredefinedType : IfcCableSegmentTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCableSegmentType : IfcFlowSegmentType
	{
		public IfcCableSegmentTypeEnum PredefinedType { get; set; }
		public IfcCableSegmentType() : base()
		{
			PredefinedType = new IfcCableSegmentTypeEnum();
		}
		public IfcCableSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCableSegmentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCalendarDate;
	/// <para>ENTITY IfcCalendarDate;</para>
	/// <para>	DayComponent : IfcDayInMonthNumber;</para>
	/// <para>	MonthComponent : IfcMonthInYearNumber;</para>
	/// <para>	YearComponent : IfcYearNumber;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : IfcValidCalendarDate (SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCalendarDateENTITY, IfcDateTimeSelect, IfcObjectReferenceSelect
	{
		public IfcDayInMonthNumber DayComponent { get; set; }
		public IfcMonthInYearNumber MonthComponent { get; set; }
		public IfcYearNumber YearComponent { get; set; }
		public IfcCalendarDate() : base()
		{
			DayComponent = new IfcDayInMonthNumber();
			MonthComponent = new IfcMonthInYearNumber();
			YearComponent = new IfcYearNumber();
		}
		public IfcCalendarDate(IfcDayInMonthNumber DayComponent, IfcMonthInYearNumber MonthComponent, IfcYearNumber YearComponent) : base ()
		{
			this.DayComponent = DayComponent;
			this.MonthComponent = MonthComponent;
			this.YearComponent = YearComponent;
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianPoint
	/// <para>ENTITY IfcCartesianPoint</para>
	/// <para> SUBTYPE OF (IfcPoint);</para>
	/// <para>	Coordinates : LIST [1:3] OF IfcLengthMeasure;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := HIINDEX(Coordinates);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : HIINDEX(Coordinates) >= 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCartesianPoint : IfcPoint, IfcTrimmingSelect
	{
		public List<IfcLengthMeasure> Coordinates { get; set; }
		public IfcCartesianPoint() : base()
		{
			Coordinates = new List<IfcLengthMeasure>();
		}
		public IfcCartesianPoint(List<IfcLengthMeasure> Coordinates) : base ()
		{
			this.Coordinates = Coordinates;
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianTransformationOperator
	/// <para>ENTITY IfcCartesianTransformationOperator</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCartesianTransformationOperator2D</para>
	/// <para>	,IfcCartesianTransformationOperator3D))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Axis1 : OPTIONAL IfcDirection;</para>
	/// <para>	Axis2 : OPTIONAL IfcDirection;</para>
	/// <para>	LocalOrigin : IfcCartesianPoint;</para>
	/// <para>	Scale : OPTIONAL REAL;</para>
	/// <para> DERIVE</para>
	/// <para>	Scl : REAL := NVL(Scale, 1.0);</para>
	/// <para>	Dim : IfcDimensionCount := LocalOrigin.Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Scl > 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem
	{
		public IfcDirection? Axis1 { get; set; }
		public IfcDirection? Axis2 { get; set; }
		public IfcCartesianPoint LocalOrigin { get; set; }
		public REAL? Scale { get; set; }
		public IfcCartesianTransformationOperator() : base()
		{
			LocalOrigin = new IfcCartesianPoint();
		}
		public IfcCartesianTransformationOperator(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, REAL Scale) : base ()
		{
			this.Axis1 = Axis1;
			this.Axis2 = Axis2;
			this.LocalOrigin = LocalOrigin;
			this.Scale = Scale;
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianTransformationOperator2D
	/// <para>ENTITY IfcCartesianTransformationOperator2D</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCartesianTransformationOperator2DnonUniform))</para>
	/// <para> SUBTYPE OF (IfcCartesianTransformationOperator);</para>
	/// <para> DERIVE</para>
	/// <para>	U : LIST [2:2] OF IfcDirection := IfcBaseAxis(2,SELF\IfcCartesianTransformationOperator.Axis1,</para>
	/// <para>          SELF\IfcCartesianTransformationOperator.Axis2,?);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcCartesianTransformationOperator.Dim = 2;</para>
	/// <para>	WR2 : NOT(EXISTS(SELF\IfcCartesianTransformationOperator.Axis1)) OR </para>
	/// <para>            (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 2);</para>
	/// <para>	WR3 : NOT(EXISTS(SELF\IfcCartesianTransformationOperator.Axis2)) OR </para>
	/// <para>            (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 2);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator
	{
		public IfcCartesianTransformationOperator2D() : base()
		{
		}
		public IfcCartesianTransformationOperator2D(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, REAL Scale) : base (Axis1, Axis2, LocalOrigin, Scale)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianTransformationOperator2DnonUniform
	/// <para>ENTITY IfcCartesianTransformationOperator2DnonUniform</para>
	/// <para> SUBTYPE OF (IfcCartesianTransformationOperator2D);</para>
	/// <para>	Scale2 : OPTIONAL REAL;</para>
	/// <para> DERIVE</para>
	/// <para>	Scl2 : REAL := NVL(Scale2, SELF\IfcCartesianTransformationOperator.Scl);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Scl2 > 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D
	{
		public REAL? Scale2 { get; set; }
		public IfcCartesianTransformationOperator2DnonUniform() : base()
		{
		}
		public IfcCartesianTransformationOperator2DnonUniform(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, REAL Scale, REAL Scale2) : base (Axis1, Axis2, LocalOrigin, Scale)
		{
			this.Scale2 = Scale2;
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianTransformationOperator3D
	/// <para>ENTITY IfcCartesianTransformationOperator3D</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCartesianTransformationOperator3DnonUniform))</para>
	/// <para> SUBTYPE OF (IfcCartesianTransformationOperator);</para>
	/// <para>	Axis3 : OPTIONAL IfcDirection;</para>
	/// <para> DERIVE</para>
	/// <para>	U : LIST [3:3] OF IfcDirection := IfcBaseAxis(3,SELF\IfcCartesianTransformationOperator.Axis1,</para>
	/// <para>              SELF\IfcCartesianTransformationOperator.Axis2,Axis3);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcCartesianTransformationOperator.Dim = 3;</para>
	/// <para>	WR2 : NOT(EXISTS(SELF\IfcCartesianTransformationOperator.Axis1)) OR </para>
	/// <para>            (SELF\IfcCartesianTransformationOperator.Axis1.Dim = 3);</para>
	/// <para>	WR3 : NOT(EXISTS(SELF\IfcCartesianTransformationOperator.Axis2)) OR </para>
	/// <para>            (SELF\IfcCartesianTransformationOperator.Axis2.Dim = 3);</para>
	/// <para>	WR4 : NOT(EXISTS(Axis3)) OR (Axis3.Dim = 3);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator
	{
		public IfcDirection? Axis3 { get; set; }
		public IfcCartesianTransformationOperator3D() : base()
		{
		}
		public IfcCartesianTransformationOperator3D(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, REAL Scale, IfcDirection Axis3) : base (Axis1, Axis2, LocalOrigin, Scale)
		{
			this.Axis3 = Axis3;
		}
	}
	/// <summary>
	/// ENTITY IfcCartesianTransformationOperator3DnonUniform
	/// <para>ENTITY IfcCartesianTransformationOperator3DnonUniform</para>
	/// <para> SUBTYPE OF (IfcCartesianTransformationOperator3D);</para>
	/// <para>	Scale2 : OPTIONAL REAL;</para>
	/// <para>	Scale3 : OPTIONAL REAL;</para>
	/// <para> DERIVE</para>
	/// <para>	Scl2 : REAL := NVL(Scale2, SELF\IfcCartesianTransformationOperator.Scl);</para>
	/// <para>	Scl3 : REAL := NVL(Scale3, SELF\IfcCartesianTransformationOperator.Scl);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Scl2 > 0.0;</para>
	/// <para>	WR2 : Scl3 > 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
	{
		public REAL? Scale2 { get; set; }
		public REAL? Scale3 { get; set; }
		public IfcCartesianTransformationOperator3DnonUniform() : base()
		{
		}
		public IfcCartesianTransformationOperator3DnonUniform(IfcDirection Axis1, IfcDirection Axis2, IfcCartesianPoint LocalOrigin, REAL Scale, IfcDirection Axis3, REAL Scale2, REAL Scale3) : base (Axis1, Axis2, LocalOrigin, Scale, Axis3)
		{
			this.Scale2 = Scale2;
			this.Scale3 = Scale3;
		}
	}
	/// <summary>
	/// ENTITY IfcCenterLineProfileDef
	/// <para>ENTITY IfcCenterLineProfileDef</para>
	/// <para> SUBTYPE OF (IfcArbitraryOpenProfileDef);</para>
	/// <para>	Thickness : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef
	{
		public IfcPositiveLengthMeasure Thickness { get; set; }
		public IfcCenterLineProfileDef() : base()
		{
			Thickness = new IfcPositiveLengthMeasure();
		}
		public IfcCenterLineProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcBoundedCurve Curve, IfcPositiveLengthMeasure Thickness) : base (ProfileType, ProfileName, Curve)
		{
			this.Thickness = Thickness;
		}
	}
	/// <summary>
	/// ENTITY IfcChamferEdgeFeature
	/// <para>ENTITY IfcChamferEdgeFeature</para>
	/// <para> SUBTYPE OF (IfcEdgeFeature);</para>
	/// <para>	Width : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	Height : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcChamferEdgeFeature : IfcEdgeFeature
	{
		public IfcPositiveLengthMeasure? Width { get; set; }
		public IfcPositiveLengthMeasure? Height { get; set; }
		public IfcChamferEdgeFeature() : base()
		{
		}
		public IfcChamferEdgeFeature(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure FeatureLength, IfcPositiveLengthMeasure Width, IfcPositiveLengthMeasure Height) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, FeatureLength)
		{
			this.Width = Width;
			this.Height = Height;
		}
	}
	/// <summary>
	/// ENTITY IfcChillerType
	/// <para>ENTITY IfcChillerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcChillerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcChillerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcChillerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcChillerType : IfcEnergyConversionDeviceType
	{
		public IfcChillerTypeEnum PredefinedType { get; set; }
		public IfcChillerType() : base()
		{
			PredefinedType = new IfcChillerTypeEnum();
		}
		public IfcChillerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcChillerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCircle
	/// <para>ENTITY IfcCircle</para>
	/// <para> SUBTYPE OF (IfcConic);</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCircle : IfcConic
	{
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcCircle() : base()
		{
			Radius = new IfcPositiveLengthMeasure();
		}
		public IfcCircle(IfcAxis2Placement Position, IfcPositiveLengthMeasure Radius) : base (Position)
		{
			this.Radius = Radius;
		}
	}
	/// <summary>
	/// ENTITY IfcCircleHollowProfileDef
	/// <para>ENTITY IfcCircleHollowProfileDef</para>
	/// <para> SUBTYPE OF (IfcCircleProfileDef);</para>
	/// <para>	WallThickness : IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : WallThickness < SELF\IfcCircleProfileDef.Radius;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCircleHollowProfileDef : IfcCircleProfileDef
	{
		public IfcPositiveLengthMeasure WallThickness { get; set; }
		public IfcCircleHollowProfileDef() : base()
		{
			WallThickness = new IfcPositiveLengthMeasure();
		}
		public IfcCircleHollowProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure WallThickness) : base (ProfileType, ProfileName, Position, Radius)
		{
			this.WallThickness = WallThickness;
		}
	}
	/// <summary>
	/// ENTITY IfcCircleProfileDef
	/// <para>ENTITY IfcCircleProfileDef</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCircleHollowProfileDef))</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCircleProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcCircleProfileDef() : base()
		{
			Radius = new IfcPositiveLengthMeasure();
		}
		public IfcCircleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Radius) : base (ProfileType, ProfileName, Position)
		{
			this.Radius = Radius;
		}
	}
	/// <summary>
	/// ENTITY IfcClassification;
	/// <para>ENTITY IfcClassification;</para>
	/// <para>	Source : IfcLabel;</para>
	/// <para>	Edition : IfcLabel;</para>
	/// <para>	EditionDate : OPTIONAL IfcCalendarDate;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	Contains : SET [0:?] OF IfcClassificationItem FOR ItemOf;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationENTITY
	{
		public IfcLabel Source { get; set; }
		public IfcLabel Edition { get; set; }
		public IfcCalendarDate? EditionDate { get; set; }
		public IfcLabel Name { get; set; }
		public IfcClassification() : base()
		{
			Source = new IfcLabel();
			Edition = new IfcLabel();
			Name = new IfcLabel();
		}
		public IfcClassification(IfcLabel Source, IfcLabel Edition, IfcCalendarDate EditionDate, IfcLabel Name) : base ()
		{
			this.Source = Source;
			this.Edition = Edition;
			this.EditionDate = EditionDate;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcClassificationItem;
	/// <para>ENTITY IfcClassificationItem;</para>
	/// <para>	Notation : IfcClassificationNotationFacet;</para>
	/// <para>	ItemOf : OPTIONAL IfcClassification;</para>
	/// <para>	Title : IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	IsClassifiedItemIn : SET [0:1] OF IfcClassificationItemRelationship FOR RelatedItems;</para>
	/// <para>	IsClassifyingItemIn : SET [0:1] OF IfcClassificationItemRelationship FOR RelatingItem;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationItemENTITY
	{
		public IfcClassificationNotationFacet Notation { get; set; }
		public IfcClassification? ItemOf { get; set; }
		public IfcLabel Title { get; set; }
		public IfcClassificationItem() : base()
		{
			Notation = new IfcClassificationNotationFacet();
			Title = new IfcLabel();
		}
		public IfcClassificationItem(IfcClassificationNotationFacet Notation, IfcClassification ItemOf, IfcLabel Title) : base ()
		{
			this.Notation = Notation;
			this.ItemOf = ItemOf;
			this.Title = Title;
		}
	}
	/// <summary>
	/// ENTITY IfcClassificationItemRelationship;
	/// <para>ENTITY IfcClassificationItemRelationship;</para>
	/// <para>	RelatingItem : IfcClassificationItem;</para>
	/// <para>	RelatedItems : SET [1:?] OF IfcClassificationItem;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationItemRelationshipENTITY
	{
		public IfcClassificationItem RelatingItem { get; set; }
		public List<IfcClassificationItem> RelatedItems { get; set; }
		public IfcClassificationItemRelationship() : base()
		{
			RelatingItem = new IfcClassificationItem();
			RelatedItems = new List<IfcClassificationItem>();
		}
		public IfcClassificationItemRelationship(IfcClassificationItem RelatingItem, List<IfcClassificationItem> RelatedItems) : base ()
		{
			this.RelatingItem = RelatingItem;
			this.RelatedItems = RelatedItems;
		}
	}
	/// <summary>
	/// ENTITY IfcClassificationNotation;
	/// <para>ENTITY IfcClassificationNotation;</para>
	/// <para>	NotationFacets : SET [1:?] OF IfcClassificationNotationFacet;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationNotationENTITY, IfcClassificationNotationSelect
	{
		public List<IfcClassificationNotationFacet> NotationFacets { get; set; }
		public IfcClassificationNotation() : base()
		{
			NotationFacets = new List<IfcClassificationNotationFacet>();
		}
		public IfcClassificationNotation(List<IfcClassificationNotationFacet> NotationFacets) : base ()
		{
			this.NotationFacets = NotationFacets;
		}
	}
	/// <summary>
	/// ENTITY IfcClassificationNotationFacet;
	/// <para>ENTITY IfcClassificationNotationFacet;</para>
	/// <para>	NotationValue : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationNotationFacetENTITY
	{
		public IfcLabel NotationValue { get; set; }
		public IfcClassificationNotationFacet() : base()
		{
			NotationValue = new IfcLabel();
		}
		public IfcClassificationNotationFacet(IfcLabel NotationValue) : base ()
		{
			this.NotationValue = NotationValue;
		}
	}
	/// <summary>
	/// ENTITY IfcClassificationReference
	/// <para>ENTITY IfcClassificationReference</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para>	ReferencedSource : OPTIONAL IfcClassification;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClassificationReference : IfcExternalReference, IfcClassificationNotationSelect
	{
		public IfcClassification? ReferencedSource { get; set; }
		public IfcClassificationReference() : base()
		{
		}
		public IfcClassificationReference(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name, IfcClassification ReferencedSource) : base (Location, ItemReference, Name)
		{
			this.ReferencedSource = ReferencedSource;
		}
	}
	/// <summary>
	/// ENTITY IfcClosedShell
	/// <para>ENTITY IfcClosedShell</para>
	/// <para> SUBTYPE OF (IfcConnectedFaceSet);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcClosedShell : IfcConnectedFaceSet, IfcShell
	{
		public IfcClosedShell() : base()
		{
		}
		public IfcClosedShell(List<IfcFace> CfsFaces) : base (CfsFaces)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCoilType
	/// <para>ENTITY IfcCoilType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcCoilTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCoilTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCoilTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCoilType : IfcEnergyConversionDeviceType
	{
		public IfcCoilTypeEnum PredefinedType { get; set; }
		public IfcCoilType() : base()
		{
			PredefinedType = new IfcCoilTypeEnum();
		}
		public IfcCoilType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCoilTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcColourRgb
	/// <para>ENTITY IfcColourRgb</para>
	/// <para> SUBTYPE OF (IfcColourSpecification);</para>
	/// <para>	Red : IfcNormalisedRatioMeasure;</para>
	/// <para>	Green : IfcNormalisedRatioMeasure;</para>
	/// <para>	Blue : IfcNormalisedRatioMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcColourRgb : IfcColourSpecification, IfcColourOrFactor
	{
		public IfcNormalisedRatioMeasure Red { get; set; }
		public IfcNormalisedRatioMeasure Green { get; set; }
		public IfcNormalisedRatioMeasure Blue { get; set; }
		public IfcColourRgb() : base()
		{
			Red = new IfcNormalisedRatioMeasure();
			Green = new IfcNormalisedRatioMeasure();
			Blue = new IfcNormalisedRatioMeasure();
		}
		public IfcColourRgb(IfcLabel Name, IfcNormalisedRatioMeasure Red, IfcNormalisedRatioMeasure Green, IfcNormalisedRatioMeasure Blue) : base (Name)
		{
			this.Red = Red;
			this.Green = Green;
			this.Blue = Blue;
		}
	}
	/// <summary>
	/// ENTITY IfcColourSpecification
	/// <para>ENTITY IfcColourSpecification</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcColourRgb));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcColourSpecificationENTITY, IfcColour
	{
		public IfcLabel? Name { get; set; }
		public IfcColourSpecification() : base()
		{
		}
		public IfcColourSpecification(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcColumn
	/// <para>ENTITY IfcColumn</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcColumn : IfcBuildingElement
	{
		public IfcColumn() : base()
		{
		}
		public IfcColumn(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcColumnType
	/// <para>ENTITY IfcColumnType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcColumnTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcColumnType : IfcBuildingElementType
	{
		public IfcColumnTypeEnum PredefinedType { get; set; }
		public IfcColumnType() : base()
		{
			PredefinedType = new IfcColumnTypeEnum();
		}
		public IfcColumnType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcColumnTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcComplexProperty
	/// <para>ENTITY IfcComplexProperty</para>
	/// <para> SUBTYPE OF (IfcProperty);</para>
	/// <para>	UsageName : IfcIdentifier;</para>
	/// <para>	HasProperties : SET [1:?] OF IfcProperty;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* HasProperties | SELF :=: temp)) = 0;</para>
	/// <para>	WR22 : IfcUniquePropertyName(HasProperties);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcComplexProperty : IfcProperty
	{
		public IfcIdentifier UsageName { get; set; }
		public List<IfcProperty> HasProperties { get; set; }
		public IfcComplexProperty() : base()
		{
			UsageName = new IfcIdentifier();
			HasProperties = new List<IfcProperty>();
		}
		public IfcComplexProperty(IfcIdentifier Name, IfcText Description, IfcIdentifier UsageName, List<IfcProperty> HasProperties) : base (Name, Description)
		{
			this.UsageName = UsageName;
			this.HasProperties = HasProperties;
		}
	}
	/// <summary>
	/// ENTITY IfcCompositeCurve
	/// <para>ENTITY IfcCompositeCurve</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(Ifc2DCompositeCurve))</para>
	/// <para> SUBTYPE OF (IfcBoundedCurve);</para>
	/// <para>	Segments : LIST [1:?] OF IfcCompositeCurveSegment;</para>
	/// <para>	SelfIntersect : LOGICAL;</para>
	/// <para> DERIVE</para>
	/// <para>	NSegments : INTEGER := SIZEOF(Segments);</para>
	/// <para>	ClosedCurve : LOGICAL := Segments[NSegments].Transition <> Discontinuous;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : ((NOT ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 1)) OR ((ClosedCurve) AND (SIZEOF(QUERY(Temp <* Segments | Temp.Transition = Discontinuous)) = 0));</para>
	/// <para>	WR42 : SIZEOF( QUERY( Temp <* Segments | Temp.Dim <> Segments[1].Dim)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCompositeCurve : IfcBoundedCurve
	{
		public List<IfcCompositeCurveSegment> Segments { get; set; }
		public LOGICAL SelfIntersect { get; set; }
		public IfcCompositeCurve() : base()
		{
			Segments = new List<IfcCompositeCurveSegment>();
			SelfIntersect = new LOGICAL();
		}
		public IfcCompositeCurve(List<IfcCompositeCurveSegment> Segments, LOGICAL SelfIntersect) : base ()
		{
			this.Segments = Segments;
			this.SelfIntersect = SelfIntersect;
		}
	}
	/// <summary>
	/// ENTITY IfcCompositeCurveSegment
	/// <para>ENTITY IfcCompositeCurveSegment</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Transition : IfcTransitionCode;</para>
	/// <para>	SameSense : BOOLEAN;</para>
	/// <para>	ParentCurve : IfcCurve;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := ParentCurve.Dim;</para>
	/// <para> INVERSE</para>
	/// <para>	UsingCurves : SET [1:?] OF IfcCompositeCurve FOR Segments;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : ('IFC2X3.IFCBOUNDEDCURVE' IN TYPEOF(ParentCurve));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCompositeCurveSegment : IfcGeometricRepresentationItem
	{
		public IfcTransitionCode Transition { get; set; }
		public BOOLEAN SameSense { get; set; }
		public IfcCurve ParentCurve { get; set; }
		public IfcCompositeCurveSegment() : base()
		{
			Transition = new IfcTransitionCode();
			SameSense = new BOOLEAN();
			ParentCurve = new IfcCurve();
		}
		public IfcCompositeCurveSegment(IfcTransitionCode Transition, BOOLEAN SameSense, IfcCurve ParentCurve) : base ()
		{
			this.Transition = Transition;
			this.SameSense = SameSense;
			this.ParentCurve = ParentCurve;
		}
	}
	/// <summary>
	/// ENTITY IfcCompositeProfileDef
	/// <para>ENTITY IfcCompositeProfileDef</para>
	/// <para> SUBTYPE OF (IfcProfileDef);</para>
	/// <para>	Profiles : SET [2:?] OF IfcProfileDef;</para>
	/// <para>	Label : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(temp <* Profiles | temp.ProfileType <> Profiles[1].ProfileType)) = 0;</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* Profiles | 'IFC2X3.IFCCOMPOSITEPROFILEDEF' IN TYPEOF(temp))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCompositeProfileDef : IfcProfileDef
	{
		public List<IfcProfileDef> Profiles { get; set; }
		public IfcLabel? Label { get; set; }
		public IfcCompositeProfileDef() : base()
		{
			Profiles = new List<IfcProfileDef>();
		}
		public IfcCompositeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, List<IfcProfileDef> Profiles, IfcLabel Label) : base (ProfileType, ProfileName)
		{
			this.Profiles = Profiles;
			this.Label = Label;
		}
	}
	/// <summary>
	/// ENTITY IfcCompressorType
	/// <para>ENTITY IfcCompressorType</para>
	/// <para> SUBTYPE OF (IfcFlowMovingDeviceType);</para>
	/// <para>	PredefinedType : IfcCompressorTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCompressorTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCompressorTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCompressorType : IfcFlowMovingDeviceType
	{
		public IfcCompressorTypeEnum PredefinedType { get; set; }
		public IfcCompressorType() : base()
		{
			PredefinedType = new IfcCompressorTypeEnum();
		}
		public IfcCompressorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCompressorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCondenserType
	/// <para>ENTITY IfcCondenserType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcCondenserTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCondenserTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCondenserTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCondenserType : IfcEnergyConversionDeviceType
	{
		public IfcCondenserTypeEnum PredefinedType { get; set; }
		public IfcCondenserType() : base()
		{
			PredefinedType = new IfcCondenserTypeEnum();
		}
		public IfcCondenserType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCondenserTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCondition
	/// <para>ENTITY IfcCondition</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCondition : IfcGroup
	{
		public IfcCondition() : base()
		{
		}
		public IfcCondition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcConditionCriterion
	/// <para>ENTITY IfcConditionCriterion</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	Criterion : IfcConditionCriterionSelect;</para>
	/// <para>	CriterionDateTime : IfcDateTimeSelect;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConditionCriterion : IfcControl
	{
		public IfcConditionCriterionSelect Criterion { get; set; }
		public IfcDateTimeSelect CriterionDateTime { get; set; }
		public IfcConditionCriterion() : base()
		{
			Criterion = new IfcConditionCriterionSelect();
			CriterionDateTime = new IfcDateTimeSelect();
		}
		public IfcConditionCriterion(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcConditionCriterionSelect Criterion, IfcDateTimeSelect CriterionDateTime) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.Criterion = Criterion;
			this.CriterionDateTime = CriterionDateTime;
		}
	}
	/// <summary>
	/// ENTITY IfcConic
	/// <para>ENTITY IfcConic</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCircle</para>
	/// <para>	,IfcEllipse))</para>
	/// <para> SUBTYPE OF (IfcCurve);</para>
	/// <para>	Position : IfcAxis2Placement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcConic : IfcCurve
	{
		public IfcAxis2Placement Position { get; set; }
		public IfcConic() : base()
		{
			Position = new IfcAxis2Placement();
		}
		public IfcConic(IfcAxis2Placement Position) : base ()
		{
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectedFaceSet
	/// <para>ENTITY IfcConnectedFaceSet</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcClosedShell</para>
	/// <para>	,IfcOpenShell))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>	CfsFaces : SET [1:?] OF IfcFace;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectedFaceSet : IfcTopologicalRepresentationItem
	{
		public List<IfcFace> CfsFaces { get; set; }
		public IfcConnectedFaceSet() : base()
		{
			CfsFaces = new List<IfcFace>();
		}
		public IfcConnectedFaceSet(List<IfcFace> CfsFaces) : base ()
		{
			this.CfsFaces = CfsFaces;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionCurveGeometry
	/// <para>ENTITY IfcConnectionCurveGeometry</para>
	/// <para> SUBTYPE OF (IfcConnectionGeometry);</para>
	/// <para>	CurveOnRelatingElement : IfcCurveOrEdgeCurve;</para>
	/// <para>	CurveOnRelatedElement : OPTIONAL IfcCurveOrEdgeCurve;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectionCurveGeometry : IfcConnectionGeometry
	{
		public IfcCurveOrEdgeCurve CurveOnRelatingElement { get; set; }
		public IfcCurveOrEdgeCurve? CurveOnRelatedElement { get; set; }
		public IfcConnectionCurveGeometry() : base()
		{
			CurveOnRelatingElement = new IfcCurveOrEdgeCurve();
		}
		public IfcConnectionCurveGeometry(IfcCurveOrEdgeCurve CurveOnRelatingElement, IfcCurveOrEdgeCurve CurveOnRelatedElement) : base ()
		{
			this.CurveOnRelatingElement = CurveOnRelatingElement;
			this.CurveOnRelatedElement = CurveOnRelatedElement;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionGeometry
	/// <para>ENTITY IfcConnectionGeometry</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcConnectionCurveGeometry</para>
	/// <para>	,IfcConnectionPointGeometry</para>
	/// <para>	,IfcConnectionPortGeometry</para>
	/// <para>	,IfcConnectionSurfaceGeometry));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcConnectionGeometryENTITY
	{
		public IfcConnectionGeometry() : base()
		{
		}
		public IfcConnectionGeometry() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionPointEccentricity
	/// <para>ENTITY IfcConnectionPointEccentricity</para>
	/// <para> SUBTYPE OF (IfcConnectionPointGeometry);</para>
	/// <para>	EccentricityInX : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	EccentricityInY : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	EccentricityInZ : OPTIONAL IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectionPointEccentricity : IfcConnectionPointGeometry
	{
		public IfcLengthMeasure? EccentricityInX { get; set; }
		public IfcLengthMeasure? EccentricityInY { get; set; }
		public IfcLengthMeasure? EccentricityInZ { get; set; }
		public IfcConnectionPointEccentricity() : base()
		{
		}
		public IfcConnectionPointEccentricity(IfcPointOrVertexPoint PointOnRelatingElement, IfcPointOrVertexPoint PointOnRelatedElement, IfcLengthMeasure EccentricityInX, IfcLengthMeasure EccentricityInY, IfcLengthMeasure EccentricityInZ) : base (PointOnRelatingElement, PointOnRelatedElement)
		{
			this.EccentricityInX = EccentricityInX;
			this.EccentricityInY = EccentricityInY;
			this.EccentricityInZ = EccentricityInZ;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionPointGeometry
	/// <para>ENTITY IfcConnectionPointGeometry</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcConnectionPointEccentricity))</para>
	/// <para> SUBTYPE OF (IfcConnectionGeometry);</para>
	/// <para>	PointOnRelatingElement : IfcPointOrVertexPoint;</para>
	/// <para>	PointOnRelatedElement : OPTIONAL IfcPointOrVertexPoint;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectionPointGeometry : IfcConnectionGeometry
	{
		public IfcPointOrVertexPoint PointOnRelatingElement { get; set; }
		public IfcPointOrVertexPoint? PointOnRelatedElement { get; set; }
		public IfcConnectionPointGeometry() : base()
		{
			PointOnRelatingElement = new IfcPointOrVertexPoint();
		}
		public IfcConnectionPointGeometry(IfcPointOrVertexPoint PointOnRelatingElement, IfcPointOrVertexPoint PointOnRelatedElement) : base ()
		{
			this.PointOnRelatingElement = PointOnRelatingElement;
			this.PointOnRelatedElement = PointOnRelatedElement;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionPortGeometry
	/// <para>ENTITY IfcConnectionPortGeometry</para>
	/// <para> SUBTYPE OF (IfcConnectionGeometry);</para>
	/// <para>	LocationAtRelatingElement : IfcAxis2Placement;</para>
	/// <para>	LocationAtRelatedElement : OPTIONAL IfcAxis2Placement;</para>
	/// <para>	ProfileOfPort : IfcProfileDef;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectionPortGeometry : IfcConnectionGeometry
	{
		public IfcAxis2Placement LocationAtRelatingElement { get; set; }
		public IfcAxis2Placement? LocationAtRelatedElement { get; set; }
		public IfcProfileDef ProfileOfPort { get; set; }
		public IfcConnectionPortGeometry() : base()
		{
			LocationAtRelatingElement = new IfcAxis2Placement();
			ProfileOfPort = new IfcProfileDef();
		}
		public IfcConnectionPortGeometry(IfcAxis2Placement LocationAtRelatingElement, IfcAxis2Placement LocationAtRelatedElement, IfcProfileDef ProfileOfPort) : base ()
		{
			this.LocationAtRelatingElement = LocationAtRelatingElement;
			this.LocationAtRelatedElement = LocationAtRelatedElement;
			this.ProfileOfPort = ProfileOfPort;
		}
	}
	/// <summary>
	/// ENTITY IfcConnectionSurfaceGeometry
	/// <para>ENTITY IfcConnectionSurfaceGeometry</para>
	/// <para> SUBTYPE OF (IfcConnectionGeometry);</para>
	/// <para>	SurfaceOnRelatingElement : IfcSurfaceOrFaceSurface;</para>
	/// <para>	SurfaceOnRelatedElement : OPTIONAL IfcSurfaceOrFaceSurface;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConnectionSurfaceGeometry : IfcConnectionGeometry
	{
		public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement { get; set; }
		public IfcSurfaceOrFaceSurface? SurfaceOnRelatedElement { get; set; }
		public IfcConnectionSurfaceGeometry() : base()
		{
			SurfaceOnRelatingElement = new IfcSurfaceOrFaceSurface();
		}
		public IfcConnectionSurfaceGeometry(IfcSurfaceOrFaceSurface SurfaceOnRelatingElement, IfcSurfaceOrFaceSurface SurfaceOnRelatedElement) : base ()
		{
			this.SurfaceOnRelatingElement = SurfaceOnRelatingElement;
			this.SurfaceOnRelatedElement = SurfaceOnRelatedElement;
		}
	}
	/// <summary>
	/// ENTITY IfcConstraint
	/// <para>ENTITY IfcConstraint</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMetric</para>
	/// <para>	,IfcObjective));</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	ConstraintGrade : IfcConstraintEnum;</para>
	/// <para>	ConstraintSource : OPTIONAL IfcLabel;</para>
	/// <para>	CreatingActor : OPTIONAL IfcActorSelect;</para>
	/// <para>	CreationTime : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	UserDefinedGrade : OPTIONAL IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	ClassifiedAs : SET [0:?] OF IfcConstraintClassificationRelationship FOR ClassifiedConstraint;</para>
	/// <para>	RelatesConstraints : SET [0:?] OF IfcConstraintRelationship FOR RelatingConstraint;</para>
	/// <para>	IsRelatedWith : SET [0:?] OF IfcConstraintRelationship FOR RelatedConstraints;</para>
	/// <para>	PropertiesForConstraint : SET [0:?] OF IfcPropertyConstraintRelationship FOR RelatingConstraint;</para>
	/// <para>	Aggregates : SET [0:?] OF IfcConstraintAggregationRelationship FOR RelatingConstraint;</para>
	/// <para>	IsAggregatedIn : SET [0:?] OF IfcConstraintAggregationRelationship FOR RelatedConstraints;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : (ConstraintGrade <> IfcConstraintEnum.USERDEFINED) OR</para>
	/// <para>             ((ConstraintGrade = IfcConstraintEnum.USERDEFINED) AND EXISTS(SELF\IfcConstraint.UserDefinedGrade));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcConstraintENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcConstraintEnum ConstraintGrade { get; set; }
		public IfcLabel? ConstraintSource { get; set; }
		public IfcActorSelect? CreatingActor { get; set; }
		public IfcDateTimeSelect? CreationTime { get; set; }
		public IfcLabel? UserDefinedGrade { get; set; }
		public IfcConstraint() : base()
		{
			Name = new IfcLabel();
			ConstraintGrade = new IfcConstraintEnum();
		}
		public IfcConstraint(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTimeSelect CreationTime, IfcLabel UserDefinedGrade) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.ConstraintGrade = ConstraintGrade;
			this.ConstraintSource = ConstraintSource;
			this.CreatingActor = CreatingActor;
			this.CreationTime = CreationTime;
			this.UserDefinedGrade = UserDefinedGrade;
		}
	}
	/// <summary>
	/// ENTITY IfcConstraintAggregationRelationship;
	/// <para>ENTITY IfcConstraintAggregationRelationship;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	RelatingConstraint : IfcConstraint;</para>
	/// <para>	RelatedConstraints : LIST [1:?] OF UNIQUE IfcConstraint;</para>
	/// <para>	LogicalAggregator : IfcLogicalOperatorEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(temp <* RelatedConstraints | </para>
	/// <para>               temp :=: RelatingConstraint</para>
	/// <para>               )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstraintAggregationRelationshipENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcConstraint RelatingConstraint { get; set; }
		public IfcConstraintAggregationRelationship() : base()
		{
			RelatingConstraint = new IfcConstraint();
		}
		public IfcConstraintAggregationRelationship(IfcLabel Name, IfcText Description, IfcConstraint RelatingConstraint) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingConstraint = RelatingConstraint;
		}
	}
	/// <summary>
	/// ENTITY IfcConstraintClassificationRelationship;
	/// <para>ENTITY IfcConstraintClassificationRelationship;</para>
	/// <para>	ClassifiedConstraint : IfcConstraint;</para>
	/// <para>	RelatedClassifications : SET [1:?] OF IfcClassificationNotationSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstraintClassificationRelationshipENTITY
	{
		public IfcConstraint ClassifiedConstraint { get; set; }
		public List<IfcClassificationNotationSelect> RelatedClassifications { get; set; }
		public IfcConstraintClassificationRelationship() : base()
		{
			ClassifiedConstraint = new IfcConstraint();
			RelatedClassifications = new List<IfcClassificationNotationSelect>();
		}
		public IfcConstraintClassificationRelationship(IfcConstraint ClassifiedConstraint, List<IfcClassificationNotationSelect> RelatedClassifications) : base ()
		{
			this.ClassifiedConstraint = ClassifiedConstraint;
			this.RelatedClassifications = RelatedClassifications;
		}
	}
	/// <summary>
	/// ENTITY IfcConstraintRelationship;
	/// <para>ENTITY IfcConstraintRelationship;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	RelatingConstraint : IfcConstraint;</para>
	/// <para>	RelatedConstraints : SET [1:?] OF IfcConstraint;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(temp <* RelatedConstraints | temp :=: RelatingConstraint )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstraintRelationshipENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcConstraint RelatingConstraint { get; set; }
		public List<IfcConstraint> RelatedConstraints { get; set; }
		public IfcConstraintRelationship() : base()
		{
			RelatingConstraint = new IfcConstraint();
			RelatedConstraints = new List<IfcConstraint>();
		}
		public IfcConstraintRelationship(IfcLabel Name, IfcText Description, IfcConstraint RelatingConstraint, List<IfcConstraint> RelatedConstraints) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingConstraint = RelatingConstraint;
			this.RelatedConstraints = RelatedConstraints;
		}
	}
	/// <summary>
	/// ENTITY IfcConstructionEquipmentResource
	/// <para>ENTITY IfcConstructionEquipmentResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstructionEquipmentResource : IfcConstructionResource
	{
		public IfcConstructionEquipmentResource() : base()
		{
		}
		public IfcConstructionEquipmentResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcConstructionMaterialResource
	/// <para>ENTITY IfcConstructionMaterialResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para>	Suppliers : OPTIONAL SET [1:?] OF IfcActorSelect;</para>
	/// <para>	UsageRatio : OPTIONAL IfcRatioMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(SELF\IfcResource.ResourceOf) <=1;</para>
	/// <para>	WR2 : NOT(EXISTS(SELF\IfcResource.ResourceOf[1])) OR</para>
	/// <para>            (SELF\IfcResource.ResourceOf[1].RelatedObjectsType = IfcObjectTypeEnum.PRODUCT);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstructionMaterialResource : IfcConstructionResource
	{
		public List<IfcActorSelect>? Suppliers { get; set; }
		public IfcRatioMeasure? UsageRatio { get; set; }
		public IfcConstructionMaterialResource() : base()
		{
		}
		public IfcConstructionMaterialResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity, List<IfcActorSelect> Suppliers, IfcRatioMeasure UsageRatio) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
			this.Suppliers = Suppliers;
			this.UsageRatio = UsageRatio;
		}
	}
	/// <summary>
	/// ENTITY IfcConstructionProductResource
	/// <para>ENTITY IfcConstructionProductResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(SELF\IfcResource.ResourceOf) <=1;</para>
	/// <para>	WR2 : NOT(EXISTS(SELF\IfcResource.ResourceOf[1])) OR</para>
	/// <para>            (SELF\IfcResource.ResourceOf[1].RelatedObjectsType = IfcObjectTypeEnum.PRODUCT);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConstructionProductResource : IfcConstructionResource
	{
		public IfcConstructionProductResource() : base()
		{
		}
		public IfcConstructionProductResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcConstructionResource
	/// <para>ENTITY IfcConstructionResource</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcConstructionEquipmentResource</para>
	/// <para>	,IfcConstructionMaterialResource</para>
	/// <para>	,IfcConstructionProductResource</para>
	/// <para>	,IfcCrewResource</para>
	/// <para>	,IfcLaborResource</para>
	/// <para>	,IfcSubContractResource))</para>
	/// <para> SUBTYPE OF (IfcResource);</para>
	/// <para>	ResourceIdentifier : OPTIONAL IfcIdentifier;</para>
	/// <para>	ResourceGroup : OPTIONAL IfcLabel;</para>
	/// <para>	ResourceConsumption : OPTIONAL IfcResourceConsumptionEnum;</para>
	/// <para>	BaseQuantity : OPTIONAL IfcMeasureWithUnit;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcConstructionResource : IfcResource
	{
		public IfcIdentifier? ResourceIdentifier { get; set; }
		public IfcLabel? ResourceGroup { get; set; }
		public IfcResourceConsumptionEnum? ResourceConsumption { get; set; }
		public IfcMeasureWithUnit? BaseQuantity { get; set; }
		public IfcConstructionResource() : base()
		{
		}
		public IfcConstructionResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ResourceIdentifier = ResourceIdentifier;
			this.ResourceGroup = ResourceGroup;
			this.ResourceConsumption = ResourceConsumption;
			this.BaseQuantity = BaseQuantity;
		}
	}
	/// <summary>
	/// ENTITY IfcContextDependentUnit
	/// <para>ENTITY IfcContextDependentUnit</para>
	/// <para> SUBTYPE OF (IfcNamedUnit);</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcContextDependentUnit : IfcNamedUnit
	{
		public IfcLabel Name { get; set; }
		public IfcContextDependentUnit() : base()
		{
			Name = new IfcLabel();
		}
		public IfcContextDependentUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcLabel Name) : base (Dimensions, UnitType)
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcControl
	/// <para>ENTITY IfcControl</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcActionRequest</para>
	/// <para>	,IfcConditionCriterion</para>
	/// <para>	,IfcCostItem</para>
	/// <para>	,IfcCostSchedule</para>
	/// <para>	,IfcEquipmentStandard</para>
	/// <para>	,IfcFurnitureStandard</para>
	/// <para>	,IfcPerformanceHistory</para>
	/// <para>	,IfcPermit</para>
	/// <para>	,IfcProjectOrder</para>
	/// <para>	,IfcProjectOrderRecord</para>
	/// <para>	,IfcScheduleTimeControl</para>
	/// <para>	,IfcServiceLife</para>
	/// <para>	,IfcSpaceProgram</para>
	/// <para>	,IfcTimeSeriesSchedule</para>
	/// <para>	,IfcWorkControl))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para> INVERSE</para>
	/// <para>	Controls : SET [0:?] OF IfcRelAssignsToControl FOR RelatingControl;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcControl : IfcObject
	{
		public IfcControl() : base()
		{
		}
		public IfcControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcControllerType
	/// <para>ENTITY IfcControllerType</para>
	/// <para> SUBTYPE OF (IfcDistributionControlElementType);</para>
	/// <para>	PredefinedType : IfcControllerTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcControllerType : IfcDistributionControlElementType
	{
		public IfcControllerTypeEnum PredefinedType { get; set; }
		public IfcControllerType() : base()
		{
			PredefinedType = new IfcControllerTypeEnum();
		}
		public IfcControllerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcControllerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcConversionBasedUnit
	/// <para>ENTITY IfcConversionBasedUnit</para>
	/// <para> SUBTYPE OF (IfcNamedUnit);</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	ConversionFactor : IfcMeasureWithUnit;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcConversionBasedUnit : IfcNamedUnit
	{
		public IfcLabel Name { get; set; }
		public IfcMeasureWithUnit ConversionFactor { get; set; }
		public IfcConversionBasedUnit() : base()
		{
			Name = new IfcLabel();
			ConversionFactor = new IfcMeasureWithUnit();
		}
		public IfcConversionBasedUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcLabel Name, IfcMeasureWithUnit ConversionFactor) : base (Dimensions, UnitType)
		{
			this.Name = Name;
			this.ConversionFactor = ConversionFactor;
		}
	}
	/// <summary>
	/// ENTITY IfcCooledBeamType
	/// <para>ENTITY IfcCooledBeamType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcCooledBeamTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCooledBeamTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCooledBeamTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCooledBeamType : IfcEnergyConversionDeviceType
	{
		public IfcCooledBeamTypeEnum PredefinedType { get; set; }
		public IfcCooledBeamType() : base()
		{
			PredefinedType = new IfcCooledBeamTypeEnum();
		}
		public IfcCooledBeamType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCooledBeamTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCoolingTowerType
	/// <para>ENTITY IfcCoolingTowerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcCoolingTowerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcCoolingTowerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcCoolingTowerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCoolingTowerType : IfcEnergyConversionDeviceType
	{
		public IfcCoolingTowerTypeEnum PredefinedType { get; set; }
		public IfcCoolingTowerType() : base()
		{
			PredefinedType = new IfcCoolingTowerTypeEnum();
		}
		public IfcCoolingTowerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCoolingTowerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCoordinatedUniversalTimeOffset;
	/// <para>ENTITY IfcCoordinatedUniversalTimeOffset;</para>
	/// <para>	HourOffset : IfcHourInDay;</para>
	/// <para>	MinuteOffset : OPTIONAL IfcMinuteInHour;</para>
	/// <para>	Sense : IfcAheadOrBehind;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCoordinatedUniversalTimeOffsetENTITY
	{
		public IfcHourInDay HourOffset { get; set; }
		public IfcMinuteInHour? MinuteOffset { get; set; }
		public IfcAheadOrBehind Sense { get; set; }
		public IfcCoordinatedUniversalTimeOffset() : base()
		{
			HourOffset = new IfcHourInDay();
			Sense = new IfcAheadOrBehind();
		}
		public IfcCoordinatedUniversalTimeOffset(IfcHourInDay HourOffset, IfcMinuteInHour MinuteOffset, IfcAheadOrBehind Sense) : base ()
		{
			this.HourOffset = HourOffset;
			this.MinuteOffset = MinuteOffset;
			this.Sense = Sense;
		}
	}
	/// <summary>
	/// ENTITY IfcCostItem
	/// <para>ENTITY IfcCostItem</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCostItem : IfcControl
	{
		public IfcCostItem() : base()
		{
		}
		public IfcCostItem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCostSchedule
	/// <para>ENTITY IfcCostSchedule</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	SubmittedBy : OPTIONAL IfcActorSelect;</para>
	/// <para>	PreparedBy : OPTIONAL IfcActorSelect;</para>
	/// <para>	SubmittedOn : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	Status : OPTIONAL IfcLabel;</para>
	/// <para>	TargetUsers : OPTIONAL SET [1:?] OF IfcActorSelect;</para>
	/// <para>	UpdateDate : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	ID : IfcIdentifier;</para>
	/// <para>	PredefinedType : IfcCostScheduleTypeEnum;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR2 : ID;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCostSchedule : IfcControl
	{
		public IfcActorSelect? SubmittedBy { get; set; }
		public IfcActorSelect? PreparedBy { get; set; }
		public IfcDateTimeSelect? SubmittedOn { get; set; }
		public IfcLabel? Status { get; set; }
		public List<IfcActorSelect>? TargetUsers { get; set; }
		public IfcDateTimeSelect? UpdateDate { get; set; }
		public IfcIdentifier ID { get; set; }
		public IfcCostScheduleTypeEnum PredefinedType { get; set; }
		public IfcCostSchedule() : base()
		{
			ID = new IfcIdentifier();
			PredefinedType = new IfcCostScheduleTypeEnum();
		}
		public IfcCostSchedule(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcActorSelect SubmittedBy, IfcActorSelect PreparedBy, IfcDateTimeSelect SubmittedOn, IfcLabel Status, List<IfcActorSelect> TargetUsers, IfcDateTimeSelect UpdateDate, IfcIdentifier ID, IfcCostScheduleTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.SubmittedBy = SubmittedBy;
			this.PreparedBy = PreparedBy;
			this.SubmittedOn = SubmittedOn;
			this.Status = Status;
			this.TargetUsers = TargetUsers;
			this.UpdateDate = UpdateDate;
			this.ID = ID;
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCostValue
	/// <para>ENTITY IfcCostValue</para>
	/// <para> SUBTYPE OF (IfcAppliedValue);</para>
	/// <para>	CostType : IfcLabel;</para>
	/// <para>	Condition : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCostValue : IfcAppliedValue, IfcMetricValueSelect
	{
		public IfcLabel CostType { get; set; }
		public IfcText? Condition { get; set; }
		public IfcCostValue() : base()
		{
			CostType = new IfcLabel();
		}
		public IfcCostValue(IfcLabel Name, IfcText Description, IfcAppliedValueSelect AppliedValue, IfcMeasureWithUnit UnitBasis, IfcDateTimeSelect ApplicableDate, IfcDateTimeSelect FixedUntilDate, IfcLabel CostType, IfcText Condition) : base (Name, Description, AppliedValue, UnitBasis, ApplicableDate, FixedUntilDate)
		{
			this.CostType = CostType;
			this.Condition = Condition;
		}
	}
	/// <summary>
	/// ENTITY IfcCovering
	/// <para>ENTITY IfcCovering</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	PredefinedType : OPTIONAL IfcCoveringTypeEnum;</para>
	/// <para> INVERSE</para>
	/// <para>	CoversSpaces : SET [0:1] OF IfcRelCoversSpaces FOR RelatedCoverings;</para>
	/// <para>	Covers : SET [0:1] OF IfcRelCoversBldgElements FOR RelatedCoverings;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : NOT(EXISTS(PredefinedType)) OR </para>
	/// <para>              (PredefinedType <> IfcCoveringTypeEnum.USERDEFINED) OR </para>
	/// <para>              ((PredefinedType = IfcCoveringTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCovering : IfcBuildingElement
	{
		public IfcCoveringTypeEnum? PredefinedType { get; set; }
		public IfcCovering() : base()
		{
		}
		public IfcCovering(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcCoveringTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCoveringType
	/// <para>ENTITY IfcCoveringType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcCoveringTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCoveringType : IfcBuildingElementType
	{
		public IfcCoveringTypeEnum PredefinedType { get; set; }
		public IfcCoveringType() : base()
		{
			PredefinedType = new IfcCoveringTypeEnum();
		}
		public IfcCoveringType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCoveringTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCraneRailAShapeProfileDef
	/// <para>ENTITY IfcCraneRailAShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	OverallHeight : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseWidth2 : IfcPositiveLengthMeasure;</para>
	/// <para>	Radius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	HeadWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	HeadDepth2 : IfcPositiveLengthMeasure;</para>
	/// <para>	HeadDepth3 : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseWidth4 : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseDepth1 : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseDepth2 : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseDepth3 : IfcPositiveLengthMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCraneRailAShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure OverallHeight { get; set; }
		public IfcPositiveLengthMeasure BaseWidth2 { get; set; }
		public IfcPositiveLengthMeasure? Radius { get; set; }
		public IfcPositiveLengthMeasure HeadWidth { get; set; }
		public IfcPositiveLengthMeasure HeadDepth2 { get; set; }
		public IfcPositiveLengthMeasure HeadDepth3 { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure BaseWidth4 { get; set; }
		public IfcPositiveLengthMeasure BaseDepth1 { get; set; }
		public IfcPositiveLengthMeasure BaseDepth2 { get; set; }
		public IfcPositiveLengthMeasure BaseDepth3 { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcCraneRailAShapeProfileDef() : base()
		{
			OverallHeight = new IfcPositiveLengthMeasure();
			BaseWidth2 = new IfcPositiveLengthMeasure();
			HeadWidth = new IfcPositiveLengthMeasure();
			HeadDepth2 = new IfcPositiveLengthMeasure();
			HeadDepth3 = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			BaseWidth4 = new IfcPositiveLengthMeasure();
			BaseDepth1 = new IfcPositiveLengthMeasure();
			BaseDepth2 = new IfcPositiveLengthMeasure();
			BaseDepth3 = new IfcPositiveLengthMeasure();
		}
		public IfcCraneRailAShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure BaseWidth2, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure HeadWidth, IfcPositiveLengthMeasure HeadDepth2, IfcPositiveLengthMeasure HeadDepth3, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure BaseWidth4, IfcPositiveLengthMeasure BaseDepth1, IfcPositiveLengthMeasure BaseDepth2, IfcPositiveLengthMeasure BaseDepth3, IfcPositiveLengthMeasure CentreOfGravityInY) : base (ProfileType, ProfileName, Position)
		{
			this.OverallHeight = OverallHeight;
			this.BaseWidth2 = BaseWidth2;
			this.Radius = Radius;
			this.HeadWidth = HeadWidth;
			this.HeadDepth2 = HeadDepth2;
			this.HeadDepth3 = HeadDepth3;
			this.WebThickness = WebThickness;
			this.BaseWidth4 = BaseWidth4;
			this.BaseDepth1 = BaseDepth1;
			this.BaseDepth2 = BaseDepth2;
			this.BaseDepth3 = BaseDepth3;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcCraneRailFShapeProfileDef
	/// <para>ENTITY IfcCraneRailFShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	OverallHeight : IfcPositiveLengthMeasure;</para>
	/// <para>	HeadWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	Radius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	HeadDepth2 : IfcPositiveLengthMeasure;</para>
	/// <para>	HeadDepth3 : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseDepth1 : IfcPositiveLengthMeasure;</para>
	/// <para>	BaseDepth2 : IfcPositiveLengthMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure OverallHeight { get; set; }
		public IfcPositiveLengthMeasure HeadWidth { get; set; }
		public IfcPositiveLengthMeasure? Radius { get; set; }
		public IfcPositiveLengthMeasure HeadDepth2 { get; set; }
		public IfcPositiveLengthMeasure HeadDepth3 { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure BaseDepth1 { get; set; }
		public IfcPositiveLengthMeasure BaseDepth2 { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcCraneRailFShapeProfileDef() : base()
		{
			OverallHeight = new IfcPositiveLengthMeasure();
			HeadWidth = new IfcPositiveLengthMeasure();
			HeadDepth2 = new IfcPositiveLengthMeasure();
			HeadDepth3 = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			BaseDepth1 = new IfcPositiveLengthMeasure();
			BaseDepth2 = new IfcPositiveLengthMeasure();
		}
		public IfcCraneRailFShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure HeadWidth, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure HeadDepth2, IfcPositiveLengthMeasure HeadDepth3, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure BaseDepth1, IfcPositiveLengthMeasure BaseDepth2, IfcPositiveLengthMeasure CentreOfGravityInY) : base (ProfileType, ProfileName, Position)
		{
			this.OverallHeight = OverallHeight;
			this.HeadWidth = HeadWidth;
			this.Radius = Radius;
			this.HeadDepth2 = HeadDepth2;
			this.HeadDepth3 = HeadDepth3;
			this.WebThickness = WebThickness;
			this.BaseDepth1 = BaseDepth1;
			this.BaseDepth2 = BaseDepth2;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcCrewResource
	/// <para>ENTITY IfcCrewResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCrewResource : IfcConstructionResource
	{
		public IfcCrewResource() : base()
		{
		}
		public IfcCrewResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCsgPrimitive3D
	/// <para>ENTITY IfcCsgPrimitive3D</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBlock</para>
	/// <para>	,IfcRectangularPyramid</para>
	/// <para>	,IfcRightCircularCone</para>
	/// <para>	,IfcRightCircularCylinder</para>
	/// <para>	,IfcSphere))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcCsgPrimitive3D : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect
	{
		public IfcAxis2Placement3D Position { get; set; }
		public IfcCsgPrimitive3D() : base()
		{
			Position = new IfcAxis2Placement3D();
		}
		public IfcCsgPrimitive3D(IfcAxis2Placement3D Position) : base ()
		{
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcCsgSolid
	/// <para>ENTITY IfcCsgSolid</para>
	/// <para> SUBTYPE OF (IfcSolidModel);</para>
	/// <para>	TreeRootExpression : IfcCsgSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCsgSolid : IfcSolidModel
	{
		public IfcCsgSelect TreeRootExpression { get; set; }
		public IfcCsgSolid() : base()
		{
			TreeRootExpression = new IfcCsgSelect();
		}
		public IfcCsgSolid(IfcCsgSelect TreeRootExpression) : base ()
		{
			this.TreeRootExpression = TreeRootExpression;
		}
	}
	/// <summary>
	/// ENTITY IfcCurrencyRelationship;
	/// <para>ENTITY IfcCurrencyRelationship;</para>
	/// <para>	RelatingMonetaryUnit : IfcMonetaryUnit;</para>
	/// <para>	RelatedMonetaryUnit : IfcMonetaryUnit;</para>
	/// <para>	ExchangeRate : IfcPositiveRatioMeasure;</para>
	/// <para>	RateDateTime : IfcDateAndTime;</para>
	/// <para>	RateSource : OPTIONAL IfcLibraryInformation;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurrencyRelationshipENTITY
	{
		public IfcMonetaryUnit RelatingMonetaryUnit { get; set; }
		public IfcMonetaryUnit RelatedMonetaryUnit { get; set; }
		public IfcPositiveRatioMeasure ExchangeRate { get; set; }
		public IfcDateAndTime RateDateTime { get; set; }
		public IfcLibraryInformation? RateSource { get; set; }
		public IfcCurrencyRelationship() : base()
		{
			RelatingMonetaryUnit = new IfcMonetaryUnit();
			RelatedMonetaryUnit = new IfcMonetaryUnit();
			ExchangeRate = new IfcPositiveRatioMeasure();
			RateDateTime = new IfcDateAndTime();
		}
		public IfcCurrencyRelationship(IfcMonetaryUnit RelatingMonetaryUnit, IfcMonetaryUnit RelatedMonetaryUnit, IfcPositiveRatioMeasure ExchangeRate, IfcDateAndTime RateDateTime, IfcLibraryInformation RateSource) : base ()
		{
			this.RelatingMonetaryUnit = RelatingMonetaryUnit;
			this.RelatedMonetaryUnit = RelatedMonetaryUnit;
			this.ExchangeRate = ExchangeRate;
			this.RateDateTime = RateDateTime;
			this.RateSource = RateSource;
		}
	}
	/// <summary>
	/// ENTITY IfcCurtainWall
	/// <para>ENTITY IfcCurtainWall</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurtainWall : IfcBuildingElement
	{
		public IfcCurtainWall() : base()
		{
		}
		public IfcCurtainWall(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCurtainWallType
	/// <para>ENTITY IfcCurtainWallType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcCurtainWallTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurtainWallType : IfcBuildingElementType
	{
		public IfcCurtainWallTypeEnum PredefinedType { get; set; }
		public IfcCurtainWallType() : base()
		{
			PredefinedType = new IfcCurtainWallTypeEnum();
		}
		public IfcCurtainWallType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcCurtainWallTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcCurve
	/// <para>ENTITY IfcCurve</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBoundedCurve</para>
	/// <para>	,IfcConic</para>
	/// <para>	,IfcLine</para>
	/// <para>	,IfcOffsetCurve2D</para>
	/// <para>	,IfcOffsetCurve3D))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := IfcCurveDim(SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcCurve : IfcGeometricRepresentationItem, IfcGeometricSetSelect
	{
		public IfcCurve() : base()
		{
		}
		public IfcCurve() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcCurveBoundedPlane
	/// <para>ENTITY IfcCurveBoundedPlane</para>
	/// <para> SUBTYPE OF (IfcBoundedSurface);</para>
	/// <para>	BasisSurface : IfcPlane;</para>
	/// <para>	OuterBoundary : IfcCurve;</para>
	/// <para>	InnerBoundaries : SET [0:?] OF IfcCurve;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := BasisSurface.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurveBoundedPlane : IfcBoundedSurface
	{
		public IfcPlane BasisSurface { get; set; }
		public IfcCurve OuterBoundary { get; set; }
		public List<IfcCurve> InnerBoundaries { get; set; }
		public IfcCurveBoundedPlane() : base()
		{
			BasisSurface = new IfcPlane();
			OuterBoundary = new IfcCurve();
			InnerBoundaries = new List<IfcCurve>();
		}
		public IfcCurveBoundedPlane(IfcPlane BasisSurface, IfcCurve OuterBoundary, List<IfcCurve> InnerBoundaries) : base ()
		{
			this.BasisSurface = BasisSurface;
			this.OuterBoundary = OuterBoundary;
			this.InnerBoundaries = InnerBoundaries;
		}
	}
	/// <summary>
	/// ENTITY IfcCurveStyle
	/// <para>ENTITY IfcCurveStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationStyle);</para>
	/// <para>	CurveFont : OPTIONAL IfcCurveFontOrScaledCurveFontSelect;</para>
	/// <para>	CurveWidth : OPTIONAL IfcSizeSelect;</para>
	/// <para>	CurveColour : OPTIONAL IfcColour;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : (NOT(EXISTS(CurveWidth))) OR</para>
	/// <para>             ('IFC2X3.IFCPOSITIVELENGTHMEASURE' IN TYPEOF(CurveWidth)) OR </para>
	/// <para>              (('IFC2X3.IFCDESCRIPTIVEMEASURE' IN TYPEOF(CurveWidth)) AND</para>
	/// <para>              (CurveWidth = 'by layer'));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurveStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		public IfcCurveFontOrScaledCurveFontSelect? CurveFont { get; set; }
		public IfcSizeSelect? CurveWidth { get; set; }
		public IfcColour? CurveColour { get; set; }
		public IfcCurveStyle() : base()
		{
		}
		public IfcCurveStyle(IfcLabel Name, IfcCurveFontOrScaledCurveFontSelect CurveFont, IfcSizeSelect CurveWidth, IfcColour CurveColour) : base (Name)
		{
			this.CurveFont = CurveFont;
			this.CurveWidth = CurveWidth;
			this.CurveColour = CurveColour;
		}
	}
	/// <summary>
	/// ENTITY IfcCurveStyleFont;
	/// <para>ENTITY IfcCurveStyleFont;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	PatternList : LIST [1:?] OF IfcCurveStyleFontPattern;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurveStyleFontENTITY, IfcCurveStyleFontSelect
	{
		public IfcLabel? Name { get; set; }
		public List<IfcCurveStyleFontPattern> PatternList { get; set; }
		public IfcCurveStyleFont() : base()
		{
			PatternList = new List<IfcCurveStyleFontPattern>();
		}
		public IfcCurveStyleFont(IfcLabel Name, List<IfcCurveStyleFontPattern> PatternList) : base ()
		{
			this.Name = Name;
			this.PatternList = PatternList;
		}
	}
	/// <summary>
	/// ENTITY IfcCurveStyleFontAndScaling;
	/// <para>ENTITY IfcCurveStyleFontAndScaling;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	CurveFont : IfcCurveStyleFontSelect;</para>
	/// <para>	CurveFontScaling : IfcPositiveRatioMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurveStyleFontAndScalingENTITY, IfcCurveFontOrScaledCurveFontSelect
	{
		public IfcLabel? Name { get; set; }
		public IfcCurveStyleFontSelect CurveFont { get; set; }
		public IfcPositiveRatioMeasure CurveFontScaling { get; set; }
		public IfcCurveStyleFontAndScaling() : base()
		{
			CurveFont = new IfcCurveStyleFontSelect();
			CurveFontScaling = new IfcPositiveRatioMeasure();
		}
		public IfcCurveStyleFontAndScaling(IfcLabel Name, IfcCurveStyleFontSelect CurveFont, IfcPositiveRatioMeasure CurveFontScaling) : base ()
		{
			this.Name = Name;
			this.CurveFont = CurveFont;
			this.CurveFontScaling = CurveFontScaling;
		}
	}
	/// <summary>
	/// ENTITY IfcCurveStyleFontPattern;
	/// <para>ENTITY IfcCurveStyleFontPattern;</para>
	/// <para>	VisibleSegmentLength : IfcLengthMeasure;</para>
	/// <para>	InvisibleSegmentLength : IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR01 : VisibleSegmentLength >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcCurveStyleFontPatternENTITY
	{
		public IfcLengthMeasure VisibleSegmentLength { get; set; }
		public IfcPositiveLengthMeasure InvisibleSegmentLength { get; set; }
		public IfcCurveStyleFontPattern() : base()
		{
			VisibleSegmentLength = new IfcLengthMeasure();
			InvisibleSegmentLength = new IfcPositiveLengthMeasure();
		}
		public IfcCurveStyleFontPattern(IfcLengthMeasure VisibleSegmentLength, IfcPositiveLengthMeasure InvisibleSegmentLength) : base ()
		{
			this.VisibleSegmentLength = VisibleSegmentLength;
			this.InvisibleSegmentLength = InvisibleSegmentLength;
		}
	}
	/// <summary>
	/// ENTITY IfcDamperType
	/// <para>ENTITY IfcDamperType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcDamperTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcDamperTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcDamperTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDamperType : IfcFlowControllerType
	{
		public IfcDamperTypeEnum PredefinedType { get; set; }
		public IfcDamperType() : base()
		{
			PredefinedType = new IfcDamperTypeEnum();
		}
		public IfcDamperType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcDamperTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcDateAndTime;
	/// <para>ENTITY IfcDateAndTime;</para>
	/// <para>	DateComponent : IfcCalendarDate;</para>
	/// <para>	TimeComponent : IfcLocalTime;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDateAndTimeENTITY, IfcDateTimeSelect, IfcObjectReferenceSelect
	{
		public IfcCalendarDate DateComponent { get; set; }
		public IfcLocalTime TimeComponent { get; set; }
		public IfcDateAndTime() : base()
		{
			DateComponent = new IfcCalendarDate();
			TimeComponent = new IfcLocalTime();
		}
		public IfcDateAndTime(IfcCalendarDate DateComponent, IfcLocalTime TimeComponent) : base ()
		{
			this.DateComponent = DateComponent;
			this.TimeComponent = TimeComponent;
		}
	}
	/// <summary>
	/// ENTITY IfcDefinedSymbol
	/// <para>ENTITY IfcDefinedSymbol</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Definition : IfcDefinedSymbolSelect;</para>
	/// <para>	Target : IfcCartesianTransformationOperator2D;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDefinedSymbol : IfcGeometricRepresentationItem
	{
		public IfcDefinedSymbolSelect Definition { get; set; }
		public IfcCartesianTransformationOperator2D Target { get; set; }
		public IfcDefinedSymbol() : base()
		{
			Definition = new IfcDefinedSymbolSelect();
			Target = new IfcCartesianTransformationOperator2D();
		}
		public IfcDefinedSymbol(IfcDefinedSymbolSelect Definition, IfcCartesianTransformationOperator2D Target) : base ()
		{
			this.Definition = Definition;
			this.Target = Target;
		}
	}
	/// <summary>
	/// ENTITY IfcDerivedProfileDef
	/// <para>ENTITY IfcDerivedProfileDef</para>
	/// <para> SUBTYPE OF (IfcProfileDef);</para>
	/// <para>	ParentProfile : IfcProfileDef;</para>
	/// <para>	Operator : IfcCartesianTransformationOperator2D;</para>
	/// <para>	Label : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SELF\IfcProfileDef.ProfileType = ParentProfile.ProfileType;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDerivedProfileDef : IfcProfileDef
	{
		public IfcProfileDef ParentProfile { get; set; }
		public IfcCartesianTransformationOperator2D Operator { get; set; }
		public IfcLabel? Label { get; set; }
		public IfcDerivedProfileDef() : base()
		{
			ParentProfile = new IfcProfileDef();
			Operator = new IfcCartesianTransformationOperator2D();
		}
		public IfcDerivedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcProfileDef ParentProfile, IfcCartesianTransformationOperator2D Operator, IfcLabel Label) : base (ProfileType, ProfileName)
		{
			this.ParentProfile = ParentProfile;
			this.Operator = Operator;
			this.Label = Label;
		}
	}
	/// <summary>
	/// ENTITY IfcDerivedUnit;
	/// <para>ENTITY IfcDerivedUnit;</para>
	/// <para>	Elements : SET [1:?] OF IfcDerivedUnitElement;</para>
	/// <para>	UnitType : IfcDerivedUnitEnum;</para>
	/// <para>	UserDefinedType : OPTIONAL IfcLabel;</para>
	/// <para> DERIVE</para>
	/// <para>	Dimensions : IfcDimensionalExponents := IfcDeriveDimensionalExponents(Elements);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (SIZEOF (Elements) > 1) OR ((SIZEOF (Elements) = 1) AND (Elements[1].Exponent <> 1 ));</para>
	/// <para>	WR2 : (UnitType <> IfcDerivedUnitEnum.USERDEFINED) OR</para>
	/// <para>            ((UnitType = IfcDerivedUnitEnum.USERDEFINED) AND </para>
	/// <para>             (EXISTS(SELF.UserDefinedType)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDerivedUnitENTITY, IfcUnit
	{
		public List<IfcDerivedUnitElement> Elements { get; set; }
		public IfcDerivedUnitEnum UnitType { get; set; }
		public IfcLabel? UserDefinedType { get; set; }
		public IfcDerivedUnit() : base()
		{
			Elements = new List<IfcDerivedUnitElement>();
			UnitType = new IfcDerivedUnitEnum();
		}
		public IfcDerivedUnit(List<IfcDerivedUnitElement> Elements, IfcDerivedUnitEnum UnitType, IfcLabel UserDefinedType) : base ()
		{
			this.Elements = Elements;
			this.UnitType = UnitType;
			this.UserDefinedType = UserDefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcDerivedUnitElement;
	/// <para>ENTITY IfcDerivedUnitElement;</para>
	/// <para>	Unit : IfcNamedUnit;</para>
	/// <para>	Exponent : INTEGER;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDerivedUnitElementENTITY
	{
		public IfcNamedUnit Unit { get; set; }
		public INTEGER Exponent { get; set; }
		public IfcDerivedUnitElement() : base()
		{
			Unit = new IfcNamedUnit();
			Exponent = new INTEGER();
		}
		public IfcDerivedUnitElement(IfcNamedUnit Unit, INTEGER Exponent) : base ()
		{
			this.Unit = Unit;
			this.Exponent = Exponent;
		}
	}
	/// <summary>
	/// ENTITY IfcDiameterDimension
	/// <para>ENTITY IfcDiameterDimension</para>
	/// <para> SUBTYPE OF (IfcDimensionCurveDirectedCallout);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDiameterDimension : IfcDimensionCurveDirectedCallout
	{
		public IfcDiameterDimension() : base()
		{
		}
		public IfcDiameterDimension(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionCalloutRelationship
	/// <para>ENTITY IfcDimensionCalloutRelationship</para>
	/// <para> SUBTYPE OF (IfcDraughtingCalloutRelationship);</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SELF\IfcDraughtingCalloutRelationship.Name IN ['primary','secondary'];</para>
	/// <para>	WR12 : SIZEOF(TYPEOF(SELF\IfcDraughtingCalloutRelationship.RelatingDraughtingCallout) * [</para>
	/// <para>                  'IFC2X3.IFCANGULARDIMENSION',</para>
	/// <para>                  'IFC2X3.IFCDIAMETERDIMENSION',</para>
	/// <para>                  'IFC2X3.IFCLINEARDIMENSION',</para>
	/// <para>                  'IFC2X3.IFCRADIUSDIMENSION']) = 1;</para>
	/// <para>	WR13 : NOT ('IFC2X3.IFCDIMENSIONCURVEDIRECTEDCALLOUT'</para>
	/// <para>               IN TYPEOF (SELF\IfcDraughtingCalloutRelationship.RelatedDraughtingCallout));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionCalloutRelationship : IfcDraughtingCalloutRelationship
	{
		public IfcDimensionCalloutRelationship() : base()
		{
		}
		public IfcDimensionCalloutRelationship(IfcLabel Name, IfcText Description, IfcDraughtingCallout RelatingDraughtingCallout, IfcDraughtingCallout RelatedDraughtingCallout) : base (Name, Description, RelatingDraughtingCallout, RelatedDraughtingCallout)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionCurve
	/// <para>ENTITY IfcDimensionCurve</para>
	/// <para> SUBTYPE OF (IfcAnnotationCurveOccurrence);</para>
	/// <para> INVERSE</para>
	/// <para>	AnnotatedBySymbols : SET [0:2] OF IfcTerminatorSymbol FOR AnnotatedCurve;</para>
	/// <para> WHERE</para>
	/// <para>	WR51 : SIZEOF(USEDIN(SELF,'IFC2X3.IFCDRAUGHTINGCALLOUT.CONTENTS')) </para>
	/// <para>                   >= 1;</para>
	/// <para>	WR52 : (SIZEOF(QUERY (Dct1 <* USEDIN(SELF,'IFC2X3.' + </para>
	/// <para>                            'IFCTERMINATORSYMBOL.ANNOTATEDCURVE') | (Dct1.Role = IfcDimensionExtentUsage.ORIGIN))) <= 1) </para>
	/// <para>             AND </para>
	/// <para>             (SIZEOF(QUERY (Dct2 <* USEDIN(SELF,'IFC2X3.' + </para>
	/// <para>                            'IFCTERMINATORSYMBOL.ANNOTATEDCURVE') | (Dct2.Role = IfcDimensionExtentUsage.TARGET))) <= 1);</para>
	/// <para>	WR53 : SIZEOF(QUERY (Dct <* AnnotatedBySymbols | </para>
	/// <para>               NOT('IFC2X3.IFCDIMENSIONCURVETERMINATOR' IN TYPEOF(Dct)))) </para>
	/// <para>               = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionCurve : IfcAnnotationCurveOccurrence
	{
		public IfcDimensionCurve() : base()
		{
		}
		public IfcDimensionCurve(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionCurveDirectedCallout
	/// <para>ENTITY IfcDimensionCurveDirectedCallout</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAngularDimension</para>
	/// <para>	,IfcDiameterDimension</para>
	/// <para>	,IfcLinearDimension</para>
	/// <para>	,IfcRadiusDimension))</para>
	/// <para> SUBTYPE OF (IfcDraughtingCallout);</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : SIZEOF(QUERY (Dc <* SELF\IfcDraughtingCallout.Contents | (</para>
	/// <para>                   'IFC2X3.IFCDIMENSIONCURVE' IN TYPEOF(Dc)))) </para>
	/// <para>                  = 1;</para>
	/// <para>	WR42 : SIZEOF (QUERY (Dc <* SELF.contents |</para>
	/// <para>                    ('IFC2X3.IFCPROJECTIONCURVE' IN</para>
	/// <para>                      TYPEOF (Dc)))) <= 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionCurveDirectedCallout : IfcDraughtingCallout
	{
		public IfcDimensionCurveDirectedCallout() : base()
		{
		}
		public IfcDimensionCurveDirectedCallout(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionCurveTerminator
	/// <para>ENTITY IfcDimensionCurveTerminator</para>
	/// <para> SUBTYPE OF (IfcTerminatorSymbol);</para>
	/// <para>	Role : IfcDimensionExtentUsage;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : 'IFC2X3.IFCDIMENSIONCURVE' IN TYPEOF</para>
	/// <para>             (SELF\IfcTerminatorSymbol.AnnotatedCurve);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionCurveTerminator : IfcTerminatorSymbol
	{
		public IfcDimensionExtentUsage Role { get; set; }
		public IfcDimensionCurveTerminator() : base()
		{
			Role = new IfcDimensionExtentUsage();
		}
		public IfcDimensionCurveTerminator(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name, IfcAnnotationCurveOccurrence AnnotatedCurve, IfcDimensionExtentUsage Role) : base (Item, Styles, Name, AnnotatedCurve)
		{
			this.Role = Role;
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionPair
	/// <para>ENTITY IfcDimensionPair</para>
	/// <para> SUBTYPE OF (IfcDraughtingCalloutRelationship);</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SELF.Name IN ['chained','parallel'];</para>
	/// <para>	WR12 : SIZEOF(TYPEOF(SELF.RelatingDraughtingCallout) * [</para>
	/// <para>                            'IFC2X3.IFCANGULARDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCDIAMETERDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCLINEARDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCRADIUSDIMENSION']) = 1;</para>
	/// <para>	WR13 : SIZEOF(TYPEOF(SELF.RelatedDraughtingCallout) * [</para>
	/// <para>                            'IFC2X3.IFCANGULARDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCDIAMETERDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCLINEARDIMENSION',</para>
	/// <para>                            'IFC2X3.IFCRADIUSDIMENSION']) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionPair : IfcDraughtingCalloutRelationship
	{
		public IfcDimensionPair() : base()
		{
		}
		public IfcDimensionPair(IfcLabel Name, IfcText Description, IfcDraughtingCallout RelatingDraughtingCallout, IfcDraughtingCallout RelatedDraughtingCallout) : base (Name, Description, RelatingDraughtingCallout, RelatedDraughtingCallout)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDimensionalExponents;
	/// <para>ENTITY IfcDimensionalExponents;</para>
	/// <para>	LengthExponent : INTEGER;</para>
	/// <para>	MassExponent : INTEGER;</para>
	/// <para>	TimeExponent : INTEGER;</para>
	/// <para>	ElectricCurrentExponent : INTEGER;</para>
	/// <para>	ThermodynamicTemperatureExponent : INTEGER;</para>
	/// <para>	AmountOfSubstanceExponent : INTEGER;</para>
	/// <para>	LuminousIntensityExponent : INTEGER;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDimensionalExponentsENTITY
	{
		public INTEGER LengthExponent { get; set; }
		public INTEGER MassExponent { get; set; }
		public INTEGER TimeExponent { get; set; }
		public INTEGER ElectricCurrentExponent { get; set; }
		public INTEGER ThermodynamicTemperatureExponent { get; set; }
		public INTEGER AmountOfSubstanceExponent { get; set; }
		public INTEGER LuminousIntensityExponent { get; set; }
		public IfcDimensionalExponents() : base()
		{
			LengthExponent = new INTEGER();
			MassExponent = new INTEGER();
			TimeExponent = new INTEGER();
			ElectricCurrentExponent = new INTEGER();
			ThermodynamicTemperatureExponent = new INTEGER();
			AmountOfSubstanceExponent = new INTEGER();
			LuminousIntensityExponent = new INTEGER();
		}
		public IfcDimensionalExponents(INTEGER LengthExponent, INTEGER MassExponent, INTEGER TimeExponent, INTEGER ElectricCurrentExponent, INTEGER ThermodynamicTemperatureExponent, INTEGER AmountOfSubstanceExponent, INTEGER LuminousIntensityExponent) : base ()
		{
			this.LengthExponent = LengthExponent;
			this.MassExponent = MassExponent;
			this.TimeExponent = TimeExponent;
			this.ElectricCurrentExponent = ElectricCurrentExponent;
			this.ThermodynamicTemperatureExponent = ThermodynamicTemperatureExponent;
			this.AmountOfSubstanceExponent = AmountOfSubstanceExponent;
			this.LuminousIntensityExponent = LuminousIntensityExponent;
		}
	}
	/// <summary>
	/// ENTITY IfcDirection
	/// <para>ENTITY IfcDirection</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	DirectionRatios : LIST [2:3] OF REAL;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := HIINDEX(DirectionRatios);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDirection : IfcGeometricRepresentationItem, IfcOrientationSelect, IfcVectorOrDirection
	{
		public List<REAL> DirectionRatios { get; set; }
		public IfcDirection() : base()
		{
			DirectionRatios = new List<REAL>();
		}
		public IfcDirection(List<REAL> DirectionRatios) : base ()
		{
			this.DirectionRatios = DirectionRatios;
		}
	}
	/// <summary>
	/// ENTITY IfcDiscreteAccessory
	/// <para>ENTITY IfcDiscreteAccessory</para>
	/// <para> SUBTYPE OF (IfcElementComponent);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDiscreteAccessory : IfcElementComponent
	{
		public IfcDiscreteAccessory() : base()
		{
		}
		public IfcDiscreteAccessory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDiscreteAccessoryType
	/// <para>ENTITY IfcDiscreteAccessoryType</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcVibrationIsolatorType))</para>
	/// <para> SUBTYPE OF (IfcElementComponentType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDiscreteAccessoryType : IfcElementComponentType
	{
		public IfcDiscreteAccessoryType() : base()
		{
		}
		public IfcDiscreteAccessoryType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionChamberElement
	/// <para>ENTITY IfcDistributionChamberElement</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionChamberElement : IfcDistributionFlowElement
	{
		public IfcDistributionChamberElement() : base()
		{
		}
		public IfcDistributionChamberElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionChamberElementType
	/// <para>ENTITY IfcDistributionChamberElementType</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>	PredefinedType : IfcDistributionChamberElementTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionChamberElementType : IfcDistributionFlowElementType
	{
		public IfcDistributionChamberElementTypeEnum PredefinedType { get; set; }
		public IfcDistributionChamberElementType() : base()
		{
			PredefinedType = new IfcDistributionChamberElementTypeEnum();
		}
		public IfcDistributionChamberElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcDistributionChamberElementTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionControlElement
	/// <para>ENTITY IfcDistributionControlElement</para>
	/// <para> SUBTYPE OF (IfcDistributionElement);</para>
	/// <para>	ControlElementId : OPTIONAL IfcIdentifier;</para>
	/// <para> INVERSE</para>
	/// <para>	AssignedToFlowElement : SET [0:1] OF IfcRelFlowControlElements FOR RelatedControlElements;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionControlElement : IfcDistributionElement
	{
		public IfcIdentifier? ControlElementId { get; set; }
		public IfcDistributionControlElement() : base()
		{
		}
		public IfcDistributionControlElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcIdentifier ControlElementId) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.ControlElementId = ControlElementId;
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionControlElementType
	/// <para>ENTITY IfcDistributionControlElementType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcActuatorType</para>
	/// <para>	,IfcAlarmType</para>
	/// <para>	,IfcControllerType</para>
	/// <para>	,IfcFlowInstrumentType</para>
	/// <para>	,IfcSensorType))</para>
	/// <para> SUBTYPE OF (IfcDistributionElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcDistributionControlElementType : IfcDistributionElementType
	{
		public IfcDistributionControlElementType() : base()
		{
		}
		public IfcDistributionControlElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionElement
	/// <para>ENTITY IfcDistributionElement</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDistributionControlElement</para>
	/// <para>	,IfcDistributionFlowElement))</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionElement : IfcElement
	{
		public IfcDistributionElement() : base()
		{
		}
		public IfcDistributionElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionElementType
	/// <para>ENTITY IfcDistributionElementType</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDistributionControlElementType</para>
	/// <para>	,IfcDistributionFlowElementType))</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionElementType : IfcElementType
	{
		public IfcDistributionElementType() : base()
		{
		}
		public IfcDistributionElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionFlowElement
	/// <para>ENTITY IfcDistributionFlowElement</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDistributionChamberElement</para>
	/// <para>	,IfcEnergyConversionDevice</para>
	/// <para>	,IfcFlowController</para>
	/// <para>	,IfcFlowFitting</para>
	/// <para>	,IfcFlowMovingDevice</para>
	/// <para>	,IfcFlowSegment</para>
	/// <para>	,IfcFlowStorageDevice</para>
	/// <para>	,IfcFlowTerminal</para>
	/// <para>	,IfcFlowTreatmentDevice))</para>
	/// <para> SUBTYPE OF (IfcDistributionElement);</para>
	/// <para> INVERSE</para>
	/// <para>	HasControlElements : SET [0:1] OF IfcRelFlowControlElements FOR RelatingFlowElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionFlowElement : IfcDistributionElement
	{
		public IfcDistributionFlowElement() : base()
		{
		}
		public IfcDistributionFlowElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionFlowElementType
	/// <para>ENTITY IfcDistributionFlowElementType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDistributionChamberElementType</para>
	/// <para>	,IfcEnergyConversionDeviceType</para>
	/// <para>	,IfcFlowControllerType</para>
	/// <para>	,IfcFlowFittingType</para>
	/// <para>	,IfcFlowMovingDeviceType</para>
	/// <para>	,IfcFlowSegmentType</para>
	/// <para>	,IfcFlowStorageDeviceType</para>
	/// <para>	,IfcFlowTerminalType</para>
	/// <para>	,IfcFlowTreatmentDeviceType))</para>
	/// <para> SUBTYPE OF (IfcDistributionElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcDistributionFlowElementType : IfcDistributionElementType
	{
		public IfcDistributionFlowElementType() : base()
		{
		}
		public IfcDistributionFlowElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDistributionPort
	/// <para>ENTITY IfcDistributionPort</para>
	/// <para> SUBTYPE OF (IfcPort);</para>
	/// <para>	FlowDirection : OPTIONAL IfcFlowDirectionEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDistributionPort : IfcPort
	{
		public IfcFlowDirectionEnum? FlowDirection { get; set; }
		public IfcDistributionPort() : base()
		{
		}
		public IfcDistributionPort(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcFlowDirectionEnum FlowDirection) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.FlowDirection = FlowDirection;
		}
	}
	/// <summary>
	/// ENTITY IfcDocumentElectronicFormat;
	/// <para>ENTITY IfcDocumentElectronicFormat;</para>
	/// <para>	FileExtension : OPTIONAL IfcLabel;</para>
	/// <para>	MimeContentType : OPTIONAL IfcLabel;</para>
	/// <para>	MimeSubtype : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(FileExtension) OR EXISTS(MimeContentType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDocumentElectronicFormatENTITY
	{
		public IfcLabel? FileExtension { get; set; }
		public IfcLabel? MimeContentType { get; set; }
		public IfcLabel? MimeSubtype { get; set; }
		public IfcDocumentElectronicFormat() : base()
		{
		}
		public IfcDocumentElectronicFormat(IfcLabel FileExtension, IfcLabel MimeContentType, IfcLabel MimeSubtype) : base ()
		{
			this.FileExtension = FileExtension;
			this.MimeContentType = MimeContentType;
			this.MimeSubtype = MimeSubtype;
		}
	}
	/// <summary>
	/// ENTITY IfcDocumentInformation;
	/// <para>ENTITY IfcDocumentInformation;</para>
	/// <para>	DocumentId : IfcIdentifier;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	DocumentReferences : OPTIONAL SET [1:?] OF IfcDocumentReference;</para>
	/// <para>	Purpose : OPTIONAL IfcText;</para>
	/// <para>	IntendedUse : OPTIONAL IfcText;</para>
	/// <para>	Scope : OPTIONAL IfcText;</para>
	/// <para>	Revision : OPTIONAL IfcLabel;</para>
	/// <para>	DocumentOwner : OPTIONAL IfcActorSelect;</para>
	/// <para>	Editors : OPTIONAL SET [1:?] OF IfcActorSelect;</para>
	/// <para>	CreationTime : OPTIONAL IfcDateAndTime;</para>
	/// <para>	LastRevisionTime : OPTIONAL IfcDateAndTime;</para>
	/// <para>	ElectronicFormat : OPTIONAL IfcDocumentElectronicFormat;</para>
	/// <para>	ValidFrom : OPTIONAL IfcCalendarDate;</para>
	/// <para>	ValidUntil : OPTIONAL IfcCalendarDate;</para>
	/// <para>	Confidentiality : OPTIONAL IfcDocumentConfidentialityEnum;</para>
	/// <para>	Status : OPTIONAL IfcDocumentStatusEnum;</para>
	/// <para> INVERSE</para>
	/// <para>	IsPointedTo : SET [0:?] OF IfcDocumentInformationRelationship FOR RelatedDocuments;</para>
	/// <para>	IsPointer : SET [0:1] OF IfcDocumentInformationRelationship FOR RelatingDocument;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDocumentInformationENTITY, IfcDocumentSelect
	{
		public IfcIdentifier DocumentId { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public List<IfcDocumentReference>? DocumentReferences { get; set; }
		public IfcText? Purpose { get; set; }
		public IfcText? IntendedUse { get; set; }
		public IfcText? Scope { get; set; }
		public IfcLabel? Revision { get; set; }
		public IfcActorSelect? DocumentOwner { get; set; }
		public List<IfcActorSelect>? Editors { get; set; }
		public IfcDateAndTime? CreationTime { get; set; }
		public IfcDateAndTime? LastRevisionTime { get; set; }
		public IfcDocumentElectronicFormat? ElectronicFormat { get; set; }
		public IfcCalendarDate? ValidFrom { get; set; }
		public IfcCalendarDate? ValidUntil { get; set; }
		public IfcDocumentConfidentialityEnum? Confidentiality { get; set; }
		public IfcDocumentStatusEnum? Status { get; set; }
		public IfcDocumentInformation() : base()
		{
			DocumentId = new IfcIdentifier();
			Name = new IfcLabel();
		}
		public IfcDocumentInformation(IfcIdentifier DocumentId, IfcLabel Name, IfcText Description, List<IfcDocumentReference> DocumentReferences, IfcText Purpose, IfcText IntendedUse, IfcText Scope, IfcLabel Revision, IfcActorSelect DocumentOwner, List<IfcActorSelect> Editors, IfcDateAndTime CreationTime, IfcDateAndTime LastRevisionTime, IfcDocumentElectronicFormat ElectronicFormat, IfcCalendarDate ValidFrom, IfcCalendarDate ValidUntil, IfcDocumentConfidentialityEnum Confidentiality, IfcDocumentStatusEnum Status) : base ()
		{
			this.DocumentId = DocumentId;
			this.Name = Name;
			this.Description = Description;
			this.DocumentReferences = DocumentReferences;
			this.Purpose = Purpose;
			this.IntendedUse = IntendedUse;
			this.Scope = Scope;
			this.Revision = Revision;
			this.DocumentOwner = DocumentOwner;
			this.Editors = Editors;
			this.CreationTime = CreationTime;
			this.LastRevisionTime = LastRevisionTime;
			this.ElectronicFormat = ElectronicFormat;
			this.ValidFrom = ValidFrom;
			this.ValidUntil = ValidUntil;
			this.Confidentiality = Confidentiality;
			this.Status = Status;
		}
	}
	/// <summary>
	/// ENTITY IfcDocumentInformationRelationship;
	/// <para>ENTITY IfcDocumentInformationRelationship;</para>
	/// <para>	RelatingDocument : IfcDocumentInformation;</para>
	/// <para>	RelatedDocuments : SET [1:?] OF IfcDocumentInformation;</para>
	/// <para>	RelationshipType : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDocumentInformationRelationshipENTITY
	{
		public IfcDocumentInformation RelatingDocument { get; set; }
		public List<IfcDocumentInformation> RelatedDocuments { get; set; }
		public IfcLabel? RelationshipType { get; set; }
		public IfcDocumentInformationRelationship() : base()
		{
			RelatingDocument = new IfcDocumentInformation();
			RelatedDocuments = new List<IfcDocumentInformation>();
		}
		public IfcDocumentInformationRelationship(IfcDocumentInformation RelatingDocument, List<IfcDocumentInformation> RelatedDocuments, IfcLabel RelationshipType) : base ()
		{
			this.RelatingDocument = RelatingDocument;
			this.RelatedDocuments = RelatedDocuments;
			this.RelationshipType = RelationshipType;
		}
	}
	/// <summary>
	/// ENTITY IfcDocumentReference
	/// <para>ENTITY IfcDocumentReference</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para> INVERSE</para>
	/// <para>	ReferenceToDocument : SET [0:1] OF IfcDocumentInformation FOR DocumentReferences;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(Name) XOR EXISTS(ReferenceToDocument[1]);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDocumentReference : IfcExternalReference, IfcDocumentSelect
	{
		public IfcDocumentReference() : base()
		{
		}
		public IfcDocumentReference(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDoor
	/// <para>ENTITY IfcDoor</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	OverallHeight : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	OverallWidth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDoor : IfcBuildingElement
	{
		public IfcPositiveLengthMeasure? OverallHeight { get; set; }
		public IfcPositiveLengthMeasure? OverallWidth { get; set; }
		public IfcDoor() : base()
		{
		}
		public IfcDoor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
		}
	}
	/// <summary>
	/// ENTITY IfcDoorLiningProperties
	/// <para>ENTITY IfcDoorLiningProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	LiningDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	LiningThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	ThresholdDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	ThresholdThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	TransomThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	TransomOffset : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	LiningOffset : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ThresholdOffset : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	CasingThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	CasingDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	ShapeAspectStyle : OPTIONAL IfcShapeAspect;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(NOT(EXISTS(LiningDepth)) AND EXISTS(LiningThickness));</para>
	/// <para>	WR32 : NOT(NOT(EXISTS(ThresholdDepth)) AND EXISTS(ThresholdThickness));</para>
	/// <para>	WR33 : (EXISTS(TransomOffset) AND EXISTS(TransomThickness)) XOR</para>
	/// <para>             (NOT(EXISTS(TransomOffset)) AND NOT(EXISTS(TransomThickness)));</para>
	/// <para>	WR34 : (EXISTS(CasingDepth) AND EXISTS(CasingThickness)) XOR</para>
	/// <para>             (NOT(EXISTS(CasingDepth)) AND NOT(EXISTS(CasingThickness)));</para>
	/// <para>	WR35 : EXISTS(SELF\IfcPropertySetDefinition.DefinesType[1]) AND </para>
	/// <para>             ('IFC2X3.IFCDOORSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDoorLiningProperties : IfcPropertySetDefinition
	{
		public IfcPositiveLengthMeasure? LiningDepth { get; set; }
		public IfcPositiveLengthMeasure? LiningThickness { get; set; }
		public IfcPositiveLengthMeasure? ThresholdDepth { get; set; }
		public IfcPositiveLengthMeasure? ThresholdThickness { get; set; }
		public IfcPositiveLengthMeasure? TransomThickness { get; set; }
		public IfcLengthMeasure? TransomOffset { get; set; }
		public IfcLengthMeasure? LiningOffset { get; set; }
		public IfcLengthMeasure? ThresholdOffset { get; set; }
		public IfcPositiveLengthMeasure? CasingThickness { get; set; }
		public IfcPositiveLengthMeasure? CasingDepth { get; set; }
		public IfcShapeAspect? ShapeAspectStyle { get; set; }
		public IfcDoorLiningProperties() : base()
		{
		}
		public IfcDoorLiningProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure LiningDepth, IfcPositiveLengthMeasure LiningThickness, IfcPositiveLengthMeasure ThresholdDepth, IfcPositiveLengthMeasure ThresholdThickness, IfcPositiveLengthMeasure TransomThickness, IfcLengthMeasure TransomOffset, IfcLengthMeasure LiningOffset, IfcLengthMeasure ThresholdOffset, IfcPositiveLengthMeasure CasingThickness, IfcPositiveLengthMeasure CasingDepth, IfcShapeAspect ShapeAspectStyle) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.LiningDepth = LiningDepth;
			this.LiningThickness = LiningThickness;
			this.ThresholdDepth = ThresholdDepth;
			this.ThresholdThickness = ThresholdThickness;
			this.TransomThickness = TransomThickness;
			this.TransomOffset = TransomOffset;
			this.LiningOffset = LiningOffset;
			this.ThresholdOffset = ThresholdOffset;
			this.CasingThickness = CasingThickness;
			this.CasingDepth = CasingDepth;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcDoorPanelProperties
	/// <para>ENTITY IfcDoorPanelProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	PanelDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	PanelOperation : IfcDoorPanelOperationEnum;</para>
	/// <para>	PanelWidth : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	PanelPosition : IfcDoorPanelPositionEnum;</para>
	/// <para>	ShapeAspectStyle : OPTIONAL IfcShapeAspect;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : EXISTS(SELF\IfcPropertySetDefinition.DefinesType[1]) AND </para>
	/// <para>             ('IFC2X3.IFCDOORSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDoorPanelProperties : IfcPropertySetDefinition
	{
		public IfcPositiveLengthMeasure? PanelDepth { get; set; }
		public IfcDoorPanelOperationEnum PanelOperation { get; set; }
		public IfcNormalisedRatioMeasure? PanelWidth { get; set; }
		public IfcDoorPanelPositionEnum PanelPosition { get; set; }
		public IfcShapeAspect? ShapeAspectStyle { get; set; }
		public IfcDoorPanelProperties() : base()
		{
			PanelOperation = new IfcDoorPanelOperationEnum();
			PanelPosition = new IfcDoorPanelPositionEnum();
		}
		public IfcDoorPanelProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure PanelDepth, IfcDoorPanelOperationEnum PanelOperation, IfcNormalisedRatioMeasure PanelWidth, IfcDoorPanelPositionEnum PanelPosition, IfcShapeAspect ShapeAspectStyle) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.PanelDepth = PanelDepth;
			this.PanelOperation = PanelOperation;
			this.PanelWidth = PanelWidth;
			this.PanelPosition = PanelPosition;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcDoorStyle
	/// <para>ENTITY IfcDoorStyle</para>
	/// <para> SUBTYPE OF (IfcTypeProduct);</para>
	/// <para>	OperationType : IfcDoorStyleOperationEnum;</para>
	/// <para>	ConstructionType : IfcDoorStyleConstructionEnum;</para>
	/// <para>	ParameterTakesPrecedence : BOOLEAN;</para>
	/// <para>	Sizeable : BOOLEAN;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDoorStyle : IfcTypeProduct
	{
		public IfcDoorStyleOperationEnum OperationType { get; set; }
		public IfcDoorStyleConstructionEnum ConstructionType { get; set; }
		public BOOLEAN ParameterTakesPrecedence { get; set; }
		public BOOLEAN Sizeable { get; set; }
		public IfcDoorStyle() : base()
		{
			OperationType = new IfcDoorStyleOperationEnum();
			ConstructionType = new IfcDoorStyleConstructionEnum();
			ParameterTakesPrecedence = new BOOLEAN();
			Sizeable = new BOOLEAN();
		}
		public IfcDoorStyle(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcDoorStyleOperationEnum OperationType, IfcDoorStyleConstructionEnum ConstructionType, BOOLEAN ParameterTakesPrecedence, BOOLEAN Sizeable) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets)
		{
			this.OperationType = OperationType;
			this.ConstructionType = ConstructionType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.Sizeable = Sizeable;
		}
	}
	/// <summary>
	/// ENTITY IfcDraughtingCallout
	/// <para>ENTITY IfcDraughtingCallout</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDimensionCurveDirectedCallout</para>
	/// <para>	,IfcStructuredDimensionCallout))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Contents : SET [1:?] OF IfcDraughtingCalloutElement;</para>
	/// <para> INVERSE</para>
	/// <para>	IsRelatedFromCallout : SET [0:?] OF IfcDraughtingCalloutRelationship FOR RelatedDraughtingCallout;</para>
	/// <para>	IsRelatedToCallout : SET [0:?] OF IfcDraughtingCalloutRelationship FOR RelatingDraughtingCallout;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDraughtingCallout : IfcGeometricRepresentationItem
	{
		public List<IfcDraughtingCalloutElement> Contents { get; set; }
		public IfcDraughtingCallout() : base()
		{
			Contents = new List<IfcDraughtingCalloutElement>();
		}
		public IfcDraughtingCallout(List<IfcDraughtingCalloutElement> Contents) : base ()
		{
			this.Contents = Contents;
		}
	}
	/// <summary>
	/// ENTITY IfcDraughtingCalloutRelationship
	/// <para>ENTITY IfcDraughtingCalloutRelationship</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDimensionCalloutRelationship</para>
	/// <para>	,IfcDimensionPair));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	RelatingDraughtingCallout : IfcDraughtingCallout;</para>
	/// <para>	RelatedDraughtingCallout : IfcDraughtingCallout;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDraughtingCalloutRelationshipENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcDraughtingCallout RelatingDraughtingCallout { get; set; }
		public IfcDraughtingCallout RelatedDraughtingCallout { get; set; }
		public IfcDraughtingCalloutRelationship() : base()
		{
			RelatingDraughtingCallout = new IfcDraughtingCallout();
			RelatedDraughtingCallout = new IfcDraughtingCallout();
		}
		public IfcDraughtingCalloutRelationship(IfcLabel Name, IfcText Description, IfcDraughtingCallout RelatingDraughtingCallout, IfcDraughtingCallout RelatedDraughtingCallout) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingDraughtingCallout = RelatingDraughtingCallout;
			this.RelatedDraughtingCallout = RelatedDraughtingCallout;
		}
	}
	/// <summary>
	/// ENTITY IfcDraughtingPreDefinedColour
	/// <para>ENTITY IfcDraughtingPreDefinedColour</para>
	/// <para> SUBTYPE OF (IfcPreDefinedColour);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPreDefinedItem.Name IN ['black','red','green','blue','yellow',</para>
	/// <para>                  'magenta','cyan','white','by layer'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDraughtingPreDefinedColour : IfcPreDefinedColour
	{
		public IfcDraughtingPreDefinedColour() : base()
		{
		}
		public IfcDraughtingPreDefinedColour(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDraughtingPreDefinedCurveFont
	/// <para>ENTITY IfcDraughtingPreDefinedCurveFont</para>
	/// <para> SUBTYPE OF (IfcPreDefinedCurveFont);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPredefinedItem.Name IN</para>
	/// <para>                    ['continuous',</para>
	/// <para>                     'chain',</para>
	/// <para>                     'chain double dash',</para>
	/// <para>                     'dashed',</para>
	/// <para>                     'dotted',</para>
	/// <para>                     'by layer'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDraughtingPreDefinedCurveFont : IfcPreDefinedCurveFont
	{
		public IfcDraughtingPreDefinedCurveFont() : base()
		{
		}
		public IfcDraughtingPreDefinedCurveFont(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDraughtingPreDefinedTextFont
	/// <para>ENTITY IfcDraughtingPreDefinedTextFont</para>
	/// <para> SUBTYPE OF (IfcPreDefinedTextFont);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPreDefinedItem.Name IN ['ISO 3098-1 font A','ISO 3098-1 font B'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDraughtingPreDefinedTextFont : IfcPreDefinedTextFont
	{
		public IfcDraughtingPreDefinedTextFont() : base()
		{
		}
		public IfcDraughtingPreDefinedTextFont(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcDuctFittingType
	/// <para>ENTITY IfcDuctFittingType</para>
	/// <para> SUBTYPE OF (IfcFlowFittingType);</para>
	/// <para>	PredefinedType : IfcDuctFittingTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR2 : (PredefinedType <> IfcDuctFittingTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcDuctFittingTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDuctFittingType : IfcFlowFittingType
	{
		public IfcDuctFittingTypeEnum PredefinedType { get; set; }
		public IfcDuctFittingType() : base()
		{
			PredefinedType = new IfcDuctFittingTypeEnum();
		}
		public IfcDuctFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcDuctFittingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcDuctSegmentType
	/// <para>ENTITY IfcDuctSegmentType</para>
	/// <para> SUBTYPE OF (IfcFlowSegmentType);</para>
	/// <para>	PredefinedType : IfcDuctSegmentTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcDuctSegmentTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcDuctSegmentTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDuctSegmentType : IfcFlowSegmentType
	{
		public IfcDuctSegmentTypeEnum PredefinedType { get; set; }
		public IfcDuctSegmentType() : base()
		{
			PredefinedType = new IfcDuctSegmentTypeEnum();
		}
		public IfcDuctSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcDuctSegmentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcDuctSilencerType
	/// <para>ENTITY IfcDuctSilencerType</para>
	/// <para> SUBTYPE OF (IfcFlowTreatmentDeviceType);</para>
	/// <para>	PredefinedType : IfcDuctSilencerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcDuctSilencerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcDuctSilencerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcDuctSilencerType : IfcFlowTreatmentDeviceType
	{
		public IfcDuctSilencerTypeEnum PredefinedType { get; set; }
		public IfcDuctSilencerType() : base()
		{
			PredefinedType = new IfcDuctSilencerTypeEnum();
		}
		public IfcDuctSilencerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcDuctSilencerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcEdge
	/// <para>ENTITY IfcEdge</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcEdgeCurve</para>
	/// <para>	,IfcOrientedEdge</para>
	/// <para>	,IfcSubedge))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>	EdgeStart : IfcVertex;</para>
	/// <para>	EdgeEnd : IfcVertex;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEdge : IfcTopologicalRepresentationItem
	{
		public IfcVertex EdgeStart { get; set; }
		public IfcVertex EdgeEnd { get; set; }
		public IfcEdge() : base()
		{
			EdgeStart = new IfcVertex();
			EdgeEnd = new IfcVertex();
		}
		public IfcEdge(IfcVertex EdgeStart, IfcVertex EdgeEnd) : base ()
		{
			this.EdgeStart = EdgeStart;
			this.EdgeEnd = EdgeEnd;
		}
	}
	/// <summary>
	/// ENTITY IfcEdgeCurve
	/// <para>ENTITY IfcEdgeCurve</para>
	/// <para> SUBTYPE OF (IfcEdge);</para>
	/// <para>	EdgeGeometry : IfcCurve;</para>
	/// <para>	SameSense : BOOLEAN;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEdgeCurve : IfcEdge, IfcCurveOrEdgeCurve
	{
		public IfcCurve EdgeGeometry { get; set; }
		public BOOLEAN SameSense { get; set; }
		public IfcEdgeCurve() : base()
		{
			EdgeGeometry = new IfcCurve();
			SameSense = new BOOLEAN();
		}
		public IfcEdgeCurve(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcCurve EdgeGeometry, BOOLEAN SameSense) : base (EdgeStart, EdgeEnd)
		{
			this.EdgeGeometry = EdgeGeometry;
			this.SameSense = SameSense;
		}
	}
	/// <summary>
	/// ENTITY IfcEdgeFeature
	/// <para>ENTITY IfcEdgeFeature</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcChamferEdgeFeature</para>
	/// <para>	,IfcRoundedEdgeFeature))</para>
	/// <para> SUBTYPE OF (IfcFeatureElementSubtraction);</para>
	/// <para>	FeatureLength : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcEdgeFeature : IfcFeatureElementSubtraction
	{
		public IfcPositiveLengthMeasure? FeatureLength { get; set; }
		public IfcEdgeFeature() : base()
		{
		}
		public IfcEdgeFeature(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure FeatureLength) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.FeatureLength = FeatureLength;
		}
	}
	/// <summary>
	/// ENTITY IfcEdgeLoop
	/// <para>ENTITY IfcEdgeLoop</para>
	/// <para> SUBTYPE OF (IfcLoop);</para>
	/// <para>	EdgeList : LIST [1:?] OF IfcOrientedEdge;</para>
	/// <para> DERIVE</para>
	/// <para>	Ne : INTEGER := SIZEOF(EdgeList);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (EdgeList[1].EdgeStart) :=: (EdgeList[Ne].EdgeEnd);</para>
	/// <para>	WR2 : IfcLoopHeadToTail(SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEdgeLoop : IfcLoop
	{
		public List<IfcOrientedEdge> EdgeList { get; set; }
		public IfcEdgeLoop() : base()
		{
			EdgeList = new List<IfcOrientedEdge>();
		}
		public IfcEdgeLoop(List<IfcOrientedEdge> EdgeList) : base ()
		{
			this.EdgeList = EdgeList;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricApplianceType
	/// <para>ENTITY IfcElectricApplianceType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcElectricApplianceTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricApplianceType : IfcFlowTerminalType
	{
		public IfcElectricApplianceTypeEnum PredefinedType { get; set; }
		public IfcElectricApplianceType() : base()
		{
			PredefinedType = new IfcElectricApplianceTypeEnum();
		}
		public IfcElectricApplianceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricApplianceTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricDistributionPoint
	/// <para>ENTITY IfcElectricDistributionPoint</para>
	/// <para> SUBTYPE OF (IfcFlowController);</para>
	/// <para>	DistributionPointFunction : IfcElectricDistributionPointFunctionEnum;</para>
	/// <para>	UserDefinedFunction : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : (DistributionPointFunction <> IfcElectricDistributionPointFunctionEnum.USERDEFINED) OR</para>
	/// <para>             ((DistributionPointFunction = IfcElectricDistributionPointFunctionEnum.USERDEFINED) AND EXISTS(SELF\IfcElectricDistributionPoint.UserDefinedFunction));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricDistributionPoint : IfcFlowController
	{
		public IfcElectricDistributionPointFunctionEnum DistributionPointFunction { get; set; }
		public IfcLabel? UserDefinedFunction { get; set; }
		public IfcElectricDistributionPoint() : base()
		{
			DistributionPointFunction = new IfcElectricDistributionPointFunctionEnum();
		}
		public IfcElectricDistributionPoint(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcElectricDistributionPointFunctionEnum DistributionPointFunction, IfcLabel UserDefinedFunction) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.DistributionPointFunction = DistributionPointFunction;
			this.UserDefinedFunction = UserDefinedFunction;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricFlowStorageDeviceType
	/// <para>ENTITY IfcElectricFlowStorageDeviceType</para>
	/// <para> SUBTYPE OF (IfcFlowStorageDeviceType);</para>
	/// <para>	PredefinedType : IfcElectricFlowStorageDeviceTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricFlowStorageDeviceType : IfcFlowStorageDeviceType
	{
		public IfcElectricFlowStorageDeviceTypeEnum PredefinedType { get; set; }
		public IfcElectricFlowStorageDeviceType() : base()
		{
			PredefinedType = new IfcElectricFlowStorageDeviceTypeEnum();
		}
		public IfcElectricFlowStorageDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricFlowStorageDeviceTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricGeneratorType
	/// <para>ENTITY IfcElectricGeneratorType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcElectricGeneratorTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricGeneratorType : IfcEnergyConversionDeviceType
	{
		public IfcElectricGeneratorTypeEnum PredefinedType { get; set; }
		public IfcElectricGeneratorType() : base()
		{
			PredefinedType = new IfcElectricGeneratorTypeEnum();
		}
		public IfcElectricGeneratorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricGeneratorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricHeaterType
	/// <para>ENTITY IfcElectricHeaterType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcElectricHeaterTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricHeaterType : IfcFlowTerminalType
	{
		public IfcElectricHeaterTypeEnum PredefinedType { get; set; }
		public IfcElectricHeaterType() : base()
		{
			PredefinedType = new IfcElectricHeaterTypeEnum();
		}
		public IfcElectricHeaterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricHeaterTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricMotorType
	/// <para>ENTITY IfcElectricMotorType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcElectricMotorTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricMotorType : IfcEnergyConversionDeviceType
	{
		public IfcElectricMotorTypeEnum PredefinedType { get; set; }
		public IfcElectricMotorType() : base()
		{
			PredefinedType = new IfcElectricMotorTypeEnum();
		}
		public IfcElectricMotorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricMotorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricTimeControlType
	/// <para>ENTITY IfcElectricTimeControlType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcElectricTimeControlTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricTimeControlType : IfcFlowControllerType
	{
		public IfcElectricTimeControlTypeEnum PredefinedType { get; set; }
		public IfcElectricTimeControlType() : base()
		{
			PredefinedType = new IfcElectricTimeControlTypeEnum();
		}
		public IfcElectricTimeControlType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcElectricTimeControlTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricalBaseProperties
	/// <para>ENTITY IfcElectricalBaseProperties</para>
	/// <para> SUBTYPE OF (IfcEnergyProperties);</para>
	/// <para>	ElectricCurrentType : OPTIONAL IfcElectricCurrentEnum;</para>
	/// <para>	InputVoltage : IfcElectricVoltageMeasure;</para>
	/// <para>	InputFrequency : IfcFrequencyMeasure;</para>
	/// <para>	FullLoadCurrent : OPTIONAL IfcElectricCurrentMeasure;</para>
	/// <para>	MinimumCircuitCurrent : OPTIONAL IfcElectricCurrentMeasure;</para>
	/// <para>	MaximumPowerInput : OPTIONAL IfcPowerMeasure;</para>
	/// <para>	RatedPowerInput : OPTIONAL IfcPowerMeasure;</para>
	/// <para>	InputPhase : INTEGER;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricalBaseProperties : IfcEnergyProperties
	{
		public IfcElectricCurrentEnum? ElectricCurrentType { get; set; }
		public IfcElectricVoltageMeasure InputVoltage { get; set; }
		public IfcFrequencyMeasure InputFrequency { get; set; }
		public IfcElectricCurrentMeasure? FullLoadCurrent { get; set; }
		public IfcElectricCurrentMeasure? MinimumCircuitCurrent { get; set; }
		public IfcPowerMeasure? MaximumPowerInput { get; set; }
		public IfcPowerMeasure? RatedPowerInput { get; set; }
		public INTEGER InputPhase { get; set; }
		public IfcElectricalBaseProperties() : base()
		{
			InputVoltage = new IfcElectricVoltageMeasure();
			InputFrequency = new IfcFrequencyMeasure();
			InputPhase = new INTEGER();
		}
		public IfcElectricalBaseProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcEnergySequenceEnum EnergySequence, IfcLabel UserDefinedEnergySequence, IfcElectricCurrentEnum ElectricCurrentType, IfcElectricVoltageMeasure InputVoltage, IfcFrequencyMeasure InputFrequency, IfcElectricCurrentMeasure FullLoadCurrent, IfcElectricCurrentMeasure MinimumCircuitCurrent, IfcPowerMeasure MaximumPowerInput, IfcPowerMeasure RatedPowerInput, INTEGER InputPhase) : base (GlobalId, OwnerHistory, Name, Description, EnergySequence, UserDefinedEnergySequence)
		{
			this.ElectricCurrentType = ElectricCurrentType;
			this.InputVoltage = InputVoltage;
			this.InputFrequency = InputFrequency;
			this.FullLoadCurrent = FullLoadCurrent;
			this.MinimumCircuitCurrent = MinimumCircuitCurrent;
			this.MaximumPowerInput = MaximumPowerInput;
			this.RatedPowerInput = RatedPowerInput;
			this.InputPhase = InputPhase;
		}
	}
	/// <summary>
	/// ENTITY IfcElectricalCircuit
	/// <para>ENTITY IfcElectricalCircuit</para>
	/// <para> SUBTYPE OF (IfcSystem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricalCircuit : IfcSystem
	{
		public IfcElectricalCircuit() : base()
		{
		}
		public IfcElectricalCircuit(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcElectricalElement
	/// <para>ENTITY IfcElectricalElement</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElectricalElement : IfcElement
	{
		public IfcElectricalElement() : base()
		{
		}
		public IfcElectricalElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcElement
	/// <para>ENTITY IfcElement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBuildingElement</para>
	/// <para>	,IfcDistributionElement</para>
	/// <para>	,IfcElectricalElement</para>
	/// <para>	,IfcElementAssembly</para>
	/// <para>	,IfcElementComponent</para>
	/// <para>	,IfcEquipmentElement</para>
	/// <para>	,IfcFeatureElement</para>
	/// <para>	,IfcFurnishingElement</para>
	/// <para>	,IfcTransportElement</para>
	/// <para>	,IfcVirtualElement))</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para>	Tag : OPTIONAL IfcIdentifier;</para>
	/// <para> INVERSE</para>
	/// <para>	HasStructuralMember : SET [0:?] OF IfcRelConnectsStructuralElement FOR RelatingElement;</para>
	/// <para>	FillsVoids : SET [0:1] OF IfcRelFillsElement FOR RelatedBuildingElement;</para>
	/// <para>	ConnectedTo : SET [0:?] OF IfcRelConnectsElements FOR RelatingElement;</para>
	/// <para>	HasCoverings : SET [0:?] OF IfcRelCoversBldgElements FOR RelatingBuildingElement;</para>
	/// <para>	HasProjections : SET [0:?] OF IfcRelProjectsElement FOR RelatingElement;</para>
	/// <para>	ReferencedInStructures : SET [0:?] OF IfcRelReferencedInSpatialStructure FOR RelatedElements;</para>
	/// <para>	HasPorts : SET [0:?] OF IfcRelConnectsPortToElement FOR RelatedElement;</para>
	/// <para>	HasOpenings : SET [0:?] OF IfcRelVoidsElement FOR RelatingBuildingElement;</para>
	/// <para>	IsConnectionRealization : SET [0:?] OF IfcRelConnectsWithRealizingElements FOR RealizingElements;</para>
	/// <para>	ProvidesBoundaries : SET [0:?] OF IfcRelSpaceBoundary FOR RelatedBuildingElement;</para>
	/// <para>	ConnectedFrom : SET [0:?] OF IfcRelConnectsElements FOR RelatedElement;</para>
	/// <para>	ContainedInStructure : SET [0:1] OF IfcRelContainedInSpatialStructure FOR RelatedElements;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcElement : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		public IfcIdentifier? Tag { get; set; }
		public IfcElement() : base()
		{
		}
		public IfcElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.Tag = Tag;
		}
	}
	/// <summary>
	/// ENTITY IfcElementAssembly
	/// <para>ENTITY IfcElementAssembly</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>	AssemblyPlace : OPTIONAL IfcAssemblyPlaceEnum;</para>
	/// <para>	PredefinedType : IfcElementAssemblyTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcElementAssemblyTypeEnum.USERDEFINED) OR ((PredefinedType = IfcElementAssemblyTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElementAssembly : IfcElement
	{
		public IfcAssemblyPlaceEnum? AssemblyPlace { get; set; }
		public IfcElementAssemblyTypeEnum PredefinedType { get; set; }
		public IfcElementAssembly() : base()
		{
			PredefinedType = new IfcElementAssemblyTypeEnum();
		}
		public IfcElementAssembly(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcAssemblyPlaceEnum AssemblyPlace, IfcElementAssemblyTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.AssemblyPlace = AssemblyPlace;
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcElementComponent
	/// <para>ENTITY IfcElementComponent</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDiscreteAccessory</para>
	/// <para>	,IfcFastener))</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcElementComponent : IfcElement
	{
		public IfcElementComponent() : base()
		{
		}
		public IfcElementComponent(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcElementComponentType
	/// <para>ENTITY IfcElementComponentType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDiscreteAccessoryType</para>
	/// <para>	,IfcFastenerType))</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcElementComponentType : IfcElementType
	{
		public IfcElementComponentType() : base()
		{
		}
		public IfcElementComponentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcElementQuantity
	/// <para>ENTITY IfcElementQuantity</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	MethodOfMeasurement : OPTIONAL IfcLabel;</para>
	/// <para>	Quantities : SET [1:?] OF IfcPhysicalQuantity;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcElementQuantity : IfcPropertySetDefinition
	{
		public IfcLabel? MethodOfMeasurement { get; set; }
		public List<IfcPhysicalQuantity> Quantities { get; set; }
		public IfcElementQuantity() : base()
		{
			Quantities = new List<IfcPhysicalQuantity>();
		}
		public IfcElementQuantity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel MethodOfMeasurement, List<IfcPhysicalQuantity> Quantities) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.MethodOfMeasurement = MethodOfMeasurement;
			this.Quantities = Quantities;
		}
	}
	/// <summary>
	/// ENTITY IfcElementType
	/// <para>ENTITY IfcElementType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBuildingElementType</para>
	/// <para>	,IfcDistributionElementType</para>
	/// <para>	,IfcElementComponentType</para>
	/// <para>	,IfcFurnishingElementType</para>
	/// <para>	,IfcSpatialStructureElementType</para>
	/// <para>	,IfcTransportElementType))</para>
	/// <para> SUBTYPE OF (IfcTypeProduct);</para>
	/// <para>	ElementType : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcElementType : IfcTypeProduct
	{
		public IfcLabel? ElementType { get; set; }
		public IfcElementType() : base()
		{
		}
		public IfcElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets)
		{
			this.ElementType = ElementType;
		}
	}
	/// <summary>
	/// ENTITY IfcElementarySurface
	/// <para>ENTITY IfcElementarySurface</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPlane))</para>
	/// <para> SUBTYPE OF (IfcSurface);</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := Position.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcElementarySurface : IfcSurface
	{
		public IfcAxis2Placement3D Position { get; set; }
		public IfcElementarySurface() : base()
		{
			Position = new IfcAxis2Placement3D();
		}
		public IfcElementarySurface(IfcAxis2Placement3D Position) : base ()
		{
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcEllipse
	/// <para>ENTITY IfcEllipse</para>
	/// <para> SUBTYPE OF (IfcConic);</para>
	/// <para>	SemiAxis1 : IfcPositiveLengthMeasure;</para>
	/// <para>	SemiAxis2 : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEllipse : IfcConic
	{
		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }
		public IfcEllipse() : base()
		{
			SemiAxis1 = new IfcPositiveLengthMeasure();
			SemiAxis2 = new IfcPositiveLengthMeasure();
		}
		public IfcEllipse(IfcAxis2Placement Position, IfcPositiveLengthMeasure SemiAxis1, IfcPositiveLengthMeasure SemiAxis2) : base (Position)
		{
			this.SemiAxis1 = SemiAxis1;
			this.SemiAxis2 = SemiAxis2;
		}
	}
	/// <summary>
	/// ENTITY IfcEllipseProfileDef
	/// <para>ENTITY IfcEllipseProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	SemiAxis1 : IfcPositiveLengthMeasure;</para>
	/// <para>	SemiAxis2 : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEllipseProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
		public IfcPositiveLengthMeasure SemiAxis2 { get; set; }
		public IfcEllipseProfileDef() : base()
		{
			SemiAxis1 = new IfcPositiveLengthMeasure();
			SemiAxis2 = new IfcPositiveLengthMeasure();
		}
		public IfcEllipseProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure SemiAxis1, IfcPositiveLengthMeasure SemiAxis2) : base (ProfileType, ProfileName, Position)
		{
			this.SemiAxis1 = SemiAxis1;
			this.SemiAxis2 = SemiAxis2;
		}
	}
	/// <summary>
	/// ENTITY IfcEnergyConversionDevice
	/// <para>ENTITY IfcEnergyConversionDevice</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEnergyConversionDevice : IfcDistributionFlowElement
	{
		public IfcEnergyConversionDevice() : base()
		{
		}
		public IfcEnergyConversionDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcEnergyConversionDeviceType
	/// <para>ENTITY IfcEnergyConversionDeviceType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAirToAirHeatRecoveryType</para>
	/// <para>	,IfcBoilerType</para>
	/// <para>	,IfcChillerType</para>
	/// <para>	,IfcCoilType</para>
	/// <para>	,IfcCondenserType</para>
	/// <para>	,IfcCooledBeamType</para>
	/// <para>	,IfcCoolingTowerType</para>
	/// <para>	,IfcElectricGeneratorType</para>
	/// <para>	,IfcElectricMotorType</para>
	/// <para>	,IfcEvaporativeCoolerType</para>
	/// <para>	,IfcEvaporatorType</para>
	/// <para>	,IfcHeatExchangerType</para>
	/// <para>	,IfcHumidifierType</para>
	/// <para>	,IfcMotorConnectionType</para>
	/// <para>	,IfcSpaceHeaterType</para>
	/// <para>	,IfcTransformerType</para>
	/// <para>	,IfcTubeBundleType</para>
	/// <para>	,IfcUnitaryEquipmentType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcEnergyConversionDeviceType : IfcDistributionFlowElementType
	{
		public IfcEnergyConversionDeviceType() : base()
		{
		}
		public IfcEnergyConversionDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcEnergyProperties
	/// <para>ENTITY IfcEnergyProperties</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcElectricalBaseProperties))</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	EnergySequence : OPTIONAL IfcEnergySequenceEnum;</para>
	/// <para>	UserDefinedEnergySequence : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEnergyProperties : IfcPropertySetDefinition
	{
		public IfcEnergySequenceEnum? EnergySequence { get; set; }
		public IfcLabel? UserDefinedEnergySequence { get; set; }
		public IfcEnergyProperties() : base()
		{
		}
		public IfcEnergyProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcEnergySequenceEnum EnergySequence, IfcLabel UserDefinedEnergySequence) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.EnergySequence = EnergySequence;
			this.UserDefinedEnergySequence = UserDefinedEnergySequence;
		}
	}
	/// <summary>
	/// ENTITY IfcEnvironmentalImpactValue
	/// <para>ENTITY IfcEnvironmentalImpactValue</para>
	/// <para> SUBTYPE OF (IfcAppliedValue);</para>
	/// <para>	ImpactType : IfcLabel;</para>
	/// <para>	Category : IfcEnvironmentalImpactCategoryEnum;</para>
	/// <para>	UserDefinedCategory : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (Category <> IfcEnvironmentalImpactCategoryEnum.USERDEFINED) OR</para>
	/// <para>            ((Category = IfcEnvironmentalImpactCategoryEnum.USERDEFINED) AND EXISTS(SELF\IfcEnvironmentalImpactValue.UserDefinedCategory));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEnvironmentalImpactValue : IfcAppliedValue
	{
		public IfcLabel ImpactType { get; set; }
		public IfcEnvironmentalImpactCategoryEnum Category { get; set; }
		public IfcLabel? UserDefinedCategory { get; set; }
		public IfcEnvironmentalImpactValue() : base()
		{
			ImpactType = new IfcLabel();
			Category = new IfcEnvironmentalImpactCategoryEnum();
		}
		public IfcEnvironmentalImpactValue(IfcLabel Name, IfcText Description, IfcAppliedValueSelect AppliedValue, IfcMeasureWithUnit UnitBasis, IfcDateTimeSelect ApplicableDate, IfcDateTimeSelect FixedUntilDate, IfcLabel ImpactType, IfcEnvironmentalImpactCategoryEnum Category, IfcLabel UserDefinedCategory) : base (Name, Description, AppliedValue, UnitBasis, ApplicableDate, FixedUntilDate)
		{
			this.ImpactType = ImpactType;
			this.Category = Category;
			this.UserDefinedCategory = UserDefinedCategory;
		}
	}
	/// <summary>
	/// ENTITY IfcEquipmentElement
	/// <para>ENTITY IfcEquipmentElement</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEquipmentElement : IfcElement
	{
		public IfcEquipmentElement() : base()
		{
		}
		public IfcEquipmentElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcEquipmentStandard
	/// <para>ENTITY IfcEquipmentStandard</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEquipmentStandard : IfcControl
	{
		public IfcEquipmentStandard() : base()
		{
		}
		public IfcEquipmentStandard(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcEvaporativeCoolerType
	/// <para>ENTITY IfcEvaporativeCoolerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcEvaporativeCoolerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcEvaporativeCoolerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcEvaporativeCoolerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEvaporativeCoolerType : IfcEnergyConversionDeviceType
	{
		public IfcEvaporativeCoolerTypeEnum PredefinedType { get; set; }
		public IfcEvaporativeCoolerType() : base()
		{
			PredefinedType = new IfcEvaporativeCoolerTypeEnum();
		}
		public IfcEvaporativeCoolerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcEvaporativeCoolerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcEvaporatorType
	/// <para>ENTITY IfcEvaporatorType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcEvaporatorTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcEvaporatorTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcEvaporatorTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcEvaporatorType : IfcEnergyConversionDeviceType
	{
		public IfcEvaporatorTypeEnum PredefinedType { get; set; }
		public IfcEvaporatorType() : base()
		{
			PredefinedType = new IfcEvaporatorTypeEnum();
		}
		public IfcEvaporatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcEvaporatorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcExtendedMaterialProperties
	/// <para>ENTITY IfcExtendedMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	ExtendedProperties : SET [1:?] OF IfcProperty;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExtendedMaterialProperties : IfcMaterialProperties
	{
		public List<IfcProperty> ExtendedProperties { get; set; }
		public IfcText? Description { get; set; }
		public IfcLabel Name { get; set; }
		public IfcExtendedMaterialProperties() : base()
		{
			ExtendedProperties = new List<IfcProperty>();
			Name = new IfcLabel();
		}
		public IfcExtendedMaterialProperties(IfcMaterial Material, List<IfcProperty> ExtendedProperties, IfcText Description, IfcLabel Name) : base (Material)
		{
			this.ExtendedProperties = ExtendedProperties;
			this.Description = Description;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcExternalReference
	/// <para>ENTITY IfcExternalReference</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcClassificationReference</para>
	/// <para>	,IfcDocumentReference</para>
	/// <para>	,IfcExternallyDefinedHatchStyle</para>
	/// <para>	,IfcExternallyDefinedSurfaceStyle</para>
	/// <para>	,IfcExternallyDefinedSymbol</para>
	/// <para>	,IfcExternallyDefinedTextFont</para>
	/// <para>	,IfcLibraryReference));</para>
	/// <para>	Location : OPTIONAL IfcLabel;</para>
	/// <para>	ItemReference : OPTIONAL IfcIdentifier;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(ItemReference) OR EXISTS(Location) OR EXISTS(Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcExternalReferenceENTITY, IfcLightDistributionDataSourceSelect, IfcObjectReferenceSelect
	{
		public IfcLabel? Location { get; set; }
		public IfcIdentifier? ItemReference { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcExternalReference() : base()
		{
		}
		public IfcExternalReference(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base ()
		{
			this.Location = Location;
			this.ItemReference = ItemReference;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcExternallyDefinedHatchStyle
	/// <para>ENTITY IfcExternallyDefinedHatchStyle</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExternallyDefinedHatchStyle : IfcExternalReference, IfcFillStyleSelect
	{
		public IfcExternallyDefinedHatchStyle() : base()
		{
		}
		public IfcExternallyDefinedHatchStyle(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcExternallyDefinedSurfaceStyle
	/// <para>ENTITY IfcExternallyDefinedSurfaceStyle</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExternallyDefinedSurfaceStyle : IfcExternalReference, IfcSurfaceStyleElementSelect
	{
		public IfcExternallyDefinedSurfaceStyle() : base()
		{
		}
		public IfcExternallyDefinedSurfaceStyle(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcExternallyDefinedSymbol
	/// <para>ENTITY IfcExternallyDefinedSymbol</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExternallyDefinedSymbol : IfcExternalReference, IfcDefinedSymbolSelect
	{
		public IfcExternallyDefinedSymbol() : base()
		{
		}
		public IfcExternallyDefinedSymbol(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcExternallyDefinedTextFont
	/// <para>ENTITY IfcExternallyDefinedTextFont</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExternallyDefinedTextFont : IfcExternalReference, IfcTextFontSelect
	{
		public IfcExternallyDefinedTextFont() : base()
		{
		}
		public IfcExternallyDefinedTextFont(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcExtrudedAreaSolid
	/// <para>ENTITY IfcExtrudedAreaSolid</para>
	/// <para> SUBTYPE OF (IfcSweptAreaSolid);</para>
	/// <para>	ExtrudedDirection : IfcDirection;</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : IfcDotProduct(IfcRepresentationItem() || IfcGeometricRepresentationItem() || IfcDirection([0.0,0.0,1.0]), SELF.ExtrudedDirection) <> 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcExtrudedAreaSolid : IfcSweptAreaSolid
	{
		public IfcDirection ExtrudedDirection { get; set; }
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcExtrudedAreaSolid() : base()
		{
			ExtrudedDirection = new IfcDirection();
			Depth = new IfcPositiveLengthMeasure();
		}
		public IfcExtrudedAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcDirection ExtrudedDirection, IfcPositiveLengthMeasure Depth) : base (SweptArea, Position)
		{
			this.ExtrudedDirection = ExtrudedDirection;
			this.Depth = Depth;
		}
	}
	/// <summary>
	/// ENTITY IfcFace
	/// <para>ENTITY IfcFace</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFaceSurface))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>	Bounds : SET [1:?] OF IfcFaceBound;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(temp <* Bounds | 'IFC2X3.IFCFACEOUTERBOUND' IN TYPEOF(temp))) <= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFace : IfcTopologicalRepresentationItem
	{
		public List<IfcFaceBound> Bounds { get; set; }
		public IfcFace() : base()
		{
			Bounds = new List<IfcFaceBound>();
		}
		public IfcFace(List<IfcFaceBound> Bounds) : base ()
		{
			this.Bounds = Bounds;
		}
	}
	/// <summary>
	/// ENTITY IfcFaceBasedSurfaceModel
	/// <para>ENTITY IfcFaceBasedSurfaceModel</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	FbsmFaces : SET [1:?] OF IfcConnectedFaceSet;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFaceBasedSurfaceModel : IfcGeometricRepresentationItem, IfcSurfaceOrFaceSurface
	{
		public List<IfcConnectedFaceSet> FbsmFaces { get; set; }
		public IfcFaceBasedSurfaceModel() : base()
		{
			FbsmFaces = new List<IfcConnectedFaceSet>();
		}
		public IfcFaceBasedSurfaceModel(List<IfcConnectedFaceSet> FbsmFaces) : base ()
		{
			this.FbsmFaces = FbsmFaces;
		}
	}
	/// <summary>
	/// ENTITY IfcFaceBound
	/// <para>ENTITY IfcFaceBound</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFaceOuterBound))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>	Bound : IfcLoop;</para>
	/// <para>	Orientation : BOOLEAN;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFaceBound : IfcTopologicalRepresentationItem
	{
		public IfcLoop Bound { get; set; }
		public BOOLEAN Orientation { get; set; }
		public IfcFaceBound() : base()
		{
			Bound = new IfcLoop();
			Orientation = new BOOLEAN();
		}
		public IfcFaceBound(IfcLoop Bound, BOOLEAN Orientation) : base ()
		{
			this.Bound = Bound;
			this.Orientation = Orientation;
		}
	}
	/// <summary>
	/// ENTITY IfcFaceOuterBound
	/// <para>ENTITY IfcFaceOuterBound</para>
	/// <para> SUBTYPE OF (IfcFaceBound);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFaceOuterBound : IfcFaceBound
	{
		public IfcFaceOuterBound() : base()
		{
		}
		public IfcFaceOuterBound(IfcLoop Bound, BOOLEAN Orientation) : base (Bound, Orientation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFaceSurface
	/// <para>ENTITY IfcFaceSurface</para>
	/// <para> SUBTYPE OF (IfcFace);</para>
	/// <para>	FaceSurface : IfcSurface;</para>
	/// <para>	SameSense : BOOLEAN;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFaceSurface : IfcFace, IfcSurfaceOrFaceSurface
	{
		public IfcSurface FaceSurface { get; set; }
		public BOOLEAN SameSense { get; set; }
		public IfcFaceSurface() : base()
		{
			FaceSurface = new IfcSurface();
			SameSense = new BOOLEAN();
		}
		public IfcFaceSurface(List<IfcFaceBound> Bounds, IfcSurface FaceSurface, BOOLEAN SameSense) : base (Bounds)
		{
			this.FaceSurface = FaceSurface;
			this.SameSense = SameSense;
		}
	}
	/// <summary>
	/// ENTITY IfcFacetedBrep
	/// <para>ENTITY IfcFacetedBrep</para>
	/// <para> SUBTYPE OF (IfcManifoldSolidBrep);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFacetedBrep : IfcManifoldSolidBrep
	{
		public IfcFacetedBrep() : base()
		{
		}
		public IfcFacetedBrep(IfcClosedShell Outer) : base (Outer)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFacetedBrepWithVoids
	/// <para>ENTITY IfcFacetedBrepWithVoids</para>
	/// <para> SUBTYPE OF (IfcManifoldSolidBrep);</para>
	/// <para>	Voids : SET [1:?] OF IfcClosedShell;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFacetedBrepWithVoids : IfcManifoldSolidBrep
	{
		public List<IfcClosedShell> Voids { get; set; }
		public IfcFacetedBrepWithVoids() : base()
		{
			Voids = new List<IfcClosedShell>();
		}
		public IfcFacetedBrepWithVoids(IfcClosedShell Outer, List<IfcClosedShell> Voids) : base (Outer)
		{
			this.Voids = Voids;
		}
	}
	/// <summary>
	/// ENTITY IfcFailureConnectionCondition
	/// <para>ENTITY IfcFailureConnectionCondition</para>
	/// <para> SUBTYPE OF (IfcStructuralConnectionCondition);</para>
	/// <para>	TensionFailureX : OPTIONAL IfcForceMeasure;</para>
	/// <para>	TensionFailureY : OPTIONAL IfcForceMeasure;</para>
	/// <para>	TensionFailureZ : OPTIONAL IfcForceMeasure;</para>
	/// <para>	CompressionFailureX : OPTIONAL IfcForceMeasure;</para>
	/// <para>	CompressionFailureY : OPTIONAL IfcForceMeasure;</para>
	/// <para>	CompressionFailureZ : OPTIONAL IfcForceMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFailureConnectionCondition : IfcStructuralConnectionCondition
	{
		public IfcForceMeasure? TensionFailureX { get; set; }
		public IfcForceMeasure? TensionFailureY { get; set; }
		public IfcForceMeasure? TensionFailureZ { get; set; }
		public IfcForceMeasure? CompressionFailureX { get; set; }
		public IfcForceMeasure? CompressionFailureY { get; set; }
		public IfcForceMeasure? CompressionFailureZ { get; set; }
		public IfcFailureConnectionCondition() : base()
		{
		}
		public IfcFailureConnectionCondition(IfcLabel Name, IfcForceMeasure TensionFailureX, IfcForceMeasure TensionFailureY, IfcForceMeasure TensionFailureZ, IfcForceMeasure CompressionFailureX, IfcForceMeasure CompressionFailureY, IfcForceMeasure CompressionFailureZ) : base (Name)
		{
			this.TensionFailureX = TensionFailureX;
			this.TensionFailureY = TensionFailureY;
			this.TensionFailureZ = TensionFailureZ;
			this.CompressionFailureX = CompressionFailureX;
			this.CompressionFailureY = CompressionFailureY;
			this.CompressionFailureZ = CompressionFailureZ;
		}
	}
	/// <summary>
	/// ENTITY IfcFanType
	/// <para>ENTITY IfcFanType</para>
	/// <para> SUBTYPE OF (IfcFlowMovingDeviceType);</para>
	/// <para>	PredefinedType : IfcFanTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcFanTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcFanTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFanType : IfcFlowMovingDeviceType
	{
		public IfcFanTypeEnum PredefinedType { get; set; }
		public IfcFanType() : base()
		{
			PredefinedType = new IfcFanTypeEnum();
		}
		public IfcFanType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcFanTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFastener
	/// <para>ENTITY IfcFastener</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMechanicalFastener))</para>
	/// <para> SUBTYPE OF (IfcElementComponent);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFastener : IfcElementComponent
	{
		public IfcFastener() : base()
		{
		}
		public IfcFastener(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFastenerType
	/// <para>ENTITY IfcFastenerType</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMechanicalFastenerType))</para>
	/// <para> SUBTYPE OF (IfcElementComponentType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFastenerType : IfcElementComponentType
	{
		public IfcFastenerType() : base()
		{
		}
		public IfcFastenerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFeatureElement
	/// <para>ENTITY IfcFeatureElement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFeatureElementAddition</para>
	/// <para>	,IfcFeatureElementSubtraction))</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFeatureElement : IfcElement
	{
		public IfcFeatureElement() : base()
		{
		}
		public IfcFeatureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFeatureElementAddition
	/// <para>ENTITY IfcFeatureElementAddition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcProjectionElement))</para>
	/// <para> SUBTYPE OF (IfcFeatureElement);</para>
	/// <para> INVERSE</para>
	/// <para>	ProjectsElements : IfcRelProjectsElement FOR RelatedFeatureElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFeatureElementAddition : IfcFeatureElement
	{
		public IfcFeatureElementAddition() : base()
		{
		}
		public IfcFeatureElementAddition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFeatureElementSubtraction
	/// <para>ENTITY IfcFeatureElementSubtraction</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcEdgeFeature</para>
	/// <para>	,IfcOpeningElement))</para>
	/// <para> SUBTYPE OF (IfcFeatureElement);</para>
	/// <para> INVERSE</para>
	/// <para>	VoidsElements : IfcRelVoidsElement FOR RelatedOpeningElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFeatureElementSubtraction : IfcFeatureElement
	{
		public IfcFeatureElementSubtraction() : base()
		{
		}
		public IfcFeatureElementSubtraction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFillAreaStyle
	/// <para>ENTITY IfcFillAreaStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationStyle);</para>
	/// <para>	FillStyles : SET [1:?] OF IfcFillStyleSelect;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(Style <* SELF.FillStyles |</para>
	/// <para>               'IFC2X3.IFCCOLOUR' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR12 : SIZEOF(QUERY(Style <* SELF.FillStyles |</para>
	/// <para>               'IFC2X3.IFCEXTERNALLYDEFINEDHATCHSTYLE' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR13 : IfcCorrectFillAreaStyle(SELF.FillStyles);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFillAreaStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		public List<IfcFillStyleSelect> FillStyles { get; set; }
		public IfcFillAreaStyle() : base()
		{
			FillStyles = new List<IfcFillStyleSelect>();
		}
		public IfcFillAreaStyle(IfcLabel Name, List<IfcFillStyleSelect> FillStyles) : base (Name)
		{
			this.FillStyles = FillStyles;
		}
	}
	/// <summary>
	/// ENTITY IfcFillAreaStyleHatching
	/// <para>ENTITY IfcFillAreaStyleHatching</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	HatchLineAppearance : IfcCurveStyle;</para>
	/// <para>	StartOfNextHatchLine : IfcHatchLineDistanceSelect;</para>
	/// <para>	PointOfReferenceHatchLine : OPTIONAL IfcCartesianPoint;</para>
	/// <para>	PatternStart : OPTIONAL IfcCartesianPoint;</para>
	/// <para>	HatchLineAngle : IfcPlaneAngleMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(</para>
	/// <para>              'IFC2X3.IFCTWODIRECTIONREPEATFACTOR' </para>
	/// <para>              IN TYPEOF(StartOfNextHatchLine)</para>
	/// <para>             );</para>
	/// <para>	WR22 : NOT(EXISTS(PatternStart)) </para>
	/// <para>             OR (PatternStart.Dim = 2);</para>
	/// <para>	WR23 : NOT(EXISTS(PointOfReferenceHatchLine)) </para>
	/// <para>             OR (PointOfReferenceHatchLine.Dim = 2);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFillAreaStyleHatching : IfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		public IfcCurveStyle HatchLineAppearance { get; set; }
		public IfcHatchLineDistanceSelect StartOfNextHatchLine { get; set; }
		public IfcCartesianPoint? PointOfReferenceHatchLine { get; set; }
		public IfcCartesianPoint? PatternStart { get; set; }
		public IfcPlaneAngleMeasure HatchLineAngle { get; set; }
		public IfcFillAreaStyleHatching() : base()
		{
			HatchLineAppearance = new IfcCurveStyle();
			StartOfNextHatchLine = new IfcHatchLineDistanceSelect();
			HatchLineAngle = new IfcPlaneAngleMeasure();
		}
		public IfcFillAreaStyleHatching(IfcCurveStyle HatchLineAppearance, IfcHatchLineDistanceSelect StartOfNextHatchLine, IfcCartesianPoint PointOfReferenceHatchLine, IfcCartesianPoint PatternStart, IfcPlaneAngleMeasure HatchLineAngle) : base ()
		{
			this.HatchLineAppearance = HatchLineAppearance;
			this.StartOfNextHatchLine = StartOfNextHatchLine;
			this.PointOfReferenceHatchLine = PointOfReferenceHatchLine;
			this.PatternStart = PatternStart;
			this.HatchLineAngle = HatchLineAngle;
		}
	}
	/// <summary>
	/// ENTITY IfcFillAreaStyleTileSymbolWithStyle
	/// <para>ENTITY IfcFillAreaStyleTileSymbolWithStyle</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Symbol : IfcAnnotationSymbolOccurrence;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem, IfcFillAreaStyleTileShapeSelect
	{
		public IfcAnnotationSymbolOccurrence Symbol { get; set; }
		public IfcFillAreaStyleTileSymbolWithStyle() : base()
		{
			Symbol = new IfcAnnotationSymbolOccurrence();
		}
		public IfcFillAreaStyleTileSymbolWithStyle(IfcAnnotationSymbolOccurrence Symbol) : base ()
		{
			this.Symbol = Symbol;
		}
	}
	/// <summary>
	/// ENTITY IfcFillAreaStyleTiles
	/// <para>ENTITY IfcFillAreaStyleTiles</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	TilingPattern : IfcOneDirectionRepeatFactor;</para>
	/// <para>	Tiles : SET [1:?] OF IfcFillAreaStyleTileShapeSelect;</para>
	/// <para>	TilingScale : IfcPositiveRatioMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFillAreaStyleTiles : IfcGeometricRepresentationItem, IfcFillStyleSelect
	{
		public IfcOneDirectionRepeatFactor TilingPattern { get; set; }
		public List<IfcFillAreaStyleTileShapeSelect> Tiles { get; set; }
		public IfcPositiveRatioMeasure TilingScale { get; set; }
		public IfcFillAreaStyleTiles() : base()
		{
			TilingPattern = new IfcOneDirectionRepeatFactor();
			Tiles = new List<IfcFillAreaStyleTileShapeSelect>();
			TilingScale = new IfcPositiveRatioMeasure();
		}
		public IfcFillAreaStyleTiles(IfcOneDirectionRepeatFactor TilingPattern, List<IfcFillAreaStyleTileShapeSelect> Tiles, IfcPositiveRatioMeasure TilingScale) : base ()
		{
			this.TilingPattern = TilingPattern;
			this.Tiles = Tiles;
			this.TilingScale = TilingScale;
		}
	}
	/// <summary>
	/// ENTITY IfcFilterType
	/// <para>ENTITY IfcFilterType</para>
	/// <para> SUBTYPE OF (IfcFlowTreatmentDeviceType);</para>
	/// <para>	PredefinedType : IfcFilterTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcFilterTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcFilterTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFilterType : IfcFlowTreatmentDeviceType
	{
		public IfcFilterTypeEnum PredefinedType { get; set; }
		public IfcFilterType() : base()
		{
			PredefinedType = new IfcFilterTypeEnum();
		}
		public IfcFilterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcFilterTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFireSuppressionTerminalType
	/// <para>ENTITY IfcFireSuppressionTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcFireSuppressionTerminalTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFireSuppressionTerminalType : IfcFlowTerminalType
	{
		public IfcFireSuppressionTerminalTypeEnum PredefinedType { get; set; }
		public IfcFireSuppressionTerminalType() : base()
		{
			PredefinedType = new IfcFireSuppressionTerminalTypeEnum();
		}
		public IfcFireSuppressionTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcFireSuppressionTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFlowController
	/// <para>ENTITY IfcFlowController</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcElectricDistributionPoint))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowController : IfcDistributionFlowElement
	{
		public IfcFlowController() : base()
		{
		}
		public IfcFlowController(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowControllerType
	/// <para>ENTITY IfcFlowControllerType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAirTerminalBoxType</para>
	/// <para>	,IfcDamperType</para>
	/// <para>	,IfcElectricTimeControlType</para>
	/// <para>	,IfcFlowMeterType</para>
	/// <para>	,IfcProtectiveDeviceType</para>
	/// <para>	,IfcSwitchingDeviceType</para>
	/// <para>	,IfcValveType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowControllerType : IfcDistributionFlowElementType
	{
		public IfcFlowControllerType() : base()
		{
		}
		public IfcFlowControllerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowFitting
	/// <para>ENTITY IfcFlowFitting</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowFitting : IfcDistributionFlowElement
	{
		public IfcFlowFitting() : base()
		{
		}
		public IfcFlowFitting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowFittingType
	/// <para>ENTITY IfcFlowFittingType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCableCarrierFittingType</para>
	/// <para>	,IfcDuctFittingType</para>
	/// <para>	,IfcJunctionBoxType</para>
	/// <para>	,IfcPipeFittingType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowFittingType : IfcDistributionFlowElementType
	{
		public IfcFlowFittingType() : base()
		{
		}
		public IfcFlowFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowInstrumentType
	/// <para>ENTITY IfcFlowInstrumentType</para>
	/// <para> SUBTYPE OF (IfcDistributionControlElementType);</para>
	/// <para>	PredefinedType : IfcFlowInstrumentTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowInstrumentType : IfcDistributionControlElementType
	{
		public IfcFlowInstrumentTypeEnum PredefinedType { get; set; }
		public IfcFlowInstrumentType() : base()
		{
			PredefinedType = new IfcFlowInstrumentTypeEnum();
		}
		public IfcFlowInstrumentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcFlowInstrumentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFlowMeterType
	/// <para>ENTITY IfcFlowMeterType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcFlowMeterTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcFlowMeterTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcFlowMeterTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowMeterType : IfcFlowControllerType
	{
		public IfcFlowMeterTypeEnum PredefinedType { get; set; }
		public IfcFlowMeterType() : base()
		{
			PredefinedType = new IfcFlowMeterTypeEnum();
		}
		public IfcFlowMeterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcFlowMeterTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFlowMovingDevice
	/// <para>ENTITY IfcFlowMovingDevice</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowMovingDevice : IfcDistributionFlowElement
	{
		public IfcFlowMovingDevice() : base()
		{
		}
		public IfcFlowMovingDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowMovingDeviceType
	/// <para>ENTITY IfcFlowMovingDeviceType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCompressorType</para>
	/// <para>	,IfcFanType</para>
	/// <para>	,IfcPumpType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowMovingDeviceType : IfcDistributionFlowElementType
	{
		public IfcFlowMovingDeviceType() : base()
		{
		}
		public IfcFlowMovingDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowSegment
	/// <para>ENTITY IfcFlowSegment</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowSegment : IfcDistributionFlowElement
	{
		public IfcFlowSegment() : base()
		{
		}
		public IfcFlowSegment(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowSegmentType
	/// <para>ENTITY IfcFlowSegmentType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCableCarrierSegmentType</para>
	/// <para>	,IfcCableSegmentType</para>
	/// <para>	,IfcDuctSegmentType</para>
	/// <para>	,IfcPipeSegmentType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowSegmentType : IfcDistributionFlowElementType
	{
		public IfcFlowSegmentType() : base()
		{
		}
		public IfcFlowSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowStorageDevice
	/// <para>ENTITY IfcFlowStorageDevice</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowStorageDevice : IfcDistributionFlowElement
	{
		public IfcFlowStorageDevice() : base()
		{
		}
		public IfcFlowStorageDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowStorageDeviceType
	/// <para>ENTITY IfcFlowStorageDeviceType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcElectricFlowStorageDeviceType</para>
	/// <para>	,IfcTankType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowStorageDeviceType : IfcDistributionFlowElementType
	{
		public IfcFlowStorageDeviceType() : base()
		{
		}
		public IfcFlowStorageDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowTerminal
	/// <para>ENTITY IfcFlowTerminal</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowTerminal : IfcDistributionFlowElement
	{
		public IfcFlowTerminal() : base()
		{
		}
		public IfcFlowTerminal(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowTerminalType
	/// <para>ENTITY IfcFlowTerminalType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAirTerminalType</para>
	/// <para>	,IfcElectricApplianceType</para>
	/// <para>	,IfcElectricHeaterType</para>
	/// <para>	,IfcFireSuppressionTerminalType</para>
	/// <para>	,IfcGasTerminalType</para>
	/// <para>	,IfcLampType</para>
	/// <para>	,IfcLightFixtureType</para>
	/// <para>	,IfcOutletType</para>
	/// <para>	,IfcSanitaryTerminalType</para>
	/// <para>	,IfcStackTerminalType</para>
	/// <para>	,IfcWasteTerminalType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowTerminalType : IfcDistributionFlowElementType
	{
		public IfcFlowTerminalType() : base()
		{
		}
		public IfcFlowTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowTreatmentDevice
	/// <para>ENTITY IfcFlowTreatmentDevice</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFlowTreatmentDevice : IfcDistributionFlowElement
	{
		public IfcFlowTreatmentDevice() : base()
		{
		}
		public IfcFlowTreatmentDevice(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFlowTreatmentDeviceType
	/// <para>ENTITY IfcFlowTreatmentDeviceType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDuctSilencerType</para>
	/// <para>	,IfcFilterType))</para>
	/// <para> SUBTYPE OF (IfcDistributionFlowElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcFlowTreatmentDeviceType : IfcDistributionFlowElementType
	{
		public IfcFlowTreatmentDeviceType() : base()
		{
		}
		public IfcFlowTreatmentDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFluidFlowProperties
	/// <para>ENTITY IfcFluidFlowProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	PropertySource : IfcPropertySourceEnum;</para>
	/// <para>	FlowConditionTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	VelocityTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	FlowrateTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	Fluid : IfcMaterial;</para>
	/// <para>	PressureTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	UserDefinedPropertySource : OPTIONAL IfcLabel;</para>
	/// <para>	TemperatureSingleValue : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	WetBulbTemperatureSingleValue : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	WetBulbTemperatureTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	TemperatureTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	FlowrateSingleValue : OPTIONAL IfcDerivedMeasureValue;</para>
	/// <para>	FlowConditionSingleValue : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	VelocitySingleValue : OPTIONAL IfcLinearVelocityMeasure;</para>
	/// <para>	PressureSingleValue : OPTIONAL IfcPressureMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFluidFlowProperties : IfcPropertySetDefinition
	{
		public IfcPropertySourceEnum PropertySource { get; set; }
		public IfcTimeSeries? FlowConditionTimeSeries { get; set; }
		public IfcTimeSeries? VelocityTimeSeries { get; set; }
		public IfcTimeSeries? FlowrateTimeSeries { get; set; }
		public IfcMaterial Fluid { get; set; }
		public IfcTimeSeries? PressureTimeSeries { get; set; }
		public IfcLabel? UserDefinedPropertySource { get; set; }
		public IfcThermodynamicTemperatureMeasure? TemperatureSingleValue { get; set; }
		public IfcThermodynamicTemperatureMeasure? WetBulbTemperatureSingleValue { get; set; }
		public IfcTimeSeries? WetBulbTemperatureTimeSeries { get; set; }
		public IfcTimeSeries? TemperatureTimeSeries { get; set; }
		public IfcDerivedMeasureValue? FlowrateSingleValue { get; set; }
		public IfcPositiveRatioMeasure? FlowConditionSingleValue { get; set; }
		public IfcLinearVelocityMeasure? VelocitySingleValue { get; set; }
		public IfcPressureMeasure? PressureSingleValue { get; set; }
		public IfcFluidFlowProperties() : base()
		{
			PropertySource = new IfcPropertySourceEnum();
			Fluid = new IfcMaterial();
		}
		public IfcFluidFlowProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPropertySourceEnum PropertySource, IfcTimeSeries FlowConditionTimeSeries, IfcTimeSeries VelocityTimeSeries, IfcTimeSeries FlowrateTimeSeries, IfcMaterial Fluid, IfcTimeSeries PressureTimeSeries, IfcLabel UserDefinedPropertySource, IfcThermodynamicTemperatureMeasure TemperatureSingleValue, IfcThermodynamicTemperatureMeasure WetBulbTemperatureSingleValue, IfcTimeSeries WetBulbTemperatureTimeSeries, IfcTimeSeries TemperatureTimeSeries, IfcDerivedMeasureValue FlowrateSingleValue, IfcPositiveRatioMeasure FlowConditionSingleValue, IfcLinearVelocityMeasure VelocitySingleValue, IfcPressureMeasure PressureSingleValue) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.PropertySource = PropertySource;
			this.FlowConditionTimeSeries = FlowConditionTimeSeries;
			this.VelocityTimeSeries = VelocityTimeSeries;
			this.FlowrateTimeSeries = FlowrateTimeSeries;
			this.Fluid = Fluid;
			this.PressureTimeSeries = PressureTimeSeries;
			this.UserDefinedPropertySource = UserDefinedPropertySource;
			this.TemperatureSingleValue = TemperatureSingleValue;
			this.WetBulbTemperatureSingleValue = WetBulbTemperatureSingleValue;
			this.WetBulbTemperatureTimeSeries = WetBulbTemperatureTimeSeries;
			this.TemperatureTimeSeries = TemperatureTimeSeries;
			this.FlowrateSingleValue = FlowrateSingleValue;
			this.FlowConditionSingleValue = FlowConditionSingleValue;
			this.VelocitySingleValue = VelocitySingleValue;
			this.PressureSingleValue = PressureSingleValue;
		}
	}
	/// <summary>
	/// ENTITY IfcFooting
	/// <para>ENTITY IfcFooting</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	PredefinedType : IfcFootingTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcFootingTypeEnum.USERDEFINED) OR ((PredefinedType = IfcFootingTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFooting : IfcBuildingElement
	{
		public IfcFootingTypeEnum PredefinedType { get; set; }
		public IfcFooting() : base()
		{
			PredefinedType = new IfcFootingTypeEnum();
		}
		public IfcFooting(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcFootingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcFuelProperties
	/// <para>ENTITY IfcFuelProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	CombustionTemperature : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	CarbonContent : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	LowerHeatingValue : OPTIONAL IfcHeatingValueMeasure;</para>
	/// <para>	HigherHeatingValue : OPTIONAL IfcHeatingValueMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFuelProperties : IfcMaterialProperties
	{
		public IfcThermodynamicTemperatureMeasure? CombustionTemperature { get; set; }
		public IfcPositiveRatioMeasure? CarbonContent { get; set; }
		public IfcHeatingValueMeasure? LowerHeatingValue { get; set; }
		public IfcHeatingValueMeasure? HigherHeatingValue { get; set; }
		public IfcFuelProperties() : base()
		{
		}
		public IfcFuelProperties(IfcMaterial Material, IfcThermodynamicTemperatureMeasure CombustionTemperature, IfcPositiveRatioMeasure CarbonContent, IfcHeatingValueMeasure LowerHeatingValue, IfcHeatingValueMeasure HigherHeatingValue) : base (Material)
		{
			this.CombustionTemperature = CombustionTemperature;
			this.CarbonContent = CarbonContent;
			this.LowerHeatingValue = LowerHeatingValue;
			this.HigherHeatingValue = HigherHeatingValue;
		}
	}
	/// <summary>
	/// ENTITY IfcFurnishingElement
	/// <para>ENTITY IfcFurnishingElement</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFurnishingElement : IfcElement
	{
		public IfcFurnishingElement() : base()
		{
		}
		public IfcFurnishingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFurnishingElementType
	/// <para>ENTITY IfcFurnishingElementType</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFurnitureType</para>
	/// <para>	,IfcSystemFurnitureElementType))</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFurnishingElementType : IfcElementType
	{
		public IfcFurnishingElementType() : base()
		{
		}
		public IfcFurnishingElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFurnitureStandard
	/// <para>ENTITY IfcFurnitureStandard</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFurnitureStandard : IfcControl
	{
		public IfcFurnitureStandard() : base()
		{
		}
		public IfcFurnitureStandard(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcFurnitureType
	/// <para>ENTITY IfcFurnitureType</para>
	/// <para> SUBTYPE OF (IfcFurnishingElementType);</para>
	/// <para>	AssemblyPlace : IfcAssemblyPlaceEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcFurnitureType : IfcFurnishingElementType
	{
		public IfcAssemblyPlaceEnum AssemblyPlace { get; set; }
		public IfcFurnitureType() : base()
		{
			AssemblyPlace = new IfcAssemblyPlaceEnum();
		}
		public IfcFurnitureType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcAssemblyPlaceEnum AssemblyPlace) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.AssemblyPlace = AssemblyPlace;
		}
	}
	/// <summary>
	/// ENTITY IfcGasTerminalType
	/// <para>ENTITY IfcGasTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcGasTerminalTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcGasTerminalTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcGasTerminalTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGasTerminalType : IfcFlowTerminalType
	{
		public IfcGasTerminalTypeEnum PredefinedType { get; set; }
		public IfcGasTerminalType() : base()
		{
			PredefinedType = new IfcGasTerminalTypeEnum();
		}
		public IfcGasTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcGasTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcGeneralMaterialProperties
	/// <para>ENTITY IfcGeneralMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	MolecularWeight : OPTIONAL IfcMolecularWeightMeasure;</para>
	/// <para>	Porosity : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	MassDensity : OPTIONAL IfcMassDensityMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeneralMaterialProperties : IfcMaterialProperties
	{
		public IfcMolecularWeightMeasure? MolecularWeight { get; set; }
		public IfcNormalisedRatioMeasure? Porosity { get; set; }
		public IfcMassDensityMeasure? MassDensity { get; set; }
		public IfcGeneralMaterialProperties() : base()
		{
		}
		public IfcGeneralMaterialProperties(IfcMaterial Material, IfcMolecularWeightMeasure MolecularWeight, IfcNormalisedRatioMeasure Porosity, IfcMassDensityMeasure MassDensity) : base (Material)
		{
			this.MolecularWeight = MolecularWeight;
			this.Porosity = Porosity;
			this.MassDensity = MassDensity;
		}
	}
	/// <summary>
	/// ENTITY IfcGeneralProfileProperties
	/// <para>ENTITY IfcGeneralProfileProperties</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralProfileProperties))</para>
	/// <para> SUBTYPE OF (IfcProfileProperties);</para>
	/// <para>	PhysicalWeight : OPTIONAL IfcMassPerLengthMeasure;</para>
	/// <para>	Perimeter : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	MinimumPlateThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	MaximumPlateThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	CrossSectionArea : OPTIONAL IfcAreaMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : NOT(EXISTS(CrossSectionArea)) OR (CrossSectionArea > 0.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeneralProfileProperties : IfcProfileProperties
	{
		public IfcMassPerLengthMeasure? PhysicalWeight { get; set; }
		public IfcPositiveLengthMeasure? Perimeter { get; set; }
		public IfcPositiveLengthMeasure? MinimumPlateThickness { get; set; }
		public IfcPositiveLengthMeasure? MaximumPlateThickness { get; set; }
		public IfcAreaMeasure? CrossSectionArea { get; set; }
		public IfcGeneralProfileProperties() : base()
		{
		}
		public IfcGeneralProfileProperties(IfcLabel ProfileName, IfcProfileDef ProfileDefinition, IfcMassPerLengthMeasure PhysicalWeight, IfcPositiveLengthMeasure Perimeter, IfcPositiveLengthMeasure MinimumPlateThickness, IfcPositiveLengthMeasure MaximumPlateThickness, IfcAreaMeasure CrossSectionArea) : base (ProfileName, ProfileDefinition)
		{
			this.PhysicalWeight = PhysicalWeight;
			this.Perimeter = Perimeter;
			this.MinimumPlateThickness = MinimumPlateThickness;
			this.MaximumPlateThickness = MaximumPlateThickness;
			this.CrossSectionArea = CrossSectionArea;
		}
	}
	/// <summary>
	/// ENTITY IfcGeometricCurveSet
	/// <para>ENTITY IfcGeometricCurveSet</para>
	/// <para> SUBTYPE OF (IfcGeometricSet);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcGeometricSet.Elements |</para>
	/// <para>            'IFC2X3.IFCSURFACE' IN TYPEOF(Temp))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeometricCurveSet : IfcGeometricSet
	{
		public IfcGeometricCurveSet() : base()
		{
		}
		public IfcGeometricCurveSet(List<IfcGeometricSetSelect> Elements) : base (Elements)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcGeometricRepresentationContext
	/// <para>ENTITY IfcGeometricRepresentationContext</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGeometricRepresentationSubContext))</para>
	/// <para> SUBTYPE OF (IfcRepresentationContext);</para>
	/// <para>	CoordinateSpaceDimension : IfcDimensionCount;</para>
	/// <para>	Precision : OPTIONAL REAL;</para>
	/// <para>	WorldCoordinateSystem : IfcAxis2Placement;</para>
	/// <para>	TrueNorth : OPTIONAL IfcDirection;</para>
	/// <para> INVERSE</para>
	/// <para>	HasSubContexts : SET [0:?] OF IfcGeometricRepresentationSubContext FOR ParentContext;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeometricRepresentationContext : IfcRepresentationContext
	{
		public IfcDimensionCount CoordinateSpaceDimension { get; set; }
		public REAL? Precision { get; set; }
		public IfcAxis2Placement WorldCoordinateSystem { get; set; }
		public IfcDirection? TrueNorth { get; set; }
		public IfcGeometricRepresentationContext() : base()
		{
			CoordinateSpaceDimension = new IfcDimensionCount();
			WorldCoordinateSystem = new IfcAxis2Placement();
		}
		public IfcGeometricRepresentationContext(IfcLabel ContextIdentifier, IfcLabel ContextType, IfcDimensionCount CoordinateSpaceDimension, REAL Precision, IfcAxis2Placement WorldCoordinateSystem, IfcDirection TrueNorth) : base (ContextIdentifier, ContextType)
		{
			this.CoordinateSpaceDimension = CoordinateSpaceDimension;
			this.Precision = Precision;
			this.WorldCoordinateSystem = WorldCoordinateSystem;
			this.TrueNorth = TrueNorth;
		}
	}
	/// <summary>
	/// ENTITY IfcGeometricRepresentationItem
	/// <para>ENTITY IfcGeometricRepresentationItem</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAnnotationFillArea</para>
	/// <para>	,IfcAnnotationSurface</para>
	/// <para>	,IfcBooleanResult</para>
	/// <para>	,IfcBoundingBox</para>
	/// <para>	,IfcCartesianTransformationOperator</para>
	/// <para>	,IfcCompositeCurveSegment</para>
	/// <para>	,IfcCsgPrimitive3D</para>
	/// <para>	,IfcCurve</para>
	/// <para>	,IfcDefinedSymbol</para>
	/// <para>	,IfcDirection</para>
	/// <para>	,IfcDraughtingCallout</para>
	/// <para>	,IfcFaceBasedSurfaceModel</para>
	/// <para>	,IfcFillAreaStyleHatching</para>
	/// <para>	,IfcFillAreaStyleTileSymbolWithStyle</para>
	/// <para>	,IfcFillAreaStyleTiles</para>
	/// <para>	,IfcGeometricSet</para>
	/// <para>	,IfcHalfSpaceSolid</para>
	/// <para>	,IfcLightSource</para>
	/// <para>	,IfcOneDirectionRepeatFactor</para>
	/// <para>	,IfcPlacement</para>
	/// <para>	,IfcPlanarExtent</para>
	/// <para>	,IfcPoint</para>
	/// <para>	,IfcSectionedSpine</para>
	/// <para>	,IfcShellBasedSurfaceModel</para>
	/// <para>	,IfcSolidModel</para>
	/// <para>	,IfcSurface</para>
	/// <para>	,IfcTextLiteral</para>
	/// <para>	,IfcVector))</para>
	/// <para> SUBTYPE OF (IfcRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcGeometricRepresentationItem : IfcRepresentationItem
	{
		public IfcGeometricRepresentationItem() : base()
		{
		}
		public IfcGeometricRepresentationItem() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcGeometricRepresentationSubContext
	/// <para>ENTITY IfcGeometricRepresentationSubContext</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationContext);</para>
	/// <para>	ParentContext : IfcGeometricRepresentationContext;</para>
	/// <para>	TargetScale : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	TargetView : IfcGeometricProjectionEnum;</para>
	/// <para>	UserDefinedTargetView : OPTIONAL IfcLabel;</para>
	/// <para> DERIVE</para>
	/// <para>	SELF\IfcGeometricRepresentationContext.WorldCoordinateSystem : IfcAxis2Placement := ParentContext.WorldCoordinateSystem;</para>
	/// <para>	SELF\IfcGeometricRepresentationContext.CoordinateSpaceDimension : IfcDimensionCount := ParentContext.CoordinateSpaceDimension;</para>
	/// <para>	SELF\IfcGeometricRepresentationContext.TrueNorth : IfcDirection := NVL(ParentContext.TrueNorth,SELF.WorldCoordinateSystem.P[2]);</para>
	/// <para>	SELF\IfcGeometricRepresentationContext.Precision : REAL := NVL(ParentContext.Precision,1.E-5);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT('IFC2X3.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(ParentContext));</para>
	/// <para>	WR32 : (TargetView <> IfcGeometricProjectionEnum.USERDEFINED) OR </para>
	/// <para>             ((TargetView =  IfcGeometricProjectionEnum.USERDEFINED) AND </para>
	/// <para>              EXISTS(UserDefinedTargetView));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext
	{
		public IfcGeometricRepresentationContext ParentContext { get; set; }
		public IfcPositiveRatioMeasure? TargetScale { get; set; }
		public IfcGeometricProjectionEnum TargetView { get; set; }
		public IfcLabel? UserDefinedTargetView { get; set; }
		public IfcGeometricRepresentationSubContext() : base()
		{
			ParentContext = new IfcGeometricRepresentationContext();
			TargetView = new IfcGeometricProjectionEnum();
		}
		public IfcGeometricRepresentationSubContext(IfcLabel ContextIdentifier, IfcLabel ContextType, IfcDimensionCount CoordinateSpaceDimension, REAL Precision, IfcAxis2Placement WorldCoordinateSystem, IfcDirection TrueNorth, IfcGeometricRepresentationContext ParentContext, IfcPositiveRatioMeasure TargetScale, IfcGeometricProjectionEnum TargetView, IfcLabel UserDefinedTargetView) : base (ContextIdentifier, ContextType, CoordinateSpaceDimension, Precision, WorldCoordinateSystem, TrueNorth)
		{
			this.ParentContext = ParentContext;
			this.TargetScale = TargetScale;
			this.TargetView = TargetView;
			this.UserDefinedTargetView = UserDefinedTargetView;
		}
	}
	/// <summary>
	/// ENTITY IfcGeometricSet
	/// <para>ENTITY IfcGeometricSet</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGeometricCurveSet))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Elements : SET [1:?] OF IfcGeometricSetSelect;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := Elements[1].Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(Temp <* Elements |</para>
	/// <para>               Temp.Dim <> Elements[1].Dim))</para>
	/// <para>             = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGeometricSet : IfcGeometricRepresentationItem
	{
		public List<IfcGeometricSetSelect> Elements { get; set; }
		public IfcGeometricSet() : base()
		{
			Elements = new List<IfcGeometricSetSelect>();
		}
		public IfcGeometricSet(List<IfcGeometricSetSelect> Elements) : base ()
		{
			this.Elements = Elements;
		}
	}
	/// <summary>
	/// ENTITY IfcGrid
	/// <para>ENTITY IfcGrid</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para>	UAxes : LIST [1:?] OF UNIQUE IfcGridAxis;</para>
	/// <para>	VAxes : LIST [1:?] OF UNIQUE IfcGridAxis;</para>
	/// <para>	WAxes : OPTIONAL LIST [1:?] OF UNIQUE IfcGridAxis;</para>
	/// <para> INVERSE</para>
	/// <para>	ContainedInStructure : SET [0:1] OF IfcRelContainedInSpatialStructure FOR RelatedElements;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : EXISTS(SELF\IfcProduct.ObjectPlacement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGrid : IfcProduct
	{
		public IfcGrid() : base()
		{
		}
		public IfcGrid(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcGridAxis;
	/// <para>ENTITY IfcGridAxis;</para>
	/// <para>	AxisTag : OPTIONAL IfcLabel;</para>
	/// <para>	AxisCurve : IfcCurve;</para>
	/// <para>	SameSense : IfcBoolean;</para>
	/// <para> INVERSE</para>
	/// <para>	PartOfW : SET [0:1] OF IfcGrid FOR WAxes;</para>
	/// <para>	PartOfV : SET [0:1] OF IfcGrid FOR VAxes;</para>
	/// <para>	PartOfU : SET [0:1] OF IfcGrid FOR UAxes;</para>
	/// <para>	HasIntersections : SET [0:?] OF IfcVirtualGridIntersection FOR IntersectingAxes;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : AxisCurve.Dim = 2;</para>
	/// <para>	WR2 : (SIZEOF(PartOfU) = 1) XOR (SIZEOF(PartOfV) = 1) XOR (SIZEOF(PartOfW) = 1);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGridAxisENTITY
	{
		public IfcLabel? AxisTag { get; set; }
		public IfcCurve AxisCurve { get; set; }
		public IfcBoolean SameSense { get; set; }
		public IfcGridAxis() : base()
		{
			AxisCurve = new IfcCurve();
			SameSense = new IfcBoolean();
		}
		public IfcGridAxis(IfcLabel AxisTag, IfcCurve AxisCurve, IfcBoolean SameSense) : base ()
		{
			this.AxisTag = AxisTag;
			this.AxisCurve = AxisCurve;
			this.SameSense = SameSense;
		}
	}
	/// <summary>
	/// ENTITY IfcGridPlacement
	/// <para>ENTITY IfcGridPlacement</para>
	/// <para> SUBTYPE OF (IfcObjectPlacement);</para>
	/// <para>	PlacementLocation : IfcVirtualGridIntersection;</para>
	/// <para>	PlacementRefDirection : OPTIONAL IfcVirtualGridIntersection;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGridPlacement : IfcObjectPlacement
	{
		public IfcVirtualGridIntersection PlacementLocation { get; set; }
		public IfcVirtualGridIntersection? PlacementRefDirection { get; set; }
		public IfcGridPlacement() : base()
		{
			PlacementLocation = new IfcVirtualGridIntersection();
		}
		public IfcGridPlacement(IfcVirtualGridIntersection PlacementLocation, IfcVirtualGridIntersection PlacementRefDirection) : base ()
		{
			this.PlacementLocation = PlacementLocation;
			this.PlacementRefDirection = PlacementRefDirection;
		}
	}
	/// <summary>
	/// ENTITY IfcGroup
	/// <para>ENTITY IfcGroup</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAsset</para>
	/// <para>	,IfcCondition</para>
	/// <para>	,IfcInventory</para>
	/// <para>	,IfcStructuralLoadGroup</para>
	/// <para>	,IfcStructuralResultGroup</para>
	/// <para>	,IfcSystem</para>
	/// <para>	,IfcZone))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para> INVERSE</para>
	/// <para>	IsGroupedBy : IfcRelAssignsToGroup FOR RelatingGroup;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcGroup : IfcObject
	{
		public IfcGroup() : base()
		{
		}
		public IfcGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcHalfSpaceSolid
	/// <para>ENTITY IfcHalfSpaceSolid</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBoxedHalfSpace</para>
	/// <para>	,IfcPolygonalBoundedHalfSpace))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	BaseSurface : IfcSurface;</para>
	/// <para>	AgreementFlag : BOOLEAN;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IfcBooleanOperand
	{
		public IfcSurface BaseSurface { get; set; }
		public BOOLEAN AgreementFlag { get; set; }
		public IfcHalfSpaceSolid() : base()
		{
			BaseSurface = new IfcSurface();
			AgreementFlag = new BOOLEAN();
		}
		public IfcHalfSpaceSolid(IfcSurface BaseSurface, BOOLEAN AgreementFlag) : base ()
		{
			this.BaseSurface = BaseSurface;
			this.AgreementFlag = AgreementFlag;
		}
	}
	/// <summary>
	/// ENTITY IfcHeatExchangerType
	/// <para>ENTITY IfcHeatExchangerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcHeatExchangerTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcHeatExchangerTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcHeatExchangerTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcHeatExchangerType : IfcEnergyConversionDeviceType
	{
		public IfcHeatExchangerTypeEnum PredefinedType { get; set; }
		public IfcHeatExchangerType() : base()
		{
			PredefinedType = new IfcHeatExchangerTypeEnum();
		}
		public IfcHeatExchangerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcHeatExchangerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcHumidifierType
	/// <para>ENTITY IfcHumidifierType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcHumidifierTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcHumidifierTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcHumidifierTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcHumidifierType : IfcEnergyConversionDeviceType
	{
		public IfcHumidifierTypeEnum PredefinedType { get; set; }
		public IfcHumidifierType() : base()
		{
			PredefinedType = new IfcHumidifierTypeEnum();
		}
		public IfcHumidifierType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcHumidifierTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcHygroscopicMaterialProperties
	/// <para>ENTITY IfcHygroscopicMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	UpperVaporResistanceFactor : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	LowerVaporResistanceFactor : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	IsothermalMoistureCapacity : OPTIONAL IfcIsothermalMoistureCapacityMeasure;</para>
	/// <para>	VaporPermeability : OPTIONAL IfcVaporPermeabilityMeasure;</para>
	/// <para>	MoistureDiffusivity : OPTIONAL IfcMoistureDiffusivityMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcHygroscopicMaterialProperties : IfcMaterialProperties
	{
		public IfcPositiveRatioMeasure? UpperVaporResistanceFactor { get; set; }
		public IfcPositiveRatioMeasure? LowerVaporResistanceFactor { get; set; }
		public IfcIsothermalMoistureCapacityMeasure? IsothermalMoistureCapacity { get; set; }
		public IfcVaporPermeabilityMeasure? VaporPermeability { get; set; }
		public IfcMoistureDiffusivityMeasure? MoistureDiffusivity { get; set; }
		public IfcHygroscopicMaterialProperties() : base()
		{
		}
		public IfcHygroscopicMaterialProperties(IfcMaterial Material, IfcPositiveRatioMeasure UpperVaporResistanceFactor, IfcPositiveRatioMeasure LowerVaporResistanceFactor, IfcIsothermalMoistureCapacityMeasure IsothermalMoistureCapacity, IfcVaporPermeabilityMeasure VaporPermeability, IfcMoistureDiffusivityMeasure MoistureDiffusivity) : base (Material)
		{
			this.UpperVaporResistanceFactor = UpperVaporResistanceFactor;
			this.LowerVaporResistanceFactor = LowerVaporResistanceFactor;
			this.IsothermalMoistureCapacity = IsothermalMoistureCapacity;
			this.VaporPermeability = VaporPermeability;
			this.MoistureDiffusivity = MoistureDiffusivity;
		}
	}
	/// <summary>
	/// ENTITY IfcIShapeProfileDef
	/// <para>ENTITY IfcIShapeProfileDef</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAsymmetricIShapeProfileDef))</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	OverallWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	OverallDepth : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : FlangeThickness < (OverallDepth / 2.);</para>
	/// <para>	WR2 : WebThickness < OverallWidth;</para>
	/// <para>	WR3 : NOT(EXISTS(FilletRadius)) OR</para>
	/// <para>            ((FilletRadius <= (OverallWidth - WebThickness)/2.) AND </para>
	/// <para>             (FilletRadius <= (OverallDepth - (2. * FlangeThickness))/2.));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcIShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure OverallWidth { get; set; }
		public IfcPositiveLengthMeasure OverallDepth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcPositiveLengthMeasure? FilletRadius { get; set; }
		public IfcIShapeProfileDef() : base()
		{
			OverallWidth = new IfcPositiveLengthMeasure();
			OverallDepth = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			FlangeThickness = new IfcPositiveLengthMeasure();
		}
		public IfcIShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure OverallWidth, IfcPositiveLengthMeasure OverallDepth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcPositiveLengthMeasure FilletRadius) : base (ProfileType, ProfileName, Position)
		{
			this.OverallWidth = OverallWidth;
			this.OverallDepth = OverallDepth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcImageTexture
	/// <para>ENTITY IfcImageTexture</para>
	/// <para> SUBTYPE OF (IfcSurfaceTexture);</para>
	/// <para>	UrlReference : IfcIdentifier;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcImageTexture : IfcSurfaceTexture
	{
		public IfcIdentifier UrlReference { get; set; }
		public IfcImageTexture() : base()
		{
			UrlReference = new IfcIdentifier();
		}
		public IfcImageTexture(BOOLEAN RepeatS, BOOLEAN RepeatT, IfcSurfaceTextureEnum TextureType, IfcCartesianTransformationOperator2D TextureTransform, IfcIdentifier UrlReference) : base (RepeatS, RepeatT, TextureType, TextureTransform)
		{
			this.UrlReference = UrlReference;
		}
	}
	/// <summary>
	/// ENTITY IfcInventory
	/// <para>ENTITY IfcInventory</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para>	InventoryType : IfcInventoryTypeEnum;</para>
	/// <para>	Jurisdiction : IfcActorSelect;</para>
	/// <para>	ResponsiblePersons : SET [1:?] OF IfcPerson;</para>
	/// <para>	LastUpdateDate : IfcCalendarDate;</para>
	/// <para>	CurrentValue : OPTIONAL IfcCostValue;</para>
	/// <para>	OriginalValue : OPTIONAL IfcCostValue;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : SIZEOF(QUERY(temp <* SELF\IfcGroup.IsGroupedBy.RelatedObjects |</para>
	/// <para>                 NOT( ('IFC2X3.IFCSPACE' IN TYPEOF (temp)) OR </para>
	/// <para>                      ('IFC2X3.IFCASSET' IN TYPEOF (temp)) OR</para>
	/// <para>                      ('IFC2X3.IFCFURNISHINGELEMENT' IN TYPEOF (temp))</para>
	/// <para>                 ))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcInventory : IfcGroup
	{
		public IfcInventoryTypeEnum InventoryType { get; set; }
		public IfcActorSelect Jurisdiction { get; set; }
		public List<IfcPerson> ResponsiblePersons { get; set; }
		public IfcCalendarDate LastUpdateDate { get; set; }
		public IfcCostValue? CurrentValue { get; set; }
		public IfcCostValue? OriginalValue { get; set; }
		public IfcInventory() : base()
		{
			InventoryType = new IfcInventoryTypeEnum();
			Jurisdiction = new IfcActorSelect();
			ResponsiblePersons = new List<IfcPerson>();
			LastUpdateDate = new IfcCalendarDate();
		}
		public IfcInventory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcInventoryTypeEnum InventoryType, IfcActorSelect Jurisdiction, List<IfcPerson> ResponsiblePersons, IfcCalendarDate LastUpdateDate, IfcCostValue CurrentValue, IfcCostValue OriginalValue) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.InventoryType = InventoryType;
			this.Jurisdiction = Jurisdiction;
			this.ResponsiblePersons = ResponsiblePersons;
			this.LastUpdateDate = LastUpdateDate;
			this.CurrentValue = CurrentValue;
			this.OriginalValue = OriginalValue;
		}
	}
	/// <summary>
	/// ENTITY IfcIrregularTimeSeries
	/// <para>ENTITY IfcIrregularTimeSeries</para>
	/// <para> SUBTYPE OF (IfcTimeSeries);</para>
	/// <para>	Values : LIST [1:?] OF IfcIrregularTimeSeriesValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcIrregularTimeSeries : IfcTimeSeries
	{
		public List<IfcIrregularTimeSeriesValue> Values { get; set; }
		public IfcIrregularTimeSeries() : base()
		{
			Values = new List<IfcIrregularTimeSeriesValue>();
		}
		public IfcIrregularTimeSeries(IfcLabel Name, IfcText Description, IfcDateTimeSelect StartTime, IfcDateTimeSelect EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit, List<IfcIrregularTimeSeriesValue> Values) : base (Name, Description, StartTime, EndTime, TimeSeriesDataType, DataOrigin, UserDefinedDataOrigin, Unit)
		{
			this.Values = Values;
		}
	}
	/// <summary>
	/// ENTITY IfcIrregularTimeSeriesValue;
	/// <para>ENTITY IfcIrregularTimeSeriesValue;</para>
	/// <para>	TimeStamp : IfcDateTimeSelect;</para>
	/// <para>	ListValues : LIST [1:?] OF IfcValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcIrregularTimeSeriesValueENTITY
	{
		public IfcDateTimeSelect TimeStamp { get; set; }
		public List<IfcValue> ListValues { get; set; }
		public IfcIrregularTimeSeriesValue() : base()
		{
			TimeStamp = new IfcDateTimeSelect();
			ListValues = new List<IfcValue>();
		}
		public IfcIrregularTimeSeriesValue(IfcDateTimeSelect TimeStamp, List<IfcValue> ListValues) : base ()
		{
			this.TimeStamp = TimeStamp;
			this.ListValues = ListValues;
		}
	}
	/// <summary>
	/// ENTITY IfcJunctionBoxType
	/// <para>ENTITY IfcJunctionBoxType</para>
	/// <para> SUBTYPE OF (IfcFlowFittingType);</para>
	/// <para>	PredefinedType : IfcJunctionBoxTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcJunctionBoxType : IfcFlowFittingType
	{
		public IfcJunctionBoxTypeEnum PredefinedType { get; set; }
		public IfcJunctionBoxType() : base()
		{
			PredefinedType = new IfcJunctionBoxTypeEnum();
		}
		public IfcJunctionBoxType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcJunctionBoxTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcLShapeProfileDef
	/// <para>ENTITY IfcLShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para>	Width : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	Thickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	EdgeRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	LegSlope : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	CentreOfGravityInX : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : Thickness < Depth;</para>
	/// <para>	WR22 : NOT(EXISTS(Width)) OR (Thickness < Width);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure? Width { get; set; }
		public IfcPositiveLengthMeasure Thickness { get; set; }
		public IfcPositiveLengthMeasure? FilletRadius { get; set; }
		public IfcPositiveLengthMeasure? EdgeRadius { get; set; }
		public IfcPlaneAngleMeasure? LegSlope { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInX { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcLShapeProfileDef() : base()
		{
			Depth = new IfcPositiveLengthMeasure();
			Thickness = new IfcPositiveLengthMeasure();
		}
		public IfcLShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure Width, IfcPositiveLengthMeasure Thickness, IfcPositiveLengthMeasure FilletRadius, IfcPositiveLengthMeasure EdgeRadius, IfcPlaneAngleMeasure LegSlope, IfcPositiveLengthMeasure CentreOfGravityInX, IfcPositiveLengthMeasure CentreOfGravityInY) : base (ProfileType, ProfileName, Position)
		{
			this.Depth = Depth;
			this.Width = Width;
			this.Thickness = Thickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
			this.LegSlope = LegSlope;
			this.CentreOfGravityInX = CentreOfGravityInX;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcLaborResource
	/// <para>ENTITY IfcLaborResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para>	SkillSet : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLaborResource : IfcConstructionResource
	{
		public IfcText? SkillSet { get; set; }
		public IfcLaborResource() : base()
		{
		}
		public IfcLaborResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity, IfcText SkillSet) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
			this.SkillSet = SkillSet;
		}
	}
	/// <summary>
	/// ENTITY IfcLampType
	/// <para>ENTITY IfcLampType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcLampTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLampType : IfcFlowTerminalType
	{
		public IfcLampTypeEnum PredefinedType { get; set; }
		public IfcLampType() : base()
		{
			PredefinedType = new IfcLampTypeEnum();
		}
		public IfcLampType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcLampTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcLibraryInformation;
	/// <para>ENTITY IfcLibraryInformation;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Version : OPTIONAL IfcLabel;</para>
	/// <para>	Publisher : OPTIONAL IfcOrganization;</para>
	/// <para>	VersionDate : OPTIONAL IfcCalendarDate;</para>
	/// <para>	LibraryReference : OPTIONAL SET [1:?] OF IfcLibraryReference;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLibraryInformationENTITY, IfcLibrarySelect
	{
		public IfcLabel Name { get; set; }
		public IfcLabel? Version { get; set; }
		public IfcOrganization? Publisher { get; set; }
		public IfcCalendarDate? VersionDate { get; set; }
		public List<IfcLibraryReference>? LibraryReference { get; set; }
		public IfcLibraryInformation() : base()
		{
			Name = new IfcLabel();
		}
		public IfcLibraryInformation(IfcLabel Name, IfcLabel Version, IfcOrganization Publisher, IfcCalendarDate VersionDate, List<IfcLibraryReference> LibraryReference) : base ()
		{
			this.Name = Name;
			this.Version = Version;
			this.Publisher = Publisher;
			this.VersionDate = VersionDate;
			this.LibraryReference = LibraryReference;
		}
	}
	/// <summary>
	/// ENTITY IfcLibraryReference
	/// <para>ENTITY IfcLibraryReference</para>
	/// <para> SUBTYPE OF (IfcExternalReference);</para>
	/// <para> INVERSE</para>
	/// <para>	ReferenceIntoLibrary : SET [0:1] OF IfcLibraryInformation FOR LibraryReference;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLibraryReference : IfcExternalReference, IfcLibrarySelect
	{
		public IfcLibraryReference() : base()
		{
		}
		public IfcLibraryReference(IfcLabel Location, IfcIdentifier ItemReference, IfcLabel Name) : base (Location, ItemReference, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcLightDistributionData;
	/// <para>ENTITY IfcLightDistributionData;</para>
	/// <para>	MainPlaneAngle : IfcPlaneAngleMeasure;</para>
	/// <para>	SecondaryPlaneAngle : LIST [1:?] OF IfcPlaneAngleMeasure;</para>
	/// <para>	LuminousIntensity : LIST [1:?] OF IfcLuminousIntensityDistributionMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightDistributionDataENTITY
	{
		public IfcPlaneAngleMeasure MainPlaneAngle { get; set; }
		public List<IfcPlaneAngleMeasure> SecondaryPlaneAngle { get; set; }
		public List<IfcLuminousIntensityDistributionMeasure> LuminousIntensity { get; set; }
		public IfcLightDistributionData() : base()
		{
			MainPlaneAngle = new IfcPlaneAngleMeasure();
			SecondaryPlaneAngle = new List<IfcPlaneAngleMeasure>();
			LuminousIntensity = new List<IfcLuminousIntensityDistributionMeasure>();
		}
		public IfcLightDistributionData(IfcPlaneAngleMeasure MainPlaneAngle, List<IfcPlaneAngleMeasure> SecondaryPlaneAngle, List<IfcLuminousIntensityDistributionMeasure> LuminousIntensity) : base ()
		{
			this.MainPlaneAngle = MainPlaneAngle;
			this.SecondaryPlaneAngle = SecondaryPlaneAngle;
			this.LuminousIntensity = LuminousIntensity;
		}
	}
	/// <summary>
	/// ENTITY IfcLightFixtureType
	/// <para>ENTITY IfcLightFixtureType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcLightFixtureTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightFixtureType : IfcFlowTerminalType
	{
		public IfcLightFixtureTypeEnum PredefinedType { get; set; }
		public IfcLightFixtureType() : base()
		{
			PredefinedType = new IfcLightFixtureTypeEnum();
		}
		public IfcLightFixtureType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcLightFixtureTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcLightIntensityDistribution;
	/// <para>ENTITY IfcLightIntensityDistribution;</para>
	/// <para>	LightDistributionCurve : IfcLightDistributionCurveEnum;</para>
	/// <para>	DistributionData : LIST [1:?] OF IfcLightDistributionData;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightIntensityDistributionENTITY, IfcLightDistributionDataSourceSelect
	{
		public IfcLightDistributionCurveEnum LightDistributionCurve { get; set; }
		public List<IfcLightDistributionData> DistributionData { get; set; }
		public IfcLightIntensityDistribution() : base()
		{
			LightDistributionCurve = new IfcLightDistributionCurveEnum();
			DistributionData = new List<IfcLightDistributionData>();
		}
		public IfcLightIntensityDistribution(IfcLightDistributionCurveEnum LightDistributionCurve, List<IfcLightDistributionData> DistributionData) : base ()
		{
			this.LightDistributionCurve = LightDistributionCurve;
			this.DistributionData = DistributionData;
		}
	}
	/// <summary>
	/// ENTITY IfcLightSource
	/// <para>ENTITY IfcLightSource</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcLightSourceAmbient</para>
	/// <para>	,IfcLightSourceDirectional</para>
	/// <para>	,IfcLightSourceGoniometric</para>
	/// <para>	,IfcLightSourcePositional))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	LightColour : IfcColourRgb;</para>
	/// <para>	AmbientIntensity : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	Intensity : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcLightSource : IfcGeometricRepresentationItem
	{
		public IfcLabel? Name { get; set; }
		public IfcColourRgb LightColour { get; set; }
		public IfcNormalisedRatioMeasure? AmbientIntensity { get; set; }
		public IfcNormalisedRatioMeasure? Intensity { get; set; }
		public IfcLightSource() : base()
		{
			LightColour = new IfcColourRgb();
		}
		public IfcLightSource(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity) : base ()
		{
			this.Name = Name;
			this.LightColour = LightColour;
			this.AmbientIntensity = AmbientIntensity;
			this.Intensity = Intensity;
		}
	}
	/// <summary>
	/// ENTITY IfcLightSourceAmbient
	/// <para>ENTITY IfcLightSourceAmbient</para>
	/// <para> SUBTYPE OF (IfcLightSource);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightSourceAmbient : IfcLightSource
	{
		public IfcLightSourceAmbient() : base()
		{
		}
		public IfcLightSourceAmbient(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity) : base (Name, LightColour, AmbientIntensity, Intensity)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcLightSourceDirectional
	/// <para>ENTITY IfcLightSourceDirectional</para>
	/// <para> SUBTYPE OF (IfcLightSource);</para>
	/// <para>	Orientation : IfcDirection;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightSourceDirectional : IfcLightSource
	{
		public IfcDirection Orientation { get; set; }
		public IfcLightSourceDirectional() : base()
		{
			Orientation = new IfcDirection();
		}
		public IfcLightSourceDirectional(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcDirection Orientation) : base (Name, LightColour, AmbientIntensity, Intensity)
		{
			this.Orientation = Orientation;
		}
	}
	/// <summary>
	/// ENTITY IfcLightSourceGoniometric
	/// <para>ENTITY IfcLightSourceGoniometric</para>
	/// <para> SUBTYPE OF (IfcLightSource);</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para>	ColourAppearance : OPTIONAL IfcColourRgb;</para>
	/// <para>	ColourTemperature : IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	LuminousFlux : IfcLuminousFluxMeasure;</para>
	/// <para>	LightEmissionSource : IfcLightEmissionSourceEnum;</para>
	/// <para>	LightDistributionDataSource : IfcLightDistributionDataSourceSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightSourceGoniometric : IfcLightSource
	{
		public IfcAxis2Placement3D Position { get; set; }
		public IfcColourRgb? ColourAppearance { get; set; }
		public IfcThermodynamicTemperatureMeasure ColourTemperature { get; set; }
		public IfcLuminousFluxMeasure LuminousFlux { get; set; }
		public IfcLightEmissionSourceEnum LightEmissionSource { get; set; }
		public IfcLightDistributionDataSourceSelect LightDistributionDataSource { get; set; }
		public IfcLightSourceGoniometric() : base()
		{
			Position = new IfcAxis2Placement3D();
			ColourTemperature = new IfcThermodynamicTemperatureMeasure();
			LuminousFlux = new IfcLuminousFluxMeasure();
			LightEmissionSource = new IfcLightEmissionSourceEnum();
			LightDistributionDataSource = new IfcLightDistributionDataSourceSelect();
		}
		public IfcLightSourceGoniometric(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcAxis2Placement3D Position, IfcColourRgb ColourAppearance, IfcThermodynamicTemperatureMeasure ColourTemperature, IfcLuminousFluxMeasure LuminousFlux, IfcLightEmissionSourceEnum LightEmissionSource, IfcLightDistributionDataSourceSelect LightDistributionDataSource) : base (Name, LightColour, AmbientIntensity, Intensity)
		{
			this.Position = Position;
			this.ColourAppearance = ColourAppearance;
			this.ColourTemperature = ColourTemperature;
			this.LuminousFlux = LuminousFlux;
			this.LightEmissionSource = LightEmissionSource;
			this.LightDistributionDataSource = LightDistributionDataSource;
		}
	}
	/// <summary>
	/// ENTITY IfcLightSourcePositional
	/// <para>ENTITY IfcLightSourcePositional</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcLightSourceSpot))</para>
	/// <para> SUBTYPE OF (IfcLightSource);</para>
	/// <para>	Position : IfcCartesianPoint;</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>	ConstantAttenuation : IfcReal;</para>
	/// <para>	DistanceAttenuation : IfcReal;</para>
	/// <para>	QuadricAttenuation : IfcReal;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightSourcePositional : IfcLightSource
	{
		public IfcCartesianPoint Position { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcReal ConstantAttenuation { get; set; }
		public IfcReal DistanceAttenuation { get; set; }
		public IfcReal QuadricAttenuation { get; set; }
		public IfcLightSourcePositional() : base()
		{
			Position = new IfcCartesianPoint();
			Radius = new IfcPositiveLengthMeasure();
			ConstantAttenuation = new IfcReal();
			DistanceAttenuation = new IfcReal();
			QuadricAttenuation = new IfcReal();
		}
		public IfcLightSourcePositional(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcCartesianPoint Position, IfcPositiveLengthMeasure Radius, IfcReal ConstantAttenuation, IfcReal DistanceAttenuation, IfcReal QuadricAttenuation) : base (Name, LightColour, AmbientIntensity, Intensity)
		{
			this.Position = Position;
			this.Radius = Radius;
			this.ConstantAttenuation = ConstantAttenuation;
			this.DistanceAttenuation = DistanceAttenuation;
			this.QuadricAttenuation = QuadricAttenuation;
		}
	}
	/// <summary>
	/// ENTITY IfcLightSourceSpot
	/// <para>ENTITY IfcLightSourceSpot</para>
	/// <para> SUBTYPE OF (IfcLightSourcePositional);</para>
	/// <para>	Orientation : IfcDirection;</para>
	/// <para>	ConcentrationExponent : OPTIONAL IfcReal;</para>
	/// <para>	SpreadAngle : IfcPositivePlaneAngleMeasure;</para>
	/// <para>	BeamWidthAngle : IfcPositivePlaneAngleMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLightSourceSpot : IfcLightSourcePositional
	{
		public IfcDirection Orientation { get; set; }
		public IfcReal? ConcentrationExponent { get; set; }
		public IfcPositivePlaneAngleMeasure SpreadAngle { get; set; }
		public IfcPositivePlaneAngleMeasure BeamWidthAngle { get; set; }
		public IfcLightSourceSpot() : base()
		{
			Orientation = new IfcDirection();
			SpreadAngle = new IfcPositivePlaneAngleMeasure();
			BeamWidthAngle = new IfcPositivePlaneAngleMeasure();
		}
		public IfcLightSourceSpot(IfcLabel Name, IfcColourRgb LightColour, IfcNormalisedRatioMeasure AmbientIntensity, IfcNormalisedRatioMeasure Intensity, IfcCartesianPoint Position, IfcPositiveLengthMeasure Radius, IfcReal ConstantAttenuation, IfcReal DistanceAttenuation, IfcReal QuadricAttenuation, IfcDirection Orientation, IfcReal ConcentrationExponent, IfcPositivePlaneAngleMeasure SpreadAngle, IfcPositivePlaneAngleMeasure BeamWidthAngle) : base (Name, LightColour, AmbientIntensity, Intensity, Position, Radius, ConstantAttenuation, DistanceAttenuation, QuadricAttenuation)
		{
			this.Orientation = Orientation;
			this.ConcentrationExponent = ConcentrationExponent;
			this.SpreadAngle = SpreadAngle;
			this.BeamWidthAngle = BeamWidthAngle;
		}
	}
	/// <summary>
	/// ENTITY IfcLine
	/// <para>ENTITY IfcLine</para>
	/// <para> SUBTYPE OF (IfcCurve);</para>
	/// <para>	Pnt : IfcCartesianPoint;</para>
	/// <para>	Dir : IfcVector;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Dir.Dim = Pnt.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLine : IfcCurve
	{
		public IfcCartesianPoint Pnt { get; set; }
		public IfcVector Dir { get; set; }
		public IfcLine() : base()
		{
			Pnt = new IfcCartesianPoint();
			Dir = new IfcVector();
		}
		public IfcLine(IfcCartesianPoint Pnt, IfcVector Dir) : base ()
		{
			this.Pnt = Pnt;
			this.Dir = Dir;
		}
	}
	/// <summary>
	/// ENTITY IfcLinearDimension
	/// <para>ENTITY IfcLinearDimension</para>
	/// <para> SUBTYPE OF (IfcDimensionCurveDirectedCallout);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLinearDimension : IfcDimensionCurveDirectedCallout
	{
		public IfcLinearDimension() : base()
		{
		}
		public IfcLinearDimension(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcLocalPlacement
	/// <para>ENTITY IfcLocalPlacement</para>
	/// <para> SUBTYPE OF (IfcObjectPlacement);</para>
	/// <para>	PlacementRelTo : OPTIONAL IfcObjectPlacement;</para>
	/// <para>	RelativePlacement : IfcAxis2Placement;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : IfcCorrectLocalPlacement(RelativePlacement, PlacementRelTo);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLocalPlacement : IfcObjectPlacement
	{
		public IfcObjectPlacement? PlacementRelTo { get; set; }
		public IfcAxis2Placement RelativePlacement { get; set; }
		public IfcLocalPlacement() : base()
		{
			RelativePlacement = new IfcAxis2Placement();
		}
		public IfcLocalPlacement(IfcObjectPlacement PlacementRelTo, IfcAxis2Placement RelativePlacement) : base ()
		{
			this.PlacementRelTo = PlacementRelTo;
			this.RelativePlacement = RelativePlacement;
		}
	}
	/// <summary>
	/// ENTITY IfcLocalTime;
	/// <para>ENTITY IfcLocalTime;</para>
	/// <para>	HourComponent : IfcHourInDay;</para>
	/// <para>	MinuteComponent : OPTIONAL IfcMinuteInHour;</para>
	/// <para>	SecondComponent : OPTIONAL IfcSecondInMinute;</para>
	/// <para>	Zone : OPTIONAL IfcCoordinatedUniversalTimeOffset;</para>
	/// <para>	DaylightSavingOffset : OPTIONAL IfcDaylightSavingHour;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : IfcValidTime (SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLocalTimeENTITY, IfcDateTimeSelect, IfcObjectReferenceSelect
	{
		public IfcHourInDay HourComponent { get; set; }
		public IfcMinuteInHour? MinuteComponent { get; set; }
		public IfcSecondInMinute? SecondComponent { get; set; }
		public IfcCoordinatedUniversalTimeOffset? Zone { get; set; }
		public IfcDaylightSavingHour? DaylightSavingOffset { get; set; }
		public IfcLocalTime() : base()
		{
			HourComponent = new IfcHourInDay();
		}
		public IfcLocalTime(IfcHourInDay HourComponent, IfcMinuteInHour MinuteComponent, IfcSecondInMinute SecondComponent, IfcCoordinatedUniversalTimeOffset Zone, IfcDaylightSavingHour DaylightSavingOffset) : base ()
		{
			this.HourComponent = HourComponent;
			this.MinuteComponent = MinuteComponent;
			this.SecondComponent = SecondComponent;
			this.Zone = Zone;
			this.DaylightSavingOffset = DaylightSavingOffset;
		}
	}
	/// <summary>
	/// ENTITY IfcLoop
	/// <para>ENTITY IfcLoop</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcEdgeLoop</para>
	/// <para>	,IfcPolyLoop</para>
	/// <para>	,IfcVertexLoop))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcLoop : IfcTopologicalRepresentationItem
	{
		public IfcLoop() : base()
		{
		}
		public IfcLoop() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcManifoldSolidBrep
	/// <para>ENTITY IfcManifoldSolidBrep</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFacetedBrep</para>
	/// <para>	,IfcFacetedBrepWithVoids))</para>
	/// <para> SUBTYPE OF (IfcSolidModel);</para>
	/// <para>	Outer : IfcClosedShell;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcManifoldSolidBrep : IfcSolidModel
	{
		public IfcClosedShell Outer { get; set; }
		public IfcManifoldSolidBrep() : base()
		{
			Outer = new IfcClosedShell();
		}
		public IfcManifoldSolidBrep(IfcClosedShell Outer) : base ()
		{
			this.Outer = Outer;
		}
	}
	/// <summary>
	/// ENTITY IfcMappedItem
	/// <para>ENTITY IfcMappedItem</para>
	/// <para> SUBTYPE OF (IfcRepresentationItem);</para>
	/// <para>	MappingSource : IfcRepresentationMap;</para>
	/// <para>	MappingTarget : IfcCartesianTransformationOperator;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMappedItem : IfcRepresentationItem
	{
		public IfcRepresentationMap MappingSource { get; set; }
		public IfcCartesianTransformationOperator MappingTarget { get; set; }
		public IfcMappedItem() : base()
		{
			MappingSource = new IfcRepresentationMap();
			MappingTarget = new IfcCartesianTransformationOperator();
		}
		public IfcMappedItem(IfcRepresentationMap MappingSource, IfcCartesianTransformationOperator MappingTarget) : base ()
		{
			this.MappingSource = MappingSource;
			this.MappingTarget = MappingTarget;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterial;
	/// <para>ENTITY IfcMaterial;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	HasRepresentation : SET [0:1] OF IfcMaterialDefinitionRepresentation FOR RepresentedMaterial;</para>
	/// <para>	ClassifiedAs : SET [0:1] OF IfcMaterialClassificationRelationship FOR ClassifiedMaterial;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialENTITY, IfcMaterialSelect, IfcObjectReferenceSelect
	{
		public IfcLabel Name { get; set; }
		public IfcMaterial() : base()
		{
			Name = new IfcLabel();
		}
		public IfcMaterial(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialClassificationRelationship;
	/// <para>ENTITY IfcMaterialClassificationRelationship;</para>
	/// <para>	MaterialClassifications : SET [1:?] OF IfcClassificationNotationSelect;</para>
	/// <para>	ClassifiedMaterial : IfcMaterial;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialClassificationRelationshipENTITY
	{
		public List<IfcClassificationNotationSelect> MaterialClassifications { get; set; }
		public IfcMaterial ClassifiedMaterial { get; set; }
		public IfcMaterialClassificationRelationship() : base()
		{
			MaterialClassifications = new List<IfcClassificationNotationSelect>();
			ClassifiedMaterial = new IfcMaterial();
		}
		public IfcMaterialClassificationRelationship(List<IfcClassificationNotationSelect> MaterialClassifications, IfcMaterial ClassifiedMaterial) : base ()
		{
			this.MaterialClassifications = MaterialClassifications;
			this.ClassifiedMaterial = ClassifiedMaterial;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialDefinitionRepresentation
	/// <para>ENTITY IfcMaterialDefinitionRepresentation</para>
	/// <para> SUBTYPE OF (IfcProductRepresentation);</para>
	/// <para>	RepresentedMaterial : IfcMaterial;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(temp <* Representations | </para>
	/// <para>               (NOT('IFC2X3.IFCSTYLEDREPRESENTATION' IN TYPEOF(temp)))</para>
	/// <para>             )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialDefinitionRepresentation : IfcProductRepresentation
	{
		public IfcMaterial RepresentedMaterial { get; set; }
		public IfcMaterialDefinitionRepresentation() : base()
		{
			RepresentedMaterial = new IfcMaterial();
		}
		public IfcMaterialDefinitionRepresentation(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations, IfcMaterial RepresentedMaterial) : base (Name, Description, Representations)
		{
			this.RepresentedMaterial = RepresentedMaterial;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialLayer;
	/// <para>ENTITY IfcMaterialLayer;</para>
	/// <para>	Material : OPTIONAL IfcMaterial;</para>
	/// <para>	LayerThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	IsVentilated : OPTIONAL IfcLogical;</para>
	/// <para> INVERSE</para>
	/// <para>	ToMaterialLayerSet : IfcMaterialLayerSet FOR MaterialLayers;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialLayerENTITY, IfcMaterialSelect, IfcObjectReferenceSelect
	{
		public IfcMaterial? Material { get; set; }
		public IfcPositiveLengthMeasure LayerThickness { get; set; }
		public IfcLogical? IsVentilated { get; set; }
		public IfcMaterialLayer() : base()
		{
			LayerThickness = new IfcPositiveLengthMeasure();
		}
		public IfcMaterialLayer(IfcMaterial Material, IfcPositiveLengthMeasure LayerThickness, IfcLogical IsVentilated) : base ()
		{
			this.Material = Material;
			this.LayerThickness = LayerThickness;
			this.IsVentilated = IsVentilated;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialLayerSet;
	/// <para>ENTITY IfcMaterialLayerSet;</para>
	/// <para>	MaterialLayers : LIST [1:?] OF IfcMaterialLayer;</para>
	/// <para>	LayerSetName : OPTIONAL IfcLabel;</para>
	/// <para> DERIVE</para>
	/// <para>	TotalThickness : IfcLengthMeasure := IfcMlsTotalThickness(SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialLayerSetENTITY, IfcMaterialSelect
	{
		public List<IfcMaterialLayer> MaterialLayers { get; set; }
		public IfcLabel? LayerSetName { get; set; }
		public IfcMaterialLayerSet() : base()
		{
			MaterialLayers = new List<IfcMaterialLayer>();
		}
		public IfcMaterialLayerSet(List<IfcMaterialLayer> MaterialLayers, IfcLabel LayerSetName) : base ()
		{
			this.MaterialLayers = MaterialLayers;
			this.LayerSetName = LayerSetName;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialLayerSetUsage;
	/// <para>ENTITY IfcMaterialLayerSetUsage;</para>
	/// <para>	ForLayerSet : IfcMaterialLayerSet;</para>
	/// <para>	LayerSetDirection : IfcLayerSetDirectionEnum;</para>
	/// <para>	DirectionSense : IfcDirectionSenseEnum;</para>
	/// <para>	OffsetFromReferenceLine : IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialLayerSetUsageENTITY, IfcMaterialSelect
	{
		public IfcMaterialLayerSet ForLayerSet { get; set; }
		public IfcLayerSetDirectionEnum LayerSetDirection { get; set; }
		public IfcDirectionSenseEnum DirectionSense { get; set; }
		public IfcLengthMeasure OffsetFromReferenceLine { get; set; }
		public IfcMaterialLayerSetUsage() : base()
		{
			ForLayerSet = new IfcMaterialLayerSet();
			LayerSetDirection = new IfcLayerSetDirectionEnum();
			DirectionSense = new IfcDirectionSenseEnum();
			OffsetFromReferenceLine = new IfcLengthMeasure();
		}
		public IfcMaterialLayerSetUsage(IfcMaterialLayerSet ForLayerSet, IfcLayerSetDirectionEnum LayerSetDirection, IfcDirectionSenseEnum DirectionSense, IfcLengthMeasure OffsetFromReferenceLine) : base ()
		{
			this.ForLayerSet = ForLayerSet;
			this.LayerSetDirection = LayerSetDirection;
			this.DirectionSense = DirectionSense;
			this.OffsetFromReferenceLine = OffsetFromReferenceLine;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialList;
	/// <para>ENTITY IfcMaterialList;</para>
	/// <para>	Materials : LIST [1:?] OF IfcMaterial;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMaterialListENTITY, IfcMaterialSelect, IfcObjectReferenceSelect
	{
		public List<IfcMaterial> Materials { get; set; }
		public IfcMaterialList() : base()
		{
			Materials = new List<IfcMaterial>();
		}
		public IfcMaterialList(List<IfcMaterial> Materials) : base ()
		{
			this.Materials = Materials;
		}
	}
	/// <summary>
	/// ENTITY IfcMaterialProperties
	/// <para>ENTITY IfcMaterialProperties</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcExtendedMaterialProperties</para>
	/// <para>	,IfcFuelProperties</para>
	/// <para>	,IfcGeneralMaterialProperties</para>
	/// <para>	,IfcHygroscopicMaterialProperties</para>
	/// <para>	,IfcMechanicalMaterialProperties</para>
	/// <para>	,IfcOpticalMaterialProperties</para>
	/// <para>	,IfcProductsOfCombustionProperties</para>
	/// <para>	,IfcThermalMaterialProperties</para>
	/// <para>	,IfcWaterProperties));</para>
	/// <para>	Material : IfcMaterial;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcMaterialPropertiesENTITY
	{
		public IfcMaterial Material { get; set; }
		public IfcMaterialProperties() : base()
		{
			Material = new IfcMaterial();
		}
		public IfcMaterialProperties(IfcMaterial Material) : base ()
		{
			this.Material = Material;
		}
	}
	/// <summary>
	/// ENTITY IfcMeasureWithUnit;
	/// <para>ENTITY IfcMeasureWithUnit;</para>
	/// <para>	ValueComponent : IfcValue;</para>
	/// <para>	UnitComponent : IfcUnit;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMeasureWithUnitENTITY, IfcAppliedValueSelect, IfcConditionCriterionSelect, IfcMetricValueSelect
	{
		public IfcValue ValueComponent { get; set; }
		public IfcUnit UnitComponent { get; set; }
		public IfcMeasureWithUnit() : base()
		{
			ValueComponent = new IfcValue();
			UnitComponent = new IfcUnit();
		}
		public IfcMeasureWithUnit(IfcValue ValueComponent, IfcUnit UnitComponent) : base ()
		{
			this.ValueComponent = ValueComponent;
			this.UnitComponent = UnitComponent;
		}
	}
	/// <summary>
	/// ENTITY IfcMechanicalConcreteMaterialProperties
	/// <para>ENTITY IfcMechanicalConcreteMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMechanicalMaterialProperties);</para>
	/// <para>	CompressiveStrength : OPTIONAL IfcPressureMeasure;</para>
	/// <para>	MaxAggregateSize : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	AdmixturesDescription : OPTIONAL IfcText;</para>
	/// <para>	Workability : OPTIONAL IfcText;</para>
	/// <para>	ProtectivePoreRatio : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	WaterImpermeability : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMechanicalConcreteMaterialProperties : IfcMechanicalMaterialProperties
	{
		public IfcPressureMeasure? CompressiveStrength { get; set; }
		public IfcPositiveLengthMeasure? MaxAggregateSize { get; set; }
		public IfcText? AdmixturesDescription { get; set; }
		public IfcText? Workability { get; set; }
		public IfcNormalisedRatioMeasure? ProtectivePoreRatio { get; set; }
		public IfcText? WaterImpermeability { get; set; }
		public IfcMechanicalConcreteMaterialProperties() : base()
		{
		}
		public IfcMechanicalConcreteMaterialProperties(IfcMaterial Material, IfcDynamicViscosityMeasure DynamicViscosity, IfcModulusOfElasticityMeasure YoungModulus, IfcModulusOfElasticityMeasure ShearModulus, IfcPositiveRatioMeasure PoissonRatio, IfcThermalExpansionCoefficientMeasure ThermalExpansionCoefficient, IfcPressureMeasure CompressiveStrength, IfcPositiveLengthMeasure MaxAggregateSize, IfcText AdmixturesDescription, IfcText Workability, IfcNormalisedRatioMeasure ProtectivePoreRatio, IfcText WaterImpermeability) : base (Material, DynamicViscosity, YoungModulus, ShearModulus, PoissonRatio, ThermalExpansionCoefficient)
		{
			this.CompressiveStrength = CompressiveStrength;
			this.MaxAggregateSize = MaxAggregateSize;
			this.AdmixturesDescription = AdmixturesDescription;
			this.Workability = Workability;
			this.ProtectivePoreRatio = ProtectivePoreRatio;
			this.WaterImpermeability = WaterImpermeability;
		}
	}
	/// <summary>
	/// ENTITY IfcMechanicalFastener
	/// <para>ENTITY IfcMechanicalFastener</para>
	/// <para> SUBTYPE OF (IfcFastener);</para>
	/// <para>	NominalDiameter : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	NominalLength : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMechanicalFastener : IfcFastener
	{
		public IfcPositiveLengthMeasure? NominalDiameter { get; set; }
		public IfcPositiveLengthMeasure? NominalLength { get; set; }
		public IfcMechanicalFastener() : base()
		{
		}
		public IfcMechanicalFastener(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure NominalDiameter, IfcPositiveLengthMeasure NominalLength) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.NominalDiameter = NominalDiameter;
			this.NominalLength = NominalLength;
		}
	}
	/// <summary>
	/// ENTITY IfcMechanicalFastenerType
	/// <para>ENTITY IfcMechanicalFastenerType</para>
	/// <para> SUBTYPE OF (IfcFastenerType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMechanicalFastenerType : IfcFastenerType
	{
		public IfcMechanicalFastenerType() : base()
		{
		}
		public IfcMechanicalFastenerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcMechanicalMaterialProperties
	/// <para>ENTITY IfcMechanicalMaterialProperties</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMechanicalConcreteMaterialProperties</para>
	/// <para>	,IfcMechanicalSteelMaterialProperties))</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	DynamicViscosity : OPTIONAL IfcDynamicViscosityMeasure;</para>
	/// <para>	YoungModulus : OPTIONAL IfcModulusOfElasticityMeasure;</para>
	/// <para>	ShearModulus : OPTIONAL IfcModulusOfElasticityMeasure;</para>
	/// <para>	PoissonRatio : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	ThermalExpansionCoefficient : OPTIONAL IfcThermalExpansionCoefficientMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(YoungModulus)) OR (YoungModulus >= 0.0);</para>
	/// <para>	WR22 : NOT(EXISTS(ShearModulus)) OR (ShearModulus >= 0.0);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMechanicalMaterialProperties : IfcMaterialProperties
	{
		public IfcDynamicViscosityMeasure? DynamicViscosity { get; set; }
		public IfcModulusOfElasticityMeasure? YoungModulus { get; set; }
		public IfcModulusOfElasticityMeasure? ShearModulus { get; set; }
		public IfcPositiveRatioMeasure? PoissonRatio { get; set; }
		public IfcThermalExpansionCoefficientMeasure? ThermalExpansionCoefficient { get; set; }
		public IfcMechanicalMaterialProperties() : base()
		{
		}
		public IfcMechanicalMaterialProperties(IfcMaterial Material, IfcDynamicViscosityMeasure DynamicViscosity, IfcModulusOfElasticityMeasure YoungModulus, IfcModulusOfElasticityMeasure ShearModulus, IfcPositiveRatioMeasure PoissonRatio, IfcThermalExpansionCoefficientMeasure ThermalExpansionCoefficient) : base (Material)
		{
			this.DynamicViscosity = DynamicViscosity;
			this.YoungModulus = YoungModulus;
			this.ShearModulus = ShearModulus;
			this.PoissonRatio = PoissonRatio;
			this.ThermalExpansionCoefficient = ThermalExpansionCoefficient;
		}
	}
	/// <summary>
	/// ENTITY IfcMechanicalSteelMaterialProperties
	/// <para>ENTITY IfcMechanicalSteelMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMechanicalMaterialProperties);</para>
	/// <para>	YieldStress : OPTIONAL IfcPressureMeasure;</para>
	/// <para>	UltimateStress : OPTIONAL IfcPressureMeasure;</para>
	/// <para>	UltimateStrain : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	HardeningModule : OPTIONAL IfcModulusOfElasticityMeasure;</para>
	/// <para>	ProportionalStress : OPTIONAL IfcPressureMeasure;</para>
	/// <para>	PlasticStrain : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	Relaxations : OPTIONAL SET [1:?] OF IfcRelaxation;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(YieldStress)) OR (YieldStress >= 0.);</para>
	/// <para>	WR32 : NOT(EXISTS(UltimateStress)) OR (UltimateStress >= 0.);</para>
	/// <para>	WR33 : NOT(EXISTS(HardeningModule)) OR (HardeningModule >= 0.);</para>
	/// <para>	WR34 : NOT(EXISTS(ProportionalStress)) OR (ProportionalStress >= 0.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMechanicalSteelMaterialProperties : IfcMechanicalMaterialProperties
	{
		public IfcPressureMeasure? YieldStress { get; set; }
		public IfcPressureMeasure? UltimateStress { get; set; }
		public IfcPositiveRatioMeasure? UltimateStrain { get; set; }
		public IfcModulusOfElasticityMeasure? HardeningModule { get; set; }
		public IfcPressureMeasure? ProportionalStress { get; set; }
		public IfcPositiveRatioMeasure? PlasticStrain { get; set; }
		public List<IfcRelaxation>? Relaxations { get; set; }
		public IfcMechanicalSteelMaterialProperties() : base()
		{
		}
		public IfcMechanicalSteelMaterialProperties(IfcMaterial Material, IfcDynamicViscosityMeasure DynamicViscosity, IfcModulusOfElasticityMeasure YoungModulus, IfcModulusOfElasticityMeasure ShearModulus, IfcPositiveRatioMeasure PoissonRatio, IfcThermalExpansionCoefficientMeasure ThermalExpansionCoefficient, IfcPressureMeasure YieldStress, IfcPressureMeasure UltimateStress, IfcPositiveRatioMeasure UltimateStrain, IfcModulusOfElasticityMeasure HardeningModule, IfcPressureMeasure ProportionalStress, IfcPositiveRatioMeasure PlasticStrain, List<IfcRelaxation> Relaxations) : base (Material, DynamicViscosity, YoungModulus, ShearModulus, PoissonRatio, ThermalExpansionCoefficient)
		{
			this.YieldStress = YieldStress;
			this.UltimateStress = UltimateStress;
			this.UltimateStrain = UltimateStrain;
			this.HardeningModule = HardeningModule;
			this.ProportionalStress = ProportionalStress;
			this.PlasticStrain = PlasticStrain;
			this.Relaxations = Relaxations;
		}
	}
	/// <summary>
	/// ENTITY IfcMember
	/// <para>ENTITY IfcMember</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMember : IfcBuildingElement
	{
		public IfcMember() : base()
		{
		}
		public IfcMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcMemberType
	/// <para>ENTITY IfcMemberType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcMemberTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMemberType : IfcBuildingElementType
	{
		public IfcMemberTypeEnum PredefinedType { get; set; }
		public IfcMemberType() : base()
		{
			PredefinedType = new IfcMemberTypeEnum();
		}
		public IfcMemberType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcMemberTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcMetric
	/// <para>ENTITY IfcMetric</para>
	/// <para> SUBTYPE OF (IfcConstraint);</para>
	/// <para>	Benchmark : IfcBenchmarkEnum;</para>
	/// <para>	ValueSource : OPTIONAL IfcLabel;</para>
	/// <para>	DataValue : IfcMetricValueSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMetric : IfcConstraint
	{
		public IfcBenchmarkEnum Benchmark { get; set; }
		public IfcLabel? ValueSource { get; set; }
		public IfcMetricValueSelect DataValue { get; set; }
		public IfcMetric() : base()
		{
			Benchmark = new IfcBenchmarkEnum();
			DataValue = new IfcMetricValueSelect();
		}
		public IfcMetric(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTimeSelect CreationTime, IfcLabel UserDefinedGrade, IfcBenchmarkEnum Benchmark, IfcLabel ValueSource, IfcMetricValueSelect DataValue) : base (Name, Description, ConstraintGrade, ConstraintSource, CreatingActor, CreationTime, UserDefinedGrade)
		{
			this.Benchmark = Benchmark;
			this.ValueSource = ValueSource;
			this.DataValue = DataValue;
		}
	}
	/// <summary>
	/// ENTITY IfcMonetaryUnit;
	/// <para>ENTITY IfcMonetaryUnit;</para>
	/// <para>	Currency : IfcCurrencyEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMonetaryUnitENTITY, IfcUnit
	{
		public IfcCurrencyEnum Currency { get; set; }
		public IfcMonetaryUnit() : base()
		{
			Currency = new IfcCurrencyEnum();
		}
		public IfcMonetaryUnit(IfcCurrencyEnum Currency) : base ()
		{
			this.Currency = Currency;
		}
	}
	/// <summary>
	/// ENTITY IfcMotorConnectionType
	/// <para>ENTITY IfcMotorConnectionType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcMotorConnectionTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMotorConnectionType : IfcEnergyConversionDeviceType
	{
		public IfcMotorConnectionTypeEnum PredefinedType { get; set; }
		public IfcMotorConnectionType() : base()
		{
			PredefinedType = new IfcMotorConnectionTypeEnum();
		}
		public IfcMotorConnectionType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcMotorConnectionTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcMove
	/// <para>ENTITY IfcMove</para>
	/// <para> SUBTYPE OF (IfcTask);</para>
	/// <para>	MoveFrom : IfcSpatialStructureElement;</para>
	/// <para>	MoveTo : IfcSpatialStructureElement;</para>
	/// <para>	PunchList : OPTIONAL LIST [1:?] OF UNIQUE IfcText;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(SELF\IfcProcess.OperatesOn) >= 1;</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* OperatesOn |</para>
	/// <para>              SIZEOF(QUERY(temp2 <* temp.RelatedObjects |</para>
	/// <para>                ('IFC2X3.IFCACTOR' IN TYPEOF (temp2)) OR</para>
	/// <para>                ('IFC2X3.IFCEQUIPMENTELEMENT' IN TYPEOF (temp2)) OR</para>
	/// <para>                ('IFC2X3.IFCFURNISHINGELEMENT' IN TYPEOF (temp2)) )) >=1</para>
	/// <para>              )) >= 1;</para>
	/// <para>	WR3 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcMove : IfcTask
	{
		public IfcSpatialStructureElement MoveFrom { get; set; }
		public IfcSpatialStructureElement MoveTo { get; set; }
		public IfcMove() : base()
		{
			MoveFrom = new IfcSpatialStructureElement();
			MoveTo = new IfcSpatialStructureElement();
		}
		public IfcMove(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier TaskId, IfcLabel Status, IfcLabel WorkMethod, BOOLEAN IsMilestone, INTEGER Priority, IfcSpatialStructureElement MoveFrom, IfcSpatialStructureElement MoveTo) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, TaskId, Status, WorkMethod, IsMilestone, Priority)
		{
			this.MoveFrom = MoveFrom;
			this.MoveTo = MoveTo;
		}
	}
	/// <summary>
	/// ENTITY IfcNamedUnit
	/// <para>ENTITY IfcNamedUnit</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcContextDependentUnit</para>
	/// <para>	,IfcConversionBasedUnit</para>
	/// <para>	,IfcSIUnit));</para>
	/// <para>	Dimensions : IfcDimensionalExponents;</para>
	/// <para>	UnitType : IfcUnitEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : IfcCorrectDimensions (SELF.UnitType, SELF.Dimensions);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcNamedUnitENTITY, IfcUnit
	{
		public IfcDimensionalExponents Dimensions { get; set; }
		public IfcUnitEnum UnitType { get; set; }
		public IfcNamedUnit() : base()
		{
			Dimensions = new IfcDimensionalExponents();
			UnitType = new IfcUnitEnum();
		}
		public IfcNamedUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType) : base ()
		{
			this.Dimensions = Dimensions;
			this.UnitType = UnitType;
		}
	}
	/// <summary>
	/// ENTITY IfcObject
	/// <para>ENTITY IfcObject</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcActor</para>
	/// <para>	,IfcControl</para>
	/// <para>	,IfcGroup</para>
	/// <para>	,IfcProcess</para>
	/// <para>	,IfcProduct</para>
	/// <para>	,IfcProject</para>
	/// <para>	,IfcResource))</para>
	/// <para> SUBTYPE OF (IfcObjectDefinition);</para>
	/// <para>	ObjectType : OPTIONAL IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	IsDefinedBy : SET [0:?] OF IfcRelDefines FOR RelatedObjects;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(temp <* IsDefinedBy | 'IFC2X3.IFCRELDEFINESBYTYPE' IN TYPEOF(temp))) <= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcObject : IfcObjectDefinition
	{
		public IfcLabel? ObjectType { get; set; }
		public IfcObject() : base()
		{
		}
		public IfcObject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.ObjectType = ObjectType;
		}
	}
	/// <summary>
	/// ENTITY IfcObjectDefinition
	/// <para>ENTITY IfcObjectDefinition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcObject</para>
	/// <para>	,IfcTypeObject))</para>
	/// <para> SUBTYPE OF (IfcRoot);</para>
	/// <para> INVERSE</para>
	/// <para>	HasAssignments : SET [0:?] OF IfcRelAssigns FOR RelatedObjects;</para>
	/// <para>	IsDecomposedBy : SET [0:?] OF IfcRelDecomposes FOR RelatingObject;</para>
	/// <para>	Decomposes : SET [0:1] OF IfcRelDecomposes FOR RelatedObjects;</para>
	/// <para>	HasAssociations : SET [0:?] OF IfcRelAssociates FOR RelatedObjects;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcObjectDefinition : IfcRoot
	{
		public IfcObjectDefinition() : base()
		{
		}
		public IfcObjectDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base (GlobalId, OwnerHistory, Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcObjectPlacement
	/// <para>ENTITY IfcObjectPlacement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGridPlacement</para>
	/// <para>	,IfcLocalPlacement));</para>
	/// <para> INVERSE</para>
	/// <para>	PlacesObject : SET [1:1] OF IfcProduct FOR ObjectPlacement;</para>
	/// <para>	ReferencedByPlacements : SET [0:?] OF IfcLocalPlacement FOR PlacementRelTo;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcObjectPlacementENTITY
	{
		public IfcObjectPlacement() : base()
		{
		}
		public IfcObjectPlacement() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcObjective
	/// <para>ENTITY IfcObjective</para>
	/// <para> SUBTYPE OF (IfcConstraint);</para>
	/// <para>	BenchmarkValues : OPTIONAL IfcMetric;</para>
	/// <para>	ResultValues : OPTIONAL IfcMetric;</para>
	/// <para>	ObjectiveQualifier : IfcObjectiveEnum;</para>
	/// <para>	UserDefinedQualifier : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : (ObjectiveQualifier <> IfcObjectiveEnum.USERDEFINED) OR</para>
	/// <para>             ((ObjectiveQualifier = IfcObjectiveEnum.USERDEFINED) AND EXISTS(SELF\IfcObjective.UserDefinedQualifier));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcObjective : IfcConstraint
	{
		public IfcMetric? BenchmarkValues { get; set; }
		public IfcMetric? ResultValues { get; set; }
		public IfcObjectiveEnum ObjectiveQualifier { get; set; }
		public IfcLabel? UserDefinedQualifier { get; set; }
		public IfcObjective() : base()
		{
			ObjectiveQualifier = new IfcObjectiveEnum();
		}
		public IfcObjective(IfcLabel Name, IfcText Description, IfcConstraintEnum ConstraintGrade, IfcLabel ConstraintSource, IfcActorSelect CreatingActor, IfcDateTimeSelect CreationTime, IfcLabel UserDefinedGrade, IfcMetric BenchmarkValues, IfcMetric ResultValues, IfcObjectiveEnum ObjectiveQualifier, IfcLabel UserDefinedQualifier) : base (Name, Description, ConstraintGrade, ConstraintSource, CreatingActor, CreationTime, UserDefinedGrade)
		{
			this.BenchmarkValues = BenchmarkValues;
			this.ResultValues = ResultValues;
			this.ObjectiveQualifier = ObjectiveQualifier;
			this.UserDefinedQualifier = UserDefinedQualifier;
		}
	}
	/// <summary>
	/// ENTITY IfcOccupant
	/// <para>ENTITY IfcOccupant</para>
	/// <para> SUBTYPE OF (IfcActor);</para>
	/// <para>	PredefinedType : IfcOccupantTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(PredefinedType = IfcOccupantTypeEnum.USERDEFINED) </para>
	/// <para>             OR EXISTS(SELF\IfcObject.ObjectType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOccupant : IfcActor
	{
		public IfcOccupantTypeEnum PredefinedType { get; set; }
		public IfcOccupant() : base()
		{
			PredefinedType = new IfcOccupantTypeEnum();
		}
		public IfcOccupant(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcActorSelect TheActor, IfcOccupantTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, TheActor)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcOffsetCurve2D
	/// <para>ENTITY IfcOffsetCurve2D</para>
	/// <para> SUBTYPE OF (IfcCurve);</para>
	/// <para>	BasisCurve : IfcCurve;</para>
	/// <para>	Distance : IfcLengthMeasure;</para>
	/// <para>	SelfIntersect : LOGICAL;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : BasisCurve.Dim = 2;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOffsetCurve2D : IfcCurve
	{
		public IfcCurve BasisCurve { get; set; }
		public IfcLengthMeasure Distance { get; set; }
		public LOGICAL SelfIntersect { get; set; }
		public IfcOffsetCurve2D() : base()
		{
			BasisCurve = new IfcCurve();
			Distance = new IfcLengthMeasure();
			SelfIntersect = new LOGICAL();
		}
		public IfcOffsetCurve2D(IfcCurve BasisCurve, IfcLengthMeasure Distance, LOGICAL SelfIntersect) : base ()
		{
			this.BasisCurve = BasisCurve;
			this.Distance = Distance;
			this.SelfIntersect = SelfIntersect;
		}
	}
	/// <summary>
	/// ENTITY IfcOffsetCurve3D
	/// <para>ENTITY IfcOffsetCurve3D</para>
	/// <para> SUBTYPE OF (IfcCurve);</para>
	/// <para>	BasisCurve : IfcCurve;</para>
	/// <para>	Distance : IfcLengthMeasure;</para>
	/// <para>	SelfIntersect : LOGICAL;</para>
	/// <para>	RefDirection : IfcDirection;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : BasisCurve.Dim = 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOffsetCurve3D : IfcCurve
	{
		public IfcCurve BasisCurve { get; set; }
		public IfcLengthMeasure Distance { get; set; }
		public LOGICAL SelfIntersect { get; set; }
		public IfcDirection RefDirection { get; set; }
		public IfcOffsetCurve3D() : base()
		{
			BasisCurve = new IfcCurve();
			Distance = new IfcLengthMeasure();
			SelfIntersect = new LOGICAL();
			RefDirection = new IfcDirection();
		}
		public IfcOffsetCurve3D(IfcCurve BasisCurve, IfcLengthMeasure Distance, LOGICAL SelfIntersect, IfcDirection RefDirection) : base ()
		{
			this.BasisCurve = BasisCurve;
			this.Distance = Distance;
			this.SelfIntersect = SelfIntersect;
			this.RefDirection = RefDirection;
		}
	}
	/// <summary>
	/// ENTITY IfcOneDirectionRepeatFactor
	/// <para>ENTITY IfcOneDirectionRepeatFactor</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcTwoDirectionRepeatFactor))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	RepeatFactor : IfcVector;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOneDirectionRepeatFactor : IfcGeometricRepresentationItem, IfcHatchLineDistanceSelect
	{
		public IfcVector RepeatFactor { get; set; }
		public IfcOneDirectionRepeatFactor() : base()
		{
			RepeatFactor = new IfcVector();
		}
		public IfcOneDirectionRepeatFactor(IfcVector RepeatFactor) : base ()
		{
			this.RepeatFactor = RepeatFactor;
		}
	}
	/// <summary>
	/// ENTITY IfcOpenShell
	/// <para>ENTITY IfcOpenShell</para>
	/// <para> SUBTYPE OF (IfcConnectedFaceSet);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOpenShell : IfcConnectedFaceSet, IfcShell
	{
		public IfcOpenShell() : base()
		{
		}
		public IfcOpenShell(List<IfcFace> CfsFaces) : base (CfsFaces)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcOpeningElement
	/// <para>ENTITY IfcOpeningElement</para>
	/// <para> SUBTYPE OF (IfcFeatureElementSubtraction);</para>
	/// <para> INVERSE</para>
	/// <para>	HasFillings : SET [0:?] OF IfcRelFillsElement FOR RelatingOpeningElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOpeningElement : IfcFeatureElementSubtraction
	{
		public IfcOpeningElement() : base()
		{
		}
		public IfcOpeningElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcOpticalMaterialProperties
	/// <para>ENTITY IfcOpticalMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	VisibleTransmittance : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	SolarTransmittance : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	ThermalIrTransmittance : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	ThermalIrEmissivityBack : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	ThermalIrEmissivityFront : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	VisibleReflectanceBack : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	VisibleReflectanceFront : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	SolarReflectanceFront : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	SolarReflectanceBack : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOpticalMaterialProperties : IfcMaterialProperties
	{
		public IfcPositiveRatioMeasure? VisibleTransmittance { get; set; }
		public IfcPositiveRatioMeasure? SolarTransmittance { get; set; }
		public IfcPositiveRatioMeasure? ThermalIrTransmittance { get; set; }
		public IfcPositiveRatioMeasure? ThermalIrEmissivityBack { get; set; }
		public IfcPositiveRatioMeasure? ThermalIrEmissivityFront { get; set; }
		public IfcPositiveRatioMeasure? VisibleReflectanceBack { get; set; }
		public IfcPositiveRatioMeasure? VisibleReflectanceFront { get; set; }
		public IfcPositiveRatioMeasure? SolarReflectanceFront { get; set; }
		public IfcPositiveRatioMeasure? SolarReflectanceBack { get; set; }
		public IfcOpticalMaterialProperties() : base()
		{
		}
		public IfcOpticalMaterialProperties(IfcMaterial Material, IfcPositiveRatioMeasure VisibleTransmittance, IfcPositiveRatioMeasure SolarTransmittance, IfcPositiveRatioMeasure ThermalIrTransmittance, IfcPositiveRatioMeasure ThermalIrEmissivityBack, IfcPositiveRatioMeasure ThermalIrEmissivityFront, IfcPositiveRatioMeasure VisibleReflectanceBack, IfcPositiveRatioMeasure VisibleReflectanceFront, IfcPositiveRatioMeasure SolarReflectanceFront, IfcPositiveRatioMeasure SolarReflectanceBack) : base (Material)
		{
			this.VisibleTransmittance = VisibleTransmittance;
			this.SolarTransmittance = SolarTransmittance;
			this.ThermalIrTransmittance = ThermalIrTransmittance;
			this.ThermalIrEmissivityBack = ThermalIrEmissivityBack;
			this.ThermalIrEmissivityFront = ThermalIrEmissivityFront;
			this.VisibleReflectanceBack = VisibleReflectanceBack;
			this.VisibleReflectanceFront = VisibleReflectanceFront;
			this.SolarReflectanceFront = SolarReflectanceFront;
			this.SolarReflectanceBack = SolarReflectanceBack;
		}
	}
	/// <summary>
	/// ENTITY IfcOrderAction
	/// <para>ENTITY IfcOrderAction</para>
	/// <para> SUBTYPE OF (IfcTask);</para>
	/// <para>	ActionID : IfcIdentifier;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR2 : ActionID;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOrderAction : IfcTask
	{
		public IfcIdentifier ActionID { get; set; }
		public IfcOrderAction() : base()
		{
			ActionID = new IfcIdentifier();
		}
		public IfcOrderAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier TaskId, IfcLabel Status, IfcLabel WorkMethod, BOOLEAN IsMilestone, INTEGER Priority, IfcIdentifier ActionID) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, TaskId, Status, WorkMethod, IsMilestone, Priority)
		{
			this.ActionID = ActionID;
		}
	}
	/// <summary>
	/// ENTITY IfcOrganization;
	/// <para>ENTITY IfcOrganization;</para>
	/// <para>	Id : OPTIONAL IfcIdentifier;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	Roles : OPTIONAL LIST [1:?] OF IfcActorRole;</para>
	/// <para>	Addresses : OPTIONAL LIST [1:?] OF IfcAddress;</para>
	/// <para> INVERSE</para>
	/// <para>	IsRelatedBy : SET [0:?] OF IfcOrganizationRelationship FOR RelatedOrganizations;</para>
	/// <para>	Relates : SET [0:?] OF IfcOrganizationRelationship FOR RelatingOrganization;</para>
	/// <para>	Engages : SET [0:?] OF IfcPersonAndOrganization FOR TheOrganization;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOrganizationENTITY, IfcActorSelect, IfcObjectReferenceSelect
	{
		public IfcIdentifier? Id { get; set; }
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public List<IfcActorRole>? Roles { get; set; }
		public List<IfcAddress>? Addresses { get; set; }
		public IfcOrganization() : base()
		{
			Name = new IfcLabel();
		}
		public IfcOrganization(IfcIdentifier Id, IfcLabel Name, IfcText Description, List<IfcActorRole> Roles, List<IfcAddress> Addresses) : base ()
		{
			this.Id = Id;
			this.Name = Name;
			this.Description = Description;
			this.Roles = Roles;
			this.Addresses = Addresses;
		}
	}
	/// <summary>
	/// ENTITY IfcOrganizationRelationship;
	/// <para>ENTITY IfcOrganizationRelationship;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	RelatingOrganization : IfcOrganization;</para>
	/// <para>	RelatedOrganizations : SET [1:?] OF IfcOrganization;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOrganizationRelationshipENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcOrganization RelatingOrganization { get; set; }
		public List<IfcOrganization> RelatedOrganizations { get; set; }
		public IfcOrganizationRelationship() : base()
		{
			Name = new IfcLabel();
			RelatingOrganization = new IfcOrganization();
			RelatedOrganizations = new List<IfcOrganization>();
		}
		public IfcOrganizationRelationship(IfcLabel Name, IfcText Description, IfcOrganization RelatingOrganization, List<IfcOrganization> RelatedOrganizations) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.RelatingOrganization = RelatingOrganization;
			this.RelatedOrganizations = RelatedOrganizations;
		}
	}
	/// <summary>
	/// ENTITY IfcOrientedEdge
	/// <para>ENTITY IfcOrientedEdge</para>
	/// <para> SUBTYPE OF (IfcEdge);</para>
	/// <para>	EdgeElement : IfcEdge;</para>
	/// <para>	Orientation : BOOLEAN;</para>
	/// <para> DERIVE</para>
	/// <para>	SELF\IfcEdge.EdgeStart : IfcVertex := IfcBooleanChoose </para>
	/// <para>                               (Orientation, EdgeElement.EdgeStart, EdgeElement.EdgeEnd);</para>
	/// <para>	SELF\IfcEdge.EdgeEnd : IfcVertex := IfcBooleanChoose </para>
	/// <para>                               (Orientation, EdgeElement.EdgeEnd, EdgeElement.EdgeStart);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : NOT('IFC2X3.IFCORIENTEDEDGE' IN TYPEOF(EdgeElement));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOrientedEdge : IfcEdge
	{
		public IfcEdge EdgeElement { get; set; }
		public BOOLEAN Orientation { get; set; }
		public IfcOrientedEdge() : base()
		{
			EdgeElement = new IfcEdge();
			Orientation = new BOOLEAN();
		}
		public IfcOrientedEdge(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcEdge EdgeElement, BOOLEAN Orientation) : base (EdgeStart, EdgeEnd)
		{
			this.EdgeElement = EdgeElement;
			this.Orientation = Orientation;
		}
	}
	/// <summary>
	/// ENTITY IfcOutletType
	/// <para>ENTITY IfcOutletType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcOutletTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOutletType : IfcFlowTerminalType
	{
		public IfcOutletTypeEnum PredefinedType { get; set; }
		public IfcOutletType() : base()
		{
			PredefinedType = new IfcOutletTypeEnum();
		}
		public IfcOutletType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcOutletTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcOwnerHistory;
	/// <para>ENTITY IfcOwnerHistory;</para>
	/// <para>	OwningUser : IfcPersonAndOrganization;</para>
	/// <para>	OwningApplication : IfcApplication;</para>
	/// <para>	State : OPTIONAL IfcStateEnum;</para>
	/// <para>	ChangeAction : IfcChangeActionEnum;</para>
	/// <para>	LastModifiedDate : OPTIONAL IfcTimeStamp;</para>
	/// <para>	LastModifyingUser : OPTIONAL IfcPersonAndOrganization;</para>
	/// <para>	LastModifyingApplication : OPTIONAL IfcApplication;</para>
	/// <para>	CreationDate : IfcTimeStamp;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcOwnerHistoryENTITY
	{
		public IfcPersonAndOrganization OwningUser { get; set; }
		public IfcApplication OwningApplication { get; set; }
		public IfcStateEnum? State { get; set; }
		public IfcChangeActionEnum ChangeAction { get; set; }
		public IfcTimeStamp? LastModifiedDate { get; set; }
		public IfcPersonAndOrganization? LastModifyingUser { get; set; }
		public IfcApplication? LastModifyingApplication { get; set; }
		public IfcTimeStamp CreationDate { get; set; }
		public IfcOwnerHistory() : base()
		{
			OwningUser = new IfcPersonAndOrganization();
			OwningApplication = new IfcApplication();
			ChangeAction = new IfcChangeActionEnum();
			CreationDate = new IfcTimeStamp();
		}
		public IfcOwnerHistory(IfcPersonAndOrganization OwningUser, IfcApplication OwningApplication, IfcStateEnum State, IfcChangeActionEnum ChangeAction, IfcTimeStamp LastModifiedDate, IfcPersonAndOrganization LastModifyingUser, IfcApplication LastModifyingApplication, IfcTimeStamp CreationDate) : base ()
		{
			this.OwningUser = OwningUser;
			this.OwningApplication = OwningApplication;
			this.State = State;
			this.ChangeAction = ChangeAction;
			this.LastModifiedDate = LastModifiedDate;
			this.LastModifyingUser = LastModifyingUser;
			this.LastModifyingApplication = LastModifyingApplication;
			this.CreationDate = CreationDate;
		}
	}
	/// <summary>
	/// ENTITY IfcParameterizedProfileDef
	/// <para>ENTITY IfcParameterizedProfileDef</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCShapeProfileDef</para>
	/// <para>	,IfcCircleProfileDef</para>
	/// <para>	,IfcCraneRailAShapeProfileDef</para>
	/// <para>	,IfcCraneRailFShapeProfileDef</para>
	/// <para>	,IfcEllipseProfileDef</para>
	/// <para>	,IfcIShapeProfileDef</para>
	/// <para>	,IfcLShapeProfileDef</para>
	/// <para>	,IfcRectangleProfileDef</para>
	/// <para>	,IfcTShapeProfileDef</para>
	/// <para>	,IfcTrapeziumProfileDef</para>
	/// <para>	,IfcUShapeProfileDef</para>
	/// <para>	,IfcZShapeProfileDef))</para>
	/// <para> SUBTYPE OF (IfcProfileDef);</para>
	/// <para>	Position : IfcAxis2Placement2D;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcParameterizedProfileDef : IfcProfileDef
	{
		public IfcAxis2Placement2D Position { get; set; }
		public IfcParameterizedProfileDef() : base()
		{
			Position = new IfcAxis2Placement2D();
		}
		public IfcParameterizedProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position) : base (ProfileType, ProfileName)
		{
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcPath
	/// <para>ENTITY IfcPath</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>	EdgeList : LIST [1:?] OF UNIQUE IfcOrientedEdge;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : IfcPathHeadToTail(SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPath : IfcTopologicalRepresentationItem
	{
		public IfcPath() : base()
		{
		}
		public IfcPath() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPerformanceHistory
	/// <para>ENTITY IfcPerformanceHistory</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	LifeCyclePhase : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPerformanceHistory : IfcControl
	{
		public IfcLabel LifeCyclePhase { get; set; }
		public IfcPerformanceHistory() : base()
		{
			LifeCyclePhase = new IfcLabel();
		}
		public IfcPerformanceHistory(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LifeCyclePhase) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.LifeCyclePhase = LifeCyclePhase;
		}
	}
	/// <summary>
	/// ENTITY IfcPermeableCoveringProperties
	/// <para>ENTITY IfcPermeableCoveringProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	OperationType : IfcPermeableCoveringOperationEnum;</para>
	/// <para>	PanelPosition : IfcWindowPanelPositionEnum;</para>
	/// <para>	FrameDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	FrameThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	ShapeAspectStyle : OPTIONAL IfcShapeAspect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPermeableCoveringProperties : IfcPropertySetDefinition
	{
		public IfcPermeableCoveringOperationEnum OperationType { get; set; }
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
		public IfcPositiveLengthMeasure? FrameDepth { get; set; }
		public IfcPositiveLengthMeasure? FrameThickness { get; set; }
		public IfcShapeAspect? ShapeAspectStyle { get; set; }
		public IfcPermeableCoveringProperties() : base()
		{
			OperationType = new IfcPermeableCoveringOperationEnum();
			PanelPosition = new IfcWindowPanelPositionEnum();
		}
		public IfcPermeableCoveringProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPermeableCoveringOperationEnum OperationType, IfcWindowPanelPositionEnum PanelPosition, IfcPositiveLengthMeasure FrameDepth, IfcPositiveLengthMeasure FrameThickness, IfcShapeAspect ShapeAspectStyle) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.OperationType = OperationType;
			this.PanelPosition = PanelPosition;
			this.FrameDepth = FrameDepth;
			this.FrameThickness = FrameThickness;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcPermit
	/// <para>ENTITY IfcPermit</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	PermitID : IfcIdentifier;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR2 : PermitID;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPermit : IfcControl
	{
		public IfcIdentifier PermitID { get; set; }
		public IfcPermit() : base()
		{
			PermitID = new IfcIdentifier();
		}
		public IfcPermit(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier PermitID) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.PermitID = PermitID;
		}
	}
	/// <summary>
	/// ENTITY IfcPerson;
	/// <para>ENTITY IfcPerson;</para>
	/// <para>	Id : OPTIONAL IfcIdentifier;</para>
	/// <para>	FamilyName : OPTIONAL IfcLabel;</para>
	/// <para>	GivenName : OPTIONAL IfcLabel;</para>
	/// <para>	MiddleNames : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	PrefixTitles : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	SuffixTitles : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	Roles : OPTIONAL LIST [1:?] OF IfcActorRole;</para>
	/// <para>	Addresses : OPTIONAL LIST [1:?] OF IfcAddress;</para>
	/// <para> INVERSE</para>
	/// <para>	EngagedIn : SET [0:?] OF IfcPersonAndOrganization FOR ThePerson;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(FamilyName) OR </para>
	/// <para>            EXISTS(GivenName);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPersonENTITY, IfcActorSelect, IfcObjectReferenceSelect
	{
		public IfcIdentifier? Id { get; set; }
		public IfcLabel? FamilyName { get; set; }
		public IfcLabel? GivenName { get; set; }
		public List<IfcLabel>? MiddleNames { get; set; }
		public List<IfcLabel>? PrefixTitles { get; set; }
		public List<IfcLabel>? SuffixTitles { get; set; }
		public List<IfcActorRole>? Roles { get; set; }
		public List<IfcAddress>? Addresses { get; set; }
		public IfcPerson() : base()
		{
		}
		public IfcPerson(IfcIdentifier Id, IfcLabel FamilyName, IfcLabel GivenName, List<IfcLabel> MiddleNames, List<IfcLabel> PrefixTitles, List<IfcLabel> SuffixTitles, List<IfcActorRole> Roles, List<IfcAddress> Addresses) : base ()
		{
			this.Id = Id;
			this.FamilyName = FamilyName;
			this.GivenName = GivenName;
			this.MiddleNames = MiddleNames;
			this.PrefixTitles = PrefixTitles;
			this.SuffixTitles = SuffixTitles;
			this.Roles = Roles;
			this.Addresses = Addresses;
		}
	}
	/// <summary>
	/// ENTITY IfcPersonAndOrganization;
	/// <para>ENTITY IfcPersonAndOrganization;</para>
	/// <para>	ThePerson : IfcPerson;</para>
	/// <para>	TheOrganization : IfcOrganization;</para>
	/// <para>	Roles : OPTIONAL LIST [1:?] OF IfcActorRole;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPersonAndOrganizationENTITY, IfcActorSelect, IfcObjectReferenceSelect
	{
		public IfcPerson ThePerson { get; set; }
		public IfcOrganization TheOrganization { get; set; }
		public List<IfcActorRole>? Roles { get; set; }
		public IfcPersonAndOrganization() : base()
		{
			ThePerson = new IfcPerson();
			TheOrganization = new IfcOrganization();
		}
		public IfcPersonAndOrganization(IfcPerson ThePerson, IfcOrganization TheOrganization, List<IfcActorRole> Roles) : base ()
		{
			this.ThePerson = ThePerson;
			this.TheOrganization = TheOrganization;
			this.Roles = Roles;
		}
	}
	/// <summary>
	/// ENTITY IfcPhysicalComplexQuantity
	/// <para>ENTITY IfcPhysicalComplexQuantity</para>
	/// <para> SUBTYPE OF (IfcPhysicalQuantity);</para>
	/// <para>	HasQuantities : SET [1:?] OF IfcPhysicalQuantity;</para>
	/// <para>	Discrimination : IfcLabel;</para>
	/// <para>	Quality : OPTIONAL IfcLabel;</para>
	/// <para>	Usage : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* HasQuantities | SELF :=: temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPhysicalComplexQuantity : IfcPhysicalQuantity
	{
		public List<IfcPhysicalQuantity> HasQuantities { get; set; }
		public IfcLabel Discrimination { get; set; }
		public IfcLabel? Quality { get; set; }
		public IfcLabel? Usage { get; set; }
		public IfcPhysicalComplexQuantity() : base()
		{
			HasQuantities = new List<IfcPhysicalQuantity>();
			Discrimination = new IfcLabel();
		}
		public IfcPhysicalComplexQuantity(IfcLabel Name, IfcText Description, List<IfcPhysicalQuantity> HasQuantities, IfcLabel Discrimination, IfcLabel Quality, IfcLabel Usage) : base (Name, Description)
		{
			this.HasQuantities = HasQuantities;
			this.Discrimination = Discrimination;
			this.Quality = Quality;
			this.Usage = Usage;
		}
	}
	/// <summary>
	/// ENTITY IfcPhysicalQuantity
	/// <para>ENTITY IfcPhysicalQuantity</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPhysicalComplexQuantity</para>
	/// <para>	,IfcPhysicalSimpleQuantity));</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para> INVERSE</para>
	/// <para>	PartOfComplex : SET [0:1] OF IfcPhysicalComplexQuantity FOR HasQuantities;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPhysicalQuantityENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcPhysicalQuantity() : base()
		{
			Name = new IfcLabel();
		}
		public IfcPhysicalQuantity(IfcLabel Name, IfcText Description) : base ()
		{
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcPhysicalSimpleQuantity
	/// <para>ENTITY IfcPhysicalSimpleQuantity</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcQuantityArea</para>
	/// <para>	,IfcQuantityCount</para>
	/// <para>	,IfcQuantityLength</para>
	/// <para>	,IfcQuantityTime</para>
	/// <para>	,IfcQuantityVolume</para>
	/// <para>	,IfcQuantityWeight))</para>
	/// <para> SUBTYPE OF (IfcPhysicalQuantity);</para>
	/// <para>	Unit : OPTIONAL IfcNamedUnit;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPhysicalSimpleQuantity : IfcPhysicalQuantity
	{
		public IfcNamedUnit? Unit { get; set; }
		public IfcPhysicalSimpleQuantity() : base()
		{
		}
		public IfcPhysicalSimpleQuantity(IfcLabel Name, IfcText Description, IfcNamedUnit Unit) : base (Name, Description)
		{
			this.Unit = Unit;
		}
	}
	/// <summary>
	/// ENTITY IfcPile
	/// <para>ENTITY IfcPile</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	PredefinedType : IfcPileTypeEnum;</para>
	/// <para>	ConstructionType : OPTIONAL IfcPileConstructionEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcPileTypeEnum.USERDEFINED) OR ((PredefinedType = IfcPileTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPile : IfcBuildingElement
	{
		public IfcPileTypeEnum PredefinedType { get; set; }
		public IfcPileConstructionEnum? ConstructionType { get; set; }
		public IfcPile() : base()
		{
			PredefinedType = new IfcPileTypeEnum();
		}
		public IfcPile(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPileTypeEnum PredefinedType, IfcPileConstructionEnum ConstructionType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.PredefinedType = PredefinedType;
			this.ConstructionType = ConstructionType;
		}
	}
	/// <summary>
	/// ENTITY IfcPipeFittingType
	/// <para>ENTITY IfcPipeFittingType</para>
	/// <para> SUBTYPE OF (IfcFlowFittingType);</para>
	/// <para>	PredefinedType : IfcPipeFittingTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcPipeFittingTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcPipeFittingTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPipeFittingType : IfcFlowFittingType
	{
		public IfcPipeFittingTypeEnum PredefinedType { get; set; }
		public IfcPipeFittingType() : base()
		{
			PredefinedType = new IfcPipeFittingTypeEnum();
		}
		public IfcPipeFittingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcPipeFittingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcPipeSegmentType
	/// <para>ENTITY IfcPipeSegmentType</para>
	/// <para> SUBTYPE OF (IfcFlowSegmentType);</para>
	/// <para>	PredefinedType : IfcPipeSegmentTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcPipeSegmentTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcPipeSegmentTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPipeSegmentType : IfcFlowSegmentType
	{
		public IfcPipeSegmentTypeEnum PredefinedType { get; set; }
		public IfcPipeSegmentType() : base()
		{
			PredefinedType = new IfcPipeSegmentTypeEnum();
		}
		public IfcPipeSegmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcPipeSegmentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcPixelTexture
	/// <para>ENTITY IfcPixelTexture</para>
	/// <para> SUBTYPE OF (IfcSurfaceTexture);</para>
	/// <para>	Width : IfcInteger;</para>
	/// <para>	Height : IfcInteger;</para>
	/// <para>	ColourComponents : IfcInteger;</para>
	/// <para>	Pixel : LIST [1:?] OF BINARY(32);</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : Width >= 1;</para>
	/// <para>	WR22 : Height >= 1;</para>
	/// <para>	WR23 : {1 <= ColourComponents <= 4};</para>
	/// <para>	WR24 : SIZEOF(Pixel) = (Width * Height);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPixelTexture : IfcSurfaceTexture
	{
		public IfcInteger Width { get; set; }
		public IfcInteger Height { get; set; }
		public IfcInteger ColourComponents { get; set; }
		public List<BINARY(32)> Pixel { get; set; }
		public IfcPixelTexture() : base()
		{
			Width = new IfcInteger();
			Height = new IfcInteger();
			ColourComponents = new IfcInteger();
			Pixel = new List<BINARY(32)>();
		}
		public IfcPixelTexture(BOOLEAN RepeatS, BOOLEAN RepeatT, IfcSurfaceTextureEnum TextureType, IfcCartesianTransformationOperator2D TextureTransform, IfcInteger Width, IfcInteger Height, IfcInteger ColourComponents, List<BINARY(32)> Pixel) : base (RepeatS, RepeatT, TextureType, TextureTransform)
		{
			this.Width = Width;
			this.Height = Height;
			this.ColourComponents = ColourComponents;
			this.Pixel = Pixel;
		}
	}
	/// <summary>
	/// ENTITY IfcPlacement
	/// <para>ENTITY IfcPlacement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAxis1Placement</para>
	/// <para>	,IfcAxis2Placement2D</para>
	/// <para>	,IfcAxis2Placement3D))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Location : IfcCartesianPoint;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := Location.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPlacement : IfcGeometricRepresentationItem
	{
		public IfcCartesianPoint Location { get; set; }
		public IfcPlacement() : base()
		{
			Location = new IfcCartesianPoint();
		}
		public IfcPlacement(IfcCartesianPoint Location) : base ()
		{
			this.Location = Location;
		}
	}
	/// <summary>
	/// ENTITY IfcPlanarBox
	/// <para>ENTITY IfcPlanarBox</para>
	/// <para> SUBTYPE OF (IfcPlanarExtent);</para>
	/// <para>	Placement : IfcAxis2Placement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPlanarBox : IfcPlanarExtent
	{
		public IfcAxis2Placement Placement { get; set; }
		public IfcPlanarBox() : base()
		{
			Placement = new IfcAxis2Placement();
		}
		public IfcPlanarBox(IfcLengthMeasure SizeInX, IfcLengthMeasure SizeInY, IfcAxis2Placement Placement) : base (SizeInX, SizeInY)
		{
			this.Placement = Placement;
		}
	}
	/// <summary>
	/// ENTITY IfcPlanarExtent
	/// <para>ENTITY IfcPlanarExtent</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPlanarBox))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	SizeInX : IfcLengthMeasure;</para>
	/// <para>	SizeInY : IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPlanarExtent : IfcGeometricRepresentationItem
	{
		public IfcLengthMeasure SizeInX { get; set; }
		public IfcLengthMeasure SizeInY { get; set; }
		public IfcPlanarExtent() : base()
		{
			SizeInX = new IfcLengthMeasure();
			SizeInY = new IfcLengthMeasure();
		}
		public IfcPlanarExtent(IfcLengthMeasure SizeInX, IfcLengthMeasure SizeInY) : base ()
		{
			this.SizeInX = SizeInX;
			this.SizeInY = SizeInY;
		}
	}
	/// <summary>
	/// ENTITY IfcPlane
	/// <para>ENTITY IfcPlane</para>
	/// <para> SUBTYPE OF (IfcElementarySurface);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPlane : IfcElementarySurface
	{
		public IfcPlane() : base()
		{
		}
		public IfcPlane(IfcAxis2Placement3D Position) : base (Position)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPlate
	/// <para>ENTITY IfcPlate</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPlate : IfcBuildingElement
	{
		public IfcPlate() : base()
		{
		}
		public IfcPlate(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPlateType
	/// <para>ENTITY IfcPlateType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcPlateTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPlateType : IfcBuildingElementType
	{
		public IfcPlateTypeEnum PredefinedType { get; set; }
		public IfcPlateType() : base()
		{
			PredefinedType = new IfcPlateTypeEnum();
		}
		public IfcPlateType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcPlateTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcPoint
	/// <para>ENTITY IfcPoint</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCartesianPoint</para>
	/// <para>	,IfcPointOnCurve</para>
	/// <para>	,IfcPointOnSurface))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPoint : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcPointOrVertexPoint
	{
		public IfcPoint() : base()
		{
		}
		public IfcPoint() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPointOnCurve
	/// <para>ENTITY IfcPointOnCurve</para>
	/// <para> SUBTYPE OF (IfcPoint);</para>
	/// <para>	BasisCurve : IfcCurve;</para>
	/// <para>	PointParameter : IfcParameterValue;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := BasisCurve.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPointOnCurve : IfcPoint
	{
		public IfcCurve BasisCurve { get; set; }
		public IfcParameterValue PointParameter { get; set; }
		public IfcPointOnCurve() : base()
		{
			BasisCurve = new IfcCurve();
			PointParameter = new IfcParameterValue();
		}
		public IfcPointOnCurve(IfcCurve BasisCurve, IfcParameterValue PointParameter) : base ()
		{
			this.BasisCurve = BasisCurve;
			this.PointParameter = PointParameter;
		}
	}
	/// <summary>
	/// ENTITY IfcPointOnSurface
	/// <para>ENTITY IfcPointOnSurface</para>
	/// <para> SUBTYPE OF (IfcPoint);</para>
	/// <para>	BasisSurface : IfcSurface;</para>
	/// <para>	PointParameterU : IfcParameterValue;</para>
	/// <para>	PointParameterV : IfcParameterValue;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := BasisSurface.Dim;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPointOnSurface : IfcPoint
	{
		public IfcSurface BasisSurface { get; set; }
		public IfcParameterValue PointParameterU { get; set; }
		public IfcParameterValue PointParameterV { get; set; }
		public IfcPointOnSurface() : base()
		{
			BasisSurface = new IfcSurface();
			PointParameterU = new IfcParameterValue();
			PointParameterV = new IfcParameterValue();
		}
		public IfcPointOnSurface(IfcSurface BasisSurface, IfcParameterValue PointParameterU, IfcParameterValue PointParameterV) : base ()
		{
			this.BasisSurface = BasisSurface;
			this.PointParameterU = PointParameterU;
			this.PointParameterV = PointParameterV;
		}
	}
	/// <summary>
	/// ENTITY IfcPolyLoop
	/// <para>ENTITY IfcPolyLoop</para>
	/// <para> SUBTYPE OF (IfcLoop);</para>
	/// <para>	Polygon : LIST [3:?] OF UNIQUE IfcCartesianPoint;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(Temp <* Polygon | Temp.Dim <> Polygon[1].Dim)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPolyLoop : IfcLoop
	{
		public IfcPolyLoop() : base()
		{
		}
		public IfcPolyLoop() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPolygonalBoundedHalfSpace
	/// <para>ENTITY IfcPolygonalBoundedHalfSpace</para>
	/// <para> SUBTYPE OF (IfcHalfSpaceSolid);</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para>	PolygonalBoundary : IfcBoundedCurve;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : PolygonalBoundary.Dim = 2;</para>
	/// <para>	WR42 : SIZEOF(TYPEOF(PolygonalBoundary) * [</para>
	/// <para>               'IFC2X3.IFCPOLYLINE', </para>
	/// <para>               'IFC2X3.IFCCOMPOSITECURVE']</para>
	/// <para>             ) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid
	{
		public IfcAxis2Placement3D Position { get; set; }
		public IfcBoundedCurve PolygonalBoundary { get; set; }
		public IfcPolygonalBoundedHalfSpace() : base()
		{
			Position = new IfcAxis2Placement3D();
			PolygonalBoundary = new IfcBoundedCurve();
		}
		public IfcPolygonalBoundedHalfSpace(IfcSurface BaseSurface, BOOLEAN AgreementFlag, IfcAxis2Placement3D Position, IfcBoundedCurve PolygonalBoundary) : base (BaseSurface, AgreementFlag)
		{
			this.Position = Position;
			this.PolygonalBoundary = PolygonalBoundary;
		}
	}
	/// <summary>
	/// ENTITY IfcPolyline
	/// <para>ENTITY IfcPolyline</para>
	/// <para> SUBTYPE OF (IfcBoundedCurve);</para>
	/// <para>	Points : LIST [2:?] OF IfcCartesianPoint;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : SIZEOF(QUERY(Temp <* Points | Temp.Dim <> Points[1].Dim)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPolyline : IfcBoundedCurve
	{
		public List<IfcCartesianPoint> Points { get; set; }
		public IfcPolyline() : base()
		{
			Points = new List<IfcCartesianPoint>();
		}
		public IfcPolyline(List<IfcCartesianPoint> Points) : base ()
		{
			this.Points = Points;
		}
	}
	/// <summary>
	/// ENTITY IfcPort
	/// <para>ENTITY IfcPort</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDistributionPort))</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para> INVERSE</para>
	/// <para>	ContainedIn : IfcRelConnectsPortToElement FOR RelatingPort;</para>
	/// <para>	ConnectedFrom : SET [0:1] OF IfcRelConnectsPorts FOR RelatedPort;</para>
	/// <para>	ConnectedTo : SET [0:1] OF IfcRelConnectsPorts FOR RelatingPort;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPort : IfcProduct
	{
		public IfcPort() : base()
		{
		}
		public IfcPort(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPostalAddress
	/// <para>ENTITY IfcPostalAddress</para>
	/// <para> SUBTYPE OF (IfcAddress);</para>
	/// <para>	InternalLocation : OPTIONAL IfcLabel;</para>
	/// <para>	AddressLines : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	PostalBox : OPTIONAL IfcLabel;</para>
	/// <para>	Town : OPTIONAL IfcLabel;</para>
	/// <para>	Region : OPTIONAL IfcLabel;</para>
	/// <para>	PostalCode : OPTIONAL IfcLabel;</para>
	/// <para>	Country : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS (InternalLocation) OR </para>
	/// <para>            EXISTS (AddressLines) OR</para>
	/// <para>            EXISTS (PostalBox) OR</para>
	/// <para>            EXISTS (PostalCode) OR</para>
	/// <para>            EXISTS (Town) OR </para>
	/// <para>            EXISTS (Region) OR  </para>
	/// <para>            EXISTS (Country);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPostalAddress : IfcAddress
	{
		public IfcLabel? InternalLocation { get; set; }
		public List<IfcLabel>? AddressLines { get; set; }
		public IfcLabel? PostalBox { get; set; }
		public IfcLabel? Town { get; set; }
		public IfcLabel? Region { get; set; }
		public IfcLabel? PostalCode { get; set; }
		public IfcLabel? Country { get; set; }
		public IfcPostalAddress() : base()
		{
		}
		public IfcPostalAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose, IfcLabel InternalLocation, List<IfcLabel> AddressLines, IfcLabel PostalBox, IfcLabel Town, IfcLabel Region, IfcLabel PostalCode, IfcLabel Country) : base (Purpose, Description, UserDefinedPurpose)
		{
			this.InternalLocation = InternalLocation;
			this.AddressLines = AddressLines;
			this.PostalBox = PostalBox;
			this.Town = Town;
			this.Region = Region;
			this.PostalCode = PostalCode;
			this.Country = Country;
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedColour
	/// <para>ENTITY IfcPreDefinedColour</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDraughtingPreDefinedColour))</para>
	/// <para> SUBTYPE OF (IfcPreDefinedItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPreDefinedColour : IfcPreDefinedItem, IfcColour
	{
		public IfcPreDefinedColour() : base()
		{
		}
		public IfcPreDefinedColour(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedCurveFont
	/// <para>ENTITY IfcPreDefinedCurveFont</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDraughtingPreDefinedCurveFont))</para>
	/// <para> SUBTYPE OF (IfcPreDefinedItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPreDefinedCurveFont : IfcPreDefinedItem, IfcCurveStyleFontSelect
	{
		public IfcPreDefinedCurveFont() : base()
		{
		}
		public IfcPreDefinedCurveFont(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedDimensionSymbol
	/// <para>ENTITY IfcPreDefinedDimensionSymbol</para>
	/// <para> SUBTYPE OF (IfcPreDefinedSymbol);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPreDefinedItem.Name IN ['arc length','conical taper','counterbore',</para>
	/// <para>                  'countersink','depth','diameter','plus minus','radius',</para>
	/// <para>                  'slope','spherical diameter','spherical radius','square'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPreDefinedDimensionSymbol : IfcPreDefinedSymbol
	{
		public IfcPreDefinedDimensionSymbol() : base()
		{
		}
		public IfcPreDefinedDimensionSymbol(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedItem
	/// <para>ENTITY IfcPreDefinedItem</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPreDefinedColour</para>
	/// <para>	,IfcPreDefinedCurveFont</para>
	/// <para>	,IfcPreDefinedSymbol</para>
	/// <para>	,IfcPreDefinedTextFont));</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPreDefinedItemENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcPreDefinedItem() : base()
		{
			Name = new IfcLabel();
		}
		public IfcPreDefinedItem(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedPointMarkerSymbol
	/// <para>ENTITY IfcPreDefinedPointMarkerSymbol</para>
	/// <para> SUBTYPE OF (IfcPreDefinedSymbol);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPreDefinedItem.Name IN ['asterisk','circle','dot','plus','square','triangle','x'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPreDefinedPointMarkerSymbol : IfcPreDefinedSymbol
	{
		public IfcPreDefinedPointMarkerSymbol() : base()
		{
		}
		public IfcPreDefinedPointMarkerSymbol(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedSymbol
	/// <para>ENTITY IfcPreDefinedSymbol</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPreDefinedDimensionSymbol</para>
	/// <para>	,IfcPreDefinedPointMarkerSymbol</para>
	/// <para>	,IfcPreDefinedTerminatorSymbol))</para>
	/// <para> SUBTYPE OF (IfcPreDefinedItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPreDefinedSymbol : IfcPreDefinedItem, IfcDefinedSymbolSelect
	{
		public IfcPreDefinedSymbol() : base()
		{
		}
		public IfcPreDefinedSymbol(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedTerminatorSymbol
	/// <para>ENTITY IfcPreDefinedTerminatorSymbol</para>
	/// <para> SUBTYPE OF (IfcPreDefinedSymbol);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SELF\IfcPreDefinedItem.Name IN ['blanked arrow','blanked box',</para>
	/// <para>                 'blanked dot','dimension origin','filled arrow','filled box',</para>
	/// <para>                 'filled dot','integral symbol','open arrow','slash','unfilled arrow'];</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPreDefinedTerminatorSymbol : IfcPreDefinedSymbol
	{
		public IfcPreDefinedTerminatorSymbol() : base()
		{
		}
		public IfcPreDefinedTerminatorSymbol(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPreDefinedTextFont
	/// <para>ENTITY IfcPreDefinedTextFont</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDraughtingPreDefinedTextFont</para>
	/// <para>	,IfcTextStyleFontModel))</para>
	/// <para> SUBTYPE OF (IfcPreDefinedItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPreDefinedTextFont : IfcPreDefinedItem, IfcTextFontSelect
	{
		public IfcPreDefinedTextFont() : base()
		{
		}
		public IfcPreDefinedTextFont(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPresentationLayerAssignment
	/// <para>ENTITY IfcPresentationLayerAssignment</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPresentationLayerWithStyle));</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	AssignedItems : SET [1:?] OF IfcLayeredItem;</para>
	/// <para>	Identifier : OPTIONAL IfcIdentifier;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPresentationLayerAssignmentENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public List<IfcLayeredItem> AssignedItems { get; set; }
		public IfcIdentifier? Identifier { get; set; }
		public IfcPresentationLayerAssignment() : base()
		{
			Name = new IfcLabel();
			AssignedItems = new List<IfcLayeredItem>();
		}
		public IfcPresentationLayerAssignment(IfcLabel Name, IfcText Description, List<IfcLayeredItem> AssignedItems, IfcIdentifier Identifier) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.AssignedItems = AssignedItems;
			this.Identifier = Identifier;
		}
	}
	/// <summary>
	/// ENTITY IfcPresentationLayerWithStyle
	/// <para>ENTITY IfcPresentationLayerWithStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationLayerAssignment);</para>
	/// <para>	LayerOn : LOGICAL;</para>
	/// <para>	LayerFrozen : LOGICAL;</para>
	/// <para>	LayerBlocked : LOGICAL;</para>
	/// <para>	LayerStyles : SET [0:?] OF IfcPresentationStyleSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPresentationLayerWithStyle : IfcPresentationLayerAssignment
	{
		public LOGICAL LayerOn { get; set; }
		public LOGICAL LayerFrozen { get; set; }
		public LOGICAL LayerBlocked { get; set; }
		public List<IfcPresentationStyleSelect> LayerStyles { get; set; }
		public IfcPresentationLayerWithStyle() : base()
		{
			LayerOn = new LOGICAL();
			LayerFrozen = new LOGICAL();
			LayerBlocked = new LOGICAL();
			LayerStyles = new List<IfcPresentationStyleSelect>();
		}
		public IfcPresentationLayerWithStyle(IfcLabel Name, IfcText Description, List<IfcLayeredItem> AssignedItems, IfcIdentifier Identifier, LOGICAL LayerOn, LOGICAL LayerFrozen, LOGICAL LayerBlocked, List<IfcPresentationStyleSelect> LayerStyles) : base (Name, Description, AssignedItems, Identifier)
		{
			this.LayerOn = LayerOn;
			this.LayerFrozen = LayerFrozen;
			this.LayerBlocked = LayerBlocked;
			this.LayerStyles = LayerStyles;
		}
	}
	/// <summary>
	/// ENTITY IfcPresentationStyle
	/// <para>ENTITY IfcPresentationStyle</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCurveStyle</para>
	/// <para>	,IfcFillAreaStyle</para>
	/// <para>	,IfcSurfaceStyle</para>
	/// <para>	,IfcSymbolStyle</para>
	/// <para>	,IfcTextStyle));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPresentationStyleENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcPresentationStyle() : base()
		{
		}
		public IfcPresentationStyle(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcPresentationStyleAssignment;
	/// <para>ENTITY IfcPresentationStyleAssignment;</para>
	/// <para>	Styles : SET [1:?] OF IfcPresentationStyleSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPresentationStyleAssignmentENTITY
	{
		public List<IfcPresentationStyleSelect> Styles { get; set; }
		public IfcPresentationStyleAssignment() : base()
		{
			Styles = new List<IfcPresentationStyleSelect>();
		}
		public IfcPresentationStyleAssignment(List<IfcPresentationStyleSelect> Styles) : base ()
		{
			this.Styles = Styles;
		}
	}
	/// <summary>
	/// ENTITY IfcProcedure
	/// <para>ENTITY IfcProcedure</para>
	/// <para> SUBTYPE OF (IfcProcess);</para>
	/// <para>	ProcedureID : IfcIdentifier;</para>
	/// <para>	ProcedureType : IfcProcedureTypeEnum;</para>
	/// <para>	UserDefinedProcedureType : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;</para>
	/// <para>	WR3 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>	WR4 : (ProcedureType <> IfcProcedureTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((ProcedureType = IfcProcedureTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcProcedure.UserDefinedProcedureType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProcedure : IfcProcess
	{
		public IfcIdentifier ProcedureID { get; set; }
		public IfcProcedureTypeEnum ProcedureType { get; set; }
		public IfcLabel? UserDefinedProcedureType { get; set; }
		public IfcProcedure() : base()
		{
			ProcedureID = new IfcIdentifier();
			ProcedureType = new IfcProcedureTypeEnum();
		}
		public IfcProcedure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ProcedureID, IfcProcedureTypeEnum ProcedureType, IfcLabel UserDefinedProcedureType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ProcedureID = ProcedureID;
			this.ProcedureType = ProcedureType;
			this.UserDefinedProcedureType = UserDefinedProcedureType;
		}
	}
	/// <summary>
	/// ENTITY IfcProcess
	/// <para>ENTITY IfcProcess</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcProcedure</para>
	/// <para>	,IfcTask))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para> INVERSE</para>
	/// <para>	OperatesOn : SET [0:?] OF IfcRelAssignsToProcess FOR RelatingProcess;</para>
	/// <para>	IsSuccessorFrom : SET [0:?] OF IfcRelSequence FOR RelatedProcess;</para>
	/// <para>	IsPredecessorTo : SET [0:?] OF IfcRelSequence FOR RelatingProcess;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcProcess : IfcObject
	{
		public IfcProcess() : base()
		{
		}
		public IfcProcess(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProduct
	/// <para>ENTITY IfcProduct</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAnnotation</para>
	/// <para>	,IfcElement</para>
	/// <para>	,IfcGrid</para>
	/// <para>	,IfcPort</para>
	/// <para>	,IfcProxy</para>
	/// <para>	,IfcSpatialStructureElement</para>
	/// <para>	,IfcStructuralActivity</para>
	/// <para>	,IfcStructuralItem))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para>	ObjectPlacement : OPTIONAL IfcObjectPlacement;</para>
	/// <para>	Representation : OPTIONAL IfcProductRepresentation;</para>
	/// <para> INVERSE</para>
	/// <para>	ReferencedBy : SET [0:?] OF IfcRelAssignsToProduct FOR RelatingProduct;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (EXISTS(Representation) AND EXISTS(ObjectPlacement))</para>
	/// <para>                        OR (EXISTS(Representation) AND </para>
	/// <para>                           (NOT('IFC2X3.IFCPRODUCTDEFINITIONSHAPE' IN TYPEOF(Representation))))</para>
	/// <para>                        OR (NOT(EXISTS(Representation)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcProduct : IfcObject
	{
		public IfcObjectPlacement? ObjectPlacement { get; set; }
		public IfcProductRepresentation? Representation { get; set; }
		public IfcProduct() : base()
		{
		}
		public IfcProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ObjectPlacement = ObjectPlacement;
			this.Representation = Representation;
		}
	}
	/// <summary>
	/// ENTITY IfcProductDefinitionShape
	/// <para>ENTITY IfcProductDefinitionShape</para>
	/// <para> SUBTYPE OF (IfcProductRepresentation);</para>
	/// <para> INVERSE</para>
	/// <para>	ShapeOfProduct : SET [1:1] OF IfcProduct FOR Representation;</para>
	/// <para>	HasShapeAspects : SET [0:?] OF IfcShapeAspect FOR PartOfProductDefinitionShape;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(temp <* Representations | </para>
	/// <para>               (NOT('IFC2X3.IFCSHAPEMODEL' IN TYPEOF(temp)))</para>
	/// <para>             )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProductDefinitionShape : IfcProductRepresentation
	{
		public IfcProductDefinitionShape() : base()
		{
		}
		public IfcProductDefinitionShape(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations) : base (Name, Description, Representations)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProductRepresentation
	/// <para>ENTITY IfcProductRepresentation</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMaterialDefinitionRepresentation</para>
	/// <para>	,IfcProductDefinitionShape));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	Representations : LIST [1:?] OF IfcRepresentation;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProductRepresentationENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public List<IfcRepresentation> Representations { get; set; }
		public IfcProductRepresentation() : base()
		{
			Representations = new List<IfcRepresentation>();
		}
		public IfcProductRepresentation(IfcLabel Name, IfcText Description, List<IfcRepresentation> Representations) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.Representations = Representations;
		}
	}
	/// <summary>
	/// ENTITY IfcProductsOfCombustionProperties
	/// <para>ENTITY IfcProductsOfCombustionProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	SpecificHeatCapacity : OPTIONAL IfcSpecificHeatCapacityMeasure;</para>
	/// <para>	N20Content : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	COContent : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	CO2Content : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProductsOfCombustionProperties : IfcMaterialProperties
	{
		public IfcSpecificHeatCapacityMeasure? SpecificHeatCapacity { get; set; }
		public IfcPositiveRatioMeasure? N20Content { get; set; }
		public IfcPositiveRatioMeasure? COContent { get; set; }
		public IfcPositiveRatioMeasure? CO2Content { get; set; }
		public IfcProductsOfCombustionProperties() : base()
		{
		}
		public IfcProductsOfCombustionProperties(IfcMaterial Material, IfcSpecificHeatCapacityMeasure SpecificHeatCapacity, IfcPositiveRatioMeasure N20Content, IfcPositiveRatioMeasure COContent, IfcPositiveRatioMeasure CO2Content) : base (Material)
		{
			this.SpecificHeatCapacity = SpecificHeatCapacity;
			this.N20Content = N20Content;
			this.COContent = COContent;
			this.CO2Content = CO2Content;
		}
	}
	/// <summary>
	/// ENTITY IfcProfileDef
	/// <para>ENTITY IfcProfileDef</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcArbitraryClosedProfileDef</para>
	/// <para>	,IfcArbitraryOpenProfileDef</para>
	/// <para>	,IfcCompositeProfileDef</para>
	/// <para>	,IfcDerivedProfileDef</para>
	/// <para>	,IfcParameterizedProfileDef));</para>
	/// <para>	ProfileType : IfcProfileTypeEnum;</para>
	/// <para>	ProfileName : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcProfileDefENTITY
	{
		public IfcProfileTypeEnum ProfileType { get; set; }
		public IfcLabel? ProfileName { get; set; }
		public IfcProfileDef() : base()
		{
			ProfileType = new IfcProfileTypeEnum();
		}
		public IfcProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName) : base ()
		{
			this.ProfileType = ProfileType;
			this.ProfileName = ProfileName;
		}
	}
	/// <summary>
	/// ENTITY IfcProfileProperties
	/// <para>ENTITY IfcProfileProperties</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGeneralProfileProperties</para>
	/// <para>	,IfcRibPlateProfileProperties));</para>
	/// <para>	ProfileName : OPTIONAL IfcLabel;</para>
	/// <para>	ProfileDefinition : OPTIONAL IfcProfileDef;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcProfilePropertiesENTITY
	{
		public IfcLabel? ProfileName { get; set; }
		public IfcProfileDef? ProfileDefinition { get; set; }
		public IfcProfileProperties() : base()
		{
		}
		public IfcProfileProperties(IfcLabel ProfileName, IfcProfileDef ProfileDefinition) : base ()
		{
			this.ProfileName = ProfileName;
			this.ProfileDefinition = ProfileDefinition;
		}
	}
	/// <summary>
	/// ENTITY IfcProject
	/// <para>ENTITY IfcProject</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para>	LongName : OPTIONAL IfcLabel;</para>
	/// <para>	Phase : OPTIONAL IfcLabel;</para>
	/// <para>	RepresentationContexts : SET [1:?] OF IfcRepresentationContext;</para>
	/// <para>	UnitsInContext : IfcUnitAssignment;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>	WR32 : SIZEOF(QUERY(Temp <* RepresentationContexts |</para>
	/// <para>              'IFC2X3.IFCGEOMETRICREPRESENTATIONSUBCONTEXT' IN TYPEOF(Temp)</para>
	/// <para>             )) = 0;</para>
	/// <para>	WR33 : SIZEOF(SELF\IfcObjectDefinition.Decomposes) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProject : IfcObject
	{
		public IfcLabel? LongName { get; set; }
		public IfcLabel? Phase { get; set; }
		public List<IfcRepresentationContext> RepresentationContexts { get; set; }
		public IfcUnitAssignment UnitsInContext { get; set; }
		public IfcProject() : base()
		{
			RepresentationContexts = new List<IfcRepresentationContext>();
			UnitsInContext = new IfcUnitAssignment();
		}
		public IfcProject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLabel LongName, IfcLabel Phase, List<IfcRepresentationContext> RepresentationContexts, IfcUnitAssignment UnitsInContext) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.LongName = LongName;
			this.Phase = Phase;
			this.RepresentationContexts = RepresentationContexts;
			this.UnitsInContext = UnitsInContext;
		}
	}
	/// <summary>
	/// ENTITY IfcProjectOrder
	/// <para>ENTITY IfcProjectOrder</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	ID : IfcIdentifier;</para>
	/// <para>	PredefinedType : IfcProjectOrderTypeEnum;</para>
	/// <para>	Status : OPTIONAL IfcLabel;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR2 : ID;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProjectOrder : IfcControl
	{
		public IfcIdentifier ID { get; set; }
		public IfcProjectOrderTypeEnum PredefinedType { get; set; }
		public IfcLabel? Status { get; set; }
		public IfcProjectOrder() : base()
		{
			ID = new IfcIdentifier();
			PredefinedType = new IfcProjectOrderTypeEnum();
		}
		public IfcProjectOrder(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ID, IfcProjectOrderTypeEnum PredefinedType, IfcLabel Status) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ID = ID;
			this.PredefinedType = PredefinedType;
			this.Status = Status;
		}
	}
	/// <summary>
	/// ENTITY IfcProjectOrderRecord
	/// <para>ENTITY IfcProjectOrderRecord</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	Records : LIST [1:?] OF UNIQUE IfcRelAssignsToProjectOrder;</para>
	/// <para>	PredefinedType : IfcProjectOrderRecordTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProjectOrderRecord : IfcControl
	{
		public IfcProjectOrderRecord() : base()
		{
		}
		public IfcProjectOrderRecord(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProjectionCurve
	/// <para>ENTITY IfcProjectionCurve</para>
	/// <para> SUBTYPE OF (IfcAnnotationCurveOccurrence);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProjectionCurve : IfcAnnotationCurveOccurrence
	{
		public IfcProjectionCurve() : base()
		{
		}
		public IfcProjectionCurve(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base (Item, Styles, Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProjectionElement
	/// <para>ENTITY IfcProjectionElement</para>
	/// <para> SUBTYPE OF (IfcFeatureElementAddition);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProjectionElement : IfcFeatureElementAddition
	{
		public IfcProjectionElement() : base()
		{
		}
		public IfcProjectionElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProperty
	/// <para>ENTITY IfcProperty</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcComplexProperty</para>
	/// <para>	,IfcSimpleProperty));</para>
	/// <para>	Name : IfcIdentifier;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para> INVERSE</para>
	/// <para>	PropertyForDependance : SET [0:?] OF IfcPropertyDependencyRelationship FOR DependingProperty;</para>
	/// <para>	PropertyDependsOn : SET [0:?] OF IfcPropertyDependencyRelationship FOR DependantProperty;</para>
	/// <para>	PartOfComplex : SET [0:1] OF IfcComplexProperty FOR HasProperties;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPropertyENTITY
	{
		public IfcIdentifier Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcProperty() : base()
		{
			Name = new IfcIdentifier();
		}
		public IfcProperty(IfcIdentifier Name, IfcText Description) : base ()
		{
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyBoundedValue
	/// <para>ENTITY IfcPropertyBoundedValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	UpperBoundValue : OPTIONAL IfcValue;</para>
	/// <para>	LowerBoundValue : OPTIONAL IfcValue;</para>
	/// <para>	Unit : OPTIONAL IfcUnit;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(UpperBoundValue)) OR NOT(EXISTS(LowerBoundValue)) OR</para>
	/// <para>             (TYPEOF(UpperBoundValue) = TYPEOF(LowerBoundValue));</para>
	/// <para>	WR22 : EXISTS(UpperBoundValue) OR EXISTS(LowerBoundValue);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyBoundedValue : IfcSimpleProperty
	{
		public IfcValue? UpperBoundValue { get; set; }
		public IfcValue? LowerBoundValue { get; set; }
		public IfcUnit? Unit { get; set; }
		public IfcPropertyBoundedValue() : base()
		{
		}
		public IfcPropertyBoundedValue(IfcIdentifier Name, IfcText Description, IfcValue UpperBoundValue, IfcValue LowerBoundValue, IfcUnit Unit) : base (Name, Description)
		{
			this.UpperBoundValue = UpperBoundValue;
			this.LowerBoundValue = LowerBoundValue;
			this.Unit = Unit;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyConstraintRelationship;
	/// <para>ENTITY IfcPropertyConstraintRelationship;</para>
	/// <para>	RelatingConstraint : IfcConstraint;</para>
	/// <para>	RelatedProperties : SET [1:?] OF IfcProperty;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyConstraintRelationshipENTITY
	{
		public IfcConstraint RelatingConstraint { get; set; }
		public List<IfcProperty> RelatedProperties { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcPropertyConstraintRelationship() : base()
		{
			RelatingConstraint = new IfcConstraint();
			RelatedProperties = new List<IfcProperty>();
		}
		public IfcPropertyConstraintRelationship(IfcConstraint RelatingConstraint, List<IfcProperty> RelatedProperties, IfcLabel Name, IfcText Description) : base ()
		{
			this.RelatingConstraint = RelatingConstraint;
			this.RelatedProperties = RelatedProperties;
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyDefinition
	/// <para>ENTITY IfcPropertyDefinition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPropertySetDefinition))</para>
	/// <para> SUBTYPE OF (IfcRoot);</para>
	/// <para> INVERSE</para>
	/// <para>	HasAssociations : SET [0:?] OF IfcRelAssociates FOR RelatedObjects;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPropertyDefinition : IfcRoot
	{
		public IfcPropertyDefinition() : base()
		{
		}
		public IfcPropertyDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base (GlobalId, OwnerHistory, Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyDependencyRelationship;
	/// <para>ENTITY IfcPropertyDependencyRelationship;</para>
	/// <para>	DependingProperty : IfcProperty;</para>
	/// <para>	DependantProperty : IfcProperty;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	Expression : OPTIONAL IfcText;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : DependingProperty :<>: DependantProperty;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyDependencyRelationshipENTITY
	{
		public IfcProperty DependingProperty { get; set; }
		public IfcProperty DependantProperty { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcText? Expression { get; set; }
		public IfcPropertyDependencyRelationship() : base()
		{
			DependingProperty = new IfcProperty();
			DependantProperty = new IfcProperty();
		}
		public IfcPropertyDependencyRelationship(IfcProperty DependingProperty, IfcProperty DependantProperty, IfcLabel Name, IfcText Description, IfcText Expression) : base ()
		{
			this.DependingProperty = DependingProperty;
			this.DependantProperty = DependantProperty;
			this.Name = Name;
			this.Description = Description;
			this.Expression = Expression;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyEnumeratedValue
	/// <para>ENTITY IfcPropertyEnumeratedValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	EnumerationValues : LIST [1:?] OF IfcValue;</para>
	/// <para>	EnumerationReference : OPTIONAL IfcPropertyEnumeration;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : NOT(EXISTS(EnumerationReference)) OR </para>
	/// <para>               (SIZEOF(QUERY(temp <* EnumerationValues |</para>
	/// <para>                temp IN EnumerationReference.EnumerationValues))</para>
	/// <para>                = SIZEOF(EnumerationValues));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyEnumeratedValue : IfcSimpleProperty
	{
		public List<IfcValue> EnumerationValues { get; set; }
		public IfcPropertyEnumeration? EnumerationReference { get; set; }
		public IfcPropertyEnumeratedValue() : base()
		{
			EnumerationValues = new List<IfcValue>();
		}
		public IfcPropertyEnumeratedValue(IfcIdentifier Name, IfcText Description, List<IfcValue> EnumerationValues, IfcPropertyEnumeration EnumerationReference) : base (Name, Description)
		{
			this.EnumerationValues = EnumerationValues;
			this.EnumerationReference = EnumerationReference;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyEnumeration;
	/// <para>ENTITY IfcPropertyEnumeration;</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	EnumerationValues : LIST [1:?] OF UNIQUE IfcValue;</para>
	/// <para>	Unit : OPTIONAL IfcUnit;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR1 : Name;</para>
	/// <para> WHERE</para>
	/// <para>	WR01 : SIZEOF(QUERY(temp <* SELF.EnumerationValues | </para>
	/// <para>               NOT(TYPEOF(SELF.EnumerationValues[1]) = TYPEOF(temp))</para>
	/// <para>               )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyEnumerationENTITY
	{
		public IfcLabel Name { get; set; }
		public IfcPropertyEnumeration() : base()
		{
			Name = new IfcLabel();
		}
		public IfcPropertyEnumeration(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyListValue
	/// <para>ENTITY IfcPropertyListValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	ListValues : LIST [1:?] OF IfcValue;</para>
	/// <para>	Unit : OPTIONAL IfcUnit;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SIZEOF(QUERY(temp <* SELF.ListValues | </para>
	/// <para>               NOT(TYPEOF(SELF.ListValues[1]) = TYPEOF(temp))</para>
	/// <para>               )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyListValue : IfcSimpleProperty
	{
		public List<IfcValue> ListValues { get; set; }
		public IfcUnit? Unit { get; set; }
		public IfcPropertyListValue() : base()
		{
			ListValues = new List<IfcValue>();
		}
		public IfcPropertyListValue(IfcIdentifier Name, IfcText Description, List<IfcValue> ListValues, IfcUnit Unit) : base (Name, Description)
		{
			this.ListValues = ListValues;
			this.Unit = Unit;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyReferenceValue
	/// <para>ENTITY IfcPropertyReferenceValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	UsageName : OPTIONAL IfcLabel;</para>
	/// <para>	PropertyReference : IfcObjectReferenceSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyReferenceValue : IfcSimpleProperty
	{
		public IfcLabel? UsageName { get; set; }
		public IfcObjectReferenceSelect PropertyReference { get; set; }
		public IfcPropertyReferenceValue() : base()
		{
			PropertyReference = new IfcObjectReferenceSelect();
		}
		public IfcPropertyReferenceValue(IfcIdentifier Name, IfcText Description, IfcLabel UsageName, IfcObjectReferenceSelect PropertyReference) : base (Name, Description)
		{
			this.UsageName = UsageName;
			this.PropertyReference = PropertyReference;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertySet
	/// <para>ENTITY IfcPropertySet</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	HasProperties : SET [1:?] OF IfcProperty;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>	WR32 : IfcUniquePropertyName(HasProperties);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertySet : IfcPropertySetDefinition
	{
		public List<IfcProperty> HasProperties { get; set; }
		public IfcPropertySet() : base()
		{
			HasProperties = new List<IfcProperty>();
		}
		public IfcPropertySet(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProperty> HasProperties) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.HasProperties = HasProperties;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertySetDefinition
	/// <para>ENTITY IfcPropertySetDefinition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDoorLiningProperties</para>
	/// <para>	,IfcDoorPanelProperties</para>
	/// <para>	,IfcElementQuantity</para>
	/// <para>	,IfcEnergyProperties</para>
	/// <para>	,IfcFluidFlowProperties</para>
	/// <para>	,IfcPermeableCoveringProperties</para>
	/// <para>	,IfcPropertySet</para>
	/// <para>	,IfcReinforcementDefinitionProperties</para>
	/// <para>	,IfcServiceLifeFactor</para>
	/// <para>	,IfcSoundProperties</para>
	/// <para>	,IfcSoundValue</para>
	/// <para>	,IfcSpaceThermalLoadProperties</para>
	/// <para>	,IfcWindowLiningProperties</para>
	/// <para>	,IfcWindowPanelProperties))</para>
	/// <para> SUBTYPE OF (IfcPropertyDefinition);</para>
	/// <para> INVERSE</para>
	/// <para>	PropertyDefinitionOf : SET [0:1] OF IfcRelDefinesByProperties FOR RelatingPropertyDefinition;</para>
	/// <para>	DefinesType : SET [0:1] OF IfcTypeObject FOR HasPropertySets;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcPropertySetDefinition : IfcPropertyDefinition
	{
		public IfcPropertySetDefinition() : base()
		{
		}
		public IfcPropertySetDefinition(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base (GlobalId, OwnerHistory, Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcPropertySingleValue
	/// <para>ENTITY IfcPropertySingleValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	NominalValue : OPTIONAL IfcValue;</para>
	/// <para>	Unit : OPTIONAL IfcUnit;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertySingleValue : IfcSimpleProperty
	{
		public IfcValue? NominalValue { get; set; }
		public IfcUnit? Unit { get; set; }
		public IfcPropertySingleValue() : base()
		{
		}
		public IfcPropertySingleValue(IfcIdentifier Name, IfcText Description, IfcValue NominalValue, IfcUnit Unit) : base (Name, Description)
		{
			this.NominalValue = NominalValue;
			this.Unit = Unit;
		}
	}
	/// <summary>
	/// ENTITY IfcPropertyTableValue
	/// <para>ENTITY IfcPropertyTableValue</para>
	/// <para> SUBTYPE OF (IfcSimpleProperty);</para>
	/// <para>	DefiningValues : LIST [1:?] OF UNIQUE IfcValue;</para>
	/// <para>	DefinedValues : LIST [1:?] OF IfcValue;</para>
	/// <para>	Expression : OPTIONAL IfcText;</para>
	/// <para>	DefiningUnit : OPTIONAL IfcUnit;</para>
	/// <para>	DefinedUnit : OPTIONAL IfcUnit;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(DefiningValues) = SIZEOF(DefinedValues);</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* SELF.DefiningValues | TYPEOF(temp) <> TYPEOF(SELF.DefiningValues[1])))=0;</para>
	/// <para>	WR3 : SIZEOF(QUERY(temp <* SELF.DefinedValues | TYPEOF(temp) <> TYPEOF(SELF.DefinedValues[1])))=0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPropertyTableValue : IfcSimpleProperty
	{
		public IfcPropertyTableValue() : base()
		{
		}
		public IfcPropertyTableValue(IfcIdentifier Name, IfcText Description) : base (Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcProtectiveDeviceType
	/// <para>ENTITY IfcProtectiveDeviceType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcProtectiveDeviceTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProtectiveDeviceType : IfcFlowControllerType
	{
		public IfcProtectiveDeviceTypeEnum PredefinedType { get; set; }
		public IfcProtectiveDeviceType() : base()
		{
			PredefinedType = new IfcProtectiveDeviceTypeEnum();
		}
		public IfcProtectiveDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcProtectiveDeviceTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcProxy
	/// <para>ENTITY IfcProxy</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para>	ProxyType : IfcObjectTypeEnum;</para>
	/// <para>	Tag : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcProxy : IfcProduct
	{
		public IfcObjectTypeEnum ProxyType { get; set; }
		public IfcLabel? Tag { get; set; }
		public IfcProxy() : base()
		{
			ProxyType = new IfcObjectTypeEnum();
		}
		public IfcProxy(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcObjectTypeEnum ProxyType, IfcLabel Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.ProxyType = ProxyType;
			this.Tag = Tag;
		}
	}
	/// <summary>
	/// ENTITY IfcPumpType
	/// <para>ENTITY IfcPumpType</para>
	/// <para> SUBTYPE OF (IfcFlowMovingDeviceType);</para>
	/// <para>	PredefinedType : IfcPumpTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcPumpTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcPumpTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcPumpType : IfcFlowMovingDeviceType
	{
		public IfcPumpTypeEnum PredefinedType { get; set; }
		public IfcPumpType() : base()
		{
			PredefinedType = new IfcPumpTypeEnum();
		}
		public IfcPumpType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcPumpTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityArea
	/// <para>ENTITY IfcQuantityArea</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	AreaValue : IfcAreaMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(SELF\IfcPhysicalSimpleQuantity.Unit)) OR</para>
	/// <para>                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.AREAUNIT);</para>
	/// <para>	WR22 : AreaValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityArea : IfcPhysicalSimpleQuantity
	{
		public IfcAreaMeasure AreaValue { get; set; }
		public IfcQuantityArea() : base()
		{
			AreaValue = new IfcAreaMeasure();
		}
		public IfcQuantityArea(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcAreaMeasure AreaValue) : base (Name, Description, Unit)
		{
			this.AreaValue = AreaValue;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityCount
	/// <para>ENTITY IfcQuantityCount</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	CountValue : IfcCountMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : CountValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityCount : IfcPhysicalSimpleQuantity
	{
		public IfcCountMeasure CountValue { get; set; }
		public IfcQuantityCount() : base()
		{
			CountValue = new IfcCountMeasure();
		}
		public IfcQuantityCount(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcCountMeasure CountValue) : base (Name, Description, Unit)
		{
			this.CountValue = CountValue;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityLength
	/// <para>ENTITY IfcQuantityLength</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	LengthValue : IfcLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(SELF\IfcPhysicalSimpleQuantity.Unit)) OR</para>
	/// <para>                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.LENGTHUNIT);</para>
	/// <para>	WR22 : LengthValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityLength : IfcPhysicalSimpleQuantity
	{
		public IfcLengthMeasure LengthValue { get; set; }
		public IfcQuantityLength() : base()
		{
			LengthValue = new IfcLengthMeasure();
		}
		public IfcQuantityLength(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcLengthMeasure LengthValue) : base (Name, Description, Unit)
		{
			this.LengthValue = LengthValue;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityTime
	/// <para>ENTITY IfcQuantityTime</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	TimeValue : IfcTimeMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(SELF\IfcPhysicalSimpleQuantity.Unit)) OR</para>
	/// <para>                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.TIMEUNIT);</para>
	/// <para>	WR22 : TimeValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityTime : IfcPhysicalSimpleQuantity
	{
		public IfcTimeMeasure TimeValue { get; set; }
		public IfcQuantityTime() : base()
		{
			TimeValue = new IfcTimeMeasure();
		}
		public IfcQuantityTime(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcTimeMeasure TimeValue) : base (Name, Description, Unit)
		{
			this.TimeValue = TimeValue;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityVolume
	/// <para>ENTITY IfcQuantityVolume</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	VolumeValue : IfcVolumeMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(SELF\IfcPhysicalSimpleQuantity.Unit)) OR</para>
	/// <para>                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.VOLUMEUNIT);</para>
	/// <para>	WR22 : VolumeValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityVolume : IfcPhysicalSimpleQuantity
	{
		public IfcVolumeMeasure VolumeValue { get; set; }
		public IfcQuantityVolume() : base()
		{
			VolumeValue = new IfcVolumeMeasure();
		}
		public IfcQuantityVolume(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcVolumeMeasure VolumeValue) : base (Name, Description, Unit)
		{
			this.VolumeValue = VolumeValue;
		}
	}
	/// <summary>
	/// ENTITY IfcQuantityWeight
	/// <para>ENTITY IfcQuantityWeight</para>
	/// <para> SUBTYPE OF (IfcPhysicalSimpleQuantity);</para>
	/// <para>	WeightValue : IfcMassMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(SELF\IfcPhysicalSimpleQuantity.Unit)) OR</para>
	/// <para>                (SELF\IfcPhysicalSimpleQuantity.Unit.UnitType = IfcUnitEnum.MASSUNIT);</para>
	/// <para>	WR22 : WeightValue >= 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcQuantityWeight : IfcPhysicalSimpleQuantity
	{
		public IfcMassMeasure WeightValue { get; set; }
		public IfcQuantityWeight() : base()
		{
			WeightValue = new IfcMassMeasure();
		}
		public IfcQuantityWeight(IfcLabel Name, IfcText Description, IfcNamedUnit Unit, IfcMassMeasure WeightValue) : base (Name, Description, Unit)
		{
			this.WeightValue = WeightValue;
		}
	}
	/// <summary>
	/// ENTITY IfcRadiusDimension
	/// <para>ENTITY IfcRadiusDimension</para>
	/// <para> SUBTYPE OF (IfcDimensionCurveDirectedCallout);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRadiusDimension : IfcDimensionCurveDirectedCallout
	{
		public IfcRadiusDimension() : base()
		{
		}
		public IfcRadiusDimension(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRailing
	/// <para>ENTITY IfcRailing</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	PredefinedType : OPTIONAL IfcRailingTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : NOT(EXISTS(PredefinedType)) OR</para>
	/// <para>              (PredefinedType <> IfcRailingTypeEnum.USERDEFINED) OR</para>
	/// <para>              ((PredefinedType = IfcRailingTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRailing : IfcBuildingElement
	{
		public IfcRailingTypeEnum? PredefinedType { get; set; }
		public IfcRailing() : base()
		{
		}
		public IfcRailing(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRailingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcRailingType
	/// <para>ENTITY IfcRailingType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcRailingTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRailingType : IfcBuildingElementType
	{
		public IfcRailingTypeEnum PredefinedType { get; set; }
		public IfcRailingType() : base()
		{
			PredefinedType = new IfcRailingTypeEnum();
		}
		public IfcRailingType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcRailingTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcRamp
	/// <para>ENTITY IfcRamp</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	ShapeType : IfcRampTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 0) OR </para>
	/// <para>            ((HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 1) AND (NOT(EXISTS(SELF\IfcProduct.Representation))));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRamp : IfcBuildingElement
	{
		public IfcRampTypeEnum ShapeType { get; set; }
		public IfcRamp() : base()
		{
			ShapeType = new IfcRampTypeEnum();
		}
		public IfcRamp(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRampTypeEnum ShapeType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.ShapeType = ShapeType;
		}
	}
	/// <summary>
	/// ENTITY IfcRampFlight
	/// <para>ENTITY IfcRampFlight</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRampFlight : IfcBuildingElement
	{
		public IfcRampFlight() : base()
		{
		}
		public IfcRampFlight(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRampFlightType
	/// <para>ENTITY IfcRampFlightType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcRampFlightTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRampFlightType : IfcBuildingElementType
	{
		public IfcRampFlightTypeEnum PredefinedType { get; set; }
		public IfcRampFlightType() : base()
		{
			PredefinedType = new IfcRampFlightTypeEnum();
		}
		public IfcRampFlightType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcRampFlightTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcRationalBezierCurve
	/// <para>ENTITY IfcRationalBezierCurve</para>
	/// <para> SUBTYPE OF (IfcBezierCurve);</para>
	/// <para>	WeightsData : LIST [2:?] OF REAL;</para>
	/// <para> DERIVE</para>
	/// <para>	Weights : ARRAY [0:255] OF REAL := IfcListToArray(WeightsData,0,SELF\IfcBSplineCurve.UpperIndexOnControlPoints);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(WeightsData) = SIZEOF(SELF\IfcBSplineCurve.ControlPointsList);</para>
	/// <para>	WR2 : IfcCurveWeightsPositive(SELF);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRationalBezierCurve : IfcBezierCurve
	{
		public List<REAL> WeightsData { get; set; }
		public IfcRationalBezierCurve() : base()
		{
			WeightsData = new List<REAL>();
		}
		public IfcRationalBezierCurve(INTEGER Degree, List<IfcCartesianPoint> ControlPointsList, IfcBSplineCurveForm CurveForm, LOGICAL ClosedCurve, LOGICAL SelfIntersect, List<REAL> WeightsData) : base (Degree, ControlPointsList, CurveForm, ClosedCurve, SelfIntersect)
		{
			this.WeightsData = WeightsData;
		}
	}
	/// <summary>
	/// ENTITY IfcRectangleHollowProfileDef
	/// <para>ENTITY IfcRectangleHollowProfileDef</para>
	/// <para> SUBTYPE OF (IfcRectangleProfileDef);</para>
	/// <para>	WallThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	InnerFilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	OuterFilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : (WallThickness < (SELF\IfcRectangleProfileDef.XDim/2.)) AND </para>
	/// <para>             (WallThickness < (SELF\IfcRectangleProfileDef.YDim/2.));</para>
	/// <para>	WR32 : NOT(EXISTS(OuterFilletRadius)) OR </para>
	/// <para>             ((OuterFilletRadius <= (SELF\IfcRectangleProfileDef.XDim/2.)) AND </para>
	/// <para>              (OuterFilletRadius <= (SELF\IfcRectangleProfileDef.YDim/2.)));</para>
	/// <para>	WR33 : NOT(EXISTS(InnerFilletRadius)) OR </para>
	/// <para>             ((InnerFilletRadius <= (SELF\IfcRectangleProfileDef.XDim/2. - WallThickness)) AND </para>
	/// <para>              (InnerFilletRadius <= (SELF\IfcRectangleProfileDef.YDim/2. - WallThickness)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRectangleHollowProfileDef : IfcRectangleProfileDef
	{
		public IfcPositiveLengthMeasure WallThickness { get; set; }
		public IfcPositiveLengthMeasure? InnerFilletRadius { get; set; }
		public IfcPositiveLengthMeasure? OuterFilletRadius { get; set; }
		public IfcRectangleHollowProfileDef() : base()
		{
			WallThickness = new IfcPositiveLengthMeasure();
		}
		public IfcRectangleHollowProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure WallThickness, IfcPositiveLengthMeasure InnerFilletRadius, IfcPositiveLengthMeasure OuterFilletRadius) : base (ProfileType, ProfileName, Position, XDim, YDim)
		{
			this.WallThickness = WallThickness;
			this.InnerFilletRadius = InnerFilletRadius;
			this.OuterFilletRadius = OuterFilletRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcRectangleProfileDef
	/// <para>ENTITY IfcRectangleProfileDef</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRectangleHollowProfileDef</para>
	/// <para>	,IfcRoundedRectangleProfileDef))</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	XDim : IfcPositiveLengthMeasure;</para>
	/// <para>	YDim : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRectangleProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure XDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }
		public IfcRectangleProfileDef() : base()
		{
			XDim = new IfcPositiveLengthMeasure();
			YDim = new IfcPositiveLengthMeasure();
		}
		public IfcRectangleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim) : base (ProfileType, ProfileName, Position)
		{
			this.XDim = XDim;
			this.YDim = YDim;
		}
	}
	/// <summary>
	/// ENTITY IfcRectangularPyramid
	/// <para>ENTITY IfcRectangularPyramid</para>
	/// <para> SUBTYPE OF (IfcCsgPrimitive3D);</para>
	/// <para>	XLength : IfcPositiveLengthMeasure;</para>
	/// <para>	YLength : IfcPositiveLengthMeasure;</para>
	/// <para>	Height : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRectangularPyramid : IfcCsgPrimitive3D
	{
		public IfcPositiveLengthMeasure XLength { get; set; }
		public IfcPositiveLengthMeasure YLength { get; set; }
		public IfcPositiveLengthMeasure Height { get; set; }
		public IfcRectangularPyramid() : base()
		{
			XLength = new IfcPositiveLengthMeasure();
			YLength = new IfcPositiveLengthMeasure();
			Height = new IfcPositiveLengthMeasure();
		}
		public IfcRectangularPyramid(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure XLength, IfcPositiveLengthMeasure YLength, IfcPositiveLengthMeasure Height) : base (Position)
		{
			this.XLength = XLength;
			this.YLength = YLength;
			this.Height = Height;
		}
	}
	/// <summary>
	/// ENTITY IfcRectangularTrimmedSurface
	/// <para>ENTITY IfcRectangularTrimmedSurface</para>
	/// <para> SUBTYPE OF (IfcBoundedSurface);</para>
	/// <para>	BasisSurface : IfcSurface;</para>
	/// <para>	U1 : IfcParameterValue;</para>
	/// <para>	V1 : IfcParameterValue;</para>
	/// <para>	U2 : IfcParameterValue;</para>
	/// <para>	V2 : IfcParameterValue;</para>
	/// <para>	Usense : BOOLEAN;</para>
	/// <para>	Vsense : BOOLEAN;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := BasisSurface.Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : U1 <> U2;</para>
	/// <para>	WR2 : V1 <> V2;</para>
	/// <para>	WR3 : (('IFC2X3.IFCELEMENTARYSURFACE' IN TYPEOF(BasisSurface)) AND</para>
	/// <para>                     (NOT ('IFC2X3.IFCPLANE' IN TYPEOF(BasisSurface)))) OR</para>
	/// <para>                     ('IFC2X3.IFCSURFACEOFREVOLUTION' IN TYPEOF(BasisSurface)) OR</para>
	/// <para>                     (Usense = (U2 > U1));</para>
	/// <para>	WR4 : Vsense = (V2 > V1);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRectangularTrimmedSurface : IfcBoundedSurface
	{
		public IfcSurface BasisSurface { get; set; }
		public IfcParameterValue U1 { get; set; }
		public IfcParameterValue V1 { get; set; }
		public IfcParameterValue U2 { get; set; }
		public IfcParameterValue V2 { get; set; }
		public BOOLEAN Usense { get; set; }
		public BOOLEAN Vsense { get; set; }
		public IfcRectangularTrimmedSurface() : base()
		{
			BasisSurface = new IfcSurface();
			U1 = new IfcParameterValue();
			V1 = new IfcParameterValue();
			U2 = new IfcParameterValue();
			V2 = new IfcParameterValue();
			Usense = new BOOLEAN();
			Vsense = new BOOLEAN();
		}
		public IfcRectangularTrimmedSurface(IfcSurface BasisSurface, IfcParameterValue U1, IfcParameterValue V1, IfcParameterValue U2, IfcParameterValue V2, BOOLEAN Usense, BOOLEAN Vsense) : base ()
		{
			this.BasisSurface = BasisSurface;
			this.U1 = U1;
			this.V1 = V1;
			this.U2 = U2;
			this.V2 = V2;
			this.Usense = Usense;
			this.Vsense = Vsense;
		}
	}
	/// <summary>
	/// ENTITY IfcReferencesValueDocument;
	/// <para>ENTITY IfcReferencesValueDocument;</para>
	/// <para>	ReferencedDocument : IfcDocumentSelect;</para>
	/// <para>	ReferencingValues : SET [1:?] OF IfcAppliedValue;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcReferencesValueDocumentENTITY
	{
		public IfcDocumentSelect ReferencedDocument { get; set; }
		public List<IfcAppliedValue> ReferencingValues { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcReferencesValueDocument() : base()
		{
			ReferencedDocument = new IfcDocumentSelect();
			ReferencingValues = new List<IfcAppliedValue>();
		}
		public IfcReferencesValueDocument(IfcDocumentSelect ReferencedDocument, List<IfcAppliedValue> ReferencingValues, IfcLabel Name, IfcText Description) : base ()
		{
			this.ReferencedDocument = ReferencedDocument;
			this.ReferencingValues = ReferencingValues;
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcRegularTimeSeries
	/// <para>ENTITY IfcRegularTimeSeries</para>
	/// <para> SUBTYPE OF (IfcTimeSeries);</para>
	/// <para>	TimeStep : IfcTimeMeasure;</para>
	/// <para>	Values : LIST [1:?] OF IfcTimeSeriesValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRegularTimeSeries : IfcTimeSeries
	{
		public IfcTimeMeasure TimeStep { get; set; }
		public List<IfcTimeSeriesValue> Values { get; set; }
		public IfcRegularTimeSeries() : base()
		{
			TimeStep = new IfcTimeMeasure();
			Values = new List<IfcTimeSeriesValue>();
		}
		public IfcRegularTimeSeries(IfcLabel Name, IfcText Description, IfcDateTimeSelect StartTime, IfcDateTimeSelect EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit, IfcTimeMeasure TimeStep, List<IfcTimeSeriesValue> Values) : base (Name, Description, StartTime, EndTime, TimeSeriesDataType, DataOrigin, UserDefinedDataOrigin, Unit)
		{
			this.TimeStep = TimeStep;
			this.Values = Values;
		}
	}
	/// <summary>
	/// ENTITY IfcReinforcementBarProperties;
	/// <para>ENTITY IfcReinforcementBarProperties;</para>
	/// <para>	TotalCrossSectionArea : IfcAreaMeasure;</para>
	/// <para>	SteelGrade : IfcLabel;</para>
	/// <para>	BarSurface : OPTIONAL IfcReinforcingBarSurfaceEnum;</para>
	/// <para>	EffectiveDepth : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	NominalBarDiameter : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	BarCount : OPTIONAL IfcCountMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcReinforcementBarPropertiesENTITY
	{
		public IfcAreaMeasure TotalCrossSectionArea { get; set; }
		public IfcLabel SteelGrade { get; set; }
		public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; }
		public IfcLengthMeasure? EffectiveDepth { get; set; }
		public IfcPositiveLengthMeasure? NominalBarDiameter { get; set; }
		public IfcCountMeasure? BarCount { get; set; }
		public IfcReinforcementBarProperties() : base()
		{
			TotalCrossSectionArea = new IfcAreaMeasure();
			SteelGrade = new IfcLabel();
		}
		public IfcReinforcementBarProperties(IfcAreaMeasure TotalCrossSectionArea, IfcLabel SteelGrade, IfcReinforcingBarSurfaceEnum BarSurface, IfcLengthMeasure EffectiveDepth, IfcPositiveLengthMeasure NominalBarDiameter, IfcCountMeasure BarCount) : base ()
		{
			this.TotalCrossSectionArea = TotalCrossSectionArea;
			this.SteelGrade = SteelGrade;
			this.BarSurface = BarSurface;
			this.EffectiveDepth = EffectiveDepth;
			this.NominalBarDiameter = NominalBarDiameter;
			this.BarCount = BarCount;
		}
	}
	/// <summary>
	/// ENTITY IfcReinforcementDefinitionProperties
	/// <para>ENTITY IfcReinforcementDefinitionProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	DefinitionType : OPTIONAL IfcLabel;</para>
	/// <para>	ReinforcementSectionDefinitions : LIST [1:?] OF IfcSectionReinforcementProperties;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcReinforcementDefinitionProperties : IfcPropertySetDefinition
	{
		public IfcLabel? DefinitionType { get; set; }
		public List<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions { get; set; }
		public IfcReinforcementDefinitionProperties() : base()
		{
			ReinforcementSectionDefinitions = new List<IfcSectionReinforcementProperties>();
		}
		public IfcReinforcementDefinitionProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel DefinitionType, List<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.DefinitionType = DefinitionType;
			this.ReinforcementSectionDefinitions = ReinforcementSectionDefinitions;
		}
	}
	/// <summary>
	/// ENTITY IfcReinforcingBar
	/// <para>ENTITY IfcReinforcingBar</para>
	/// <para> SUBTYPE OF (IfcReinforcingElement);</para>
	/// <para>	NominalDiameter : IfcPositiveLengthMeasure;</para>
	/// <para>	CrossSectionArea : IfcAreaMeasure;</para>
	/// <para>	BarLength : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	BarRole : IfcReinforcingBarRoleEnum;</para>
	/// <para>	BarSurface : OPTIONAL IfcReinforcingBarSurfaceEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (BarRole <> IfcReinforcingBarRoleEnum.USERDEFINED) OR ((BarRole = IfcReinforcingBarRoleEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcReinforcingBar : IfcReinforcingElement
	{
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure? BarLength { get; set; }
		public IfcReinforcingBarRoleEnum BarRole { get; set; }
		public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; }
		public IfcReinforcingBar() : base()
		{
			NominalDiameter = new IfcPositiveLengthMeasure();
			CrossSectionArea = new IfcAreaMeasure();
			BarRole = new IfcReinforcingBarRoleEnum();
		}
		public IfcReinforcingBar(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcPositiveLengthMeasure BarLength, IfcReinforcingBarRoleEnum BarRole, IfcReinforcingBarSurfaceEnum BarSurface) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, SteelGrade)
		{
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.BarLength = BarLength;
			this.BarRole = BarRole;
			this.BarSurface = BarSurface;
		}
	}
	/// <summary>
	/// ENTITY IfcReinforcingElement
	/// <para>ENTITY IfcReinforcingElement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcReinforcingBar</para>
	/// <para>	,IfcReinforcingMesh</para>
	/// <para>	,IfcTendon</para>
	/// <para>	,IfcTendonAnchor))</para>
	/// <para> SUBTYPE OF (IfcBuildingElementComponent);</para>
	/// <para>	SteelGrade : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcReinforcingElement : IfcBuildingElementComponent
	{
		public IfcLabel? SteelGrade { get; set; }
		public IfcReinforcingElement() : base()
		{
		}
		public IfcReinforcingElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.SteelGrade = SteelGrade;
		}
	}
	/// <summary>
	/// ENTITY IfcReinforcingMesh
	/// <para>ENTITY IfcReinforcingMesh</para>
	/// <para> SUBTYPE OF (IfcReinforcingElement);</para>
	/// <para>	MeshLength : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	MeshWidth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	LongitudinalBarNominalDiameter : IfcPositiveLengthMeasure;</para>
	/// <para>	TransverseBarNominalDiameter : IfcPositiveLengthMeasure;</para>
	/// <para>	LongitudinalBarCrossSectionArea : IfcAreaMeasure;</para>
	/// <para>	TransverseBarCrossSectionArea : IfcAreaMeasure;</para>
	/// <para>	LongitudinalBarSpacing : IfcPositiveLengthMeasure;</para>
	/// <para>	TransverseBarSpacing : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcReinforcingMesh : IfcReinforcingElement
	{
		public IfcPositiveLengthMeasure? MeshLength { get; set; }
		public IfcPositiveLengthMeasure? MeshWidth { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; }
		public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; }
		public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; }
		public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; }
		public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; }
		public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; }
		public IfcReinforcingMesh() : base()
		{
			LongitudinalBarNominalDiameter = new IfcPositiveLengthMeasure();
			TransverseBarNominalDiameter = new IfcPositiveLengthMeasure();
			LongitudinalBarCrossSectionArea = new IfcAreaMeasure();
			TransverseBarCrossSectionArea = new IfcAreaMeasure();
			LongitudinalBarSpacing = new IfcPositiveLengthMeasure();
			TransverseBarSpacing = new IfcPositiveLengthMeasure();
		}
		public IfcReinforcingMesh(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcPositiveLengthMeasure MeshLength, IfcPositiveLengthMeasure MeshWidth, IfcPositiveLengthMeasure LongitudinalBarNominalDiameter, IfcPositiveLengthMeasure TransverseBarNominalDiameter, IfcAreaMeasure LongitudinalBarCrossSectionArea, IfcAreaMeasure TransverseBarCrossSectionArea, IfcPositiveLengthMeasure LongitudinalBarSpacing, IfcPositiveLengthMeasure TransverseBarSpacing) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, SteelGrade)
		{
			this.MeshLength = MeshLength;
			this.MeshWidth = MeshWidth;
			this.LongitudinalBarNominalDiameter = LongitudinalBarNominalDiameter;
			this.TransverseBarNominalDiameter = TransverseBarNominalDiameter;
			this.LongitudinalBarCrossSectionArea = LongitudinalBarCrossSectionArea;
			this.TransverseBarCrossSectionArea = TransverseBarCrossSectionArea;
			this.LongitudinalBarSpacing = LongitudinalBarSpacing;
			this.TransverseBarSpacing = TransverseBarSpacing;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAggregates
	/// <para>ENTITY IfcRelAggregates</para>
	/// <para> SUBTYPE OF (IfcRelDecomposes);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAggregates : IfcRelDecomposes
	{
		public IfcRelAggregates() : base()
		{
		}
		public IfcRelAggregates(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcObjectDefinition RelatingObject, List<IfcObjectDefinition> RelatedObjects) : base (GlobalId, OwnerHistory, Name, Description, RelatingObject, RelatedObjects)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssigns
	/// <para>ENTITY IfcRelAssigns</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelAssignsToActor</para>
	/// <para>	,IfcRelAssignsToControl</para>
	/// <para>	,IfcRelAssignsToGroup</para>
	/// <para>	,IfcRelAssignsToProcess</para>
	/// <para>	,IfcRelAssignsToProduct</para>
	/// <para>	,IfcRelAssignsToResource))</para>
	/// <para> SUBTYPE OF (IfcRelationship);</para>
	/// <para>	RelatedObjects : SET [1:?] OF IfcObjectDefinition;</para>
	/// <para>	RelatedObjectsType : OPTIONAL IfcObjectTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : IfcCorrectObjectAssignment(RelatedObjectsType, RelatedObjects);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRelAssigns : IfcRelationship
	{
		public List<IfcObjectDefinition> RelatedObjects { get; set; }
		public IfcObjectTypeEnum? RelatedObjectsType { get; set; }
		public IfcRelAssigns() : base()
		{
			RelatedObjects = new List<IfcObjectDefinition>();
		}
		public IfcRelAssigns(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedObjects = RelatedObjects;
			this.RelatedObjectsType = RelatedObjectsType;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsTasks
	/// <para>ENTITY IfcRelAssignsTasks</para>
	/// <para> SUBTYPE OF (IfcRelAssignsToControl);</para>
	/// <para>	TimeForTask : OPTIONAL IfcScheduleTimeControl;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : HIINDEX(SELF\IfcRelAssigns.RelatedObjects) = 1;</para>
	/// <para>	WR2 : 'IFC2X3.IFCTASK' IN TYPEOF(SELF\IfcRelAssigns.RelatedObjects[1]);</para>
	/// <para>	WR3 : 'IFC2X3.IFCWORKCONTROL' IN TYPEOF(SELF\IfcRelAssignsToControl.RelatingControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsTasks : IfcRelAssignsToControl
	{
		public IfcScheduleTimeControl? TimeForTask { get; set; }
		public IfcRelAssignsTasks() : base()
		{
		}
		public IfcRelAssignsTasks(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcControl RelatingControl, IfcScheduleTimeControl TimeForTask) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType, RelatingControl)
		{
			this.TimeForTask = TimeForTask;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToActor
	/// <para>ENTITY IfcRelAssignsToActor</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelOccupiesSpaces))</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingActor : IfcActor;</para>
	/// <para>	ActingRole : OPTIONAL IfcActorRole;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingActor :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToActor : IfcRelAssigns
	{
		public IfcActor RelatingActor { get; set; }
		public IfcActorRole? ActingRole { get; set; }
		public IfcRelAssignsToActor() : base()
		{
			RelatingActor = new IfcActor();
		}
		public IfcRelAssignsToActor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcActor RelatingActor, IfcActorRole ActingRole) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingActor = RelatingActor;
			this.ActingRole = ActingRole;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToControl
	/// <para>ENTITY IfcRelAssignsToControl</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelAssignsTasks</para>
	/// <para>	,IfcRelAssignsToProjectOrder</para>
	/// <para>	,IfcRelSchedulesCostItems))</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingControl : IfcControl;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingControl :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToControl : IfcRelAssigns
	{
		public IfcControl RelatingControl { get; set; }
		public IfcRelAssignsToControl() : base()
		{
			RelatingControl = new IfcControl();
		}
		public IfcRelAssignsToControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcControl RelatingControl) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingControl = RelatingControl;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToGroup
	/// <para>ENTITY IfcRelAssignsToGroup</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingGroup : IfcGroup;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingGroup :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToGroup : IfcRelAssigns
	{
		public IfcGroup RelatingGroup { get; set; }
		public IfcRelAssignsToGroup() : base()
		{
			RelatingGroup = new IfcGroup();
		}
		public IfcRelAssignsToGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcGroup RelatingGroup) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingGroup = RelatingGroup;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToProcess
	/// <para>ENTITY IfcRelAssignsToProcess</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingProcess : IfcProcess;</para>
	/// <para>	QuantityInProcess : OPTIONAL IfcMeasureWithUnit;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingProcess :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToProcess : IfcRelAssigns
	{
		public IfcProcess RelatingProcess { get; set; }
		public IfcMeasureWithUnit? QuantityInProcess { get; set; }
		public IfcRelAssignsToProcess() : base()
		{
			RelatingProcess = new IfcProcess();
		}
		public IfcRelAssignsToProcess(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcProcess RelatingProcess, IfcMeasureWithUnit QuantityInProcess) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingProcess = RelatingProcess;
			this.QuantityInProcess = QuantityInProcess;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToProduct
	/// <para>ENTITY IfcRelAssignsToProduct</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingProduct : IfcProduct;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingProduct :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToProduct : IfcRelAssigns
	{
		public IfcProduct RelatingProduct { get; set; }
		public IfcRelAssignsToProduct() : base()
		{
			RelatingProduct = new IfcProduct();
		}
		public IfcRelAssignsToProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcProduct RelatingProduct) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingProduct = RelatingProduct;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToProjectOrder
	/// <para>ENTITY IfcRelAssignsToProjectOrder</para>
	/// <para> SUBTYPE OF (IfcRelAssignsToControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToProjectOrder : IfcRelAssignsToControl
	{
		public IfcRelAssignsToProjectOrder() : base()
		{
		}
		public IfcRelAssignsToProjectOrder(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcControl RelatingControl) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType, RelatingControl)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssignsToResource
	/// <para>ENTITY IfcRelAssignsToResource</para>
	/// <para> SUBTYPE OF (IfcRelAssigns);</para>
	/// <para>	RelatingResource : IfcResource;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingResource :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssignsToResource : IfcRelAssigns
	{
		public IfcResource RelatingResource { get; set; }
		public IfcRelAssignsToResource() : base()
		{
			RelatingResource = new IfcResource();
		}
		public IfcRelAssignsToResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcResource RelatingResource) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType)
		{
			this.RelatingResource = RelatingResource;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociates
	/// <para>ENTITY IfcRelAssociates</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelAssociatesAppliedValue</para>
	/// <para>	,IfcRelAssociatesApproval</para>
	/// <para>	,IfcRelAssociatesClassification</para>
	/// <para>	,IfcRelAssociatesConstraint</para>
	/// <para>	,IfcRelAssociatesDocument</para>
	/// <para>	,IfcRelAssociatesLibrary</para>
	/// <para>	,IfcRelAssociatesMaterial</para>
	/// <para>	,IfcRelAssociatesProfileProperties))</para>
	/// <para> SUBTYPE OF (IfcRelationship);</para>
	/// <para>	RelatedObjects : SET [1:?] OF IfcRoot;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* RelatedObjects |</para>
	/// <para>              NOT(('IFC2X3.IFCOBJECTDEFINITION' IN TYPEOF(temp)) </para>
	/// <para>               OR ('IFC2X3.IFCPROPERTYDEFINITION' IN TYPEOF(temp)))</para>
	/// <para>              )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociates : IfcRelationship
	{
		public List<IfcRoot> RelatedObjects { get; set; }
		public IfcRelAssociates() : base()
		{
			RelatedObjects = new List<IfcRoot>();
		}
		public IfcRelAssociates(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedObjects = RelatedObjects;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesAppliedValue
	/// <para>ENTITY IfcRelAssociatesAppliedValue</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingAppliedValue : IfcAppliedValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesAppliedValue : IfcRelAssociates
	{
		public IfcAppliedValue RelatingAppliedValue { get; set; }
		public IfcRelAssociatesAppliedValue() : base()
		{
			RelatingAppliedValue = new IfcAppliedValue();
		}
		public IfcRelAssociatesAppliedValue(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcAppliedValue RelatingAppliedValue) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingAppliedValue = RelatingAppliedValue;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesApproval
	/// <para>ENTITY IfcRelAssociatesApproval</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingApproval : IfcApproval;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesApproval : IfcRelAssociates
	{
		public IfcApproval RelatingApproval { get; set; }
		public IfcRelAssociatesApproval() : base()
		{
			RelatingApproval = new IfcApproval();
		}
		public IfcRelAssociatesApproval(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcApproval RelatingApproval) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingApproval = RelatingApproval;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesClassification
	/// <para>ENTITY IfcRelAssociatesClassification</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingClassification : IfcClassificationNotationSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesClassification : IfcRelAssociates
	{
		public IfcClassificationNotationSelect RelatingClassification { get; set; }
		public IfcRelAssociatesClassification() : base()
		{
			RelatingClassification = new IfcClassificationNotationSelect();
		}
		public IfcRelAssociatesClassification(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcClassificationNotationSelect RelatingClassification) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingClassification = RelatingClassification;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesConstraint
	/// <para>ENTITY IfcRelAssociatesConstraint</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	Intent : IfcLabel;</para>
	/// <para>	RelatingConstraint : IfcConstraint;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesConstraint : IfcRelAssociates
	{
		public IfcLabel Intent { get; set; }
		public IfcConstraint RelatingConstraint { get; set; }
		public IfcRelAssociatesConstraint() : base()
		{
			Intent = new IfcLabel();
			RelatingConstraint = new IfcConstraint();
		}
		public IfcRelAssociatesConstraint(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcLabel Intent, IfcConstraint RelatingConstraint) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.Intent = Intent;
			this.RelatingConstraint = RelatingConstraint;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesDocument
	/// <para>ENTITY IfcRelAssociatesDocument</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingDocument : IfcDocumentSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesDocument : IfcRelAssociates
	{
		public IfcDocumentSelect RelatingDocument { get; set; }
		public IfcRelAssociatesDocument() : base()
		{
			RelatingDocument = new IfcDocumentSelect();
		}
		public IfcRelAssociatesDocument(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcDocumentSelect RelatingDocument) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingDocument = RelatingDocument;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesLibrary
	/// <para>ENTITY IfcRelAssociatesLibrary</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingLibrary : IfcLibrarySelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesLibrary : IfcRelAssociates
	{
		public IfcLibrarySelect RelatingLibrary { get; set; }
		public IfcRelAssociatesLibrary() : base()
		{
			RelatingLibrary = new IfcLibrarySelect();
		}
		public IfcRelAssociatesLibrary(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcLibrarySelect RelatingLibrary) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingLibrary = RelatingLibrary;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesMaterial
	/// <para>ENTITY IfcRelAssociatesMaterial</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingMaterial : IfcMaterialSelect;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* SELF\IfcRelAssociates.RelatedObjects | </para>
	/// <para>             ('IFC2X3.IFCFEATUREELEMENTSUBTRACTION' IN TYPEOF(temp))</para>
	/// <para>               OR ('IFC2X3.IFCVIRTUALELEMENT' IN TYPEOF(temp))</para>
	/// <para>             )) = 0;</para>
	/// <para>	WR22 : SIZEOF(QUERY(temp <* SELF\IfcRelAssociates.RelatedObjects | </para>
	/// <para>             (NOT('IFC2X3.IFCPRODUCT' IN TYPEOF(temp)) </para>
	/// <para>              AND NOT('IFC2X3.IFCTYPEPRODUCT' IN TYPEOF(temp)))</para>
	/// <para>             )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesMaterial : IfcRelAssociates
	{
		public IfcMaterialSelect RelatingMaterial { get; set; }
		public IfcRelAssociatesMaterial() : base()
		{
			RelatingMaterial = new IfcMaterialSelect();
		}
		public IfcRelAssociatesMaterial(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcMaterialSelect RelatingMaterial) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingMaterial = RelatingMaterial;
		}
	}
	/// <summary>
	/// ENTITY IfcRelAssociatesProfileProperties
	/// <para>ENTITY IfcRelAssociatesProfileProperties</para>
	/// <para> SUBTYPE OF (IfcRelAssociates);</para>
	/// <para>	RelatingProfileProperties : IfcProfileProperties;</para>
	/// <para>	ProfileSectionLocation : OPTIONAL IfcShapeAspect;</para>
	/// <para>	ProfileOrientation : OPTIONAL IfcOrientationSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelAssociatesProfileProperties : IfcRelAssociates
	{
		public IfcProfileProperties RelatingProfileProperties { get; set; }
		public IfcShapeAspect? ProfileSectionLocation { get; set; }
		public IfcOrientationSelect? ProfileOrientation { get; set; }
		public IfcRelAssociatesProfileProperties() : base()
		{
			RelatingProfileProperties = new IfcProfileProperties();
		}
		public IfcRelAssociatesProfileProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcRoot> RelatedObjects, IfcProfileProperties RelatingProfileProperties, IfcShapeAspect ProfileSectionLocation, IfcOrientationSelect ProfileOrientation) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingProfileProperties = RelatingProfileProperties;
			this.ProfileSectionLocation = ProfileSectionLocation;
			this.ProfileOrientation = ProfileOrientation;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnects
	/// <para>ENTITY IfcRelConnects</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelConnectsElements</para>
	/// <para>	,IfcRelConnectsPortToElement</para>
	/// <para>	,IfcRelConnectsPorts</para>
	/// <para>	,IfcRelConnectsStructuralActivity</para>
	/// <para>	,IfcRelConnectsStructuralElement</para>
	/// <para>	,IfcRelConnectsStructuralMember</para>
	/// <para>	,IfcRelContainedInSpatialStructure</para>
	/// <para>	,IfcRelCoversBldgElements</para>
	/// <para>	,IfcRelCoversSpaces</para>
	/// <para>	,IfcRelFillsElement</para>
	/// <para>	,IfcRelFlowControlElements</para>
	/// <para>	,IfcRelInteractionRequirements</para>
	/// <para>	,IfcRelProjectsElement</para>
	/// <para>	,IfcRelReferencedInSpatialStructure</para>
	/// <para>	,IfcRelSequence</para>
	/// <para>	,IfcRelServicesBuildings</para>
	/// <para>	,IfcRelSpaceBoundary</para>
	/// <para>	,IfcRelVoidsElement))</para>
	/// <para> SUBTYPE OF (IfcRelationship);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRelConnects : IfcRelationship
	{
		public IfcRelConnects() : base()
		{
		}
		public IfcRelConnects(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base (GlobalId, OwnerHistory, Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsElements
	/// <para>ENTITY IfcRelConnectsElements</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelConnectsPathElements</para>
	/// <para>	,IfcRelConnectsWithRealizingElements))</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	ConnectionGeometry : OPTIONAL IfcConnectionGeometry;</para>
	/// <para>	RelatingElement : IfcElement;</para>
	/// <para>	RelatedElement : IfcElement;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : RelatingElement :<>: RelatedElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsElements : IfcRelConnects
	{
		public IfcConnectionGeometry? ConnectionGeometry { get; set; }
		public IfcElement RelatingElement { get; set; }
		public IfcElement RelatedElement { get; set; }
		public IfcRelConnectsElements() : base()
		{
			RelatingElement = new IfcElement();
			RelatedElement = new IfcElement();
		}
		public IfcRelConnectsElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.ConnectionGeometry = ConnectionGeometry;
			this.RelatingElement = RelatingElement;
			this.RelatedElement = RelatedElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsPathElements
	/// <para>ENTITY IfcRelConnectsPathElements</para>
	/// <para> SUBTYPE OF (IfcRelConnectsElements);</para>
	/// <para>	RelatingPriorities : LIST [0:?] OF INTEGER;</para>
	/// <para>	RelatedPriorities : LIST [0:?] OF INTEGER;</para>
	/// <para>	RelatedConnectionType : IfcConnectionTypeEnum;</para>
	/// <para>	RelatingConnectionType : IfcConnectionTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsPathElements : IfcRelConnectsElements
	{
		public List<INTEGER> RelatingPriorities { get; set; }
		public List<INTEGER> RelatedPriorities { get; set; }
		public IfcConnectionTypeEnum RelatedConnectionType { get; set; }
		public IfcConnectionTypeEnum RelatingConnectionType { get; set; }
		public IfcRelConnectsPathElements() : base()
		{
			RelatingPriorities = new List<INTEGER>();
			RelatedPriorities = new List<INTEGER>();
			RelatedConnectionType = new IfcConnectionTypeEnum();
			RelatingConnectionType = new IfcConnectionTypeEnum();
		}
		public IfcRelConnectsPathElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement, List<INTEGER> RelatingPriorities, List<INTEGER> RelatedPriorities, IfcConnectionTypeEnum RelatedConnectionType, IfcConnectionTypeEnum RelatingConnectionType) : base (GlobalId, OwnerHistory, Name, Description, ConnectionGeometry, RelatingElement, RelatedElement)
		{
			this.RelatingPriorities = RelatingPriorities;
			this.RelatedPriorities = RelatedPriorities;
			this.RelatedConnectionType = RelatedConnectionType;
			this.RelatingConnectionType = RelatingConnectionType;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsPortToElement
	/// <para>ENTITY IfcRelConnectsPortToElement</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingPort : IfcPort;</para>
	/// <para>	RelatedElement : IfcElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsPortToElement : IfcRelConnects
	{
		public IfcPort RelatingPort { get; set; }
		public IfcElement RelatedElement { get; set; }
		public IfcRelConnectsPortToElement() : base()
		{
			RelatingPort = new IfcPort();
			RelatedElement = new IfcElement();
		}
		public IfcRelConnectsPortToElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPort RelatingPort, IfcElement RelatedElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingPort = RelatingPort;
			this.RelatedElement = RelatedElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsPorts
	/// <para>ENTITY IfcRelConnectsPorts</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingPort : IfcPort;</para>
	/// <para>	RelatedPort : IfcPort;</para>
	/// <para>	RealizingElement : OPTIONAL IfcElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsPorts : IfcRelConnects
	{
		public IfcPort RelatingPort { get; set; }
		public IfcPort RelatedPort { get; set; }
		public IfcElement? RealizingElement { get; set; }
		public IfcRelConnectsPorts() : base()
		{
			RelatingPort = new IfcPort();
			RelatedPort = new IfcPort();
		}
		public IfcRelConnectsPorts(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPort RelatingPort, IfcPort RelatedPort, IfcElement RealizingElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingPort = RelatingPort;
			this.RelatedPort = RelatedPort;
			this.RealizingElement = RealizingElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsStructuralActivity
	/// <para>ENTITY IfcRelConnectsStructuralActivity</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingElement : IfcStructuralActivityAssignmentSelect;</para>
	/// <para>	RelatedStructuralActivity : IfcStructuralActivity;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsStructuralActivity : IfcRelConnects
	{
		public IfcStructuralActivityAssignmentSelect RelatingElement { get; set; }
		public IfcStructuralActivity RelatedStructuralActivity { get; set; }
		public IfcRelConnectsStructuralActivity() : base()
		{
			RelatingElement = new IfcStructuralActivityAssignmentSelect();
			RelatedStructuralActivity = new IfcStructuralActivity();
		}
		public IfcRelConnectsStructuralActivity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralActivityAssignmentSelect RelatingElement, IfcStructuralActivity RelatedStructuralActivity) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingElement = RelatingElement;
			this.RelatedStructuralActivity = RelatedStructuralActivity;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsStructuralElement
	/// <para>ENTITY IfcRelConnectsStructuralElement</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingElement : IfcElement;</para>
	/// <para>	RelatedStructuralMember : IfcStructuralMember;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsStructuralElement : IfcRelConnects
	{
		public IfcElement RelatingElement { get; set; }
		public IfcStructuralMember RelatedStructuralMember { get; set; }
		public IfcRelConnectsStructuralElement() : base()
		{
			RelatingElement = new IfcElement();
			RelatedStructuralMember = new IfcStructuralMember();
		}
		public IfcRelConnectsStructuralElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingElement, IfcStructuralMember RelatedStructuralMember) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingElement = RelatingElement;
			this.RelatedStructuralMember = RelatedStructuralMember;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsStructuralMember
	/// <para>ENTITY IfcRelConnectsStructuralMember</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelConnectsWithEccentricity))</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingStructuralMember : IfcStructuralMember;</para>
	/// <para>	RelatedStructuralConnection : IfcStructuralConnection;</para>
	/// <para>	AppliedCondition : OPTIONAL IfcBoundaryCondition;</para>
	/// <para>	AdditionalConditions : OPTIONAL IfcStructuralConnectionCondition;</para>
	/// <para>	SupportedLength : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ConditionCoordinateSystem : OPTIONAL IfcAxis2Placement3D;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsStructuralMember : IfcRelConnects
	{
		public IfcStructuralMember RelatingStructuralMember { get; set; }
		public IfcStructuralConnection RelatedStructuralConnection { get; set; }
		public IfcBoundaryCondition? AppliedCondition { get; set; }
		public IfcStructuralConnectionCondition? AdditionalConditions { get; set; }
		public IfcLengthMeasure? SupportedLength { get; set; }
		public IfcAxis2Placement3D? ConditionCoordinateSystem { get; set; }
		public IfcRelConnectsStructuralMember() : base()
		{
			RelatingStructuralMember = new IfcStructuralMember();
			RelatedStructuralConnection = new IfcStructuralConnection();
		}
		public IfcRelConnectsStructuralMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralMember RelatingStructuralMember, IfcStructuralConnection RelatedStructuralConnection, IfcBoundaryCondition AppliedCondition, IfcStructuralConnectionCondition AdditionalConditions, IfcLengthMeasure SupportedLength, IfcAxis2Placement3D ConditionCoordinateSystem) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingStructuralMember = RelatingStructuralMember;
			this.RelatedStructuralConnection = RelatedStructuralConnection;
			this.AppliedCondition = AppliedCondition;
			this.AdditionalConditions = AdditionalConditions;
			this.SupportedLength = SupportedLength;
			this.ConditionCoordinateSystem = ConditionCoordinateSystem;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsWithEccentricity
	/// <para>ENTITY IfcRelConnectsWithEccentricity</para>
	/// <para> SUBTYPE OF (IfcRelConnectsStructuralMember);</para>
	/// <para>	ConnectionConstraint : IfcConnectionGeometry;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsWithEccentricity : IfcRelConnectsStructuralMember
	{
		public IfcConnectionGeometry ConnectionConstraint { get; set; }
		public IfcRelConnectsWithEccentricity() : base()
		{
			ConnectionConstraint = new IfcConnectionGeometry();
		}
		public IfcRelConnectsWithEccentricity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcStructuralMember RelatingStructuralMember, IfcStructuralConnection RelatedStructuralConnection, IfcBoundaryCondition AppliedCondition, IfcStructuralConnectionCondition AdditionalConditions, IfcLengthMeasure SupportedLength, IfcAxis2Placement3D ConditionCoordinateSystem, IfcConnectionGeometry ConnectionConstraint) : base (GlobalId, OwnerHistory, Name, Description, RelatingStructuralMember, RelatedStructuralConnection, AppliedCondition, AdditionalConditions, SupportedLength, ConditionCoordinateSystem)
		{
			this.ConnectionConstraint = ConnectionConstraint;
		}
	}
	/// <summary>
	/// ENTITY IfcRelConnectsWithRealizingElements
	/// <para>ENTITY IfcRelConnectsWithRealizingElements</para>
	/// <para> SUBTYPE OF (IfcRelConnectsElements);</para>
	/// <para>	RealizingElements : SET [1:?] OF IfcElement;</para>
	/// <para>	ConnectionType : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelConnectsWithRealizingElements : IfcRelConnectsElements
	{
		public List<IfcElement> RealizingElements { get; set; }
		public IfcLabel? ConnectionType { get; set; }
		public IfcRelConnectsWithRealizingElements() : base()
		{
			RealizingElements = new List<IfcElement>();
		}
		public IfcRelConnectsWithRealizingElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcConnectionGeometry ConnectionGeometry, IfcElement RelatingElement, IfcElement RelatedElement, List<IfcElement> RealizingElements, IfcLabel ConnectionType) : base (GlobalId, OwnerHistory, Name, Description, ConnectionGeometry, RelatingElement, RelatedElement)
		{
			this.RealizingElements = RealizingElements;
			this.ConnectionType = ConnectionType;
		}
	}
	/// <summary>
	/// ENTITY IfcRelContainedInSpatialStructure
	/// <para>ENTITY IfcRelContainedInSpatialStructure</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatedElements : SET [1:?] OF IfcProduct;</para>
	/// <para>	RelatingStructure : IfcSpatialStructureElement;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SIZEOF(QUERY(temp <* RelatedElements | 'IFC2X3.IFCSPATIALSTRUCTUREELEMENT' IN TYPEOF(temp))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelContainedInSpatialStructure : IfcRelConnects
	{
		public List<IfcProduct> RelatedElements { get; set; }
		public IfcSpatialStructureElement RelatingStructure { get; set; }
		public IfcRelContainedInSpatialStructure() : base()
		{
			RelatedElements = new List<IfcProduct>();
			RelatingStructure = new IfcSpatialStructureElement();
		}
		public IfcRelContainedInSpatialStructure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProduct> RelatedElements, IfcSpatialStructureElement RelatingStructure) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedElements = RelatedElements;
			this.RelatingStructure = RelatingStructure;
		}
	}
	/// <summary>
	/// ENTITY IfcRelCoversBldgElements
	/// <para>ENTITY IfcRelCoversBldgElements</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingBuildingElement : IfcElement;</para>
	/// <para>	RelatedCoverings : SET [1:?] OF IfcCovering;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelCoversBldgElements : IfcRelConnects
	{
		public IfcElement RelatingBuildingElement { get; set; }
		public List<IfcCovering> RelatedCoverings { get; set; }
		public IfcRelCoversBldgElements() : base()
		{
			RelatingBuildingElement = new IfcElement();
			RelatedCoverings = new List<IfcCovering>();
		}
		public IfcRelCoversBldgElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingBuildingElement, List<IfcCovering> RelatedCoverings) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingBuildingElement = RelatingBuildingElement;
			this.RelatedCoverings = RelatedCoverings;
		}
	}
	/// <summary>
	/// ENTITY IfcRelCoversSpaces
	/// <para>ENTITY IfcRelCoversSpaces</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatedSpace : IfcSpace;</para>
	/// <para>	RelatedCoverings : SET [1:?] OF IfcCovering;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelCoversSpaces : IfcRelConnects
	{
		public IfcSpace RelatedSpace { get; set; }
		public List<IfcCovering> RelatedCoverings { get; set; }
		public IfcRelCoversSpaces() : base()
		{
			RelatedSpace = new IfcSpace();
			RelatedCoverings = new List<IfcCovering>();
		}
		public IfcRelCoversSpaces(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpace RelatedSpace, List<IfcCovering> RelatedCoverings) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedSpace = RelatedSpace;
			this.RelatedCoverings = RelatedCoverings;
		}
	}
	/// <summary>
	/// ENTITY IfcRelDecomposes
	/// <para>ENTITY IfcRelDecomposes</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelAggregates</para>
	/// <para>	,IfcRelNests))</para>
	/// <para> SUBTYPE OF (IfcRelationship);</para>
	/// <para>	RelatingObject : IfcObjectDefinition;</para>
	/// <para>	RelatedObjects : SET [1:?] OF IfcObjectDefinition;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SIZEOF(QUERY(Temp <* RelatedObjects | RelatingObject :=: Temp)) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRelDecomposes : IfcRelationship
	{
		public IfcObjectDefinition RelatingObject { get; set; }
		public List<IfcObjectDefinition> RelatedObjects { get; set; }
		public IfcRelDecomposes() : base()
		{
			RelatingObject = new IfcObjectDefinition();
			RelatedObjects = new List<IfcObjectDefinition>();
		}
		public IfcRelDecomposes(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcObjectDefinition RelatingObject, List<IfcObjectDefinition> RelatedObjects) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingObject = RelatingObject;
			this.RelatedObjects = RelatedObjects;
		}
	}
	/// <summary>
	/// ENTITY IfcRelDefines
	/// <para>ENTITY IfcRelDefines</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelDefinesByProperties</para>
	/// <para>	,IfcRelDefinesByType))</para>
	/// <para> SUBTYPE OF (IfcRelationship);</para>
	/// <para>	RelatedObjects : SET [1:?] OF IfcObject;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRelDefines : IfcRelationship
	{
		public List<IfcObject> RelatedObjects { get; set; }
		public IfcRelDefines() : base()
		{
			RelatedObjects = new List<IfcObject>();
		}
		public IfcRelDefines(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedObjects = RelatedObjects;
		}
	}
	/// <summary>
	/// ENTITY IfcRelDefinesByProperties
	/// <para>ENTITY IfcRelDefinesByProperties</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelOverridesProperties))</para>
	/// <para> SUBTYPE OF (IfcRelDefines);</para>
	/// <para>	RelatingPropertyDefinition : IfcPropertySetDefinition;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelDefinesByProperties : IfcRelDefines
	{
		public IfcPropertySetDefinition RelatingPropertyDefinition { get; set; }
		public IfcRelDefinesByProperties() : base()
		{
			RelatingPropertyDefinition = new IfcPropertySetDefinition();
		}
		public IfcRelDefinesByProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects, IfcPropertySetDefinition RelatingPropertyDefinition) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingPropertyDefinition = RelatingPropertyDefinition;
		}
	}
	/// <summary>
	/// ENTITY IfcRelDefinesByType
	/// <para>ENTITY IfcRelDefinesByType</para>
	/// <para> SUBTYPE OF (IfcRelDefines);</para>
	/// <para>	RelatingType : IfcTypeObject;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelDefinesByType : IfcRelDefines
	{
		public IfcTypeObject RelatingType { get; set; }
		public IfcRelDefinesByType() : base()
		{
			RelatingType = new IfcTypeObject();
		}
		public IfcRelDefinesByType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects, IfcTypeObject RelatingType) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects)
		{
			this.RelatingType = RelatingType;
		}
	}
	/// <summary>
	/// ENTITY IfcRelFillsElement
	/// <para>ENTITY IfcRelFillsElement</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingOpeningElement : IfcOpeningElement;</para>
	/// <para>	RelatedBuildingElement : IfcElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelFillsElement : IfcRelConnects
	{
		public IfcOpeningElement RelatingOpeningElement { get; set; }
		public IfcElement RelatedBuildingElement { get; set; }
		public IfcRelFillsElement() : base()
		{
			RelatingOpeningElement = new IfcOpeningElement();
			RelatedBuildingElement = new IfcElement();
		}
		public IfcRelFillsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcOpeningElement RelatingOpeningElement, IfcElement RelatedBuildingElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingOpeningElement = RelatingOpeningElement;
			this.RelatedBuildingElement = RelatedBuildingElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelFlowControlElements
	/// <para>ENTITY IfcRelFlowControlElements</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatedControlElements : SET [1:?] OF IfcDistributionControlElement;</para>
	/// <para>	RelatingFlowElement : IfcDistributionFlowElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelFlowControlElements : IfcRelConnects
	{
		public List<IfcDistributionControlElement> RelatedControlElements { get; set; }
		public IfcDistributionFlowElement RelatingFlowElement { get; set; }
		public IfcRelFlowControlElements() : base()
		{
			RelatedControlElements = new List<IfcDistributionControlElement>();
			RelatingFlowElement = new IfcDistributionFlowElement();
		}
		public IfcRelFlowControlElements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcDistributionControlElement> RelatedControlElements, IfcDistributionFlowElement RelatingFlowElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedControlElements = RelatedControlElements;
			this.RelatingFlowElement = RelatingFlowElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelInteractionRequirements
	/// <para>ENTITY IfcRelInteractionRequirements</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	DailyInteraction : OPTIONAL IfcCountMeasure;</para>
	/// <para>	ImportanceRating : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	LocationOfInteraction : OPTIONAL IfcSpatialStructureElement;</para>
	/// <para>	RelatedSpaceProgram : IfcSpaceProgram;</para>
	/// <para>	RelatingSpaceProgram : IfcSpaceProgram;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelInteractionRequirements : IfcRelConnects
	{
		public IfcCountMeasure? DailyInteraction { get; set; }
		public IfcNormalisedRatioMeasure? ImportanceRating { get; set; }
		public IfcSpatialStructureElement? LocationOfInteraction { get; set; }
		public IfcSpaceProgram RelatedSpaceProgram { get; set; }
		public IfcSpaceProgram RelatingSpaceProgram { get; set; }
		public IfcRelInteractionRequirements() : base()
		{
			RelatedSpaceProgram = new IfcSpaceProgram();
			RelatingSpaceProgram = new IfcSpaceProgram();
		}
		public IfcRelInteractionRequirements(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcCountMeasure DailyInteraction, IfcNormalisedRatioMeasure ImportanceRating, IfcSpatialStructureElement LocationOfInteraction, IfcSpaceProgram RelatedSpaceProgram, IfcSpaceProgram RelatingSpaceProgram) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.DailyInteraction = DailyInteraction;
			this.ImportanceRating = ImportanceRating;
			this.LocationOfInteraction = LocationOfInteraction;
			this.RelatedSpaceProgram = RelatedSpaceProgram;
			this.RelatingSpaceProgram = RelatingSpaceProgram;
		}
	}
	/// <summary>
	/// ENTITY IfcRelNests
	/// <para>ENTITY IfcRelNests</para>
	/// <para> SUBTYPE OF (IfcRelDecomposes);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(Temp <* SELF\IfcRelDecomposes.RelatedObjects | </para>
	/// <para>              NOT(TYPEOF(SELF\IfcRelDecomposes.RelatingObject) = TYPEOF(Temp)))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelNests : IfcRelDecomposes
	{
		public IfcRelNests() : base()
		{
		}
		public IfcRelNests(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcObjectDefinition RelatingObject, List<IfcObjectDefinition> RelatedObjects) : base (GlobalId, OwnerHistory, Name, Description, RelatingObject, RelatedObjects)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelOccupiesSpaces
	/// <para>ENTITY IfcRelOccupiesSpaces</para>
	/// <para> SUBTYPE OF (IfcRelAssignsToActor);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelOccupiesSpaces : IfcRelAssignsToActor
	{
		public IfcRelOccupiesSpaces() : base()
		{
		}
		public IfcRelOccupiesSpaces(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcActor RelatingActor, IfcActorRole ActingRole) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType, RelatingActor, ActingRole)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelOverridesProperties
	/// <para>ENTITY IfcRelOverridesProperties</para>
	/// <para> SUBTYPE OF (IfcRelDefinesByProperties);</para>
	/// <para>	OverridingProperties : SET [1:?] OF IfcProperty;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(SELF\IfcRelDefines.RelatedObjects) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelOverridesProperties : IfcRelDefinesByProperties
	{
		public List<IfcProperty> OverridingProperties { get; set; }
		public IfcRelOverridesProperties() : base()
		{
			OverridingProperties = new List<IfcProperty>();
		}
		public IfcRelOverridesProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObject> RelatedObjects, IfcPropertySetDefinition RelatingPropertyDefinition, List<IfcProperty> OverridingProperties) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatingPropertyDefinition)
		{
			this.OverridingProperties = OverridingProperties;
		}
	}
	/// <summary>
	/// ENTITY IfcRelProjectsElement
	/// <para>ENTITY IfcRelProjectsElement</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingElement : IfcElement;</para>
	/// <para>	RelatedFeatureElement : IfcFeatureElementAddition;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelProjectsElement : IfcRelConnects
	{
		public IfcElement RelatingElement { get; set; }
		public IfcFeatureElementAddition RelatedFeatureElement { get; set; }
		public IfcRelProjectsElement() : base()
		{
			RelatingElement = new IfcElement();
			RelatedFeatureElement = new IfcFeatureElementAddition();
		}
		public IfcRelProjectsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingElement, IfcFeatureElementAddition RelatedFeatureElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingElement = RelatingElement;
			this.RelatedFeatureElement = RelatedFeatureElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelReferencedInSpatialStructure
	/// <para>ENTITY IfcRelReferencedInSpatialStructure</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatedElements : SET [1:?] OF IfcProduct;</para>
	/// <para>	RelatingStructure : IfcSpatialStructureElement;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SIZEOF(QUERY(temp <* RelatedElements | 'IFC2X3.IFCSPATIALSTRUCTUREELEMENT' IN TYPEOF(temp))) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelReferencedInSpatialStructure : IfcRelConnects
	{
		public List<IfcProduct> RelatedElements { get; set; }
		public IfcSpatialStructureElement RelatingStructure { get; set; }
		public IfcRelReferencedInSpatialStructure() : base()
		{
			RelatedElements = new List<IfcProduct>();
			RelatingStructure = new IfcSpatialStructureElement();
		}
		public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcProduct> RelatedElements, IfcSpatialStructureElement RelatingStructure) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatedElements = RelatedElements;
			this.RelatingStructure = RelatingStructure;
		}
	}
	/// <summary>
	/// ENTITY IfcRelSchedulesCostItems
	/// <para>ENTITY IfcRelSchedulesCostItems</para>
	/// <para> SUBTYPE OF (IfcRelAssignsToControl);</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(temp <* SELF\IfcRelAssigns.RelatedObjects |</para>
	/// <para>               NOT('IFC2X3.IFCCOSTITEM' IN TYPEOF(temp))</para>
	/// <para>               )) = 0;</para>
	/// <para>	WR12 : 'IFC2X3.IFCCOSTSCHEDULE' IN TYPEOF (SELF\IfcRelAssignsToControl.RelatingControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelSchedulesCostItems : IfcRelAssignsToControl
	{
		public IfcRelSchedulesCostItems() : base()
		{
		}
		public IfcRelSchedulesCostItems(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, List<IfcObjectDefinition> RelatedObjects, IfcObjectTypeEnum RelatedObjectsType, IfcControl RelatingControl) : base (GlobalId, OwnerHistory, Name, Description, RelatedObjects, RelatedObjectsType, RelatingControl)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelSequence
	/// <para>ENTITY IfcRelSequence</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingProcess : IfcProcess;</para>
	/// <para>	RelatedProcess : IfcProcess;</para>
	/// <para>	TimeLag : IfcTimeMeasure;</para>
	/// <para>	SequenceType : IfcSequenceEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : RelatingProcess :<>: RelatedProcess;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelSequence : IfcRelConnects
	{
		public IfcProcess RelatingProcess { get; set; }
		public IfcProcess RelatedProcess { get; set; }
		public IfcTimeMeasure TimeLag { get; set; }
		public IfcSequenceEnum SequenceType { get; set; }
		public IfcRelSequence() : base()
		{
			RelatingProcess = new IfcProcess();
			RelatedProcess = new IfcProcess();
			TimeLag = new IfcTimeMeasure();
			SequenceType = new IfcSequenceEnum();
		}
		public IfcRelSequence(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcProcess RelatingProcess, IfcProcess RelatedProcess, IfcTimeMeasure TimeLag, IfcSequenceEnum SequenceType) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingProcess = RelatingProcess;
			this.RelatedProcess = RelatedProcess;
			this.TimeLag = TimeLag;
			this.SequenceType = SequenceType;
		}
	}
	/// <summary>
	/// ENTITY IfcRelServicesBuildings
	/// <para>ENTITY IfcRelServicesBuildings</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingSystem : IfcSystem;</para>
	/// <para>	RelatedBuildings : SET [1:?] OF IfcSpatialStructureElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelServicesBuildings : IfcRelConnects
	{
		public IfcSystem RelatingSystem { get; set; }
		public List<IfcSpatialStructureElement> RelatedBuildings { get; set; }
		public IfcRelServicesBuildings() : base()
		{
			RelatingSystem = new IfcSystem();
			RelatedBuildings = new List<IfcSpatialStructureElement>();
		}
		public IfcRelServicesBuildings(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSystem RelatingSystem, List<IfcSpatialStructureElement> RelatedBuildings) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingSystem = RelatingSystem;
			this.RelatedBuildings = RelatedBuildings;
		}
	}
	/// <summary>
	/// ENTITY IfcRelSpaceBoundary
	/// <para>ENTITY IfcRelSpaceBoundary</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingSpace : IfcSpace;</para>
	/// <para>	RelatedBuildingElement : OPTIONAL IfcElement;</para>
	/// <para>	ConnectionGeometry : OPTIONAL IfcConnectionGeometry;</para>
	/// <para>	PhysicalOrVirtualBoundary : IfcPhysicalOrVirtualEnum;</para>
	/// <para>	InternalOrExternalBoundary : IfcInternalOrExternalEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : ((PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.Physical) AND </para>
	/// <para>              (EXISTS(RelatedBuildingElement) AND NOT('IFC2X3.IFCVIRTUALELEMENT' IN TYPEOF(RelatedBuildingElement)))) </para>
	/// <para>            OR </para>
	/// <para>            ((PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.Virtual) AND </para>
	/// <para>              (NOT(EXISTS(RelatedBuildingElement)) OR ('IFC2X3.IFCVIRTUALELEMENT' IN TYPEOF(RelatedBuildingElement)))) </para>
	/// <para>            OR </para>
	/// <para>             (PhysicalOrVirtualBoundary = IfcPhysicalOrVirtualEnum.NotDefined);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelSpaceBoundary : IfcRelConnects
	{
		public IfcSpace RelatingSpace { get; set; }
		public IfcElement? RelatedBuildingElement { get; set; }
		public IfcConnectionGeometry? ConnectionGeometry { get; set; }
		public IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary { get; set; }
		public IfcInternalOrExternalEnum InternalOrExternalBoundary { get; set; }
		public IfcRelSpaceBoundary() : base()
		{
			RelatingSpace = new IfcSpace();
			PhysicalOrVirtualBoundary = new IfcPhysicalOrVirtualEnum();
			InternalOrExternalBoundary = new IfcInternalOrExternalEnum();
		}
		public IfcRelSpaceBoundary(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcSpace RelatingSpace, IfcElement RelatedBuildingElement, IfcConnectionGeometry ConnectionGeometry, IfcPhysicalOrVirtualEnum PhysicalOrVirtualBoundary, IfcInternalOrExternalEnum InternalOrExternalBoundary) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingSpace = RelatingSpace;
			this.RelatedBuildingElement = RelatedBuildingElement;
			this.ConnectionGeometry = ConnectionGeometry;
			this.PhysicalOrVirtualBoundary = PhysicalOrVirtualBoundary;
			this.InternalOrExternalBoundary = InternalOrExternalBoundary;
		}
	}
	/// <summary>
	/// ENTITY IfcRelVoidsElement
	/// <para>ENTITY IfcRelVoidsElement</para>
	/// <para> SUBTYPE OF (IfcRelConnects);</para>
	/// <para>	RelatingBuildingElement : IfcElement;</para>
	/// <para>	RelatedOpeningElement : IfcFeatureElementSubtraction;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelVoidsElement : IfcRelConnects
	{
		public IfcElement RelatingBuildingElement { get; set; }
		public IfcFeatureElementSubtraction RelatedOpeningElement { get; set; }
		public IfcRelVoidsElement() : base()
		{
			RelatingBuildingElement = new IfcElement();
			RelatedOpeningElement = new IfcFeatureElementSubtraction();
		}
		public IfcRelVoidsElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcElement RelatingBuildingElement, IfcFeatureElementSubtraction RelatedOpeningElement) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.RelatingBuildingElement = RelatingBuildingElement;
			this.RelatedOpeningElement = RelatedOpeningElement;
		}
	}
	/// <summary>
	/// ENTITY IfcRelationship
	/// <para>ENTITY IfcRelationship</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcRelAssigns</para>
	/// <para>	,IfcRelAssociates</para>
	/// <para>	,IfcRelConnects</para>
	/// <para>	,IfcRelDecomposes</para>
	/// <para>	,IfcRelDefines))</para>
	/// <para> SUBTYPE OF (IfcRoot);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRelationship : IfcRoot
	{
		public IfcRelationship() : base()
		{
		}
		public IfcRelationship(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base (GlobalId, OwnerHistory, Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRelaxation;
	/// <para>ENTITY IfcRelaxation;</para>
	/// <para>	RelaxationValue : IfcNormalisedRatioMeasure;</para>
	/// <para>	InitialStress : IfcNormalisedRatioMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRelaxationENTITY
	{
		public IfcNormalisedRatioMeasure RelaxationValue { get; set; }
		public IfcNormalisedRatioMeasure InitialStress { get; set; }
		public IfcRelaxation() : base()
		{
			RelaxationValue = new IfcNormalisedRatioMeasure();
			InitialStress = new IfcNormalisedRatioMeasure();
		}
		public IfcRelaxation(IfcNormalisedRatioMeasure RelaxationValue, IfcNormalisedRatioMeasure InitialStress) : base ()
		{
			this.RelaxationValue = RelaxationValue;
			this.InitialStress = InitialStress;
		}
	}
	/// <summary>
	/// ENTITY IfcRepresentation
	/// <para>ENTITY IfcRepresentation</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcShapeModel</para>
	/// <para>	,IfcStyleModel));</para>
	/// <para>	ContextOfItems : IfcRepresentationContext;</para>
	/// <para>	RepresentationIdentifier : OPTIONAL IfcLabel;</para>
	/// <para>	RepresentationType : OPTIONAL IfcLabel;</para>
	/// <para>	Items : SET [1:?] OF IfcRepresentationItem;</para>
	/// <para> INVERSE</para>
	/// <para>	RepresentationMap : SET [0:1] OF IfcRepresentationMap FOR MappedRepresentation;</para>
	/// <para>	LayerAssignments : SET [0:?] OF IfcPresentationLayerAssignment FOR AssignedItems;</para>
	/// <para>	OfProductRepresentation : SET [0:1] OF IfcProductRepresentation FOR Representations;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRepresentationENTITY, IfcLayeredItem
	{
		public IfcRepresentationContext ContextOfItems { get; set; }
		public IfcLabel? RepresentationIdentifier { get; set; }
		public IfcLabel? RepresentationType { get; set; }
		public List<IfcRepresentationItem> Items { get; set; }
		public IfcRepresentation() : base()
		{
			ContextOfItems = new IfcRepresentationContext();
			Items = new List<IfcRepresentationItem>();
		}
		public IfcRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base ()
		{
			this.ContextOfItems = ContextOfItems;
			this.RepresentationIdentifier = RepresentationIdentifier;
			this.RepresentationType = RepresentationType;
			this.Items = Items;
		}
	}
	/// <summary>
	/// ENTITY IfcRepresentationContext
	/// <para>ENTITY IfcRepresentationContext</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGeometricRepresentationContext));</para>
	/// <para>	ContextIdentifier : OPTIONAL IfcLabel;</para>
	/// <para>	ContextType : OPTIONAL IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	RepresentationsInContext : SET [0:?] OF IfcRepresentation FOR ContextOfItems;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRepresentationContextENTITY
	{
		public IfcLabel? ContextIdentifier { get; set; }
		public IfcLabel? ContextType { get; set; }
		public IfcRepresentationContext() : base()
		{
		}
		public IfcRepresentationContext(IfcLabel ContextIdentifier, IfcLabel ContextType) : base ()
		{
			this.ContextIdentifier = ContextIdentifier;
			this.ContextType = ContextType;
		}
	}
	/// <summary>
	/// ENTITY IfcRepresentationItem
	/// <para>ENTITY IfcRepresentationItem</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcGeometricRepresentationItem</para>
	/// <para>	,IfcMappedItem</para>
	/// <para>	,IfcStyledItem</para>
	/// <para>	,IfcTopologicalRepresentationItem));</para>
	/// <para> INVERSE</para>
	/// <para>	LayerAssignments : SET [0:?] OF IfcPresentationLayerAssignment FOR AssignedItems;</para>
	/// <para>	StyledByItem : SET [0:1] OF IfcStyledItem FOR Item;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRepresentationItemENTITY, IfcLayeredItem
	{
		public IfcRepresentationItem() : base()
		{
		}
		public IfcRepresentationItem() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRepresentationMap;
	/// <para>ENTITY IfcRepresentationMap;</para>
	/// <para>	MappingOrigin : IfcAxis2Placement;</para>
	/// <para>	MappedRepresentation : IfcRepresentation;</para>
	/// <para> INVERSE</para>
	/// <para>	MapUsage : SET [0:?] OF IfcMappedItem FOR MappingSource;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRepresentationMapENTITY
	{
		public IfcAxis2Placement MappingOrigin { get; set; }
		public IfcRepresentation MappedRepresentation { get; set; }
		public IfcRepresentationMap() : base()
		{
			MappingOrigin = new IfcAxis2Placement();
			MappedRepresentation = new IfcRepresentation();
		}
		public IfcRepresentationMap(IfcAxis2Placement MappingOrigin, IfcRepresentation MappedRepresentation) : base ()
		{
			this.MappingOrigin = MappingOrigin;
			this.MappedRepresentation = MappedRepresentation;
		}
	}
	/// <summary>
	/// ENTITY IfcResource
	/// <para>ENTITY IfcResource</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcConstructionResource))</para>
	/// <para> SUBTYPE OF (IfcObject);</para>
	/// <para> INVERSE</para>
	/// <para>	ResourceOf : SET [0:?] OF IfcRelAssignsToResource FOR RelatingResource;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcResource : IfcObject
	{
		public IfcResource() : base()
		{
		}
		public IfcResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcRevolvedAreaSolid
	/// <para>ENTITY IfcRevolvedAreaSolid</para>
	/// <para> SUBTYPE OF (IfcSweptAreaSolid);</para>
	/// <para>	Axis : IfcAxis1Placement;</para>
	/// <para>	Angle : IfcPlaneAngleMeasure;</para>
	/// <para> DERIVE</para>
	/// <para>	AxisLine : IfcLine := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcCurve() || IfcLine(Axis.Location, </para>
	/// <para>                   IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector(Axis.Z,1.0));</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : Axis.Location.Coordinates[3] = 0.0;</para>
	/// <para>	WR32 : Axis.Z.DirectionRatios[3] = 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRevolvedAreaSolid : IfcSweptAreaSolid
	{
		public IfcAxis1Placement Axis { get; set; }
		public IfcPlaneAngleMeasure Angle { get; set; }
		public IfcRevolvedAreaSolid() : base()
		{
			Axis = new IfcAxis1Placement();
			Angle = new IfcPlaneAngleMeasure();
		}
		public IfcRevolvedAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcAxis1Placement Axis, IfcPlaneAngleMeasure Angle) : base (SweptArea, Position)
		{
			this.Axis = Axis;
			this.Angle = Angle;
		}
	}
	/// <summary>
	/// ENTITY IfcRibPlateProfileProperties
	/// <para>ENTITY IfcRibPlateProfileProperties</para>
	/// <para> SUBTYPE OF (IfcProfileProperties);</para>
	/// <para>	Thickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	RibHeight : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	RibWidth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	RibSpacing : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	Direction : IfcRibPlateDirectionEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRibPlateProfileProperties : IfcProfileProperties
	{
		public IfcPositiveLengthMeasure? Thickness { get; set; }
		public IfcPositiveLengthMeasure? RibHeight { get; set; }
		public IfcPositiveLengthMeasure? RibWidth { get; set; }
		public IfcPositiveLengthMeasure? RibSpacing { get; set; }
		public IfcRibPlateDirectionEnum Direction { get; set; }
		public IfcRibPlateProfileProperties() : base()
		{
			Direction = new IfcRibPlateDirectionEnum();
		}
		public IfcRibPlateProfileProperties(IfcLabel ProfileName, IfcProfileDef ProfileDefinition, IfcPositiveLengthMeasure Thickness, IfcPositiveLengthMeasure RibHeight, IfcPositiveLengthMeasure RibWidth, IfcPositiveLengthMeasure RibSpacing, IfcRibPlateDirectionEnum Direction) : base (ProfileName, ProfileDefinition)
		{
			this.Thickness = Thickness;
			this.RibHeight = RibHeight;
			this.RibWidth = RibWidth;
			this.RibSpacing = RibSpacing;
			this.Direction = Direction;
		}
	}
	/// <summary>
	/// ENTITY IfcRightCircularCone
	/// <para>ENTITY IfcRightCircularCone</para>
	/// <para> SUBTYPE OF (IfcCsgPrimitive3D);</para>
	/// <para>	Height : IfcPositiveLengthMeasure;</para>
	/// <para>	BottomRadius : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRightCircularCone : IfcCsgPrimitive3D
	{
		public IfcPositiveLengthMeasure Height { get; set; }
		public IfcPositiveLengthMeasure BottomRadius { get; set; }
		public IfcRightCircularCone() : base()
		{
			Height = new IfcPositiveLengthMeasure();
			BottomRadius = new IfcPositiveLengthMeasure();
		}
		public IfcRightCircularCone(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Height, IfcPositiveLengthMeasure BottomRadius) : base (Position)
		{
			this.Height = Height;
			this.BottomRadius = BottomRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcRightCircularCylinder
	/// <para>ENTITY IfcRightCircularCylinder</para>
	/// <para> SUBTYPE OF (IfcCsgPrimitive3D);</para>
	/// <para>	Height : IfcPositiveLengthMeasure;</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRightCircularCylinder : IfcCsgPrimitive3D
	{
		public IfcPositiveLengthMeasure Height { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcRightCircularCylinder() : base()
		{
			Height = new IfcPositiveLengthMeasure();
			Radius = new IfcPositiveLengthMeasure();
		}
		public IfcRightCircularCylinder(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Height, IfcPositiveLengthMeasure Radius) : base (Position)
		{
			this.Height = Height;
			this.Radius = Radius;
		}
	}
	/// <summary>
	/// ENTITY IfcRoof
	/// <para>ENTITY IfcRoof</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	ShapeType : IfcRoofTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 0) OR </para>
	/// <para>            ((HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 1) AND (NOT(EXISTS(SELF\IfcProduct.Representation))));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRoof : IfcBuildingElement
	{
		public IfcRoofTypeEnum ShapeType { get; set; }
		public IfcRoof() : base()
		{
			ShapeType = new IfcRoofTypeEnum();
		}
		public IfcRoof(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcRoofTypeEnum ShapeType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.ShapeType = ShapeType;
		}
	}
	/// <summary>
	/// ENTITY IfcRoot
	/// <para>ENTITY IfcRoot</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcObjectDefinition</para>
	/// <para>	,IfcPropertyDefinition</para>
	/// <para>	,IfcRelationship));</para>
	/// <para>	GlobalId : IfcGloballyUniqueId;</para>
	/// <para>	OwnerHistory : IfcOwnerHistory;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR1 : GlobalId;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcRootENTITY
	{
		public IfcGloballyUniqueId GlobalId { get; set; }
		public IfcOwnerHistory OwnerHistory { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcRoot() : base()
		{
			GlobalId = new IfcGloballyUniqueId();
			OwnerHistory = new IfcOwnerHistory();
		}
		public IfcRoot(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description) : base ()
		{
			this.GlobalId = GlobalId;
			this.OwnerHistory = OwnerHistory;
			this.Name = Name;
			this.Description = Description;
		}
	}
	/// <summary>
	/// ENTITY IfcRoundedEdgeFeature
	/// <para>ENTITY IfcRoundedEdgeFeature</para>
	/// <para> SUBTYPE OF (IfcEdgeFeature);</para>
	/// <para>	Radius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRoundedEdgeFeature : IfcEdgeFeature
	{
		public IfcPositiveLengthMeasure? Radius { get; set; }
		public IfcRoundedEdgeFeature() : base()
		{
		}
		public IfcRoundedEdgeFeature(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure FeatureLength, IfcPositiveLengthMeasure Radius) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, FeatureLength)
		{
			this.Radius = Radius;
		}
	}
	/// <summary>
	/// ENTITY IfcRoundedRectangleProfileDef
	/// <para>ENTITY IfcRoundedRectangleProfileDef</para>
	/// <para> SUBTYPE OF (IfcRectangleProfileDef);</para>
	/// <para>	RoundingRadius : IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : ((RoundingRadius <= (SELF\IfcRectangleProfileDef.XDim/2.)) AND </para>
	/// <para>              (RoundingRadius <= (SELF\IfcRectangleProfileDef.YDim/2.)));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcRoundedRectangleProfileDef : IfcRectangleProfileDef
	{
		public IfcPositiveLengthMeasure RoundingRadius { get; set; }
		public IfcRoundedRectangleProfileDef() : base()
		{
			RoundingRadius = new IfcPositiveLengthMeasure();
		}
		public IfcRoundedRectangleProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure XDim, IfcPositiveLengthMeasure YDim, IfcPositiveLengthMeasure RoundingRadius) : base (ProfileType, ProfileName, Position, XDim, YDim)
		{
			this.RoundingRadius = RoundingRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcSIUnit
	/// <para>ENTITY IfcSIUnit</para>
	/// <para> SUBTYPE OF (IfcNamedUnit);</para>
	/// <para>	Prefix : OPTIONAL IfcSIPrefix;</para>
	/// <para>	Name : IfcSIUnitName;</para>
	/// <para> DERIVE</para>
	/// <para>	SELF\IfcNamedUnit.Dimensions : IfcDimensionalExponents := IfcDimensionsForSiUnit (SELF.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSIUnit : IfcNamedUnit
	{
		public IfcSIPrefix? Prefix { get; set; }
		public IfcSIUnitName Name { get; set; }
		public IfcSIUnit() : base()
		{
			Name = new IfcSIUnitName();
		}
		public IfcSIUnit(IfcDimensionalExponents Dimensions, IfcUnitEnum UnitType, IfcSIPrefix Prefix, IfcSIUnitName Name) : base (Dimensions, UnitType)
		{
			this.Prefix = Prefix;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcSanitaryTerminalType
	/// <para>ENTITY IfcSanitaryTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcSanitaryTerminalTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSanitaryTerminalType : IfcFlowTerminalType
	{
		public IfcSanitaryTerminalTypeEnum PredefinedType { get; set; }
		public IfcSanitaryTerminalType() : base()
		{
			PredefinedType = new IfcSanitaryTerminalTypeEnum();
		}
		public IfcSanitaryTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSanitaryTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcScheduleTimeControl
	/// <para>ENTITY IfcScheduleTimeControl</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	ActualStart : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	EarlyStart : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	LateStart : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	ScheduleStart : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	ActualFinish : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	EarlyFinish : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	LateFinish : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	ScheduleFinish : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	ScheduleDuration : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	ActualDuration : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	RemainingTime : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	FreeFloat : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	TotalFloat : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	IsCritical : OPTIONAL BOOLEAN;</para>
	/// <para>	StatusTime : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	StartFloat : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	FinishFloat : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	Completion : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para> INVERSE</para>
	/// <para>	ScheduleTimeControlAssigned : IfcRelAssignsTasks FOR TimeForTask;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcScheduleTimeControl : IfcControl
	{
		public IfcDateTimeSelect? ActualStart { get; set; }
		public IfcDateTimeSelect? EarlyStart { get; set; }
		public IfcDateTimeSelect? LateStart { get; set; }
		public IfcDateTimeSelect? ScheduleStart { get; set; }
		public IfcDateTimeSelect? ActualFinish { get; set; }
		public IfcDateTimeSelect? EarlyFinish { get; set; }
		public IfcDateTimeSelect? LateFinish { get; set; }
		public IfcDateTimeSelect? ScheduleFinish { get; set; }
		public IfcTimeMeasure? ScheduleDuration { get; set; }
		public IfcTimeMeasure? ActualDuration { get; set; }
		public IfcTimeMeasure? RemainingTime { get; set; }
		public IfcTimeMeasure? FreeFloat { get; set; }
		public IfcTimeMeasure? TotalFloat { get; set; }
		public BOOLEAN? IsCritical { get; set; }
		public IfcDateTimeSelect? StatusTime { get; set; }
		public IfcTimeMeasure? StartFloat { get; set; }
		public IfcTimeMeasure? FinishFloat { get; set; }
		public IfcPositiveRatioMeasure? Completion { get; set; }
		public IfcScheduleTimeControl() : base()
		{
		}
		public IfcScheduleTimeControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcDateTimeSelect ActualStart, IfcDateTimeSelect EarlyStart, IfcDateTimeSelect LateStart, IfcDateTimeSelect ScheduleStart, IfcDateTimeSelect ActualFinish, IfcDateTimeSelect EarlyFinish, IfcDateTimeSelect LateFinish, IfcDateTimeSelect ScheduleFinish, IfcTimeMeasure ScheduleDuration, IfcTimeMeasure ActualDuration, IfcTimeMeasure RemainingTime, IfcTimeMeasure FreeFloat, IfcTimeMeasure TotalFloat, BOOLEAN IsCritical, IfcDateTimeSelect StatusTime, IfcTimeMeasure StartFloat, IfcTimeMeasure FinishFloat, IfcPositiveRatioMeasure Completion) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ActualStart = ActualStart;
			this.EarlyStart = EarlyStart;
			this.LateStart = LateStart;
			this.ScheduleStart = ScheduleStart;
			this.ActualFinish = ActualFinish;
			this.EarlyFinish = EarlyFinish;
			this.LateFinish = LateFinish;
			this.ScheduleFinish = ScheduleFinish;
			this.ScheduleDuration = ScheduleDuration;
			this.ActualDuration = ActualDuration;
			this.RemainingTime = RemainingTime;
			this.FreeFloat = FreeFloat;
			this.TotalFloat = TotalFloat;
			this.IsCritical = IsCritical;
			this.StatusTime = StatusTime;
			this.StartFloat = StartFloat;
			this.FinishFloat = FinishFloat;
			this.Completion = Completion;
		}
	}
	/// <summary>
	/// ENTITY IfcSectionProperties;
	/// <para>ENTITY IfcSectionProperties;</para>
	/// <para>	SectionType : IfcSectionTypeEnum;</para>
	/// <para>	StartProfile : IfcProfileDef;</para>
	/// <para>	EndProfile : OPTIONAL IfcProfileDef;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSectionPropertiesENTITY
	{
		public IfcSectionTypeEnum SectionType { get; set; }
		public IfcProfileDef StartProfile { get; set; }
		public IfcProfileDef? EndProfile { get; set; }
		public IfcSectionProperties() : base()
		{
			SectionType = new IfcSectionTypeEnum();
			StartProfile = new IfcProfileDef();
		}
		public IfcSectionProperties(IfcSectionTypeEnum SectionType, IfcProfileDef StartProfile, IfcProfileDef EndProfile) : base ()
		{
			this.SectionType = SectionType;
			this.StartProfile = StartProfile;
			this.EndProfile = EndProfile;
		}
	}
	/// <summary>
	/// ENTITY IfcSectionReinforcementProperties;
	/// <para>ENTITY IfcSectionReinforcementProperties;</para>
	/// <para>	LongitudinalStartPosition : IfcLengthMeasure;</para>
	/// <para>	LongitudinalEndPosition : IfcLengthMeasure;</para>
	/// <para>	TransversePosition : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ReinforcementRole : IfcReinforcingBarRoleEnum;</para>
	/// <para>	SectionDefinition : IfcSectionProperties;</para>
	/// <para>	CrossSectionReinforcementDefinitions : SET [1:?] OF IfcReinforcementBarProperties;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSectionReinforcementPropertiesENTITY
	{
		public IfcLengthMeasure LongitudinalStartPosition { get; set; }
		public IfcLengthMeasure LongitudinalEndPosition { get; set; }
		public IfcLengthMeasure? TransversePosition { get; set; }
		public IfcReinforcingBarRoleEnum ReinforcementRole { get; set; }
		public IfcSectionProperties SectionDefinition { get; set; }
		public List<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions { get; set; }
		public IfcSectionReinforcementProperties() : base()
		{
			LongitudinalStartPosition = new IfcLengthMeasure();
			LongitudinalEndPosition = new IfcLengthMeasure();
			ReinforcementRole = new IfcReinforcingBarRoleEnum();
			SectionDefinition = new IfcSectionProperties();
			CrossSectionReinforcementDefinitions = new List<IfcReinforcementBarProperties>();
		}
		public IfcSectionReinforcementProperties(IfcLengthMeasure LongitudinalStartPosition, IfcLengthMeasure LongitudinalEndPosition, IfcLengthMeasure TransversePosition, IfcReinforcingBarRoleEnum ReinforcementRole, IfcSectionProperties SectionDefinition, List<IfcReinforcementBarProperties> CrossSectionReinforcementDefinitions) : base ()
		{
			this.LongitudinalStartPosition = LongitudinalStartPosition;
			this.LongitudinalEndPosition = LongitudinalEndPosition;
			this.TransversePosition = TransversePosition;
			this.ReinforcementRole = ReinforcementRole;
			this.SectionDefinition = SectionDefinition;
			this.CrossSectionReinforcementDefinitions = CrossSectionReinforcementDefinitions;
		}
	}
	/// <summary>
	/// ENTITY IfcSectionedSpine
	/// <para>ENTITY IfcSectionedSpine</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	SpineCurve : IfcCompositeCurve;</para>
	/// <para>	CrossSections : LIST [2:?] OF IfcProfileDef;</para>
	/// <para>	CrossSectionPositions : LIST [2:?] OF IfcAxis2Placement3D;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(CrossSections) = SIZEOF(CrossSectionPositions);</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* CrossSections | CrossSections[1].ProfileType <> temp.ProfileType)) = 0;</para>
	/// <para>	WR3 : SpineCurve.Dim = 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSectionedSpine : IfcGeometricRepresentationItem
	{
		public IfcCompositeCurve SpineCurve { get; set; }
		public List<IfcProfileDef> CrossSections { get; set; }
		public List<IfcAxis2Placement3D> CrossSectionPositions { get; set; }
		public IfcSectionedSpine() : base()
		{
			SpineCurve = new IfcCompositeCurve();
			CrossSections = new List<IfcProfileDef>();
			CrossSectionPositions = new List<IfcAxis2Placement3D>();
		}
		public IfcSectionedSpine(IfcCompositeCurve SpineCurve, List<IfcProfileDef> CrossSections, List<IfcAxis2Placement3D> CrossSectionPositions) : base ()
		{
			this.SpineCurve = SpineCurve;
			this.CrossSections = CrossSections;
			this.CrossSectionPositions = CrossSectionPositions;
		}
	}
	/// <summary>
	/// ENTITY IfcSensorType
	/// <para>ENTITY IfcSensorType</para>
	/// <para> SUBTYPE OF (IfcDistributionControlElementType);</para>
	/// <para>	PredefinedType : IfcSensorTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSensorType : IfcDistributionControlElementType
	{
		public IfcSensorTypeEnum PredefinedType { get; set; }
		public IfcSensorType() : base()
		{
			PredefinedType = new IfcSensorTypeEnum();
		}
		public IfcSensorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSensorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcServiceLife
	/// <para>ENTITY IfcServiceLife</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	ServiceLifeType : IfcServiceLifeTypeEnum;</para>
	/// <para>	ServiceLifeDuration : IfcTimeMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcServiceLife : IfcControl
	{
		public IfcServiceLifeTypeEnum ServiceLifeType { get; set; }
		public IfcTimeMeasure ServiceLifeDuration { get; set; }
		public IfcServiceLife() : base()
		{
			ServiceLifeType = new IfcServiceLifeTypeEnum();
			ServiceLifeDuration = new IfcTimeMeasure();
		}
		public IfcServiceLife(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcServiceLifeTypeEnum ServiceLifeType, IfcTimeMeasure ServiceLifeDuration) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ServiceLifeType = ServiceLifeType;
			this.ServiceLifeDuration = ServiceLifeDuration;
		}
	}
	/// <summary>
	/// ENTITY IfcServiceLifeFactor
	/// <para>ENTITY IfcServiceLifeFactor</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	PredefinedType : IfcServiceLifeFactorTypeEnum;</para>
	/// <para>	UpperValue : OPTIONAL IfcMeasureValue;</para>
	/// <para>	MostUsedValue : IfcMeasureValue;</para>
	/// <para>	LowerValue : OPTIONAL IfcMeasureValue;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(PredefinedType = IfcServiceLifeFactorTypeEnum.USERDEFINED)</para>
	/// <para>             OR EXISTS(SELF\IfcObject.ObjectType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcServiceLifeFactor : IfcPropertySetDefinition
	{
		public IfcServiceLifeFactorTypeEnum PredefinedType { get; set; }
		public IfcMeasureValue? UpperValue { get; set; }
		public IfcMeasureValue MostUsedValue { get; set; }
		public IfcMeasureValue? LowerValue { get; set; }
		public IfcServiceLifeFactor() : base()
		{
			PredefinedType = new IfcServiceLifeFactorTypeEnum();
			MostUsedValue = new IfcMeasureValue();
		}
		public IfcServiceLifeFactor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcServiceLifeFactorTypeEnum PredefinedType, IfcMeasureValue UpperValue, IfcMeasureValue MostUsedValue, IfcMeasureValue LowerValue) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.PredefinedType = PredefinedType;
			this.UpperValue = UpperValue;
			this.MostUsedValue = MostUsedValue;
			this.LowerValue = LowerValue;
		}
	}
	/// <summary>
	/// ENTITY IfcShapeAspect;
	/// <para>ENTITY IfcShapeAspect;</para>
	/// <para>	ShapeRepresentations : LIST [1:?] OF IfcShapeModel;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	ProductDefinitional : LOGICAL;</para>
	/// <para>	PartOfProductDefinitionShape : IfcProductDefinitionShape;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcShapeAspectENTITY
	{
		public List<IfcShapeModel> ShapeRepresentations { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcText? Description { get; set; }
		public LOGICAL ProductDefinitional { get; set; }
		public IfcProductDefinitionShape PartOfProductDefinitionShape { get; set; }
		public IfcShapeAspect() : base()
		{
			ShapeRepresentations = new List<IfcShapeModel>();
			ProductDefinitional = new LOGICAL();
			PartOfProductDefinitionShape = new IfcProductDefinitionShape();
		}
		public IfcShapeAspect(List<IfcShapeModel> ShapeRepresentations, IfcLabel Name, IfcText Description, LOGICAL ProductDefinitional, IfcProductDefinitionShape PartOfProductDefinitionShape) : base ()
		{
			this.ShapeRepresentations = ShapeRepresentations;
			this.Name = Name;
			this.Description = Description;
			this.ProductDefinitional = ProductDefinitional;
			this.PartOfProductDefinitionShape = PartOfProductDefinitionShape;
		}
	}
	/// <summary>
	/// ENTITY IfcShapeModel
	/// <para>ENTITY IfcShapeModel</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcShapeRepresentation</para>
	/// <para>	,IfcTopologyRepresentation))</para>
	/// <para> SUBTYPE OF (IfcRepresentation);</para>
	/// <para> INVERSE</para>
	/// <para>	OfShapeAspect : SET [0:1] OF IfcShapeAspect FOR ShapeRepresentations;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : (SIZEOF(SELF\IfcRepresentation.OfProductRepresentation) = 1) XOR </para>
	/// <para>             (SIZEOF(SELF\IfcRepresentation.RepresentationMap) = 1) XOR</para>
	/// <para>             (SIZEOF(OfShapeAspect) = 1);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcShapeModel : IfcRepresentation
	{
		public IfcShapeModel() : base()
		{
		}
		public IfcShapeModel(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base (ContextOfItems, RepresentationIdentifier, RepresentationType, Items)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcShapeRepresentation
	/// <para>ENTITY IfcShapeRepresentation</para>
	/// <para> SUBTYPE OF (IfcShapeModel);</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : 'IFC2X3.IFCGEOMETRICREPRESENTATIONCONTEXT' </para>
	/// <para>             IN TYPEOF(SELF\IfcRepresentation.ContextOfItems);</para>
	/// <para>	WR22 : SIZEOF(QUERY(temp <* Items | </para>
	/// <para>               ('IFC2X3.IFCTOPOLOGICALREPRESENTATIONITEM' IN TYPEOF(temp))</para>
	/// <para>                 AND (NOT(SIZEOF(</para>
	/// <para>                   ['IFC2X3.IFCVERTEXPOINT',</para>
	/// <para>                    'IFC2X3.IFCEDGECURVE',</para>
	/// <para>                    'IFC2X3.IFCFACESURFACE'] * TYPEOF(temp)) = 1))</para>
	/// <para>             )) = 0;</para>
	/// <para>	WR23 : EXISTS(SELF\IfcRepresentation.RepresentationType);</para>
	/// <para>	WR24 : IfcShapeRepresentationTypes(SELF\IfcRepresentation.RepresentationType, SELF\IfcRepresentation.Items);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcShapeRepresentation : IfcShapeModel
	{
		public IfcShapeRepresentation() : base()
		{
		}
		public IfcShapeRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base (ContextOfItems, RepresentationIdentifier, RepresentationType, Items)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcShellBasedSurfaceModel
	/// <para>ENTITY IfcShellBasedSurfaceModel</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	SbsmBoundary : SET [1:?] OF IfcShell;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem
	{
		public List<IfcShell> SbsmBoundary { get; set; }
		public IfcShellBasedSurfaceModel() : base()
		{
			SbsmBoundary = new List<IfcShell>();
		}
		public IfcShellBasedSurfaceModel(List<IfcShell> SbsmBoundary) : base ()
		{
			this.SbsmBoundary = SbsmBoundary;
		}
	}
	/// <summary>
	/// ENTITY IfcSimpleProperty
	/// <para>ENTITY IfcSimpleProperty</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcPropertyBoundedValue</para>
	/// <para>	,IfcPropertyEnumeratedValue</para>
	/// <para>	,IfcPropertyListValue</para>
	/// <para>	,IfcPropertyReferenceValue</para>
	/// <para>	,IfcPropertySingleValue</para>
	/// <para>	,IfcPropertyTableValue))</para>
	/// <para> SUBTYPE OF (IfcProperty);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSimpleProperty : IfcProperty
	{
		public IfcSimpleProperty() : base()
		{
		}
		public IfcSimpleProperty(IfcIdentifier Name, IfcText Description) : base (Name, Description)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSite
	/// <para>ENTITY IfcSite</para>
	/// <para> SUBTYPE OF (IfcSpatialStructureElement);</para>
	/// <para>	RefLatitude : OPTIONAL IfcCompoundPlaneAngleMeasure;</para>
	/// <para>	RefLongitude : OPTIONAL IfcCompoundPlaneAngleMeasure;</para>
	/// <para>	RefElevation : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	LandTitleNumber : OPTIONAL IfcLabel;</para>
	/// <para>	SiteAddress : OPTIONAL IfcPostalAddress;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSite : IfcSpatialStructureElement
	{
		public IfcCompoundPlaneAngleMeasure? RefLatitude { get; set; }
		public IfcCompoundPlaneAngleMeasure? RefLongitude { get; set; }
		public IfcLengthMeasure? RefElevation { get; set; }
		public IfcLabel? LandTitleNumber { get; set; }
		public IfcPostalAddress? SiteAddress { get; set; }
		public IfcSite() : base()
		{
		}
		public IfcSite(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcCompoundPlaneAngleMeasure RefLatitude, IfcCompoundPlaneAngleMeasure RefLongitude, IfcLengthMeasure RefElevation, IfcLabel LandTitleNumber, IfcPostalAddress SiteAddress) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, LongName, CompositionType)
		{
			this.RefLatitude = RefLatitude;
			this.RefLongitude = RefLongitude;
			this.RefElevation = RefElevation;
			this.LandTitleNumber = LandTitleNumber;
			this.SiteAddress = SiteAddress;
		}
	}
	/// <summary>
	/// ENTITY IfcSlab
	/// <para>ENTITY IfcSlab</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	PredefinedType : OPTIONAL IfcSlabTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : NOT(EXISTS(PredefinedType)) OR</para>
	/// <para>              (PredefinedType <> IfcSlabTypeEnum.USERDEFINED) OR</para>
	/// <para>              ((PredefinedType = IfcSlabTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSlab : IfcBuildingElement
	{
		public IfcSlabTypeEnum? PredefinedType { get; set; }
		public IfcSlab() : base()
		{
		}
		public IfcSlab(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcSlabTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcSlabType
	/// <para>ENTITY IfcSlabType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcSlabTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSlabType : IfcBuildingElementType
	{
		public IfcSlabTypeEnum PredefinedType { get; set; }
		public IfcSlabType() : base()
		{
			PredefinedType = new IfcSlabTypeEnum();
		}
		public IfcSlabType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSlabTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcSlippageConnectionCondition
	/// <para>ENTITY IfcSlippageConnectionCondition</para>
	/// <para> SUBTYPE OF (IfcStructuralConnectionCondition);</para>
	/// <para>	SlippageX : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	SlippageY : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	SlippageZ : OPTIONAL IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSlippageConnectionCondition : IfcStructuralConnectionCondition
	{
		public IfcLengthMeasure? SlippageX { get; set; }
		public IfcLengthMeasure? SlippageY { get; set; }
		public IfcLengthMeasure? SlippageZ { get; set; }
		public IfcSlippageConnectionCondition() : base()
		{
		}
		public IfcSlippageConnectionCondition(IfcLabel Name, IfcLengthMeasure SlippageX, IfcLengthMeasure SlippageY, IfcLengthMeasure SlippageZ) : base (Name)
		{
			this.SlippageX = SlippageX;
			this.SlippageY = SlippageY;
			this.SlippageZ = SlippageZ;
		}
	}
	/// <summary>
	/// ENTITY IfcSolidModel
	/// <para>ENTITY IfcSolidModel</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcCsgSolid</para>
	/// <para>	,IfcManifoldSolidBrep</para>
	/// <para>	,IfcSweptAreaSolid</para>
	/// <para>	,IfcSweptDiskSolid))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := 3;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSolidModel : IfcGeometricRepresentationItem, IfcBooleanOperand
	{
		public IfcSolidModel() : base()
		{
		}
		public IfcSolidModel() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSoundProperties
	/// <para>ENTITY IfcSoundProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	IsAttenuating : IfcBoolean;</para>
	/// <para>	SoundScale : OPTIONAL IfcSoundScaleEnum;</para>
	/// <para>	SoundValues : LIST [1:8] OF IfcSoundValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSoundProperties : IfcPropertySetDefinition
	{
		public IfcBoolean IsAttenuating { get; set; }
		public IfcSoundScaleEnum? SoundScale { get; set; }
		public List<IfcSoundValue> SoundValues { get; set; }
		public IfcSoundProperties() : base()
		{
			IsAttenuating = new IfcBoolean();
			SoundValues = new List<IfcSoundValue>();
		}
		public IfcSoundProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcBoolean IsAttenuating, IfcSoundScaleEnum SoundScale, List<IfcSoundValue> SoundValues) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.IsAttenuating = IsAttenuating;
			this.SoundScale = SoundScale;
			this.SoundValues = SoundValues;
		}
	}
	/// <summary>
	/// ENTITY IfcSoundValue
	/// <para>ENTITY IfcSoundValue</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	SoundLevelTimeSeries : OPTIONAL IfcTimeSeries;</para>
	/// <para>	Frequency : IfcFrequencyMeasure;</para>
	/// <para>	SoundLevelSingleValue : OPTIONAL IfcDerivedMeasureValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSoundValue : IfcPropertySetDefinition
	{
		public IfcTimeSeries? SoundLevelTimeSeries { get; set; }
		public IfcFrequencyMeasure Frequency { get; set; }
		public IfcDerivedMeasureValue? SoundLevelSingleValue { get; set; }
		public IfcSoundValue() : base()
		{
			Frequency = new IfcFrequencyMeasure();
		}
		public IfcSoundValue(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcTimeSeries SoundLevelTimeSeries, IfcFrequencyMeasure Frequency, IfcDerivedMeasureValue SoundLevelSingleValue) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.SoundLevelTimeSeries = SoundLevelTimeSeries;
			this.Frequency = Frequency;
			this.SoundLevelSingleValue = SoundLevelSingleValue;
		}
	}
	/// <summary>
	/// ENTITY IfcSpace
	/// <para>ENTITY IfcSpace</para>
	/// <para> SUBTYPE OF (IfcSpatialStructureElement);</para>
	/// <para>	InteriorOrExteriorSpace : IfcInternalOrExternalEnum;</para>
	/// <para>	ElevationWithFlooring : OPTIONAL IfcLengthMeasure;</para>
	/// <para> INVERSE</para>
	/// <para>	HasCoverings : SET [0:?] OF IfcRelCoversSpaces FOR RelatedSpace;</para>
	/// <para>	BoundedBy : SET [0:?] OF IfcRelSpaceBoundary FOR RelatingSpace;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSpace : IfcSpatialStructureElement
	{
		public IfcInternalOrExternalEnum InteriorOrExteriorSpace { get; set; }
		public IfcLengthMeasure? ElevationWithFlooring { get; set; }
		public IfcSpace() : base()
		{
			InteriorOrExteriorSpace = new IfcInternalOrExternalEnum();
		}
		public IfcSpace(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType, IfcInternalOrExternalEnum InteriorOrExteriorSpace, IfcLengthMeasure ElevationWithFlooring) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, LongName, CompositionType)
		{
			this.InteriorOrExteriorSpace = InteriorOrExteriorSpace;
			this.ElevationWithFlooring = ElevationWithFlooring;
		}
	}
	/// <summary>
	/// ENTITY IfcSpaceHeaterType
	/// <para>ENTITY IfcSpaceHeaterType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcSpaceHeaterTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcSpaceHeaterTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcSpaceHeaterTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSpaceHeaterType : IfcEnergyConversionDeviceType
	{
		public IfcSpaceHeaterTypeEnum PredefinedType { get; set; }
		public IfcSpaceHeaterType() : base()
		{
			PredefinedType = new IfcSpaceHeaterTypeEnum();
		}
		public IfcSpaceHeaterType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSpaceHeaterTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcSpaceProgram
	/// <para>ENTITY IfcSpaceProgram</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	SpaceProgramIdentifier : IfcIdentifier;</para>
	/// <para>	MaxRequiredArea : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	MinRequiredArea : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	RequestedLocation : OPTIONAL IfcSpatialStructureElement;</para>
	/// <para>	StandardRequiredArea : IfcAreaMeasure;</para>
	/// <para> INVERSE</para>
	/// <para>	HasInteractionReqsFrom : SET [0:?] OF IfcRelInteractionRequirements FOR RelatedSpaceProgram;</para>
	/// <para>	HasInteractionReqsTo : SET [0:?] OF IfcRelInteractionRequirements FOR RelatingSpaceProgram;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSpaceProgram : IfcControl
	{
		public IfcIdentifier SpaceProgramIdentifier { get; set; }
		public IfcAreaMeasure? MaxRequiredArea { get; set; }
		public IfcAreaMeasure? MinRequiredArea { get; set; }
		public IfcSpatialStructureElement? RequestedLocation { get; set; }
		public IfcAreaMeasure StandardRequiredArea { get; set; }
		public IfcSpaceProgram() : base()
		{
			SpaceProgramIdentifier = new IfcIdentifier();
			StandardRequiredArea = new IfcAreaMeasure();
		}
		public IfcSpaceProgram(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier SpaceProgramIdentifier, IfcAreaMeasure MaxRequiredArea, IfcAreaMeasure MinRequiredArea, IfcSpatialStructureElement RequestedLocation, IfcAreaMeasure StandardRequiredArea) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.SpaceProgramIdentifier = SpaceProgramIdentifier;
			this.MaxRequiredArea = MaxRequiredArea;
			this.MinRequiredArea = MinRequiredArea;
			this.RequestedLocation = RequestedLocation;
			this.StandardRequiredArea = StandardRequiredArea;
		}
	}
	/// <summary>
	/// ENTITY IfcSpaceThermalLoadProperties
	/// <para>ENTITY IfcSpaceThermalLoadProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	ApplicableValueRatio : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	ThermalLoadSource : IfcThermalLoadSourceEnum;</para>
	/// <para>	PropertySource : IfcPropertySourceEnum;</para>
	/// <para>	SourceDescription : OPTIONAL IfcText;</para>
	/// <para>	MaximumValue : IfcPowerMeasure;</para>
	/// <para>	MinimumValue : OPTIONAL IfcPowerMeasure;</para>
	/// <para>	ThermalLoadTimeSeriesValues : OPTIONAL IfcTimeSeries;</para>
	/// <para>	UserDefinedThermalLoadSource : OPTIONAL IfcLabel;</para>
	/// <para>	UserDefinedPropertySource : OPTIONAL IfcLabel;</para>
	/// <para>	ThermalLoadType : IfcThermalLoadTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSpaceThermalLoadProperties : IfcPropertySetDefinition
	{
		public IfcPositiveRatioMeasure? ApplicableValueRatio { get; set; }
		public IfcThermalLoadSourceEnum ThermalLoadSource { get; set; }
		public IfcPropertySourceEnum PropertySource { get; set; }
		public IfcText? SourceDescription { get; set; }
		public IfcPowerMeasure MaximumValue { get; set; }
		public IfcPowerMeasure? MinimumValue { get; set; }
		public IfcTimeSeries? ThermalLoadTimeSeriesValues { get; set; }
		public IfcLabel? UserDefinedThermalLoadSource { get; set; }
		public IfcLabel? UserDefinedPropertySource { get; set; }
		public IfcThermalLoadTypeEnum ThermalLoadType { get; set; }
		public IfcSpaceThermalLoadProperties() : base()
		{
			ThermalLoadSource = new IfcThermalLoadSourceEnum();
			PropertySource = new IfcPropertySourceEnum();
			MaximumValue = new IfcPowerMeasure();
			ThermalLoadType = new IfcThermalLoadTypeEnum();
		}
		public IfcSpaceThermalLoadProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveRatioMeasure ApplicableValueRatio, IfcThermalLoadSourceEnum ThermalLoadSource, IfcPropertySourceEnum PropertySource, IfcText SourceDescription, IfcPowerMeasure MaximumValue, IfcPowerMeasure MinimumValue, IfcTimeSeries ThermalLoadTimeSeriesValues, IfcLabel UserDefinedThermalLoadSource, IfcLabel UserDefinedPropertySource, IfcThermalLoadTypeEnum ThermalLoadType) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.ApplicableValueRatio = ApplicableValueRatio;
			this.ThermalLoadSource = ThermalLoadSource;
			this.PropertySource = PropertySource;
			this.SourceDescription = SourceDescription;
			this.MaximumValue = MaximumValue;
			this.MinimumValue = MinimumValue;
			this.ThermalLoadTimeSeriesValues = ThermalLoadTimeSeriesValues;
			this.UserDefinedThermalLoadSource = UserDefinedThermalLoadSource;
			this.UserDefinedPropertySource = UserDefinedPropertySource;
			this.ThermalLoadType = ThermalLoadType;
		}
	}
	/// <summary>
	/// ENTITY IfcSpaceType
	/// <para>ENTITY IfcSpaceType</para>
	/// <para> SUBTYPE OF (IfcSpatialStructureElementType);</para>
	/// <para>	PredefinedType : IfcSpaceTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSpaceType : IfcSpatialStructureElementType
	{
		public IfcSpaceTypeEnum PredefinedType { get; set; }
		public IfcSpaceType() : base()
		{
			PredefinedType = new IfcSpaceTypeEnum();
		}
		public IfcSpaceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSpaceTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcSpatialStructureElement
	/// <para>ENTITY IfcSpatialStructureElement</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBuilding</para>
	/// <para>	,IfcBuildingStorey</para>
	/// <para>	,IfcSite</para>
	/// <para>	,IfcSpace))</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para>	LongName : OPTIONAL IfcLabel;</para>
	/// <para>	CompositionType : IfcElementCompositionEnum;</para>
	/// <para> INVERSE</para>
	/// <para>	ReferencesElements : SET [0:?] OF IfcRelReferencedInSpatialStructure FOR RelatingStructure;</para>
	/// <para>	ServicedBySystems : SET [0:?] OF IfcRelServicesBuildings FOR RelatedBuildings;</para>
	/// <para>	ContainsElements : SET [0:?] OF IfcRelContainedInSpatialStructure FOR RelatingStructure;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : (HIINDEX(SELF\IfcObjectDefinition.Decomposes) = 1) </para>
	/// <para>             AND</para>
	/// <para>             ('IFC2X3.IFCRELAGGREGATES' IN TYPEOF(SELF\IfcObjectDefinition.Decomposes[1])) </para>
	/// <para>             AND</para>
	/// <para>             (('IFC2X3.IFCPROJECT' IN TYPEOF (SELF\IfcObjectDefinition.Decomposes[1].RelatingObject)) OR</para>
	/// <para>              ('IFC2X3.IFCSPATIALSTRUCTUREELEMENT' IN TYPEOF (SELF\IfcObjectDefinition.Decomposes[1].RelatingObject))</para>
	/// <para>             );</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSpatialStructureElement : IfcProduct
	{
		public IfcLabel? LongName { get; set; }
		public IfcElementCompositionEnum CompositionType { get; set; }
		public IfcSpatialStructureElement() : base()
		{
			CompositionType = new IfcElementCompositionEnum();
		}
		public IfcSpatialStructureElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcLabel LongName, IfcElementCompositionEnum CompositionType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.LongName = LongName;
			this.CompositionType = CompositionType;
		}
	}
	/// <summary>
	/// ENTITY IfcSpatialStructureElementType
	/// <para>ENTITY IfcSpatialStructureElementType</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcSpaceType))</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSpatialStructureElementType : IfcElementType
	{
		public IfcSpatialStructureElementType() : base()
		{
		}
		public IfcSpatialStructureElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSphere
	/// <para>ENTITY IfcSphere</para>
	/// <para> SUBTYPE OF (IfcCsgPrimitive3D);</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSphere : IfcCsgPrimitive3D
	{
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcSphere() : base()
		{
			Radius = new IfcPositiveLengthMeasure();
		}
		public IfcSphere(IfcAxis2Placement3D Position, IfcPositiveLengthMeasure Radius) : base (Position)
		{
			this.Radius = Radius;
		}
	}
	/// <summary>
	/// ENTITY IfcStackTerminalType
	/// <para>ENTITY IfcStackTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcStackTerminalTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStackTerminalType : IfcFlowTerminalType
	{
		public IfcStackTerminalTypeEnum PredefinedType { get; set; }
		public IfcStackTerminalType() : base()
		{
			PredefinedType = new IfcStackTerminalTypeEnum();
		}
		public IfcStackTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcStackTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcStair
	/// <para>ENTITY IfcStair</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	ShapeType : IfcStairTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 0) OR </para>
	/// <para>            ((HIINDEX(SELF\IfcObjectDefinition.IsDecomposedBy) = 1) AND (NOT(EXISTS(SELF\IfcProduct.Representation))));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStair : IfcBuildingElement
	{
		public IfcStairTypeEnum ShapeType { get; set; }
		public IfcStair() : base()
		{
			ShapeType = new IfcStairTypeEnum();
		}
		public IfcStair(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcStairTypeEnum ShapeType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.ShapeType = ShapeType;
		}
	}
	/// <summary>
	/// ENTITY IfcStairFlight
	/// <para>ENTITY IfcStairFlight</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	NumberOfRiser : OPTIONAL INTEGER;</para>
	/// <para>	NumberOfTreads : OPTIONAL INTEGER;</para>
	/// <para>	RiserHeight : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	TreadLength : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStairFlight : IfcBuildingElement
	{
		public INTEGER? NumberOfRiser { get; set; }
		public INTEGER? NumberOfTreads { get; set; }
		public IfcPositiveLengthMeasure? RiserHeight { get; set; }
		public IfcPositiveLengthMeasure? TreadLength { get; set; }
		public IfcStairFlight() : base()
		{
		}
		public IfcStairFlight(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, INTEGER NumberOfRiser, INTEGER NumberOfTreads, IfcPositiveLengthMeasure RiserHeight, IfcPositiveLengthMeasure TreadLength) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.NumberOfRiser = NumberOfRiser;
			this.NumberOfTreads = NumberOfTreads;
			this.RiserHeight = RiserHeight;
			this.TreadLength = TreadLength;
		}
	}
	/// <summary>
	/// ENTITY IfcStairFlightType
	/// <para>ENTITY IfcStairFlightType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcStairFlightTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStairFlightType : IfcBuildingElementType
	{
		public IfcStairFlightTypeEnum PredefinedType { get; set; }
		public IfcStairFlightType() : base()
		{
			PredefinedType = new IfcStairFlightTypeEnum();
		}
		public IfcStairFlightType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcStairFlightTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralAction
	/// <para>ENTITY IfcStructuralAction</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLinearAction</para>
	/// <para>	,IfcStructuralPlanarAction</para>
	/// <para>	,IfcStructuralPointAction))</para>
	/// <para> SUBTYPE OF (IfcStructuralActivity);</para>
	/// <para>	DestabilizingLoad : BOOLEAN;</para>
	/// <para>	CausedBy : OPTIONAL IfcStructuralReaction;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralAction : IfcStructuralActivity
	{
		public BOOLEAN DestabilizingLoad { get; set; }
		public IfcStructuralReaction? CausedBy { get; set; }
		public IfcStructuralAction() : base()
		{
			DestabilizingLoad = new BOOLEAN();
		}
		public IfcStructuralAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal)
		{
			this.DestabilizingLoad = DestabilizingLoad;
			this.CausedBy = CausedBy;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralActivity
	/// <para>ENTITY IfcStructuralActivity</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralAction</para>
	/// <para>	,IfcStructuralReaction))</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para>	AppliedLoad : IfcStructuralLoad;</para>
	/// <para>	GlobalOrLocal : IfcGlobalOrLocalEnum;</para>
	/// <para> INVERSE</para>
	/// <para>	AssignedToStructuralItem : IfcRelConnectsStructuralActivity FOR RelatedStructuralActivity;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralActivity : IfcProduct
	{
		public IfcStructuralLoad AppliedLoad { get; set; }
		public IfcGlobalOrLocalEnum GlobalOrLocal { get; set; }
		public IfcStructuralActivity() : base()
		{
			AppliedLoad = new IfcStructuralLoad();
			GlobalOrLocal = new IfcGlobalOrLocalEnum();
		}
		public IfcStructuralActivity(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.AppliedLoad = AppliedLoad;
			this.GlobalOrLocal = GlobalOrLocal;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralAnalysisModel
	/// <para>ENTITY IfcStructuralAnalysisModel</para>
	/// <para> SUBTYPE OF (IfcSystem);</para>
	/// <para>	PredefinedType : IfcAnalysisModelTypeEnum;</para>
	/// <para>	OrientationOf2DPlane : OPTIONAL IfcAxis2Placement3D;</para>
	/// <para>	LoadedBy : OPTIONAL SET [1:?] OF IfcStructuralLoadGroup;</para>
	/// <para>	HasResults : OPTIONAL SET [1:?] OF IfcStructuralResultGroup;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralAnalysisModel : IfcSystem
	{
		public IfcAnalysisModelTypeEnum PredefinedType { get; set; }
		public IfcAxis2Placement3D? OrientationOf2DPlane { get; set; }
		public List<IfcStructuralLoadGroup>? LoadedBy { get; set; }
		public List<IfcStructuralResultGroup>? HasResults { get; set; }
		public IfcStructuralAnalysisModel() : base()
		{
			PredefinedType = new IfcAnalysisModelTypeEnum();
		}
		public IfcStructuralAnalysisModel(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcAnalysisModelTypeEnum PredefinedType, IfcAxis2Placement3D OrientationOf2DPlane, List<IfcStructuralLoadGroup> LoadedBy, List<IfcStructuralResultGroup> HasResults) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.PredefinedType = PredefinedType;
			this.OrientationOf2DPlane = OrientationOf2DPlane;
			this.LoadedBy = LoadedBy;
			this.HasResults = HasResults;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralConnection
	/// <para>ENTITY IfcStructuralConnection</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralCurveConnection</para>
	/// <para>	,IfcStructuralPointConnection</para>
	/// <para>	,IfcStructuralSurfaceConnection))</para>
	/// <para> SUBTYPE OF (IfcStructuralItem);</para>
	/// <para>	AppliedCondition : OPTIONAL IfcBoundaryCondition;</para>
	/// <para> INVERSE</para>
	/// <para>	ConnectsStructuralMembers : SET [1:?] OF IfcRelConnectsStructuralMember FOR RelatedStructuralConnection;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralConnection : IfcStructuralItem
	{
		public IfcBoundaryCondition? AppliedCondition { get; set; }
		public IfcStructuralConnection() : base()
		{
		}
		public IfcStructuralConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.AppliedCondition = AppliedCondition;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralConnectionCondition
	/// <para>ENTITY IfcStructuralConnectionCondition</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcFailureConnectionCondition</para>
	/// <para>	,IfcSlippageConnectionCondition));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralConnectionConditionENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcStructuralConnectionCondition() : base()
		{
		}
		public IfcStructuralConnectionCondition(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralCurveConnection
	/// <para>ENTITY IfcStructuralCurveConnection</para>
	/// <para> SUBTYPE OF (IfcStructuralConnection);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralCurveConnection : IfcStructuralConnection
	{
		public IfcStructuralCurveConnection() : base()
		{
		}
		public IfcStructuralCurveConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedCondition)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralCurveMember
	/// <para>ENTITY IfcStructuralCurveMember</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralCurveMemberVarying))</para>
	/// <para> SUBTYPE OF (IfcStructuralMember);</para>
	/// <para>	PredefinedType : IfcStructuralCurveTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralCurveMember : IfcStructuralMember
	{
		public IfcStructuralCurveTypeEnum PredefinedType { get; set; }
		public IfcStructuralCurveMember() : base()
		{
			PredefinedType = new IfcStructuralCurveTypeEnum();
		}
		public IfcStructuralCurveMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralCurveTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralCurveMemberVarying
	/// <para>ENTITY IfcStructuralCurveMemberVarying</para>
	/// <para> SUBTYPE OF (IfcStructuralCurveMember);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralCurveMemberVarying : IfcStructuralCurveMember
	{
		public IfcStructuralCurveMemberVarying() : base()
		{
		}
		public IfcStructuralCurveMemberVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralCurveTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, PredefinedType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralItem
	/// <para>ENTITY IfcStructuralItem</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralConnection</para>
	/// <para>	,IfcStructuralMember))</para>
	/// <para> SUBTYPE OF (IfcProduct);</para>
	/// <para> INVERSE</para>
	/// <para>	AssignedStructuralActivity : SET [0:?] OF IfcRelConnectsStructuralActivity FOR RelatingElement;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralItem : IfcProduct, IfcStructuralActivityAssignmentSelect
	{
		public IfcStructuralItem() : base()
		{
		}
		public IfcStructuralItem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLinearAction
	/// <para>ENTITY IfcStructuralLinearAction</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLinearActionVarying))</para>
	/// <para> SUBTYPE OF (IfcStructuralAction);</para>
	/// <para>	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : SIZEOF(['IFC2X3.IFCSTRUCTURALLOADLINEARFORCE',</para>
	/// <para>                     'IFC2X3.IFCSTRUCTURALLOADTEMPERATURE']</para>
	/// <para>             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLinearAction : IfcStructuralAction
	{
		public IfcProjectedOrTrueLengthEnum ProjectedOrTrue { get; set; }
		public IfcStructuralLinearAction() : base()
		{
			ProjectedOrTrue = new IfcProjectedOrTrueLengthEnum();
		}
		public IfcStructuralLinearAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy, IfcProjectedOrTrueLengthEnum ProjectedOrTrue) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal, DestabilizingLoad, CausedBy)
		{
			this.ProjectedOrTrue = ProjectedOrTrue;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLinearActionVarying
	/// <para>ENTITY IfcStructuralLinearActionVarying</para>
	/// <para> SUBTYPE OF (IfcStructuralLinearAction);</para>
	/// <para>	VaryingAppliedLoadLocation : IfcShapeAspect;</para>
	/// <para>	SubsequentAppliedLoads : LIST [1:?] OF IfcStructuralLoad;</para>
	/// <para> DERIVE</para>
	/// <para>	VaryingAppliedLoads : LIST [2:?] OF IfcStructuralLoad := IfcAddToBeginOfList(SELF\IfcStructuralActivity.AppliedLoad, SubsequentAppliedLoads);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLinearActionVarying : IfcStructuralLinearAction
	{
		public IfcShapeAspect VaryingAppliedLoadLocation { get; set; }
		public List<IfcStructuralLoad> SubsequentAppliedLoads { get; set; }
		public IfcStructuralLinearActionVarying() : base()
		{
			VaryingAppliedLoadLocation = new IfcShapeAspect();
			SubsequentAppliedLoads = new List<IfcStructuralLoad>();
		}
		public IfcStructuralLinearActionVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcShapeAspect VaryingAppliedLoadLocation, List<IfcStructuralLoad> SubsequentAppliedLoads) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal, DestabilizingLoad, CausedBy, ProjectedOrTrue)
		{
			this.VaryingAppliedLoadLocation = VaryingAppliedLoadLocation;
			this.SubsequentAppliedLoads = SubsequentAppliedLoads;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoad
	/// <para>ENTITY IfcStructuralLoad</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLoadStatic));</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralLoadENTITY
	{
		public IfcLabel? Name { get; set; }
		public IfcStructuralLoad() : base()
		{
		}
		public IfcStructuralLoad(IfcLabel Name) : base ()
		{
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadGroup
	/// <para>ENTITY IfcStructuralLoadGroup</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para>	PredefinedType : IfcLoadGroupTypeEnum;</para>
	/// <para>	ActionType : IfcActionTypeEnum;</para>
	/// <para>	ActionSource : IfcActionSourceTypeEnum;</para>
	/// <para>	Coefficient : OPTIONAL IfcRatioMeasure;</para>
	/// <para>	Purpose : OPTIONAL IfcLabel;</para>
	/// <para> INVERSE</para>
	/// <para>	SourceOfResultGroup : SET [0:1] OF IfcStructuralResultGroup FOR ResultForLoadGroup;</para>
	/// <para>	LoadGroupFor : SET [0:?] OF IfcStructuralAnalysisModel FOR LoadedBy;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadGroup : IfcGroup
	{
		public IfcLoadGroupTypeEnum PredefinedType { get; set; }
		public IfcActionTypeEnum ActionType { get; set; }
		public IfcActionSourceTypeEnum ActionSource { get; set; }
		public IfcRatioMeasure? Coefficient { get; set; }
		public IfcLabel? Purpose { get; set; }
		public IfcStructuralLoadGroup() : base()
		{
			PredefinedType = new IfcLoadGroupTypeEnum();
			ActionType = new IfcActionTypeEnum();
			ActionSource = new IfcActionSourceTypeEnum();
		}
		public IfcStructuralLoadGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcLoadGroupTypeEnum PredefinedType, IfcActionTypeEnum ActionType, IfcActionSourceTypeEnum ActionSource, IfcRatioMeasure Coefficient, IfcLabel Purpose) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.PredefinedType = PredefinedType;
			this.ActionType = ActionType;
			this.ActionSource = ActionSource;
			this.Coefficient = Coefficient;
			this.Purpose = Purpose;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadLinearForce
	/// <para>ENTITY IfcStructuralLoadLinearForce</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadStatic);</para>
	/// <para>	LinearForceX : OPTIONAL IfcLinearForceMeasure;</para>
	/// <para>	LinearForceY : OPTIONAL IfcLinearForceMeasure;</para>
	/// <para>	LinearForceZ : OPTIONAL IfcLinearForceMeasure;</para>
	/// <para>	LinearMomentX : OPTIONAL IfcLinearMomentMeasure;</para>
	/// <para>	LinearMomentY : OPTIONAL IfcLinearMomentMeasure;</para>
	/// <para>	LinearMomentZ : OPTIONAL IfcLinearMomentMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadLinearForce : IfcStructuralLoadStatic
	{
		public IfcLinearForceMeasure? LinearForceX { get; set; }
		public IfcLinearForceMeasure? LinearForceY { get; set; }
		public IfcLinearForceMeasure? LinearForceZ { get; set; }
		public IfcLinearMomentMeasure? LinearMomentX { get; set; }
		public IfcLinearMomentMeasure? LinearMomentY { get; set; }
		public IfcLinearMomentMeasure? LinearMomentZ { get; set; }
		public IfcStructuralLoadLinearForce() : base()
		{
		}
		public IfcStructuralLoadLinearForce(IfcLabel Name, IfcLinearForceMeasure LinearForceX, IfcLinearForceMeasure LinearForceY, IfcLinearForceMeasure LinearForceZ, IfcLinearMomentMeasure LinearMomentX, IfcLinearMomentMeasure LinearMomentY, IfcLinearMomentMeasure LinearMomentZ) : base (Name)
		{
			this.LinearForceX = LinearForceX;
			this.LinearForceY = LinearForceY;
			this.LinearForceZ = LinearForceZ;
			this.LinearMomentX = LinearMomentX;
			this.LinearMomentY = LinearMomentY;
			this.LinearMomentZ = LinearMomentZ;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadPlanarForce
	/// <para>ENTITY IfcStructuralLoadPlanarForce</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadStatic);</para>
	/// <para>	PlanarForceX : OPTIONAL IfcPlanarForceMeasure;</para>
	/// <para>	PlanarForceY : OPTIONAL IfcPlanarForceMeasure;</para>
	/// <para>	PlanarForceZ : OPTIONAL IfcPlanarForceMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadPlanarForce : IfcStructuralLoadStatic
	{
		public IfcPlanarForceMeasure? PlanarForceX { get; set; }
		public IfcPlanarForceMeasure? PlanarForceY { get; set; }
		public IfcPlanarForceMeasure? PlanarForceZ { get; set; }
		public IfcStructuralLoadPlanarForce() : base()
		{
		}
		public IfcStructuralLoadPlanarForce(IfcLabel Name, IfcPlanarForceMeasure PlanarForceX, IfcPlanarForceMeasure PlanarForceY, IfcPlanarForceMeasure PlanarForceZ) : base (Name)
		{
			this.PlanarForceX = PlanarForceX;
			this.PlanarForceY = PlanarForceY;
			this.PlanarForceZ = PlanarForceZ;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadSingleDisplacement
	/// <para>ENTITY IfcStructuralLoadSingleDisplacement</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLoadSingleDisplacementDistortion))</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadStatic);</para>
	/// <para>	DisplacementX : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	DisplacementY : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	DisplacementZ : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	RotationalDisplacementRX : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	RotationalDisplacementRY : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	RotationalDisplacementRZ : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic
	{
		public IfcLengthMeasure? DisplacementX { get; set; }
		public IfcLengthMeasure? DisplacementY { get; set; }
		public IfcLengthMeasure? DisplacementZ { get; set; }
		public IfcPlaneAngleMeasure? RotationalDisplacementRX { get; set; }
		public IfcPlaneAngleMeasure? RotationalDisplacementRY { get; set; }
		public IfcPlaneAngleMeasure? RotationalDisplacementRZ { get; set; }
		public IfcStructuralLoadSingleDisplacement() : base()
		{
		}
		public IfcStructuralLoadSingleDisplacement(IfcLabel Name, IfcLengthMeasure DisplacementX, IfcLengthMeasure DisplacementY, IfcLengthMeasure DisplacementZ, IfcPlaneAngleMeasure RotationalDisplacementRX, IfcPlaneAngleMeasure RotationalDisplacementRY, IfcPlaneAngleMeasure RotationalDisplacementRZ) : base (Name)
		{
			this.DisplacementX = DisplacementX;
			this.DisplacementY = DisplacementY;
			this.DisplacementZ = DisplacementZ;
			this.RotationalDisplacementRX = RotationalDisplacementRX;
			this.RotationalDisplacementRY = RotationalDisplacementRY;
			this.RotationalDisplacementRZ = RotationalDisplacementRZ;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadSingleDisplacementDistortion
	/// <para>ENTITY IfcStructuralLoadSingleDisplacementDistortion</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadSingleDisplacement);</para>
	/// <para>	Distortion : OPTIONAL IfcCurvatureMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadSingleDisplacementDistortion : IfcStructuralLoadSingleDisplacement
	{
		public IfcCurvatureMeasure? Distortion { get; set; }
		public IfcStructuralLoadSingleDisplacementDistortion() : base()
		{
		}
		public IfcStructuralLoadSingleDisplacementDistortion(IfcLabel Name, IfcLengthMeasure DisplacementX, IfcLengthMeasure DisplacementY, IfcLengthMeasure DisplacementZ, IfcPlaneAngleMeasure RotationalDisplacementRX, IfcPlaneAngleMeasure RotationalDisplacementRY, IfcPlaneAngleMeasure RotationalDisplacementRZ, IfcCurvatureMeasure Distortion) : base (Name, DisplacementX, DisplacementY, DisplacementZ, RotationalDisplacementRX, RotationalDisplacementRY, RotationalDisplacementRZ)
		{
			this.Distortion = Distortion;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadSingleForce
	/// <para>ENTITY IfcStructuralLoadSingleForce</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLoadSingleForceWarping))</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadStatic);</para>
	/// <para>	ForceX : OPTIONAL IfcForceMeasure;</para>
	/// <para>	ForceY : OPTIONAL IfcForceMeasure;</para>
	/// <para>	ForceZ : OPTIONAL IfcForceMeasure;</para>
	/// <para>	MomentX : OPTIONAL IfcTorqueMeasure;</para>
	/// <para>	MomentY : OPTIONAL IfcTorqueMeasure;</para>
	/// <para>	MomentZ : OPTIONAL IfcTorqueMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadSingleForce : IfcStructuralLoadStatic
	{
		public IfcForceMeasure? ForceX { get; set; }
		public IfcForceMeasure? ForceY { get; set; }
		public IfcForceMeasure? ForceZ { get; set; }
		public IfcTorqueMeasure? MomentX { get; set; }
		public IfcTorqueMeasure? MomentY { get; set; }
		public IfcTorqueMeasure? MomentZ { get; set; }
		public IfcStructuralLoadSingleForce() : base()
		{
		}
		public IfcStructuralLoadSingleForce(IfcLabel Name, IfcForceMeasure ForceX, IfcForceMeasure ForceY, IfcForceMeasure ForceZ, IfcTorqueMeasure MomentX, IfcTorqueMeasure MomentY, IfcTorqueMeasure MomentZ) : base (Name)
		{
			this.ForceX = ForceX;
			this.ForceY = ForceY;
			this.ForceZ = ForceZ;
			this.MomentX = MomentX;
			this.MomentY = MomentY;
			this.MomentZ = MomentZ;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadSingleForceWarping
	/// <para>ENTITY IfcStructuralLoadSingleForceWarping</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadSingleForce);</para>
	/// <para>	WarpingMoment : OPTIONAL IfcWarpingMomentMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadSingleForceWarping : IfcStructuralLoadSingleForce
	{
		public IfcWarpingMomentMeasure? WarpingMoment { get; set; }
		public IfcStructuralLoadSingleForceWarping() : base()
		{
		}
		public IfcStructuralLoadSingleForceWarping(IfcLabel Name, IfcForceMeasure ForceX, IfcForceMeasure ForceY, IfcForceMeasure ForceZ, IfcTorqueMeasure MomentX, IfcTorqueMeasure MomentY, IfcTorqueMeasure MomentZ, IfcWarpingMomentMeasure WarpingMoment) : base (Name, ForceX, ForceY, ForceZ, MomentX, MomentY, MomentZ)
		{
			this.WarpingMoment = WarpingMoment;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadStatic
	/// <para>ENTITY IfcStructuralLoadStatic</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralLoadLinearForce</para>
	/// <para>	,IfcStructuralLoadPlanarForce</para>
	/// <para>	,IfcStructuralLoadSingleDisplacement</para>
	/// <para>	,IfcStructuralLoadSingleForce</para>
	/// <para>	,IfcStructuralLoadTemperature))</para>
	/// <para> SUBTYPE OF (IfcStructuralLoad);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralLoadStatic : IfcStructuralLoad
	{
		public IfcStructuralLoadStatic() : base()
		{
		}
		public IfcStructuralLoadStatic(IfcLabel Name) : base (Name)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralLoadTemperature
	/// <para>ENTITY IfcStructuralLoadTemperature</para>
	/// <para> SUBTYPE OF (IfcStructuralLoadStatic);</para>
	/// <para>	DeltaT_Constant : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	DeltaT_Y : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	DeltaT_Z : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralLoadTemperature : IfcStructuralLoadStatic
	{
		public IfcThermodynamicTemperatureMeasure? DeltaT_Constant { get; set; }
		public IfcThermodynamicTemperatureMeasure? DeltaT_Y { get; set; }
		public IfcThermodynamicTemperatureMeasure? DeltaT_Z { get; set; }
		public IfcStructuralLoadTemperature() : base()
		{
		}
		public IfcStructuralLoadTemperature(IfcLabel Name, IfcThermodynamicTemperatureMeasure DeltaT_Constant, IfcThermodynamicTemperatureMeasure DeltaT_Y, IfcThermodynamicTemperatureMeasure DeltaT_Z) : base (Name)
		{
			this.DeltaT_Constant = DeltaT_Constant;
			this.DeltaT_Y = DeltaT_Y;
			this.DeltaT_Z = DeltaT_Z;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralMember
	/// <para>ENTITY IfcStructuralMember</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralCurveMember</para>
	/// <para>	,IfcStructuralSurfaceMember))</para>
	/// <para> SUBTYPE OF (IfcStructuralItem);</para>
	/// <para> INVERSE</para>
	/// <para>	ReferencesElement : SET [0:?] OF IfcRelConnectsStructuralElement FOR RelatedStructuralMember;</para>
	/// <para>	ConnectedBy : SET [0:?] OF IfcRelConnectsStructuralMember FOR RelatingStructuralMember;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralMember : IfcStructuralItem
	{
		public IfcStructuralMember() : base()
		{
		}
		public IfcStructuralMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralPlanarAction
	/// <para>ENTITY IfcStructuralPlanarAction</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralPlanarActionVarying))</para>
	/// <para> SUBTYPE OF (IfcStructuralAction);</para>
	/// <para>	ProjectedOrTrue : IfcProjectedOrTrueLengthEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : SIZEOF(['IFC2X3.IFCSTRUCTURALLOADPLANARFORCE',</para>
	/// <para>                     'IFC2X3.IFCSTRUCTURALLOADTEMPERATURE']</para>
	/// <para>             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralPlanarAction : IfcStructuralAction
	{
		public IfcProjectedOrTrueLengthEnum ProjectedOrTrue { get; set; }
		public IfcStructuralPlanarAction() : base()
		{
			ProjectedOrTrue = new IfcProjectedOrTrueLengthEnum();
		}
		public IfcStructuralPlanarAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy, IfcProjectedOrTrueLengthEnum ProjectedOrTrue) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal, DestabilizingLoad, CausedBy)
		{
			this.ProjectedOrTrue = ProjectedOrTrue;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralPlanarActionVarying
	/// <para>ENTITY IfcStructuralPlanarActionVarying</para>
	/// <para> SUBTYPE OF (IfcStructuralPlanarAction);</para>
	/// <para>	VaryingAppliedLoadLocation : IfcShapeAspect;</para>
	/// <para>	SubsequentAppliedLoads : LIST [2:?] OF IfcStructuralLoad;</para>
	/// <para> DERIVE</para>
	/// <para>	VaryingAppliedLoads : LIST [3:?] OF IfcStructuralLoad := IfcAddToBeginOfList(SELF\IfcStructuralActivity.AppliedLoad, SubsequentAppliedLoads);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralPlanarActionVarying : IfcStructuralPlanarAction
	{
		public IfcShapeAspect VaryingAppliedLoadLocation { get; set; }
		public List<IfcStructuralLoad> SubsequentAppliedLoads { get; set; }
		public IfcStructuralPlanarActionVarying() : base()
		{
			VaryingAppliedLoadLocation = new IfcShapeAspect();
			SubsequentAppliedLoads = new List<IfcStructuralLoad>();
		}
		public IfcStructuralPlanarActionVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy, IfcProjectedOrTrueLengthEnum ProjectedOrTrue, IfcShapeAspect VaryingAppliedLoadLocation, List<IfcStructuralLoad> SubsequentAppliedLoads) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal, DestabilizingLoad, CausedBy, ProjectedOrTrue)
		{
			this.VaryingAppliedLoadLocation = VaryingAppliedLoadLocation;
			this.SubsequentAppliedLoads = SubsequentAppliedLoads;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralPointAction
	/// <para>ENTITY IfcStructuralPointAction</para>
	/// <para> SUBTYPE OF (IfcStructuralAction);</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : SIZEOF(['IFC2X3.IFCSTRUCTURALLOADSINGLEFORCE',</para>
	/// <para>                     'IFC2X3.IFCSTRUCTURALLOADSINGLEDISPLACEMENT']</para>
	/// <para>             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralPointAction : IfcStructuralAction
	{
		public IfcStructuralPointAction() : base()
		{
		}
		public IfcStructuralPointAction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal, BOOLEAN DestabilizingLoad, IfcStructuralReaction CausedBy) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal, DestabilizingLoad, CausedBy)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralPointConnection
	/// <para>ENTITY IfcStructuralPointConnection</para>
	/// <para> SUBTYPE OF (IfcStructuralConnection);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralPointConnection : IfcStructuralConnection
	{
		public IfcStructuralPointConnection() : base()
		{
		}
		public IfcStructuralPointConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedCondition)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralPointReaction
	/// <para>ENTITY IfcStructuralPointReaction</para>
	/// <para> SUBTYPE OF (IfcStructuralReaction);</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : SIZEOF(['IFC2X3.IFCSTRUCTURALLOADSINGLEFORCE',</para>
	/// <para>                     'IFC2X3.IFCSTRUCTURALLOADSINGLEDISPLACEMENT']</para>
	/// <para>             * TYPEOF(SELF\IfcStructuralActivity.AppliedLoad)) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralPointReaction : IfcStructuralReaction
	{
		public IfcStructuralPointReaction() : base()
		{
		}
		public IfcStructuralPointReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralProfileProperties
	/// <para>ENTITY IfcStructuralProfileProperties</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralSteelProfileProperties))</para>
	/// <para> SUBTYPE OF (IfcGeneralProfileProperties);</para>
	/// <para>	TorsionalConstantX : OPTIONAL IfcMomentOfInertiaMeasure;</para>
	/// <para>	MomentOfInertiaYZ : OPTIONAL IfcMomentOfInertiaMeasure;</para>
	/// <para>	MomentOfInertiaY : OPTIONAL IfcMomentOfInertiaMeasure;</para>
	/// <para>	MomentOfInertiaZ : OPTIONAL IfcMomentOfInertiaMeasure;</para>
	/// <para>	WarpingConstant : OPTIONAL IfcWarpingConstantMeasure;</para>
	/// <para>	ShearCentreZ : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ShearCentreY : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	ShearDeformationAreaZ : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	ShearDeformationAreaY : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	MaximumSectionModulusY : OPTIONAL IfcSectionModulusMeasure;</para>
	/// <para>	MinimumSectionModulusY : OPTIONAL IfcSectionModulusMeasure;</para>
	/// <para>	MaximumSectionModulusZ : OPTIONAL IfcSectionModulusMeasure;</para>
	/// <para>	MinimumSectionModulusZ : OPTIONAL IfcSectionModulusMeasure;</para>
	/// <para>	TorsionalSectionModulus : OPTIONAL IfcSectionModulusMeasure;</para>
	/// <para>	CentreOfGravityInX : OPTIONAL IfcLengthMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : NOT(EXISTS(ShearDeformationAreaY)) OR (ShearDeformationAreaY >= 0.);</para>
	/// <para>	WR22 : NOT(EXISTS(ShearDeformationAreaZ)) OR (ShearDeformationAreaZ >= 0.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralProfileProperties : IfcGeneralProfileProperties
	{
		public IfcMomentOfInertiaMeasure? TorsionalConstantX { get; set; }
		public IfcMomentOfInertiaMeasure? MomentOfInertiaYZ { get; set; }
		public IfcMomentOfInertiaMeasure? MomentOfInertiaY { get; set; }
		public IfcMomentOfInertiaMeasure? MomentOfInertiaZ { get; set; }
		public IfcWarpingConstantMeasure? WarpingConstant { get; set; }
		public IfcLengthMeasure? ShearCentreZ { get; set; }
		public IfcLengthMeasure? ShearCentreY { get; set; }
		public IfcAreaMeasure? ShearDeformationAreaZ { get; set; }
		public IfcAreaMeasure? ShearDeformationAreaY { get; set; }
		public IfcSectionModulusMeasure? MaximumSectionModulusY { get; set; }
		public IfcSectionModulusMeasure? MinimumSectionModulusY { get; set; }
		public IfcSectionModulusMeasure? MaximumSectionModulusZ { get; set; }
		public IfcSectionModulusMeasure? MinimumSectionModulusZ { get; set; }
		public IfcSectionModulusMeasure? TorsionalSectionModulus { get; set; }
		public IfcLengthMeasure? CentreOfGravityInX { get; set; }
		public IfcLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcStructuralProfileProperties() : base()
		{
		}
		public IfcStructuralProfileProperties(IfcLabel ProfileName, IfcProfileDef ProfileDefinition, IfcMassPerLengthMeasure PhysicalWeight, IfcPositiveLengthMeasure Perimeter, IfcPositiveLengthMeasure MinimumPlateThickness, IfcPositiveLengthMeasure MaximumPlateThickness, IfcAreaMeasure CrossSectionArea, IfcMomentOfInertiaMeasure TorsionalConstantX, IfcMomentOfInertiaMeasure MomentOfInertiaYZ, IfcMomentOfInertiaMeasure MomentOfInertiaY, IfcMomentOfInertiaMeasure MomentOfInertiaZ, IfcWarpingConstantMeasure WarpingConstant, IfcLengthMeasure ShearCentreZ, IfcLengthMeasure ShearCentreY, IfcAreaMeasure ShearDeformationAreaZ, IfcAreaMeasure ShearDeformationAreaY, IfcSectionModulusMeasure MaximumSectionModulusY, IfcSectionModulusMeasure MinimumSectionModulusY, IfcSectionModulusMeasure MaximumSectionModulusZ, IfcSectionModulusMeasure MinimumSectionModulusZ, IfcSectionModulusMeasure TorsionalSectionModulus, IfcLengthMeasure CentreOfGravityInX, IfcLengthMeasure CentreOfGravityInY) : base (ProfileName, ProfileDefinition, PhysicalWeight, Perimeter, MinimumPlateThickness, MaximumPlateThickness, CrossSectionArea)
		{
			this.TorsionalConstantX = TorsionalConstantX;
			this.MomentOfInertiaYZ = MomentOfInertiaYZ;
			this.MomentOfInertiaY = MomentOfInertiaY;
			this.MomentOfInertiaZ = MomentOfInertiaZ;
			this.WarpingConstant = WarpingConstant;
			this.ShearCentreZ = ShearCentreZ;
			this.ShearCentreY = ShearCentreY;
			this.ShearDeformationAreaZ = ShearDeformationAreaZ;
			this.ShearDeformationAreaY = ShearDeformationAreaY;
			this.MaximumSectionModulusY = MaximumSectionModulusY;
			this.MinimumSectionModulusY = MinimumSectionModulusY;
			this.MaximumSectionModulusZ = MaximumSectionModulusZ;
			this.MinimumSectionModulusZ = MinimumSectionModulusZ;
			this.TorsionalSectionModulus = TorsionalSectionModulus;
			this.CentreOfGravityInX = CentreOfGravityInX;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralReaction
	/// <para>ENTITY IfcStructuralReaction</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralPointReaction))</para>
	/// <para> SUBTYPE OF (IfcStructuralActivity);</para>
	/// <para> INVERSE</para>
	/// <para>	Causes : SET [0:?] OF IfcStructuralAction FOR CausedBy;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStructuralReaction : IfcStructuralActivity
	{
		public IfcStructuralReaction() : base()
		{
		}
		public IfcStructuralReaction(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralLoad AppliedLoad, IfcGlobalOrLocalEnum GlobalOrLocal) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedLoad, GlobalOrLocal)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralResultGroup
	/// <para>ENTITY IfcStructuralResultGroup</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para>	TheoryType : IfcAnalysisTheoryTypeEnum;</para>
	/// <para>	ResultForLoadGroup : OPTIONAL IfcStructuralLoadGroup;</para>
	/// <para>	IsLinear : BOOLEAN;</para>
	/// <para> INVERSE</para>
	/// <para>	ResultGroupFor : SET [0:1] OF IfcStructuralAnalysisModel FOR HasResults;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralResultGroup : IfcGroup
	{
		public IfcAnalysisTheoryTypeEnum TheoryType { get; set; }
		public IfcStructuralLoadGroup? ResultForLoadGroup { get; set; }
		public BOOLEAN IsLinear { get; set; }
		public IfcStructuralResultGroup() : base()
		{
			TheoryType = new IfcAnalysisTheoryTypeEnum();
			IsLinear = new BOOLEAN();
		}
		public IfcStructuralResultGroup(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcAnalysisTheoryTypeEnum TheoryType, IfcStructuralLoadGroup ResultForLoadGroup, BOOLEAN IsLinear) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.TheoryType = TheoryType;
			this.ResultForLoadGroup = ResultForLoadGroup;
			this.IsLinear = IsLinear;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralSteelProfileProperties
	/// <para>ENTITY IfcStructuralSteelProfileProperties</para>
	/// <para> SUBTYPE OF (IfcStructuralProfileProperties);</para>
	/// <para>	ShearAreaZ : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	ShearAreaY : OPTIONAL IfcAreaMeasure;</para>
	/// <para>	PlasticShapeFactorY : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para>	PlasticShapeFactorZ : OPTIONAL IfcPositiveRatioMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(EXISTS(ShearAreaY)) OR (ShearAreaY >= 0.);</para>
	/// <para>	WR32 : NOT(EXISTS(ShearAreaZ)) OR (ShearAreaZ >= 0.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralSteelProfileProperties : IfcStructuralProfileProperties
	{
		public IfcAreaMeasure? ShearAreaZ { get; set; }
		public IfcAreaMeasure? ShearAreaY { get; set; }
		public IfcPositiveRatioMeasure? PlasticShapeFactorY { get; set; }
		public IfcPositiveRatioMeasure? PlasticShapeFactorZ { get; set; }
		public IfcStructuralSteelProfileProperties() : base()
		{
		}
		public IfcStructuralSteelProfileProperties(IfcLabel ProfileName, IfcProfileDef ProfileDefinition, IfcMassPerLengthMeasure PhysicalWeight, IfcPositiveLengthMeasure Perimeter, IfcPositiveLengthMeasure MinimumPlateThickness, IfcPositiveLengthMeasure MaximumPlateThickness, IfcAreaMeasure CrossSectionArea, IfcMomentOfInertiaMeasure TorsionalConstantX, IfcMomentOfInertiaMeasure MomentOfInertiaYZ, IfcMomentOfInertiaMeasure MomentOfInertiaY, IfcMomentOfInertiaMeasure MomentOfInertiaZ, IfcWarpingConstantMeasure WarpingConstant, IfcLengthMeasure ShearCentreZ, IfcLengthMeasure ShearCentreY, IfcAreaMeasure ShearDeformationAreaZ, IfcAreaMeasure ShearDeformationAreaY, IfcSectionModulusMeasure MaximumSectionModulusY, IfcSectionModulusMeasure MinimumSectionModulusY, IfcSectionModulusMeasure MaximumSectionModulusZ, IfcSectionModulusMeasure MinimumSectionModulusZ, IfcSectionModulusMeasure TorsionalSectionModulus, IfcLengthMeasure CentreOfGravityInX, IfcLengthMeasure CentreOfGravityInY, IfcAreaMeasure ShearAreaZ, IfcAreaMeasure ShearAreaY, IfcPositiveRatioMeasure PlasticShapeFactorY, IfcPositiveRatioMeasure PlasticShapeFactorZ) : base (ProfileName, ProfileDefinition, PhysicalWeight, Perimeter, MinimumPlateThickness, MaximumPlateThickness, CrossSectionArea, TorsionalConstantX, MomentOfInertiaYZ, MomentOfInertiaY, MomentOfInertiaZ, WarpingConstant, ShearCentreZ, ShearCentreY, ShearDeformationAreaZ, ShearDeformationAreaY, MaximumSectionModulusY, MinimumSectionModulusY, MaximumSectionModulusZ, MinimumSectionModulusZ, TorsionalSectionModulus, CentreOfGravityInX, CentreOfGravityInY)
		{
			this.ShearAreaZ = ShearAreaZ;
			this.ShearAreaY = ShearAreaY;
			this.PlasticShapeFactorY = PlasticShapeFactorY;
			this.PlasticShapeFactorZ = PlasticShapeFactorZ;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralSurfaceConnection
	/// <para>ENTITY IfcStructuralSurfaceConnection</para>
	/// <para> SUBTYPE OF (IfcStructuralConnection);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralSurfaceConnection : IfcStructuralConnection
	{
		public IfcStructuralSurfaceConnection() : base()
		{
		}
		public IfcStructuralSurfaceConnection(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcBoundaryCondition AppliedCondition) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, AppliedCondition)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralSurfaceMember
	/// <para>ENTITY IfcStructuralSurfaceMember</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStructuralSurfaceMemberVarying))</para>
	/// <para> SUBTYPE OF (IfcStructuralMember);</para>
	/// <para>	PredefinedType : IfcStructuralSurfaceTypeEnum;</para>
	/// <para>	Thickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralSurfaceMember : IfcStructuralMember
	{
		public IfcStructuralSurfaceTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure? Thickness { get; set; }
		public IfcStructuralSurfaceMember() : base()
		{
			PredefinedType = new IfcStructuralSurfaceTypeEnum();
		}
		public IfcStructuralSurfaceMember(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralSurfaceTypeEnum PredefinedType, IfcPositiveLengthMeasure Thickness) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation)
		{
			this.PredefinedType = PredefinedType;
			this.Thickness = Thickness;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuralSurfaceMemberVarying
	/// <para>ENTITY IfcStructuralSurfaceMemberVarying</para>
	/// <para> SUBTYPE OF (IfcStructuralSurfaceMember);</para>
	/// <para>	SubsequentThickness : LIST [2:?] OF IfcPositiveLengthMeasure;</para>
	/// <para>	VaryingThicknessLocation : IfcShapeAspect;</para>
	/// <para> DERIVE</para>
	/// <para>	VaryingThickness : LIST [3:?] OF IfcPositiveLengthMeasure := IfcAddToBeginOfList(SELF\IfcStructuralSurfaceMember.Thickness, SubsequentThickness);</para>
	/// <para> WHERE</para>
	/// <para>	WR61 : EXISTS(SELF\IfcStructuralSurfaceMember.Thickness);</para>
	/// <para>	WR62 : SIZEOF(QUERY(temp <* SELF.VaryingThicknessLocation.ShapeRepresentations |</para>
	/// <para>               NOT(SIZEOF(temp\IfcRepresentation.Items) = 1)</para>
	/// <para>               )) = 0;</para>
	/// <para>	WR63 : SIZEOF(QUERY(temp <* SELF.VaryingThicknessLocation.ShapeRepresentations |</para>
	/// <para>               NOT(('IFC2X3.IFCCARTESIANPOINT' IN TYPEOF(temp\IfcRepresentation.Items[1]))</para>
	/// <para>                     OR</para>
	/// <para>                   ('IFC2X3.IFCPOINTONSURFACE' IN TYPEOF(temp\IfcRepresentation.Items[1])))</para>
	/// <para>               )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember
	{
		public List<IfcPositiveLengthMeasure> SubsequentThickness { get; set; }
		public IfcShapeAspect VaryingThicknessLocation { get; set; }
		public IfcStructuralSurfaceMemberVarying() : base()
		{
			SubsequentThickness = new List<IfcPositiveLengthMeasure>();
			VaryingThicknessLocation = new IfcShapeAspect();
		}
		public IfcStructuralSurfaceMemberVarying(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcStructuralSurfaceTypeEnum PredefinedType, IfcPositiveLengthMeasure Thickness, List<IfcPositiveLengthMeasure> SubsequentThickness, IfcShapeAspect VaryingThicknessLocation) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, PredefinedType, Thickness)
		{
			this.SubsequentThickness = SubsequentThickness;
			this.VaryingThicknessLocation = VaryingThicknessLocation;
		}
	}
	/// <summary>
	/// ENTITY IfcStructuredDimensionCallout
	/// <para>ENTITY IfcStructuredDimensionCallout</para>
	/// <para> SUBTYPE OF (IfcDraughtingCallout);</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : SIZEOF(QUERY ( Ato <* QUERY ( Con <* SELF.contents | (</para>
	/// <para>                   'IFC2X3.IFCANNOTATIONTEXTOCCURRENCE' IN </para>
	/// <para>                    TYPEOF(Con)) ) | (NOT (Ato.Name IN ['dimension value',</para>
	/// <para>                   'tolerance value','unit text','prefix text','suffix text']))))</para>
	/// <para>                  = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStructuredDimensionCallout : IfcDraughtingCallout
	{
		public IfcStructuredDimensionCallout() : base()
		{
		}
		public IfcStructuredDimensionCallout(List<IfcDraughtingCalloutElement> Contents) : base (Contents)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStyleModel
	/// <para>ENTITY IfcStyleModel</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcStyledRepresentation))</para>
	/// <para> SUBTYPE OF (IfcRepresentation);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcStyleModel : IfcRepresentation
	{
		public IfcStyleModel() : base()
		{
		}
		public IfcStyleModel(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base (ContextOfItems, RepresentationIdentifier, RepresentationType, Items)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcStyledItem
	/// <para>ENTITY IfcStyledItem</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcAnnotationOccurrence))</para>
	/// <para> SUBTYPE OF (IfcRepresentationItem);</para>
	/// <para>	Item : OPTIONAL IfcRepresentationItem;</para>
	/// <para>	Styles : SET [1:?] OF IfcPresentationStyleAssignment;</para>
	/// <para>	Name : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(Styles) = 1;</para>
	/// <para>	WR12 : NOT('IFC2X3.IFCSTYLEDITEM' IN TYPEOF(Item));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStyledItem : IfcRepresentationItem
	{
		public IfcRepresentationItem? Item { get; set; }
		public List<IfcPresentationStyleAssignment> Styles { get; set; }
		public IfcLabel? Name { get; set; }
		public IfcStyledItem() : base()
		{
			Styles = new List<IfcPresentationStyleAssignment>();
		}
		public IfcStyledItem(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name) : base ()
		{
			this.Item = Item;
			this.Styles = Styles;
			this.Name = Name;
		}
	}
	/// <summary>
	/// ENTITY IfcStyledRepresentation
	/// <para>ENTITY IfcStyledRepresentation</para>
	/// <para> SUBTYPE OF (IfcStyleModel);</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* SELF\IfcRepresentation.Items | </para>
	/// <para>               (NOT('IFC2X3.IFCSTYLEDITEM' IN TYPEOF(temp)))</para>
	/// <para>             )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcStyledRepresentation : IfcStyleModel
	{
		public IfcStyledRepresentation() : base()
		{
		}
		public IfcStyledRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base (ContextOfItems, RepresentationIdentifier, RepresentationType, Items)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSubContractResource
	/// <para>ENTITY IfcSubContractResource</para>
	/// <para> SUBTYPE OF (IfcConstructionResource);</para>
	/// <para>	SubContractor : OPTIONAL IfcActorSelect;</para>
	/// <para>	JobDescription : OPTIONAL IfcText;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSubContractResource : IfcConstructionResource
	{
		public IfcActorSelect? SubContractor { get; set; }
		public IfcText? JobDescription { get; set; }
		public IfcSubContractResource() : base()
		{
		}
		public IfcSubContractResource(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier ResourceIdentifier, IfcLabel ResourceGroup, IfcResourceConsumptionEnum ResourceConsumption, IfcMeasureWithUnit BaseQuantity, IfcActorSelect SubContractor, IfcText JobDescription) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ResourceIdentifier, ResourceGroup, ResourceConsumption, BaseQuantity)
		{
			this.SubContractor = SubContractor;
			this.JobDescription = JobDescription;
		}
	}
	/// <summary>
	/// ENTITY IfcSubedge
	/// <para>ENTITY IfcSubedge</para>
	/// <para> SUBTYPE OF (IfcEdge);</para>
	/// <para>	ParentEdge : IfcEdge;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSubedge : IfcEdge
	{
		public IfcEdge ParentEdge { get; set; }
		public IfcSubedge() : base()
		{
			ParentEdge = new IfcEdge();
		}
		public IfcSubedge(IfcVertex EdgeStart, IfcVertex EdgeEnd, IfcEdge ParentEdge) : base (EdgeStart, EdgeEnd)
		{
			this.ParentEdge = ParentEdge;
		}
	}
	/// <summary>
	/// ENTITY IfcSurface
	/// <para>ENTITY IfcSurface</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBoundedSurface</para>
	/// <para>	,IfcElementarySurface</para>
	/// <para>	,IfcSweptSurface))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSurface : IfcGeometricRepresentationItem, IfcGeometricSetSelect, IfcSurfaceOrFaceSurface
	{
		public IfcSurface() : base()
		{
		}
		public IfcSurface() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceCurveSweptAreaSolid
	/// <para>ENTITY IfcSurfaceCurveSweptAreaSolid</para>
	/// <para> SUBTYPE OF (IfcSweptAreaSolid);</para>
	/// <para>	Directrix : IfcCurve;</para>
	/// <para>	StartParam : IfcParameterValue;</para>
	/// <para>	EndParam : IfcParameterValue;</para>
	/// <para>	ReferenceSurface : IfcSurface;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceCurveSweptAreaSolid : IfcSweptAreaSolid
	{
		public IfcCurve Directrix { get; set; }
		public IfcParameterValue StartParam { get; set; }
		public IfcParameterValue EndParam { get; set; }
		public IfcSurface ReferenceSurface { get; set; }
		public IfcSurfaceCurveSweptAreaSolid() : base()
		{
			Directrix = new IfcCurve();
			StartParam = new IfcParameterValue();
			EndParam = new IfcParameterValue();
			ReferenceSurface = new IfcSurface();
		}
		public IfcSurfaceCurveSweptAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position, IfcCurve Directrix, IfcParameterValue StartParam, IfcParameterValue EndParam, IfcSurface ReferenceSurface) : base (SweptArea, Position)
		{
			this.Directrix = Directrix;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
			this.ReferenceSurface = ReferenceSurface;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceOfLinearExtrusion
	/// <para>ENTITY IfcSurfaceOfLinearExtrusion</para>
	/// <para> SUBTYPE OF (IfcSweptSurface);</para>
	/// <para>	ExtrudedDirection : IfcDirection;</para>
	/// <para>	Depth : IfcLengthMeasure;</para>
	/// <para> DERIVE</para>
	/// <para>	ExtrusionAxis : IfcVector := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector (ExtrudedDirection, Depth);</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : Depth > 0.;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceOfLinearExtrusion : IfcSweptSurface
	{
		public IfcDirection ExtrudedDirection { get; set; }
		public IfcLengthMeasure Depth { get; set; }
		public IfcSurfaceOfLinearExtrusion() : base()
		{
			ExtrudedDirection = new IfcDirection();
			Depth = new IfcLengthMeasure();
		}
		public IfcSurfaceOfLinearExtrusion(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position, IfcDirection ExtrudedDirection, IfcLengthMeasure Depth) : base (SweptCurve, Position)
		{
			this.ExtrudedDirection = ExtrudedDirection;
			this.Depth = Depth;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceOfRevolution
	/// <para>ENTITY IfcSurfaceOfRevolution</para>
	/// <para> SUBTYPE OF (IfcSweptSurface);</para>
	/// <para>	AxisPosition : IfcAxis1Placement;</para>
	/// <para> DERIVE</para>
	/// <para>	AxisLine : IfcLine := IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcCurve() || IfcLine(AxisPosition.Location, </para>
	/// <para>                       IfcRepresentationItem() || IfcGeometricRepresentationItem () || IfcVector(AxisPosition.Z,1.0));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceOfRevolution : IfcSweptSurface
	{
		public IfcAxis1Placement AxisPosition { get; set; }
		public IfcSurfaceOfRevolution() : base()
		{
			AxisPosition = new IfcAxis1Placement();
		}
		public IfcSurfaceOfRevolution(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position, IfcAxis1Placement AxisPosition) : base (SweptCurve, Position)
		{
			this.AxisPosition = AxisPosition;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyle
	/// <para>ENTITY IfcSurfaceStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationStyle);</para>
	/// <para>	Side : IfcSurfaceSide;</para>
	/// <para>	Styles : SET [1:5] OF IfcSurfaceStyleElementSelect;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF(QUERY(Style <* SELF.Styles |</para>
	/// <para>               'IFC2X3.IFCSURFACESTYLESHADING' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR12 : SIZEOF(QUERY(Style <* SELF.Styles |</para>
	/// <para>               'IFC2X3.IFCSURFACESTYLELIGHTING' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR13 : SIZEOF(QUERY(Style <* SELF.Styles |</para>
	/// <para>               'IFC2X3.IFCSURFACESTYLEREFRACTION' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR14 : SIZEOF(QUERY(Style <* SELF.Styles |</para>
	/// <para>               'IFC2X3.IFCSURFACESTYLEWITHTEXTURES' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>	WR15 : SIZEOF(QUERY(Style <* SELF.Styles |</para>
	/// <para>               'IFC2X3.IFCEXTERNALLYDEFINEDSURFACESTYLE' IN</para>
	/// <para>                TYPEOF(Style)</para>
	/// <para>               )) <= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		public IfcSurfaceSide Side { get; set; }
		public List<IfcSurfaceStyleElementSelect> Styles { get; set; }
		public IfcSurfaceStyle() : base()
		{
			Side = new IfcSurfaceSide();
			Styles = new List<IfcSurfaceStyleElementSelect>();
		}
		public IfcSurfaceStyle(IfcLabel Name, IfcSurfaceSide Side, List<IfcSurfaceStyleElementSelect> Styles) : base (Name)
		{
			this.Side = Side;
			this.Styles = Styles;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyleLighting;
	/// <para>ENTITY IfcSurfaceStyleLighting;</para>
	/// <para>	DiffuseTransmissionColour : IfcColourRgb;</para>
	/// <para>	DiffuseReflectionColour : IfcColourRgb;</para>
	/// <para>	TransmissionColour : IfcColourRgb;</para>
	/// <para>	ReflectanceColour : IfcColourRgb;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyleLightingENTITY, IfcSurfaceStyleElementSelect
	{
		public IfcColourRgb DiffuseTransmissionColour { get; set; }
		public IfcColourRgb DiffuseReflectionColour { get; set; }
		public IfcColourRgb TransmissionColour { get; set; }
		public IfcColourRgb ReflectanceColour { get; set; }
		public IfcSurfaceStyleLighting() : base()
		{
			DiffuseTransmissionColour = new IfcColourRgb();
			DiffuseReflectionColour = new IfcColourRgb();
			TransmissionColour = new IfcColourRgb();
			ReflectanceColour = new IfcColourRgb();
		}
		public IfcSurfaceStyleLighting(IfcColourRgb DiffuseTransmissionColour, IfcColourRgb DiffuseReflectionColour, IfcColourRgb TransmissionColour, IfcColourRgb ReflectanceColour) : base ()
		{
			this.DiffuseTransmissionColour = DiffuseTransmissionColour;
			this.DiffuseReflectionColour = DiffuseReflectionColour;
			this.TransmissionColour = TransmissionColour;
			this.ReflectanceColour = ReflectanceColour;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyleRefraction;
	/// <para>ENTITY IfcSurfaceStyleRefraction;</para>
	/// <para>	RefractionIndex : OPTIONAL IfcReal;</para>
	/// <para>	DispersionFactor : OPTIONAL IfcReal;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyleRefractionENTITY, IfcSurfaceStyleElementSelect
	{
		public IfcReal? RefractionIndex { get; set; }
		public IfcReal? DispersionFactor { get; set; }
		public IfcSurfaceStyleRefraction() : base()
		{
		}
		public IfcSurfaceStyleRefraction(IfcReal RefractionIndex, IfcReal DispersionFactor) : base ()
		{
			this.RefractionIndex = RefractionIndex;
			this.DispersionFactor = DispersionFactor;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyleRendering
	/// <para>ENTITY IfcSurfaceStyleRendering</para>
	/// <para> SUBTYPE OF (IfcSurfaceStyleShading);</para>
	/// <para>	Transparency : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	DiffuseColour : OPTIONAL IfcColourOrFactor;</para>
	/// <para>	TransmissionColour : OPTIONAL IfcColourOrFactor;</para>
	/// <para>	DiffuseTransmissionColour : OPTIONAL IfcColourOrFactor;</para>
	/// <para>	ReflectionColour : OPTIONAL IfcColourOrFactor;</para>
	/// <para>	SpecularColour : OPTIONAL IfcColourOrFactor;</para>
	/// <para>	SpecularHighlight : OPTIONAL IfcSpecularHighlightSelect;</para>
	/// <para>	ReflectanceMethod : IfcReflectanceMethodEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyleRendering : IfcSurfaceStyleShading
	{
		public IfcNormalisedRatioMeasure? Transparency { get; set; }
		public IfcColourOrFactor? DiffuseColour { get; set; }
		public IfcColourOrFactor? TransmissionColour { get; set; }
		public IfcColourOrFactor? DiffuseTransmissionColour { get; set; }
		public IfcColourOrFactor? ReflectionColour { get; set; }
		public IfcColourOrFactor? SpecularColour { get; set; }
		public IfcSpecularHighlightSelect? SpecularHighlight { get; set; }
		public IfcReflectanceMethodEnum ReflectanceMethod { get; set; }
		public IfcSurfaceStyleRendering() : base()
		{
			ReflectanceMethod = new IfcReflectanceMethodEnum();
		}
		public IfcSurfaceStyleRendering(IfcColourRgb SurfaceColour, IfcNormalisedRatioMeasure Transparency, IfcColourOrFactor DiffuseColour, IfcColourOrFactor TransmissionColour, IfcColourOrFactor DiffuseTransmissionColour, IfcColourOrFactor ReflectionColour, IfcColourOrFactor SpecularColour, IfcSpecularHighlightSelect SpecularHighlight, IfcReflectanceMethodEnum ReflectanceMethod) : base (SurfaceColour)
		{
			this.Transparency = Transparency;
			this.DiffuseColour = DiffuseColour;
			this.TransmissionColour = TransmissionColour;
			this.DiffuseTransmissionColour = DiffuseTransmissionColour;
			this.ReflectionColour = ReflectionColour;
			this.SpecularColour = SpecularColour;
			this.SpecularHighlight = SpecularHighlight;
			this.ReflectanceMethod = ReflectanceMethod;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyleShading
	/// <para>ENTITY IfcSurfaceStyleShading</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcSurfaceStyleRendering));</para>
	/// <para>	SurfaceColour : IfcColourRgb;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyleShadingENTITY, IfcSurfaceStyleElementSelect
	{
		public IfcColourRgb SurfaceColour { get; set; }
		public IfcSurfaceStyleShading() : base()
		{
			SurfaceColour = new IfcColourRgb();
		}
		public IfcSurfaceStyleShading(IfcColourRgb SurfaceColour) : base ()
		{
			this.SurfaceColour = SurfaceColour;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceStyleWithTextures;
	/// <para>ENTITY IfcSurfaceStyleWithTextures;</para>
	/// <para>	Textures : LIST [1:?] OF IfcSurfaceTexture;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSurfaceStyleWithTexturesENTITY, IfcSurfaceStyleElementSelect
	{
		public List<IfcSurfaceTexture> Textures { get; set; }
		public IfcSurfaceStyleWithTextures() : base()
		{
			Textures = new List<IfcSurfaceTexture>();
		}
		public IfcSurfaceStyleWithTextures(List<IfcSurfaceTexture> Textures) : base ()
		{
			this.Textures = Textures;
		}
	}
	/// <summary>
	/// ENTITY IfcSurfaceTexture
	/// <para>ENTITY IfcSurfaceTexture</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcBlobTexture</para>
	/// <para>	,IfcImageTexture</para>
	/// <para>	,IfcPixelTexture));</para>
	/// <para>	RepeatS : BOOLEAN;</para>
	/// <para>	RepeatT : BOOLEAN;</para>
	/// <para>	TextureType : IfcSurfaceTextureEnum;</para>
	/// <para>	TextureTransform : OPTIONAL IfcCartesianTransformationOperator2D;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSurfaceTextureENTITY
	{
		public BOOLEAN RepeatS { get; set; }
		public BOOLEAN RepeatT { get; set; }
		public IfcSurfaceTextureEnum TextureType { get; set; }
		public IfcCartesianTransformationOperator2D? TextureTransform { get; set; }
		public IfcSurfaceTexture() : base()
		{
			RepeatS = new BOOLEAN();
			RepeatT = new BOOLEAN();
			TextureType = new IfcSurfaceTextureEnum();
		}
		public IfcSurfaceTexture(BOOLEAN RepeatS, BOOLEAN RepeatT, IfcSurfaceTextureEnum TextureType, IfcCartesianTransformationOperator2D TextureTransform) : base ()
		{
			this.RepeatS = RepeatS;
			this.RepeatT = RepeatT;
			this.TextureType = TextureType;
			this.TextureTransform = TextureTransform;
		}
	}
	/// <summary>
	/// ENTITY IfcSweptAreaSolid
	/// <para>ENTITY IfcSweptAreaSolid</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcExtrudedAreaSolid</para>
	/// <para>	,IfcRevolvedAreaSolid</para>
	/// <para>	,IfcSurfaceCurveSweptAreaSolid))</para>
	/// <para> SUBTYPE OF (IfcSolidModel);</para>
	/// <para>	SweptArea : IfcProfileDef;</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para> WHERE</para>
	/// <para>	WR22 : SweptArea.ProfileType = IfcProfileTypeEnum.Area;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSweptAreaSolid : IfcSolidModel
	{
		public IfcProfileDef SweptArea { get; set; }
		public IfcAxis2Placement3D Position { get; set; }
		public IfcSweptAreaSolid() : base()
		{
			SweptArea = new IfcProfileDef();
			Position = new IfcAxis2Placement3D();
		}
		public IfcSweptAreaSolid(IfcProfileDef SweptArea, IfcAxis2Placement3D Position) : base ()
		{
			this.SweptArea = SweptArea;
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcSweptDiskSolid
	/// <para>ENTITY IfcSweptDiskSolid</para>
	/// <para> SUBTYPE OF (IfcSolidModel);</para>
	/// <para>	Directrix : IfcCurve;</para>
	/// <para>	Radius : IfcPositiveLengthMeasure;</para>
	/// <para>	InnerRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	StartParam : IfcParameterValue;</para>
	/// <para>	EndParam : IfcParameterValue;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Directrix.Dim = 3;</para>
	/// <para>	WR2 : (NOT EXISTS(InnerRadius)) OR (Radius > InnerRadius);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSweptDiskSolid : IfcSolidModel
	{
		public IfcCurve Directrix { get; set; }
		public IfcPositiveLengthMeasure Radius { get; set; }
		public IfcPositiveLengthMeasure? InnerRadius { get; set; }
		public IfcParameterValue StartParam { get; set; }
		public IfcParameterValue EndParam { get; set; }
		public IfcSweptDiskSolid() : base()
		{
			Directrix = new IfcCurve();
			Radius = new IfcPositiveLengthMeasure();
			StartParam = new IfcParameterValue();
			EndParam = new IfcParameterValue();
		}
		public IfcSweptDiskSolid(IfcCurve Directrix, IfcPositiveLengthMeasure Radius, IfcPositiveLengthMeasure InnerRadius, IfcParameterValue StartParam, IfcParameterValue EndParam) : base ()
		{
			this.Directrix = Directrix;
			this.Radius = Radius;
			this.InnerRadius = InnerRadius;
			this.StartParam = StartParam;
			this.EndParam = EndParam;
		}
	}
	/// <summary>
	/// ENTITY IfcSweptSurface
	/// <para>ENTITY IfcSweptSurface</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcSurfaceOfLinearExtrusion</para>
	/// <para>	,IfcSurfaceOfRevolution))</para>
	/// <para> SUBTYPE OF (IfcSurface);</para>
	/// <para>	SweptCurve : IfcProfileDef;</para>
	/// <para>	Position : IfcAxis2Placement3D;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := Position.Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : NOT('IFC2X3.IFCDERIVEDPROFILEDEF' IN TYPEOF(SweptCurve));</para>
	/// <para>	WR2 : SweptCurve.ProfileType = IfcProfileTypeEnum.Curve;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcSweptSurface : IfcSurface
	{
		public IfcProfileDef SweptCurve { get; set; }
		public IfcAxis2Placement3D Position { get; set; }
		public IfcSweptSurface() : base()
		{
			SweptCurve = new IfcProfileDef();
			Position = new IfcAxis2Placement3D();
		}
		public IfcSweptSurface(IfcProfileDef SweptCurve, IfcAxis2Placement3D Position) : base ()
		{
			this.SweptCurve = SweptCurve;
			this.Position = Position;
		}
	}
	/// <summary>
	/// ENTITY IfcSwitchingDeviceType
	/// <para>ENTITY IfcSwitchingDeviceType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcSwitchingDeviceTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSwitchingDeviceType : IfcFlowControllerType
	{
		public IfcSwitchingDeviceTypeEnum PredefinedType { get; set; }
		public IfcSwitchingDeviceType() : base()
		{
			PredefinedType = new IfcSwitchingDeviceTypeEnum();
		}
		public IfcSwitchingDeviceType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcSwitchingDeviceTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcSymbolStyle
	/// <para>ENTITY IfcSymbolStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationStyle);</para>
	/// <para>	StyleOfSymbol : IfcSymbolStyleSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSymbolStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		public IfcSymbolStyleSelect StyleOfSymbol { get; set; }
		public IfcSymbolStyle() : base()
		{
			StyleOfSymbol = new IfcSymbolStyleSelect();
		}
		public IfcSymbolStyle(IfcLabel Name, IfcSymbolStyleSelect StyleOfSymbol) : base (Name)
		{
			this.StyleOfSymbol = StyleOfSymbol;
		}
	}
	/// <summary>
	/// ENTITY IfcSystem
	/// <para>ENTITY IfcSystem</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcElectricalCircuit</para>
	/// <para>	,IfcStructuralAnalysisModel))</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para> INVERSE</para>
	/// <para>	ServicesBuildings : SET [0:1] OF IfcRelServicesBuildings FOR RelatingSystem;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSystem : IfcGroup
	{
		public IfcSystem() : base()
		{
		}
		public IfcSystem(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcSystemFurnitureElementType
	/// <para>ENTITY IfcSystemFurnitureElementType</para>
	/// <para> SUBTYPE OF (IfcFurnishingElementType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcSystemFurnitureElementType : IfcFurnishingElementType
	{
		public IfcSystemFurnitureElementType() : base()
		{
		}
		public IfcSystemFurnitureElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcTShapeProfileDef
	/// <para>ENTITY IfcTShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeEdgeRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	WebEdgeRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	WebSlope : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	FlangeSlope : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	CentreOfGravityInY : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : FlangeThickness < Depth;</para>
	/// <para>	WR2 : WebThickness < FlangeWidth;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcPositiveLengthMeasure? FilletRadius { get; set; }
		public IfcPositiveLengthMeasure? FlangeEdgeRadius { get; set; }
		public IfcPositiveLengthMeasure? WebEdgeRadius { get; set; }
		public IfcPlaneAngleMeasure? WebSlope { get; set; }
		public IfcPlaneAngleMeasure? FlangeSlope { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
		public IfcTShapeProfileDef() : base()
		{
			Depth = new IfcPositiveLengthMeasure();
			FlangeWidth = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			FlangeThickness = new IfcPositiveLengthMeasure();
		}
		public IfcTShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcPositiveLengthMeasure FilletRadius, IfcPositiveLengthMeasure FlangeEdgeRadius, IfcPositiveLengthMeasure WebEdgeRadius, IfcPlaneAngleMeasure WebSlope, IfcPlaneAngleMeasure FlangeSlope, IfcPositiveLengthMeasure CentreOfGravityInY) : base (ProfileType, ProfileName, Position)
		{
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.FlangeEdgeRadius = FlangeEdgeRadius;
			this.WebEdgeRadius = WebEdgeRadius;
			this.WebSlope = WebSlope;
			this.FlangeSlope = FlangeSlope;
			this.CentreOfGravityInY = CentreOfGravityInY;
		}
	}
	/// <summary>
	/// ENTITY IfcTable;
	/// <para>ENTITY IfcTable;</para>
	/// <para>	Name : STRING;</para>
	/// <para>	Rows : LIST [1:?] OF IfcTableRow;</para>
	/// <para> DERIVE</para>
	/// <para>	NumberOfCellsInRow : INTEGER := HIINDEX(Rows[1].RowCells);</para>
	/// <para>	NumberOfHeadings : INTEGER := SIZEOF(QUERY( Temp <* Rows | Temp.IsHeading));</para>
	/// <para>	NumberOfDataRows : INTEGER := SIZEOF(QUERY( Temp <* Rows | NOT(Temp.IsHeading)));</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY( Temp <* Rows | HIINDEX(Temp.RowCells) <> HIINDEX(Rows[1].RowCells))) = 0;</para>
	/// <para>	WR2 : SIZEOF(QUERY( Temp <* Rows | HIINDEX(Temp.RowCells) <> HIINDEX(Rows[1].RowCells))) = 0;</para>
	/// <para>	WR3 : { 0 <= NumberOfHeadings <= 1 };</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTableENTITY, IfcMetricValueSelect
	{
		public STRING Name { get; set; }
		public List<IfcTableRow> Rows { get; set; }
		public IfcTable() : base()
		{
			Name = new STRING();
			Rows = new List<IfcTableRow>();
		}
		public IfcTable(STRING Name, List<IfcTableRow> Rows) : base ()
		{
			this.Name = Name;
			this.Rows = Rows;
		}
	}
	/// <summary>
	/// ENTITY IfcTableRow;
	/// <para>ENTITY IfcTableRow;</para>
	/// <para>	RowCells : LIST [1:?] OF IfcValue;</para>
	/// <para>	IsHeading : BOOLEAN;</para>
	/// <para> INVERSE</para>
	/// <para>	OfTable : IfcTable FOR Rows;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTableRowENTITY
	{
		public List<IfcValue> RowCells { get; set; }
		public BOOLEAN IsHeading { get; set; }
		public IfcTableRow() : base()
		{
			RowCells = new List<IfcValue>();
			IsHeading = new BOOLEAN();
		}
		public IfcTableRow(List<IfcValue> RowCells, BOOLEAN IsHeading) : base ()
		{
			this.RowCells = RowCells;
			this.IsHeading = IsHeading;
		}
	}
	/// <summary>
	/// ENTITY IfcTankType
	/// <para>ENTITY IfcTankType</para>
	/// <para> SUBTYPE OF (IfcFlowStorageDeviceType);</para>
	/// <para>	PredefinedType : IfcTankTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcTankTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcTankTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTankType : IfcFlowStorageDeviceType
	{
		public IfcTankTypeEnum PredefinedType { get; set; }
		public IfcTankType() : base()
		{
			PredefinedType = new IfcTankTypeEnum();
		}
		public IfcTankType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcTankTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcTask
	/// <para>ENTITY IfcTask</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcMove</para>
	/// <para>	,IfcOrderAction))</para>
	/// <para> SUBTYPE OF (IfcProcess);</para>
	/// <para>	TaskId : IfcIdentifier;</para>
	/// <para>	Status : OPTIONAL IfcLabel;</para>
	/// <para>	WorkMethod : OPTIONAL IfcLabel;</para>
	/// <para>	IsMilestone : BOOLEAN;</para>
	/// <para>	Priority : OPTIONAL INTEGER;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;</para>
	/// <para>	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;</para>
	/// <para>	WR3 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTask : IfcProcess
	{
		public IfcIdentifier TaskId { get; set; }
		public IfcLabel? Status { get; set; }
		public IfcLabel? WorkMethod { get; set; }
		public BOOLEAN IsMilestone { get; set; }
		public INTEGER? Priority { get; set; }
		public IfcTask() : base()
		{
			TaskId = new IfcIdentifier();
			IsMilestone = new BOOLEAN();
		}
		public IfcTask(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier TaskId, IfcLabel Status, IfcLabel WorkMethod, BOOLEAN IsMilestone, INTEGER Priority) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.TaskId = TaskId;
			this.Status = Status;
			this.WorkMethod = WorkMethod;
			this.IsMilestone = IsMilestone;
			this.Priority = Priority;
		}
	}
	/// <summary>
	/// ENTITY IfcTelecomAddress
	/// <para>ENTITY IfcTelecomAddress</para>
	/// <para> SUBTYPE OF (IfcAddress);</para>
	/// <para>	TelephoneNumbers : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	FacsimileNumbers : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	PagerNumber : OPTIONAL IfcLabel;</para>
	/// <para>	ElectronicMailAddresses : OPTIONAL LIST [1:?] OF IfcLabel;</para>
	/// <para>	WWWHomePageURL : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS (TelephoneNumbers) OR</para>
	/// <para>            EXISTS (PagerNumber) OR</para>
	/// <para>            EXISTS (FacsimileNumbers) OR </para>
	/// <para>            EXISTS (ElectronicMailAddresses) OR </para>
	/// <para>            EXISTS (WWWHomePageURL);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTelecomAddress : IfcAddress
	{
		public List<IfcLabel>? TelephoneNumbers { get; set; }
		public List<IfcLabel>? FacsimileNumbers { get; set; }
		public IfcLabel? PagerNumber { get; set; }
		public List<IfcLabel>? ElectronicMailAddresses { get; set; }
		public IfcLabel? WWWHomePageURL { get; set; }
		public IfcTelecomAddress() : base()
		{
		}
		public IfcTelecomAddress(IfcAddressTypeEnum Purpose, IfcText Description, IfcLabel UserDefinedPurpose, List<IfcLabel> TelephoneNumbers, List<IfcLabel> FacsimileNumbers, IfcLabel PagerNumber, List<IfcLabel> ElectronicMailAddresses, IfcLabel WWWHomePageURL) : base (Purpose, Description, UserDefinedPurpose)
		{
			this.TelephoneNumbers = TelephoneNumbers;
			this.FacsimileNumbers = FacsimileNumbers;
			this.PagerNumber = PagerNumber;
			this.ElectronicMailAddresses = ElectronicMailAddresses;
			this.WWWHomePageURL = WWWHomePageURL;
		}
	}
	/// <summary>
	/// ENTITY IfcTendon
	/// <para>ENTITY IfcTendon</para>
	/// <para> SUBTYPE OF (IfcReinforcingElement);</para>
	/// <para>	PredefinedType : IfcTendonTypeEnum;</para>
	/// <para>	NominalDiameter : IfcPositiveLengthMeasure;</para>
	/// <para>	CrossSectionArea : IfcAreaMeasure;</para>
	/// <para>	TensionForce : OPTIONAL IfcForceMeasure;</para>
	/// <para>	PreStress : OPTIONAL IfcPressureMeasure;</para>
	/// <para>	FrictionCoefficient : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	AnchorageSlip : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	MinCurvatureRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcTendonTypeEnum.USERDEFINED) OR ((PredefinedType = IfcTendonTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcObject.ObjectType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTendon : IfcReinforcingElement
	{
		public IfcTendonTypeEnum PredefinedType { get; set; }
		public IfcPositiveLengthMeasure NominalDiameter { get; set; }
		public IfcAreaMeasure CrossSectionArea { get; set; }
		public IfcForceMeasure? TensionForce { get; set; }
		public IfcPressureMeasure? PreStress { get; set; }
		public IfcNormalisedRatioMeasure? FrictionCoefficient { get; set; }
		public IfcPositiveLengthMeasure? AnchorageSlip { get; set; }
		public IfcPositiveLengthMeasure? MinCurvatureRadius { get; set; }
		public IfcTendon() : base()
		{
			PredefinedType = new IfcTendonTypeEnum();
			NominalDiameter = new IfcPositiveLengthMeasure();
			CrossSectionArea = new IfcAreaMeasure();
		}
		public IfcTendon(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade, IfcTendonTypeEnum PredefinedType, IfcPositiveLengthMeasure NominalDiameter, IfcAreaMeasure CrossSectionArea, IfcForceMeasure TensionForce, IfcPressureMeasure PreStress, IfcNormalisedRatioMeasure FrictionCoefficient, IfcPositiveLengthMeasure AnchorageSlip, IfcPositiveLengthMeasure MinCurvatureRadius) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, SteelGrade)
		{
			this.PredefinedType = PredefinedType;
			this.NominalDiameter = NominalDiameter;
			this.CrossSectionArea = CrossSectionArea;
			this.TensionForce = TensionForce;
			this.PreStress = PreStress;
			this.FrictionCoefficient = FrictionCoefficient;
			this.AnchorageSlip = AnchorageSlip;
			this.MinCurvatureRadius = MinCurvatureRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcTendonAnchor
	/// <para>ENTITY IfcTendonAnchor</para>
	/// <para> SUBTYPE OF (IfcReinforcingElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTendonAnchor : IfcReinforcingElement
	{
		public IfcTendonAnchor() : base()
		{
		}
		public IfcTendonAnchor(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcLabel SteelGrade) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag, SteelGrade)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcTerminatorSymbol
	/// <para>ENTITY IfcTerminatorSymbol</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDimensionCurveTerminator))</para>
	/// <para> SUBTYPE OF (IfcAnnotationSymbolOccurrence);</para>
	/// <para>	AnnotatedCurve : IfcAnnotationCurveOccurrence;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTerminatorSymbol : IfcAnnotationSymbolOccurrence
	{
		public IfcAnnotationCurveOccurrence AnnotatedCurve { get; set; }
		public IfcTerminatorSymbol() : base()
		{
			AnnotatedCurve = new IfcAnnotationCurveOccurrence();
		}
		public IfcTerminatorSymbol(IfcRepresentationItem Item, List<IfcPresentationStyleAssignment> Styles, IfcLabel Name, IfcAnnotationCurveOccurrence AnnotatedCurve) : base (Item, Styles, Name)
		{
			this.AnnotatedCurve = AnnotatedCurve;
		}
	}
	/// <summary>
	/// ENTITY IfcTextLiteral
	/// <para>ENTITY IfcTextLiteral</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcTextLiteralWithExtent))</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Literal : IfcPresentableText;</para>
	/// <para>	Placement : IfcAxis2Placement;</para>
	/// <para>	Path : IfcTextPath;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextLiteral : IfcGeometricRepresentationItem
	{
		public IfcPresentableText Literal { get; set; }
		public IfcAxis2Placement Placement { get; set; }
		public IfcTextPath Path { get; set; }
		public IfcTextLiteral() : base()
		{
			Literal = new IfcPresentableText();
			Placement = new IfcAxis2Placement();
			Path = new IfcTextPath();
		}
		public IfcTextLiteral(IfcPresentableText Literal, IfcAxis2Placement Placement, IfcTextPath Path) : base ()
		{
			this.Literal = Literal;
			this.Placement = Placement;
			this.Path = Path;
		}
	}
	/// <summary>
	/// ENTITY IfcTextLiteralWithExtent
	/// <para>ENTITY IfcTextLiteralWithExtent</para>
	/// <para> SUBTYPE OF (IfcTextLiteral);</para>
	/// <para>	Extent : IfcPlanarExtent;</para>
	/// <para>	BoxAlignment : IfcBoxAlignment;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT('IFC2X3.IFCPLANARBOX' IN TYPEOF(Extent));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextLiteralWithExtent : IfcTextLiteral
	{
		public IfcPlanarExtent Extent { get; set; }
		public IfcBoxAlignment BoxAlignment { get; set; }
		public IfcTextLiteralWithExtent() : base()
		{
			Extent = new IfcPlanarExtent();
			BoxAlignment = new IfcBoxAlignment();
		}
		public IfcTextLiteralWithExtent(IfcPresentableText Literal, IfcAxis2Placement Placement, IfcTextPath Path, IfcPlanarExtent Extent, IfcBoxAlignment BoxAlignment) : base (Literal, Placement, Path)
		{
			this.Extent = Extent;
			this.BoxAlignment = BoxAlignment;
		}
	}
	/// <summary>
	/// ENTITY IfcTextStyle
	/// <para>ENTITY IfcTextStyle</para>
	/// <para> SUBTYPE OF (IfcPresentationStyle);</para>
	/// <para>	TextCharacterAppearance : OPTIONAL IfcCharacterStyleSelect;</para>
	/// <para>	TextStyle : OPTIONAL IfcTextStyleSelect;</para>
	/// <para>	TextFontStyle : IfcTextFontSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		public IfcCharacterStyleSelect? TextCharacterAppearance { get; set; }
		public IfcTextStyleSelect? TextStyle { get; set; }
		public IfcTextFontSelect TextFontStyle { get; set; }
		public IfcTextStyle() : base()
		{
			TextFontStyle = new IfcTextFontSelect();
		}
		public IfcTextStyle(IfcLabel Name, IfcCharacterStyleSelect TextCharacterAppearance, IfcTextStyleSelect TextStyle, IfcTextFontSelect TextFontStyle) : base (Name)
		{
			this.TextCharacterAppearance = TextCharacterAppearance;
			this.TextStyle = TextStyle;
			this.TextFontStyle = TextFontStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcTextStyleFontModel
	/// <para>ENTITY IfcTextStyleFontModel</para>
	/// <para> SUBTYPE OF (IfcPreDefinedTextFont);</para>
	/// <para>	FontFamily : OPTIONAL LIST [1:?] OF IfcTextFontName;</para>
	/// <para>	FontStyle : OPTIONAL IfcFontStyle;</para>
	/// <para>	FontVariant : OPTIONAL IfcFontVariant;</para>
	/// <para>	FontWeight : OPTIONAL IfcFontWeight;</para>
	/// <para>	FontSize : IfcSizeSelect;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : ('IFC2X3.IFCLENGTHMEASURE' IN TYPEOF(SELF.FontSize)) AND</para>
	/// <para>             (SELF.FontSize > 0.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextStyleFontModel : IfcPreDefinedTextFont
	{
		public List<IfcTextFontName>? FontFamily { get; set; }
		public IfcFontStyle? FontStyle { get; set; }
		public IfcFontVariant? FontVariant { get; set; }
		public IfcFontWeight? FontWeight { get; set; }
		public IfcSizeSelect FontSize { get; set; }
		public IfcTextStyleFontModel() : base()
		{
			FontSize = new IfcSizeSelect();
		}
		public IfcTextStyleFontModel(IfcLabel Name, List<IfcTextFontName> FontFamily, IfcFontStyle FontStyle, IfcFontVariant FontVariant, IfcFontWeight FontWeight, IfcSizeSelect FontSize) : base (Name)
		{
			this.FontFamily = FontFamily;
			this.FontStyle = FontStyle;
			this.FontVariant = FontVariant;
			this.FontWeight = FontWeight;
			this.FontSize = FontSize;
		}
	}
	/// <summary>
	/// ENTITY IfcTextStyleForDefinedFont;
	/// <para>ENTITY IfcTextStyleForDefinedFont;</para>
	/// <para>	Colour : IfcColour;</para>
	/// <para>	BackgroundColour : OPTIONAL IfcColour;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextStyleForDefinedFontENTITY, IfcCharacterStyleSelect
	{
		public IfcColour Colour { get; set; }
		public IfcColour? BackgroundColour { get; set; }
		public IfcTextStyleForDefinedFont() : base()
		{
			Colour = new IfcColour();
		}
		public IfcTextStyleForDefinedFont(IfcColour Colour, IfcColour BackgroundColour) : base ()
		{
			this.Colour = Colour;
			this.BackgroundColour = BackgroundColour;
		}
	}
	/// <summary>
	/// ENTITY IfcTextStyleTextModel;
	/// <para>ENTITY IfcTextStyleTextModel;</para>
	/// <para>	TextIndent : OPTIONAL IfcSizeSelect;</para>
	/// <para>	TextAlign : OPTIONAL IfcTextAlignment;</para>
	/// <para>	TextDecoration : OPTIONAL IfcTextDecoration;</para>
	/// <para>	LetterSpacing : OPTIONAL IfcSizeSelect;</para>
	/// <para>	WordSpacing : OPTIONAL IfcSizeSelect;</para>
	/// <para>	TextTransform : OPTIONAL IfcTextTransformation;</para>
	/// <para>	LineHeight : OPTIONAL IfcSizeSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextStyleTextModelENTITY, IfcTextStyleSelect
	{
		public IfcSizeSelect? TextIndent { get; set; }
		public IfcTextAlignment? TextAlign { get; set; }
		public IfcTextDecoration? TextDecoration { get; set; }
		public IfcSizeSelect? LetterSpacing { get; set; }
		public IfcSizeSelect? WordSpacing { get; set; }
		public IfcTextTransformation? TextTransform { get; set; }
		public IfcSizeSelect? LineHeight { get; set; }
		public IfcTextStyleTextModel() : base()
		{
		}
		public IfcTextStyleTextModel(IfcSizeSelect TextIndent, IfcTextAlignment TextAlign, IfcTextDecoration TextDecoration, IfcSizeSelect LetterSpacing, IfcSizeSelect WordSpacing, IfcTextTransformation TextTransform, IfcSizeSelect LineHeight) : base ()
		{
			this.TextIndent = TextIndent;
			this.TextAlign = TextAlign;
			this.TextDecoration = TextDecoration;
			this.LetterSpacing = LetterSpacing;
			this.WordSpacing = WordSpacing;
			this.TextTransform = TextTransform;
			this.LineHeight = LineHeight;
		}
	}
	/// <summary>
	/// ENTITY IfcTextStyleWithBoxCharacteristics;
	/// <para>ENTITY IfcTextStyleWithBoxCharacteristics;</para>
	/// <para>	BoxHeight : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	BoxWidth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	BoxSlantAngle : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	BoxRotateAngle : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	CharacterSpacing : OPTIONAL IfcSizeSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextStyleWithBoxCharacteristicsENTITY, IfcTextStyleSelect
	{
		public IfcPositiveLengthMeasure? BoxHeight { get; set; }
		public IfcPositiveLengthMeasure? BoxWidth { get; set; }
		public IfcPlaneAngleMeasure? BoxSlantAngle { get; set; }
		public IfcPlaneAngleMeasure? BoxRotateAngle { get; set; }
		public IfcSizeSelect? CharacterSpacing { get; set; }
		public IfcTextStyleWithBoxCharacteristics() : base()
		{
		}
		public IfcTextStyleWithBoxCharacteristics(IfcPositiveLengthMeasure BoxHeight, IfcPositiveLengthMeasure BoxWidth, IfcPlaneAngleMeasure BoxSlantAngle, IfcPlaneAngleMeasure BoxRotateAngle, IfcSizeSelect CharacterSpacing) : base ()
		{
			this.BoxHeight = BoxHeight;
			this.BoxWidth = BoxWidth;
			this.BoxSlantAngle = BoxSlantAngle;
			this.BoxRotateAngle = BoxRotateAngle;
			this.CharacterSpacing = CharacterSpacing;
		}
	}
	/// <summary>
	/// ENTITY IfcTextureCoordinate
	/// <para>ENTITY IfcTextureCoordinate</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcTextureCoordinateGenerator</para>
	/// <para>	,IfcTextureMap));</para>
	/// <para> INVERSE</para>
	/// <para>	AnnotatedSurface : SET [1:1] OF IfcAnnotationSurface FOR TextureCoordinates;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcTextureCoordinateENTITY
	{
		public IfcTextureCoordinate() : base()
		{
		}
		public IfcTextureCoordinate() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcTextureCoordinateGenerator
	/// <para>ENTITY IfcTextureCoordinateGenerator</para>
	/// <para> SUBTYPE OF (IfcTextureCoordinate);</para>
	/// <para>	Mode : IfcLabel;</para>
	/// <para>	Parameter : LIST [1:?] OF IfcSimpleValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextureCoordinateGenerator : IfcTextureCoordinate
	{
		public IfcLabel Mode { get; set; }
		public List<IfcSimpleValue> Parameter { get; set; }
		public IfcTextureCoordinateGenerator() : base()
		{
			Mode = new IfcLabel();
			Parameter = new List<IfcSimpleValue>();
		}
		public IfcTextureCoordinateGenerator(IfcLabel Mode, List<IfcSimpleValue> Parameter) : base ()
		{
			this.Mode = Mode;
			this.Parameter = Parameter;
		}
	}
	/// <summary>
	/// ENTITY IfcTextureMap
	/// <para>ENTITY IfcTextureMap</para>
	/// <para> SUBTYPE OF (IfcTextureCoordinate);</para>
	/// <para>	TextureMaps : SET [1:?] OF IfcVertexBasedTextureMap;</para>
	/// <para> WHERE</para>
	/// <para>	WR11 : SIZEOF([</para>
	/// <para>               'IFC2X3.IFCSHELLBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCFACEBASEDSURFACEMODEL',</para>
	/// <para>               'IFC2X3.IFCFACETEDBREP',</para>
	/// <para>               'IFC2X3.IFCFACETEDBREPWITHVOIDS'] </para>
	/// <para>              * TYPEOF(SELF\IfcTextureCoordinate.AnnotatedSurface[1].Item)</para>
	/// <para>               ) >= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextureMap : IfcTextureCoordinate
	{
		public List<IfcVertexBasedTextureMap> TextureMaps { get; set; }
		public IfcTextureMap() : base()
		{
			TextureMaps = new List<IfcVertexBasedTextureMap>();
		}
		public IfcTextureMap(List<IfcVertexBasedTextureMap> TextureMaps) : base ()
		{
			this.TextureMaps = TextureMaps;
		}
	}
	/// <summary>
	/// ENTITY IfcTextureVertex;
	/// <para>ENTITY IfcTextureVertex;</para>
	/// <para>	Coordinates : LIST [2:2] OF IfcParameterValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTextureVertexENTITY
	{
		public List<IfcParameterValue> Coordinates { get; set; }
		public IfcTextureVertex() : base()
		{
			Coordinates = new List<IfcParameterValue>();
		}
		public IfcTextureVertex(List<IfcParameterValue> Coordinates) : base ()
		{
			this.Coordinates = Coordinates;
		}
	}
	/// <summary>
	/// ENTITY IfcThermalMaterialProperties
	/// <para>ENTITY IfcThermalMaterialProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	SpecificHeatCapacity : OPTIONAL IfcSpecificHeatCapacityMeasure;</para>
	/// <para>	BoilingPoint : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	FreezingPoint : OPTIONAL IfcThermodynamicTemperatureMeasure;</para>
	/// <para>	ThermalConductivity : OPTIONAL IfcThermalConductivityMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcThermalMaterialProperties : IfcMaterialProperties
	{
		public IfcSpecificHeatCapacityMeasure? SpecificHeatCapacity { get; set; }
		public IfcThermodynamicTemperatureMeasure? BoilingPoint { get; set; }
		public IfcThermodynamicTemperatureMeasure? FreezingPoint { get; set; }
		public IfcThermalConductivityMeasure? ThermalConductivity { get; set; }
		public IfcThermalMaterialProperties() : base()
		{
		}
		public IfcThermalMaterialProperties(IfcMaterial Material, IfcSpecificHeatCapacityMeasure SpecificHeatCapacity, IfcThermodynamicTemperatureMeasure BoilingPoint, IfcThermodynamicTemperatureMeasure FreezingPoint, IfcThermalConductivityMeasure ThermalConductivity) : base (Material)
		{
			this.SpecificHeatCapacity = SpecificHeatCapacity;
			this.BoilingPoint = BoilingPoint;
			this.FreezingPoint = FreezingPoint;
			this.ThermalConductivity = ThermalConductivity;
		}
	}
	/// <summary>
	/// ENTITY IfcTimeSeries
	/// <para>ENTITY IfcTimeSeries</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcIrregularTimeSeries</para>
	/// <para>	,IfcRegularTimeSeries));</para>
	/// <para>	Name : IfcLabel;</para>
	/// <para>	Description : OPTIONAL IfcText;</para>
	/// <para>	StartTime : IfcDateTimeSelect;</para>
	/// <para>	EndTime : IfcDateTimeSelect;</para>
	/// <para>	TimeSeriesDataType : IfcTimeSeriesDataTypeEnum;</para>
	/// <para>	DataOrigin : IfcDataOriginEnum;</para>
	/// <para>	UserDefinedDataOrigin : OPTIONAL IfcLabel;</para>
	/// <para>	Unit : OPTIONAL IfcUnit;</para>
	/// <para> INVERSE</para>
	/// <para>	DocumentedBy : SET [0:1] OF IfcTimeSeriesReferenceRelationship FOR ReferencedTimeSeries;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcTimeSeriesENTITY, IfcMetricValueSelect, IfcObjectReferenceSelect
	{
		public IfcLabel Name { get; set; }
		public IfcText? Description { get; set; }
		public IfcDateTimeSelect StartTime { get; set; }
		public IfcDateTimeSelect EndTime { get; set; }
		public IfcTimeSeriesDataTypeEnum TimeSeriesDataType { get; set; }
		public IfcDataOriginEnum DataOrigin { get; set; }
		public IfcLabel? UserDefinedDataOrigin { get; set; }
		public IfcUnit? Unit { get; set; }
		public IfcTimeSeries() : base()
		{
			Name = new IfcLabel();
			StartTime = new IfcDateTimeSelect();
			EndTime = new IfcDateTimeSelect();
			TimeSeriesDataType = new IfcTimeSeriesDataTypeEnum();
			DataOrigin = new IfcDataOriginEnum();
		}
		public IfcTimeSeries(IfcLabel Name, IfcText Description, IfcDateTimeSelect StartTime, IfcDateTimeSelect EndTime, IfcTimeSeriesDataTypeEnum TimeSeriesDataType, IfcDataOriginEnum DataOrigin, IfcLabel UserDefinedDataOrigin, IfcUnit Unit) : base ()
		{
			this.Name = Name;
			this.Description = Description;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			this.TimeSeriesDataType = TimeSeriesDataType;
			this.DataOrigin = DataOrigin;
			this.UserDefinedDataOrigin = UserDefinedDataOrigin;
			this.Unit = Unit;
		}
	}
	/// <summary>
	/// ENTITY IfcTimeSeriesReferenceRelationship;
	/// <para>ENTITY IfcTimeSeriesReferenceRelationship;</para>
	/// <para>	ReferencedTimeSeries : IfcTimeSeries;</para>
	/// <para>	TimeSeriesReferences : SET [1:?] OF IfcDocumentSelect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTimeSeriesReferenceRelationshipENTITY
	{
		public IfcTimeSeries ReferencedTimeSeries { get; set; }
		public List<IfcDocumentSelect> TimeSeriesReferences { get; set; }
		public IfcTimeSeriesReferenceRelationship() : base()
		{
			ReferencedTimeSeries = new IfcTimeSeries();
			TimeSeriesReferences = new List<IfcDocumentSelect>();
		}
		public IfcTimeSeriesReferenceRelationship(IfcTimeSeries ReferencedTimeSeries, List<IfcDocumentSelect> TimeSeriesReferences) : base ()
		{
			this.ReferencedTimeSeries = ReferencedTimeSeries;
			this.TimeSeriesReferences = TimeSeriesReferences;
		}
	}
	/// <summary>
	/// ENTITY IfcTimeSeriesSchedule
	/// <para>ENTITY IfcTimeSeriesSchedule</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	ApplicableDates : OPTIONAL LIST [1:?] OF IfcDateTimeSelect;</para>
	/// <para>	TimeSeriesScheduleType : IfcTimeSeriesScheduleTypeEnum;</para>
	/// <para>	TimeSeries : IfcTimeSeries;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : NOT(TimeSeriesScheduleType=IfcTimeSeriesScheduleTypeEnum.USERDEFINED) OR EXISTS(SELF\IfcObject.ObjectType);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTimeSeriesSchedule : IfcControl
	{
		public List<IfcDateTimeSelect>? ApplicableDates { get; set; }
		public IfcTimeSeriesScheduleTypeEnum TimeSeriesScheduleType { get; set; }
		public IfcTimeSeries TimeSeries { get; set; }
		public IfcTimeSeriesSchedule() : base()
		{
			TimeSeriesScheduleType = new IfcTimeSeriesScheduleTypeEnum();
			TimeSeries = new IfcTimeSeries();
		}
		public IfcTimeSeriesSchedule(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, List<IfcDateTimeSelect> ApplicableDates, IfcTimeSeriesScheduleTypeEnum TimeSeriesScheduleType, IfcTimeSeries TimeSeries) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.ApplicableDates = ApplicableDates;
			this.TimeSeriesScheduleType = TimeSeriesScheduleType;
			this.TimeSeries = TimeSeries;
		}
	}
	/// <summary>
	/// ENTITY IfcTimeSeriesValue;
	/// <para>ENTITY IfcTimeSeriesValue;</para>
	/// <para>	ListValues : LIST [1:?] OF IfcValue;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTimeSeriesValueENTITY
	{
		public List<IfcValue> ListValues { get; set; }
		public IfcTimeSeriesValue() : base()
		{
			ListValues = new List<IfcValue>();
		}
		public IfcTimeSeriesValue(List<IfcValue> ListValues) : base ()
		{
			this.ListValues = ListValues;
		}
	}
	/// <summary>
	/// ENTITY IfcTopologicalRepresentationItem
	/// <para>ENTITY IfcTopologicalRepresentationItem</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcConnectedFaceSet</para>
	/// <para>	,IfcEdge</para>
	/// <para>	,IfcFace</para>
	/// <para>	,IfcFaceBound</para>
	/// <para>	,IfcLoop</para>
	/// <para>	,IfcPath</para>
	/// <para>	,IfcVertex))</para>
	/// <para> SUBTYPE OF (IfcRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcTopologicalRepresentationItem : IfcRepresentationItem
	{
		public IfcTopologicalRepresentationItem() : base()
		{
		}
		public IfcTopologicalRepresentationItem() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcTopologyRepresentation
	/// <para>ENTITY IfcTopologyRepresentation</para>
	/// <para> SUBTYPE OF (IfcShapeModel);</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : SIZEOF(QUERY(temp <* SELF\IfcRepresentation.Items | </para>
	/// <para>               NOT('IFC2X3.IFCTOPOLOGICALREPRESENTATIONITEM' IN TYPEOF(temp))</para>
	/// <para>             )) = 0;</para>
	/// <para>	WR22 : EXISTS(SELF\IfcRepresentation.RepresentationType);</para>
	/// <para>	WR23 : IfcTopologyRepresentationTypes(SELF\IfcRepresentation.RepresentationType, SELF\IfcRepresentation.Items);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTopologyRepresentation : IfcShapeModel
	{
		public IfcTopologyRepresentation() : base()
		{
		}
		public IfcTopologyRepresentation(IfcRepresentationContext ContextOfItems, IfcLabel RepresentationIdentifier, IfcLabel RepresentationType, List<IfcRepresentationItem> Items) : base (ContextOfItems, RepresentationIdentifier, RepresentationType, Items)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcTransformerType
	/// <para>ENTITY IfcTransformerType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcTransformerTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTransformerType : IfcEnergyConversionDeviceType
	{
		public IfcTransformerTypeEnum PredefinedType { get; set; }
		public IfcTransformerType() : base()
		{
			PredefinedType = new IfcTransformerTypeEnum();
		}
		public IfcTransformerType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcTransformerTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcTransportElement
	/// <para>ENTITY IfcTransportElement</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>	OperationType : OPTIONAL IfcTransportElementTypeEnum;</para>
	/// <para>	CapacityByWeight : OPTIONAL IfcMassMeasure;</para>
	/// <para>	CapacityByNumber : OPTIONAL IfcCountMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTransportElement : IfcElement
	{
		public IfcTransportElementTypeEnum? OperationType { get; set; }
		public IfcMassMeasure? CapacityByWeight { get; set; }
		public IfcCountMeasure? CapacityByNumber { get; set; }
		public IfcTransportElement() : base()
		{
		}
		public IfcTransportElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcTransportElementTypeEnum OperationType, IfcMassMeasure CapacityByWeight, IfcCountMeasure CapacityByNumber) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.OperationType = OperationType;
			this.CapacityByWeight = CapacityByWeight;
			this.CapacityByNumber = CapacityByNumber;
		}
	}
	/// <summary>
	/// ENTITY IfcTransportElementType
	/// <para>ENTITY IfcTransportElementType</para>
	/// <para> SUBTYPE OF (IfcElementType);</para>
	/// <para>	PredefinedType : IfcTransportElementTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTransportElementType : IfcElementType
	{
		public IfcTransportElementTypeEnum PredefinedType { get; set; }
		public IfcTransportElementType() : base()
		{
			PredefinedType = new IfcTransportElementTypeEnum();
		}
		public IfcTransportElementType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcTransportElementTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcTrapeziumProfileDef
	/// <para>ENTITY IfcTrapeziumProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	BottomXDim : IfcPositiveLengthMeasure;</para>
	/// <para>	TopXDim : IfcPositiveLengthMeasure;</para>
	/// <para>	YDim : IfcPositiveLengthMeasure;</para>
	/// <para>	TopXOffset : IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTrapeziumProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure BottomXDim { get; set; }
		public IfcPositiveLengthMeasure TopXDim { get; set; }
		public IfcPositiveLengthMeasure YDim { get; set; }
		public IfcLengthMeasure TopXOffset { get; set; }
		public IfcTrapeziumProfileDef() : base()
		{
			BottomXDim = new IfcPositiveLengthMeasure();
			TopXDim = new IfcPositiveLengthMeasure();
			YDim = new IfcPositiveLengthMeasure();
			TopXOffset = new IfcLengthMeasure();
		}
		public IfcTrapeziumProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure BottomXDim, IfcPositiveLengthMeasure TopXDim, IfcPositiveLengthMeasure YDim, IfcLengthMeasure TopXOffset) : base (ProfileType, ProfileName, Position)
		{
			this.BottomXDim = BottomXDim;
			this.TopXDim = TopXDim;
			this.YDim = YDim;
			this.TopXOffset = TopXOffset;
		}
	}
	/// <summary>
	/// ENTITY IfcTrimmedCurve
	/// <para>ENTITY IfcTrimmedCurve</para>
	/// <para> SUBTYPE OF (IfcBoundedCurve);</para>
	/// <para>	BasisCurve : IfcCurve;</para>
	/// <para>	Trim1 : SET [1:2] OF IfcTrimmingSelect;</para>
	/// <para>	Trim2 : SET [1:2] OF IfcTrimmingSelect;</para>
	/// <para>	SenseAgreement : BOOLEAN;</para>
	/// <para>	MasterRepresentation : IfcTrimmingPreference;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : (HIINDEX(Trim1) = 1) OR (TYPEOF(Trim1[1]) <> TYPEOF(Trim1[2]));</para>
	/// <para>	WR42 : (HIINDEX(Trim2) = 1) OR (TYPEOF(Trim2[1]) <> TYPEOF(Trim2[2]));</para>
	/// <para>	WR43 : NOT('IFC2X3.IFCBOUNDEDCURVE' IN TYPEOF(BasisCurve));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTrimmedCurve : IfcBoundedCurve
	{
		public IfcCurve BasisCurve { get; set; }
		public List<IfcTrimmingSelect> Trim1 { get; set; }
		public List<IfcTrimmingSelect> Trim2 { get; set; }
		public BOOLEAN SenseAgreement { get; set; }
		public IfcTrimmingPreference MasterRepresentation { get; set; }
		public IfcTrimmedCurve() : base()
		{
			BasisCurve = new IfcCurve();
			Trim1 = new List<IfcTrimmingSelect>();
			Trim2 = new List<IfcTrimmingSelect>();
			SenseAgreement = new BOOLEAN();
			MasterRepresentation = new IfcTrimmingPreference();
		}
		public IfcTrimmedCurve(IfcCurve BasisCurve, List<IfcTrimmingSelect> Trim1, List<IfcTrimmingSelect> Trim2, BOOLEAN SenseAgreement, IfcTrimmingPreference MasterRepresentation) : base ()
		{
			this.BasisCurve = BasisCurve;
			this.Trim1 = Trim1;
			this.Trim2 = Trim2;
			this.SenseAgreement = SenseAgreement;
			this.MasterRepresentation = MasterRepresentation;
		}
	}
	/// <summary>
	/// ENTITY IfcTubeBundleType
	/// <para>ENTITY IfcTubeBundleType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcTubeBundleTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcTubeBundleTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcTubeBundleTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTubeBundleType : IfcEnergyConversionDeviceType
	{
		public IfcTubeBundleTypeEnum PredefinedType { get; set; }
		public IfcTubeBundleType() : base()
		{
			PredefinedType = new IfcTubeBundleTypeEnum();
		}
		public IfcTubeBundleType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcTubeBundleTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcTwoDirectionRepeatFactor
	/// <para>ENTITY IfcTwoDirectionRepeatFactor</para>
	/// <para> SUBTYPE OF (IfcOneDirectionRepeatFactor);</para>
	/// <para>	SecondRepeatFactor : IfcVector;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTwoDirectionRepeatFactor : IfcOneDirectionRepeatFactor
	{
		public IfcVector SecondRepeatFactor { get; set; }
		public IfcTwoDirectionRepeatFactor() : base()
		{
			SecondRepeatFactor = new IfcVector();
		}
		public IfcTwoDirectionRepeatFactor(IfcVector RepeatFactor, IfcVector SecondRepeatFactor) : base (RepeatFactor)
		{
			this.SecondRepeatFactor = SecondRepeatFactor;
		}
	}
	/// <summary>
	/// ENTITY IfcTypeObject
	/// <para>ENTITY IfcTypeObject</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcTypeProduct))</para>
	/// <para> SUBTYPE OF (IfcObjectDefinition);</para>
	/// <para>	ApplicableOccurrence : OPTIONAL IfcLabel;</para>
	/// <para>	HasPropertySets : OPTIONAL SET [1:?] OF IfcPropertySetDefinition;</para>
	/// <para> INVERSE</para>
	/// <para>	ObjectTypeOf : SET [0:1] OF IfcRelDefinesByType FOR RelatingType;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : EXISTS(SELF\IfcRoot.Name);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTypeObject : IfcObjectDefinition
	{
		public IfcLabel? ApplicableOccurrence { get; set; }
		public List<IfcPropertySetDefinition>? HasPropertySets { get; set; }
		public IfcTypeObject() : base()
		{
		}
		public IfcTypeObject(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.ApplicableOccurrence = ApplicableOccurrence;
			this.HasPropertySets = HasPropertySets;
		}
	}
	/// <summary>
	/// ENTITY IfcTypeProduct
	/// <para>ENTITY IfcTypeProduct</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcDoorStyle</para>
	/// <para>	,IfcElementType</para>
	/// <para>	,IfcWindowStyle))</para>
	/// <para> SUBTYPE OF (IfcTypeObject);</para>
	/// <para>	RepresentationMaps : OPTIONAL LIST [1:?] OF UNIQUE IfcRepresentationMap;</para>
	/// <para>	Tag : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR41 : NOT(EXISTS(SELF\IfcTypeObject.ObjectTypeOf[1])) OR</para>
	/// <para>             (SIZEOF(QUERY(temp <* SELF\IfcTypeObject.ObjectTypeOf[1].RelatedObjects |</para>
	/// <para>               NOT('IFC2X3.IFCPRODUCT' IN TYPEOF(temp)))</para>
	/// <para>             ) = 0);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcTypeProduct : IfcTypeObject
	{
		public IfcTypeProduct() : base()
		{
		}
		public IfcTypeProduct(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcUShapeProfileDef
	/// <para>ENTITY IfcUShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	EdgeRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeSlope : OPTIONAL IfcPlaneAngleMeasure;</para>
	/// <para>	CentreOfGravityInX : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : FlangeThickness < (Depth / 2.);</para>
	/// <para>	WR22 : WebThickness < FlangeWidth;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcUShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcPositiveLengthMeasure? FilletRadius { get; set; }
		public IfcPositiveLengthMeasure? EdgeRadius { get; set; }
		public IfcPlaneAngleMeasure? FlangeSlope { get; set; }
		public IfcPositiveLengthMeasure? CentreOfGravityInX { get; set; }
		public IfcUShapeProfileDef() : base()
		{
			Depth = new IfcPositiveLengthMeasure();
			FlangeWidth = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			FlangeThickness = new IfcPositiveLengthMeasure();
		}
		public IfcUShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcPositiveLengthMeasure FilletRadius, IfcPositiveLengthMeasure EdgeRadius, IfcPlaneAngleMeasure FlangeSlope, IfcPositiveLengthMeasure CentreOfGravityInX) : base (ProfileType, ProfileName, Position)
		{
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
			this.FlangeSlope = FlangeSlope;
			this.CentreOfGravityInX = CentreOfGravityInX;
		}
	}
	/// <summary>
	/// ENTITY IfcUnitAssignment;
	/// <para>ENTITY IfcUnitAssignment;</para>
	/// <para>	Units : SET [1:?] OF IfcUnit;</para>
	/// <para> WHERE</para>
	/// <para>	WR01 : IfcCorrectUnitAssignment(Units);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcUnitAssignmentENTITY
	{
		public List<IfcUnit> Units { get; set; }
		public IfcUnitAssignment() : base()
		{
			Units = new List<IfcUnit>();
		}
		public IfcUnitAssignment(List<IfcUnit> Units) : base ()
		{
			this.Units = Units;
		}
	}
	/// <summary>
	/// ENTITY IfcUnitaryEquipmentType
	/// <para>ENTITY IfcUnitaryEquipmentType</para>
	/// <para> SUBTYPE OF (IfcEnergyConversionDeviceType);</para>
	/// <para>	PredefinedType : IfcUnitaryEquipmentTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcUnitaryEquipmentTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcUnitaryEquipmentTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcUnitaryEquipmentType : IfcEnergyConversionDeviceType
	{
		public IfcUnitaryEquipmentTypeEnum PredefinedType { get; set; }
		public IfcUnitaryEquipmentType() : base()
		{
			PredefinedType = new IfcUnitaryEquipmentTypeEnum();
		}
		public IfcUnitaryEquipmentType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcUnitaryEquipmentTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcValveType
	/// <para>ENTITY IfcValveType</para>
	/// <para> SUBTYPE OF (IfcFlowControllerType);</para>
	/// <para>	PredefinedType : IfcValveTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcValveTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcValveTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcValveType : IfcFlowControllerType
	{
		public IfcValveTypeEnum PredefinedType { get; set; }
		public IfcValveType() : base()
		{
			PredefinedType = new IfcValveTypeEnum();
		}
		public IfcValveType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcValveTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcVector
	/// <para>ENTITY IfcVector</para>
	/// <para> SUBTYPE OF (IfcGeometricRepresentationItem);</para>
	/// <para>	Orientation : IfcDirection;</para>
	/// <para>	Magnitude : IfcLengthMeasure;</para>
	/// <para> DERIVE</para>
	/// <para>	Dim : IfcDimensionCount := Orientation.Dim;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : Magnitude >= 0.0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVector : IfcGeometricRepresentationItem, IfcVectorOrDirection
	{
		public IfcDirection Orientation { get; set; }
		public IfcLengthMeasure Magnitude { get; set; }
		public IfcVector() : base()
		{
			Orientation = new IfcDirection();
			Magnitude = new IfcLengthMeasure();
		}
		public IfcVector(IfcDirection Orientation, IfcLengthMeasure Magnitude) : base ()
		{
			this.Orientation = Orientation;
			this.Magnitude = Magnitude;
		}
	}
	/// <summary>
	/// ENTITY IfcVertex
	/// <para>ENTITY IfcVertex</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcVertexPoint))</para>
	/// <para> SUBTYPE OF (IfcTopologicalRepresentationItem);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVertex : IfcTopologicalRepresentationItem
	{
		public IfcVertex() : base()
		{
		}
		public IfcVertex() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcVertexBasedTextureMap;
	/// <para>ENTITY IfcVertexBasedTextureMap;</para>
	/// <para>	TextureVertices : LIST [3:?] OF IfcTextureVertex;</para>
	/// <para>	TexturePoints : LIST [3:?] OF IfcCartesianPoint;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVertexBasedTextureMapENTITY
	{
		public List<IfcTextureVertex> TextureVertices { get; set; }
		public List<IfcCartesianPoint> TexturePoints { get; set; }
		public IfcVertexBasedTextureMap() : base()
		{
			TextureVertices = new List<IfcTextureVertex>();
			TexturePoints = new List<IfcCartesianPoint>();
		}
		public IfcVertexBasedTextureMap(List<IfcTextureVertex> TextureVertices, List<IfcCartesianPoint> TexturePoints) : base ()
		{
			this.TextureVertices = TextureVertices;
			this.TexturePoints = TexturePoints;
		}
	}
	/// <summary>
	/// ENTITY IfcVertexLoop
	/// <para>ENTITY IfcVertexLoop</para>
	/// <para> SUBTYPE OF (IfcLoop);</para>
	/// <para>	LoopVertex : IfcVertex;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVertexLoop : IfcLoop
	{
		public IfcVertex LoopVertex { get; set; }
		public IfcVertexLoop() : base()
		{
			LoopVertex = new IfcVertex();
		}
		public IfcVertexLoop(IfcVertex LoopVertex) : base ()
		{
			this.LoopVertex = LoopVertex;
		}
	}
	/// <summary>
	/// ENTITY IfcVertexPoint
	/// <para>ENTITY IfcVertexPoint</para>
	/// <para> SUBTYPE OF (IfcVertex);</para>
	/// <para>	VertexGeometry : IfcPoint;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVertexPoint : IfcVertex, IfcPointOrVertexPoint
	{
		public IfcPoint VertexGeometry { get; set; }
		public IfcVertexPoint() : base()
		{
			VertexGeometry = new IfcPoint();
		}
		public IfcVertexPoint(IfcPoint VertexGeometry) : base ()
		{
			this.VertexGeometry = VertexGeometry;
		}
	}
	/// <summary>
	/// ENTITY IfcVibrationIsolatorType
	/// <para>ENTITY IfcVibrationIsolatorType</para>
	/// <para> SUBTYPE OF (IfcDiscreteAccessoryType);</para>
	/// <para>	PredefinedType : IfcVibrationIsolatorTypeEnum;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (PredefinedType <> IfcVibrationIsolatorTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((PredefinedType = IfcVibrationIsolatorTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVibrationIsolatorType : IfcDiscreteAccessoryType
	{
		public IfcVibrationIsolatorTypeEnum PredefinedType { get; set; }
		public IfcVibrationIsolatorType() : base()
		{
			PredefinedType = new IfcVibrationIsolatorTypeEnum();
		}
		public IfcVibrationIsolatorType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcVibrationIsolatorTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcVirtualElement
	/// <para>ENTITY IfcVirtualElement</para>
	/// <para> SUBTYPE OF (IfcElement);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVirtualElement : IfcElement
	{
		public IfcVirtualElement() : base()
		{
		}
		public IfcVirtualElement(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcVirtualGridIntersection;
	/// <para>ENTITY IfcVirtualGridIntersection;</para>
	/// <para>	IntersectingAxes : LIST [2:2] OF UNIQUE IfcGridAxis;</para>
	/// <para>	OffsetDistances : LIST [2:3] OF IfcLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcVirtualGridIntersectionENTITY
	{
		public IfcVirtualGridIntersection() : base()
		{
		}
		public IfcVirtualGridIntersection() : base ()
		{
		}
	}
	/// <summary>
	/// ENTITY IfcWall
	/// <para>ENTITY IfcWall</para>
	/// <para> SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcWallStandardCase))</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF (QUERY(temp <* SELF\IfcObjectDefinition.HasAssociations |</para>
	/// <para>              'IFC2X3.IFCRELASSOCIATESMATERIAL' IN TYPEOF(temp)</para>
	/// <para>              )) <= 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWall : IfcBuildingElement
	{
		public IfcWall() : base()
		{
		}
		public IfcWall(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcWallStandardCase
	/// <para>ENTITY IfcWallStandardCase</para>
	/// <para> SUBTYPE OF (IfcWall);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF (QUERY(temp <* USEDIN(SELF, 'IFC2X3.IFCRELASSOCIATES.RELATEDOBJECTS') |</para>
	/// <para>                          ('IFC2X3.IFCRELASSOCIATESMATERIAL' IN TYPEOF(temp)) AND</para>
	/// <para>                          ('IFC2X3.IFCMATERIALLAYERSETUSAGE' IN TYPEOF(temp.RelatingMaterial))</para>
	/// <para>                          )) = 1;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWallStandardCase : IfcWall
	{
		public IfcWallStandardCase() : base()
		{
		}
		public IfcWallStandardCase(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcWallType
	/// <para>ENTITY IfcWallType</para>
	/// <para> SUBTYPE OF (IfcBuildingElementType);</para>
	/// <para>	PredefinedType : IfcWallTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWallType : IfcBuildingElementType
	{
		public IfcWallTypeEnum PredefinedType { get; set; }
		public IfcWallType() : base()
		{
			PredefinedType = new IfcWallTypeEnum();
		}
		public IfcWallType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcWallTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcWasteTerminalType
	/// <para>ENTITY IfcWasteTerminalType</para>
	/// <para> SUBTYPE OF (IfcFlowTerminalType);</para>
	/// <para>	PredefinedType : IfcWasteTerminalTypeEnum;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWasteTerminalType : IfcFlowTerminalType
	{
		public IfcWasteTerminalTypeEnum PredefinedType { get; set; }
		public IfcWasteTerminalType() : base()
		{
			PredefinedType = new IfcWasteTerminalTypeEnum();
		}
		public IfcWasteTerminalType(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcLabel ElementType, IfcWasteTerminalTypeEnum PredefinedType) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets, ElementType)
		{
			this.PredefinedType = PredefinedType;
		}
	}
	/// <summary>
	/// ENTITY IfcWaterProperties
	/// <para>ENTITY IfcWaterProperties</para>
	/// <para> SUBTYPE OF (IfcMaterialProperties);</para>
	/// <para>	IsPotable : OPTIONAL BOOLEAN;</para>
	/// <para>	Hardness : OPTIONAL IfcIonConcentrationMeasure;</para>
	/// <para>	AlkalinityConcentration : OPTIONAL IfcIonConcentrationMeasure;</para>
	/// <para>	AcidityConcentration : OPTIONAL IfcIonConcentrationMeasure;</para>
	/// <para>	ImpuritiesContent : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	PHLevel : OPTIONAL IfcPHMeasure;</para>
	/// <para>	DissolvedSolidsContent : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para> UNIQUE</para>
	/// <para>	UR11 : Material;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWaterProperties : IfcMaterialProperties
	{
		public BOOLEAN? IsPotable { get; set; }
		public IfcIonConcentrationMeasure? Hardness { get; set; }
		public IfcIonConcentrationMeasure? AlkalinityConcentration { get; set; }
		public IfcIonConcentrationMeasure? AcidityConcentration { get; set; }
		public IfcNormalisedRatioMeasure? ImpuritiesContent { get; set; }
		public IfcPHMeasure? PHLevel { get; set; }
		public IfcNormalisedRatioMeasure? DissolvedSolidsContent { get; set; }
		public IfcWaterProperties() : base()
		{
		}
		public IfcWaterProperties(IfcMaterial Material, BOOLEAN IsPotable, IfcIonConcentrationMeasure Hardness, IfcIonConcentrationMeasure AlkalinityConcentration, IfcIonConcentrationMeasure AcidityConcentration, IfcNormalisedRatioMeasure ImpuritiesContent, IfcPHMeasure PHLevel, IfcNormalisedRatioMeasure DissolvedSolidsContent) : base (Material)
		{
			this.IsPotable = IsPotable;
			this.Hardness = Hardness;
			this.AlkalinityConcentration = AlkalinityConcentration;
			this.AcidityConcentration = AcidityConcentration;
			this.ImpuritiesContent = ImpuritiesContent;
			this.PHLevel = PHLevel;
			this.DissolvedSolidsContent = DissolvedSolidsContent;
		}
	}
	/// <summary>
	/// ENTITY IfcWindow
	/// <para>ENTITY IfcWindow</para>
	/// <para> SUBTYPE OF (IfcBuildingElement);</para>
	/// <para>	OverallHeight : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	OverallWidth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWindow : IfcBuildingElement
	{
		public IfcPositiveLengthMeasure? OverallHeight { get; set; }
		public IfcPositiveLengthMeasure? OverallWidth { get; set; }
		public IfcWindow() : base()
		{
		}
		public IfcWindow(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcObjectPlacement ObjectPlacement, IfcProductRepresentation Representation, IfcIdentifier Tag, IfcPositiveLengthMeasure OverallHeight, IfcPositiveLengthMeasure OverallWidth) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, ObjectPlacement, Representation, Tag)
		{
			this.OverallHeight = OverallHeight;
			this.OverallWidth = OverallWidth;
		}
	}
	/// <summary>
	/// ENTITY IfcWindowLiningProperties
	/// <para>ENTITY IfcWindowLiningProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	LiningDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	LiningThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	TransomThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	MullionThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	FirstTransomOffset : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	SecondTransomOffset : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	FirstMullionOffset : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	SecondMullionOffset : OPTIONAL IfcNormalisedRatioMeasure;</para>
	/// <para>	ShapeAspectStyle : OPTIONAL IfcShapeAspect;</para>
	/// <para> WHERE</para>
	/// <para>	WR31 : NOT(NOT(EXISTS(LiningDepth)) AND EXISTS(LiningThickness));</para>
	/// <para>	WR32 : NOT(NOT(EXISTS(FirstTransomOffset)) AND EXISTS(SecondTransomOffset));</para>
	/// <para>	WR33 : NOT(NOT(EXISTS(FirstMullionOffset)) AND EXISTS(SecondMullionOffset));</para>
	/// <para>	WR34 : EXISTS(SELF\IfcPropertySetDefinition.DefinesType[1]) AND </para>
	/// <para>             ('IFC2X3.IFCWINDOWSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWindowLiningProperties : IfcPropertySetDefinition
	{
		public IfcPositiveLengthMeasure? LiningDepth { get; set; }
		public IfcPositiveLengthMeasure? LiningThickness { get; set; }
		public IfcPositiveLengthMeasure? TransomThickness { get; set; }
		public IfcPositiveLengthMeasure? MullionThickness { get; set; }
		public IfcNormalisedRatioMeasure? FirstTransomOffset { get; set; }
		public IfcNormalisedRatioMeasure? SecondTransomOffset { get; set; }
		public IfcNormalisedRatioMeasure? FirstMullionOffset { get; set; }
		public IfcNormalisedRatioMeasure? SecondMullionOffset { get; set; }
		public IfcShapeAspect? ShapeAspectStyle { get; set; }
		public IfcWindowLiningProperties() : base()
		{
		}
		public IfcWindowLiningProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcPositiveLengthMeasure LiningDepth, IfcPositiveLengthMeasure LiningThickness, IfcPositiveLengthMeasure TransomThickness, IfcPositiveLengthMeasure MullionThickness, IfcNormalisedRatioMeasure FirstTransomOffset, IfcNormalisedRatioMeasure SecondTransomOffset, IfcNormalisedRatioMeasure FirstMullionOffset, IfcNormalisedRatioMeasure SecondMullionOffset, IfcShapeAspect ShapeAspectStyle) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.LiningDepth = LiningDepth;
			this.LiningThickness = LiningThickness;
			this.TransomThickness = TransomThickness;
			this.MullionThickness = MullionThickness;
			this.FirstTransomOffset = FirstTransomOffset;
			this.SecondTransomOffset = SecondTransomOffset;
			this.FirstMullionOffset = FirstMullionOffset;
			this.SecondMullionOffset = SecondMullionOffset;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcWindowPanelProperties
	/// <para>ENTITY IfcWindowPanelProperties</para>
	/// <para> SUBTYPE OF (IfcPropertySetDefinition);</para>
	/// <para>	OperationType : IfcWindowPanelOperationEnum;</para>
	/// <para>	PanelPosition : IfcWindowPanelPositionEnum;</para>
	/// <para>	FrameDepth : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	FrameThickness : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	ShapeAspectStyle : OPTIONAL IfcShapeAspect;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWindowPanelProperties : IfcPropertySetDefinition
	{
		public IfcWindowPanelOperationEnum OperationType { get; set; }
		public IfcWindowPanelPositionEnum PanelPosition { get; set; }
		public IfcPositiveLengthMeasure? FrameDepth { get; set; }
		public IfcPositiveLengthMeasure? FrameThickness { get; set; }
		public IfcShapeAspect? ShapeAspectStyle { get; set; }
		public IfcWindowPanelProperties() : base()
		{
			OperationType = new IfcWindowPanelOperationEnum();
			PanelPosition = new IfcWindowPanelPositionEnum();
		}
		public IfcWindowPanelProperties(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcWindowPanelOperationEnum OperationType, IfcWindowPanelPositionEnum PanelPosition, IfcPositiveLengthMeasure FrameDepth, IfcPositiveLengthMeasure FrameThickness, IfcShapeAspect ShapeAspectStyle) : base (GlobalId, OwnerHistory, Name, Description)
		{
			this.OperationType = OperationType;
			this.PanelPosition = PanelPosition;
			this.FrameDepth = FrameDepth;
			this.FrameThickness = FrameThickness;
			this.ShapeAspectStyle = ShapeAspectStyle;
		}
	}
	/// <summary>
	/// ENTITY IfcWindowStyle
	/// <para>ENTITY IfcWindowStyle</para>
	/// <para> SUBTYPE OF (IfcTypeProduct);</para>
	/// <para>	ConstructionType : IfcWindowStyleConstructionEnum;</para>
	/// <para>	OperationType : IfcWindowStyleOperationEnum;</para>
	/// <para>	ParameterTakesPrecedence : BOOLEAN;</para>
	/// <para>	Sizeable : BOOLEAN;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWindowStyle : IfcTypeProduct
	{
		public IfcWindowStyleConstructionEnum ConstructionType { get; set; }
		public IfcWindowStyleOperationEnum OperationType { get; set; }
		public BOOLEAN ParameterTakesPrecedence { get; set; }
		public BOOLEAN Sizeable { get; set; }
		public IfcWindowStyle() : base()
		{
			ConstructionType = new IfcWindowStyleConstructionEnum();
			OperationType = new IfcWindowStyleOperationEnum();
			ParameterTakesPrecedence = new BOOLEAN();
			Sizeable = new BOOLEAN();
		}
		public IfcWindowStyle(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ApplicableOccurrence, List<IfcPropertySetDefinition> HasPropertySets, IfcWindowStyleConstructionEnum ConstructionType, IfcWindowStyleOperationEnum OperationType, BOOLEAN ParameterTakesPrecedence, BOOLEAN Sizeable) : base (GlobalId, OwnerHistory, Name, Description, ApplicableOccurrence, HasPropertySets)
		{
			this.ConstructionType = ConstructionType;
			this.OperationType = OperationType;
			this.ParameterTakesPrecedence = ParameterTakesPrecedence;
			this.Sizeable = Sizeable;
		}
	}
	/// <summary>
	/// ENTITY IfcWorkControl
	/// <para>ENTITY IfcWorkControl</para>
	/// <para> ABSTRACT SUPERTYPE OF (ONEOF</para>
	/// <para>	(IfcWorkPlan</para>
	/// <para>	,IfcWorkSchedule))</para>
	/// <para> SUBTYPE OF (IfcControl);</para>
	/// <para>	Identifier : IfcIdentifier;</para>
	/// <para>	CreationDate : IfcDateTimeSelect;</para>
	/// <para>	Creators : OPTIONAL SET [1:?] OF IfcPerson;</para>
	/// <para>	Purpose : OPTIONAL IfcLabel;</para>
	/// <para>	Duration : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	TotalFloat : OPTIONAL IfcTimeMeasure;</para>
	/// <para>	StartTime : IfcDateTimeSelect;</para>
	/// <para>	FinishTime : OPTIONAL IfcDateTimeSelect;</para>
	/// <para>	WorkControlType : OPTIONAL IfcWorkControlTypeEnum;</para>
	/// <para>	UserDefinedControlType : OPTIONAL IfcLabel;</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : (WorkControlType <> IfcWorkControlTypeEnum.USERDEFINED) OR</para>
	/// <para>            ((WorkControlType = IfcWorkControlTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcWorkControl.UserDefinedControlType));</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public abstract class IfcWorkControl : IfcControl
	{
		public IfcIdentifier Identifier { get; set; }
		public IfcDateTimeSelect CreationDate { get; set; }
		public List<IfcPerson>? Creators { get; set; }
		public IfcLabel? Purpose { get; set; }
		public IfcTimeMeasure? Duration { get; set; }
		public IfcTimeMeasure? TotalFloat { get; set; }
		public IfcDateTimeSelect StartTime { get; set; }
		public IfcDateTimeSelect? FinishTime { get; set; }
		public IfcWorkControlTypeEnum? WorkControlType { get; set; }
		public IfcLabel? UserDefinedControlType { get; set; }
		public IfcWorkControl() : base()
		{
			Identifier = new IfcIdentifier();
			CreationDate = new IfcDateTimeSelect();
			StartTime = new IfcDateTimeSelect();
		}
		public IfcWorkControl(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identifier, IfcDateTimeSelect CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcTimeMeasure Duration, IfcTimeMeasure TotalFloat, IfcDateTimeSelect StartTime, IfcDateTimeSelect FinishTime, IfcWorkControlTypeEnum WorkControlType, IfcLabel UserDefinedControlType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
			this.Identifier = Identifier;
			this.CreationDate = CreationDate;
			this.Creators = Creators;
			this.Purpose = Purpose;
			this.Duration = Duration;
			this.TotalFloat = TotalFloat;
			this.StartTime = StartTime;
			this.FinishTime = FinishTime;
			this.WorkControlType = WorkControlType;
			this.UserDefinedControlType = UserDefinedControlType;
		}
	}
	/// <summary>
	/// ENTITY IfcWorkPlan
	/// <para>ENTITY IfcWorkPlan</para>
	/// <para> SUBTYPE OF (IfcWorkControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWorkPlan : IfcWorkControl
	{
		public IfcWorkPlan() : base()
		{
		}
		public IfcWorkPlan(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identifier, IfcDateTimeSelect CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcTimeMeasure Duration, IfcTimeMeasure TotalFloat, IfcDateTimeSelect StartTime, IfcDateTimeSelect FinishTime, IfcWorkControlTypeEnum WorkControlType, IfcLabel UserDefinedControlType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, Identifier, CreationDate, Creators, Purpose, Duration, TotalFloat, StartTime, FinishTime, WorkControlType, UserDefinedControlType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcWorkSchedule
	/// <para>ENTITY IfcWorkSchedule</para>
	/// <para> SUBTYPE OF (IfcWorkControl);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcWorkSchedule : IfcWorkControl
	{
		public IfcWorkSchedule() : base()
		{
		}
		public IfcWorkSchedule(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType, IfcIdentifier Identifier, IfcDateTimeSelect CreationDate, List<IfcPerson> Creators, IfcLabel Purpose, IfcTimeMeasure Duration, IfcTimeMeasure TotalFloat, IfcDateTimeSelect StartTime, IfcDateTimeSelect FinishTime, IfcWorkControlTypeEnum WorkControlType, IfcLabel UserDefinedControlType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType, Identifier, CreationDate, Creators, Purpose, Duration, TotalFloat, StartTime, FinishTime, WorkControlType, UserDefinedControlType)
		{
		}
	}
	/// <summary>
	/// ENTITY IfcZShapeProfileDef
	/// <para>ENTITY IfcZShapeProfileDef</para>
	/// <para> SUBTYPE OF (IfcParameterizedProfileDef);</para>
	/// <para>	Depth : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeWidth : IfcPositiveLengthMeasure;</para>
	/// <para>	WebThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FlangeThickness : IfcPositiveLengthMeasure;</para>
	/// <para>	FilletRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para>	EdgeRadius : OPTIONAL IfcPositiveLengthMeasure;</para>
	/// <para> WHERE</para>
	/// <para>	WR21 : FlangeThickness < (Depth / 2.);</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcZShapeProfileDef : IfcParameterizedProfileDef
	{
		public IfcPositiveLengthMeasure Depth { get; set; }
		public IfcPositiveLengthMeasure FlangeWidth { get; set; }
		public IfcPositiveLengthMeasure WebThickness { get; set; }
		public IfcPositiveLengthMeasure FlangeThickness { get; set; }
		public IfcPositiveLengthMeasure? FilletRadius { get; set; }
		public IfcPositiveLengthMeasure? EdgeRadius { get; set; }
		public IfcZShapeProfileDef() : base()
		{
			Depth = new IfcPositiveLengthMeasure();
			FlangeWidth = new IfcPositiveLengthMeasure();
			WebThickness = new IfcPositiveLengthMeasure();
			FlangeThickness = new IfcPositiveLengthMeasure();
		}
		public IfcZShapeProfileDef(IfcProfileTypeEnum ProfileType, IfcLabel ProfileName, IfcAxis2Placement2D Position, IfcPositiveLengthMeasure Depth, IfcPositiveLengthMeasure FlangeWidth, IfcPositiveLengthMeasure WebThickness, IfcPositiveLengthMeasure FlangeThickness, IfcPositiveLengthMeasure FilletRadius, IfcPositiveLengthMeasure EdgeRadius) : base (ProfileType, ProfileName, Position)
		{
			this.Depth = Depth;
			this.FlangeWidth = FlangeWidth;
			this.WebThickness = WebThickness;
			this.FlangeThickness = FlangeThickness;
			this.FilletRadius = FilletRadius;
			this.EdgeRadius = EdgeRadius;
		}
	}
	/// <summary>
	/// ENTITY IfcZone
	/// <para>ENTITY IfcZone</para>
	/// <para> SUBTYPE OF (IfcGroup);</para>
	/// <para> WHERE</para>
	/// <para>	WR1 : SIZEOF (QUERY (temp <* SELF\IfcGroup.IsGroupedBy.RelatedObjects |  NOT(('IFC2X3.IFCZONE' IN TYPEOF(temp)) OR ('IFC2X3.IFCSPACE' IN TYPEOF(temp))) )) = 0;</para>
	/// <para>END_ENTITY;</para>
	/// <summary>
	public class IfcZone : IfcGroup
	{
		public IfcZone() : base()
		{
		}
		public IfcZone(IfcGloballyUniqueId GlobalId, IfcOwnerHistory OwnerHistory, IfcLabel Name, IfcText Description, IfcLabel ObjectType) : base (GlobalId, OwnerHistory, Name, Description, ObjectType)
		{
		}
	}
