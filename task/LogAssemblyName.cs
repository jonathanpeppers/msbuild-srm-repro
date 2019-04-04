using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace task
{
	public class LogAssemblyName : Task
	{
		public override bool Execute ()
		{
			using (var reader = new PEReader (File.OpenRead (GetType ().Assembly.Location))) {
				var metadata = reader.GetMetadataReader ();
				var assembly = metadata.GetAssemblyDefinition ();
				var name = assembly.GetAssemblyName ();
				Log.LogMessage (MessageImportance.High, $"Assembly Name: {name}");
			}
			return true;
		}
	}
}
