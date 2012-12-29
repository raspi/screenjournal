using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.IO;

/// <summary>
/// System.Configuration based configuration loading/saving
/// </summary>

namespace screenjournal
{
	// Elements
	// directory, interval, ..
	public class ApplicationConfigElement : ConfigurationElement
	{
		public ApplicationConfigElement()
		{ 
		}

		/// <summary>
		/// Gets or sets the directory where screenshots are saved.
		/// </summary>
		[ConfigurationProperty("directory", DefaultValue = "", IsRequired = true)]
		public string directory
		{
			get {return (string)this["directory"];}
			set {this["directory"] = value;}
		}

		/// <summary>
		/// Gets or sets the interval of seconds when screenshots are taken.
		/// </summary>
		[ConfigurationProperty("interval", DefaultValue = 300, IsRequired = true)]
		public int interval
		{
			get {return (int) this["interval"];}
			set {this["interval"] = value;}
		}
	}

	// Section that has Elements inside it
	public class ApplicationConfigSection : ConfigurationSection
	{
		public ApplicationConfigSection()
		{
		}
		
		[ConfigurationProperty("cfg")]
		public ApplicationConfigElement ConfigElement
		{
			get {return (ApplicationConfigElement) this["cfg"];}
			set {this["cfg"] = value;}
		}
	}


	public static class AppCfg
	{
		static readonly string sectionName = "cfg";

		public static Configuration getConfiguration()
		{
			string configFile = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "\\" + Assembly.GetEntryAssembly().GetName().Name + ".config";
			
			if(!File.Exists(configFile))
			{
				File.Create(configFile);
			}
			
			return ConfigurationManager.OpenExeConfiguration(configFile);

		}


		public static ApplicationConfigSection LoadConfiguration()
		{
			var config = getConfiguration();

			ApplicationConfigSection customSection = (ApplicationConfigSection)config.GetSection(sectionName);
			customSection =	(ApplicationConfigSection)config.GetSection(sectionName);

			string defaultDirectory = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures), Assembly.GetEntryAssembly().GetName().Name);

			bool modified = false;

			if (customSection == null)
			{
				// Generate default values
				modified = true;

				// Generate the default directory to user's Pictures directory
				Directory.CreateDirectory(defaultDirectory);

				customSection = new ApplicationConfigSection();
				customSection.ConfigElement.interval = 300;
				customSection.ConfigElement.directory = defaultDirectory;

			}

			if (!Directory.Exists(customSection.ConfigElement.directory))
			{
				// Non-existing directory, revert to default
				modified = true;
				customSection.ConfigElement.directory = defaultDirectory;
			}

			if (customSection.ConfigElement.interval <= 0)
			{
				// interval is too low
				modified = true;
				customSection.ConfigElement.interval = 1;
			}

			if (modified)
			{
				config.Sections.Add(sectionName, customSection);
				config.Save(ConfigurationSaveMode.Modified);
			}

			return customSection;

		}

		public static void SaveConfiguration(ApplicationConfigSection section)
		{
			var config = getConfiguration();

			config.Sections.Remove(sectionName);
			config.Sections.Add(sectionName, section);
			config.Save(ConfigurationSaveMode.Modified);

		}
		
	}
}
