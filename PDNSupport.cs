using PaintDotNet;
using System;

namespace VancouverSkyline
{
    public class PluginSupportInfo : IPluginSupportInfo
    {
        public string Author
        {
            get
            {
                return "Andrew David - Vancouver";
            }
        }
        public string Copyright
        {
            get
            {
                return "© 2021 CompuDon";
            }
        }

        public string DisplayName
        {
            get
            {
                return "VancouverSkyline";
            }
        }
        public Uri WebsiteUri
        {
            get
            {
                return new Uri("http://www.getpaint.net/redirect/plugins.html");
            }
        }

        Version? IPluginSupportInfo.Version => throw new NotImplementedException();
    }
}