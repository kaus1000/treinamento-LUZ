﻿#pragma checksum "..\..\..\Views\FormularioAluno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "674D4EC3D91B34A2E74326FEC7AF1B2799E3B69F86982121F3E74DF20D179096"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SistemaEscola.Enum;
using SistemaEscola.View;
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


namespace SistemaEscola.View {
    
    
    /// <summary>
    /// FormularioAluno
    /// </summary>
    public partial class FormularioAluno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\Views\FormularioAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StringTextBoxNome;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\FormularioAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StringTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\FormularioAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSerie;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\FormularioAluno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumberTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolApp;component/views/formularioaluno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\FormularioAluno.xaml"
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
            this.StringTextBoxNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\Views\FormularioAluno.xaml"
            this.StringTextBoxNome.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.StringValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StringTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\Views\FormularioAluno.xaml"
            this.StringTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.StringValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboSerie = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.NumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\Views\FormularioAluno.xaml"
            this.NumberTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 75 "..\..\..\Views\FormularioAluno.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

