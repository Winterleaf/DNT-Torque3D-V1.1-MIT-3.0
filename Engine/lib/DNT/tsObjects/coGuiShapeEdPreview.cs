
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
    internal class tsObjectConvertercoGuiShapeEdPreview : TypeConverter
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
                return new coGuiShapeEdPreview(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiShapeEdPreview))]
    public class coGuiShapeEdPreview: coEditTSCtrl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiShapeEdPreview(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiShapeEdPreview(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiShapeEdPreview(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiShapeEdPreview ts, string simobjectid)
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
        public static bool operator !=(coGuiShapeEdPreview ts, string simobjectid)
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
        public static implicit operator string( coGuiShapeEdPreview ts)
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
        public static implicit operator coGuiShapeEdPreview(string ts)
            {
            return new coGuiShapeEdPreview(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiShapeEdPreview ts)
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
        public static implicit operator coGuiShapeEdPreview(int ts)
            {
            return new coGuiShapeEdPreview(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiShapeEdPreview ts)
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
        public static implicit operator coGuiShapeEdPreview(uint ts)
            {
            return new coGuiShapeEdPreview(ts);
            }
/// <summary>
/// Index of the active thread, or -1 if none 
/// </summary>
public int activeThread
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".activeThread").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".activeThread", value.AsString());
          }
       }
/// <summary>
/// The number of collision meshes in the shape 
/// </summary>
public int colMeshes
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".colMeshes").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colMeshes", value.AsString());
          }
       }
/// <summary>
/// The total number of collision polygons (all meshes) in the shape 
/// </summary>
public int colPolys
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".colPolys").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".colPolys", value.AsString());
          }
       }
/// <summary>
/// The current detail level 
/// </summary>
public int currentDL
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".currentDL").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".currentDL", value.AsString());
          }
       }
/// <summary>
/// Number of polygons in the current detail 
/// </summary>
public int detailPolys
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".detailPolys").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".detailPolys", value.AsString());
          }
       }
/// <summary>
/// The size of the current detail 
/// </summary>
public int detailSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".detailSize").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".detailSize", value.AsString());
          }
       }
/// <summary>
/// If true, dragging the gizmo will rotate the sun direction 
/// </summary>
public bool editSun
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".editSun").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".editSun", value.AsString());
          }
       }
/// <summary>
/// If false, the current detail is selected based on camera distance 
/// </summary>
public bool fixedDetail
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fixedDetail").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fixedDetail", value.AsString());
          }
       }
private Point2I _gridDimension = null;
/// <summary>
/// Grid dimensions (number of rows and columns) in the form \rows cols\ 
/// </summary>
public Point2I gridDimension
       {
       get
          {
          if (_gridDimension!=null)
              _gridDimension.DetachAllEvents();
           _gridDimension = dnTorque.self.GetVar(_mSimObjectId + ".gridDimension").AsPoint2I();
          _gridDimension.OnChangeNotification +=_gridDimension_OnChangeNotification;
          return _gridDimension;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".gridDimension", value.AsString());
          }
       }
void _gridDimension_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".gridDimension", e.NewValue);
       }
/// <summary>
/// The number of bones in the current detail level (skins only) 
/// </summary>
public int numBones
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numBones").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numBones", value.AsString());
          }
       }
/// <summary>
/// The number of draw calls in the current detail level 
/// </summary>
public int numDrawCalls
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numDrawCalls").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numDrawCalls", value.AsString());
          }
       }
/// <summary>
/// The number of materials in the current detail level 
/// </summary>
public int numMaterials
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numMaterials").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numMaterials", value.AsString());
          }
       }
/// <summary>
/// The number of vertex weights in the current detail level (skins only) 
/// </summary>
public int numWeights
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".numWeights").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".numWeights", value.AsString());
          }
       }
/// <summary>
/// The current distance from the camera to the model 
/// </summary>
public float orbitDist
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".orbitDist").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".orbitDist", value.AsString());
          }
       }
/// <summary>
/// The current pixel size of the model 
/// </summary>
public float pixelSize
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".pixelSize").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".pixelSize", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape bounding box 
/// </summary>
public bool renderBounds
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderBounds").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderBounds", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape's collision geometry 
/// </summary>
public bool renderColMeshes
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderColMeshes").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderColMeshes", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape in 'ghost' mode (transparent) 
/// </summary>
public bool renderGhost
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderGhost").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderGhost", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to draw the grid 
/// </summary>
public bool renderGrid
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderGrid").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderGrid", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render mounted objects 
/// </summary>
public bool renderMounts
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderMounts").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderMounts", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the shape nodes 
/// </summary>
public bool renderNodes
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderNodes").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderNodes", value.AsString());
          }
       }
