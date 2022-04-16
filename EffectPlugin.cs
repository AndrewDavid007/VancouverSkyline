using PaintDotNet;
using PaintDotNet.Effects;
using System.Drawing;

namespace VancouverSkyline
{
    [PluginSupportInfo(typeof(PluginSupportInfo), DisplayName = "VancouverSkyline 15-09-2021")]
    public class EffectPlugin
        : PaintDotNet.Effects.Effect
    {
        public static string StaticName
        {
            get
            {
                return "VancouverSkyline";
            }
        }

        // public static Bitmap StaticIcon
        // {
        //     get
        //     {
        //         return new Bitmap(typeof(EffectPlugin), "EffectPluginIcon.png");
        //     }
        // }
        // 
        // Entire StaticIcon method (above) can be replaced by the line below referencing an icon (png) held in Resources
        //
        public static Bitmap StaticImage { get { return Resources.Icon; } }

        public static string StaticSubMenuName
        {
            get
            {
                // return null; // Use for no submenu
                return SubmenuNames.Render;  // Use for existing submenu
                // return "My SubMenu";     // Use for custom submenu
            }
        }

        public EffectPlugin()
           : base(EffectPlugin.StaticName, EffectPlugin.StaticImage, EffectPlugin.StaticSubMenuName, new EffectOptions() { Flags = EffectFlags.Configurable })
        {

        }

        public override EffectConfigDialog CreateConfigDialog()
        {
            return new EffectPluginConfigDialog();
        }

        public override void Render(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs, Rectangle[] rois, int startIndex, int length)
        {
            _ = EnvironmentParameters.GetSelectionAsPdnRegion();

            for (int i = startIndex; i < startIndex + length; ++i)
            {
                Rectangle rect = rois[i];

                for (int y = rect.Top; y < rect.Bottom; ++y)
                {
                    for (int x = rect.Left; x < rect.Right; ++x)
                    {
                        // Render Code Here
                    }
                }
            }
        }
    }
}
