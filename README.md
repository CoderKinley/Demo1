# LeftMenuPanel Control Library

A custom WinForms control library for .NET 8 that provides a dynamic, collapsible left-side menu panel with nested menu items. The menu supports dark mode, smooth animations, and is populated from JSON data.

## Overview

The LeftMenuPanel control is designed to provide a modern, user-friendly navigation solution for WinForms applications. It features:

- Collapsible menu panel with hamburger icon toggle
- Support for nested menu items (up to 2 levels deep)
- Icons and text for all menu items
- Dynamic population from JSON data source
- Dark mode toggle
- Smooth animations
- Responsive design with scrollbars when needed
- Tooltips for collapsed view

## Installation

### Option 1: NuGet Package

```
Install-Package LeftMenuPanel
```

🧩 Option 1: If the GitHub library contains source code (.cs files)

Download/Clone the Repository

If you haven't already, download the GitHub repo as ZIP or clone it using Git:

bashgit clone https://github.com/username/repo-name.git

Add Existing Project or Files

Open your WinForms project in Visual Studio.
If the repo is a separate project:

Right-click on your solution → Add → Existing Project → select the .csproj file.
Then, right-click your WinForms project → Add → Project Reference → check the newly added project.


If it's just a set of .cs files:

Right-click your project → Add → Existing Item → select the .cs files you need.
## Option 2: Using a Precompiled DLL Library

# Adding a DLL Reference - Detailed Steps
### Step 1: Organize Your Library Files
1. Create a dedicated folder in your project (recommended):
   * Right-click on your project in Solution Explorer
   * Select `Add` → `New Folder`
   * Name it `lib`, `references`, or `external-libs`
   * Copy the `.dll` file into this folder

### Step 2: Add the DLL Reference
#### Method A: Using Solution Explorer
1. Right-click on the `References` or `Dependencies` node in your project
2. Select `Add Reference...`
3. In the Reference Manager dialog:
   * Select the `Browse` tab
   * Click the `Browse...` button
   * Navigate to the folder where you placed the DLL
   * Select the DLL file and click `OK`
   * Ensure the reference is checked in the list
   * Click `OK` to confirm

#### Method B: Using Project Properties
1. Right-click on your project in Solution Explorer
2. Select `Properties`
3. Go to the `References` tab (or `Dependencies` in newer versions)
4. Click `Add` or `Add Reference...`
5. Follow the same browsing steps as Method A

### Step 3: Set Reference Properties (Optional but Recommended)
After adding the reference, you can modify its properties:
1. Click on the newly added reference in Solution Explorer
2. In the Properties window (F4):
   * Set `Copy Local` to `True` (ensures the DLL is copied to your output directory)
   * Verify that `Specific Version` is set appropriately for your needs

### Step 4: Using the Library in Code
1. Add the required namespace at the top of your code files:
   ```csharp
   using LibraryNamespace;  // Replace with the actual namespace of the library
   ```
2. If you're unsure about the namespace:
   * Use Object Browser (View → Object Browser) to explore the DLL
   * Or try an IDE like JetBrains dotPeek to inspect the DLL contents

### Step 5: Check Build Configuration
1. Make sure the DLL is compatible with your project's target framework
2. For platform-specific DLLs, ensure your project's platform target matches (x86, x64, or Any CPU)
3. Build your project to verify the reference is working correctly

### Troubleshooting Common Issues
- **"Could not load file or assembly..."** error: Ensure the DLL and all its dependencies are accessible
- **Missing dependencies**: Some DLLs require additional libraries; check documentation
- **Version conflicts**: Make sure the DLL version is compatible with your .NET version
- **Reference not working**: Try restarting Visual Studio after adding references
### Option 2: Manual DLL Reference

1. Download the `LeftMenuPanel.dll` file
2. In Visual Studio, right-click on your project's References
3. Select "Add Reference..." and browse to the downloaded DLL

## Usage

### Adding the Control to Your Form

