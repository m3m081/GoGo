using System;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using Gtk;



namespace GoGo
{
	public class DbUtils
	{
		public SqliteConnection Conn;	
		public SqliteCommand cmd;
		public SqliteDataReader reader;
		public SqliteDataAdapter adapt;

		public string query1;

		ListStore item;

		public DbUtils ()
		{
			Console.Write("Constructor Invocado");
		}

		private Boolean checkfile(string f){
			//Verifica que exista el archivo 
			string path = Directory.GetCurrentDirectory ();
			string s = path + "/" + f;
			Boolean b=false;

			Console.Write("Path: "+ s);

			if (File.Exists(s)){
				Console.Write("Se encontro el archivo: " + f);
				b= true;
			}else{
				Console.Write("No se encontro el archivo: " + f);
				b=false;
			}

			return b;
		}

		public void CheckDB(){
			if (checkfile ("GoGodb.s3db") == false) {
				try{
					CreateDB();
				}catch (Exception e){
					Console.WriteLine("The process failed: {0}", e.ToString());
				}
			}
		}

		public void Connect(){

			Conn = new SqliteConnection ("Data Source= GoGodb.s3db;Version=3"); 
			Conn.Open ();
			Console.WriteLine("Conexion a DB abierta /n");
		
		}

		public void CreateDB(){
			query1= "CREATE TABLE tblGastos01" +
				"( id integer not null primary key," +
				"fecha text,destino text not null, " +
				"cantidad integer,importe real,gasolina real," +
				"varios real,total real );";

			SqliteConnection.CreateFile ("GoGo.s3db");
			Connect ();
			Console.WriteLine("Conexion a DB abierta /n");
			cmd=Conn.CreateCommand();
			cmd.CommandText=query1;
			cmd.ExecuteNonQuery();
			cmd.Dispose();

			query1= "CREATE TABLE tblGastos02" +
				"( id integer not null primary key," +
				"fecha text,destino text not null, " +
				"cantidad integer,importe real,gasolina real," +
				"varios real,total real );"; 

			cmd=Conn.CreateCommand();
			cmd.CommandText=query1;
			cmd.ExecuteNonQuery();

			Console.WriteLine("Tablas Creadas /n");
			Disconnect();
		}
	
		public void Insert(string fecha,string destino,string cantidad,string importe,string gasolina,string varios,string total){

			Connect ();

			cmd=Conn.CreateCommand();
			String query = "INSERT INTO  tblGastos (fecha,destino,cantidad,importe,gasolina,varios,total) " +
				"VALUES (?,?,?,?,?,?,?)";

			SqliteParameter Date= new SqliteParameter();
			SqliteParameter Dest= new SqliteParameter();
			SqliteParameter Qty= new SqliteParameter();
			SqliteParameter Import= new SqliteParameter();
			SqliteParameter Gas= new SqliteParameter();
			SqliteParameter Various= new SqliteParameter();
			SqliteParameter Total= new SqliteParameter();

			cmd.Parameters.Add (Date);
			cmd.Parameters.Add (Dest);
			cmd.Parameters.Add (Qty);
			cmd.Parameters.Add (Import);
			cmd.Parameters.Add (Qty);
			cmd.Parameters.Add (Various);
			cmd.Parameters.Add (Total);

			Date.Value = fecha;
			Dest.Value = destino;
			Qty.Value = int.Parse (cantidad);
			Import.Value = float.Parse (importe);
			Gas.Value = float.Parse (gasolina);
			Various .Value = float.Parse (varios );
	    	Total .Value = float.Parse (total );

			cmd.CommandText=query;
			cmd.ExecuteNonQuery();
			Console.WriteLine("Insercion de datos realizada /n");

			Disconnect();
		}
		public void Update(string fecha,string destino,string cantidad,string importe,string gasolina,string varios,string total,int id){

			Connect ();

			cmd=Conn.CreateCommand();

			String query = "UPDATE tblGastos SET fecha=?,destino=?,cantidad=?,importe=?,gasolina=?,varios=?,total=? WHERE id=?";

			SqliteParameter Date= new SqliteParameter();
			SqliteParameter Dest= new SqliteParameter();
			SqliteParameter Qty= new SqliteParameter();
			SqliteParameter Import= new SqliteParameter();
			SqliteParameter Gas= new SqliteParameter();
			SqliteParameter Various= new SqliteParameter();
			SqliteParameter Total= new SqliteParameter();
			SqliteParameter Id= new SqliteParameter(); 

			cmd.Parameters.Add (Date);
			cmd.Parameters.Add (Dest);
			cmd.Parameters.Add (Qty);
			cmd.Parameters.Add (Import);
			cmd.Parameters.Add (Qty);
			cmd.Parameters.Add (Various);
			cmd.Parameters.Add (Total);
			cmd.Parameters.Add (Id);

			Date.Value = fecha;
			Dest.Value = destino;
			Qty.Value = int.Parse (cantidad);
			Import.Value = float.Parse (importe);
			Gas.Value = float.Parse (gasolina);
			Various .Value = float.Parse (varios );
			Total .Value = float.Parse (total );
			Id.Value = id ;

			cmd.CommandText=query;
			cmd.ExecuteNonQuery();
			Console.WriteLine("Actualizacion de datos realizada /n");

			Disconnect();
		}
		public void Delete( int key ){
			Connect ();
			cmd=Conn.CreateCommand();
			query1 = "DELETE FROM tblGastos WHERE id=?";
			SqliteParameter Id= new SqliteParameter(); 
			cmd.Parameters.Add (Id);

			Id.Value = key;

			cmd.CommandText=query1;
			cmd.ExecuteNonQuery();

			Console.WriteLine("Registro Borrado /n");
			Disconnect();
		}
        public ListStore LoadData(){

			item = new ListStore(typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

			string query="SELECT * FROM tblGastos ORDER BY id DESC;";

			try {
				Connect ();
				item.Clear ();
				cmd=Conn.CreateCommand();
				cmd.CommandText=query;
				reader = cmd.ExecuteReader ();
				while(reader.Read()){
					item.AppendValues(reader["id"].ToString(),reader["fecha"].ToString(),reader["destino"].ToString(),reader["cantidad"].ToString(),reader["importe"].ToString(),reader["gasolina"].ToString(),reader["varios"].ToString(),reader["total"].ToString());
				}
				reader.Close();
				Disconnect();
			}catch (Exception e){
				Console.WriteLine("The process failed: {0}", e.ToString());
			}
			return item;
    	}

		public void Disconnect(){
			Console.WriteLine("Conexion Cerrada /n");
			Conn.Close ();
		}
	}
}

