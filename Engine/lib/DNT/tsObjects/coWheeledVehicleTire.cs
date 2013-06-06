
// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
// 
// THE SOFTW ARE IS PROVIDED ON AN “ AS IS” BASIS, WITHOUT W ARRANTY OF ANY KIND,
// INCLUDING WITHOUT LIMIT ATION THE W ARRANTIES OF MERCHANT ABILITY, FITNESS
// FOR A PARTICULAR PURPOSE OR NON-INFRINGEMENT . THE ENTIRE RISK AS TO THE
// QUALITY AND PERFORMANCE OF THE SOFTW ARE IS THE RESPONSIBILITY OF LICENSEE.
// SHOULD THE SOFTW ARE PROVE DEFECTIVE IN ANY RESPECT , LICENSEE AND NOT LICEN -
// SOR OR ITS SUPPLIERS OR RESELLERS ASSUMES THE ENTIRE COST OF AN Y SERVICE AND
// REPAIR. THIS DISCLAIMER OF W ARRANTY CONSTITUTES AN ESSENTIAL PART OF THIS
// AGREEMENT. NO USE OF THE SOFTW ARE IS AUTHORIZED HEREUNDER EXCEPT UNDER
// THIS DISCLAIMER.
// 
// The use of the WinterLeaf Entertainment LLC DotNetT orque (“DNT ”) and DotNetT orque
// Customizer (“DNTC”)is governed by this license agreement (“ Agreement”).
// 
// R E S T R I C T I O N S
// 
// (a) Licensee may not: (i) create any derivative works of DNTC, including but not
// limited to translations, localizations, technology add-ons, or game making software
// other than Games; (ii) reverse engineer , or otherwise attempt to derive the algorithms
// for DNT or DNTC (iii) redistribute, encumber , sell, rent, lease, sublicense, or otherwise
// transfer rights to  DNTC; or (iv) remove or alter any tra demark, logo, copyright
// or other proprietary notices, legends, symbols or labels in DNT or DNTC; or (iiv) use
// the Software to develop or distribute any software that compete s with the Software
// without WinterLeaf Entertainment’s prior written consent; or (i iiv) use the Software for
// any illegal purpose.
// (b) Licensee may not distribute the DNTC in any manner.
// 
// LI C E N S E G R A N T .
// This license allows companies of any size, government entities or individuals to cre -
// ate, sell, rent, lease, or otherwise profit commercially from, games using executables
// created from the source code of DNT
// 
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// THE SOURCE CODE GENERATED BY DNTC CAN BE  DISTRIBUTED PUBLICLY PROVIDED THAT THE 
// DISTRIBUTOR PROVIDES  THE GENERATE SOURCE CODE FREE OF CHARGE.
// 
// THIS SOURCE CODE (DNT) CAN BE DISTRIBUTED PUBLICLY PROVIDED THAT THE DISTRIBUTOR 
// PROVIDES  THE SOURCE CODE (DNT) FREE OF CHARGE.
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// 
// Please visit http://www.winterleafentertainment.com for more information about the project and latest updates.

#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.Enums;
using System.ComponentModel;
using System.Threading;
#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoWheeledVehicleTire : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof(string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
            if (value is string)
                {
                return new coWheeledVehicleTire(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoWheeledVehicleTire))]
    public class coWheeledVehicleTire: coSimDataBlock
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWheeledVehicleTire(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWheeledVehicleTire(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWheeledVehicleTire(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coWheeledVehicleTire ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);


            }
  /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            throw new NotImplementedException();
            }
  /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            
            return (this._mSimObjectId ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(coWheeledVehicleTire ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( coWheeledVehicleTire ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coWheeledVehicleTire(string ts)
            {
            return new coWheeledVehicleTire(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coWheeledVehicleTire ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return 0;
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coWheeledVehicleTire(int ts)
            {
            return new coWheeledVehicleTire(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coWheeledVehicleTire ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return 0;
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coWheeledVehicleTire(uint ts)
            {
            return new coWheeledVehicleTire(ts);
            }
/// <summary>
/// Tire friction when the wheel is slipping (no traction). 
/// </summary>
public float kineticFriction
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".kineticFriction").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".kineticFriction", value.AsString());
          }
       }
/// <summary>
/// Damping force applied against lateral forces generated by the tire.\n\n   @see lateralForce 
/// </summary>
public float lateralDamping
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lateralDamping").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lateralDamping", value.AsString());
          }
       }
