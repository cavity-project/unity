﻿using System;
using System.Reflection;

[assembly: CLSCompliant(true)]
[assembly: AssemblyDefaultAlias("Cavity.ServiceLocation.Unity.dll")]
[assembly: AssemblyTitle("Cavity.ServiceLocation.Unity.dll")]

#if (DEBUG)

[assembly: AssemblyDescription("Cavity : Unity Service Location Library (Debug)")]

#else

[assembly: AssemblyDescription("Cavity : Unity Service Location Library (Release)")]

#endif