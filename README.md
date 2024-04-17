# uni3-4

This is a repository containing a collection of 14 Windows Form projects completed during our university class. These projects cover a range of topics and demonstrate various concepts in C# programming. Each project is designed to showcase different aspects of Windows Forms application development, providing a comprehensive learning experience for students.
Projects Overview

 **Project 1**: Controls
        The foundation of a Windows interface is represented by controls. These controls can be hosted by a container, which can be a form or another control. Controls derive from System.Windows.Forms and are responsible for rendering a portion of the container.
 
  **Project 2**: Value Controls
        Value controls such as label, textbox, and picturebox display information to the user. Labels are used for displaying text on a form, while textboxes allow users to input text. Picturebox is used for displaying images.
 
  **Project 3**: Selection Controls
        CheckBoxes and RadioButtons are selection controls with a Checked property indicating the selection state. They trigger the Checked event upon state change. When ThreeState property is set, it allows for a third state, and the CheckState property determines the state of the control.
 
  **Project 4**: LinkLabel
        LinkLabel displays text with certain parts drawn as hyperlinks. LinkClicked event is handled to make the link functional.
        
  **Project 5**: List Controls
        List controls such as ListBox, CheckedListBox, ComboBox, and ImageList can be bound to a DataSet, ArrayList, or any array-like data source.
        
  **Project 6**: PV6 Application
        Demonstrates the use of the ImageList control. The "Draw" button adds *.gif files from the specified folder to the list and displays them. The "Animate" button animates the *.gif files using PictureBox.
        
  **Project 7**: MonthCalendar
        Displays a calendar for selecting a date graphically. Important properties include MinDate, MaxDate, and TodayDate. Exposes DateSelected and DateChanged events for handling date selection.
        
  **Project 8**: ListView
        Used to display a collection of items in different views. Properties like View, LargeImageList, and Columns control its appearance.
        
  **Project 9**: Execution Controls
        Controls for controlling execution (Timer) or dialogs (OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, ContextMenu).
        
  **Project 10**: Container Controls
        GroupBox, Panel, and TabControl are containers for other controls. PV10 simulates toy store command submission using TabPages for categorization.
        
  **Project 11**: Menu Controls
        MenuStrip and ContextMenuStrip represent menu controls. MainMenuStrip property specifies the main menu. Switching menus dynamically is possible during runtime.
        
  **Project 12**: System.Drawing
        Contains types for 2D drawing essential for graphical user interface design.
        
  **Project 13**: PV13 Example
        Constructs an icon based on an image. Demonstrates loading an image and drawing it on a form.
        
  **Project 14**: Multiple Choice Test Generator
        Generates multiple-choice tests from a text file, including questions, answers, distractors, and associated images. Displays the test result and response statistics afterward.

Getting Started

To get started with any of the projects, simply clone this repository to your local machine and open the respective project solution file in Visual Studio. Each project is self-contained within its own directory and solution file, making it easy to navigate and work with.
Prerequisites

    Visual Studio (2015 or later)
    .NET Framework (4.5 or later)

Running the Projects

    Open Visual Studio.
    Navigate to the directory of the desired project.
    Open the solution file (.sln) in Visual Studio.
    Build and run the project using the Visual Studio debugger.

Contributing

If you'd like to contribute to any of the projects, feel free to fork this repository, make your changes, and submit a pull request. Contributions such as bug fixes, enhancements, and additional features are always welcome!

License
These projects are provided under the MIT License, allowing you to freely use and modify them for both personal and commercial purposes.

Acknowledgements
Special thanks to our university instructors for guiding us through these projects and providing valuable insights into Windows Forms application development in C#.
