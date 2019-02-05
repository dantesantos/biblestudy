using BibleStudy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BibleStudy.Controllers
{
    public class AuthorsController : Controller
    {
        public DbBible db = new DbBible();
        
        // GET: Authors
        public ActionResult Authors()
        {
            List<object> myModel = new List<object>();
            myModel.Add(db.ChapterQties.ToList());
            myModel.Add(db.VerseContents.ToList());
            return View(myModel);
        }

        public ActionResult John()
        {
            Authors();
            ViewBag.Message = "The author is the apostle John, " + "\"" + " the disciple whom Jesus loved" + "\"" + 
                " (13:23 [see note there]; 19:26; 20:2; 21:7,20,24). He was prominent in the early church but is not " +
                "mentioned by name in this Gospel -- which would be natural if he wrote it, but hard to explain otherwise. " +
                "The author knew Jewish life well, as seen from references to popular Messianic speculations (see, e.g., " +
                "1:21 and note; 7:40-42), to the hostility between Jews and Samaritans (see 4:9 and note), and to Jewish customs, " +
                "such as the duty of circumcision on the eighth day taking precedence over the prohibition of working on the " +
                "Sabbath (see note on 7:22). He knew the geography of the Holy Land, locating Bethany about 15 stadia " +
                "(about two miles) from Jerusalem (11:18) and mentioning Cana, a village not referred to in any earlier " +
                "writing known to us (2:1 [see note there]; 21:2). The Gospel of John has many touches that appear to reflect " +
                "the recollections of an eyewitness -- such as the house at Bethany being filled with the fragrance of the broken " +
                "perfume jar (see 12:3 and note). Early writers such as Irenaeus and Tertullian say that John wrote this Gospel, " +
                "and all other evidence agrees (see Introduction to 1 John: Author).";
            
            return View();
        }

        public ActionResult Matthew()
        {
            Authors();
            ViewBag.Message = "Although the first Gospel is anonymous, the early church fathers were unanimous in holding that Matthew, " +
                "one of the 12 apostles, was its author. However, the results of modern critical studies -- in particular those that stress " +
                "Matthew's alleged dependence on Mark for a substantial part of his Gospel -- have caused some Biblical scholars to abandon " +
                "Matthean authorship. Why, they ask, would Matthew, an eyewitness to the events of our Lord's life, depend so heavily on Mark's" +
                " account? The best answer seems to be that he agreed with it and wanted to show that the apostolic testimony to Christ was " +
                "not divided. " +
                "Matthew, whose name means " + "\"" + "gift of the Lord," + "\"" + "was a tax collector who left his work to " +
                "follow Jesus(9:9 - 13). In Mark and Luke he is called by his other name, Levi.";
            
            return View();
        }

        public ActionResult Mark()
        {
            Authors();
            ViewBag.Message = "Although there is no direct internal evidence of authorship, it was the unanimous testimony of the " +
                "early church that this Gospel was written by John Mark (" + "\"" + "John, also called Mark," + "\"" + "Ac 12:12,25; 15:37)." +
                " The most important evidence comes from Papias (c. a.d. 140), who quotes an even earlier source as saying: (1) " +
                "Mark was a close associate of Peter, from whom he received the tradition of the things said and done by the Lord; " +
                "(2) this tradition did not come to Mark as a finished, sequential account of the life of our Lord, but as the preaching " +
                "of Peter -- preaching directed to the needs of the early Christian communities; (3) Mark accurately preserved this material. " +
                "The conclusion drawn from this tradition is that the Gospel of Mark largely consists of the preaching of Peter arranged " +
                "and shaped by Mark (see note on Ac 10:37).";

            return View();
        }

        //public ActionResult Chapters()
        //{      
        //    var con = db.ChapterQties.ToList();
            
        //    return View(con);            
        //}

        //public ActionResult BuildTable()
        //{
        //    Authors();
        //    var verse = db.VerseContents.ToList();
        //    return View(verse);
        //}



        public ActionResult ViewVerses(string ChapterAuthor)
        {
            ViewBag.ChapterAuthor = ChapterAuthor;
            
            return View();
        }

        
    }
}