```csharp
using LeftMenuPanel;

// In your Form's constructor or InitializeComponent method
private void InitializeComponent()
{
    // Other form initialization code
    
    // Create the menu panel
    var menuPanel = new LeftMenuPanel.MenuPanel();
    menuPanel.Dock = DockStyle.Left;
    this.Controls.Add(menuPanel);
    
    // Load menu from JSON
    menuPanel.LoadMenuFromJson("path/to/your/menu.json");
}
```
## LeftMenuPanel Configuration

This project demonstrates how to configure and use a collapsible left menu panel in a Windows application. The menu is dynamic, data-driven via JSON, and supports custom icon directories.

## Features

Below is a breakdown of how to set up and initialize the `LeftMenuPanel`:

### Set Expanded Width

```csharp
leftMenuPanel.ExpandedWidth = 200;
```

Description: Defines the width of the menu panel when it is in the expanded state.
Value: 200 pixels

### Set Collapsed Width

```csharp
leftMenuPanel.CollapsedWidth = 60;
```

Description: Sets the width of the menu panel when it is collapsed.
Value: 60 pixels

### Set Animation Step

```csharp
leftMenuPanel.Step = 60;
```

Description: Defines the pixel step for the expand/collapse animation. This value controls how quickly the menu resizes during animation.
Value: 60 pixels per animation tick

### Set Menu File Path

```csharp
leftMenuPanel.MenuFilePath = "Resources/Menu.json";
```

Description: Specifies the path to the JSON file containing the menu structure.
Note: The JSON file should define items with names and corresponding icons.

### Set Menu Icons Path

```csharp
leftMenuPanel.MenuImagePath = "Resources/MenuIcons";
```

Description: Directory path for menu icons. Each icon file name should match the icon name referenced in Menu.json.

### Load Menu from JSON

```csharp
leftMenuPanel.LoadMenu();
```

Description: Loads the menu items from the provided JSON file and populates the menu UI.

### Handle Menu Item Click

```csharp
leftMenuPanel.MenuItemClicked += LeftMenuPanel_MenuItemClicked;
```

Description: Subscribes to the MenuItemClicked event. This allows you to define custom logic when a menu item is clicked.

Example Event Handler:

```csharp
private void LeftMenuPanel_MenuItemClicked(object sender, MenuItemEventArgs e)
{
    MessageBox.Show($"You clicked on: {e.MenuItemName}");
}
```
### JSON Structure

The menu data should be structured as follows:

```json
{
  "MenuItems": [
    {
      "Id": "1",
      "Text": "Dashboard",
      "Icon": "dashboard.png",
      "SubItems": []
    },
    {
      "Id": "2",
      "Text": "Users",
      "Icon": "users.png",
      "SubItems": [
        {
          "Id": "2.1",
          "Text": "User Management",
          "Icon": "user_management.png",
          "SubItems": []
        },
        {
          "Id": "2.2",
          "Text": "User Reports",
          "Icon": "user_reports.png",
          "SubItems": []
        }
      ]
    }
  ]
}
```

### Event Handling

To handle menu item clicks:

```csharp
menuPanel.MenuItemClicked += (sender, e) => {
    // e.MenuItemId contains the ID of the clicked item
    // e.Text contains the text of the clicked item
    Console.WriteLine($"Menu item clicked: {e.Text} (ID: {e.MenuItemId})");
    
    // Update your main content area based on the selected menu item
    UpdateMainContent(e.MenuItemId);
};
```

### Customization

#### Toggle Dark Mode

```csharp
menuPanel.DarkMode = true; // or false for light mode
```

#### Programmatically Collapse/Expand

```csharp
menuPanel.Collapsed = true; // Collapse the menu
menuPanel.Collapsed = false; // Expand the menu
```

#### Custom Colors

```csharp
// Set custom colors for the menu
menuPanel.BackgroundColor = Color.FromArgb(40, 44, 52);
menuPanel.TextColor = Color.White;
menuPanel.HoverColor = Color.FromArgb(61, 67, 79);
menuPanel.ActiveItemColor = Color.FromArgb(97, 175, 254);
```

## Implementation Details

### Core Components

1. **MenuPanel**: The main container for the left menu
2. **MenuItemControl**: Individual menu item controls with icons and text
3. **JsonMenuLoader**: Handles loading and parsing of menu data from JSON
4. **MenuCollapseManager**: Manages the collapse/expand behavior and animations

