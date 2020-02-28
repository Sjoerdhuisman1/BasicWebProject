using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace BasicWebProject.App_Code
{
    public class songMethodes
    {
        DataSet ds = new DataSet("Playlist");
        public DataRow GetEmptyDataRow()
        {
            DataRow dr = ds.Tables["songs"].NewRow();
            return dr;
        }

        public void CreateSong(DataRow dataRow, string file)
        {
            ds.Tables["songs"].Rows.Add(dataRow);
            ds.WriteXml(HttpContext.Current.Server.MapPath(file));
        }

       

        public DataSet GetAllSongs(string file)
        {
          //  DataSet ds = new DataSet("Playlist");

            DataTable dtSongs = new DataTable("songs");

            DataColumn dcId = new DataColumn("id");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcTitle = new DataColumn("title");
            DataColumn dcYear = new DataColumn("year");
            DataColumn dcGenre = new DataColumn("genre");
            DataColumn dcTime = new DataColumn("time");
            DataColumn dcFile = new DataColumn("file");

            dtSongs.Columns.Add(dcId);
            dtSongs.Columns.Add(dcArtist);
            dtSongs.Columns.Add(dcTitle);
            dtSongs.Columns.Add(dcYear);
            dtSongs.Columns.Add(dcGenre);
            dtSongs.Columns.Add(dcTime);
            dtSongs.Columns.Add(dcFile);
            ds.Tables.Add(dtSongs);

//ds.ReadXml(file);

            ds.ReadXml(HttpContext.Current.Server.MapPath(file));
            return ds;
        }
    }
}
