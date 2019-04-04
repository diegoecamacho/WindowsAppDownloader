using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDownloadApp
{

   public enum DownloadLinkEnum
    {
        Default,
        [Description("https://ninite.com/.net4.7.2-7zip-adoptjava8-adoptjavax11-adoptjavax8-air-blender-chrome-discord-everything-firefox-foxit-klitecodecs-krita-notepadplusplus-openoffice-python-revo-shockwave-silverlight-spotify-steam-teamviewer14-teracopy-vscode/ninite.exe")]
        NiniteDefaults,
        [Description("https://www.dm.origin.com/download")]
        Origin,
        [Description("http://ubi.li/4vxt9")]
        UPlay,
        [Description("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi?productName=unrealtournament")]
        EpicGames,
        [Description("https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=16")]
        VisualStudios2019,
        [Description("https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15#")]
        VisualStudios2017,
        /////
        [Description("https://product-downloads.atlassian.com/software/sourcetree/windows/ga/SourceTreeSetup-3.1.2.exe")]
        SourceTree,
        [Description("http://www.perforce.com/downloads/perforce/r18.4/bin.ntx64/p4vinst64.exe")]
        P4V,
        [Description("https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe")]
        UnityHub,
        [Description("http://www.nurgo-software.com/download/AquaSnap.msi")]
        AquaSnap,
        [Description("http://www.nurgo-software.com/download/TidyTabs.msi")]
        TidyTab

    }

    public partial class DownloadCheckbox : CheckBox
    {
        [Category("DownloadLink Enum"), Description("Download Link ENum"),
            Browsable(true), Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Design.UITypeEditor))]
        private DownloadLinkEnum downloadLink = DownloadLinkEnum.Default;

  
        public DownloadLinkEnum DownloadType
        {
            get
            {
                return downloadLink;
            }
            set
            {
                downloadLink = value;
            }
        }

        public DownloadCheckbox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

  
    }
}
