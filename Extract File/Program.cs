using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_File
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = Console.ReadLine();

			string fileName = GetFileName(filePath);
			string fileExtension = GetFileExtension(filePath);

			Console.WriteLine("File name: " + fileName);
			Console.WriteLine("File extension: " + fileExtension);
		}
		static string GetFileName(string filePath)
		{
			int lastSlashIndex = filePath.LastIndexOf('/');
			int lastBackslashIndex = filePath.LastIndexOf('\\');
			int startIndex = Math.Max(lastSlashIndex, lastBackslashIndex) + 1;

			int lastDotIndex = filePath.LastIndexOf('.');
			int length = lastDotIndex - startIndex;

			return filePath.Substring(startIndex, length);
		}

		static string GetFileExtension(string filePath)
		{
			int lastDotIndex = filePath.LastIndexOf('.');
			int length = filePath.Length - lastDotIndex - 1;

			return filePath.Substring(lastDotIndex + 1, length);
		}
	}
}