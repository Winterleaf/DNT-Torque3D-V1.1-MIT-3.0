
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
    internal class tsObjectConvertercoSFXSource : TypeConverter
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
                return new coSFXSource(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoSFXSource))]
    public class coSFXSource: coSimGroup
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSFXSource(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSFXSource(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coSFXSource(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coSFXSource ts, string simobjectid)
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
        public static bool operator !=(coSFXSource ts, string simobjectid)
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
        public static implicit operator string( coSFXSource ts)
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
        public static implicit operator coSFXSource(string ts)
            {
            return new coSFXSource(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coSFXSource ts)
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
        public static implicit operator coSFXSource(int ts)
            {
            return new coSFXSource(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coSFXSource ts)
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
        public static implicit operator coSFXSource(uint ts)
            {
            return new coSFXSource(ts);
            }
/// <summary>
/// The playback configuration that determines the initial sound properties and setup.\n     Any SFXSource must have an associated SFXDescription. 
/// </summary>
public coSFXDescription description
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".description");
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".description", value.ToString());
          }
       }
/// <summary>
/// Name of function to call when the status of the source changes.\n\n     The source that had its status changed is passed as the first argument to the function and the      new status of the source is passed as the second argument. 
/// </summary>
public String statusCallback
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".statusCallback").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".statusCallback", value.AsString());
          }
       }
