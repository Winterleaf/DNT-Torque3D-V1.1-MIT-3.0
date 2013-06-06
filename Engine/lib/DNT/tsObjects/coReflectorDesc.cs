
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
    internal class tsObjectConvertercoReflectorDesc : TypeConverter
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
                return new coReflectorDesc(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoReflectorDesc))]
    public class coReflectorDesc: coSimDataBlock
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coReflectorDesc(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coReflectorDesc(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coReflectorDesc(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coReflectorDesc ts, string simobjectid)
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
        public static bool operator !=(coReflectorDesc ts, string simobjectid)
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
        public static implicit operator string( coReflectorDesc ts)
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
        public static implicit operator coReflectorDesc(string ts)
            {
            return new coReflectorDesc(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coReflectorDesc ts)
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
        public static implicit operator coReflectorDesc(int ts)
            {
            return new coReflectorDesc(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coReflectorDesc ts)
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
        public static implicit operator coReflectorDesc(uint ts)
            {
            return new coReflectorDesc(ts);
            }
/// <summary>
/// Scale applied to lod calculation of objects rendering into      this reflection ( modulates $pref::TS::detailAdjust ). 
/// </summary>
public float detailAdjust
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".detailAdjust").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".detailAdjust", value.AsString());
          }
       }
/// <summary>
/// Far plane distance to use when rendering reflections. 
/// </summary>
public float farDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".farDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".farDist", value.AsString());
          }
       }
/// <summary>
/// If less than maxRateMs has elapsed since this relfection was last      updated, then do not update it again. This 'skip' can be disabled by      setting maxRateMs to zero. 
/// </summary>
public int maxRateMs
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxRateMs").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxRateMs", value.AsString());
          }
       }
/// <summary>
/// Near plane distance to use when rendering this reflection. Adjust      this to limit self-occlusion artifacts. 
/// </summary>
public float nearDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".nearDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".nearDist", value.AsString());
          }
       }
/// <summary>
/// Object types which render into this reflection. 
/// </summary>
public int objectTypeMask
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".objectTypeMask").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".objectTypeMask", value.AsString());
          }
       }
/// <summary>
/// Priority for updating this reflection, relative to others. 
/// </summary>
public float priority
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".priority").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".priority", value.AsString());
          }
       }
/// <summary>
/// Size in pixels of the (square) reflection texture. For a cubemap      this value is interpreted as size of each face. 
/// </summary>
public int texSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texSize").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texSize", value.AsString());
          }
       }
/// <summary>
/// If available on the device use HOQs to determine if the reflective object      is visible before updating its reflection. 
/// </summary>
public bool useOcclusionQuery
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useOcclusionQuery").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useOcclusionQuery", value.AsString());
          }
       }
}}