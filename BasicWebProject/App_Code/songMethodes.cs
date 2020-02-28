using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BasicWebProject.App_Code
{
    public class songMethodes
    {
    }

    public DataSet GetAllSongs(string file)
    {
        DataSet ds = new DataSet("playlist");

        DataTable dtSongs = new DataTable("songs");
        
        DataColumn dcId = new DataColumn("id");
        DataColumn dcArtist = new DataColumn("artist");
        DataColumn dcTitle = new DataColumn("title");
        DataColumn dcYear = new DataColumn("year");
        DataColumn dcGenre = new DataColumn("genre");
        DataColumn dcTime = new DataColumn("time");
        DataColumn dcFile = new DataColumn("file");
    }
}