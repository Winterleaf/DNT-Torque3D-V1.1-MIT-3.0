DNT 1.1 Update Notes
1.  C++ T3D objects are now implemented in C#
    a.	The C++ InitPersist definitions in SimObjects are exposed as properties
        i.	<co<Object> instance>.<InitPersist Field> = <String>
       ii.	Example: npc["HoldAndFire"] = true.AsString();
    b.	C++ Console Methods are now defined off the implemented C# class
        i.	<co<Object> instance>.<Some Console Function>(<Parameters>);
       ii.	Example: npc.mountImage("LurkerWeaponImage", 0, true, "");
      iii.	Full intellisense
    c.	Class Hierarchy` follows the same Inheritance as C++ classes
        i.	Example inheritance: coPlayerData -> coShapeBaseData->coGameBaseData->coSimDataBlock->coSimObject
       ii.	Member functions are over-ridden properly through inheritance.
    d.	Declaration and Initialization of the new object types
        i.	co<Object> <name> = <string value>
          	Example: coSimSet path = npc["path"];
       ii.	co<Object> <name> = <unsigned integer value>
            Example: uint targetnode = datablock["targetNode"].AsUint();
      iii.	co<Object> <name> = <integer value>
           	Example: coShapeBaseData datablock = shapebase.getDataBlock();
    e.	Properties of the object can be referenced using []
        i.	Example: npc["HoldAndFire"] = false.AsString();
2.	Functions can now take the co<Object> types as parameters
    a.	Example:
        [Torque_Decorations.TorqueCallBack("", "AIPlayer", "getNearestPlayerTarget", "(%this)", 1, 2500, false)]
        public int AIPlayergetNearestPlayerTarget(coAIPlayer npc)
3.	Global variables now have shorthand notation
    a.	bGlobals[<Variable Name>] - Sets or gets a script variable as a bool
    b.	sGlobals[<Variable Name>] - Sets or gets a script variable as a string
    c.	iGlobals[<Variable Name>] - Sets or gets a script variable as a integer
    d.	fGlobals[<Variable Name>] - Sets or gets a script variable as a float
    e.	dGlobals[<Variable Name>] - Sets or gets a script variable as a double
4.	C# Containers have been expanded and now include:
    a.	AngAxisF
    b.	Box3F
    c.	ColorF
    d.	ColorI
    e.	EaseF
    f.	Point2F
    g.	Point2I
    h.	Point3F
    i.	Point4F
    j.	Polyhedron
    k.	RectF
    l.	RectI
    m.	RectSpacingI
    n.	TransformF
    o.	Vector
5.	Added C++ for AI detection to speed up finding targets using coAIPlayer
    a.	Function Name: AISearchSimSet
    b.	Parameters:
        1.	Viewing Angle
        2.	Distance
        3.	SimSet of coPlayers to search
        4.	SimSet to return what is found
    c.	Example: npc.AISearchSimSet(180, 50, MobSearchGroup, MobSearchGroupResult);




Torque 3D Project Manager 2.0 Set Up
------------------------------------

1. If you are still using Torque 3D 1.2's Toolbox, remove the existing Torque 3D Toolbox.exe file and the four Qt .dll files from your Torque 3D repo.

2. Copy Project Manager.exe and projects.xml into your Torque 3D repo.

3. Also copy QtCore4.dll, QtGui4.dll, QtNetwork4.dll and QtXml4.dll into your Torque 3D repo.


Using Project Manager
---------------------

1. Double click Project Manager.exe to start it up.

2. Click on the New Project button to create a project from an existing Torque 3D template.  You may also choose which modules you would like to include with your project.

3. With a project selected, click on the Open Folder button to open a new window at the project's location.

4. With a project selected, click on the Modules button to change which modules will be part of your project.  The window that opens includes a Regenerate button to rebuild your project's files.

5. With a project selected, click on the Regenerate button to regenerate the project's C++ files.  This is the same as launching the generateProjects.bat file.


License
-------

Copyright (c) 2012 GarageGames, LLC

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to
deal in the Software without restriction, including without limitation the
rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
sell copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
IN THE SOFTWARE.