/// <summary>
/// Add a notification marker called @a name at @a pos seconds of playback.
///    @param name Symbolic name for the marker that will be passed to the onMarkerPassed() callback.
///    @param pos Playback position in seconds when the notification should trigger.  Note that this is a soft limit and there 
///       may be a delay between the play cursor actually passing the position and the callback being triggered.
///    @note For looped sounds, the marker will trigger on each iteration.
///    @tsexample
///    // Create a new source.
///    $source = sfxCreateSource( AudioMusicLoop2D, \"art/sound/backgroundMusic\" );
///    
///    // Assign a class to the source.
///    $source.class = \"BackgroundMusic\";
///    
///    // Add a playback marker at one minute into playback.
///    $source.addMarker( \"first\", 60 );
///    
///    // Define the callback function.  This function will be called when the playback position passes the one minute mark.
///    function BackgroundMusic::onMarkerPassed( %this, %markerName )
///    {
///       if( %markerName $= \"first\" )
///          echo( \"Playback has passed the 60 seconds mark.\" );
///    }
///    
///    // Play the sound.
///    $source.play();
///    @endtsexample )
/// 
/// </summary>
public  void addMarker(string name, float pos){
TorqueScriptTemplate.m_ts.fnSFXSource_addMarker(_mSimObjectId, name, pos);
}
/// <summary>
/// Attach @a parameter to the source,
///    Once attached, the source will react to value changes of the given @a parameter.  Attaching a parameter 
///    will also trigger an initial read-out of the parameter's current value.
///    @param parameter The parameter to attach to the source. )
/// 
/// </summary>
public  void addParameter(string parameter){
TorqueScriptTemplate.m_ts.fnSFXSource_addParameter(_mSimObjectId, parameter);
}
/// <summary>
/// Get the final effective volume level of the source.
///    This method returns the volume level as it is after source group volume modulation, fades, and distance-based 
///    volume attenuation have been applied to the base volume level.
///    @return The effective volume of the source.
///    @ref SFXSource_volume )
/// 
/// </summary>
public  float getAttenuatedVolume(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getAttenuatedVolume(_mSimObjectId);
}
/// <summary>
/// Get the fade-in time set on the source.
///    This will initially be SFXDescription::fadeInTime.
///    @return The fade-in time set on the source in seconds.
///    @see SFXDescription::fadeInTime
///    @ref SFXSource_fades )
/// 
/// </summary>
public  float getFadeInTime(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getFadeInTime(_mSimObjectId);
}
/// <summary>
/// Get the fade-out time set on the source.
///    This will initially be SFXDescription::fadeOutTime.
///    @return The fade-out time set on the source in seconds.
///    @see SFXDescription::fadeOutTime
///    @ref SFXSource_fades )
/// 
/// </summary>
public  float getFadeOutTime(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getFadeOutTime(_mSimObjectId);
}
/// <summary>
/// Get the parameter at the given index.
///    @param index Index of the parameter to fetch.  Must be 0=index=getParameterCount().
///    @return The parameter at the given @a index or null if @a index is out of range.
///    @tsexample
///       // Print the name ofo each parameter attached to %source.
///       %numParams = %source.getParameterCount();
///       for( %i = 0; %i  %numParams; %i ++ )
///          echo( %source.getParameter( %i ).getParameterName() );
///    @endtsexample
///    @see getParameterCount )
/// 
/// </summary>
public  string getParameter(int index){
return TorqueScriptTemplate.m_ts.fnSFXSource_getParameter(_mSimObjectId, index);
}
/// <summary>
/// Get the number of SFXParameters that are attached to the source.
///    @return The number of parameters attached to the source.
///    @tsexample
///       // Print the name ofo each parameter attached to %source.
///       %numParams = %source.getParameterCount();
///       for( %i = 0; %i  %numParams; %i ++ )
///          echo( %source.getParameter( %i ).getParameterName() );
///    @endtsexample
///    @see getParameter
///    @see addParameter )
/// 
/// </summary>
public  int getParameterCount(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getParameterCount(_mSimObjectId);
}
/// <summary>
/// Get the pitch scale of the source.
///    Pitch determines the playback speed of the source (default: 1).
///    @return The current pitch scale factor of the source.
///    @see setPitch
///    @see SFXDescription::pitch )
/// 
/// </summary>
public  float getPitch(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getPitch(_mSimObjectId);
}
/// <summary>
/// Get the current playback status.
///    @return Te current playback status )
/// 
/// </summary>
public  SFXStatus getStatus(){
return (SFXStatus)( TorqueScriptTemplate.m_ts.fnSFXSource_getStatus(_mSimObjectId));
}
/// <summary>
/// Get the current base volume level of the source.
///    This is not the final effective volume that the source is playing at but rather the starting 
///    volume level before source group modulation, fades, or distance-based volume attenuation are applied.
///    @return The current base volume level.
///    @see setVolume
///    @see SFXDescription::volume
///    @ref SFXSource_volume )
/// 
/// </summary>
public  float getVolume(){
return TorqueScriptTemplate.m_ts.fnSFXSource_getVolume(_mSimObjectId);
}
/// <summary>
/// Test whether the source is currently paused.
///    @return True if the source is in paused state, false otherwise.
///    @see pause
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
public  bool isPaused(){
return TorqueScriptTemplate.m_ts.fnSFXSource_isPaused(_mSimObjectId);
}
/// <summary>
/// Test whether the source is currently playing.
///    @return True if the source is in playing state, false otherwise.
///    @see play
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
public  bool isPlaying(){
return TorqueScriptTemplate.m_ts.fnSFXSource_isPlaying(_mSimObjectId);
}
/// <summary>
/// Test whether the source is currently stopped.
///    @return True if the source is in stopped state, false otherwise.
///    @see stop
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
public  bool isStopped(){
return TorqueScriptTemplate.m_ts.fnSFXSource_isStopped(_mSimObjectId);
}
/// <summary>
/// Pause playback of the source.
///    @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be 
///       configured on the description.
///       Be aware that if a fade-out effect is used, the source will not immediately to paused state but will 
///       rather remain in playing state until the fade-out time has expired.. )
/// 
/// </summary>
public  void pause(float fadeOutTime){
TorqueScriptTemplate.m_ts.fnSFXSource_pause(_mSimObjectId, fadeOutTime);
}
/// <summary>
/// Start playback of the source.
///    If the sound data for the source has not yet been fully loaded, there will be a delay after calling 
///    play and playback will start after the data has become available.
///    @param fadeInTime Seconds for the sound to reach full volume.  If -1, the SFXDescription::fadeInTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-in effect that may 
///       be configured on the description. )
/// 
/// </summary>
public  void play(float fadeInTime){
TorqueScriptTemplate.m_ts.fnSFXSource_play(_mSimObjectId, fadeInTime);
}
/// <summary>
/// Detach @a parameter from the source.
///    Once detached, the source will no longer react to value changes of the given @a parameter.
///    If the parameter is not attached to the source, the method will do nothing.
///    @param parameter The parameter to detach from the source. )
/// 
/// </summary>
public  void removeParameter(string parameter){
TorqueScriptTemplate.m_ts.fnSFXSource_removeParameter(_mSimObjectId, parameter);
}
/// <summary>
/// Set up the 3D volume cone for the source.
///    @param innerAngle Angle of the inner sound cone in degrees (@ref SFXDescription::coneInsideAngle).  Must be 0=innerAngle=360.
///    @param outerAngle Angle of the outer sound cone in degrees (@ref SFXDescription::coneOutsideAngle).  Must be 0=outerAngle=360.
///    @param outsideVolume Volume scale factor outside of outer cone (@ref SFXDescription::coneOutsideVolume).  Must be 0=outsideVolume=1.
///    @note This method has no effect on the source if the source is not 3D. )
/// 
/// </summary>
public  void setCone(float innerAngle, float outerAngle, float outsideVolume){
TorqueScriptTemplate.m_ts.fnSFXSource_setCone(_mSimObjectId, innerAngle, outerAngle, outsideVolume);
}
/// <summary>
/// Set the fade time parameters of the source.
///    @param fadeInTime The new fade-in time in seconds.
///    @param fadeOutTime The new fade-out time in seconds.
///    @see SFXDescription::fadeInTime
///    @see SFXDescription::fadeOutTime
///    @ref SFXSource_fades )
/// 
/// </summary>
public  void setFadeTimes(float fadeInTime, float fadeOutTime){
TorqueScriptTemplate.m_ts.fnSFXSource_setFadeTimes(_mSimObjectId, fadeInTime, fadeOutTime);
}
/// <summary>
/// Set the pitch scale of the source.
///    Pitch determines the playback speed of the source (default: 1).
///    @param pitch The new pitch scale factor.
///    @see getPitch
///    @see SFXDescription::pitch )
/// 
/// </summary>
public  void setPitch(float pitch){
TorqueScriptTemplate.m_ts.fnSFXSource_setPitch(_mSimObjectId, pitch);
}
/// <summary>
/// ( SFXSource, setTransform, void, 3, 4,
///    ( vector position [, vector direction ] ) 
///    Set the position and orientation of a 3D sound source.
///    @hide )
/// 
/// </summary>
public  void setTransform(string a2, string a3= ""){
TorqueScriptTemplate.m_ts.fnSFXSource_setTransform(_mSimObjectId, a2, a3);
}
/// <summary>
/// Set the base volume level for the source.
///    This volume will be the starting point for source group volume modulation, fades, and distance-based 
///    volume attenuation.
///    @param volume The new base volume level for the source.  Must be 0>=volume=1.
///    @see getVolume
///    @ref SFXSource_volume )
/// 
/// </summary>
public  void setVolume(float volume){
TorqueScriptTemplate.m_ts.fnSFXSource_setVolume(_mSimObjectId, volume);
}
/// <summary>
/// Stop playback of the source.
///    @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be 
///       configured on the description.
///       Be aware that if a fade-out effect is used, the source will not immediately transtion to stopped state but 
///       will rather remain in playing state until the fade-out time has expired. )
/// 
/// </summary>
public  void stop(float fadeOutTime){
TorqueScriptTemplate.m_ts.fnSFXSource_stop(_mSimObjectId, fadeOutTime);
}
}}
