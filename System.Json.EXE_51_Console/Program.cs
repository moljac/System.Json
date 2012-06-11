using System;
using System.Collections.Generic;
using System.Text;

namespace System.Json.EXE{
	class Program
	{
		static void Main(string[] args)
		{
			SampleOriginal();

			SampleMSDN_Community();
		}

		private static void SampleOriginal()
		{
			string jsonString =
				"{\"v\":{\"Name\":\"Default\",\"Author\":{\"Name\":\"Jerry\",\"Age\":15},\"Posts\":[{\"Title\":\"Post 1\",\"CreateTime\":\"Fri, 01 Jan 2010 00:00:00 GMT\"},{\"Title\":\"Post 2\",\"CreateTime\":\"Mon, 01 Feb 2010 00:00:00 GMT\"},{\"Title\":\"Post 3\",\"CreateTime\":\"Mon, 01 Mar 2010 00:00:00 GMT\"}]}}";
			JsonValue json = JsonValue.Parse(jsonString);

			JsonValue v = json["v"];
			Console.WriteLine("v[\"Name]\" = {0}", v["Name"]);
			Console.WriteLine("v[\"Name]\" = {0}", v["Name"]);

			// this compiles under VS2010??? 
			// but not under MonoDevelop
			// var???
			var v1 = json["v"];

			return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <see cref="http://msdn.microsoft.com/en-us/library/system.json(v=vs.95).aspx"/>
		public static void SampleMSDN_Community()
		{
			JsonValue json = JsonValue.Parse(@"{""simple"":""value1"",""complex"":{""name"":""value2"",""id"":""value3""}}");

			string simpleValue = json["simple"]; // contains "value1"
			JsonValue complex = json["complex"];
			string nameValue = complex["name"]; // contains "value2"		

			return;
		}
	}
}
