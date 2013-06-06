
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
    internal class tsObjectConvertercoItem : TypeConverter
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
                return new coItem(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoItem))]
    public class coItem: coShapeBase
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coItem(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coItem(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coItem(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coItem ts, string simobjectid)
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
        public static bool operator !=(coItem ts, string simobjectid)
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
        public static implicit operator string( coItem ts)
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
        public static implicit operator coItem(string ts)
            {
            return new coItem(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coItem ts)
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
        public static implicit operator coItem(int ts)
            {
            return new coItem(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coItem ts)
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
        public static implicit operator coItem(uint ts)
            {
            return new coItem(ts);
            }
/// <summary>
/// If true, the object will automatically rotate around its Z axis.\n
/// </summary>
public bool rotate
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".rotate").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rotate", value.AsString());
          }
       }
/// <summary>
/// If true, the object is not moving in the world.\n
/// </summary>
public bool staticx
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".static").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".static", value.AsString());
          }
       }
/// <summary>
/// @brief Get the normal of the surface on which the object is stuck.   
///    @return Returns The XYZ normal from where this Item is stuck.
///    @tsexample
/// 	   // Acquire the position where this Item is currently stuck
/// 	   %stuckPosition = %item.getLastStickPos();
///    @endtsexample
///    @note Server side only.
///    )
/// 
/// </summary>
public  string getLastStickyNormal(){
return TorqueScriptTemplate.m_ts.fnItem_getLastStickyNormal(_mSimObjectId);
}
/// <summary>
/// @brief Get the position on the surface on which this Item is stuck.   
///    @return Returns The XYZ position of where this Item is stuck.
///    @tsexample
/// 	   // Acquire the position where this Item is currently stuck
/// 	   %stuckPosition = %item.getLastStickPos();
///    @endtsexample
///    @note Server side only.
///    )
/// 
/// </summary>
public  string getLastStickyPos(){
return TorqueScriptTemplate.m_ts.fnItem_getLastStickyPos(_mSimObjectId);
}
/// <summary>
/// @brief Is the object at rest (ie, no longer moving)?   
///    @return True if the object is at rest, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not at rest.
/// 	   %isAtRest = %item.isAtRest();
///    @endtsexample
///    )
/// 
/// </summary>
public  bool isAtRest(){
return TorqueScriptTemplate.m_ts.fnItem_isAtRest(_mSimObjectId);
}
/// <summary>
/// @brief Is the object still rotating?   
///    @return True if the object is still rotating, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not rotating.
/// 	   %isRotating = %itemData.isRotating();
///    @endtsexample
///    @see rotate
///    )
/// 
/// </summary>
public  bool isRotating(){
return TorqueScriptTemplate.m_ts.fnItem_isRotating(_mSimObjectId);
}
/// <summary>
/// @brief Is the object static (ie, non-movable)?   
///    @return True if the object is static, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not static.
/// 	   %isStatic = %itemData.isStatic();
///    @endtsexample
///    @see static
///    )
/// 
/// </summary>
public  bool isStatic(){
return TorqueScriptTemplate.m_ts.fnItem_isStatic(_mSimObjectId);
}
/// <summary>
/// @brief Temporarily disable collisions against a specific ShapeBase object.
/// 
///    This is useful to prevent a player from immediately picking up an Item they have 
///    just thrown.  Only one object may be on the timeout list at a time.  The timeout is 
///    defined as 15 ticks.
/// 
///    @param objectID ShapeBase object ID to disable collisions against.
///    @return Returns true if the ShapeBase object requested could be found, false if it could not.
/// 
///    @tsexample
/// 	   // Set the ShapeBase Object ID to disable collisions against
/// 	   %ignoreColObj = %player.getID();
/// 	   // Inform this Item object to ignore collisions temproarily against the %ignoreColObj.
/// 	   %item.setCollisionTimeout(%ignoreColObj);
///    @endtsexample
///    )
/// 
/// </summary>
public  bool setCollisionTimeout(int ignoreColObj){
return TorqueScriptTemplate.m_ts.fnItem_setCollisionTimeout(_mSimObjectId, ignoreColObj);
}
}}