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

using System;
using System.ComponentModel;
using System.Threading;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    public partial class Main : TorqueScriptTemplate
        {
        // Inventory items.  These objects rely on the item & inventory support
        // system defined in item.cs and inventory.cs

        //-----------------------------------------------------------------------------
        // Health Patches cannot be picked up and are not meant to be added to inventory.
        // Health is applied automatically when an objects collides with a patch.
        //-----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "HealthPatch", "onCollision", "(%this, %obj, %col)", 3, 1500, false)]
        public void HealthPatchOnCollision(coItemData healthkit_datablock, coSceneObject healthkit_instance, coPlayer player)
            {
            if (player.getDamageLevel() <= 0.00 || player.getState() == "Dead")
                return;

            player.applyRepair(healthkit_datablock["repairAmount"].AsFloat());

            healthkit_instance.call("schedulePop");


            //coGameConnection client = player["client"];
            //if (!client.isObject())
            //    return;
            //using (BackgroundWorker bwr = new BackgroundWorker())
            //    {
            //    bwr.DoWork += bwr_UpdateHealth;
            //    bwr.RunWorkerAsync(new HealthKitHelper(player, healthkit_instance));
            //    }

            AudioServerPlay3D("HealthUseSound", player.getTransform());
            }


        /// <summary>
        /// This function is used by the above backgroundworker to update the 
        /// player that their health has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //public void bwr_UpdateHealth(object sender, DoWorkEventArgs e)
        //    {
        //    coPlayer player = ((HealthKitHelper) e.Argument).player;

        //    if (!player.isObject())
        //        return;
        //    // Would be better to add a onRepair() callback to shapeBase.cpp in order to
        //    // prevent any excess/unneccesary schedules from this.  But for the time
        //    // being....

        //    // This is just a rough timer to update the Health HUD every 250 ms.  From
        //    // my tests a large health pack will fully heal a player from 10 health in
        //    // 36 iterations (ie. 9 seconds).  If either the scheduling time, the repair
        //    // amount, or the repair rate is changed then the healthTimer counter should
        //    // be changed also.
        //    for (int i = 0; i < 40; i++)
        //        {
        //        //Since this is happening out of process, we need prevent the torque
        //        //engine from ticking while we do this.  If we don't the memory will
        //        //get corrupt if two processes enter the Torque DLL at the same time.
        //        //So we use a Monitor and lock an object which prevents an engine tick
        //        //from occuring.
        //        lock (m_ts.tick)
        //            {
        //            //update the player if he is alive.
        //            if (player.isObject() && player.getState() != "Dead")
        //                PlayerUpdateHealth(player);
        //            else
        //                //No reason to keep updating if they are dead.
        //                break;
        //            }
        //        //Sleep for 250 milleseconds.
        //        Thread.Sleep(250);
        //        }
        //    }


        [Torque_Decorations.TorqueCallBack("", "ShapeBase", "tossPatch", "(%this)", 1, 1500, false)]
        public string ShapeBaseTossPatch(coShapeBase thisobj)
            {
            if (!thisobj.isObject())
                return string.Empty;

            coItem item = console.Call_Classname("ItemData", "CreateItem", new[] {"HealthKitPatch"});
            item["istemp"] = true.AsString();

            item["sourceObject"] = thisobj;
            item["static"] = false.AsString();

            (( coSimSet)"MissionCleanup").pushToBack(item);

            Random r = new Random();

            Point3F vec = new Point3F(-1 + (float) r.NextDouble()*2, -1*(float) r.NextDouble()*2, (float) r.NextDouble());
            vec = vec.vecotrScale(10);
            Point3F eye = thisobj.getEyeVector();
            float dot = new Point3F("0 0 1 ").vectorDot(eye);
            if (dot < 0)
                dot = -dot;

            vec = vec + new Point3F("0 0 8").vecotrScale(1 - dot);
            vec = vec + thisobj.getVelocity();

            TransformF pos = new TransformF(thisobj.getWorldBox().minExtents);
            item.setTransform(pos);
            item.applyImpulse(pos.MPosition, vec);
            item.setCollisionTimeout(thisobj);

            item.call("schedulePop");

            return item;
            }

        #region Nested type: HealthKitHelper

        /// <summary>
        /// Class used to pass the player id and healthkit id to a background
        /// thread which updates the player and then deletes the healthkit.
        /// </summary>
        public class HealthKitHelper
            {
            public HealthKitHelper(string p, string h)
                {
                player = p;
                healthkit = h;
                }

            public string player { get; set; }
            public string healthkit { get; set; }
            }

        #endregion
        }
    }