//	Copyright © 2015, EPSITEC SA, CH-1400 Yverdon-les-Bains, Switzerland
//	Author: Pierre ARNAUD, Maintainer: Pierre ARNAUD

using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Epsitec.Lydia
{
	public class Broken
	{
		[Fact]
		public void Should_Throw_SystemIOFileLoadException()
		{
			var typeName = "Epsitec.Lydia.Broken+Inner, Tests.Lydia.Framework, Version=1.1.0.0, Culture=neutral, PublicKeyToken=2aced0b9a2249607";
			
			System.Diagnostics.Trace.WriteLine ("This type should not be found: ");
			System.Diagnostics.Trace.WriteLine (typeName);

			Assert.Throws<System.IO.FileLoadException> (() => System.Type.GetType (typeName));
		}


		public class Inner
		{
		}
	}
}

