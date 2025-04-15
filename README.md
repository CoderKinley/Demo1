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