/// <summary>
/// @brief Tire force perpendicular to the direction of movement.\n\n   Lateral force can in simple terms be considered left/right steering    force. WheeledVehicles are acted upon by forces generated by their tires    and the lateralForce measures the magnitude of the force exerted on the    vehicle when the tires are deformed along the x-axis. With real wheeled    vehicles, tires are constantly being deformed and it is the interplay of    deformation forces which determines how a vehicle moves. In Torque's    simulation of vehicle physics, tire deformation obviously can't be handled    with absolute realism, but the interplay of a vehicle's velocity, its    engine's torque and braking forces, and its wheels' friction, lateral    deformation, lateralDamping, lateralRelaxation, longitudinal deformation,    longitudinalDamping, and longitudinalRelaxation forces, along with its    wheels' angular velocity are combined to create a robust real-time    physical simulation.\n\n   For this field, the larger the value supplied for the lateralForce, the    larger the effect steering maneuvers can have. In Torque tire forces are    applied at a vehicle's wheel hubs. 
/// </summary>
public float lateralForce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lateralForce").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lateralForce", value.AsString());
          }
       }
/// <summary>
/// @brief Relaxing force applied against lateral forces generated by the tire.\n\n   The lateralRelaxation force measures how strongly the tire effectively    un-deforms.\n\n@see lateralForce 
/// </summary>
public float lateralRelaxation
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lateralRelaxation").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lateralRelaxation", value.AsString());
          }
       }
/// <summary>
/// Damping force applied against longitudinal forces generated by the tire.\n\n   @see longitudinalForce 
/// </summary>
public float longitudinalDamping
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".longitudinalDamping").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".longitudinalDamping", value.AsString());
          }
       }
/// <summary>
/// @brief Tire force in the direction of movement.\n\n   Longitudinal force can in simple terms be considered forward/backward    movement force. WheeledVehicles are acted upon by forces generated by    their tires and the longitudinalForce measures the magnitude of the    force exerted on the vehicle when the tires are deformed along the y-axis.\n\n   For this field, the larger the value, the larger the effect    acceleration/deceleration inputs have.\n\n   @see lateralForce 
/// </summary>
public float longitudinalForce
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".longitudinalForce").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".longitudinalForce", value.AsString());
          }
       }
/// <summary>
/// @brief Relaxing force applied against longitudinal forces generated by the tire.\n\n   The longitudinalRelaxation force measures how strongly the tire effectively    un-deforms.\n\n   @see longitudinalForce 
/// </summary>
public float longitudinalRelaxation
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".longitudinalRelaxation").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".longitudinalRelaxation", value.AsString());
          }
       }
/// <summary>
/// The mass of the wheel.\nCurrently unused. 
/// </summary>
public float mass
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mass").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mass", value.AsString());
          }
       }
/// <summary>
/// @brief The radius of the wheel.\n\n   The radius is determined from the bounding box of the shape provided    in the shapefile field, and does not need to be specified in script.    The tire should be built with its hub axis along the object's Y-axis. 
/// </summary>
public float radius
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".radius").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".radius", value.AsString());
          }
       }
/// <summary>
/// Tire restitution.\nCurrently unused. 
/// </summary>
public float restitution
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".restitution").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".restitution", value.AsString());
          }
       }
/// <summary>
/// The path to the shape to use for the wheel. 
/// </summary>
public String shapeFile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".shapeFile").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".shapeFile", value.AsString());
          }
       }
/// <summary>
/// Tire friction when the wheel is not slipping (has traction). 
/// </summary>
public float staticFriction
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".staticFriction").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".staticFriction", value.AsString());
          }
       }
}}