/// <summary>
/// Flag indicating whether to render the selected object's bounding box 
/// </summary>
public bool renderObjBox
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".renderObjBox").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".renderObjBox", value.AsString());
          }
       }
/// <summary>
/// Index of the selected node, or -1 if none 
/// </summary>
public int selectedNode
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".selectedNode").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".selectedNode", value.AsString());
          }
       }
/// <summary>
/// Index of the selected object detail mesh, or 0 if none 
/// </summary>
public int selectedObjDetail
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".selectedObjDetail").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".selectedObjDetail", value.AsString());
          }
       }
/// <summary>
/// Index of the selected object, or -1 if none 
/// </summary>
public int selectedObject
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".selectedObject").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".selectedObject", value.AsString());
          }
       }
private ColorI _sunAmbient = null;
/// <summary>
/// Diffuse color for the sun 
/// </summary>
public ColorI sunAmbient
       {
       get
          {
          if (_sunAmbient!=null)
              _sunAmbient.DetachAllEvents();
           _sunAmbient = dnTorque.self.GetVar(_mSimObjectId + ".sunAmbient").AsColorI();
          _sunAmbient.OnChangeNotification +=_sunAmbient_OnChangeNotification;
          return _sunAmbient;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sunAmbient", value.AsString());
          }
       }
void _sunAmbient_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".sunAmbient", e.NewValue);
       }
/// <summary>
/// X-axis rotation angle for the sun 
/// </summary>
public float sunAngleX
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".sunAngleX").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sunAngleX", value.AsString());
          }
       }
/// <summary>
/// Z-axis rotation angle for the sun 
/// </summary>
public float sunAngleZ
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".sunAngleZ").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sunAngleZ", value.AsString());
          }
       }
private ColorI _sunDiffuse = null;
/// <summary>
/// Ambient color for the sun 
/// </summary>
public ColorI sunDiffuse
       {
       get
          {
          if (_sunDiffuse!=null)
              _sunDiffuse.DetachAllEvents();
           _sunDiffuse = dnTorque.self.GetVar(_mSimObjectId + ".sunDiffuse").AsColorI();
          _sunDiffuse.OnChangeNotification +=_sunDiffuse_OnChangeNotification;
          return _sunDiffuse;
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".sunDiffuse", value.AsString());
          }
       }
void _sunDiffuse_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
       {
       dnTorque.self.SetVar(_mSimObjectId + ".sunDiffuse", e.NewValue);
       }
/// <summary>
/// Playback direction of the active thread 
/// </summary>
public int threadDirection
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".threadDirection").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".threadDirection", value.AsString());
          }
       }
/// <summary>
/// 'PingPong' mode of the active thread 
/// </summary>
public bool threadPingPong
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".threadPingPong").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".threadPingPong", value.AsString());
          }
       }
/// <summary>
/// Current position of the active thread (0-1) 
/// </summary>
public float threadPos
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".threadPos").AsFloat();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".threadPos", value.AsString());
          }
       }
