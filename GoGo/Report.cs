using System;
using System.IO;
using System.Diagnostics;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Mono.Data.Sqlite ;

namespace GoGo
{
	public class Report
	{
		public Report ()
		{

		}

		public void ShowReport(){
		
			string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
			Document document = new Document(PageSize.A4);
			PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
			document.Open();

			PdfPTable table = new PdfPTable(8);


			table.SetWidths (new float[]{0.5f, 1.6f, 2.8f,1.0f,1.0f,1.0f,1.0f,1.0f});

			PdfPCell cell = new PdfPCell(new Phrase("Registro de Gastos"));

			cell.Colspan = 8;

			cell.Border = 0;

			cell.HorizontalAlignment = 1;
		

			table.AddCell(cell);

			string[] headerText = new string[8] { "Id", "Fecha", "Destino", 
				"Cant.","Imp.", "Comb.", "Var.", "Total"};

			for (int x = 0; x < headerText.Length; x++)
			{   
				Font hdrFont = FontFactory.GetFont("Monotype Corsiva", 10, BaseColor.WHITE);
				PdfPCell hdrCell = new PdfPCell(new Phrase(headerText[x], new Font(hdrFont)));
				hdrCell.BackgroundColor = new BaseColor(0, 0, 0);
				hdrCell.BorderColor = new BaseColor(111, 111, 111);
				hdrCell.HorizontalAlignment = 1;
				table.AddCell(hdrCell);             
			}

			SqliteConnection Conn;	
			SqliteCommand cmd;
			SqliteDataReader reader;

			string query="SELECT * FROM tblGastos ORDER BY id DESC;";
		
			try {

				Conn = new SqliteConnection ("Data Source= GoGodb.s3db;Version=3"); 
				Conn.Open ();
				cmd=Conn.CreateCommand();
				cmd.CommandText=query;
				reader = cmd.ExecuteReader ();

				while(reader.Read()){
					table.AddCell(reader["id"].ToString());
					table.AddCell(reader["fecha"].ToString());
					table.AddCell(reader["destino"].ToString());
					table.AddCell(reader["cantidad"].ToString());
					table.AddCell("$"+reader["importe"].ToString());
					table.AddCell("$ "+reader["gasolina"].ToString());
					table.AddCell("$ "+reader["varios"].ToString());
					table.AddCell("$ "+reader["total"].ToString());
				}
				reader.Close();
				Conn.Close();

			}catch (Exception e){
				Console.WriteLine("The process failed: {0}", e.ToString());
			}
			document.Add(table);
			document.Close();

			Process prc = new System.Diagnostics.Process();
			prc.StartInfo.FileName = fileName;
			prc.Start();

		}

	}}

