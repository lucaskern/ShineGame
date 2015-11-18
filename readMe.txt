Harrison Smells -- Fuck you Conner

cd (where ever your Shine Game Folder is)

git pull origin master

Edit Stuff

git status

git add --all

git commit -m "what did you do"

git push origin master

---------------
For Shine2
---------------

Page Switch 
	**YOU DO NOT NEED TO TOUCH Switcher.cs, ISwitchable,
	App, or MainWindow **

	To switch to a new page, call this method
	Switcher.Switch(new <PageYouWant>())

Riddle page
	every .1 seconds, the timer ticks, to line up audio
	with text size change I call text elements fontsize
	at appropriate tick count, e.g. first strum at .5 seconds,
	call property when tick = 5, 3 seconds when tick = 30., etc.

Media Player
	Make a MediaPlayer object named media, then:
	media.Open(new Uri(@"../../Assets/Sound/<soundName>.m4a", UriKind.Relative));
        media.Play();

Invisible button
	for key objects (Subject to change upon implememtation of Inventory)
	use level 1 as a template, grab the button style from the xaml (above grid)
	
	then make a button with that style, change width/height accordingly
	<Button Style="{StaticResource MyButtonStyle}" Content="" Margin="142,544,1032,82"  Width="106" Height="94" Click="Button_Click" Foreground="{x:Null}"/>

Sizing, positioning
	Some images and buttons seem to be shifted from the preview to
	running the program, not sure why but if you fix it thatd be sweet
	probably something stupid.


	