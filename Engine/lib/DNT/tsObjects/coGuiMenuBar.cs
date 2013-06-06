
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
    internal class tsObjectConvertercoGuiMenuBar : TypeConverter
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
                return new coGuiMenuBar(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoGuiMenuBar))]
    public class coGuiMenuBar: coGuiTickCtrl
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiMenuBar(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiMenuBar(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coGuiMenuBar(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiMenuBar ts, string simobjectid)
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
        public static bool operator !=(coGuiMenuBar ts, string simobjectid)
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
        public static implicit operator string( coGuiMenuBar ts)
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
        public static implicit operator coGuiMenuBar(string ts)
            {
            return new coGuiMenuBar(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coGuiMenuBar ts)
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
        public static implicit operator coGuiMenuBar(int ts)
            {
            return new coGuiMenuBar(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coGuiMenuBar ts)
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
        public static implicit operator coGuiMenuBar(uint ts)
            {
            return new coGuiMenuBar(ts);
            }
/// <summary>
/// Extra padding to add to the bounds of the control.\n
/// </summary>
public int padding
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".padding").AsInt();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".padding", value.AsString());
          }
       }
/// <summary>
/// @brief Adds a new menu to the menu bar.
///    @param menuText Text to display for the new menu item.
///    @param menuId ID for the new menu item.
///    @tsexample
///    // Define the menu text
///    %menuText = \"New Menu\";
///    // Define the menu ID.
///    %menuId = \"2\";
///    // Inform the GuiMenuBar control to add the new menu
///    %thisGuiMenuBar.addMenu(%menuText,%menuId);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void addMenu(string menuText, int menuId){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_addMenu(_mSimObjectId, menuText, menuId);
}
/// <summary>
/// ,,0,NULL,-1),
///    @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.
///    @param menu Menu name or menu Id to add the new item to.
///    @param menuItemText Text for the new menu item.
///    @param menuItemId Id for the new menu item.
///    @param accelerator Accelerator key for the new menu item.
///    @param checkGroup Check group to include this menu item in.
///    @tsexample
///    // Define the menu we wish to add the item to
///    %targetMenu = \"New Menu\";  or  %menu = \"4\";
///    // Define the text for the new menu item
///    %menuItemText = \"Menu Item\";
///    // Define the id for the new menu item
///    %menuItemId = \"3\";
///    // Set the accelerator key to toggle this menu item with
///    %accelerator = \"n\";
///    // Define the Check Group that this menu item will be in, if we want it to be in a check group. -1 sets it in no check group.
///    %checkGroup = \"4\";
///    // Inform the GuiMenuBar control to add the new menu item with the defined fields
///    %thisGuiMenuBar.addMenuItem(%menu,%menuItemText,%menuItemId,%accelerator,%checkGroup);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void addMenuItem(string targetMenu, string menuItemText, int menuItemId, string accelerator, int checkGroup){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_addMenuItem(_mSimObjectId, targetMenu, menuItemText, menuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Adds a menu item to the specified menu.  The menu argument can be either the text of a menu or its id.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param submenuItemText Text to show for the new submenu
///    @param submenuItemId Id for the new submenu
///    @param accelerator Accelerator key for the new submenu
///    @param checkGroup Which check group the new submenu should be in, or -1 for none.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define the text for the new submenu
///    %submenuItemText = \"New Submenu Item\";
///    // Define the id for the new submenu
///    %submenuItemId = \"4\";
///    // Define the accelerator key for the new submenu
///    %accelerator = \"n\";
///    // Define the checkgroup for the new submenu
///    %checkgroup = \"7\";
///    // Request the GuiMenuBar control to add the new submenu with the defined information
///    %thisGuiMenuBar.addSubmenuItem(%menuTarget,%menuItem,%submenuItemText,%submenuItemId,%accelerator,%checkgroup);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void addSubmenuItem(string menuTarget, string menuItem, string submenuItemText, int submenuItemId, string accelerator, int checkGroup){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_addSubmenuItem(_mSimObjectId, menuTarget, menuItem, submenuItemText, submenuItemId, accelerator, checkGroup);
}
/// <summary>
/// @brief Removes all the menu items from the specified menu.
///    @param menuTarget Menu to remove all items from  
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Inform the GuiMenuBar control to clear all menu items from the defined menu
///    %thisGuiMenuBar.clearMenuItems(%menuTarget);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void clearMenuItems(string menuTarget){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_clearMenuItems(_mSimObjectId, menuTarget);
}
/// <summary>
/// @brief Clears all the menus from the menu bar.
///    @tsexample
///    // Inform the GuiMenuBar control to clear all menus from itself.
///    %thisGuiMenuBar.clearMenus();
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void clearMenus(int param1, int param2){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_clearMenus(_mSimObjectId, param1, param2);
}
/// <summary>
/// @brief Removes all the menu items from the specified submenu.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Inform the GuiMenuBar to remove all submenu items from the defined menu item
///    %thisGuiMenuBar.clearSubmenuItems(%menuTarget,%menuItem);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
public  void clearSubmenuItems(string menuTarget, string menuItem){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_clearSubmenuItems(_mSimObjectId, menuTarget, menuItem);
}
/// <summary>
/// @brief Removes the specified menu from the menu bar.
///    @param menuTarget Menu to remove from the menu bar  
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Inform the GuiMenuBar to remove the defined menu from the menu bar
///    %thisGuiMenuBar.removeMenu(%menuTarget);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void removeMenu(string menuTarget){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_removeMenu(_mSimObjectId, menuTarget);
}
/// <summary>
/// @brief Removes the specified menu item from the menu.
///    @param menuTarget Menu to affect the menu item in
///    @param menuItem Menu item to affect
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Request the GuiMenuBar control to remove the define menu item
///    %thisGuiMenuBar.removeMenuItem(%menuTarget,%menuItem);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void removeMenuItem(string menuTarget, string menuItemTarget){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_removeMenuItem(_mSimObjectId, menuTarget, menuItemTarget);
}
/// <summary>
/// @brief Sets the menu bitmap index for the check mark image.
///    @param bitmapIndex Bitmap index for the check mark image.
///    @tsexample
///    // Define the bitmap index
///    %bitmapIndex = \"2\";
///    // Inform the GuiMenuBar control of the proper bitmap index for the check mark image
///    %thisGuiMenuBar.setCheckmarkBitmapIndex(%bitmapIndex);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setCheckmarkBitmapIndex(int bitmapindex){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setCheckmarkBitmapIndex(_mSimObjectId, bitmapindex);
}
/// <summary>
/// @brief Sets the bitmap index for the menu and toggles rendering only the bitmap.
///    @param menuTarget Menu to affect
///    @param bitmapindex Bitmap index to set for the menu
///    @param bitmaponly If true, only the bitmap will be rendered
///    @param drawborder If true, a border will be drawn around the menu.
///    @tsexample
///    // Define the menuTarget to affect
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Set the bitmap index
///    %bitmapIndex = \"5\";
///    // Set if we are only to render the bitmap or not
///    %bitmaponly = \"true\";
///    // Set if we are rendering a border or not
///    %drawborder = \"true\";
///    // Inform the GuiMenuBar of the bitmap and rendering changes
///    %thisGuiMenuBar.setMenuBitmapIndex(%menuTarget,%bitmapIndex,%bitmapOnly,%drawBorder);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuBitmapIndex(string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuBitmapIndex(_mSimObjectId, menuTarget, bitmapindex, bitmaponly, drawborder);
}
/// <summary>
/// @brief Sets the specified menu item bitmap index in the bitmap array.  Setting the item's index to -1 will remove any bitmap.
///    @param menuTarget Menu to affect the menuItem in
///    @param menuItem Menu item to affect
///    @param bitmapIndex Bitmap index to set the menu item to
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem\"
///    %menuItem = \"New Menu Item\";  or %menuItem = \"2\";
///    // Define the bitmapIndex
///    %bitmapIndex = \"6\";
///    // Inform the GuiMenuBar control to set the menu item to the defined bitmap
///    %thisGuiMenuBar.setMenuItemBitmap(%menuTarget,%menuItem,%bitmapIndex);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuItemBitmap(string menuTarget, string menuItemTarget, int bitmapIndex){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemBitmap(_mSimObjectId, menuTarget, menuItemTarget, bitmapIndex);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in
///    the bitmap array (although this may be changed with setCheckmarkBitmapIndex()).
///    Any other menu items in the menu with the same check group become unchecked if they are checked.
///    @param menuTarget Menu to work in
///    @param menuItem Menu item to affect
///    @param checked Whether we are setting it to checked or not
///    @tsexample
///    
///    @endtsexample
///    @return If not void, return value and description
///    @see References)
/// 
/// </summary>
public  void setMenuItemChecked(string menuTarget, string menuItemTarget, bool xchecked){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemChecked(_mSimObjectId, menuTarget, menuItemTarget, xchecked);
}
/// <summary>
/// @brief sets the menu item to enabled or disabled based on the enable parameter.
///    The specified menu and menu item can either be text or ids.
///    Detailed description
///    @param menuTarget Menu to work in
///    @param menuItemTarget The menu item inside of the menu to enable or disable
///    @param enabled Boolean enable / disable value.
///    @tsexample
///    // Define the menu
///    %menu = \"New Menu\";  or  %menu = \"4\";
///    // Define the menu item
///    %menuItem = \"New Menu Item\";  or %menuItem = \"2\";
///    // Define the enabled state
///    %enabled = \"true\";
///    // Inform the GuiMenuBar control to set the enabled state of the requested menu item
///    %thisGuiMenuBar.setMenuItemEnable(%menu,%menuItme,%enabled);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuItemEnable(string menuTarget, string menuItemTarget, bool enabled){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemEnable(_mSimObjectId, menuTarget, menuItemTarget, enabled);
}
/// <summary>
/// @brief Sets the given menu item to be a submenu.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param isSubmenu Whether or not the menuItem will become a subMenu or not
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define whether or not the Menu Item is a sub menu or not
///    %isSubmenu = \"true\";
///    // Inform the GuiMenuBar control to set the defined menu item to be a submenu or not.
///    %thisGuiMenuBar.setMenuItemSubmenuState(%menuTarget,%menuItem,%isSubmenu);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuItemSubmenuState(string menuTarget, string menuItem, bool isSubmenu){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemSubmenuState(_mSimObjectId, menuTarget, menuItem, isSubmenu);
}
/// <summary>
/// @brief Sets the text of the specified menu item to the new string.
///    @param menuTarget Menu to affect
///    @param menuItem Menu item in the menu to change the text at
///    @param newMenuItemText New menu text
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";
///    // Define the new text for the menu item
///    %newMenuItemText = \"Very New Menu Item\";
///    // Inform the GuiMenuBar control to change the defined menu item with the new text
///    %thisGuiMenuBar.setMenuItemText(%menuTarget,%menuItem,%newMenuItemText);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuItemText(string menuTarget, string menuItemTarget, string newMenuItemText){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemText(_mSimObjectId, menuTarget, menuItemTarget, newMenuItemText);
}
/// <summary>
/// @brief Brief Description.
///    Detailed description
///    @param menuTarget Menu to affect the menu item in
///    @param menuItem Menu item to affect
///    @param isVisible Visible state to set the menu item to.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"2\";
///    // Define the visibility state
///    %isVisible = \"true\";
///    // Inform the GuiMenuBarControl of the visibility state of the defined menu item
///    %thisGuiMenuBar.setMenuItemVisible(%menuTarget,%menuItem,%isVisible);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuItemVisible(string menuTarget, string menuItemTarget, bool isVisible){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuItemVisible(_mSimObjectId, menuTarget, menuItemTarget, isVisible);
}
/// <summary>
/// @brief Sets the menu rendering margins: horizontal, vertical, bitmap spacing.
///    Detailed description
///    @param horizontalMargin Number of pixels on the left and right side of a menu's text.
///    @param verticalMargin Number of pixels on the top and bottom of a menu's text.
///    @param bitmapToTextSpacing Number of pixels between a menu's bitmap and text.
///    @tsexample
///    // Define the horizontalMargin
///    %horizontalMargin = \"5\";
///    // Define the verticalMargin
///    %verticalMargin = \"5\";
///    // Define the bitmapToTextSpacing
///    %bitmapToTextSpacing = \"12\";
///    // Inform the GuiMenuBar control to set its margins based on the defined values.
///    %thisGuiMenuBar.setMenuMargins(%horizontalMargin,%verticalMargin,%bitmapToTextSpacing);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuMargins(int horizontalMargin, int verticalMargin, int bitmapToTextSpacing){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuMargins(_mSimObjectId, horizontalMargin, verticalMargin, bitmapToTextSpacing);
}
/// <summary>
/// @brief Sets the text of the specified menu to the new string.
///    @param menuTarget Menu to affect
///    @param newMenuText New menu text
///    @tsexample
///    // Define the menu to affect
///    %menu = \"New Menu\";  or %menu = \"3\";
///    // Define the text to change the menu to
///    %newMenuText = \"Still a New Menu\";
///    // Inform the GuiMenuBar control to change the defined menu to the defined text
///    %thisGuiMenuBar.setMenuText(%menu,%newMenuText);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuText(string menuTarget, string newMenuText){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuText(_mSimObjectId, menuTarget, newMenuText);
}
/// <summary>
/// @brief Sets the whether or not to display the specified menu.
///    @param menuTarget Menu item to affect
///    @param visible Whether the menu item will be visible or not
///    @tsexample
///    // Define the menu to work with
///    %menuTarget = \"New Menu\";  or  %menuTarget = \"4\";
///    // Define if the menu should be visible or not
///    %visible = \"true\";
///    // Inform the GuiMenuBar control of the new visibility state for the defined menu
///    %thisGuiMenuBar.setMenuVisible(%menuTarget,%visible);
///    @endtsexample
///    @see GuiTickCtrl)
/// 
/// </summary>
public  void setMenuVisible(string menuTarget, bool visible){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setMenuVisible(_mSimObjectId, menuTarget, visible);
}
/// <summary>
/// @brief Sets the menu item bitmap to a check mark, which by default is the first element in the
///    bitmap array (although this may be changed with setCheckmarkBitmapIndex()).
///    Any other menu items in the menu with the same check group become unchecked if they are checked.
///    @param menuTarget Menu to affect a submenu in
///    @param menuItem Menu item to affect
///    @param submenuItemText Text to show for submenu
///    @param checked Whether or not this submenu item will be checked.
///    @tsexample
///    // Define the menuTarget
///    %menuTarget = \"New Menu\";  or %menuTarget = \"3\";
///    // Define the menuItem
///    %menuItem = \"New Menu Item\";  or  %menuItem = \"5\";
///    // Define the text for the new submenu
///    %submenuItemText = \"Submenu Item\";
///    // Define if this submenu item should be checked or not
///    %checked = \"true\";
///    // Inform the GuiMenuBar control to set the checked state of the defined submenu item
///    %thisGuiMenuBar.setSubmenuItemChecked(%menuTarget,%menuItem,%submenuItemText,%checked);
///    @endtsexample
///    @return If not void, return value and description
///    @see References)
/// 
/// </summary>
public  void setSubmenuItemChecked(string menuTarget, string menuItemTarget, string submenuItemText, bool xchecked){
TorqueScriptTemplate.m_ts.fnGuiMenuBar_setSubmenuItemChecked(_mSimObjectId, menuTarget, menuItemTarget, submenuItemText, xchecked);
}
}}
