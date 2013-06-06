
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
    internal class tsObjectConvertercoGFXSamplerStateData : TypeConverter
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
                return new coGFXSamplerStateData(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGFXSamplerStateData))]
    public class coGFXSamplerStateData: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGFXSamplerStateData(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGFXSamplerStateData(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGFXSamplerStateData(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGFXSamplerStateData ts, string simobjectid)
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
        public static bool operator !=(coGFXSamplerStateData ts, string simobjectid)
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
        public static implicit operator string( coGFXSamplerStateData ts)
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
        public static implicit operator coGFXSamplerStateData(string ts)
            {
            return new coGFXSamplerStateData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGFXSamplerStateData ts)
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
        public static implicit operator coGFXSamplerStateData(int ts)
            {
            return new coGFXSamplerStateData(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGFXSamplerStateData ts)
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
        public static implicit operator coGFXSamplerStateData(uint ts)
            {
            return new coGFXSamplerStateData(ts);
            }
/// <summary>
/// The texture address mode for the u coordinate. The default is GFXAddressWrap. 
/// </summary>
public TypeGFXTextureAddressMode addressModeU
       {
       get
          {          return (TypeGFXTextureAddressMode)Enum.Parse(typeof(TypeGFXTextureAddressMode), dnTorque.self.GetVar(_mSimObjectId + ".addressModeU").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".addressModeU", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The texture address mode for the v coordinate. The default is GFXAddressWrap. 
/// </summary>
public TypeGFXTextureAddressMode addressModeV
       {
       get
          {          return (TypeGFXTextureAddressMode)Enum.Parse(typeof(TypeGFXTextureAddressMode), dnTorque.self.GetVar(_mSimObjectId + ".addressModeV").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".addressModeV", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The texture address mode for the w coordinate. The default is GFXAddressWrap. 
/// </summary>
public TypeGFXTextureAddressMode addressModeW
       {
       get
          {          return (TypeGFXTextureAddressMode)Enum.Parse(typeof(TypeGFXTextureAddressMode), dnTorque.self.GetVar(_mSimObjectId + ".addressModeW").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".addressModeW", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The first alpha argument for the texture stage. The default value is GFXTATexture. 
/// </summary>
public GFXTextureArgument alphaArg1
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".alphaArg1"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".alphaArg1", value.ToString());
          }
       }
/// <summary>
/// The second alpha argument for the texture stage. The default value is GFXTADiffuse. 
/// </summary>
public GFXTextureArgument alphaArg2
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".alphaArg2"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".alphaArg2", value.ToString());
          }
       }
/// <summary>
/// The third alpha channel selector operand for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
/// </summary>
public GFXTextureArgument alphaArg3
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".alphaArg3"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".alphaArg3", value.ToString());
          }
       }
/// <summary>
/// The texture alpha blending operation. The default value is GFXTOPModulate. 
/// </summary>
public TypeGFXTextureOp alphaOp
       {
       get
          {          return (TypeGFXTextureOp)Enum.Parse(typeof(TypeGFXTextureOp), dnTorque.self.GetVar(_mSimObjectId + ".alphaOp").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".alphaOp", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The first color argument for the texture stage. The default value is GFXTACurrent. 
/// </summary>
public GFXTextureArgument colorArg1
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".colorArg1"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colorArg1", value.ToString());
          }
       }
/// <summary>
/// The second color argument for the texture stage. The default value is GFXTATexture. 
/// </summary>
public GFXTextureArgument colorArg2
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".colorArg2"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colorArg2", value.ToString());
          }
       }
/// <summary>
/// The third color argument for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
/// </summary>
public GFXTextureArgument colorArg3
       {
       get
          {          return (GFXTextureArgument)Enum.Parse(typeof(GFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".colorArg3"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colorArg3", value.ToString());
          }
       }
/// <summary>
/// The texture magnification filter. The default is GFXTextureFilterLinear. 
/// </summary>
public TypeGFXTextureFilterType magFilter
       {
       get
          {          return (TypeGFXTextureFilterType)Enum.Parse(typeof(TypeGFXTextureFilterType), dnTorque.self.GetVar(_mSimObjectId + ".magFilter").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".magFilter", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The maximum texture anisotropy. The default value is 1. 
/// </summary>
public int maxAnisotropy
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".maxAnisotropy").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".maxAnisotropy", value.AsString());
          }
       }
/// <summary>
/// The texture minification filter. The default is GFXTextureFilterLinear. 
/// </summary>
public TypeGFXTextureFilterType minFilter
       {
       get
          {          return (TypeGFXTextureFilterType)Enum.Parse(typeof(TypeGFXTextureFilterType), dnTorque.self.GetVar(_mSimObjectId + ".minFilter").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".minFilter", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The texture mipmap filter used during minification. The default is GFXTextureFilterLinear. 
/// </summary>
public TypeGFXTextureFilterType mipFilter
       {
       get
          {          return (TypeGFXTextureFilterType)Enum.Parse(typeof(TypeGFXTextureFilterType), dnTorque.self.GetVar(_mSimObjectId + ".mipFilter").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mipFilter", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The mipmap level of detail bias. The default value is zero. 
/// </summary>
public float mipLODBias
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".mipLODBias").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".mipLODBias", value.AsString());
          }
       }
/// <summary>
/// The selection of the destination register for the result of this stage. The default is GFXTACurrent. 
/// </summary>
public TypeGFXTextureArgument resultArg
       {
       get
          {          return (TypeGFXTextureArgument)Enum.Parse(typeof(TypeGFXTextureArgument), dnTorque.self.GetVar(_mSimObjectId + ".resultArg").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".resultArg", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The texture color blending operation. The default value is GFXTOPDisable which disables the sampler. 
/// </summary>
public TypeGFXTextureOp textureColorOp
       {
       get
          {          return (TypeGFXTextureOp)Enum.Parse(typeof(TypeGFXTextureOp), dnTorque.self.GetVar(_mSimObjectId + ".textureColorOp").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureColorOp", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// Sets the texture transform state. The default is GFXTTFFDisable. 
/// </summary>
public TypeGFXTextureTransformFlags textureTransform
       {
       get
          {          return (TypeGFXTextureTransformFlags)Enum.Parse(typeof(TypeGFXTextureTransformFlags), dnTorque.self.GetVar(_mSimObjectId + ".textureTransform").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".textureTransform", value.ToString().Replace("zz_zz"," "));
          }
       }
}}
