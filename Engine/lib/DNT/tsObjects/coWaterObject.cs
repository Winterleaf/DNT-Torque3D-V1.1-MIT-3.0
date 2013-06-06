
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
    internal class tsObjectConvertercoWaterObject : TypeConverter
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
                return new coWaterObject(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoWaterObject))]
    public class coWaterObject: coSceneObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWaterObject(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWaterObject(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coWaterObject(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coWaterObject ts, string simobjectid)
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
        public static bool operator !=(coWaterObject ts, string simobjectid)
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
        public static implicit operator string( coWaterObject ts)
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
        public static implicit operator coWaterObject(string ts)
            {
            return new coWaterObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coWaterObject ts)
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
        public static implicit operator coWaterObject(int ts)
            {
            return new coWaterObject(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coWaterObject ts)
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
        public static implicit operator coWaterObject(uint ts)
            {
            return new coWaterObject(ts);
            }
private ColorI _baseColor = null;
/// <summary>
/// Changes color of water fog. 
/// </summary>
public ColorI baseColor
       {
       get
          {
          if (_baseColor!=null)
              _baseColor.DetachAllEvents();
           _baseColor = dnTorque.self.GetVar(_mSimObjectId + ".baseColor").AsColorI();
          _baseColor.OnChangeNotification +=_baseColor_OnChangeNotification;
          return _baseColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".baseColor", value.AsString());
          }
       }
void _baseColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".baseColor", e.NewValue);
       }
/// <summary>
/// Relative opacity or transparency of the water surface. 
/// </summary>
public float clarity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".clarity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".clarity", value.AsString());
          }
       }
/// <summary>
/// Cubemap used instead of reflection texture if fullReflect is off. 
/// </summary>
public String cubemap
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".cubemap").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".cubemap", value.AsString());
          }
       }
/// <summary>
/// Affects buoyancy of an object, thus affecting the Z velocity of a player (jumping, falling, etc.
/// </summary>
public float density
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".density").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".density", value.AsString());
          }
       }
/// <summary>
/// Depth in world units, the max range of the color gradient texture. 
/// </summary>
public float depthGradientMax
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".depthGradientMax").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".depthGradientMax", value.AsString());
          }
       }
/// <summary>
/// 1D texture defining the base water color by depth 
/// </summary>
public String depthGradientTex
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".depthGradientTex").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".depthGradientTex", value.AsString());
          }
       }
/// <summary>
/// Max distance that distortion algorithm is performed. 		 The lower, the more distorted the effect.
/// </summary>
public float distortEndDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".distortEndDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".distortEndDist", value.AsString());
          }
       }
/// <summary>
/// Determines the scaling down of distortion 		 in shallow water.
/// </summary>
public float distortFullDepth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".distortFullDepth").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".distortFullDepth", value.AsString());
          }
       }
/// <summary>
/// Determines start of distortion effect where water		  surface intersects the camera near plane.
/// </summary>
public float distortStartDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".distortStartDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".distortStartDist", value.AsString());
          }
       }
/// <summary>
/// When true the water colors don't react to changes to environment lighting. 
/// </summary>
public bool emissive
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".emissive").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".emissive", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
public float foamAmbientLerp
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamAmbientLerp").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamAmbientLerp", value.AsString());
          }
       }
private Point2F _foamDir = null;
/// <summary>
///  
/// </summary>
public Point2F foamDir
       {
       get
          {
          if (_foamDir!=null)
              _foamDir.DetachAllEvents();
           _foamDir = dnTorque.self.GetVar(_mSimObjectId + ".foamDir").AsPoint2F();
          _foamDir.OnChangeNotification +=_foamDir_OnChangeNotification;
          return _foamDir;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamDir", value.AsString());
          }
       }
void _foamDir_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".foamDir", e.NewValue);
       }
/// <summary>
///  
/// </summary>
public float foamMaxDepth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamMaxDepth").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamMaxDepth", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
public float foamOpacity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamOpacity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamOpacity", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
public float foamRippleInfluence
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamRippleInfluence").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamRippleInfluence", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
public float foamSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamSpeed", value.AsString());
          }
       }
/// <summary>
/// Diffuse texture for foam in shallow water (advanced lighting only) 
/// </summary>
public String foamTex
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".foamTex").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamTex", value.AsString());
          }
       }
