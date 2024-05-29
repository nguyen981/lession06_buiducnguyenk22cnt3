using BdnLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BdnLesson06.Controllers
{
    public class BdnSongController : Controller
    {
        private static List<BdnSong> bdnSongs = new List<BdnSong>() 
        {
            new BdnSong{Id=2200123,BdnTitle="Bui Duc Nguyen", BdnAuthor="K22CNT3",BdnArtist="NTU", BdnYearRelease=2020 },
            new BdnSong{Id=1,BdnTitle="Bui Duc Nguyen", BdnAuthor="K22CNT3",BdnArtist="NTU", BdnYearRelease=2020 }
        };
        // GET: BdnSong
        public ActionResult BdnIndex()
        {
            return View(bdnSongs);
        }
        //Get : BdnCreate
        /// <summary>
        /// Form theem moi bai hat
        /// Author: Bui Duc Nguyen
        /// </summary>
        /// <returns></returns>
        public ActionResult BdnCreate()
        {
            var bdnSong = new BdnSong();
            return View();
        }
    }
}