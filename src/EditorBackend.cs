using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoCa_Editor
{
	internal static class EditorBackend
	{
		internal static string Directory = "";
		internal static Dictionary<string,RoWa.LoCa.Language> Languages = new Dictionary<string, RoWa.LoCa.Language>();
		
		internal static void LoadLanguages(string dir)
		{
			Languages.Clear();
			Directory = dir;
			foreach(string fname in System.IO.Directory.GetFiles(dir))
			{
				try
				{
					RoWa.LoCa.Language lang = new RoWa.LoCa.Language(fname);
					Languages.Add(new System.IO.FileInfo(fname).Name, lang);
				}catch(Exception ex)
				{
					
				}
			}
		}

		
	}
}