### Design Patterns Used

- **Factory Pattern**: For creating menu item controls from JSON data
- **Observer Pattern**: For notifying subscribers about menu item clicks
- **Strategy Pattern**: For handling different menu item types and behaviors
- **Decorator Pattern**: For adding visual effects to menu items (hover, active state)

### Error Handling

The library implements robust error handling for common scenarios:

1. **Invalid JSON**: Graceful error messages when JSON cannot be parsed
2. **Missing Icons**: Fallback to default icons when specified icons are not found
3. **Excessive Nesting**: Visual feedback for menu items with more than 2 levels of nesting
4. **Layout Issues**: Automatic adjustment with scrollbars for overflow content

## Performance Considerations

- Menu items are created dynamically only when needed
- Memory usage is optimized by reusing components where possible
- Smooth animations are implemented using efficient timer-based approaches
- Rendering is optimized to minimize flickering and visual artifacts

## Technical Requirements

- .NET 8 or above
- WinForms application
- C1.AdoNet.JSON package from NuGet.org for JSON integration

## Troubleshooting

### Common Issues

1. **Menu items not appearing**: Ensure your JSON file is formatted correctly and all required fields are present
2. **Icons not showing**: Verify the icon paths in your JSON are correct and accessible
3. **Animation stuttering**: Reduce complexity of your menu structure or adjust animation speed
4. **Layout issues**: Ensure proper container sizing and docking properties

### Debug Logging

Enable debug logging for troubleshooting:

```csharp
menuPanel.EnableDebugLogging = true;
```


-------------------------------------------------------------------------------------
# WinFormsApp1 - LeftMenuPanel Integration

This guide explains how to integrate the LeftMenuPanel from LeftMenuPanelLibrary into a Windows Forms Application.

## Prerequisites

- Visual Studio
- .NET 6 or later (or compatible WinForms project)
- Reference to LeftMenuPanelLibrary (either DLL or project reference)
- FontAwesome.Sharp NuGet package

## Steps to Add LeftMenuPanel

### 1. Add the Required Libraries

Make sure the following namespaces are added at the top of Form1.Designer.cs:

```csharp
using LeftMenuPanelLibrary;
using FontAwesome.Sharp;
```

Also, add `FontAwesome.Sharp` via NuGet if it's not already present:

```
Install-Package FontAwesome.Sharp
```

### 2. Declare the LeftMenuPanel Control

In the `Form1` partial class (inside `Form1.Designer.cs`), declare the `leftMenuPanel` control:

```csharp
private LeftMenuPanelLibrary.LeftMenuPanel leftMenuPanel;
```

### 3. Initialize the LeftMenuPanel

Inside the `InitializeComponent` method, before setting up `panel1`, create and configure the `leftMenuPanel`:

```csharp
leftMenuPanel = new LeftMenuPanelLibrary.LeftMenuPanel();
leftMenuPanel.AutoSize = true;
leftMenuPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
leftMenuPanel.CollapsedWidth = 60;
leftMenuPanel.ExpandedWidth = 200;
leftMenuPanel.Dock = DockStyle.Left;
leftMenuPanel.MenuFilePath = "FilePath..."; // Add your actual file path
leftMenuPanel.MenuImagePath = "Folder Name..."; // Add your actual image folder path
leftMenuPanel.Name = "leftMenuPanel";
leftMenuPanel.Size = new Size(227, 450);
leftMenuPanel.TabIndex = 0;
```

### 4. Adjust the Main Panel to the Right of the Menu

Modify `panel1` so it docks to fill the remaining space **after** the menu:

```csharp
panel1.Dock = DockStyle.Fill;
panel1.Location = new Point(227, 0); // Shift right to leave space for menu
```

### 5. Add Controls to the Form

Finally, in the `Form1` constructor or `InitializeComponent`, ensure the controls are added in the correct order:

```csharp
this.Controls.Add(panel1); // Main content
this.Controls.Add(leftMenuPanel); // Left menu panel
```

### 6. Build and Run

Run the application. You should see:
* A collapsible left menu on the left.
* Main content panel occupying the rest of the form.
