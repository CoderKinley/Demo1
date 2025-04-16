# LeftMenuPanel Control Library

A custom WinForms control library for .NET 8 that provides a dynamic, collapsible left-side menu panel with nested menu items. The menu supports dark mode, smooth animations, and is populated from raw JSON data using C1.AdoNet.Json Library from the Component One UI.

## Overview

The LeftMenuPanel control is designed to provide a modern, user-friendly navigation solution for WinForms applications. It features:

- Collapsible menu panel with hamburger icon toggle
- Support for nested menu items (up to 2 levels deep)
- Icons and text for all menu items
- Dynamic population from JSON data source Using C1.AdoNet.Json Library
- Dark/Light mode toggle
- Smooth Animating Side Panel
- Responsive design with scrollbars when needed
- Tooltips for collapsed view, and if there are furthur nestings

---

# WinFormSideMenuControl Solution
## Content 
![image](https://github.com/user-attachments/assets/2ffd1d21-d9ec-4da2-8f45-b53a5bd7d70f)

This library provides a customizable left-side menu panel component for WinForms applications, structured in a modular and maintainable way.

## Folder Structure Overview

The project follows a clean, component-oriented folder layout:

- **Controls/**
  - Contains custom user controls related to the left menu panel UI.

- **Events/**
  - Includes custom event handlers, delegates, and event-related logic.

- **Interface/**
  - Defines interfaces to establish contracts between components and promote loose coupling.

- **Models/**
  - Data structures and models used for representing menu items and configuration.

- **Resources/**
  - Static assets such as images, icons, or Default JSON files.

- **Services/**
  - Core services or business logic that power the behavior of the menu panel.

- **LeftMenuPanel.cs**
  - The main entry point or component that integrates all other parts into a reusable left menu panel.


This solution contains two projects:

## 1. LeftMenuPanelLibrary

This is the actual library project that implements the side menu panel functionality. The library contains:

- Core components for creating customizable side menus in WinForms applications
- Collapsible menu functionality
- Icon support via FontAwesome.Sharp
- Various customization options

## 2. WinFormSideMenuControl

This is a demo application that showcases how to implement and use the LeftMenuPanelLibrary in a real WinForms project. It includes:

- `MenuDemoForm.cs` - A sample form demonstrating the menu panel integration
- Example of proper implementation and configuration of the library
- Working demonstration of menu functionality

## Running the Demo Application

After cloning the repository from Bitbucket and opening the solution in Visual Studio:

1. Set the WinFormSideMenuControl project as the startup project
   - Right-click on the WinFormSideMenuControl project in Solution Explorer
   - Select "Set as Startup Project"
2. Press F5 or click the "Start" button to run the demo application
3. The demo will show a functional implementation of the side menu panel that you can interact with

This provides a practical example of how to integrate the LeftMenuPanelLibrary into your own WinForms applications.

### Installing Other required Nuget Packages

This Following packages must be installed into your packages
- `C1.AdoNet.Json`
- `FontAwesome.Sharp`
---
## Installing NuGet Packages
To ensure all necessary libraries are available, install the following NuGet packages:
---
### 1. **C1.AdoNet.Json**
This package provides ADO.NET support for JSON data sources.
#### Install via Package Manager Console:
```powershell
Install-Package C1.AdoNet.Json
```
Or via .NET CLI:
```bash
dotnet add package C1.AdoNet.Json
```
### 2. **FontAwesome.Sharp**
This package allows you to use FontAwesome icons in your WinForms app.
#### Install via Package Manager Console:
```powershell
Install-Package FontAwesome.Sharp
```
Or via .NET CLI:
```bash
dotnet add package FontAwesome.Sharp
```

## Usage

### Adding the Control to Your Form

```csharp
using LeftMenuPanelLibrary

namespace YourApplication
{
    public partial class YourApplicationForm : Form
    {
        leftMenuPanel = LeftMenuPanel();

        public YourApplicationForm()
        {
            InitializeComponent();
            LoadLeftPanel();
        }

        private void LoadLeftPanel()
        {
            leftMenuPanel = new LeftMenuPanel()
            {
                Dock = DockStyle.Left,
                ExpandedWidth = 250,
                CollapsedWidth = 60
            }
            this.Controls.Add(leftMenuPanel); // Adds to the UI
            leftMenuPanel.LoadMenu(); // To load the left Menupanel
        }
    }
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
---
## Manually Adding to InitializeComponent 

This guide explains how to integrate the LeftMenuPanel from LeftMenuPanelLibrary into a Windows Forms Application.

## Prerequisites

- Visual Studio
- .NET 6 or later (or compatible WinForms project)
- Reference to LeftMenuPanelLibrary (either DLL or project reference)
- FontAwesome.Sharp NuGet package

## Steps to Add LeftMenuPanel When there is no Drag and Drop leftmenuPanel avaliable

### 1. Add the Required Libraries

### 2. Declare the LeftMenuPanel Control

In the `Form1` partial class (inside `Form1.Designer.cs`), declare the `leftMenuPanel` control:

```csharp
private LeftMenuPanelLibrary.LeftMenuPanel leftMenuPanel;
```

### 3. Initialize the LeftMenuPanel

Inside the `InitializeComponent` method, before setting up `panel1`, create and configure the `leftMenuPanel`:

The InitializeComponent can be viewed by double clicking on it
```csharp
namespace YourApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inside of here, if there is no drag and drop file availiable 
        }
    }
```

Next:

```csharp
//
// leftMenuPanel
//
leftMenuPanel = new LeftMenuPanel();

leftMenuPanel = new LeftMenuPanelLibrary.LeftMenuPanel();
leftMenuPanel.AutoSize = true;
leftMenuPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
leftMenuPanel.CollapsedWidth = 60;
leftMenuPanel.ExpandedWidth = 200;
leftMenuPanel.Dock = DockStyle.Left;
leftMenuPanel.MenuFilePath = "FilePath.JSON"; // Add your actual file path
leftMenuPanel.MenuImagePath = "Folder Name Of Icons"; // Add your actual image folder path
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

Now after that if you go and look into the design folder you will be able to see the UI just like you are doing the drag and drop component

### 6. Build and Run

Run the application. You should see:
* A collapsible left menu on the left.
* Main content panel occupying the rest of the form.

### JSON Structure

The menu data should be structured as follows:

```json
{
  "menu": [
    {
      "title": "Dashboard",
      "icon": "dashboard.png",
      "items": []
    },
    {
      "title": "Users",
      "icon": "users.png",
      "items": [
        {
          "title": "User Management",
          "icon": "user_management.png",
          "items": []
        },
        {
          "title": "User Reports",
          "icon": "user_reports.png",
          "items": []
        }
      ]
    }
  ]
}
```

## Implementation Details

### Core Components

1. **MenuPanel**: The main container for the left menu
2. **MenuItemControl**: Individual menu item controls with icons and text
3. **JsonMenuLoader**: Handles loading and parsing of menu data from JSON
4. **MenuCollapseManager**: Manages the collapse/expand behavior and animations

### Error Handling

The library implements error handling for common scenarios:

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


##  Relational Menu Model

This library uses a **relational data model** to manage hierarchical menu structures, supporting main menu items and nested submenu items with support for multiple depths.

###  How It Works

- The `MenuDataService` class implements the `IMenuReader` interface and reads menu definitions from two separate data tables:
  - **menu** – stores top-level menu entries.
  - **items** – stores child menu items that may be nested further using JSON.

- The `ReadAllMenuItems()` method:
  - Fetches rows from both tables.
  - Parses them into a list of `MenuItemInfo` objects.
  - Orders them by their hierarchical path to maintain panel order.

- Nested children in the `items` table are stored as **JSON arrays** in the `items` field.
  - The parser uses recursive logic (`ParseNestedItems`) to build the full tree structure using parent-child `Path` information.

###  Schema Summary

| Table    | Field         | Description                                |
|----------|---------------|--------------------------------------------|
| `menu`   | `title`       | Display title of the main menu item        |
|          | `icon`        | Icon path or identifier                    |
|          | `ParentJsonPath` | JSON path used for hierarchy              |
|          | `items`       | Optional nested children in JSON format    |
| `items`  | `title`       | Title of a submenu item                    |
|          | `icon`        | Icon for the submenu                      |
|          | `ParentJsonPath` | Path to parent item (e.g., `menu[0].items[0]`) |
|          | `items`       | JSON array of further nested items         |



