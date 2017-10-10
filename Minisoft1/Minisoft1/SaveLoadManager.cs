/*
 * Created by SharpDevelop.
 * User: Martin
 * Date: 8.10.2017
 * Time: 11:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Minisoft1
{
	/// <summary>
	/// Description of SettingsManager.
	/// </summary>
	public class SaveLoadManager
	{
		public SaveLoadManager()
		{
		}
		
		public Settings load()
		// loads settings from file to list
		{
			if (File.Exists("settings.dat")) 
			{ 
				Settings settings;
				FileStream s = new FileStream("settings.dat", FileMode.Open);
				BinaryFormatter f = new BinaryFormatter();
				settings = f.Deserialize(s) as Settings;
				s.Close();
				return settings;
			}
			return null;	
		}
		
		public void save(Settings settings)
		// saves list of values to file
		{
			FileStream s = new FileStream("settings.dat", FileMode.Create);
			BinaryFormatter f = new BinaryFormatter();
			f.Serialize(s, settings);
			s.Close();				
		}		
	}
}