private Point2F _foamTexScale = null;
/// <summary>
/// 			 applied to the surface.
/// </summary>
public Point2F foamTexScale
       {
       get
          {
          if (_foamTexScale!=null)
              _foamTexScale.DetachAllEvents();
           _foamTexScale = dnTorque.self.GetVar(_mSimObjectId + ".foamTexScale").AsPoint2F();
          _foamTexScale.OnChangeNotification +=_foamTexScale_OnChangeNotification;
          return _foamTexScale;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".foamTexScale", value.AsString());
          }
       }
void _foamTexScale_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".foamTexScale", e.NewValue);
       }
/// <summary>
/// Extent of fresnel affecting reflection fogging. 
/// </summary>
public float fresnelBias
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fresnelBias").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fresnelBias", value.AsString());
          }
       }
/// <summary>
/// Measures intensity of affect on reflection based on fogging. 
/// </summary>
public float fresnelPower
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fresnelPower").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fresnelPower", value.AsString());
          }
       }
/// <summary>
/// Enables dynamic reflection rendering. 
/// </summary>
public bool fullReflect
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fullReflect").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fullReflect", value.AsString());
          }
       }
/// <summary>
/// Liquid type of WaterBlock, such as water, ocean, lava		  Currently only Water is defined and used.
/// </summary>
public String liquidType
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".liquidType").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".liquidType", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
public float overallFoamOpacity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".overallFoamOpacity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".overallFoamOpacity", value.AsString());
          }
       }
/// <summary>
/// Master variable affecting entire surface
/// </summary>
public float overallRippleMagnitude
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".overallRippleMagnitude").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".overallRippleMagnitude", value.AsString());
          }
       }
/// <summary>
/// Master variable affecting entire body 		  of water's undulation 
/// </summary>
public float overallWaveMagnitude
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".overallWaveMagnitude").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".overallWaveMagnitude", value.AsString());
          }
       }
/// <summary>
/// scale up or down the detail level for objects rendered in a reflection 
/// </summary>
public float reflectDetailAdjust
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectDetailAdjust").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectDetailAdjust", value.AsString());
          }
       }
/// <summary>
/// Overall scalar to the reflectivity of the water surface. 
/// </summary>
public float reflectivity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectivity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectivity", value.AsString());
          }
       }
/// <summary>
/// Affects the sort time of reflected objects. 
/// </summary>
public int reflectMaxRateMs
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectMaxRateMs").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectMaxRateMs", value.AsString());
          }
       }
/// <summary>
/// always use z up as the reflection normal 
/// </summary>
public bool reflectNormalUp
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectNormalUp").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectNormalUp", value.AsString());
          }
       }
/// <summary>
/// Affects the sort order of reflected objects. 
/// </summary>
public float reflectPriority
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectPriority").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectPriority", value.AsString());
          }
       }
/// <summary>
/// The texture size used for reflections (square) 
/// </summary>
public int reflectTexSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".reflectTexSize").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".reflectTexSize", value.AsString());
          }
       }
private Point2F _rippleDir = null;
/// <summary>
/// Modifies the direction of ripples on the surface. 
/// </summary>
public Point2F rippleDir
       {
       get
          {
          if (_rippleDir!=null)
              _rippleDir.DetachAllEvents();
           _rippleDir = dnTorque.self.GetVar(_mSimObjectId + ".rippleDir").AsPoint2F();
          _rippleDir.OnChangeNotification +=_rippleDir_OnChangeNotification;
          return _rippleDir;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rippleDir", value.AsString());
          }
       }
void _rippleDir_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".rippleDir", e.NewValue);
       }
/// <summary>
/// Intensifies the vertext modification of the surface. 
/// </summary>
public float rippleMagnitude
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".rippleMagnitude").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rippleMagnitude", value.AsString());
          }
       }
/// <summary>
/// Modifies speed of surface ripples.
/// </summary>
public float rippleSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".rippleSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rippleSpeed", value.AsString());
          }
       }
/// <summary>
/// Normal map used to simulate small surface ripples 
/// </summary>
public String rippleTex
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".rippleTex").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rippleTex", value.AsString());
          }
       }
