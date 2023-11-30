using Syncfusion.Maui.ImageEditor;

namespace ShowSaveEdit_ToolBars;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var bottomToolbar = this.imageEditor.Toolbars[1];

        ImageEditorToolbarItem? penToolbarItem = (ImageEditorToolbarItem?)bottomToolbar.ToolbarItems.FirstOrDefault(x => x.Name == "Pen");
        if (penToolbarItem != null)
        {
            penToolbarItem.SubToolbars[0].ToolbarItems.Add(new ImageEditorToolbarItem { Name = "SaveEdit" });
        }

        ImageEditorToolbarItem? textToolbarItem = (ImageEditorToolbarItem?)bottomToolbar.ToolbarItems.FirstOrDefault(x => x.Name == "Text");
        if (textToolbarItem != null)
        {
            textToolbarItem.SubToolbars[0].ToolbarItems.Add(new ImageEditorToolbarItem { Name = "SaveEdit" });
        }

        ImageEditorToolbarItem? shapeToolbarItem = (ImageEditorToolbarItem?)bottomToolbar.ToolbarItems.FirstOrDefault(x => x.Name == "Shape");
        if (shapeToolbarItem != null)
        {
            ImageEditorToolbarItem? shapeItem = (ImageEditorToolbarItem?)shapeToolbarItem.SubToolbars[0].ToolbarItems.FirstOrDefault();
            if (shapeItem != null)
            {
                shapeItem.SubToolbars[0].ToolbarItems.Add(new ImageEditorToolbarItem { Name = "SaveEdit" });
            }
        }
    }
}