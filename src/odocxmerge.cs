using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.IO;
using System.Linq;

namespace altChunk
{
	class Program
	{
		static void DocxMerge(string srcFile1, string srcFile2, string outFile)
		{
			File.Delete(outFile);
			File.Copy(srcFile1, outFile);

			using (WordprocessingDocument myDoc =
					WordprocessingDocument.Open(outFile, true))
			{
				string altChunkId = "AltChunkId1";
				MainDocumentPart mainPart = myDoc.MainDocumentPart;
				AlternativeFormatImportPart chunk =
					mainPart.AddAlternativeFormatImportPart(
							AlternativeFormatImportPartType.WordprocessingML,
							altChunkId);

				using (FileStream fileStream = File.Open(srcFile2,
							FileMode.Open))
					chunk.FeedData(fileStream);

				AltChunk altChunk = new AltChunk();
				altChunk.Id = altChunkId;

				mainPart.Document.Body.InsertAfter(altChunk,
						mainPart.Document.Body.Elements<Paragraph>().Last());
				mainPart.Document.Save();
			}
		}

		static void Usage()
		{
			Console.WriteLine("Usage: odocxmerge [FILE1] [FILE2] [OUTPUT]");
		}

		static void Main(string[] args)
		{
			if (args.Length != 3) {
				Usage();
				Environment.Exit(0);
			}

			if (!File.Exists(args[0])) {
				Console.Write(args[0]);
				Console.WriteLine(": file not found.");
				Environment.Exit(1);
			}

			if (!File.Exists(args[1])) {
				Console.Write(args[1]);
				Console.WriteLine(": file not found.");
				Environment.Exit(1);
			}

			DocxMerge(args[0], args[1], args[2]);
		}
	}
}
