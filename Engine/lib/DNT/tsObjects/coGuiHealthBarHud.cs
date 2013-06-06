
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
    internal class tsObjectConvertercoGuiHealthBarHud : TypeConverter
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
                return new coGuiHealthBarHud(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiHealthBarHud))]
    public class coGuiHealthBarHud: coGuiControl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiHealthBarHud(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiHealthBarHud(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiHealthBarHud(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiHealthBarHud ts, string simobjectid)
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
        public static bool operator !=(coGuiHealthBarHud ts, string simobjectid)
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
        public static implicit operator string( coGuiHealthBarHud ts)
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
        public static implicit operator coGuiHealthBarHud(string ts)
            {
            return new coGuiHealthBarHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiHealthBarHud ts)
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
        public static implicit operator coGuiHealthBarHud(int ts)
            {
            return new coGuiHealthBarHud(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiHealthBarHud ts)
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
        public static implicit operator coGuiHealthBarHud(uint ts)
            {
            return new coGuiHealthBarHud(ts);
            }
private ColorF _damageFillColor = null;
/// <summary>
/// As the health bar depletes, this color will represent the health loss amount. 
/// </summary>
public ColorF damageFillColor
       {
       get
          {
          if (_damageFillColor!=null)
              _damageFillColor.DetachAllEvents();
           _damageFillColor = dnTorque.self.GetVar(_mSimObjectId + ".damageFillColor").AsColorF();
          _damageFillColor.OnChangeNotification +=_damageFillColor_OnChangeNotification;
          return _damageFillColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".damageFillColor", value.AsString());
          }
       }
void _damageFillColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".damageFillColor", e.NewValue);
       }
/// <summary>
/// If true, display the energy value rather than the damage value. 
/// </summary>
public bool displayEnergy
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".displayEnergy").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".displayEnergy", value.AsString());
          }
       }
private ColorF _fillColor = null;
/// <summary>
/// Standard color for the background of the control. 
/// </summary>
public ColorF fillColor
       {
       get
          {
          if (_fillColor!=null)
              _fillColor.DetachAllEvents();
           _fillColor = dnTorque.self.GetVar(_mSimObjectId + ".fillColor").AsColorF();
          _fillColor.OnChangeNotification +=_fillColor_OnChangeNotification;
          return _fillColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fillColor", value.AsString());
          }
       }
void _fillColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".fillColor", e.NewValue);
       }
private ColorF _frameColor = null;
/// <summary>
/// Color for the control's frame. 
/// </summary>
public ColorF frameColor
       {
       get
          {
          if (_frameColor!=null)
              _frameColor.DetachAllEvents();
           _frameColor = dnTorque.self.GetVar(_mSimObjectId + ".frameColor").AsColorF();
          _frameColor.OnChangeNotification +=_frameColor_OnChangeNotification;
          return _frameColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".frameColor", value.AsString());
          }
       }
void _frameColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".frameColor", e.NewValue);
       }
/// <summary>
/// Speed at which the control will pulse. 
/// </summary>
public int pulseRate
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pulseRate").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pulseRate", value.AsString());
          }
       }
/// <summary>
/// Health level the control must be under before the control will pulse. 
/// </summary>
public float pulseThreshold
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pulseThreshold").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pulseThreshold", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the background color of the control. 
/// </summary>
public bool showFill
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".showFill").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".showFill", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the frame of the control. 
/// </summary>
public bool showFrame
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".showFrame").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".showFrame", value.AsString());
          }
       }
}}
