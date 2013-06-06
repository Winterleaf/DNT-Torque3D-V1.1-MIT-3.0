
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
    internal class tsObjectConvertercoFileDialog : TypeConverter
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
                return new coFileDialog(value as string);
                }

            return null;
            }
        }

      
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(tsObjectConvertercoFileDialog))]
    public class coFileDialog: coSimObject
{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coFileDialog(string simobjectid) : base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coFileDialog(uint simobjectid): base(simobjectid){ }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
internal coFileDialog(int simobjectid): base(simobjectid){ }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coFileDialog ts, string simobjectid)
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
        public static bool operator !=(coFileDialog ts, string simobjectid)
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
        public static implicit operator string( coFileDialog ts)
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
        public static implicit operator coFileDialog(string ts)
            {
            return new coFileDialog(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( coFileDialog ts)
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
        public static implicit operator coFileDialog(int ts)
            {
            return new coFileDialog(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( coFileDialog ts)
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
        public static implicit operator coFileDialog(uint ts)
            {
            return new coFileDialog(ts);
            }
/// <summary>
/// True/False whether to set the working directory to the directory returned by the dialog. 
/// </summary>
public bool changePath
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".changePath").AsBool();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".changePath", value.AsString());
          }
       }
/// <summary>
/// The default file path when the dialog is shown. 
/// </summary>
public String defaultFile
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".defaultFile").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".defaultFile", value.AsString());
          }
       }
/// <summary>
/// The default directory path when the dialog is shown. 
/// </summary>
public String defaultPath
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".defaultPath").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".defaultPath", value.AsString());
          }
       }
/// <summary>
/// The default file name when the dialog is shown. 
/// </summary>
public String fileName
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".fileName").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".fileName", value.AsString());
          }
       }
/// <summary>
/// The filter string for limiting the types of files visible in the dialog. It makes use of the pipe symbol '|'    as a delimiter. For example:\n\n   'All Files|*.*'\n\n   'Image Files|*.png;*.jpg|Png Files|*.png|Jepg Files|*.jpg' 
/// </summary>
public String filters
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".filters").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".filters", value.AsString());
          }
       }
/// <summary>
/// The title for the dialog. 
/// </summary>
public String title
       {
       get
          {
          return dnTorque.self.GetVar(_mSimObjectId + ".title").AsString();
          }
       set
          {
          dnTorque.self.SetVar(_mSimObjectId + ".title", value.AsString());
          }
       }
/// <summary>
/// @brief Launches the OS file browser
/// 
///    After an Execute() call, the chosen file name and path is available in one of two areas.  
///    If only a single file selection is permitted, the results will be stored in the @a fileName 
///    attribute.
/// 
///    If multiple file selection is permitted, the results will be stored in the 
///    @a files array.  The total number of files in the array will be stored in the 
///    @a fileCount attribute.
/// 
///    @tsexample
///    // NOTE: This is not he preferred class to use, but this still works
///    // Create the file dialog
///    %baseFileDialog = new FileDialog()
///    {
///       // Allow browsing of all file types
///       filters = \"*.*\";
///       // No default file
///       defaultFile = ;
///       // Set default path relative to project
///       defaultPath = \"./\";
///       // Set the title
///       title = \"Durpa\";
///       // Allow changing of path you are browsing
///       changePath = true;
///    };
///     // Launch the file dialog
///     %baseFileDialog.Execute();
///     
///     // Don't forget to cleanup
///     %baseFileDialog.delete();
/// 
///     // A better alternative is to use the 
///     // derived classes which are specific to file open and save
///     // Create a dialog dedicated to opening files
///     %openFileDlg = new OpenFileDialog()
///     {
///        // Look for jpg image files
///        // First part is the descriptor|second part is the extension
///        Filters = \"Jepg Files|*.jpg\";
///        // Allow browsing through other folders
///        ChangePath = true;
///        // Only allow opening of one file at a time
///        MultipleFiles = false;
///     };
///     // Launch the open file dialog
///     %result = %openFileDlg.Execute();
///     // Obtain the chosen file name and path
///     if ( %result )
///     {
///        %seletedFile = %openFileDlg.file;
///     }
///     else
///     {
///        %selectedFile = \"\";
///     }
///     // Cleanup
///     %openFileDlg.delete();
/// 
///     // Create a dialog dedicated to saving a file
///     %saveFileDlg = new SaveFileDialog()
///     {
///        // Only allow for saving of COLLADA files
///        Filters = \"COLLADA Files (*.dae)|*.dae|\";
///        // Default save path to where the WorldEditor last saved
///        DefaultPath = $pref::WorldEditor::LastPath;
///        // No default file specified
///        DefaultFile = \"\";
///        // Do not allow the user to change to a new directory
///        ChangePath = false;
///        // Prompt the user if they are going to overwrite an existing file
///        OverwritePrompt = true;
///     };
///     // Launch the save file dialog
///     %result = %saveFileDlg.Execute();
///     // Obtain the file name
///     %selectedFile = \"\";
///     if ( %result )
///        %selectedFile = %saveFileDlg.file;
///     // Cleanup
///     %saveFileDlg.delete();
///    @endtsexample
/// 
///    @return True if the file was selected was successfully found (opened) or declared (saved).)
/// 
/// </summary>
public  bool Execute(){
return TorqueScriptTemplate.m_ts.fnFileDialog_Execute(_mSimObjectId);
}
}}