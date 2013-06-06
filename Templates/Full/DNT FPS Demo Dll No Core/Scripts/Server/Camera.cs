﻿// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
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
// 
// 
// 

#region

using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    public partial class Main : TorqueScriptTemplate
        {
        // Global movement speed that affects all cameras.  This should be moved
        // into the camera datablock.


        [Torque_Decorations.TorqueCallBack("", "", "InitializeCamera", "()", 0, 19000, true)]
        public void InitializeCamera()
            {
            iGlobal["$Camera::movementSpeed"] = 30;
            }


        //-----------------------------------------------------------------------------
        // Camera methods
        //-----------------------------------------------------------------------------

        //-----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "Camera", "onAdd", "(%this,%obj)", 2, 19000, false)]
        public void CameraOnAdd(coCamera camera, string obj)
            {
            CameraSetMode(camera, camera["mode"]);
            }

        [Torque_Decorations.TorqueCallBack("", "Camera", "setMode", "(%this,%mode,%arg1,%arg2,%arg3)", 5, 19000, false)]
        public void CameraSetMode(coCamera camera, string mode, string arg1 = "", string arg2 = "", string arg3 = "")
            {
            coSimDataBlock t = camera.getDataBlock();
            System.Console.WriteLine(t.getName());
            console.Call_Classname(camera.getDataBlock().AsString(), "setMode", new string[] { camera, mode, arg1, arg2, arg3 });
            // Punt this one over to our datablock
            }


        [Torque_Decorations.TorqueCallBack("", "Observer", "onTrigger", "(%this,%obj,%trigger,%state)", 4, 19000, false)]
        public void ObserverObserverOnTrigger(coCameraData cameradata, coCamera camera, string trigger, bool state)
            {
            // state = 0 means that a trigger key was released
            if (state == false)
                return;

            // Default player triggers: 0=fire 1=altFire 2=jump
            coGameConnection client = camera.getControllingClient();
            string mode = camera["mode"];
            switch (mode)
                {
                case "Observer":
                    // Do something interesting.
                    break;
                case "Corpse":
                    //Here is a winner... if you send the prepare too soon, it will crash out the client.  The GameConnectionOnControlObjectChange needs
                    //time to run, and since it's still processing the first change (Switch to camera) this second change (Camera->player) will crash
                    //out the client.
                    //ServerCmdSetEditorCameraStandard(client);
                    //ServerCmdDropCameraAtPlayer(client);
                    camera.setFlyMode();
                    client.setControlObject(camera);
                    GameConnectiOnPreparePlayer(client);
                    break;
                }
            }

        [Torque_Decorations.TorqueCallBack("", "Observer", "setMode", "(%this,%obj,%mode,%arg1,%arg2,%arg3)", 5, 19000, false)]
        public void ObserverObserverSetMode(coCamera camera, string mode, coSceneObject arg1, string arg2, string arg3)
            {
            switch (mode)
                {
                case "Observer":
                    camera.setFlyMode();
                    break;
                case "Corpse":
                    camera.setOrbitMode(arg1, arg1.getTransform(), (float)0.5, (float)4.5, (float)4.5, false, new Point3F(), false);
                    camera["orbitObj"] = arg1;
                    break;
                }
            camera["mode"] = mode;
            }
        }
    }