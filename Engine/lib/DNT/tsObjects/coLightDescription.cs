
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
    internal class tsObjectConvertercoLightDescription : TypeConverter
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
                return new coLightDescription(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoLightDescription))]
    public class coLightDescription: coSimDataBlock
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coLightDescription(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coLightDescription(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coLightDescription(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coLightDescription ts, string simobjectid)
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
        public static bool operator !=(coLightDescription ts, string simobjectid)
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
        public static implicit operator string( coLightDescription ts)
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
        public static implicit operator coLightDescription(string ts)
            {
            return new coLightDescription(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coLightDescription ts)
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
        public static implicit operator coLightDescription(int ts)
            {
            return new coLightDescription(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coLightDescription ts)
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
        public static implicit operator coLightDescription(uint ts)
            {
            return new coLightDescription(ts);
            }
/// <summary>
/// The length of time in seconds for a single playback of the light animation 
/// </summary>
public float animationPeriod
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animationPeriod").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animationPeriod", value.AsString());
          }
       }
/// <summary>
/// The phase used to offset the animation start time to vary the animation of nearby lights. 
/// </summary>
public float animationPhase
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animationPhase").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animationPhase", value.AsString());
          }
       }
/// <summary>
/// Datablock containing light animation information (LightAnimData) 
/// </summary>
public coLightAnimData animationType
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animationType");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animationType", value.ToString());
          }
       }
/// <summary>
/// Adjusts the lights power, 0 being off completely. 
/// </summary>
public float brightness
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".brightness").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".brightness", value.AsString());
          }
       }
/// <summary>
/// Enables/disabled shadow casts by this light. 
/// </summary>
public bool castShadows
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".castShadows").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".castShadows", value.AsString());
          }
       }
private ColorF _color = null;
/// <summary>
/// Changes the base color hue of the light. 
/// </summary>
public ColorF color
       {
       get
          {
          if (_color!=null)
              _color.DetachAllEvents();
           _color = dnTorque.self.GetVar(_mSimObjectId + ".color").AsColorF();
          _color.OnChangeNotification +=_color_OnChangeNotification;
          return _color;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".color", value.AsString());
          }
       }
void _color_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".color", e.NewValue);
       }
/// <summary>
/// Globally scales all features of the light flare 
/// </summary>
public float flareScale
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".flareScale").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".flareScale", value.AsString());
          }
       }
/// <summary>
/// Datablock containing light flare information (LightFlareData) 
/// </summary>
public coLightFlareData flareType
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".flareType");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".flareType", value.ToString());
          }
       }
/// <summary>
/// Controls the size (radius) of the light 
/// </summary>
public float range
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".range").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".range", value.AsString());
          }
       }
/// <summary>
/// @brief Force an inspectPostApply call for the benefit of tweaking via the console
///    
///    Normally this functionality is only exposed to objects via the World Editor, once changes have been made. 
///    Exposing apply to script allows you to make changes to it on the fly without the World Editor.
/// 
///    @note This is intended for debugging and tweaking, not for game play
/// 
///    @tsexample
///    // Change a property of the light description
///    RocketLauncherLightDesc.brightness = 10;
///    // Make it so
///    RocketLauncherLightDesc.apply();
///    
///    @endtsexample
/// )
/// 
/// </summary>
public  void apply(){
TorqueScriptTemplate.m_ts.fnLightDescription_apply(_mSimObjectId);
}
}}
