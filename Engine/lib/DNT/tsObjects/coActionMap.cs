
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
    internal class tsObjectConvertercoActionMap : TypeConverter
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
                return new coActionMap(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoActionMap))]
    public class coActionMap: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coActionMap(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coActionMap(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coActionMap(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coActionMap ts, string simobjectid)
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
        public static bool operator !=(coActionMap ts, string simobjectid)
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
        public static implicit operator string( coActionMap ts)
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
        public static implicit operator coActionMap(string ts)
            {
            return new coActionMap(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coActionMap ts)
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
        public static implicit operator coActionMap(int ts)
            {
            return new coActionMap(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coActionMap ts)
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
        public static implicit operator coActionMap(uint ts)
            {
            return new coActionMap(ts);
            }
/// <summary>
/// ( ActionMap, bind, bool, 5, 10, actionMap.bind( device, action, [modifier spec, mod...], command ) 
/// 			  @hide)
/// 
/// </summary>
public  bool bind(string a2, string a3, string a4, string a5= "", string a6= "", string a7= "", string a8= "", string a9= ""){
return TorqueScriptTemplate.m_ts.fnActionMap_bind(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9);
}
/// <summary>
///  ),
///     @brief Associates a make command and optional break command to a specified input device action.
///     Must include parenthesis and semicolon in the make and break command strings.
///     @param device The device to bind to. Can be a keyboard, mouse, joystick or gamepad.
///     @param action The device action to bind to. The action is dependant upon the device. Specify a key for keyboards.
///     @param makeCmd The command to execute when the device/action is made.
///     @param breakCmd [optional] The command to execute when the device or action is unmade.
///     @return True the bind was successful, false if the device was unknown or description failed.
/// 	@tsexample
/// 	// Print to the console when the spacebar is pressed
/// 	function onSpaceDown()
/// 	{
/// 	   echo(\"Space bar down!\");
/// 	}
/// 	// Print to the console when the spacebar is released
/// 	function onSpaceUp()
/// 	{
/// 	   echo(\"Space bar up!\");
/// 	}
///    // Bind the commands onSpaceDown() and onSpaceUp() to spacebar events
/// 	moveMap.bindCmd(keyboard, \"space\", \"onSpaceDown();\", \"onSpaceUp();\");
/// 	@endtsexample)
/// 
/// </summary>
public  bool bindCmd(string device, string action, string makeCmd, string breakCmd){
return TorqueScriptTemplate.m_ts.fnActionMap_bindCmd(_mSimObjectId, device, action, makeCmd, breakCmd);
}
/// <summary>
/// ( ActionMap, bindObj, bool, 6, 11, (device, action, [modifier spec, mod...], command, object)
/// 			  @hide)
/// 
/// </summary>
public  bool bindObj(string a2, string a3, string a4, string a5, string a6= "", string a7= "", string a8= "", string a9= "", string a10= ""){
return TorqueScriptTemplate.m_ts.fnActionMap_bindObj(_mSimObjectId, a2, a3, a4, a5, a6, a7, a8, a9, a10);
}
/// <summary>
/// @brief Gets the ActionMap binding for the specified command.
///    Use getField() on the return value to get the device and action of the binding.
///    @param command The function to search bindings for.
///    @return The binding against the specified command. Returns an empty string(\"\") 
///    if a binding wasn't found.
/// 	@tsexample
/// 	// Find what the function \"jump()\" is bound to in moveMap
/// 	%bind = moveMap.getBinding( \"jump\" );
/// 	if ( %bind !$= \"\" )
/// 	{
/// 	// Find out what device is used in the binding
/// 		%device = getField( %bind, 0 );
/// 	// Find out what action (such as a key) is used in the binding
/// 		%action = getField( %bind, 1 );
/// 	}
/// 	@endtsexample
///    @see getField)
/// 
/// </summary>
public  string getBinding(string command){
return TorqueScriptTemplate.m_ts.fnActionMap_getBinding(_mSimObjectId, command);
}
/// <summary>
/// @brief Gets ActionMap command for the device and action.
///    @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.
///    @return The command against the specified device and action.
/// 	@tsexample
/// 	// Find what function is bound to a device\'s action
/// 	// In this example, \"jump()\" was assigned to the space key in another script
/// 	%command = moveMap.getCommand(\"keyboard\", \"space\");
/// 	// Should print \"jump\" in the console
/// 	echo(%command)
/// 	@endtsexample)
/// 
/// </summary>
public  string getCommand(string device, string action){
return TorqueScriptTemplate.m_ts.fnActionMap_getCommand(_mSimObjectId, device, action);
}
/// <summary>
/// @brief Gets the Dead zone for the specified device and action.
///    @param device The device that was bound.  Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.
///    @return The dead zone for the specified device and action. Returns \"0 0\" if there is no dead zone  
///    or an empty string(\"\") if the mapping was not found.
/// 	@tsexample
/// 	%deadZone = moveMap.getDeadZone( \"gamepad\", \"thumbrx\");
/// 	@endtsexample)
/// 
/// </summary>
public  string getDeadZone(string device, string action){
return TorqueScriptTemplate.m_ts.fnActionMap_getDeadZone(_mSimObjectId, device, action);
}
/// <summary>
/// @brief Get any scaling on the specified device and action.
///    @param device The device that was bound. Can be keyboard, mouse, joystick or gamepad.
///    @param action The device action that was bound. The action is dependant upon the device. Specify a key for keyboards.
///    @return Any scaling applied to the specified device and action.
/// 	@tsexample
/// 	%scale = %moveMap.getScale( \"gamepad\", \"thumbrx\");
/// 	@endtsexample)
/// 
/// </summary>
public  float getScale(string device, string action){
return TorqueScriptTemplate.m_ts.fnActionMap_getScale(_mSimObjectId, device, action);
}
/// <summary>
/// @brief Determines if the specified device and action is inverted.
///    Should only be used for scrolling devices or gamepad/joystick axes.
///    @param device The device that was bound. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action that was bound.  The action is dependant upon the device. Specify a key for keyboards.
///    @return True if the specified device and action is inverted.
/// 	@tsexample
///    %if ( moveMap.isInverted( \"mouse\", \"xaxis\"))
///       echo(\"Mouse's xAxis is inverted\");
/// 	@endtsexample)
/// 
/// </summary>
public  bool isInverted(string device, string action){
return TorqueScriptTemplate.m_ts.fnActionMap_isInverted(_mSimObjectId, device, action);
}
/// <summary>
/// @brief Pop the ActionMap off the %ActionMap stack.
///    Deactivates an %ActionMap and removes it from the @ActionMap stack.
/// 	@tsexample
/// 	// Deactivate moveMap
/// 	moveMap.pop();
/// 	@endtsexample
///    @see ActionMap)
/// 
/// </summary>
public  void pop(){
TorqueScriptTemplate.m_ts.fnActionMap_pop(_mSimObjectId);
}
/// <summary>
/// @brief Push the ActionMap onto the %ActionMap stack.
///    Activates an ActionMap and placees it at the top of the ActionMap stack.
/// 	@tsexample
/// 	// Make moveMap the active action map
/// 	moveMap.push();
/// 	@endtsexample
///    @see ActionMap)
/// 
/// </summary>
public  void push(){
TorqueScriptTemplate.m_ts.fnActionMap_push(_mSimObjectId);
}
/// <summary>
/// @brief Saves the ActionMap to a file or dumps it to the console.
///    @param fileName The file path to save the ActionMap to. If a filename is not specified 
///     the ActionMap will be dumped to the console.
///    @param append Whether to write the ActionMap at the end of the file or overwrite it.
/// 	@tsexample
/// 	// Write out the actionmap into the config.cs file
///    moveMap.save( \"scripts/client/config.cs\" );
/// 	@endtsexample)
/// 
/// </summary>
public  void save(string fileName, bool append){
TorqueScriptTemplate.m_ts.fnActionMap_save(_mSimObjectId, fileName, append);
}
/// <summary>
/// @brief Removes the binding on an input device and action.
///    @param device The device to unbind from. Can be a keyboard, mouse, joystick or a gamepad.
///    @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.
///    @return True if the unbind was successful, false if the device was unknown or description failed.
/// 	@tsexample
/// 	moveMap.unbind(\"keyboard\", \"space\");
/// 	@endtsexample)
/// 
/// </summary>
public  bool unbind(string device, string action){
return TorqueScriptTemplate.m_ts.fnActionMap_unbind(_mSimObjectId, device, action);
}
/// <summary>
/// @brief Remove any object-binding on an input device and action.
///    @param device The device to bind to.  Can be keyboard, mouse, joystick or gamepad.
///    @param action The device action to unbind from. The action is dependant upon the device. Specify a key for keyboards.
///    @param obj The object to perform unbind against.
///    @return True if the unbind was successful, false if the device was unknown or description failed.
/// 	@tsexample
///    moveMap.unbindObj(\"keyboard\", \"numpad1\", \"rangeChange\", %player);
///    @endtsexample)
/// 
/// </summary>
public  bool unbindObj(string device, string action, string obj){
return TorqueScriptTemplate.m_ts.fnActionMap_unbindObj(_mSimObjectId, device, action, obj);
}
}}