/// <summary>
/// Add a new thread (initially without any sequence set) )
/// 
/// </summary>
public  void addThread(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_addThread(_mSimObjectId);
}
/// <summary>
/// Compute the bounding box of the shape using the current detail and node transforms
///    @return the bounding box \"min.x min.y min.z max.x max.y max.z\" )
/// 
/// </summary>
public  Box3F computeShapeBounds(){
return new Box3F ( TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_computeShapeBounds(_mSimObjectId));
}
/// <summary>
/// Export the current shape and all mounted objects to COLLADA (.dae).
///    Note that animation is not exported, and all geometry is combined into a 
///    single mesh.
///    @param path Destination filename )
/// 
/// </summary>
public  void exportToCollada(string path){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_exportToCollada(_mSimObjectId, path);
}
/// <summary>
/// Adjust the camera position and zoom to fit the shape within the view. )
/// 
/// </summary>
public  void fitToShape(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_fitToShape(_mSimObjectId);
}
/// <summary>
/// Return whether the named object is currently hidden )
/// 
/// </summary>
public  bool getMeshHidden(string name){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getMeshHidden(_mSimObjectId, name);
}
/// <summary>
/// Get the playback direction of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return direction of the sequence (-1=reverse, 0=paused, 1=forward) )
/// 
/// </summary>
public  float getMountThreadDir(int slot){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getMountThreadDir(_mSimObjectId, slot);
}
/// <summary>
/// Get the playback position of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return playback position of the sequence (0-1) )
/// 
/// </summary>
public  float getMountThreadPos(int slot){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getMountThreadPos(_mSimObjectId, slot);
}
/// <summary>
/// Get the name of the sequence playing on this mounted shape
///    @param slot mounted shape slot
///    @return name of the sequence (if any) )
/// 
/// </summary>
public  string getMountThreadSequence(int slot){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getMountThreadSequence(_mSimObjectId, slot);
}
/// <summary>
/// Get the number of threads
///    @return the number of threads )
/// 
/// </summary>
public  int getThreadCount(){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getThreadCount(_mSimObjectId);
}
/// <summary>
/// Get the name of the sequence assigned to the active thread )
/// 
/// </summary>
public  string getThreadSequence(){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_getThreadSequence(_mSimObjectId);
}
/// <summary>
/// Mount a shape onto the main shape at the specified node
///    @param shapePath path to the shape to mount
///    @param nodeName name of the node on the main shape to mount to
///    @param type type of mounting to use (Object, Image or Wheel)
///    @param slot mount slot )
/// 
/// </summary>
public  bool mountShape(string shapePath, string nodeName, string type, int slot){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_mountShape(_mSimObjectId, shapePath, nodeName, type, slot);
}
/// <summary>
/// Refresh the shape (used when the shape meshes or nodes have been added or removed) )
/// 
/// </summary>
public  void refreshShape(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_refreshShape(_mSimObjectId);
}
/// <summary>
/// Refreshes thread sequences (in case of removed/renamed sequences )
/// 
/// </summary>
public  void refreshThreadSequences(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_refreshThreadSequences(_mSimObjectId);
}
/// <summary>
/// Removes the specifed thread
///    @param slot index of the thread to remove )
/// 
/// </summary>
public  void removeThread(int slot){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_removeThread(_mSimObjectId, slot);
}
/// <summary>
/// Show or hide all objects in the shape )
/// 
/// </summary>
public  void setAllMeshesHidden(bool hidden){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setAllMeshesHidden(_mSimObjectId, hidden);
}
/// <summary>
/// Show or hide the named object in the shape )
/// 
/// </summary>
public  void setMeshHidden(string name, bool hidden){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setMeshHidden(_mSimObjectId, name, hidden);
}
/// <summary>
/// Sets the model to be displayed in this control
///    @param shapeName Name of the model to display.
///    @return True if the model was loaded successfully, false otherwise. )
/// 
/// </summary>
public  bool setModel(string shapePath){
return TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setModel(_mSimObjectId, shapePath);
}
/// <summary>
/// Set the node a shape is mounted to.
///    @param slot mounted shape slot
///    @param nodename name of the node to mount to )
/// 
/// </summary>
public  void setMountNode(int slot, string nodeName){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setMountNode(_mSimObjectId, slot, nodeName);
}
/// <summary>
/// Set the playback direction of the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param dir playback direction (-1=backwards, 0=paused, 1=forwards) )
/// 
/// </summary>
public  void setMountThreadDir(int slot, float dir){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setMountThreadDir(_mSimObjectId, slot, dir);
}
/// <summary>
/// Set the sequence position of the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param pos sequence position (0-1) )
/// 
/// </summary>
public  void setMountThreadPos(int slot, float pos){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setMountThreadPos(_mSimObjectId, slot, pos);
}
/// <summary>
/// Set the sequence to play for the shape mounted in the specified slot
///    @param slot mounted shape slot
///    @param name name of the sequence to play )
/// 
/// </summary>
public  void setMountThreadSequence(int slot, string name){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setMountThreadSequence(_mSimObjectId, slot, name);
}
/// <summary>
/// Set the camera orbit position
///    @param pos Position in the form \"x y z\" )
/// 
/// </summary>
public  void setOrbitPos(Point3F pos){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setOrbitPos(_mSimObjectId, pos.AsString());
}
/// <summary>
/// Sets the sequence to play for the active thread.
///    @param name name of the sequence to play
///    @param duration transition duration (0 for no transition)
///    @param pos position in the new sequence to transition to
///    @param play if true, the new sequence will play during the transition )
/// 
/// </summary>
public  void setThreadSequence(string name, float duration, float pos, bool play){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setThreadSequence(_mSimObjectId, name, duration, pos, play);
}
/// <summary>
/// Set the time scale of all threads
///    @param scale new time scale value )
/// 
/// </summary>
public  void setTimeScale(float scale){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_setTimeScale(_mSimObjectId, scale);
}
/// <summary>
/// Unmount all shapes )
/// 
/// </summary>
public  void unmountAll(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_unmountAll(_mSimObjectId);
}
/// <summary>
/// Unmount the shape in the specified slot
///    @param slot mounted shape slot )
/// 
/// </summary>
public  void unmountShape(int slot){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_unmountShape(_mSimObjectId, slot);
}
/// <summary>
/// Refresh the shape node transforms (used when a node transform has been modified externally) )
/// 
/// </summary>
public  void updateNodeTransforms(){
TorqueScriptTemplate.m_ts.fnGuiShapeEdPreview_updateNodeTransforms(_mSimObjectId);
}
}}
