﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.296
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenVPNManager.lang {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenVPNManager.lang.strings", typeof(strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Could not communicate with OpenVPN Manager - perhaps remote control is not allowed? ähnelt.
        /// </summary>
        internal static string ARGS_Error {
            get {
                return ResourceManager.GetString("ARGS_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die -install-autostart   -   Install autostart and quit
        ///-remove-autostart   -   Remove autostart and quit
        ///-connect name   -   Connect to VPN &quot;name&quot;
        ///-disconnect name   -   Disconnect from VPN &quot;name&quot;
        ///-quit   -   Shut down running OpenVPN Manager
        ///
        ///-install   -   install OpenVPNManager service
        ///-uninstall   -   uninstall OpenVPNManager service
        ///-ExecuteServiceAsConsole   -   Run the &apos;service&apos; as a console program ähnelt.
        /// </summary>
        internal static string ARGS_Help {
            get {
                return ResourceManager.GetString("ARGS_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Invalid value &quot;{1}&quot; for argument {0}!
        ///Valid values are:
        ///{2} ähnelt.
        /// </summary>
        internal static string ARGS_Invalid_Parameter {
            get {
                return ResourceManager.GetString("ARGS_Invalid_Parameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Missing value for argument &quot;{0}&quot; ähnelt.
        /// </summary>
        internal static string ARGS_Missing_Parameter {
            get {
                return ResourceManager.GetString("ARGS_Missing_Parameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Unknown argument &quot;{0}&quot; ähnelt.
        /// </summary>
        internal static string ARGS_Unknown_Parameter {
            get {
                return ResourceManager.GetString("ARGS_Unknown_Parameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Could not load Config file. Ignoring! ähnelt.
        /// </summary>
        internal static string BOX_Config_Error {
            get {
                return ResourceManager.GetString("BOX_Config_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Unable to connect!
        ///
        ///Details: ähnelt.
        /// </summary>
        internal static string BOX_Error_Connect {
            get {
                return ResourceManager.GetString("BOX_Error_Connect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Error while loading configuration: ähnelt.
        /// </summary>
        internal static string BOX_Error_Information {
            get {
                return ResourceManager.GetString("BOX_Error_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Could not find smart card. Please insert one and press retry. ähnelt.
        /// </summary>
        internal static string BOX_NoKey {
            get {
                return ResourceManager.GetString("BOX_NoKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Do you want to reconnect to this VPN? ähnelt.
        /// </summary>
        internal static string BOX_Reconnect {
            get {
                return ResourceManager.GetString("BOX_Reconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die These settings are saved in the registry. You can change them with administrator rights.
        ///They are located in HKEY_LOCAL_MACHINE\SOFTWARE\OpenVPN. ähnelt.
        /// </summary>
        internal static string BOX_Service_How_Change {
            get {
                return ResourceManager.GetString("BOX_Service_How_Change", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The OpenVPN service is not installed ähnelt.
        /// </summary>
        internal static string BOX_Service_Not_Installed {
            get {
                return ResourceManager.GetString("BOX_Service_Not_Installed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die OpenVPN Manager and the OpenVPN service are using the same directory.
        ///OpenVPN Manager can&apos;t figure out how the connections should be controlled, so the service control features are deactivated.
        ///Change one of the directories or change the service file extension. ähnelt.
        /// </summary>
        internal static string BOX_Service_Same_Path {
            get {
                return ResourceManager.GetString("BOX_Service_Same_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die In order to edit settings all connection must be closed. Close all connections? ähnelt.
        /// </summary>
        internal static string BOX_Settings_Close {
            get {
                return ResourceManager.GetString("BOX_Settings_Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The update information could not be downloaded ähnelt.
        /// </summary>
        internal static string BOX_UpdateError {
            get {
                return ResourceManager.GetString("BOX_UpdateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The update information hat an invalid format ähnelt.
        /// </summary>
        internal static string BOX_UpdateFormat {
            get {
                return ResourceManager.GetString("BOX_UpdateFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die A new Version (%s) was found. Do you want to see details in your browser? ähnelt.
        /// </summary>
        internal static string BOX_UpdateInformation {
            get {
                return ResourceManager.GetString("BOX_UpdateInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The update information did not contain this program! ähnelt.
        /// </summary>
        internal static string BOX_UpdateMissing {
            get {
                return ResourceManager.GetString("BOX_UpdateMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die No new version was found. ähnelt.
        /// </summary>
        internal static string BOX_UpdateNone {
            get {
                return ResourceManager.GetString("BOX_UpdateNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die The location of the OpenVPN binary changed.
        ///
        ///Please also update the service (using the service tab) if the
        ///service should also use the new location. ähnelt.
        /// </summary>
        internal static string BOX_UpdateService {
            get {
                return ResourceManager.GetString("BOX_UpdateService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Error while starting OpenVPN. Do you want to see its log file? ähnelt.
        /// </summary>
        internal static string BOX_VPN_Error {
            get {
                return ResourceManager.GetString("BOX_VPN_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Error while starting OpenVPN. ähnelt.
        /// </summary>
        internal static string BOX_VPNS_Error {
            get {
                return ResourceManager.GetString("BOX_VPNS_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die disabled ähnelt.
        /// </summary>
        internal static string DIALOG_Disabled {
            get {
                return ResourceManager.GetString("DIALOG_Disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die enabled ähnelt.
        /// </summary>
        internal static string DIALOG_Enabled {
            get {
                return ResourceManager.GetString("DIALOG_Enabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die All files ähnelt.
        /// </summary>
        internal static string DIALOG_Filter_Allfiles {
            get {
                return ResourceManager.GetString("DIALOG_Filter_Allfiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Applications ähnelt.
        /// </summary>
        internal static string DIALOG_Filter_Application {
            get {
                return ResourceManager.GetString("DIALOG_Filter_Application", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &amp;Copy IP ähnelt.
        /// </summary>
        internal static string DIALOG_IP_Copy {
            get {
                return ResourceManager.GetString("DIALOG_IP_Copy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die service ähnelt.
        /// </summary>
        internal static string DIALOG_Service {
            get {
                return ResourceManager.GetString("DIALOG_Service", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Select OpenVPN configuration directory ähnelt.
        /// </summary>
        internal static string DIALOG_Title_Folder {
            get {
                return ResourceManager.GetString("DIALOG_Title_Folder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Search OpenVPN ähnelt.
        /// </summary>
        internal static string DIALOG_Title_Open_OpenVPN {
            get {
                return ResourceManager.GetString("DIALOG_Title_Open_OpenVPN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Connect (Alt+O) ähnelt.
        /// </summary>
        internal static string QUICKINFO_Connect {
            get {
                return ResourceManager.GetString("QUICKINFO_Connect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Disconnect (Alt+O) ähnelt.
        /// </summary>
        internal static string QUICKINFO_Disconnect {
            get {
                return ResourceManager.GetString("QUICKINFO_Disconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die An Update is available! ähnelt.
        /// </summary>
        internal static string QUICKINFO_Update {
            get {
                return ResourceManager.GetString("QUICKINFO_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die See the &quot;about&quot; Dialog for more information. ähnelt.
        /// </summary>
        internal static string QUICKINFO_Update_More {
            get {
                return ResourceManager.GetString("QUICKINFO_Update_More", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Connected ähnelt.
        /// </summary>
        internal static string STATE_Connected {
            get {
                return ResourceManager.GetString("STATE_Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Connecting ähnelt.
        /// </summary>
        internal static string STATE_Connecting {
            get {
                return ResourceManager.GetString("STATE_Connecting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Disconnected ähnelt.
        /// </summary>
        internal static string STATE_Disconnected {
            get {
                return ResourceManager.GetString("STATE_Disconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Initializing... ähnelt.
        /// </summary>
        internal static string STATE_Initializing {
            get {
                return ResourceManager.GetString("STATE_Initializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Stopped ähnelt.
        /// </summary>
        internal static string STATE_Stopped {
            get {
                return ResourceManager.GetString("STATE_Stopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Stopping... ähnelt.
        /// </summary>
        internal static string STATE_Stopping {
            get {
                return ResourceManager.GetString("STATE_Stopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Error ähnelt.
        /// </summary>
        internal static string STETE_Error {
            get {
                return ResourceManager.GetString("STETE_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &amp;Connect ähnelt.
        /// </summary>
        internal static string TRAY_Connect {
            get {
                return ResourceManager.GetString("TRAY_Connect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &amp;Disconnect ähnelt.
        /// </summary>
        internal static string TRAY_Disconnect {
            get {
                return ResourceManager.GetString("TRAY_Disconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &amp;Edit ähnelt.
        /// </summary>
        internal static string TRAY_Edit {
            get {
                return ResourceManager.GetString("TRAY_Edit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Show &amp;error information ähnelt.
        /// </summary>
        internal static string TRAY_Error_Information {
            get {
                return ResourceManager.GetString("TRAY_Error_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &amp;Show ähnelt.
        /// </summary>
        internal static string TRAY_Show {
            get {
                return ResourceManager.GetString("TRAY_Show", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Adding routes... ähnelt.
        /// </summary>
        internal static string VPNSTATE_ADD_ROUTES {
            get {
                return ResourceManager.GetString("VPNSTATE_ADD_ROUTES", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Assigning IP... ähnelt.
        /// </summary>
        internal static string VPNSTATE_ASSIGN_IP {
            get {
                return ResourceManager.GetString("VPNSTATE_ASSIGN_IP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Authenticating... ähnelt.
        /// </summary>
        internal static string VPNSTATE_AUTH {
            get {
                return ResourceManager.GetString("VPNSTATE_AUTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Connected ähnelt.
        /// </summary>
        internal static string VPNSTATE_CONNECTED {
            get {
                return ResourceManager.GetString("VPNSTATE_CONNECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Connecting... ähnelt.
        /// </summary>
        internal static string VPNSTATE_CONNECTING {
            get {
                return ResourceManager.GetString("VPNSTATE_CONNECTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Exiting... ähnelt.
        /// </summary>
        internal static string VPNSTATE_EXITING {
            get {
                return ResourceManager.GetString("VPNSTATE_EXITING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Downloading config... ähnelt.
        /// </summary>
        internal static string VPNSTATE_GET_CONFIG {
            get {
                return ResourceManager.GetString("VPNSTATE_GET_CONFIG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Reconnecting... ähnelt.
        /// </summary>
        internal static string VPNSTATE_RECONNECTING {
            get {
                return ResourceManager.GetString("VPNSTATE_RECONNECTING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Waiting for Server... ähnelt.
        /// </summary>
        internal static string VPNSTATE_WAIT {
            get {
                return ResourceManager.GetString("VPNSTATE_WAIT", resourceCulture);
            }
        }
    }
}
