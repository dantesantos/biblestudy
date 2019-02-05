# The Bible Study
<p>The purpose of this site is offer to those people that want to go deep into the bible verses and know more about it.</p>
<p>Although I could go further with some new features that I learned I couldn't finish the page due to persistent errors.</p>
<p></p>
<p>There is a problem between what the files generates and what the Web App created on Azure shows. On the Web App, for example,
the images and the buttons that leads you to the chapters don't appear.</p>
<p>Some features learned:</p>
<ul>
  <li>List<object> myModel = new List<object>();
            myModel.Add(db.ChapterQties.ToList());
            myModel.Add(db.VerseContents.ToList());
            return View(myModel); = This is used to create the objects and push the models inside them
  </li>
  <li>
    @Url.Action() = It generates a URL as per provided action name, contrillername, route object.
  </li>
  <li>
    @Html.DisplayNameFor() = shows the name of the property or the string defined in the display attribute for the property.
  </li>
  <li>
    @Html.DisplayFor() = shows the value of the field.
  </li>
</ul>

