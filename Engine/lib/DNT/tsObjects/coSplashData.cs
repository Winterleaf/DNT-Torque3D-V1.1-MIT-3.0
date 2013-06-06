
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
    internal class tsObjectConvertercoSplashData : TypeConverter
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
                return new coSplashData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoSplashData))]
    public class coSplashData: coGameBaseData
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSplashData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSplashData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSplashData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSplashData ts, string simobjectid)
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
        public static bool operator !=(coSplashData ts, string simobjectid)
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
        public static implicit operator string( coSplashData ts)
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
        public static implicit operator coSplashData(string ts)
            {
            return new coSplashData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coSplashData ts)
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
        public static implicit operator coSplashData(int ts)
            {
            return new coSplashData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coSplashData ts)
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
        public static implicit operator coSplashData(uint ts)
            {
            return new coSplashData(ts);
            }
/// <summary>
/// Constant acceleration value to place upon the splash effect.\n
/// </summary>
public float acceleration
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".acceleration").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".acceleration", value.AsString());
          }
       }
private ColorF _colors = null;
/// <summary>
/// Color values to set the splash effect, rgba. Up to 4 allowed. Will transition through colors based on values set in the times value. Example: colors[0] = \0.6 1.0 1.0 0.5\.\n 
/// </summary>
public ColorF colors
       {
       get
          {
          if (_colors!=null)
              _colors.DetachAllEvents();
           _colors = dnTorque.self.GetVar(_mSimObjectId + ".colors").AsColorF();
          _colors.OnChangeNotification +=_colors_OnChangeNotification;
          return _colors;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colors", value.AsString());
          }
       }
void _colors_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".colors", e.NewValue);
       }
/// <summary>
/// Time to delay, in milliseconds, before actually starting this effect.\n
/// </summary>
public int delayMS
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayMS").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayMS", value.AsString());
          }
       }
/// <summary>
/// Time variance for delayMS.\n
/// </summary>
public int delayVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".delayVariance").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".delayVariance", value.AsString());
          }
       }
/// <summary>
/// Rotational angle to create a splash ring.\n
/// </summary>
public float ejectionAngle
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ejectionAngle").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ejectionAngle", value.AsString());
          }
       }
/// <summary>
/// Frequency in which to emit splash rings.\n
/// </summary>
public float ejectionFreq
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ejectionFreq").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ejectionFreq", value.AsString());
          }
       }
/// <summary>
/// List of particle emitters to create at the point of this Splash effect.\n
/// </summary>
public coParticleEmitterData emitter
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".emitter");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".emitter", value.ToString());
          }
       }
/// <summary>
/// ExplosionData object to create at the creation position of this splash effect.\n
/// </summary>
public coExplosionData explosion
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".explosion");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".explosion", value.ToString());
          }
       }
/// <summary>
/// Height for the splash to reach.\n
/// </summary>
public float height
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".height").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".height", value.AsString());
          }
       }
/// <summary>
/// Lifetime for this effect, in milliseconds.\n
/// </summary>
public int lifetimeMS
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifetimeMS").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifetimeMS", value.AsString());
          }
       }
/// <summary>
/// Time variance for lifetimeMS.\n
/// </summary>
public int lifetimeVariance
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifetimeVariance").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifetimeVariance", value.AsString());
          }
       }
/// <summary>
/// Number of ejection points in the splash ring.\n
/// </summary>
public int numSegments
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numSegments").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numSegments", value.AsString());
          }
       }
/// <summary>
/// Lifetime, in milliseconds, for a splash ring.\n
/// </summary>
public float ringLifetime
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".ringLifetime").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".ringLifetime", value.AsString());
          }
       }
private Point3F _scale = null;
/// <summary>
/// The scale of this splashing effect, defined as the F32 points X, Y, Z.\n
/// </summary>
public Point3F scale
       {
       get
          {
          if (_scale!=null)
              _scale.DetachAllEvents();
           _scale = dnTorque.self.GetVar(_mSimObjectId + ".scale").AsPoint3F();
          _scale.OnChangeNotification +=_scale_OnChangeNotification;
          return _scale;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".scale", value.AsString());
          }
       }
void _scale_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".scale", e.NewValue);
       }
/// <summary>
/// SFXProfile effect to play.\n
/// </summary>
public coSFXProfile soundProfile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".soundProfile");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".soundProfile", value.ToString());
          }
       }
/// <summary>
/// Starting radius size of a splash ring.\n
/// </summary>
public float startRadius
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".startRadius").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".startRadius", value.AsString());
          }
       }
/// <summary>
/// Factor in which to apply the texture to the splash ring, 0.0f - 1.0f.\n
/// </summary>
public float texFactor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texFactor").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texFactor", value.AsString());
          }
       }
/// <summary>
/// Imagemap file to use as the texture for the splash effect.\n
/// </summary>
public String texture
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texture").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texture", value.AsString());
          }
       }
/// <summary>
/// Amount to wrap the texture around the splash ring, 0.0f - 1.0f.\n
/// </summary>
public float texWrap
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".texWrap").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".texWrap", value.AsString());
          }
       }
/// <summary>
/// Times to transition through the splash effect. Up to 4 allowed. Values are 0.0 - 1.0, and corrispond to the life of the particle where 0 is first created and 1 is end of lifespace.\n 
/// </summary>
public float times
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".times").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".times", value.AsString());
          }
       }
/// <summary>
/// Velocity for the splash effect to travel.\n
/// </summary>
public float velocity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".velocity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".velocity", value.AsString());
          }
       }
/// <summary>
/// Width for the X and Y coordinates to create this effect within.
/// </summary>
public float width
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".width").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".width", value.AsString());
          }
       }
}}