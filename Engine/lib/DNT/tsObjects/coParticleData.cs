
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
    internal class tsObjectConvertercoParticleData : TypeConverter
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
                return new coParticleData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoParticleData))]
    public class coParticleData: coSimDataBlock
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coParticleData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coParticleData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coParticleData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coParticleData ts, string simobjectid)
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
        public static bool operator !=(coParticleData ts, string simobjectid)
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
        public static implicit operator string( coParticleData ts)
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
        public static implicit operator coParticleData(string ts)
            {
            return new coParticleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coParticleData ts)
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
        public static implicit operator coParticleData(int ts)
            {
            return new coParticleData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coParticleData ts)
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
        public static implicit operator coParticleData(uint ts)
            {
            return new coParticleData(ts);
            }
/// <summary>
/// If true, allow the particle texture to be an animated sprite. 
/// </summary>
public bool animateTexture
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animateTexture").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animateTexture", value.AsString());
          }
       }
/// <summary>
/// @brief A list of frames and/or frame ranges to use for particle    animation if animateTexture is true.\n\n   Each frame token must be separated by whitespace. A frame token must be    a positive integer frame number or a range of frame numbers separated    with a '-'. The range separator, '-', cannot have any whitspace around    it.\n\n   Ranges can be specified to move through the frames in reverse as well    as forward (eg. 19-14). Frame numbers exceeding the number of tiles will    wrap.\n   @tsexample\n   animTexFrames = \0-16 20 19 18 17 31-21\;\n   @endtsexample\n 
/// </summary>
public String animTexFrames
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animTexFrames").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animTexFrames", value.AsString());
          }
       }
/// <summary>
/// @brief Texture file to use for this particle if animateTexture is true.\n\n   Deprecated. Use textureName instead. 
/// </summary>
public String animTexName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".animTexName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animTexName", value.AsString());
          }
       }
private Point2I _animTexTiling = null;
/// <summary>
/// @brief The number of frames, in rows and columns stored in textureName    (when animateTexture is true).\n\n   A maximum of 256 frames can be stored in a single texture when using    animTexTiling. Value should be \NumColumns NumRows\, for example \4 4\. 
/// </summary>
public Point2I animTexTiling
       {
       get
          {
          if (_animTexTiling!=null)
              _animTexTiling.DetachAllEvents();
           _animTexTiling = dnTorque.self.GetVar(_mSimObjectId + ".animTexTiling").AsPoint2I();
          _animTexTiling.OnChangeNotification +=_animTexTiling_OnChangeNotification;
          return _animTexTiling;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".animTexTiling", value.AsString());
          }
       }
void _animTexTiling_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".animTexTiling", e.NewValue);
       }
private ColorF _colors = null;
/// <summary>
/// @brief Particle RGBA color keyframe values.\n\n   The particle color will linearly interpolate between the color/time keys    over the lifetime of the particle. 
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
/// Constant acceleration to apply to this particle. 
/// </summary>
public float constantAcceleration
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".constantAcceleration").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".constantAcceleration", value.AsString());
          }
       }
/// <summary>
/// Particle physics drag amount. 
/// </summary>
public float dragCoefficient
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".dragCoefficient").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".dragCoefficient", value.AsString());
          }
       }
/// <summary>
/// If animateTexture is true, this defines the frames per second of the    sprite animation. 
/// </summary>
public int framesPerSec
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".framesPerSec").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".framesPerSec", value.AsString());
          }
       }
/// <summary>
/// Strength of gravity on the particles. 
/// </summary>
public float gravityCoefficient
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".gravityCoefficient").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gravityCoefficient", value.AsString());
          }
       }
/// <summary>
/// Amount of emitter velocity to add to particle initial velocity. 
/// </summary>
public float inheritedVelFactor
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".inheritedVelFactor").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".inheritedVelFactor", value.AsString());
          }
       }
/// <summary>
/// Time in milliseconds before this particle is destroyed. 
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
/// Variance in lifetime of particle, from 0 - lifetimeMS. 
/// </summary>
public int lifetimeVarianceMS
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".lifetimeVarianceMS").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".lifetimeVarianceMS", value.AsString());
          }
       }
/// <summary>
/// @brief Particle size keyframe values.\n\n   The particle size will linearly interpolate between the size/time keys    over the lifetime of the particle. 
/// </summary>
public float sizes
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".sizes").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sizes", value.AsString());
          }
       }
/// <summary>
/// Maximum allowed spin speed of this particle, between spinRandomMin and 1000. 
/// </summary>
public float spinRandomMax
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".spinRandomMax").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".spinRandomMax", value.AsString());
          }
       }
/// <summary>
/// Minimum allowed spin speed of this particle, between -1000 and spinRandomMax. 
/// </summary>
public float spinRandomMin
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".spinRandomMin").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".spinRandomMin", value.AsString());
          }
       }
/// <summary>
/// Speed at which to spin the particle. 
/// </summary>
public float spinSpeed
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".spinSpeed").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".spinSpeed", value.AsString());
          }
       }
private Point2F _textureCoords = null;
/// <summary>
/// @brief 4 element array defining the UV coords into textureName to use    for this particle.\n\n   Coords should be set for the first tile only when using animTexTiling;    coordinates for other tiles will be calculated automatically. \0 0\ is    top left and \1 1\ is bottom right. 
/// </summary>
public Point2F textureCoords
       {
       get
          {
          if (_textureCoords!=null)
              _textureCoords.DetachAllEvents();
           _textureCoords = dnTorque.self.GetVar(_mSimObjectId + ".textureCoords").AsPoint2F();
          _textureCoords.OnChangeNotification +=_textureCoords_OnChangeNotification;
          return _textureCoords;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureCoords", value.AsString());
          }
       }
void _textureCoords_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".textureCoords", e.NewValue);
       }
/// <summary>
/// Texture file to use for this particle. 
/// </summary>
public String textureName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".textureName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureName", value.AsString());
          }
       }
/// <summary>
/// @brief Time keys used with the colors and sizes keyframes.\n\n   Values are from 0.0 (particle creation) to 1.0 (end of lifespace). 
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
/// @brief Controls how particles blend with the scene.\n\n   If true, particles blend like ParticleBlendStyle NORMAL, if false,    blend like ParticleBlendStyle ADDITIVE.\n   @note If ParticleEmitterData::blendStyle is set, it will override this value. 
/// </summary>
public bool useInvAlpha
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".useInvAlpha").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".useInvAlpha", value.AsString());
          }
       }
/// <summary>
/// Strength of wind on the particles. 
/// </summary>
public float windCoefficient
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".windCoefficient").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".windCoefficient", value.AsString());
          }
       }
/// <summary>
/// Reloads this particle.
///    @tsexample
///    // Get the editor's current particle
///    %particle = PE_ParticleEditor.currParticle
///    // Change a particle value
///    %particle.setFieldValue( %propertyField, %value );
///    // Reload it
///    %particle.reload();
///    @endtsexample )
/// 
/// </summary>
public  void reload(){
TorqueScriptTemplate.m_ts.fnParticleData_reload(_mSimObjectId);
}
}}
