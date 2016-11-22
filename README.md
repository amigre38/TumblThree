# TumblThree - A Tumblr Blog Backup Application

TumblThree is the code rewrite of [TumblTwo](https://github.com/johanneszab/TumblTwo), a free and open source Tumblr blog backup application, using C# with WPF and the MVVM pattern. It uses the [Win Application Framework (WAF)](https://github.com/jbe2277/waf). It downloads photo, video, audio and text posts from a given tumblr blog.

### New Features (over TumblTwo):
* Internationalization support.
* Autosave of the queuelist.
* Save, clear and restore the queuelist.
* Download of text, audio, quote, conversation and link posts.
* Download meta information for photo, video and audio posts.
* Set a time interval for a automatic download (e.g. during nights).
* Preview of photos & videos.
* Taskbar buttons and key bindings.

### New Features (over TumblOne):
* Multiple simultaneous picture downloads of a single blog.
* Multiple simultaneous downloads of different blogs, customizable in the settings.
* Download of tumblr.com hosted videos.
* It is possible to download images from blogs only for specific tags.
* A clipboard monitor that detects *http(s):// .tumblr.com* urls in the clipboard (copy and paste) and automatically adds the blog to the bloglist.
* A download queue for blogs.
* A detection if the blog is still online or the owner has changed.
* The blogview is now sortable and shows more information, e.g. date added, last time finished and the progress.
* A settings panel (change download location, turn preview off/on, define number of simultaneous downloads, set the imagesize of downloaded pictures, etc.).
* Source code at github (Written in C# using WPF and MVVM).

## Screenshot:
![TumblThree Main UI](http://www.jzab.de/sites/default/files/images/tumblthree.png?raw=true "TumblThree Main UI")

### Application Usage: ###

* Usage
  * extract the .zip file and run the application by double clicking TumblThree.exe. The application now comes as a zip file as some parts of it are modular .dll files like internationalization support.
  * To use the application, simply copy the url of any tumblr.com blog you want to backup from into the textbox at the bottom. Afterwards, click on 'Add Blog' on the right of it.
  * To start the download process, click on 'Crawl'. The application will regularly check for (new) blogs in the queue and start processing them, until you stop the application by pressing 'Stop'. So, you can either add blogs to the queue via 'Add to Queue' first and then click 'Crawl', or you start the download process first and add blogs to the queue afterwards.
  * A green bar left to the blog in the queue indicates a actively downloaded blog.
  * You can set up more than one parallel download in the 'Settings'. Also, it is possible to change the download location and the sizes of the picture and video files to download. It is possible to setup a timer for automatic start of the download. 
  * In the Details window you can view statistics of your blog and set blog specific options. You can choose here what kind of post type (photo, video, audio, text, conversation, quote, link) to download.
  
* Tags

  * You can also download only tagged images by adding tags in a comma separated list in the tag column of the blog list in the top. For example: _great big car,bears_ would search for images that are tagged for either a _great big car_ or _bears_ or both.

* Speed

  * If the download stalls after a period of time and just finishes incompletely, you might have to lower the Number of parallel connections in the settings panel. Most likely the application has opened too many connections to the tumblr network which were timed out and got closed by the servers. Try to redownload with lower values. The applications restarts where it left off.
  * Otherwise, if the download speeds are not satisfied, you may increase the value.

* Key Mappings

  * Currently mapped keys are: 
    * space -- start crawl
    * ctrl-space -- pause crawl
    * shift-space -- stop crawl
    * del -- remove blog from queuelist
    * shift-del -- remove blog from blogmanager.
	
* Saved Settings

  * Application settings are stored in _C:\Users\"Username"\AppData\Local\TumblThree_. 
  * For each blog there is also an index file in the download location (default: in the _.\Blogs\_ folder relative to the executable) named after the _blogname_.tumblr. Here are blog relative information stored like what files have been downloaded, the url of the blog and when it was added. This allows you to move your downloaded files (photos, videos, audio files) to a different location without interfering with the backup process.

### Current Limitations: ###

* The old datasets from TumblTwo and TumblOne are NOT compatible yet.
* No more support for Windows XP.
 
### How To Build The Source Code To Help Further Developing: ###

* Download [Visual Studio](https://www.visualstudio.com/vs/community/).
* Download the [source code as .zip file](https://github.com/johanneszab/TumblThree/archive/master.zip) or use the [GitHub Desktop](https://desktop.github.com/) and [checkout the code](https://github.com/johanneszab/TumblThree.git).
* Open the TumblThree.sln solution file in the src/ directory of the code.
* Build the Source once before editing anything. Build->Build Solution.
 
### New Feature Request: ###

* [See the Wiki page for ideas of new or missing features](https://github.com/johanneszab/TumblThree/wiki/New-Feature-Requests-and-Possible-Enhancements) and add your thoughts.
