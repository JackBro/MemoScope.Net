﻿using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Xml.Serialization;
using WinFwk.UITools.Settings.Skins;

namespace WinFwk.UITools.Settings
{
    public class UISettings
    {
        public static UISettings Instance { get; private set; }

        internal static void InitSettings(UISettings uiSettings)
        {
            Instance = uiSettings;
        }

        public UISettings()
        {
            DockStripGradient = new GradientConfig();
            ActiveTabGradient = new GradientConfig();
            InactiveTabGradient = new GradientConfig();

            ActiveCaptionGradient = new GradientConfig();
            InactiveCaptionGradient = new GradientConfig();
        }

        [Category("__Global")]
        [Editor(typeof(SkinTypeEditor), typeof(UITypeEditor))]
        [DisplayName("Select and apply pre set skin")]
        [XmlIgnore]
        public AbstractSkin Skin
        {
            get
            {
                return null;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                value.Apply(this);
            }
        }

        [XmlIgnore]
        [Category("GUI - Main")]
        public Color BackgroundColor { get; set; }
        [Browsable(false)]
        public string BackgroundColorStr
        {
            get
            {
                return WinFwkHelper.ToString(BackgroundColor);
            }
            set
            {
                BackgroundColor = WinFwkHelper.FromString(value);
            }
        }

        [XmlIgnore]
        [Category("GUI - Main")]
        public Color ForegroundColor { get; set; }
        [Browsable(false)]
        public string ForegroundColorStr
        {
            get
            {
                return WinFwkHelper.ToString(ForegroundColor);
            }
            set
            {
                ForegroundColor = WinFwkHelper.FromString(value);
            }
        }

        [Category("GUI - Tables")]
        public bool UseAlternateRowColor { get; set; }
        [XmlIgnore]
        [Category("GUI - Tables")]
        public Color AlternateRowColor { get; set; }
        [Browsable(false)]
        public string AlternateRowColorStr
        {
            get
            {
                return WinFwkHelper.ToString(AlternateRowColor);
            }
            set
            {
                AlternateRowColor = WinFwkHelper.FromString(value);
            }
        }
        [XmlIgnore]
        [Category("GUI - Tables")]
        public Color HeaderBackColor { get; set; }
        [Browsable(false)]
        public string HeaderBackColorStr
        {
            get
            {
                return WinFwkHelper.ToString(HeaderBackColor);
            }
            set
            {
                HeaderBackColor = WinFwkHelper.FromString(value);
            }
        }
        [XmlIgnore]
        [Category("GUI - Tables")]
        public Color HeaderForeColor { get; set; }
        [Browsable(false)]
        public string HeaderForeColorStr
        {
            get
            {
                return WinFwkHelper.ToString(HeaderForeColor);
            }
            set
            {
                HeaderForeColor = WinFwkHelper.FromString(value);
            }
        }
        [XmlIgnore]
        [Category("GUI - Tables")]
        public Color SelectedRowBackgroundColor { get; set; }
        [Browsable(false)]
        public string SelectedRowBackgroundColorStr
        {
            get
            {
                return WinFwkHelper.ToString(SelectedRowBackgroundColor);
            }
            set
            {
                SelectedRowBackgroundColor = WinFwkHelper.FromString(value);
            }
        }
        [XmlIgnore]
        [Category("GUI - Tables")]
        public Color SelectedRowForegroundColor { get; set; }
        [Browsable(false)]
        public string SelectedRowForeColorStr
        {
            get
            {
                return WinFwkHelper.ToString(SelectedRowForegroundColor);
            }
            set
            {
                SelectedRowForegroundColor = WinFwkHelper.FromString(value);
            }
        }

        [Category("DockPanel - Tab")]
        public GradientConfig DockStripGradient { get; set; }

        [Category("DockPanel - Tab")]
        public GradientConfig ActiveTabGradient { get; set; }
        [Category("DockPanel - Tab")]
        public GradientConfig InactiveTabGradient { get; set; }

        [Category("DockPanel - Caption")]
        public GradientConfig ActiveCaptionGradient { get; set; }
        [Category("DockPanel - Caption")]
        public GradientConfig InactiveCaptionGradient { get; set; }
    }
}

