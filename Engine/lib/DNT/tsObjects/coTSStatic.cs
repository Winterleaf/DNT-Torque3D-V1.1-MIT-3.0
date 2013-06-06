
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
    internal class tsObjectConvertercoTSStatic : TypeConverter
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
                return new coTSStatic(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoTSStatic))]
    public class coTSStatic: coSceneObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coTSStatic(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coTSStatic(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coTSStatic(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coTSStatic ts, string simobjectid)
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
        public static bool operator !=(coTSStatic ts, string simobjectid)
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
        public static implicit operator string( coTSStatic ts)
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
        public static implicit operator coTSStatic(string ts)
            {
            return new coTSStatic(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coTSStatic ts)
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
        public static implicit operator coTSStatic(int ts)
            {
            return new coTSStatic(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coTSStatic ts)
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
        public static implicit operator coTSStatic(uint ts)
            {
            return new coTSStatic(ts);
            }
/// <summary>
/// @brief Allow a Player to walk up sloping polygons in the TSStatic (based on the collisionType).\n\n     When set to false, the slightest bump will stop the player from walking on top of the object.\n
/// </summary>
public bool allowPlayerStep
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".allowPlayerStep").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".allowPlayerStep", value.AsString());
          }
       }
/// <summary>
/// The type of mesh data to use for collision queries. 
/// </summary>
public TypeTSMeshType collisionType
       {
       get
          {          return (TypeTSMeshType)Enum.Parse(typeof(TypeTSMeshType), dnTorque.self.GetVar(_mSimObjectId + ".collisionType").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".collisionType", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// The type of mesh data used to clip decal polygons against. 
/// </summary>
public TypeTSMeshType decalType
       {
       get
          {          return (TypeTSMeshType)Enum.Parse(typeof(TypeTSMeshType), dnTorque.self.GetVar(_mSimObjectId + ".decalType").Replace(" ", "zz_zz"));
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".decalType", value.ToString().Replace("zz_zz"," "));
          }
       }
/// <summary>
/// Forces rendering to a particular detail level. 
/// </summary>
public int forceDetail
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".forceDetail").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".forceDetail", value.AsString());
          }
       }
/// <summary>
/// Enables detailed culling of meshes within the TSStatic. Should only be used      with large complex shapes like buildings which contain many submeshes. 
/// </summary>
public bool meshCulling
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".meshCulling").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".meshCulling", value.AsString());
          }
       }
/// <summary>
/// Enables translucent sorting of the TSStatic by its origin instead of the bounds. 
/// </summary>
public bool originSort
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".originSort").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".originSort", value.AsString());
          }
       }
/// <summary>
/// Enables automatic playing of the animation sequence named \ambient\ (if it exists) when the TSStatic is loaded.
/// </summary>
public bool playAmbient
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".playAmbient").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".playAmbient", value.AsString());
          }
       }
/// <summary>
/// Debug rendering mode shows the normals for each point in the TSStatic's mesh. 
/// </summary>
public float renderNormals
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderNormals").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderNormals", value.AsString());
          }
       }
/// <summary>
/// %Path and filename of the model file (.DTS, .DAE) to use for this TSStatic. 
/// </summary>
public String shapeName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".shapeName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".shapeName", value.AsString());
          }
       }
/// <summary>
/// @brief The skin applied to the shape.\n\n   'Skinning' the shape effectively renames the material targets, allowing    different materials to be used on different instances of the same model.\n\n   Any material targets that start with the old skin name have that part    of the name replaced with the new skin name. The initial old skin name is    \base\. For example, if a new skin of \blue\ was applied to a model    that had material targets ibase_body/i and iface/i, the new targets    would be iblue_body/i and iface/i. Note that iface/i was not    renamed since it did not start with the old skin name of \base\.\n\n   To support models that do not use the default \base\ naming convention,    you can also specify the part of the name to replace in the skin field    itself. For example, if a model had a material target called ishapemat/i,    we could apply a new skin \shape=blue\, and the material target would be    renamed to ibluemat/i (note \shape\ has been replaced with \blue\).\n\n   Multiple skin updates can also be applied at the same time by separating    them with a semicolon. For example: \base=blue;face=happy_face\.\n\n   Material targets are only renamed if an existing Material maps to that    name, or if there is a diffuse texture in the model folder with the same    name as the new target.\n\n 
/// </summary>
public String skin
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".skin").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".skin", value.AsString());
          }
       }
/// <summary>
/// ,NULL,NULL),
///    @brief Change one of the materials on the shape.
/// 
///    This method changes materials per mapTo with others. The material that 
///    is being replaced is mapped to unmapped_mat as a part of this transition.
/// 
///    @note Warning, right now this only sort of works. It doesn't do a live 
///    update like it should.
/// 
///    @param mapTo the name of the material target to remap (from getTargetName)
///    @param oldMat the old Material that was mapped 
///    @param newMat the new Material to map
/// 
///    @tsexample
///       // remap the first material in the shape
///       %mapTo = %obj.getTargetName( 0 );
///       %obj.changeMaterial( %mapTo, 0, MyMaterial );
///    @endtsexample )
/// 
/// </summary>
public  void changeMaterial(string mapTo, string oldMat, string newMat){
TorqueScriptTemplate.m_ts.fnTSStatic_changeMaterial(_mSimObjectId, mapTo, oldMat, newMat);
}
/// <summary>
/// @brief Get the model filename used by this shape.
/// 
///    @return the shape filename
///    @tsexample
/// 		// Acquire the model filename used on this shape.
/// 		%modelFilename = %obj.getModelFile();
///    @endtsexample
///    )
/// 
/// </summary>
public  string getModelFile(){
return TorqueScriptTemplate.m_ts.fnTSStatic_getModelFile(_mSimObjectId);
}
/// <summary>
/// Get the number of materials in the shape.
///    @return the number of materials in the shape.
///    @see getTargetName())
/// 
/// </summary>
public  int getTargetCount(){
return TorqueScriptTemplate.m_ts.fnTSStatic_getTargetCount(_mSimObjectId);
}
/// <summary>
/// Get the name of the indexed shape material.
///    @param index index of the material to get (valid range is 0 - getTargetCount()-1).
///    @return the name of the indexed material.
///    @see getTargetCount())
/// 
/// </summary>
public  string getTargetName(int index){
return TorqueScriptTemplate.m_ts.fnTSStatic_getTargetName(_mSimObjectId, index);
}
}}