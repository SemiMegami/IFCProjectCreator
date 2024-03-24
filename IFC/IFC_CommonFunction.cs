using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CSiBKK.IFC.Global;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
    public class IFC_CommonFunction
    {
        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix4x4 GetMatrix4x4(Vector3 coordinates, List<Vector3> directions)
        {

            var mat = new Matrix4x4()
            {
                M11 = directions[0][0],
                M12 = directions[0][1],
                M13 = directions[0][2],
                M21 = directions[1][0],
                M22 = directions[1][1],
                M23 = directions[1][2],
                M31 = directions[2][0],
                M32 = directions[2][1],
                M33 = directions[2][2],
                M41 = coordinates.X,
                M42 = coordinates.Y,
                M43 = coordinates.Z,
                M44 = 1,
            };

            return mat;
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix3x2 GetMatrix3x2(Vector2 coordinate, List<Vector2> directions)
        {
            var mat = new Matrix3x2()
            {
                M11 = directions[0][0],
                M12 = directions[0][1],
                M21 = directions[1][0],
                M22 = directions[1][1],
                M31 = coordinate.X,
                M32 = coordinate.Y,

            };

            return mat;
        }

        #region ---- IFCObjectPlacement ----

        public static Matrix4x4 GetMatrix4x4(IFCObjectPlacement IFCObjectPlacement)
        {
            if (IFCObjectPlacement == null)
            {
                return Matrix4x4.Identity;
            }
            if (IFCObjectPlacement is IFC2x3.IFCLocalPlacement placement2x3)
            {
                if(placement2x3._RelativePlacement != null)
                {
                    return GetMatrix4x4((IFCAxis2Placement3D)placement2x3._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4.IFCLocalPlacement placement4)
            {
                if (placement4._RelativePlacement != null)
                {
                    return GetMatrix4x4((IFCAxis2Placement3D)placement4._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x1.IFCLocalPlacement placement4x1)
            {
                if (placement4x1._RelativePlacement != null)
                {
                    return GetMatrix4x4((IFCAxis2Placement3D)placement4x1._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x2.IFCLocalPlacement placement4x2)
            {
                if (placement4x2._RelativePlacement != null)
                {
                    return GetMatrix4x4((IFCAxis2Placement3D)placement4x2._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x3.IFCLocalPlacement placement4x3)
            {
                if (placement4x3._RelativePlacement != null)
                {
                    return GetMatrix4x4((IFCAxis2Placement3D)placement4x3._RelativePlacement);
                }
            }
            return Matrix4x4.Identity;
        }

        public static Matrix4x4 GetGlobalMatrix4x4(IFCObjectPlacement IFCObjectPlacement)
        {
            if (IFCObjectPlacement == null)
            {
                return Matrix4x4.Identity;
            }
            var parentMat = Matrix4x4.Identity;
           
            if (IFCObjectPlacement is IFC2x3.IFCLocalPlacement placement2x3)
            {
                if (placement2x3._PlacementRelTo != null)
                {
                    parentMat = GetGlobalMatrix4x4(placement2x3._PlacementRelTo);
                }
            }
            if (IFCObjectPlacement is IFC4.IFCLocalPlacement placement4)
            {
                if (placement4._PlacementRelTo != null)
                {

                    parentMat = GetGlobalMatrix4x4(placement4._PlacementRelTo);
                }
            }
            if (IFCObjectPlacement is IFC4x1.IFCLocalPlacement placement4x1)
            {
                if (placement4x1._PlacementRelTo != null)
                {
                    parentMat = GetGlobalMatrix4x4(placement4x1._PlacementRelTo);
                }
            }
            if (IFCObjectPlacement is IFC4x2.IFCLocalPlacement placement4x2)
            {
                if (placement4x2._PlacementRelTo != null)
                {
                    parentMat = GetGlobalMatrix4x4(placement4x2._PlacementRelTo);
                }
            }
            if (IFCObjectPlacement is IFC4x3.IFCLocalPlacement placement4x3)
            {
                if (placement4x3._PlacementRelTo != null)
                {
                    parentMat = GetGlobalMatrix4x4(placement4x3._PlacementRelTo);
                }
            }
            return  GetMatrix4x4(IFCObjectPlacement) * parentMat;
        }

            public static Matrix3x2 GetMatrix3x2(IFCObjectPlacement IFCObjectPlacement)
        {
            if (IFCObjectPlacement == null)
            {
                return Matrix3x2.Identity;
            }
            if (IFCObjectPlacement is IFC2x3.IFCLocalPlacement placement2x3)
            {
                if (placement2x3._RelativePlacement != null)
                {
                    return GetMatrix3x2((IFCAxis2Placement2D)placement2x3._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4.IFCLocalPlacement placement4)
            {
                if (placement4._RelativePlacement != null)
                {
                    return GetMatrix3x2((IFCAxis2Placement2D)placement4._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x1.IFCLocalPlacement placement4x1)
            {
                if (placement4x1._RelativePlacement != null)
                {
                    return GetMatrix3x2((IFCAxis2Placement2D)placement4x1._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x2.IFCLocalPlacement placement4x2)
            {
                if(placement4x2._RelativePlacement != null)
                {
                    return GetMatrix3x2((IFCAxis2Placement2D)placement4x2._RelativePlacement);
                }
            }
            if (IFCObjectPlacement is IFC4x3.IFCLocalPlacement placement4x3)
            {
                if (placement4x3._RelativePlacement != null)
                {
                    return GetMatrix3x2((IFCAxis2Placement2D)placement4x3._RelativePlacement);
                }
            }
            return Matrix3x2.Identity;
        }

        #endregion

        #region ---- IFCAxis2Placement ----

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix4x4 GetMatrix4x4(IFCAxis2Placement3D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return Matrix4x4.Identity;
            }
            return GetMatrix4x4(GetCoordinate3D(IFCAxis2Placement), GetDirection3Ds(IFCAxis2Placement));
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix4x4 GetGlobalMatrix4x4(IFCAxis2Placement3D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return Matrix4x4.Identity;
            }
            return GetMatrix4x4(GetCoordinate3D(IFCAxis2Placement), GetDirection3Ds(IFCAxis2Placement));
        }



        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static List<Vector3> GetDirection3Ds(IFCAxis2Placement3D IFCAxis2Placement)
        {
            List<Vector3> directions = new List<Vector3>();
            if (IFCAxis2Placement == null)
            {
                directions.Add(new Vector3(1, 0, 0));
                directions.Add(new Vector3(0, 1, 0));
                directions.Add(new Vector3(0, 0, 1));
                return directions;
            }
            if (IFCAxis2Placement is IFC2x3.IFCAxis2Placement3D IFC2x3Axis2Placement)
            {
                var P = IFC2x3Axis2Placement.P;
                if(P!= null)
                {
                    directions.Add(GetVector3(P[0]));
                    directions.Add(GetVector3(P[1]));
                    directions.Add(GetVector3(P[2]));
                }  
            }
            else if (IFCAxis2Placement is IFC4.IFCAxis2Placement3D IFC4Axis2Placement)
            {
                var P = IFC4Axis2Placement.P;  
                if (P != null)
                {
                    directions.Add(GetVector3(P[0]));
                    directions.Add(GetVector3(P[1]));
                    directions.Add(GetVector3(P[2]));
                }
                
            }
            else if (IFCAxis2Placement is IFC4x1.IFCAxis2Placement3D IFC4x1Axis2Placement)
            {
                var P = IFC4x1Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector3(P[0]));
                    directions.Add(GetVector3(P[1]));
                    directions.Add(GetVector3(P[2]));
                }
            }
            else if (IFCAxis2Placement is IFC4x2.IFCAxis2Placement3D IFC4x2Axis2Placement)
            {
                var P = IFC4x2Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector3(P[0]));
                    directions.Add(GetVector3(P[1]));
                    directions.Add(GetVector3(P[2]));
                }
            }
            else if (IFCAxis2Placement is IFC4x3.IFCAxis2Placement3D IFC4x3Axis2Placement)
            {
                var P = IFC4x3Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector3(P[0]));
                    directions.Add(GetVector3(P[1]));
                    directions.Add(GetVector3(P[2]));
                }
            }
            else
            {
                directions.Add(new Vector3(1, 0, 0));
                directions.Add(new Vector3(0, 1, 0));
                directions.Add(new Vector3(0, 0, 1));
            }
            return directions;
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Vector3 GetCoordinate3D(IFCAxis2Placement3D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                new Vector3();
            }
            List<double> coordinates = new List<double>();
            if (IFCAxis2Placement is IFC2x3.IFCAxis2Placement3D IFC2x3Axis2Placement)
            {
                if(IFC2x3Axis2Placement.Location != null && IFC2x3Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC2x3Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                    coordinates.Add(placementCoordinates[2]);
                }
               
            }
            else if (IFCAxis2Placement is IFC4.IFCAxis2Placement3D IFC4Axis2Placement)
            {
                if (IFC4Axis2Placement.Location != null && IFC4Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                    coordinates.Add(placementCoordinates[2]);
                }
            }
            else if (IFCAxis2Placement is IFC4x1.IFCAxis2Placement3D IFC4x1Axis2Placement)
            {
                if (IFC4x1Axis2Placement.Location != null && IFC4x1Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4x1Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                    coordinates.Add(placementCoordinates[2]);
                }
            }
            else if (IFCAxis2Placement is IFC4x2.IFCAxis2Placement3D IFC4x2Axis2Placement)
            {
                if (IFC4x2Axis2Placement.Location != null && IFC4x2Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4x2Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                    coordinates.Add(placementCoordinates[2]);
                }
            }
            else if (IFCAxis2Placement is IFC4x3.IFCAxis2Placement3D IFC4x3Axis2Placement)
            {
                var point = IFC4x3Axis2Placement.Location;
                if (point is IFC4x3.IFCCartesianPoint cartesianPoint)
                {
                    if(cartesianPoint.Coordinates != null)
                    {
                        coordinates.Add(cartesianPoint.Coordinates[0]);
                        coordinates.Add(cartesianPoint.Coordinates[1]);
                        coordinates.Add(cartesianPoint.Coordinates[2]);
                    }
                }
                else
                {
                    coordinates.Add(0);
                    coordinates.Add(0);
                    coordinates.Add(0);
                }
            }
            else
            {
                coordinates.Add(0);
                coordinates.Add(0);
                coordinates.Add(0);
            }
            return new Vector3((float)coordinates[0], (float)coordinates[1], (float)coordinates[2]);
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix3x2 GetMatrix3x2(IFCAxis2Placement2D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return Matrix3x2.Identity;
            }
            return GetMatrix3x2(GetCoordinate2D(IFCAxis2Placement), GetDirection2Ds(IFCAxis2Placement));
        }

        /// <summary>
        /// Get the GetCoordinate2D from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Vector2 GetCoordinate2D(IFCAxis2Placement IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return new Vector2();
            }
            if (IFCAxis2Placement is IFCAxis2Placement2D IFCAxis2Placement2D) return GetCoordinate2D(IFCAxis2Placement2D);
            return new Vector2();
        }

        /// <summary>
        /// Get the GetCoordinate2D from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Vector2 GetCoordinate2D(IFCAxis2Placement2D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return new Vector2();
            }
            List<double> coordinates = new List<double>();
            if (IFCAxis2Placement is IFC2x3.IFCAxis2Placement2D IFC2x3Axis2Placement)
            {
                if (IFC2x3Axis2Placement.Location != null && IFC2x3Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC2x3Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                }

            }
            else if (IFCAxis2Placement is IFC4.IFCAxis2Placement2D IFC4Axis2Placement)
            {
                if (IFC4Axis2Placement.Location != null && IFC4Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                }
            }
            else if (IFCAxis2Placement is IFC4x1.IFCAxis2Placement2D IFC4x1Axis2Placement)
            {
                if (IFC4x1Axis2Placement.Location != null && IFC4x1Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4x1Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                }
            }
            else if (IFCAxis2Placement is IFC4x2.IFCAxis2Placement2D IFC4x2Axis2Placement)
            {
                if (IFC4x2Axis2Placement.Location != null && IFC4x2Axis2Placement.Location.Coordinates != null)
                {
                    var placementCoordinates = IFC4x2Axis2Placement.Location.Coordinates;
                    coordinates.Add(placementCoordinates[0]);
                    coordinates.Add(placementCoordinates[1]);
                }
            }
            else if (IFCAxis2Placement is IFC4x3.IFCAxis2Placement2D IFC4x3Axis2Placement)
            {
                if(IFC4x3Axis2Placement.Location != null)
                {
                    IFC4x3.IFCPoint point = IFC4x3Axis2Placement.Location;
                    if (point is IFC4x3.IFCCartesianPoint cartesianPoint)
                    {
                        if(cartesianPoint.Coordinates != null)
                        {
                            coordinates.Add(cartesianPoint.Coordinates[0]);
                            coordinates.Add(cartesianPoint.Coordinates[1]);
                        }
                    }
                    else
                    {
                        coordinates.Add(0);
                        coordinates.Add(0);
                    }
                }
            }
            else
            {
                coordinates.Add(0);
                coordinates.Add(0);
            }
            return new Vector2((float)coordinates[0], (float)coordinates[1]);
        }




        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static List<Vector2> GetDirection2Ds(IFCAxis2Placement2D IFCAxis2Placement)
        {
            if (IFCAxis2Placement == null)
            {
                return new List<Vector2>() { new Vector2(1, 0), new Vector2(0, 1) };
            }
            List<Vector2> directions = new List<Vector2>();
            if (IFCAxis2Placement is IFC2x3.IFCAxis2Placement2D IFC2x3Axis2Placement)
            {
                var P = IFC2x3Axis2Placement.P;
                if(P != null)
                {
                    directions.Add(GetVector2(P[0]));
                    directions.Add(GetVector2(P[1]));
                }
            }
            else if (IFCAxis2Placement is IFC4.IFCAxis2Placement2D IFC4Axis2Placement)
            {
                var P = IFC4Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector2(P[0]));
                    directions.Add(GetVector2(P[1]));
                }
            }
            else if (IFCAxis2Placement is IFC4x1.IFCAxis2Placement2D IFC4x1Axis2Placement)
            {
                var P = IFC4x1Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector2(P[0]));
                    directions.Add(GetVector2(P[1]));
                }
            }
            else if (IFCAxis2Placement is IFC4x2.IFCAxis2Placement2D IFC4x2Axis2Placement)
            {
                var P = IFC4x2Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector2(P[0]));
                    directions.Add(GetVector2(P[1]));
                }
            }
            else if (IFCAxis2Placement is IFC4x3.IFCAxis2Placement2D IFC4x3Axis2Placement)
            {
                var P = IFC4x3Axis2Placement.P;
                if (P != null)
                {
                    directions.Add(GetVector2(P[0]));
                    directions.Add(GetVector2(P[1]));
                }
            }
            else
            {
                directions.Add(new Vector2(1, 0));
                directions.Add(new Vector2(0, 1));
            }
            return directions;
        }

        #endregion

        #region ---- IFCCartesianTransformationOperator ----
        /// <summary>
        /// Get the GetCoordinate2D from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Vector2 GetCoordinate2D(IFCCartesianTransformationOperator2D IFCCartesianTransformationOperator2D)
        {
            if(IFCCartesianTransformationOperator2D != null && IFCCartesianTransformationOperator2D._LocalOrigin != null)
            {
                return GetVector2(IFCCartesianTransformationOperator2D._LocalOrigin);
            }
            return new Vector2();
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static List<Vector2> GetDirection2Ds(IFCCartesianTransformationOperator2D IFCCartesianTransformationOperator2D)
        {

            if (IFCCartesianTransformationOperator2D == null)
            {
                return new List<Vector2>() { new Vector2(1, 0), new Vector2(0, 1) };
            }
            List<Vector2> directions = new List<Vector2>();
            if (IFCCartesianTransformationOperator2D._Axis1 != null)
            {
                directions.Add(GetVector2(IFCCartesianTransformationOperator2D._Axis1));
            }
            else
            {
                directions.Add(new Vector2(1, 0));
            }
            if (IFCCartesianTransformationOperator2D._Axis2 != null)
            {
                directions.Add(GetVector2(IFCCartesianTransformationOperator2D._Axis2));
            }
            else
            {
                directions.Add(new Vector2(0, 1));
            }

            return directions;
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix3x2 GetMatrix3x2(IFCCartesianTransformationOperator2D IFCCartesianTransformationOperator2D)
        {
            if (IFCCartesianTransformationOperator2D == null)
            {
                return Matrix3x2.Identity;
            }
            return GetMatrix3x2(GetCoordinate2D(IFCCartesianTransformationOperator2D), GetDirection2Ds(IFCCartesianTransformationOperator2D));
        }


        /// <summary>
        /// Get the GetCoordinate2D from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Vector3 GetCoordinate3D(IFCCartesianTransformationOperator3D IFCCartesianTransformationOperator2D)
        {
            if (IFCCartesianTransformationOperator2D != null && IFCCartesianTransformationOperator2D._LocalOrigin != null)
            {
                return GetVector3(IFCCartesianTransformationOperator2D._LocalOrigin);
            }
            return new Vector3();
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static List<Vector3> GetDirection3Ds(IFCCartesianTransformationOperator3D IFCCartesianTransformationOperator2D)
        {
            var U = IFCCartesianTransformationOperator2D._U;
            if (IFCCartesianTransformationOperator2D == null)
            {
                return new List<Vector3>() { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };
            }
            if(U != null && U.Count == 3)
            {
                List<Vector3> directions = new List<Vector3>();
                if (U[0] != null)
                {
                    directions.Add(GetVector3(U[0]));
                }
                else
                {
                    directions.Add(new Vector3(1, 0, 0));
                }
                if (U[1] != null)
                {
                    directions.Add(GetVector3(U[1]));
                }
                else
                {
                    directions.Add(new Vector3(0, 1, 0));
                }
                if (U[2] != null)
                {
                    directions.Add(GetVector3(U[2]));
                }
                else
                {
                    directions.Add(new Vector3(0, 0, 1));
                }
                return directions;
            }
            return new List<Vector3>() { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };
        }

        /// <summary>
        /// Get the transform matrix from IFC
        /// </summary>
        /// <param name="IFCAxis2Placement"></param>
        /// <returns></returns>
        public static Matrix4x4 GetMatrix4x4(IFCCartesianTransformationOperator3D IFCCartesianTransformationOperator3D)
        {
            if (IFCCartesianTransformationOperator3D == null)
            {
                return Matrix4x4.Identity;
            }
            return GetMatrix4x4(GetCoordinate3D(IFCCartesianTransformationOperator3D), GetDirection3Ds(IFCCartesianTransformationOperator3D));
        }

        #endregion

        #region---- IFCDirection ----

        /// <summary>
        /// Get the vector matrix from IFC
        /// </summary>
        /// <param name="IFCDirection"></param>
        /// <returns></returns>
        public static Vector2 GetVector2(IFCDirection IFCDirection)
        {
            if (IFCDirection == null)
            {
                return new Vector2();
            }
            if (IFCDirection is IFC2x3.IFCDirection IFC2x3Direction)
            {
                if(IFC2x3Direction.DirectionRatios != null)
                {
                    List<REAL> DirectionRatios = IFC2x3Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector2();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector2((float)DirectionRatios[0], 0);
                        case 2: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                        case 3: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                    }
                }
               
            }
            else if (IFCDirection is IFC4.IFCDirection IFC4Direction)
            {
                if (IFC4Direction.DirectionRatios != null)
                {
                    List<IFC4.IFCReal> DirectionRatios = IFC4Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector2();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector2((float)DirectionRatios[0], 0);
                        case 2: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                        case 3: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                    }
                }
            }
            else if (IFCDirection is IFC4x1.IFCDirection IFC4x1Direction)
            {
                if (IFC4x1Direction.DirectionRatios != null)
                {
                    List<IFC4x1.IFCReal> DirectionRatios = IFC4x1Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector2();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector2((float)DirectionRatios[0], 0);
                        case 2: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                        case 3: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                    }
                }
            }
            else if (IFCDirection is IFC4x2.IFCDirection IFC4x2Direction)
            {
                if (IFC4x2Direction.DirectionRatios != null)
                {
                    List<IFC4x2.IFCReal> DirectionRatios = IFC4x2Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector2();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector2((float)DirectionRatios[0], 0);
                        case 2: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                        case 3: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                    }
                }
            }
            else if (IFCDirection is IFC4x3.IFCDirection IFC4x3Direction)
            {
                if (IFC4x3Direction.DirectionRatios != null)
                {
                    List<IFC4x3.IFCReal> DirectionRatios = IFC4x3Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector2();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector2((float)DirectionRatios[0], 0);
                        case 2: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                        case 3: return new Vector2((float)DirectionRatios[0], (float)DirectionRatios[1]);
                    }
                }
            }
            return new Vector2();
        }

        /// <summary>
        /// Get the vector matrix from IFC
        /// </summary>
        /// <param name="IFCDirection"></param>
        /// <returns></returns>
        public static Vector3 GetVector3(IFCDirection IFCDirection)
        {
            if (IFCDirection == null)
            {
                return new Vector3();
            }
            if (IFCDirection is IFC2x3.IFCDirection IFC2x3Direction)
            {
                if(IFC2x3Direction.DirectionRatios != null)
                {
                    List<REAL> DirectionRatios = IFC2x3Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector3();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector3((float)DirectionRatios[0], 0, 0);
                        case 2: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], 0);
                        case 3: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], (float)DirectionRatios[2]);
                    }
                }
            }
            else if (IFCDirection is IFC4.IFCDirection IFC4Direction)
            {
                if (IFC4Direction.DirectionRatios != null)
                {
                    List<IFC4.IFCReal> DirectionRatios = IFC4Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector3();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector3((float)DirectionRatios[0], 0, 0);
                        case 2: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], 0);
                        case 3: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], (float)DirectionRatios[2]);
                    }
                }
            }
            else if (IFCDirection is IFC4x1.IFCDirection IFC4x1Direction)
            {
                if (IFC4x1Direction.DirectionRatios != null)
                {
                    List<IFC4x1.IFCReal> DirectionRatios = IFC4x1Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector3();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector3((float)DirectionRatios[0], 0, 0);
                        case 2: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], 0);
                        case 3: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], (float)DirectionRatios[2]);
                    }
                }
            }
            else if (IFCDirection is IFC4x2.IFCDirection IFC4x2Direction)
            {
                if (IFC4x2Direction.DirectionRatios != null)
                {
                    List<IFC4x2.IFCReal> DirectionRatios = IFC4x2Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector3();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector3((float)DirectionRatios[0], 0, 0);
                        case 2: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], 0);
                        case 3: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], (float)DirectionRatios[2]);
                    }
                }
            }
            else if (IFCDirection is IFC4x3.IFCDirection IFC4x3Direction)
            {
                if (IFC4x3Direction.DirectionRatios != null)
                {
                    List<IFC4x3.IFCReal> DirectionRatios = IFC4x3Direction.DirectionRatios;
                    if (DirectionRatios == null)
                    {
                        return new Vector3();
                    }
                    switch (DirectionRatios.Count)
                    {
                        case 1: return new Vector3((float)DirectionRatios[0], 0, 0);
                        case 2: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], 0);
                        case 3: return new Vector3((float)DirectionRatios[0], (float)DirectionRatios[1], (float)DirectionRatios[2]);
                    }
                }
            }
            return new Vector3();
        }


        #endregion

        #region---- IFCCartesianPoint ----
        /// <summary>
        /// Get Vector3 for input IFCCartesianPoint
        /// </summary>
        /// <param name="cartesianPoint"></param>
        /// <returns></returns>
        public static Vector2 GetVector2(IFCCartesianPoint cartesianPoint)
        {
            if (cartesianPoint == null)
            {
                return new Vector2();
            }

            if (cartesianPoint is IFC2x3.IFCCartesianPoint IFC2x3cartesianPoint)
            {
                if (IFC2x3cartesianPoint.Coordinates != null)
                {
                    switch (IFC2x3cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector2((float)IFC2x3cartesianPoint.Coordinates[0], 0);
                        case 2: return new Vector2((float)IFC2x3cartesianPoint.Coordinates[0], (float)IFC2x3cartesianPoint.Coordinates[1]);
                        case 3: return new Vector2((float)IFC2x3cartesianPoint.Coordinates[0], (float)IFC2x3cartesianPoint.Coordinates[1]);
                    }
                }
            }
            if (cartesianPoint is IFC4.IFCCartesianPoint IFC4cartesianPoint)
            {
                if (IFC4cartesianPoint.Coordinates != null)
                {
                    switch (IFC4cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector2((float)IFC4cartesianPoint.Coordinates[0], 0);
                        case 2: return new Vector2((float)IFC4cartesianPoint.Coordinates[0], (float)IFC4cartesianPoint.Coordinates[1]);
                        case 3: return new Vector2((float)IFC4cartesianPoint.Coordinates[0], (float)IFC4cartesianPoint.Coordinates[1]);
                    }
                }
            }
            if (cartesianPoint is IFC4x1.IFCCartesianPoint IFC4x1cartesianPoint)
            {
                if (IFC4x1cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x1cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector2((float)IFC4x1cartesianPoint.Coordinates[0], 0);
                        case 2: return new Vector2((float)IFC4x1cartesianPoint.Coordinates[0], (float)IFC4x1cartesianPoint.Coordinates[1]);
                        case 3: return new Vector2((float)IFC4x1cartesianPoint.Coordinates[0], (float)IFC4x1cartesianPoint.Coordinates[1]);
                    }
                }
            }
            if (cartesianPoint is IFC4x2.IFCCartesianPoint IFC4x2cartesianPoint)
            {
                if (IFC4x2cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x2cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector2((float)IFC4x2cartesianPoint.Coordinates[0], 0);
                        case 2: return new Vector2((float)IFC4x2cartesianPoint.Coordinates[0], (float)IFC4x2cartesianPoint.Coordinates[1]);
                        case 3: return new Vector2((float)IFC4x2cartesianPoint.Coordinates[0], (float)IFC4x2cartesianPoint.Coordinates[1]);
                    }
                }
            }
            if (cartesianPoint is IFC4x3.IFCCartesianPoint IFC4x3cartesianPoint)
            {
                if (IFC4x3cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x3cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector2((float)IFC4x3cartesianPoint.Coordinates[0], 0);
                        case 2: return new Vector2((float)IFC4x3cartesianPoint.Coordinates[0], (float)IFC4x3cartesianPoint.Coordinates[1]);
                        case 3: return new Vector2((float)IFC4x3cartesianPoint.Coordinates[0], (float)IFC4x3cartesianPoint.Coordinates[1]);
                    }
                }
            }
            return new Vector2();
        }

        public static Vector2 GetVector2(IFCVector IFCVector)
        {
            if(IFCVector._Magnitude != null && IFCVector._Orientation != null)
            {
                return (float)GetValue(IFCVector._Magnitude) * Vector2.Normalize(GetVector2(IFCVector._Orientation));
            }
            return Vector2.Zero;
        }

        /// <summary>
        /// Get Vector3 for input IFCCartesianPoint
        /// </summary>
        /// <param name="cartesianPoint"></param>
        /// <returns></returns>
        public static Vector3 GetVector3(IFCCartesianPoint cartesianPoint)
        {
            if (cartesianPoint == null)
            {
                return new Vector3();
            }

            if (cartesianPoint is IFC2x3.IFCCartesianPoint IFC2x3cartesianPoint)
            {
                if(IFC2x3cartesianPoint.Coordinates != null)
                {
                    switch (IFC2x3cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector3((float)IFC2x3cartesianPoint.Coordinates[0], 0, 0);
                        case 2: return new Vector3((float)IFC2x3cartesianPoint.Coordinates[0], (float)IFC2x3cartesianPoint.Coordinates[1], 0);
                        case 3: return new Vector3((float)IFC2x3cartesianPoint.Coordinates[0], (float)IFC2x3cartesianPoint.Coordinates[1], (float)IFC2x3cartesianPoint.Coordinates[2]);
                    }
                }
                
            }
            if (cartesianPoint is IFC4.IFCCartesianPoint IFC4cartesianPoint)
            {
                if (IFC4cartesianPoint.Coordinates != null)
                {
                    switch (IFC4cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector3((float)IFC4cartesianPoint.Coordinates[0], 0, 0);
                        case 2: return new Vector3((float)IFC4cartesianPoint.Coordinates[0], (float)IFC4cartesianPoint.Coordinates[1], 0);
                        case 3: return new Vector3((float)IFC4cartesianPoint.Coordinates[0], (float)IFC4cartesianPoint.Coordinates[1], (float)IFC4cartesianPoint.Coordinates[2]);
                    }
                }
            }
            if (cartesianPoint is IFC4x1.IFCCartesianPoint IFC4x1cartesianPoint)
            {
                if (IFC4x1cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x1cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector3((float)IFC4x1cartesianPoint.Coordinates[0], 0, 0);
                        case 2: return new Vector3((float)IFC4x1cartesianPoint.Coordinates[0], (float)IFC4x1cartesianPoint.Coordinates[1], 0);
                        case 3: return new Vector3((float)IFC4x1cartesianPoint.Coordinates[0], (float)IFC4x1cartesianPoint.Coordinates[1], (float)IFC4x1cartesianPoint.Coordinates[2]);
                    }
                }
            }
            if (cartesianPoint is IFC4x2.IFCCartesianPoint IFC4x2cartesianPoint)
            {
                if (IFC4x2cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x2cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector3((float)IFC4x2cartesianPoint.Coordinates[0], 0, 0);
                        case 2: return new Vector3((float)IFC4x2cartesianPoint.Coordinates[0], (float)IFC4x2cartesianPoint.Coordinates[1], 0);
                        case 3: return new Vector3((float)IFC4x2cartesianPoint.Coordinates[0], (float)IFC4x2cartesianPoint.Coordinates[1], (float)IFC4x2cartesianPoint.Coordinates[2]);
                    }
                }
            }
            if (cartesianPoint is IFC4x3.IFCCartesianPoint IFC4x3cartesianPoint)
            {
                if (IFC4x3cartesianPoint.Coordinates != null)
                {
                    switch (IFC4x3cartesianPoint.Coordinates.Count)
                    {
                        case 1: return new Vector3((float)IFC4x3cartesianPoint.Coordinates[0], 0, 0);
                        case 2: return new Vector3((float)IFC4x3cartesianPoint.Coordinates[0], (float)IFC4x3cartesianPoint.Coordinates[1], 0);
                        case 3: return new Vector3((float)IFC4x3cartesianPoint.Coordinates[0], (float)IFC4x3cartesianPoint.Coordinates[1], (float)IFC4x3cartesianPoint.Coordinates[2]);
                    }
                }
            }
            return new Vector3();
        }
        #endregion

        #region ---- IFCVector ----

        /// <summary>
        /// Get the vector matrix from IFC
        /// </summary>
        /// <param name="IFCVector"></param>
        /// <returns></returns>
        public static Vector3 GetVector3(IFCVector IFCVector)
        {
            if (IFCVector == null)
            {
                return new Vector3();
            }
            if(IFCVector._Orientation != null && IFCVector._Magnitude != null)
            {
                Vector3 dir = GetVector3(IFCVector._Orientation);
                if (dir == Vector3.Zero)
                {
                    return Vector3.Zero;
                }
                var mag = GetValue(IFCVector._Magnitude);

                return (float)mag * Vector3.Normalize(dir);
            }

            return new Vector3();
        }

        #endregion

        #region ---- IFCCartesianPointList ----

        public static List<Vector2> GetVector2List(IFCCartesianPointList IFCCartesianPointList)
        {
            if (IFCCartesianPointList == null)
            {
                return new List<Vector2>();
            }
            List<Vector2> vs = new List<Vector2>();
            if (IFCCartesianPointList is IFC4.IFCCartesianPointList2D IFC4CartesianPointList2D)
            {
                if(IFC4CartesianPointList2D.CoordList  != null)
                {
                    foreach (var coord in IFC4CartesianPointList2D.CoordList)
                    {
                        switch (coord.Count)
                        {
                            case 0: vs.Add(new Vector2()); break;
                            case 1: vs.Add(new Vector2((float)coord[0], 0)); break;
                            case 2: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                            case 3: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                        }
                    }
                }
                
            }
            if (IFCCartesianPointList is IFC4x1.IFCCartesianPointList2D IFC4x1CartesianPointList2D)
            {
                if (IFC4x1CartesianPointList2D.CoordList != null)
                {
                    foreach (var coord in IFC4x1CartesianPointList2D.CoordList)
                    {
                        switch (coord.Count)
                        {
                            case 0: vs.Add(new Vector2()); break;
                            case 1: vs.Add(new Vector2((float)coord[0], 0)); break;
                            case 2: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                            case 3: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                        }
                    }
                }
            }
            if (IFCCartesianPointList is IFC4x2.IFCCartesianPointList2D IFC4x2CartesianPointList2D)
            {
                if (IFC4x2CartesianPointList2D.CoordList != null)
                {
                    foreach (var coord in IFC4x2CartesianPointList2D.CoordList)
                    {
                        switch (coord.Count)
                        {
                            case 0: vs.Add(new Vector2()); break;
                            case 1: vs.Add(new Vector2((float)coord[0], 0)); break;
                            case 2: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                            case 3: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                        }
                    }
                }
            }
            if (IFCCartesianPointList is IFC4x3.IFCCartesianPointList2D IFC4x3CartesianPointList2D)
            {
                if (IFC4x3CartesianPointList2D.CoordList != null)
                {
                    foreach (var coord in IFC4x3CartesianPointList2D.CoordList)
                    {
                        switch (coord.Count)
                        {
                            case 0: vs.Add(new Vector2()); break;
                            case 1: vs.Add(new Vector2((float)coord[0], 0)); break;
                            case 2: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                            case 3: vs.Add(new Vector2((float)coord[0], (float)coord[1])); break;
                        }
                    }
                }
            }
            return vs;
        }
        #endregion

        #region ---- IFCValue ----

        public static double GetValue(IFCLengthMeasure IFCLengthMeasure)
        {
            if (IFCLengthMeasure == null) return 0.0f;

            if (IFCLengthMeasure is IFC2x3.IFCLengthMeasure IFC2x3PositiveLengthMeasure) return IFC2x3PositiveLengthMeasure.Value;
            if (IFCLengthMeasure is IFC4.IFCLengthMeasure IFC4PositiveLengthMeasure) return IFC4PositiveLengthMeasure.Value;
            if (IFCLengthMeasure is IFC4x1.IFCLengthMeasure IFC4x1PositiveLengthMeasure) return IFC4x1PositiveLengthMeasure.Value;
            if (IFCLengthMeasure is IFC4x2.IFCLengthMeasure IFC4x2PositiveLengthMeasure) return IFC4x2PositiveLengthMeasure.Value;
            if (IFCLengthMeasure is IFC4x3.IFCLengthMeasure IFC4x3PositiveLengthMeasure) return IFC4x3PositiveLengthMeasure.Value;
            return 0.0f;
        }
        public static double GetValue(IFCPositiveLengthMeasure IFCPositiveLengthMeasure)
        {
            if (IFCPositiveLengthMeasure == null) return 0.0f;

            if (IFCPositiveLengthMeasure is IFC2x3.IFCPositiveLengthMeasure IFC2x3PositiveLengthMeasure) return IFC2x3PositiveLengthMeasure.Value;
            if (IFCPositiveLengthMeasure is IFC4.IFCPositiveLengthMeasure IFC4PositiveLengthMeasure) return IFC4PositiveLengthMeasure.Value;
            if (IFCPositiveLengthMeasure is IFC4x1.IFCPositiveLengthMeasure IFC4x1PositiveLengthMeasure) return IFC4x1PositiveLengthMeasure.Value;
            if (IFCPositiveLengthMeasure is IFC4x2.IFCPositiveLengthMeasure IFC4x2PositiveLengthMeasure) return IFC4x2PositiveLengthMeasure.Value;
            if (IFCPositiveLengthMeasure is IFC4x3.IFCPositiveLengthMeasure IFC4x3PositiveLengthMeasure) return IFC4x3PositiveLengthMeasure.Value;
            return 0.0f;
        }

        public static int GetValue(IFCPositiveInteger IFCPositiveInteger)
        {
            if (IFCPositiveInteger == null) return 0;

            if (IFCPositiveInteger is IFC4.IFCPositiveInteger IFC4PositiveInteger) return IFC4PositiveInteger.Value;
            if (IFCPositiveInteger is IFC4x1.IFCPositiveInteger IFC4x1PositiveInteger) return IFC4x1PositiveInteger.Value;
            if (IFCPositiveInteger is IFC4x2.IFCPositiveInteger IFC4x2PositiveInteger) return IFC4x2PositiveInteger.Value;
            if (IFCPositiveInteger is IFC4x3.IFCPositiveInteger IFC4x3PositiveInteger) return IFC4x3PositiveInteger.Value;
            return 0;
        }

        public static double GetValue(IFCTrimmingSelect IFCTrimmingSelect)
        {
            if (IFCTrimmingSelect is REAL r)
            {
                return r.Value;
            }
            return 0;
        }

        public static double GetValue(IFCPlaneAngleMeasure IFCPlaneAngleMeasure)
        {
            if (IFCPlaneAngleMeasure == null) return 0.0f;

            if (IFCPlaneAngleMeasure is IFC2x3.IFCPlaneAngleMeasure IFC2x3PlaneAngleMeasure) return IFC2x3PlaneAngleMeasure.Value;
            if (IFCPlaneAngleMeasure is IFC4.IFCPlaneAngleMeasure IFC4PlaneAngleMeasure) return IFC4PlaneAngleMeasure.Value;
            if (IFCPlaneAngleMeasure is IFC4x1.IFCPlaneAngleMeasure IFC4x1PlaneAngleMeasure) return IFC4x1PlaneAngleMeasure.Value;
            if (IFCPlaneAngleMeasure is IFC4x2.IFCPlaneAngleMeasure IFC4x2PlaneAngleMeasure) return IFC4x2PlaneAngleMeasure.Value;
            if (IFCPlaneAngleMeasure is IFC4x3.IFCPlaneAngleMeasure IFC4x3PlaneAngleMeasure) return IFC4x3PlaneAngleMeasure.Value;
            return 0.0f;
        }



        public static bool GetValue(IFCBoolean IFCBoolean)
        {
            if (IFCBoolean == null) return false;

            if (IFCBoolean is IFC2x3.IFCBoolean IFC2x3Boolean) return IFC2x3Boolean.Value;
            if (IFCBoolean is IFC4.IFCBoolean IFC4Boolean) return IFC4Boolean.Value;
            if (IFCBoolean is IFC4x1.IFCBoolean IFC4x1Boolean) return IFC4x1Boolean.Value;
            if (IFCBoolean is IFC4x2.IFCBoolean IFC4x2Boolean) return IFC4x2Boolean.Value;
            if (IFCBoolean is IFC4x3.IFCBoolean IFC4x3Boolean) return IFC4x3Boolean.Value;
            return false;
        }

        #endregion


        private static List<IFCProduct> GetProductsInChildren(IFCProduct product, List<IFCRelContainedInSpatialStructure> IFCRelContainedInSpatialStructures)
        {
            List<IFCProduct> products = new List<IFCProduct>();
            foreach (IFCRelContainedInSpatialStructure IFCRelContainedInSpatialStructure in IFCRelContainedInSpatialStructures)
            {
                if (IFCRelContainedInSpatialStructure is IFC.IFC2x3.IFCRelContainedInSpatialStructure IFC2x3RelContainedInSpatialStructure)
                {
                    if (IFC2x3RelContainedInSpatialStructure.RelatingStructure == product)
                    {
                        var elements = IFC2x3RelContainedInSpatialStructure.RelatedElements;
                        if(elements != null)
                        {
                            foreach (var element in elements)
                            {
                                products.Add(element);
                            }
                        }
                    }
                }
                if (IFCRelContainedInSpatialStructure is IFC.IFC4.IFCRelContainedInSpatialStructure IFC4RelContainedInSpatialStructure)
                {
                    if (IFC4RelContainedInSpatialStructure.RelatingStructure == product)
                    {
                        var elements = IFC4RelContainedInSpatialStructure.RelatedElements;
                        if (elements != null)
                        {
                            foreach (var element in elements)
                            {
                                products.Add(element);
                            }
                        }
                    }
                }
                if (IFCRelContainedInSpatialStructure is IFC.IFC4x1.IFCRelContainedInSpatialStructure IFC4x1RelContainedInSpatialStructure)
                {
                    if (IFC4x1RelContainedInSpatialStructure.RelatingStructure == product)
                    {
                        var elements = IFC4x1RelContainedInSpatialStructure.RelatedElements;
                        if (elements != null)
                        {
                            foreach (var element in elements)
                            {
                                products.Add(element);
                            }
                        }
                    }
                }
                if (IFCRelContainedInSpatialStructure is IFC.IFC4x1.IFCRelContainedInSpatialStructure IFC4x2RelContainedInSpatialStructure)
                {
                    if (IFC4x2RelContainedInSpatialStructure.RelatingStructure == product)
                    {
                        var elements = IFC4x2RelContainedInSpatialStructure.RelatedElements;
                        if (elements != null)
                        {
                            foreach (var element in elements)
                            {
                                products.Add(element);
                            }
                        }
                    }
                }
                if (IFCRelContainedInSpatialStructure is IFC.IFC4x1.IFCRelContainedInSpatialStructure IFC4x3RelContainedInSpatialStructure)
                {
                    if (IFC4x3RelContainedInSpatialStructure.RelatingStructure == product)
                    {
                        var elements = IFC4x3RelContainedInSpatialStructure.RelatedElements;
                        if (elements != null)
                        {
                            foreach (var element in elements)
                            {
                                products.Add(element);
                            }
                        }
                    }
                }
            }
            return products;
        }

        private static List<IFCProduct> GetProductsInChildren(IFCProduct product, List<IFCRelAggregates> IFCRelAggregates)
        {
            List<IFCProduct> products = new List<IFCProduct>();
            foreach (IFCRelAggregates rel in IFCRelAggregates)
            {
                if (rel._RelatingObject == product)
                {
                    var elements = rel._RelatedObjects;
                    if (elements != null)
                    {
                        foreach (var element in elements)
                        {
                            if (element is IFCProduct p)
                                products.Add(p);
                        }
                    }
                }
            }
            return products;
        }

        /// <summary>
        /// Find children in the product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="IFCRelAggregates"></param>
        /// <param name="IFCRelContainedInSpatialStructures"></param>
        /// <returns></returns>
        public static List<IFCProduct> GetProductsInChildren(IFCProduct product, List<IFCRelAggregates> IFCRelAggregates, List<IFCRelContainedInSpatialStructure> IFCRelContainedInSpatialStructures)
        {
            List<IFCProduct> IFCProducts = GetProductsInChildren(product, IFCRelContainedInSpatialStructures);

            IFCProducts.AddRange(GetProductsInChildren(product, IFCRelAggregates));
            return IFCProducts;
        }
    }
}