private Point2F _rippleTexScale = null;
/// <summary>
/// Intensifies the affect of the normal map 			 applied to the surface.
/// </summary>
public Point2F rippleTexScale
       {
       get
          {
          if (_rippleTexScale!=null)
              _rippleTexScale.DetachAllEvents();
           _rippleTexScale = dnTorque.self.GetVar(_mSimObjectId + ".rippleTexScale").AsPoint2F();
          _rippleTexScale.OnChangeNotification +=_rippleTexScale_OnChangeNotification;
          return _rippleTexScale;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".rippleTexScale", value.AsString());
          }
       }
void _rippleTexScale_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".rippleTexScale", e.NewValue);
       }
/// <summary>
/// Ambient sound environment when listener is submerged. 
/// </summary>
public coSFXAmbience soundAmbience
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".soundAmbience");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".soundAmbience", value.ToString());
          }
       }
private ColorF _specularColor = null;
/// <summary>
/// Color used for specularity on the water surface ( sun only ). 
/// </summary>
public ColorF specularColor
       {
       get
          {
          if (_specularColor!=null)
              _specularColor.DetachAllEvents();
           _specularColor = dnTorque.self.GetVar(_mSimObjectId + ".specularColor").AsColorF();
          _specularColor.OnChangeNotification +=_specularColor_OnChangeNotification;
          return _specularColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".specularColor", value.AsString());
          }
       }
void _specularColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".specularColor", e.NewValue);
       }
/// <summary>
/// Power used for specularity on the water surface ( sun only ). 
/// </summary>
public float specularPower
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".specularPower").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".specularPower", value.AsString());
          }
       }
private ColorI _underwaterColor = null;
/// <summary>
/// Changes the color shading of objects beneath		  the water surface.
/// </summary>
public ColorI underwaterColor
       {
       get
          {
          if (_underwaterColor!=null)
              _underwaterColor.DetachAllEvents();
           _underwaterColor = dnTorque.self.GetVar(_mSimObjectId + ".underwaterColor").AsColorI();
          _underwaterColor.OnChangeNotification +=_underwaterColor_OnChangeNotification;
          return _underwaterColor;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".underwaterColor", value.AsString());
          }
       }
void _underwaterColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".underwaterColor", e.NewValue);
       }
/// <summary>
/// turn off reflection rendering when occluded (delayed). 
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
/// <summary>
/// Affects drag force applied to an object submerged in this container. 
/// </summary>
public float viscosity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".viscosity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".viscosity", value.AsString());
          }
       }
/// <summary>
/// Intensity of underwater fogging. 
/// </summary>
public float waterFogDensity
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waterFogDensity").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waterFogDensity", value.AsString());
          }
       }
/// <summary>
/// Delta, or limit, applied to waterFogDensity. 
/// </summary>
public float waterFogDensityOffset
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waterFogDensityOffset").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waterFogDensityOffset", value.AsString());
          }
       }
private Point2F _waveDir = null;
/// <summary>
/// Direction waves flow toward shores. 
/// </summary>
public Point2F waveDir
       {
       get
          {
          if (_waveDir!=null)
              _waveDir.DetachAllEvents();
           _waveDir = dnTorque.self.GetVar(_mSimObjectId + ".waveDir").AsPoint2F();
          _waveDir.OnChangeNotification +=_waveDir_OnChangeNotification;
          return _waveDir;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waveDir", value.AsString());
          }
       }
void _waveDir_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".waveDir", e.NewValue);
       }
/// <summary>
/// Height of water undulation. 
/// </summary>
public float waveMagnitude
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waveMagnitude").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waveMagnitude", value.AsString());
          }
       }
/// <summary>
/// Speed of water undulation. 
/// </summary>
public float waveSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".waveSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".waveSpeed", value.AsString());
          }
       }
/// <summary>
/// The refract color intensity scaled at wetDepth. 
/// </summary>
public float wetDarkening
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".wetDarkening").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".wetDarkening", value.AsString());
          }
       }
/// <summary>
/// The depth in world units at which full darkening will be received,		  giving a wet look to objects underwater. 
/// </summary>
public float wetDepth
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".wetDepth").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".wetDepth", value.AsString());
          }
       }
}}