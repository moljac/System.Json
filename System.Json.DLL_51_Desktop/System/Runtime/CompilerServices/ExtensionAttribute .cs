using System;
using System.Collections.Generic;
using System.Text;

namespace System.Runtime.CompilerServices
{
	/// <summary>
	/// Extension methods not available in netfx 3.0
	/// 
	/// If target framework version is less than 3.5 using extension methods cause
	/// following compilation error:
	/// 
	/// Cannot define a new extension method because the compiler required type 
	/// 'System.Runtime.CompilerServices.ExtensionAttribute' cannot be found. 
	/// Are you missing a reference to System.Core.dll?
	/// 
	/// System.Core.dll is new to V3.5 of the .NET Framework and ExtensionAttribute 
	/// is defined in this assembly, so there are no surprises that we receive this 
	/// compilation error, as System.Core.dll cannot be found.
	/// 
	/// With reflector:
	/// 
	/// [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]  
	/// public sealed class ExtensionAttribute : Attribute  
	/// {  
	/// }
	/// 
	/// To make extension methods to work, create attribute in the System.Runtime.CompilerServices 
	/// namespace, as follows:
	/// 
	/// namespace System.Runtime.CompilerServices
	/// {
	///     [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]    
	///     public sealed class ExtensionAttribute : Attribute
	///     {
	///     }
	/// }

	/// </summary>
	/// <see cref="http://www.c-sharpcorner.com/uploadfile/pcurnow/extension-methods-under-net-framework-v2-and-v3/"/>
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]
	public sealed class ExtensionAttribute : Attribute
	{
	}
}
