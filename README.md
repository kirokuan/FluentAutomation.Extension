# FluentAutomation.Extension
 Add 2 extension method:
 
 1. I.Quit() 
 close current all windows.
 2. I.OpenNewWindow()
	I.OpenNewWindow(url)
Pop up another blank browser or url if url is available
This may be blocked by the browser. 
This can be solved with ('-incognito', '--disable-popup-blocking') enabled
