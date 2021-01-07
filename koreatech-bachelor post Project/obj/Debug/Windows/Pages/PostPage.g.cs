﻿#pragma checksum "..\..\..\..\Windows\Pages\PostPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0B04C420539F2A623227B761B2C78898E77DF8EA5EEF4C2C5118B265C2644B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using koreatech_bachelor_Post_Project.Windows.Pages;


namespace koreatech_bachelor_Post_Project.Windows.Pages {
    
    
    /// <summary>
    /// PostPage
    /// </summary>
    public partial class PostPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 84 "..\..\..\..\Windows\Pages\PostPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PostListView;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Windows\Pages\PostPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PresentPageText;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\Windows\Pages\PostPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MaxPageText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/koreatech-bachelor Post Project;component/windows/pages/postpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Pages\PostPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 42 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NormalNoticeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 49 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ScholarshipNoticeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 56 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BachelorNoticeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 63 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HireNoticeButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 70 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CoronaNoticeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PostListView = ((System.Windows.Controls.ListView)(target));
            
            #line 86 "..\..\..\..\Windows\Pages\PostPage.xaml"
            this.PostListView.SizeChanged += new System.Windows.SizeChangedEventHandler(this.PostListView_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 122 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PageBackButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PresentPageText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 130 "..\..\..\..\Windows\Pages\PostPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PageNextButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MaxPageText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

